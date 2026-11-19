# PR 132117 without boolean imports

Experiment: remove the importer registrations and switch cases for `All`, `Any`, `None` and their three `WhereAllBitsSet` forms. Count, IndexOf, LastIndexOf and their all-bits-set imports remain. No other JIT changes.

Source: PR head `e8ea6fced00eb152330971ff3817692e1ca07e1e`; baseline main parent `00236714c28b30ae2522b348d11315e509cf4425`. Experimental worktree: `/tmp/pr132117-perf-no-bools`. See [patch](remove-bool-imports.patch).

## SuperPMI assembly comparison

Nine local Linux ARM64 collections matching JIT/EE `213c3e7f-f472-4ee7-9003-47e23afb035f`. Release JITs; both variants compared against the same baseline. These are generated code bytes, not JIT binary size or compilation-time measurements. This is not the cross-platform CI collection set.

| Collection | Full PR FullOpts delta | Without booleans FullOpts delta | Change from removal |
|---|---:|---:|---:|
| aspire.nativeaot.linux.arm64.checked.mch | +60 | +60 | +0 |
| aspnet2.run.linux.arm64.checked.mch | +276 | +276 | +0 |
| coreclr_tests.run.linux.arm64.checked.mch | +804 | +804 | +0 |
| libraries.crossgen2.linux.arm64.checked.mch | +0 | +0 | +0 |
| libraries.pmi.linux.arm64.checked.mch | -48 | -48 | +0 |
| libraries_tests.run.linux.arm64.Release.mch | +15,776 | +15,776 | +0 |
| libraries_tests_no_tiered_compilation.run.linux.arm64.Release.mch | +1,088 | +260 | -828 |
| realworld.run.linux.arm64.checked.mch | +60 | +60 | +0 |
| smoke_tests.nativeaot.linux.arm64.checked.mch | +76 | +76 | +0 |

| Mode | Full PR vs main | Without booleans vs main | Reduction |
|---|---:|---:|---:|
| FullOpts | +18,092 bytes | +17,264 bytes | 828 bytes (4.6% of growth) |
| MinOpts | +21,444 bytes | +11,588 bytes | 9,856 bytes (46.0% of growth) |
| Overall | +39,536 bytes | +28,852 bytes | 10,684 bytes (27.0% of growth) |

Replay counts: {'base': Counter({'Successful compiles': 2816625, 'Missing compiles': 656, 'Failing compiles': 0}), 'full': Counter({'Successful compiles': 2816587, 'Missing compiles': 694, 'Failing compiles': 0}), 'stripped': Counter({'Successful compiles': 2816587, 'Missing compiles': 694, 'Failing compiles': 0})}. Missing replay data exists, so totals apply to the successfully compared contexts. Both comparisons have identical baseline counts and baseline byte totals per collection/mode and identical missing counts between the two candidates. Most size savings are in MinOpts library-test code; FullOpts savings occur in the non-tiered library-test collection.

## Direct-helper and span harness

744 cases: the previous 456 direct-helper cases plus 144 boolean all-bits-set cases and 144 span caller cases. Five rotated process passes per JIT, 10 ms per case per pass, CPU 5 (Cortex-X925), Release JITs, tiering and ReadyToRun disabled. Same runtime/CoreLib/framework libraries, swapping only the JIT. Custom Stopwatch harness, not BenchmarkDotNet. All correctness checks passed on all three variants.

Screening rule: median differs by more than 5% and the five observed ranges do not overlap. This is not a statistical significance test.

Without boolean imports versus full PR: {'no clear change': 744}.

Representative last-lane int cases:

| Case | Main ns | Full PR ns | Without booleans ns |
|---|---:|---:|---:|
| V64_int_Count_last | 0.764 | 0.548 | 0.548 |
| V128_int_Count_last | 0.709 | 0.550 | 0.550 |
| V64_int_IndexOf_last | 0.865 | 0.776 | 0.776 |
| V128_int_IndexOf_last | 0.811 | 0.776 | 0.776 |
| V64_int_LastIndexOf_last | 0.761 | 0.671 | 0.671 |
| V128_int_LastIndexOf_last | 0.753 | 0.671 | 0.670 |
| V128_int_Any_last | 0.655 | 0.656 | 0.655 |
| V128_int_AllWhereAllBitsSet_last | 0.648 | 0.648 | 0.648 |
| V128_int_NoneWhereAllBitsSet_last | 0.648 | 0.648 | 0.648 |

Disassembly: 740 of 744 benchmark wrappers have identical instructions/operands and size after masking process-specific addresses. Differences: ['V64_float_All_nan', 'V64_double_All_nan', 'V128_float_All_nan', 'V128_double_All_nan']. Those four constant-NaN All wrappers shrink from 92 to 88 bytes. All count/index wrappers and span wrappers are unchanged.

## Existing dotnet/performance benchmarks

Full PR is the baseline for this comparison. Unmodified Span<T>.IndexOfValue and LastIndexOfValue benchmarks, byte/char/int at lengths 4/33/512/3000. BenchmarkDotNet, five warmups, 15 iterations at 100 ms, one launch per side, CPU 5; 5% Mann–Whitney comparison threshold. Same suite revision as the previous investigation.

BDN classifications: {'Same': 24}. Flagged rows: []. Full reports: `bdn/results/`.

## Validation and reproduction

The PR’s existing VectorHelperApis regression test passes (return 100) on main, full PR and stripped JIT. Experimental source passes git diff --check. The comparison does not test other architectures or measure Tier0/startup performance. Code-size savings in MinOpts do not by themselves establish a startup-speed improvement.

- Patch and rebuild: `bash prepare.sh` (expects the baseline runtime and full PR JIT from the previous experiment).
- SuperPMI: `bash run-spmi.sh` (expects the nine locally cached matching collections).
- Harness: `python3 run.py`; disassembly: `PERF_MS=1 python3 disasm.py`.
- Standard suite: `bash run-bdn.sh`.
- Summary: `python3 analyze.py`.

Original PR worktree and branch are unchanged; changes exist only in the experimental worktree and saved patch.
