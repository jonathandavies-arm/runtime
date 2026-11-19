#!/usr/bin/env python3
# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.
"""Stage one shared runtime with two JITs and run the helper investigation."""
import argparse
import csv
from datetime import datetime, timezone
import hashlib
import json
import os
from pathlib import Path
import shutil
import subprocess

HERE = Path(__file__).resolve().parent
REPO = HERE.parents[2]


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--core-root', required=True, type=Path,
                        help='Matching runnable runtime directory, including corerun and CoreLib')
    parser.add_argument('--baseline-jit', required=True, type=Path)
    parser.add_argument('--candidate-jit', required=True, type=Path)
    parser.add_argument('--framework-dir', type=Path,
                        help='Optional matching framework assemblies/native libraries; Core_Root takes precedence')
    parser.add_argument('--dotnet', type=Path, default=REPO / '.dotnet/dotnet')
    parser.add_argument('--output', type=Path)
    parser.add_argument('--cpu', type=int, default=5)
    parser.add_argument('--passes', type=int, default=5)
    parser.add_argument('--duration-ms', type=int, default=10)
    parser.add_argument('--filter', help='Exact generated case names separated by |')
    parser.add_argument('--disasm', action='store_true', help='Also collect diffable disassembly; do not use these timings')
    args = parser.parse_args()
    if args.passes < 1 or args.duration_ms < 1:
        parser.error('passes and duration-ms must be positive')
    if args.cpu not in os.sched_getaffinity(0):
        parser.error('selected CPU is outside this process affinity')
    core = args.core_root.resolve()
    dotnet = args.dotnet.resolve()
    for file in [core / 'corerun', core / 'libcoreclr.so', core / 'System.Private.CoreLib.dll',
                 args.baseline_jit, args.candidate_jit, dotnet]:
        if not file.is_file():
            parser.error(f'missing required file: {file}')
    output = (args.output or REPO / 'artifacts/vector-helper-perf' /
              datetime.now(timezone.utc).strftime('%Y%m%d-%H%M%S')).resolve()
    if output.exists() and any(output.iterdir()):
        parser.error(f'output directory must be empty: {output}')
    output.mkdir(parents=True, exist_ok=True)
    subprocess.run([str(dotnet), 'build', str(HERE / 'Bench.csproj'), '-c', 'Release',
                    '-o', str(output / 'bin')], cwd=REPO, check=True)
    jit_paths = {'base': args.baseline_jit.resolve(), 'current': args.candidate_jit.resolve()}
    metadata = {'cpu': args.cpu, 'passes': args.passes, 'duration_ms': args.duration_ms,
                'filter': args.filter, 'disasm': args.disasm, 'core_root': str(core),
                'framework_dir': str(args.framework_dir), 'jit_paths': {k: str(v) for k, v in jit_paths.items()},
                'sha256': {}}
    for variant, jit in jit_paths.items():
        dest = output / variant
        dest.mkdir()
        for source in ([args.framework_dir.resolve()] if args.framework_dir else []) + [core]:
            for file in source.iterdir():
                if file.is_file():
                    shutil.copy2(file, dest / file.name)
        shutil.copy2(jit, dest / 'libclrjit.so')
        if not (dest / 'System.Runtime.dll').is_file():
            parser.error('staged runtime lacks System.Runtime.dll; supply --framework-dir')
        metadata['sha256'][variant] = {
            name: hashlib.sha256((dest / name).read_bytes()).hexdigest()
            for name in ['libcoreclr.so', 'System.Private.CoreLib.dll', 'libclrjit.so']}
    (output / 'run.json').write_text(json.dumps(metadata, indent=2) + '\n')
    env = os.environ.copy()
    for name in ['CORE_ROOT', 'PERF_FILTER', 'DOTNET_JitDisasm', 'DOTNET_JitStdOutFile']:
        env.pop(name, None)
    env.update(DOTNET_TieredCompilation='0', DOTNET_ReadyToRun='0', PERF_MS=str(args.duration_ms))
    if args.filter:
        env['PERF_FILTER'] = args.filter
    for rep in range(args.passes):
        for variant in (['base', 'current'] if rep % 2 == 0 else ['current', 'base']):
            print(f'Pass {rep + 1}: {variant}', flush=True)
            env['CORE_ROOT'] = str(output / variant)
            if args.disasm:
                env.update(DOTNET_JitDisasm='Bench:V* Bench:Span*', DOTNET_JitDisasmDiffable='1',
                           DOTNET_JitStdOutFile=str(output / f'{variant}-{rep}.dasm'))
            with (output / f'{variant}-{rep}.csv').open('w') as stdout, \
                    (output / f'{variant}-{rep}.err').open('w') as stderr:
                subprocess.run(['taskset', '-c', str(args.cpu), str(output / variant / 'corerun'),
                                str(output / 'bin/Bench.dll')], env=env, stdout=stdout,
                               stderr=stderr, check=True)
            with (output / f'{variant}-{rep}.csv').open() as stream:
                if not any(csv.DictReader(stream)):
                    raise RuntimeError('No cases ran; check --filter')
    print(f'Results: {output}')


if __name__ == '__main__':
    main()
