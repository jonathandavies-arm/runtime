from pathlib import Path
import os,subprocess,json,time,shutil
p=Path(__file__).resolve().parent
root=Path('/tmp/pr132117-perf-base/artifacts/bin/coreclr/linux.arm64.Release')
libs=Path.cwd()/'.dotnet/shared/Microsoft.NETCore.App/12.0.0-alpha.1.26557.102'
for variant in ['base','head']:
 dest=p/variant;dest.mkdir(exist_ok=True)
 for src in [libs,root]:
  for f in src.iterdir():
   if f.is_file():
    d=dest/f.name
    if d.is_symlink():d.unlink()
    shutil.copy2(f,d)
 shutil.copy2(root/'System.Private.CoreLib.dll',dest/'System.Private.CoreLib.dll')
 runner=dest/'corerun'
 if runner.is_symlink():runner.unlink()
 shutil.copy2(root/'corerun',runner)
 jit=dest/'libclrjit.so';jit.unlink();shutil.copy2(f'/tmp/pr132117-perf-{variant}/artifacts/bin/coreclr/linux.arm64.Release/libclrjit.so',jit)
env=os.environ.copy();env.update(DOTNET_TieredCompilation='0',DOTNET_ReadyToRun='0')
cpu=5;print('CPU',cpu,flush=True)
for rep in range(5):
 for variant in (['base','head'] if rep%2==0 else ['head','base']):
  print(rep,variant,flush=True)
  env["CORE_ROOT"]=str(p/variant)
  with open(p/f'{variant}-{rep}.csv','w') as out,open(p/f'{variant}-{rep}.err','w') as err:
   subprocess.run(['taskset','-c',str(cpu),str(p/variant/'corerun'),str(p/'bin/Bench.dll')],env=env,stdout=out,stderr=err,check=True)
