#!/usr/bin/env python3
# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.
"""Summarize custom harness CSV samples (a screening rule, not a statistical test)."""
import argparse
import collections
import csv
from pathlib import Path
import statistics


def read_passes(folder, prefix):
    files = sorted(folder.glob(f'{prefix}-[0-9]*.csv'))
    if not files:
        raise ValueError(f'no pass CSVs for {prefix} in {folder}')
    samples = []
    for file in files:
        with file.open() as stream:
            rows = list(csv.DictReader(stream))
        sample = {r['case']: float(r['ns']) for r in rows}
        if not sample or len(sample) != len(rows):
            raise ValueError(f'empty or duplicate cases in {file}')
        if samples and sample.keys() != samples[0].keys():
            raise ValueError(f'case set differs in {file}')
        samples.append(sample)
    return samples


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('results', type=Path)
    parser.add_argument('--baseline', default='base')
    parser.add_argument('--candidate', default='current')
    args = parser.parse_args()
    folder = args.results.resolve()
    baseline = read_passes(folder, args.baseline)
    candidate = read_passes(folder, args.candidate)
    if baseline[0].keys() != candidate[0].keys():
        raise ValueError('baseline and candidate case sets differ')
    output = []
    groups = collections.defaultdict(collections.Counter)
    for case in baseline[0]:
        base = [p[case] for p in baseline]
        diff = [p[case] for p in candidate]
        bm, dm = statistics.median(base), statistics.median(diff)
        change = 100 * (dm / bm - 1)
        result = ('faster' if change < -5 and max(diff) < min(base) else
                  'slower' if change > 5 and min(diff) > max(base) else 'no clear change')
        family = case.split('_')[2] if case.startswith('V') else 'Span'
        groups[family][result] += 1
        output.append(dict(case=case, baseline_ns=bm, candidate_ns=dm, change_pct=change,
                           classification=result, baseline_min=min(base), baseline_max=max(base),
                           candidate_min=min(diff), candidate_max=max(diff)))
    with (folder / 'comparison.csv').open('w') as stream:
        writer = csv.DictWriter(stream, fieldnames=output[0].keys())
        writer.writeheader()
        writer.writerows(output)
    lines = ['# Custom harness screening', '',
             f'{len(output)} cases; {len(baseline)} baseline and {len(candidate)} candidate process passes.', '',
             'Flags require >5% median change and no overlap between observed ranges. '
             'This is not a statistical significance or equivalence test. Confirm flagged results '
             'with longer runs and inspect the assembly.', '',
             '| Family | Faster | Slower | No clear change |', '|---|---:|---:|---:|']
    for family, counts in groups.items():
        lines.append(f"| {family} | {counts['faster']} | {counts['slower']} | {counts['no clear change']} |")
    (folder / 'SCREENING.md').write_text('\n'.join(lines) + '\n')
    print('\n'.join(lines))


if __name__ == '__main__':
    main()
