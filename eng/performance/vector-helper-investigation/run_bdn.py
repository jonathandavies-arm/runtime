#!/usr/bin/env python3
# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.
"""Run the existing dotnet/performance span selection with two staged CoreRuns."""
import argparse
import json
import os
from pathlib import Path
import subprocess

HERE = Path(__file__).resolve().parent
REPO = HERE.parents[2]


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--performance-repo', required=True, type=Path)
    parser.add_argument('--runtimes', required=True, type=Path, help='run.py output containing base/ and current/')
    parser.add_argument('--output', required=True, type=Path)
    parser.add_argument('--dotnet', type=Path, default=REPO / '.dotnet/dotnet')
    parser.add_argument('--cpu', type=int, default=5)
    parser.add_argument('--launches', type=int, default=3)
    args = parser.parse_args()
    perf, runtimes, output = (p.resolve() for p in [args.performance_repo, args.runtimes, args.output])
    dll = perf / 'artifacts/bin/MicroBenchmarks/Release/net12.0/MicroBenchmarks.dll'
    dotnet = args.dotnet.resolve()
    for file in [dll, dotnet, runtimes / 'base/corerun', runtimes / 'current/corerun']:
        if not file.is_file():
            parser.error(f'missing file: {file}; see README.md for the build command')
    if args.launches < 1 or args.cpu not in os.sched_getaffinity(0):
        parser.error('launches must be positive and CPU must be in this process affinity')
    if output.exists() and any(output.iterdir()):
        parser.error('output directory must be empty')
    output.mkdir(parents=True, exist_ok=True)
    env = os.environ.copy()
    env.pop('CORE_ROOT', None)
    env.update(DOTNET_TieredCompilation='0', DOTNET_ReadyToRun='0')
    env['PATH'] = str(dotnet.parent) + os.pathsep + env.get('PATH', '')
    command = ['taskset', '-c', str(args.cpu), str(dotnet), str(dll),
               '--filter', '*System.Memory.Span*IndexOfValue*', '*System.Memory.Span*LastIndexOfValue*',
               '--coreRun', str(runtimes / 'base/corerun'), str(runtimes / 'current/corerun'),
               '--cli', str(dotnet), '--artifacts', str(output / 'bdn'),
               '--warmupCount', '5', '--iterationCount', '15', '--iterationTime', '100',
               '--launchCount', str(args.launches), '--exporters', 'json', 'csv', 'markdown',
               '--statisticalTest', '5%']
    (output / 'command.json').write_text(json.dumps(command, indent=2) + '\n')
    subprocess.run(command, cwd=perf, env=env, check=True)


if __name__ == '__main__':
    main()
