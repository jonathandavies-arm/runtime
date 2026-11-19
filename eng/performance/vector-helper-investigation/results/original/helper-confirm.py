from pathlib import Path
import os,subprocess
p=Path(__file__).resolve().parent
names=[f'V{width}_int_{op}_last' for width in [64,128] for op in ['Count','IndexOf','LastIndexOf','Any','All','None','CountWhereAllBitsSet','IndexOfWhereAllBitsSet','LastIndexOfWhereAllBitsSet']]+['V128_float_Count_last','V128_double_Count_last','V128_long_Count_last']
env=os.environ.copy();env.update(DOTNET_TieredCompilation='0',DOTNET_ReadyToRun='0',PERF_MS='150',PERF_FILTER='|'.join(names))
for i in range(5):
 for v in (['base','head'] if i%2==0 else ['head','base']):
  env['CORE_ROOT']=str(p/v)
  with open(p/f'helper-confirm-{v}-{i}.csv','w') as f:subprocess.run(['taskset','-c','5',str(p/v/'corerun'),str(p/'bin/Bench.dll')],env=env,stdout=f,check=True)
