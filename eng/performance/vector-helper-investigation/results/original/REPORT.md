# PR 132117 ARM64 performance screening

Latest PR head `e8ea6fced00eb152330971ff3817692e1ca07e1e` versus its main parent `00236714c28b30ae2522b348d11315e509cf4425`.

Cortex-X925, CPU 5; Release JITs built with the same compiler and options. Both sides use the same baseline CoreCLR and CoreLib, with SDK 12.0.100-alpha.1.26557.102 framework assemblies. Tiered compilation and ReadyToRun disabled. Five separate processes per side, alternating order. Custom Stopwatch harness (not BenchmarkDotNet), 10 ms per case per process, batched calls; timings include loop and array access overhead. Each case checks its result before timing.

600 cases: Vector64/128 byte/short/int/long/float/double Count/IndexOf/LastIndexOf/Any/All/None and three all-bits-set helpers; absent/first/last/all matches and floating NaNs. Span byte/short/int IndexOf/LastIndexOf/Count at lengths 16/64/256/4096.

Screening flag: median change exceeds 5% and the five-sample ranges do not overlap. This is not a statistical significance test. Small timings and differences need longer targeted confirmation. Larger code is not necessarily slower.

## V: 456 cases
143 clearly faster, 1 clearly slower by the screening rule; 312 unclassified.

| Case | Base ns | PR ns | Change |
|---|---:|---:|---:|
| V64_byte_CountWhereAllBitsSet_last | 0.842 | 0.551 | -34.5% |
| V64_byte_CountWhereAllBitsSet_first | 0.842 | 0.551 | -34.5% |
| V64_byte_CountWhereAllBitsSet_absent | 0.843 | 0.552 | -34.5% |
| V64_byte_CountWhereAllBitsSet_all | 0.842 | 0.552 | -34.4% |
| V64_byte_Count_absent | 0.819 | 0.540 | -34.1% |
| V64_short_CountWhereAllBitsSet_last | 0.843 | 0.556 | -34.1% |
| V64_short_CountWhereAllBitsSet_absent | 0.843 | 0.555 | -34.1% |
| V64_short_CountWhereAllBitsSet_all | 0.842 | 0.555 | -34.1% |
| V64_short_CountWhereAllBitsSet_first | 0.841 | 0.556 | -33.9% |
| V64_int_CountWhereAllBitsSet_absent | 0.779 | 0.554 | -28.9% |
| V128_double_Count_nan | 0.270 | 0.286 | +6.0% |

## Span: 144 cases
0 clearly faster, 3 clearly slower by the screening rule; 141 unclassified.

| Case | Base ns | PR ns | Change |
|---|---:|---:|---:|
| Span_byte_256_IndexOf_absent | 5.359 | 5.734 | +7.0% |
| Span_byte_4096_IndexOf_last | 89.986 | 95.949 | +6.6% |
| Span_byte_64_IndexOf_absent | 2.191 | 2.321 | +5.9% |

Raw samples: `base-0.csv` through `base-4.csv`, `head-0.csv` through `head-4.csv`. All cases and observed ranges are in `comparison.csv`. Reproduce with `setup.sh` (expects the two worktrees at `/tmp/pr132117-perf-{base,head}`).


## Longer confirmation

Ten alternating processes per side, 150 ms per case per process (15 times the initial sample duration).

| Case | Base median ns | PR median ns | Change | Sample ranges separate |
|---|---:|---:|---:|---|
| V64_byte_Count_absent | 0.815 | 0.537 | -34.1% | True |
| V128_byte_Count_all | 0.726 | 0.568 | -21.8% | True |
| V128_double_Count_nan | 0.286 | 0.286 | +0.0% | False |
| Span_byte_64_IndexOf_absent | 2.193 | 2.192 | -0.0% | False |
| Span_byte_256_IndexOf_absent | 5.388 | 5.384 | -0.1% | False |
| Span_byte_4096_IndexOf_last | 88.576 | 88.376 | -0.2% | False |

Disassembly confirms that the byte Count helpers replace mask extraction and population count with a shift and horizontal add. V64 byte Count wrapper shrinks from 208 to 184 bytes; V128 byte Count wrapper from 140 to 128 bytes. These sizes include the benchmark loop.

The three span cases and the double-NaN Count case flagged as slower produce identical normalized benchmark instructions and code size on both sides. Their timing differences therefore do not establish an instruction-level regression; process layout, caller code outside the disassembled wrapper, cache state, and measurement variation remain possible causes.

This screening demonstrates direct-helper improvements on Cortex-X925. It does not demonstrate end-to-end application gains or justify all CI code-size growth. BenchmarkDotNet and other ARM64 cores remain useful follow-up work.
