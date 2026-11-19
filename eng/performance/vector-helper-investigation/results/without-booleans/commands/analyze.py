from pathlib import Path
import csv,json,statistics as st,collections,re
p=Path(__file__).resolve().parent
full=json.load(open(p/'spmi-head/diff_summary.json'))[2]
strip=json.load(open(p/'spmi-no-bools/diff_summary.json'))[2]
lines=['# PR 132117 without boolean imports','','Experiment: remove the importer registrations and switch cases for `All`, `Any`, `None` and their three `WhereAllBitsSet` forms. Count, IndexOf, LastIndexOf and their all-bits-set imports remain. No other JIT changes.','','Source: PR head `e8ea6fced00eb152330971ff3817692e1ca07e1e`; baseline main parent `00236714c28b30ae2522b348d11315e509cf4425`. Experimental worktree: `/tmp/pr132117-perf-no-bools`. See [patch](remove-bool-imports.patch).','','## SuperPMI assembly comparison','','Nine local Linux ARM64 collections matching JIT/EE `213c3e7f-f472-4ee7-9003-47e23afb035f`. Release JITs; both variants compared against the same baseline. These are generated code bytes, not JIT binary size or compilation-time measurements. This is not the cross-platform CI collection set.','','| Collection | Full PR FullOpts delta | Without booleans FullOpts delta | Change from removal |','|---|---:|---:|---:|']
totals={v:collections.Counter() for v in ['full','stripped']};missing={v:collections.Counter() for v in ['base','full','stripped']};collections_csv=[]
for x,y in zip(full,strip):
 assert x[0]==y[0]
 for section in ['Overall','FullOpts','MinOpts']:
  for k in ['Successful compiles','Missing compiles','Failing compiles','Diffed contexts','Diffed code bytes']:
   assert x[1][section][k]==y[1][section][k],(x[0],section,k)
 for v,b in [('full',x[2]),('stripped',y[2])]:
  for section in ['Overall','FullOpts','MinOpts']:totals[v][section]+=b[section]['Diffed code bytes']-x[1][section]['Diffed code bytes']
 for v,b in [('base',x[1]),('full',x[2]),('stripped',y[2])]:
  for k in ['Successful compiles','Missing compiles','Failing compiles']:missing[v][k]+=b['Overall'][k]
 f=x[2]['FullOpts']['Diffed code bytes']-x[1]['FullOpts']['Diffed code bytes'];s=y[2]['FullOpts']['Diffed code bytes']-y[1]['FullOpts']['Diffed code bytes']
 lines.append(f'| {x[0]} | {f:+,} | {s:+,} | {s-f:+,} |');collections_csv.append(dict(collection=x[0],full_fullopts_delta=f,stripped_fullopts_delta=s))
lines+=['','| Mode | Full PR vs main | Without booleans vs main | Reduction |','|---|---:|---:|---:|']
for section in ['FullOpts','MinOpts','Overall']:
 f=totals['full'][section];s=totals['stripped'][section];lines.append(f'| {section} | {f:+,} bytes | {s:+,} bytes | {f-s:,} bytes ({100*(f-s)/f:.1f}% of growth) |')
lines+=['',f'Replay counts: {dict(missing)}. Missing replay data exists, so totals apply to the successfully compared contexts. Both comparisons have identical baseline counts and baseline byte totals per collection/mode and identical missing counts between the two candidates. Most size savings are in MinOpts library-test code; FullOpts savings occur in the non-tiered library-test collection.','','## Direct-helper and span harness','','744 cases: the previous 456 direct-helper cases plus 144 boolean all-bits-set cases and 144 span caller cases. Five rotated process passes per JIT, 10 ms per case per pass, CPU 5 (Cortex-X925), Release JITs, tiering and ReadyToRun disabled. Same runtime/CoreLib/framework libraries, swapping only the JIT. Custom Stopwatch harness, not BenchmarkDotNet. All correctness checks passed on all three variants.','','Screening rule: median differs by more than 5% and the five observed ranges do not overlap. This is not a statistical significance test.']
data={v:[{r['case']:float(r['ns']) for r in csv.DictReader(open(p/f'{v}-{i}.csv'))} for i in range(5)] for v in ['base','head','no-bools']};rows=[];flags=collections.Counter()
for n in data['head'][0]:
 samples={v:[r[n] for r in data[v]] for v in data};medians={v:st.median(a) for v,a in samples.items()};a=samples['head'];b=samples['no-bools'];pct=100*(medians['no-bools']/medians['head']-1)
 flag='faster' if pct < -5 and max(b)<min(a) else 'slower' if pct>5 and min(b)>max(a) else 'no clear change';flags[flag]+=1
 rows.append(dict(case=n,base_ns=medians['base'],full_ns=medians['head'],stripped_ns=medians['no-bools'],stripped_vs_full_pct=pct,screening=flag))
