#!/usr/bin/env bash
set -euo pipefail
cd /home/jondav01/projects/dotnet/runtime-perf
out="$PWD/artifacts/local/pr132117-perf/no-bools"
wt=/tmp/pr132117-perf-no-bools
test -d "$wt" || git worktree add --detach "$wt" e8ea6fced00eb152330971ff3817692e1ca07e1e
if git -C "$wt" diff --quiet; then
 git -C "$wt" apply "$out/remove-bool-imports.patch"
else
 git -C "$wt" diff | cmp - "$out/remove-bool-imports.patch"
fi
"$wt/src/coreclr/build-runtime.sh" -arm64 -release -ninja -component jit -numproc 16 -cmakeargs '-DFEATURE_DYNAMIC_CODE_COMPILED=1'
python3 "$out/generate.py"
.dotnet/dotnet build "$out/Bench.csproj" -c Release -o "$out/bin"
