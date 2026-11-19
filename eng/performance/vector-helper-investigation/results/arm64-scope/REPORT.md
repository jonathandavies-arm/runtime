# ARM64-only validation

[Scope and build details](README.md) · [Patch](arm64-only.patch)

| Target | Comparison | Collections | Paired contexts | Raw diff contexts | Base/diff missing records |
|---|---|---:|---:|---:|---:|
| arm64-only | Full PR → ARM64-only | 9 | 2,816,581 | 0 | 700 / 694 |
| windows-x64 | Main → ARM64-only | 1 | 33,800 | 0 | 0 / 0 |
| linux-x64 | Main → ARM64-only | 1 | 31,466 | 0 | 0 / 0 |
| windows-x86 | Main → ARM64-only | 1 | 30,603 | 3299 | 0 / 0 |

Windows x86 reported 3,299 raw binary-diff contexts, with zero code-size change. All 3,299 were replayed with diffable disassembly; the complete disassembly output is byte-for-byte identical (33,833,254 bytes each). See `x86-disasm-comparison.txt` and `check-x86-disasm.py`.

ARM64: nine collections. Windows/Linux x64: NativeAOT smoke collections. Windows x86: real-world collection, when available. Missing records are excluded; these checks do not reproduce the full CI collection set.

The 744 ARM64 benchmark wrappers are identical to the full PR, and existing PR regression tests pass. No throughput measurements were repeated for this scope-only change. Boolean imports remain enabled on ARM64.
