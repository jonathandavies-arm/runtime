# ARM64-only scope change for PR 132117

Local branch: `upstream/sve/common-vector-routines-arm64-only`
Worktree: `/tmp/pr132117-perf-arm64-only`
Based on PR head `e8ea6fced00eb152330971ff3817692e1ca07e1e`.

The twelve new vector helper registrations and their importer code are compiled only for `TARGET_ARM64`. Xarch-specific mask/count/index code in the new imports is removed. `Any`, `All`, `None` and their all-bits-set forms remain enabled on ARM64, so the earlier boolean-removal experiment stays separate.

The patch is `arm64-only.patch`. Source files: `src/coreclr/jit/hwintrinsic.cpp` and `src/coreclr/jit/hwintrinsiclist.h` in the worktree. `git diff --check` passes.

Builds passed for the native ARM64 JIT and the alljits target, including cross-JITs for Linux x64, Windows x64/x86, ARM32 and WebAssembly. The build uses Release and `-DFEATURE_DYNAMIC_CODE_COMPILED=1`.

All 744 ARM64 benchmark wrappers are identical to the full PR after normalizing process-specific addresses. All harness correctness checks and the existing PR VectorHelperApis regression test pass. The timing output of these disassembly runs is not used as benchmark evidence; there was no reason to repeat timing once identical code was established.

`run-spmi.sh` compares full PR versus ARM64-only on nine cached Linux ARM64 collections. `run-cross-spmi.sh` compares matching-main cross-JITs versus ARM64-only on available x64/x86 collections. These local checks do not replace the full CI collection set. The ARM64 collections have missing replay data; results cover successful comparisons only.

The Jira link requires authentication in the available web tool. The Jira ID was verified from Gerrit commit metadata; the ticket body was not read. The GitHub UTF-16 discussion motivates the ARM64 optimization.
