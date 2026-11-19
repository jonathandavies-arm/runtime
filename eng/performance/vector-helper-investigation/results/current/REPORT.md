# Performance recheck: 05cea1dca36

Current commit: `05cea1dca36` (Restrict Vector helper imports to Arm64). Baseline main: `00236714c28b30ae2522b348d11315e509cf4425`. The current JIT was rebuilt from this workspace. Boolean imports remain enabled on ARM64.

Cortex-X925, CPU 5; identical baseline runtime, CoreLib and framework assemblies with only libclrjit.so changed. Tiered compilation and ReadyToRun disabled. Binary hashes are saved in `binary-sha256.txt`.

## Custom harness

744 cases, five alternating process passes per side, 10 ms per case per pass. Custom Stopwatch measurements; not BenchmarkDotNet. Result checks run before timing. Screening flags require >5% median change and non-overlapping observed ranges, not a formal significance test.

| Family | Faster | Slower | No clear change |
|---|---:|---:|---:|
| Count | 24 | 0 | 28 |
| IndexOf | 9 | 0 | 43 |
| LastIndexOf | 24 | 0 | 28 |
| Any | 0 | 0 | 52 |
| All | 0 | 0 | 52 |
| None | 0 | 0 | 52 |
| CountWhereAllBitsSet | 32 | 0 | 16 |
| IndexOfWhereAllBitsSet | 24 | 0 | 24 |
| LastIndexOfWhereAllBitsSet | 28 | 0 | 20 |
| AnyWhereAllBitsSet | 0 | 0 | 48 |
| AllWhereAllBitsSet | 0 | 0 | 48 |
| NoneWhereAllBitsSet | 0 | 0 | 48 |
| Span | 0 | 1 | 143 |

Representative last-lane integer matches:

| Case | Baseline ns | Current ns | Change |
|---|---:|---:|---:|
| V64_int_Count_last | 0.764 | 0.548 | -28.3% |
| V64_int_IndexOf_last | 0.865 | 0.776 | -10.3% |
| V64_int_LastIndexOf_last | 0.761 | 0.670 | -11.9% |
| V128_int_Count_last | 0.710 | 0.550 | -22.5% |
| V128_int_IndexOf_last | 0.811 | 0.776 | -4.2% |
| V128_int_LastIndexOf_last | 0.753 | 0.671 | -10.9% |

Full results and sample ranges: `custom-comparison.csv`. Gains on these microbenchmarks do not establish application-level gains.

## dotnet/performance

Unmodified System.Memory.Span<T>.IndexOfValue and LastIndexOfValue, byte/char/int, lengths 4/33/512/3000 (24 cases). BenchmarkDotNet with five warmups, 15 measured iterations at 100 ms, three process launches per runtime/case, comparison threshold 5%. Suite commit `262db8039904ac2836fa9640f6b4d351f94118fc`.

Classifications: {'Same': 23, 'Slower': 1}.

| Type | Method | Size | Baseline ns | Current ns | Change | BDN classification |
|---|---|---:|---:|---:|---:|---|
| Span_Byte_ | IndexOfValue | 3000 | 30.201 | 31.275 | +3.6% | Same |
| Span_Byte_ | IndexOfValue | 33 | 2.107 | 2.115 | +0.4% | Same |
| Span_Byte_ | IndexOfValue | 4 | 2.059 | 2.067 | +0.4% | Same |
| Span_Byte_ | IndexOfValue | 512 | 6.215 | 6.155 | -1.0% | Same |
| Span_Byte_ | LastIndexOfValue | 3000 | 30.566 | 30.015 | -1.8% | Same |
| Span_Byte_ | LastIndexOfValue | 33 | 2.262 | 2.282 | +0.9% | Same |
| Span_Byte_ | LastIndexOfValue | 4 | 1.830 | 1.881 | +2.8% | Same |
| Span_Byte_ | LastIndexOfValue | 512 | 6.073 | 5.985 | -1.4% | Same |
| Span_Char_ | IndexOfValue | 3000 | 60.071 | 59.067 | -1.7% | Same |
| Span_Char_ | IndexOfValue | 33 | 2.269 | 2.261 | -0.4% | Same |
| Span_Char_ | IndexOfValue | 4 | 2.323 | 2.317 | -0.3% | Same |
| Span_Char_ | IndexOfValue | 512 | 11.289 | 11.476 | +1.7% | Same |
| Span_Char_ | LastIndexOfValue | 3000 | 73.397 | 73.217 | -0.2% | Same |
| Span_Char_ | LastIndexOfValue | 33 | 2.607 | 2.615 | +0.3% | Same |
| Span_Char_ | LastIndexOfValue | 4 | 1.906 | 1.906 | +0.0% | Same |
| Span_Char_ | LastIndexOfValue | 512 | 12.185 | 12.047 | -1.1% | Same |
| Span_Int32_ | IndexOfValue | 3000 | 124.274 | 123.200 | -0.9% | Same |
| Span_Int32_ | IndexOfValue | 33 | 2.760 | 2.760 | +0.0% | Same |
| Span_Int32_ | IndexOfValue | 4 | 1.822 | 1.823 | +0.1% | Same |
| Span_Int32_ | IndexOfValue | 512 | 21.476 | 21.084 | -1.8% | Same |
| Span_Int32_ | LastIndexOfValue | 3000 | 139.775 | 139.887 | +0.1% | Same |
| Span_Int32_ | LastIndexOfValue | 33 | 3.073 | 3.066 | -0.2% | Same |
| Span_Int32_ | LastIndexOfValue | 4 | 1.895 | 2.016 | +6.4% | Slower |
| Span_Int32_ | LastIndexOfValue | 512 | 23.231 | 23.241 | +0.0% | Same |

## Longer check of the custom span flag

Span<byte>.LastIndexOf, length 64, first element matches. Five rotated process passes, 250 ms per pass. Original means full PR e8ea6fced00; current is the ARM64-only commit.

| Variant | Median ns | Observed min | Observed max |
|---|---:|---:|---:|
| base | 2.862 | 2.862 | 2.864 |
| original | 2.826 | 2.825 | 2.835 |
| current | 2.825 | 2.812 | 2.827 |

The initial custom screening slowdown did not reproduce in this longer check. Original PR and current commit have essentially the same timing here, about 1.3% below baseline. Raw samples are saved as confirmation-{variant}-{pass}.csv. This separate input is not covered by the standard suite midpoint-match cases.

Commands: `run.py` stages runtimes and runs the custom harness; `run-bdn.sh` runs the standard suite; `analyze.py` writes this report. Initial build log: `build.log`. All outputs are saved in this directory.
