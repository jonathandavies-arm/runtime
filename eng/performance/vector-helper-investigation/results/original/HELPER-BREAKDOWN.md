# Performance by helper family

PR e8ea6fced00 versus matching main 00236714c28; Cortex-X925. This analysis combines the original 456-case direct-helper screening with new longer runs of 21 representative cases.

## Longer representative checks

Five alternating process launches per side, 150 ms per case per launch; same runtime and CoreLib, only JIT changed. Custom Stopwatch harness, not BenchmarkDotNet. Table reports median time change; negative means faster. All nonzero integer count/search gains below have non-overlapping observed ranges, including the 4.3% result.

Integer inputs, match in the last lane:

| Helper | Vector64<int> | Vector128<int> |
|---|---:|---:|
| Count | -34.9% | -22.5% |
| IndexOf | -10.3% | -4.3% |
| LastIndexOf | -11.9% | -10.9% |
| Any | -0.0% | +0.0% |
| All | +0.0% | -0.0% |
| None | -0.0% | +0.0% |
| CountWhereAllBitsSet | -28.8% | -22.2% |
| IndexOfWhereAllBitsSet | -10.0% | -5.9% |
| LastIndexOfWhereAllBitsSet | -11.7% | -8.5% |

Additional controls: Vector128 long/float/double Count with the same match placement were unchanged. Gains depend on element type and lowering path.

## Full initial screening

Screening rule: more than 5% median change and no overlap among five process samples. These are screening flags, not statistical significance claims.

| Helper | Cases | Faster | Initially slower |
|---|---:|---:|---:|
| Count | 52 | 24 | 1 |
| IndexOf | 52 | 11 | 0 |
| LastIndexOf | 52 | 24 | 0 |
| Any | 52 | 0 | 0 |
| All | 52 | 0 | 0 |
| None | 52 | 0 | 0 |
| CountWhereAllBitsSet | 48 | 32 | 0 |
| IndexOfWhereAllBitsSet | 48 | 24 | 0 |
| LastIndexOfWhereAllBitsSet | 48 | 28 | 0 |

The one initial slower Count/NaN flag disappeared in the previous longer confirmation. Any/None benchmark instruction sequences were identical on both sides; All was identical except four constant-NaN cases with minor register/loop changes and no measured gain.

## Assembly evidence

Vector128<int> LastIndexOf wrapper grew from 136 to 144 bytes while its longer-run time improved by 10.9%. Its lowering replaces mask extraction, transfer to a general register, and leading-zero count with a vector select and horizontal minimum before extracting the result. This demonstrates that a larger sequence can run faster for this case. Wrapper sizes include the measurement loop.

Count uses a shorter vector shift/horizontal-add sequence instead of mask extraction and population count.

## Limits and attribution

These measurements distinguish which API calls improved when switching the entire PR JIT on and off. They do not isolate interactions between individual implementation changes; that would require JIT builds with each helper family enabled separately.

The unchanged dotnet/performance span benchmarks remain a different workload: 23 of 24 unchanged at the 5% threshold and a length-4 Span<int>.LastIndexOfValue regression confirmed at 5.8%. A faster direct LastIndexOf helper does not guarantee every inlined span caller improves.

The harness does not cover every supported element type, every input, or other ARM64 CPUs. Any/All/NoneWhereAllBitsSet are not measured by these direct cases. No recommendation to remove those imports follows from these results alone.

Reproduce representative runs with `python3 helper-confirm.py`; source generator: `generate.py`; raw files: `helper-confirm-{base,head}-{0..4}.csv`. Disassembly: `base-disasm.txt` and `head-disasm.txt`.
