from pathlib import Path
import subprocess,os
p=Path(__file__).resolve().parent
for v in ['base','head','no-bools']:
 env=os.environ.copy();env.update(CORE_ROOT=str(p/v),DOTNET_TieredCompilation='0',DOTNET_ReadyToRun='0',DOTNET_JitDisasm='Bench:V* Bench:Span*',DOTNET_JitStdOutFile=str(p/f'{v}-disasm.txt'))
 with open(p/f'{v}-disasm-timing-unused.csv','w') as out:
  subprocess.run([str(p/v/'corerun'),str(p/'bin/Bench.dll')],env=env,stdout=out,check=True)
