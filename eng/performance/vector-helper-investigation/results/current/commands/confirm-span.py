from pathlib import Path
import subprocess,os,csv,statistics as st
p=Path(__file__).resolve().parent
runtimes={'base':p/'base','current':p/'current','original':p.parent/'arm64-only/head'}
env=os.environ.copy();env.update(DOTNET_TieredCompilation='0',DOTNET_ReadyToRun='0',PERF_MS='250',PERF_FILTER='Span_byte_64_LastIndexOf_first')
for rep in range(5):
 names=list(runtimes);names=names[rep%3:]+names[:rep%3]
 for v in names:
  env['CORE_ROOT']=str(runtimes[v])
  with open(p/f'confirmation-{v}-{rep}.csv','w') as f:
   subprocess.run(['taskset','-c','5',str(runtimes[v]/'corerun'),str(p.parent/'no-bools/bin/Bench.dll')],env=env,stdout=f,check=True)
for v in runtimes:
 vals=[float(next(csv.DictReader(open(p/f'confirmation-{v}-{i}.csv')))['ns']) for i in range(5)]
 print(v,st.median(vals),min(vals),max(vals),flush=True)
