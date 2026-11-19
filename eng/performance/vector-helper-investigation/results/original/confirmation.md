
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
