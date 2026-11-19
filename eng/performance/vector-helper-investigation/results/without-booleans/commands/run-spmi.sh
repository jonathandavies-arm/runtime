#!/usr/bin/env bash
set -euo pipefail
cd /home/jondav01/projects/dotnet/runtime-perf
out="$PWD/artifacts/local/pr132117-perf/no-bools"
collections="$PWD/artifacts/spmi/stackalloc-rebase-20261116/mch/213c3e7f-f472-4ee7-9003-47e23afb035f.linux.arm64"
export PATH="$PWD/.dotnet:$HOME/.dotnet/tools:$PATH"
for variant in head no-bools; do
 python3 src/coreclr/scripts/superpmi.py asmdiffs -arch arm64 -build_type Release \
  -core_root "$PWD/artifacts/bin/coreclr/linux.arm64.Checked" \
  -base_jit_path /tmp/pr132117-perf-base/artifacts/bin/coreclr/linux.arm64.Release/libclrjit.so \
  -diff_jit_path /tmp/pr132117-perf-$variant/artifacts/bin/coreclr/linux.arm64.Release/libclrjit.so \
  -mch_files "$collections"/*.mch --parallelism 16 --summary_as_json \
  -spmi_location "$out/spmi-$variant" -log_level info > "$out/spmi-$variant.log" 2>&1
done
