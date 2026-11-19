from pathlib import Path
import csv,statistics as st,collections,json
p=Path(__file__).resolve().parent
samples={v:[{r['case']:float(r['ns']) for r in csv.DictReader(open(p/f'{v}-{i}.csv'))} for i in range(5)] for v in ['base','current']}
rows=[];families=collections.defaultdict(collections.Counter)
for n in samples['base'][0]:
 b=[r[n] for r in samples['base']];c=[r[n] for r in samples['current']];bm=st.median(b);cm=st.median(c);pct=100*(cm/bm-1)
 flag='faster' if pct < -5 and max(c)<min(b) else 'slower' if pct>5 and min(c)>max(b) else 'no clear change'
 family=n.split('_')[2] if n.startswith('V') else 'Span';families[family][flag]+=1
 rows.append(dict(case=n,baseline_ns=bm,current_ns=cm,change_pct=pct,classification=flag,baseline_min=min(b),baseline_max=max(b),current_min=min(c),current_max=max(c)))
with open(p/'custom-comparison.csv','w') as f:
 w=csv.DictWriter(f,fieldnames=rows[0].keys());w.writeheader();w.writerows(rows)
lines=['# Performance recheck: 05cea1dca36','','Current commit: `05cea1dca36` (Restrict Vector helper imports to Arm64). Baseline main: `00236714c28b30ae2522b348d11315e509cf4425`. The current JIT was rebuilt from this workspace. Boolean imports remain enabled on ARM64.','','Cortex-X925, CPU 5; identical baseline runtime, CoreLib and framework assemblies with only libclrjit.so changed. Tiered compilation and ReadyToRun disabled. Binary hashes are saved in `binary-sha256.txt`.','','## Custom harness','','744 cases, five alternating process passes per side, 10 ms per case per pass. Custom Stopwatch measurements; not BenchmarkDotNet. Result checks run before timing. Screening flags require >5% median change and non-overlapping observed ranges, not a formal significance test.','','| Family | Faster | Slower | No clear change |','|---|---:|---:|---:|']
for family,counts in families.items():lines.append(f"| {family} | {counts['faster']} | {counts['slower']} | {counts['no clear change']} |")
lines+=['','Representative last-lane integer matches:','','| Case | Baseline ns | Current ns | Change |','|---|---:|---:|---:|']
for width in [64,128]:
 for op in ['Count','IndexOf','LastIndexOf']:
  n=f'V{width}_int_{op}_last';r=next(r for r in rows if r['case']==n);lines.append(f"| {n} | {r['baseline_ns']:.3f} | {r['current_ns']:.3f} | {r['change_pct']:+.1f}% |")
lines+=['','Full results and sample ranges: `custom-comparison.csv`. Gains on these microbenchmarks do not establish application-level gains.','','## dotnet/performance','','Unmodified System.Memory.Span<T>.IndexOfValue and LastIndexOfValue, byte/char/int, lengths 4/33/512/3000 (24 cases). BenchmarkDotNet with five warmups, 15 measured iterations at 100 ms, three process launches per runtime/case, comparison threshold 5%. Suite commit `262db8039904ac2836fa9640f6b4d351f94118fc`.']
files=list((p/'results/results').glob('*-report.csv'))
if len(files)==3:
 pairs={};counts=collections.Counter();br=[]
 for f in files:
  for r in csv.DictReader(open(f)):
   key=(f.stem.replace('System.Memory.','').replace('-report',''),r['Method'],r['Size']);pairs.setdefault(key,{})['current' if '/current/' in r['Toolchain'] else 'base']=r
 for (typ,method,size),pair in sorted(pairs.items()):
  b=pair['base'];c=pair['current'];result=c['MannWhitney(5%)'];counts[result]+=1
  bn=float(b['Mean'].split()[0]);cn=float(c['Mean'].split()[0]);br.append(dict(type=typ,method=method,size=size,baseline_ns=bn,current_ns=cn,change_pct=100*(cn/bn-1),classification=result))
 with open(p/'bdn-comparison.csv','w') as f:
  w=csv.DictWriter(f,fieldnames=br[0].keys());w.writeheader();w.writerows(br)
 lines+=['',f'Classifications: {dict(counts)}.','','| Type | Method | Size | Baseline ns | Current ns | Change | BDN classification |','|---|---|---:|---:|---:|---:|---|']
 for r in br:lines.append(f"| {r['type']} | {r['method']} | {r['size']} | {r['baseline_ns']:.3f} | {r['current_ns']:.3f} | {r['change_pct']:+.1f}% | {r['classification']} |")
else:lines+=['','Run is still in progress; rerun analyze.py when all three reports are available.']
if (p/'confirmation-current-4.csv').exists():
 lines+=['','## Longer check of the custom span flag','','Span<byte>.LastIndexOf, length 64, first element matches. Five rotated process passes, 250 ms per pass. Original means full PR e8ea6fced00; current is the ARM64-only commit.','','| Variant | Median ns | Observed min | Observed max |','|---|---:|---:|---:|']
 for v in ['base','original','current']:
  vals=[float(next(csv.DictReader(open(p/f'confirmation-{v}-{i}.csv')))['ns']) for i in range(5)]
  lines.append(f'| {v} | {st.median(vals):.3f} | {min(vals):.3f} | {max(vals):.3f} |')
 lines+=['','The initial custom screening slowdown did not reproduce in this longer check. Original PR and current commit have essentially the same timing here, about 1.3% below baseline. Raw samples are saved as confirmation-{variant}-{pass}.csv. This separate input is not covered by the standard suite midpoint-match cases.']
lines+=['','Commands: `run.py` stages runtimes and runs the custom harness; `run-bdn.sh` runs the standard suite; `analyze.py` writes this report. Initial build log: `build.log`. All outputs are saved in this directory.']
(p/'REPORT.md').write_text('\n'.join(lines)+'\n');print('\n'.join(lines))
