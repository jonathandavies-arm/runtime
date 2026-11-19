from pathlib import Path
import json,os,subprocess
p=Path(__file__).resolve().parent
rows=json.load(open(p/'spmi-windows-x86/diff_summary.json'))[2][0][3]
contexts=p/'x86-diff-contexts.mcl';contexts.write_text(''.join(r['Context']+'\n' for r in sorted(rows,key=lambda r:int(r['Context']))))
mch=next((p/'windows-x86').rglob('*.mch'));tool=Path.cwd()/'artifacts/bin/coreclr/linux.arm64.Checked/superpmi'
for v in ['base','arm64-only']:
 out=p/f'x86-{v}-all-diffs.dasm'
 if out.exists():out.unlink()
 env=os.environ.copy();env.update(DOTNET_JitEnableNoWayAssert='1',DOTNET_JitNoForceFallback='1',DOTNET_JitAlignLoops='0',DOTNET_JitDisasm='*',DOTNET_JitDisasmDiffable='1',DOTNET_JitStdOutFile=str(out))
 with open(p/f'x86-{v}-disasm-replay.log','w') as log:
  subprocess.run([str(tool),'-target','x86','-c',str(contexts),f'/tmp/pr132117-perf-{v}/artifacts/bin/coreclr/linux.arm64.Release/libclrjit_win_x86_arm64.so',str(mch)],env=env,stdout=log,stderr=log,check=True)
a=(p/'x86-base-all-diffs.dasm').read_bytes();b=(p/'x86-arm64-only-all-diffs.dasm').read_bytes();result=f'{len(rows)} raw-diff contexts replayed; diffable disassembly identical: {a==b}; bytes {len(a)} / {len(b)}\n';print(result);(p/'x86-disasm-comparison.txt').write_text(result)
