#!/usr/bin/env bash
set -euo pipefail
repo=/home/jondav01/projects/dotnet/runtime-perf
perf=/home/jondav01/projects/dotnet/performance
out="$repo/artifacts/local/pr132117-perf/no-bools"
cd "$perf"
unset CORE_ROOT
export DOTNET_TieredCompilation=0 DOTNET_ReadyToRun=0
export PATH="$repo/.dotnet:$PATH"
taskset -c 5 "$repo/.dotnet/dotnet" "$perf/artifacts/bin/MicroBenchmarks/Release/net12.0/MicroBenchmarks.dll" \
 --filter '*System.Memory.Span*IndexOfValue*' '*System.Memory.Span*LastIndexOfValue*' \
 --coreRun "$repo/artifacts/local/pr132117-perf/no-bools/head/corerun" "$repo/artifacts/local/pr132117-perf/no-bools/no-bools/corerun" \
 --cli "$repo/.dotnet/dotnet" --artifacts "$out/bdn" \
 --warmupCount 5 --iterationCount 15 --iterationTime 100 --launchCount 1 \
 --exporters json csv markdown --statisticalTest '5%'
