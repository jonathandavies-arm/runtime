from pathlib import Path
import os,subprocess,shutil,json
repo=Path.cwd();out=Path(__file__).resolve().parent
runtime=Path('/tmp/pr132117-perf-base/artifacts/bin/coreclr/linux.arm64.Release')
libs=repo/'.dotnet/shared/Microsoft.NETCore.App/12.0.0-alpha.1.26557.102'
jits={'base':runtime/'libclrjit.so','current':repo/'artifacts/bin/coreclr/linux.arm64.Release/libclrjit.so'}
for v,jit in jits.items():
 dest=out/v;dest.mkdir(exist_ok=True)
 for src in [libs,runtime]:
  for f in src.iterdir():
   if f.is_file():shutil.copy2(f,dest/f.name)
 shutil.copy2(jit,dest/'libclrjit.so')
env=os.environ.copy();env.update(DOTNET_TieredCompilation='0',DOTNET_ReadyToRun='0')
for rep in range(5):
 for v in (['base','current'] if rep%2==0 else ['current','base']):
  env['CORE_ROOT']=str(out/v);print(rep,v,flush=True)
  with open(out/f'{v}-{rep}.csv','w') as f,open(out/f'{v}-{rep}.err','w') as e:
   subprocess.run(['taskset','-c','5',str(out/v/'corerun'),str(out.parent/'no-bools/bin/Bench.dll')],env=env,stdout=f,stderr=e,check=True)