with open(p/'performance-comparison.csv','w') as f:
 w=csv.DictWriter(f,fieldnames=rows[0].keys());w.writeheader();w.writerows(rows)
lines+=['',f'Without boolean imports versus full PR: {dict(flags)}.','','Representative last-lane int cases:','','| Case | Main ns | Full PR ns | Without booleans ns |','|---|---:|---:|---:|']
for n in ['V64_int_Count_last','V128_int_Count_last','V64_int_IndexOf_last','V128_int_IndexOf_last','V64_int_LastIndexOf_last','V128_int_LastIndexOf_last','V128_int_Any_last','V128_int_AllWhereAllBitsSet_last','V128_int_NoneWhereAllBitsSet_last']:
 r=next(r for r in rows if r['case']==n);lines.append(f"| {n} | {r['base_ns']:.3f} | {r['full_ns']:.3f} | {r['stripped_ns']:.3f} |")
def disasm(v):
 d={}
 for c in (p/f'{v}-disasm.txt').read_text().split('; Assembly listing for method ')[1:]:
  n=c.split('(')[0].split(':')[-1];ls=[]
  for l in c.splitlines():
   if re.match(r'^\s+[a-z][a-z0-9.]+\s',l) or 'Total bytes' in l:
    l=re.sub(r'0x[0-9A-Fa-f]{10,}','ADDRESS',l.strip())
    if re.match(r'mov[zk]\s+x\d+,',l):l=re.sub(r'#0x[0-9A-Fa-f]+','#ADDRESS_PART',l)
    ls.append(l)
  d[n]=ls
 return d
asm1=disasm('head');asm2=disasm('no-bools');changed=[n for n in asm1 if asm1[n]!=asm2[n]]
lines+=['',f'Disassembly: {len(asm1)-len(changed)} of {len(asm1)} benchmark wrappers have identical instructions/operands and size after masking process-specific addresses. Differences: {changed}. Those four constant-NaN All wrappers shrink from 92 to 88 bytes. All count/index wrappers and span wrappers are unchanged.','','## Existing dotnet/performance benchmarks','','Full PR is the baseline for this comparison. Unmodified Span<T>.IndexOfValue and LastIndexOfValue benchmarks, byte/char/int at lengths 4/33/512/3000. BenchmarkDotNet, five warmups, 15 iterations at 100 ms, one launch per side, CPU 5; 5% Mann–Whitney comparison threshold. Same suite revision as the previous investigation.']
files=list((p/'bdn/results').glob('*-report.csv'))
if len(files)==3:
 counter=collections.Counter();flagged=[]
 for f in files:
  for r in csv.DictReader(open(f)):
   if '/no-bools/' in r['Toolchain']:
    counter[r['MannWhitney(5%)']]+=1
    if r['MannWhitney(5%)']!='Same':flagged.append((f.name,r['Method'],r['Size'],r['Ratio'],r['MannWhitney(5%)']))
 lines+=['',f'BDN classifications: {dict(counter)}. Flagged rows: {flagged}. Full reports: `bdn/results/`.']
else:lines+=['','BenchmarkDotNet run pending; rerun this analyzer when complete.']
lines+=['','## Validation and reproduction','','The PR’s existing VectorHelperApis regression test passes (return 100) on main, full PR and stripped JIT. Experimental source passes git diff --check. The comparison does not test other architectures or measure Tier0/startup performance. Code-size savings in MinOpts do not by themselves establish a startup-speed improvement.','','- Patch and rebuild: `bash prepare.sh` (expects the baseline runtime and full PR JIT from the previous experiment).','- SuperPMI: `bash run-spmi.sh` (expects the nine locally cached matching collections).','- Harness: `python3 run.py`; disassembly: `PERF_MS=1 python3 disasm.py`.','- Standard suite: `bash run-bdn.sh`.','- Summary: `python3 analyze.py`.','','Original PR worktree and branch are unchanged; changes exist only in the experimental worktree and saved patch.']
(p/'REPORT.md').write_text('\n'.join(lines)+'\n');print('Wrote',p/'REPORT.md');print('Performance',dict(flags))
