from pathlib import Path
import csv,statistics as st,json
p=Path(__file__).resolve().parent
data={v:[{r['case']:float(r['ns']) for r in csv.DictReader(open(p/f'{v}-{i}.csv'))} for i in range(5)] for v in ['base','head']}
rows=[]
for name in data['base'][0]:
 b=[x[name] for x in data['base']];h=[x[name] for x in data['head']];bm=st.median(b);hm=st.median(h)
 pct=(hm/bm-1)*100; clear=max(h)<min(b) or min(h)>max(b)
 rows.append(dict(case=name,base_ns=bm,head_ns=hm,change_pct=pct,ranges_separate=clear,base_min=min(b),base_max=max(b),head_min=min(h),head_max=max(h)))
with open(p/'comparison.csv','w') as f:
 w=csv.DictWriter(f,fieldnames=rows[0].keys());w.writeheader();w.writerows(rows)
lines=['# PR 132117 ARM64 performance screening','','Latest PR head `e8ea6fced00eb152330971ff3817692e1ca07e1e` versus its main parent `00236714c28b30ae2522b348d11315e509cf4425`.','','Cortex-X925, CPU 5; Release JITs built with the same compiler and options. Both sides use the same baseline CoreCLR and CoreLib, with SDK 12.0.100-alpha.1.26557.102 framework assemblies. Tiered compilation and ReadyToRun disabled. Five separate processes per side, alternating order. Custom Stopwatch harness (not BenchmarkDotNet), 10 ms per case per process, batched calls; timings include loop and array access overhead. Each case checks its result before timing.','','600 cases: Vector64/128 byte/short/int/long/float/double Count/IndexOf/LastIndexOf/Any/All/None and three all-bits-set helpers; absent/first/last/all matches and floating NaNs. Span byte/short/int IndexOf/LastIndexOf/Count at lengths 16/64/256/4096.','','Screening flag: median change exceeds 5% and the five-sample ranges do not overlap. This is not a statistical significance test. Small timings and differences need longer targeted confirmation. Larger code is not necessarily slower.','']
for group in ['V','Span']:
 rs=[r for r in rows if r['case'].startswith(group)]
 faster=[r for r in rs if r['change_pct'] < -5 and r['ranges_separate']];slower=[r for r in rs if r['change_pct'] > 5 and r['ranges_separate']]
 lines += [f'## {group}: {len(rs)} cases',f'{len(faster)} clearly faster, {len(slower)} clearly slower by the screening rule; {len(rs)-len(faster)-len(slower)} unclassified.','','| Case | Base ns | PR ns | Change |','|---|---:|---:|---:|']
 for r in sorted(faster,key=lambda r:r['change_pct'])[:10]+sorted(slower,key=lambda r:-r['change_pct'])[:10]:lines.append(f"| {r['case']} | {r['base_ns']:.3f} | {r['head_ns']:.3f} | {r['change_pct']:+.1f}% |")
 lines+=['']
lines+=['Raw samples: `base-0.csv` through `base-4.csv`, `head-0.csv` through `head-4.csv`. All cases and observed ranges are in `comparison.csv`. Reproduce with `setup.sh` (expects the two worktrees at `/tmp/pr132117-perf-{base,head}`).']
(p/'REPORT.md').write_text('\n'.join(lines)+'\n')
print('\n'.join(lines))
