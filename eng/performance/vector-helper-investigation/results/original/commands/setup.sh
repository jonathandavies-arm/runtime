#!/usr/bin/env bash
set -euo pipefail
repo=/home/jondav01/projects/dotnet/runtime-perf
cd "$repo"
test -d /tmp/pr132117-perf-base || git worktree add --detach /tmp/pr132117-perf-base 00236714c28b30ae2522b348d11315e509cf4425
test -d /tmp/pr132117-perf-head || git worktree add --detach /tmp/pr132117-perf-head e8ea6fced00eb152330971ff3817692e1ca07e1e
test -e /tmp/pr132117-perf-base/.dotnet || ln -s "$repo/.dotnet" /tmp/pr132117-perf-base/.dotnet
for side in base head; do
  /tmp/pr132117-perf-$side/src/coreclr/build-runtime.sh -arm64 -release -ninja -component jit -numproc 10 -cmakeargs '-DFEATURE_DYNAMIC_CODE_COMPILED=1'
done
/tmp/pr132117-perf-base/src/coreclr/build-runtime.sh -arm64 -release -ninja -component runtime -numproc 16 -cmakeargs '-DFEATURE_DYNAMIC_CODE_COMPILED=1'
/tmp/pr132117-perf-base/build.sh -s clr.corelib+clr.nativecorelib -c Release
python3 artifacts/local/pr132117-perf/generate.py
.dotnet/dotnet build artifacts/local/pr132117-perf/Bench.csproj -c Release -o artifacts/local/pr132117-perf/bin
python3 artifacts/local/pr132117-perf/run.py
python3 artifacts/local/pr132117-perf/disasm.py
python3 artifacts/local/pr132117-perf/analyze.py
python3 artifacts/local/pr132117-perf/confirm.py
