using System; using System.Diagnostics; using System.Runtime.CompilerServices; using System.Runtime.Intrinsics; class Bench { static int sink;
static Vector64<byte>[] dV64_byte_Count_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_byte_Count_absent[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_Count_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_byte_Count_first[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_Count_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_byte_Count_last[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_Count_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_byte_Count_all[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_IndexOf_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_byte_IndexOf_absent[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_IndexOf_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_byte_IndexOf_first[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_IndexOf_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_byte_IndexOf_last[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_IndexOf_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_byte_IndexOf_all[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOf_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_byte_LastIndexOf_absent[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOf_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_byte_LastIndexOf_first[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOf_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_byte_LastIndexOf_last[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOf_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_byte_LastIndexOf_all[i & 255], (byte)2); return r; }
static Vector64<byte>[] dV64_byte_Any_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_byte_Any_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_Any_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_byte_Any_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_Any_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_byte_Any_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_Any_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_byte_Any_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_All_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_byte_All_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_All_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_byte_All_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_All_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_byte_All_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_All_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_byte_All_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_None_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_byte_None_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_None_first=Make(Vector64<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_byte_None_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_None_last=Make(Vector64<byte>.Zero.WithElement(7, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_byte_None_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_None_all=Make(Vector64.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_byte_None_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector64<byte>[] dV64_byte_CountWhereAllBitsSet_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_byte_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_CountWhereAllBitsSet_first=Make(Vector64<byte>.Zero.WithElement(0, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_byte_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_CountWhereAllBitsSet_last=Make(Vector64<byte>.Zero.WithElement(7, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_byte_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_byte_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_IndexOfWhereAllBitsSet_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_byte_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_IndexOfWhereAllBitsSet_first=Make(Vector64<byte>.Zero.WithElement(0, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_byte_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_IndexOfWhereAllBitsSet_last=Make(Vector64<byte>.Zero.WithElement(7, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_byte_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_byte_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_byte_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOfWhereAllBitsSet_first=Make(Vector64<byte>.Zero.WithElement(0, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_byte_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOfWhereAllBitsSet_last=Make(Vector64<byte>.Zero.WithElement(7, Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_byte_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<byte>[] dV64_byte_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_byte_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_byte_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<short>[] dV64_short_Count_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_short_Count_absent[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_Count_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_short_Count_first[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_Count_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_short_Count_last[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_Count_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_short_Count_all[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_IndexOf_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_short_IndexOf_absent[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_IndexOf_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_short_IndexOf_first[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_IndexOf_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_short_IndexOf_last[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_IndexOf_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_short_IndexOf_all[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_LastIndexOf_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_short_LastIndexOf_absent[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_LastIndexOf_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_short_LastIndexOf_first[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_LastIndexOf_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_short_LastIndexOf_last[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_LastIndexOf_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_short_LastIndexOf_all[i & 255], (short)2); return r; }
static Vector64<short>[] dV64_short_Any_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_short_Any_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_Any_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_short_Any_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_Any_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_short_Any_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_Any_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_short_Any_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_All_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_short_All_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_All_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_short_All_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_All_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_short_All_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_All_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_short_All_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_None_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_short_None_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_None_first=Make(Vector64<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_short_None_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_None_last=Make(Vector64<short>.Zero.WithElement(3, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_short_None_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_None_all=Make(Vector64.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_short_None_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector64<short>[] dV64_short_CountWhereAllBitsSet_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_short_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<short>[] dV64_short_CountWhereAllBitsSet_first=Make(Vector64<short>.Zero.WithElement(0, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_short_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<short>[] dV64_short_CountWhereAllBitsSet_last=Make(Vector64<short>.Zero.WithElement(3, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_short_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<short>[] dV64_short_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_short_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<short>[] dV64_short_IndexOfWhereAllBitsSet_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_short_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<short>[] dV64_short_IndexOfWhereAllBitsSet_first=Make(Vector64<short>.Zero.WithElement(0, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_short_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<short>[] dV64_short_IndexOfWhereAllBitsSet_last=Make(Vector64<short>.Zero.WithElement(3, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_short_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<short>[] dV64_short_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_short_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<short>[] dV64_short_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_short_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<short>[] dV64_short_LastIndexOfWhereAllBitsSet_first=Make(Vector64<short>.Zero.WithElement(0, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_short_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<short>[] dV64_short_LastIndexOfWhereAllBitsSet_last=Make(Vector64<short>.Zero.WithElement(3, Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_short_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<short>[] dV64_short_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_short_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_short_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<int>[] dV64_int_Count_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_int_Count_absent[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_Count_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_int_Count_first[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_Count_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_int_Count_last[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_Count_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_int_Count_all[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_IndexOf_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_int_IndexOf_absent[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_IndexOf_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_int_IndexOf_first[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_IndexOf_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_int_IndexOf_last[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_IndexOf_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_int_IndexOf_all[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_LastIndexOf_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_int_LastIndexOf_absent[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_LastIndexOf_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_int_LastIndexOf_first[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_LastIndexOf_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_int_LastIndexOf_last[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_LastIndexOf_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_int_LastIndexOf_all[i & 255], 2); return r; }
static Vector64<int>[] dV64_int_Any_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_int_Any_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_Any_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_int_Any_first[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_Any_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_int_Any_last[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_Any_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_int_Any_all[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_All_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_int_All_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_All_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_int_All_first[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_All_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_int_All_last[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_All_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_int_All_all[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_None_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_int_None_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_None_first=Make(Vector64<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_int_None_first[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_None_last=Make(Vector64<int>.Zero.WithElement(1, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_int_None_last[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_None_all=Make(Vector64.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_int_None_all[i & 255], 2) ? 1 : 0); return r; }
static Vector64<int>[] dV64_int_CountWhereAllBitsSet_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_int_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<int>[] dV64_int_CountWhereAllBitsSet_first=Make(Vector64<int>.Zero.WithElement(0, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_int_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<int>[] dV64_int_CountWhereAllBitsSet_last=Make(Vector64<int>.Zero.WithElement(1, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_int_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<int>[] dV64_int_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_int_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<int>[] dV64_int_IndexOfWhereAllBitsSet_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_int_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<int>[] dV64_int_IndexOfWhereAllBitsSet_first=Make(Vector64<int>.Zero.WithElement(0, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_int_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<int>[] dV64_int_IndexOfWhereAllBitsSet_last=Make(Vector64<int>.Zero.WithElement(1, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_int_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<int>[] dV64_int_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_int_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<int>[] dV64_int_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_int_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<int>[] dV64_int_LastIndexOfWhereAllBitsSet_first=Make(Vector64<int>.Zero.WithElement(0, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_int_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<int>[] dV64_int_LastIndexOfWhereAllBitsSet_last=Make(Vector64<int>.Zero.WithElement(1, Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_int_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<int>[] dV64_int_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_int_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_int_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<long>[] dV64_long_Count_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_long_Count_absent[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_Count_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_long_Count_first[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_Count_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_long_Count_last[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_Count_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_long_Count_all[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_IndexOf_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_long_IndexOf_absent[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_IndexOf_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_long_IndexOf_first[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_IndexOf_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_long_IndexOf_last[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_IndexOf_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_long_IndexOf_all[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_LastIndexOf_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_long_LastIndexOf_absent[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_LastIndexOf_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_long_LastIndexOf_first[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_LastIndexOf_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_long_LastIndexOf_last[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_LastIndexOf_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_long_LastIndexOf_all[i & 255], 2L); return r; }
static Vector64<long>[] dV64_long_Any_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_long_Any_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_Any_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_long_Any_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_Any_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_long_Any_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_Any_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_long_Any_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_All_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_long_All_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_All_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_long_All_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_All_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_long_All_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_All_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_long_All_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_None_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_long_None_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_None_first=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_long_None_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_None_last=Make(Vector64<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_long_None_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_None_all=Make(Vector64.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_long_None_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector64<long>[] dV64_long_CountWhereAllBitsSet_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_long_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<long>[] dV64_long_CountWhereAllBitsSet_first=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_long_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<long>[] dV64_long_CountWhereAllBitsSet_last=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_long_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<long>[] dV64_long_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_long_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<long>[] dV64_long_IndexOfWhereAllBitsSet_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_long_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<long>[] dV64_long_IndexOfWhereAllBitsSet_first=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_long_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<long>[] dV64_long_IndexOfWhereAllBitsSet_last=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_long_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<long>[] dV64_long_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_long_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<long>[] dV64_long_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_long_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<long>[] dV64_long_LastIndexOfWhereAllBitsSet_first=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_long_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<long>[] dV64_long_LastIndexOfWhereAllBitsSet_last=Make(Vector64<long>.Zero.WithElement(0, Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_long_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<long>[] dV64_long_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_long_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_long_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<float>[] dV64_float_Count_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_float_Count_absent[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_Count_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_float_Count_first[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_Count_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_float_Count_last[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_Count_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_float_Count_all[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_Count_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Count_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_float_Count_nan[i & 255], float.NaN); return r; }
static Vector64<float>[] dV64_float_IndexOf_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_float_IndexOf_absent[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_IndexOf_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_float_IndexOf_first[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_IndexOf_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_float_IndexOf_last[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_IndexOf_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_float_IndexOf_all[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_IndexOf_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_float_IndexOf_nan[i & 255], float.NaN); return r; }
static Vector64<float>[] dV64_float_LastIndexOf_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_float_LastIndexOf_absent[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_LastIndexOf_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_float_LastIndexOf_first[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_LastIndexOf_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_float_LastIndexOf_last[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_LastIndexOf_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_float_LastIndexOf_all[i & 255], 2f); return r; }
static Vector64<float>[] dV64_float_LastIndexOf_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_float_LastIndexOf_nan[i & 255], float.NaN); return r; }
static Vector64<float>[] dV64_float_Any_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_float_Any_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_Any_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_float_Any_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_Any_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_float_Any_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_Any_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_float_Any_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_Any_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_Any_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_float_Any_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_All_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_float_All_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_All_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_float_All_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_All_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_float_All_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_All_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_float_All_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_All_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_All_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_float_All_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_None_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_float_None_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_None_first=Make(Vector64<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_float_None_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_None_last=Make(Vector64<float>.Zero.WithElement(1, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_float_None_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_None_all=Make(Vector64.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_float_None_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_None_nan=Make(Vector64.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_None_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_float_None_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector64<float>[] dV64_float_CountWhereAllBitsSet_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_float_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<float>[] dV64_float_CountWhereAllBitsSet_first=Make(Vector64<float>.Zero.WithElement(0, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_float_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<float>[] dV64_float_CountWhereAllBitsSet_last=Make(Vector64<float>.Zero.WithElement(1, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_float_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<float>[] dV64_float_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_float_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<float>[] dV64_float_IndexOfWhereAllBitsSet_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_float_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<float>[] dV64_float_IndexOfWhereAllBitsSet_first=Make(Vector64<float>.Zero.WithElement(0, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_float_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<float>[] dV64_float_IndexOfWhereAllBitsSet_last=Make(Vector64<float>.Zero.WithElement(1, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_float_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<float>[] dV64_float_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_float_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<float>[] dV64_float_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_float_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<float>[] dV64_float_LastIndexOfWhereAllBitsSet_first=Make(Vector64<float>.Zero.WithElement(0, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_float_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<float>[] dV64_float_LastIndexOfWhereAllBitsSet_last=Make(Vector64<float>.Zero.WithElement(1, Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_float_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<float>[] dV64_float_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_float_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_float_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<double>[] dV64_double_Count_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_double_Count_absent[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_Count_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_double_Count_first[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_Count_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_double_Count_last[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_Count_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_double_Count_all[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_Count_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Count_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.Count(dV64_double_Count_nan[i & 255], double.NaN); return r; }
static Vector64<double>[] dV64_double_IndexOf_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_double_IndexOf_absent[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_IndexOf_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_double_IndexOf_first[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_IndexOf_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_double_IndexOf_last[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_IndexOf_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_double_IndexOf_all[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_IndexOf_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOf(dV64_double_IndexOf_nan[i & 255], double.NaN); return r; }
static Vector64<double>[] dV64_double_LastIndexOf_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_double_LastIndexOf_absent[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_LastIndexOf_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_double_LastIndexOf_first[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_LastIndexOf_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_double_LastIndexOf_last[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_LastIndexOf_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_double_LastIndexOf_all[i & 255], 2d); return r; }
static Vector64<double>[] dV64_double_LastIndexOf_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOf(dV64_double_LastIndexOf_nan[i & 255], double.NaN); return r; }
static Vector64<double>[] dV64_double_Any_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_double_Any_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_Any_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_double_Any_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_Any_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_double_Any_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_Any_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_double_Any_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_Any_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_Any_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.Any(dV64_double_Any_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_All_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_double_All_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_All_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_double_All_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_All_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_double_All_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_All_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_double_All_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_All_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_All_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.All(dV64_double_All_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_None_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_double_None_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_None_first=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_double_None_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_None_last=Make(Vector64<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_double_None_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_None_all=Make(Vector64.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_double_None_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_None_nan=Make(Vector64.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_None_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector64.None(dV64_double_None_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector64<double>[] dV64_double_CountWhereAllBitsSet_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_double_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<double>[] dV64_double_CountWhereAllBitsSet_first=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_double_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<double>[] dV64_double_CountWhereAllBitsSet_last=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_double_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<double>[] dV64_double_CountWhereAllBitsSet_all=Make(Vector64.Create(Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.CountWhereAllBitsSet(dV64_double_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<double>[] dV64_double_IndexOfWhereAllBitsSet_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_double_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<double>[] dV64_double_IndexOfWhereAllBitsSet_first=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_double_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<double>[] dV64_double_IndexOfWhereAllBitsSet_last=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_double_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<double>[] dV64_double_IndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.IndexOfWhereAllBitsSet(dV64_double_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector64<double>[] dV64_double_LastIndexOfWhereAllBitsSet_absent=Make(Vector64<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_double_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector64<double>[] dV64_double_LastIndexOfWhereAllBitsSet_first=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_double_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector64<double>[] dV64_double_LastIndexOfWhereAllBitsSet_last=Make(Vector64<double>.Zero.WithElement(0, Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_double_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector64<double>[] dV64_double_LastIndexOfWhereAllBitsSet_all=Make(Vector64.Create(Vector64<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V64_double_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector64.LastIndexOfWhereAllBitsSet(dV64_double_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_Count_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_byte_Count_absent[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_Count_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_byte_Count_first[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_Count_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_byte_Count_last[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_Count_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_byte_Count_all[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_IndexOf_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_byte_IndexOf_absent[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_IndexOf_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_byte_IndexOf_first[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_IndexOf_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_byte_IndexOf_last[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_IndexOf_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_byte_IndexOf_all[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOf_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_byte_LastIndexOf_absent[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOf_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_byte_LastIndexOf_first[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOf_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_byte_LastIndexOf_last[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOf_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_byte_LastIndexOf_all[i & 255], (byte)2); return r; }
static Vector128<byte>[] dV128_byte_Any_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_byte_Any_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_Any_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_byte_Any_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_Any_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_byte_Any_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_Any_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_byte_Any_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_All_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_byte_All_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_All_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_byte_All_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_All_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_byte_All_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_All_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_byte_All_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_None_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_byte_None_absent[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_None_first=Make(Vector128<byte>.Zero.WithElement(0, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_byte_None_first[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_None_last=Make(Vector128<byte>.Zero.WithElement(15, (byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_byte_None_last[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_None_all=Make(Vector128.Create((byte)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_byte_None_all[i & 255], (byte)2) ? 1 : 0); return r; }
static Vector128<byte>[] dV128_byte_CountWhereAllBitsSet_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_byte_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_CountWhereAllBitsSet_first=Make(Vector128<byte>.Zero.WithElement(0, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_byte_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_CountWhereAllBitsSet_last=Make(Vector128<byte>.Zero.WithElement(15, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_byte_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_byte_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_IndexOfWhereAllBitsSet_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_byte_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_IndexOfWhereAllBitsSet_first=Make(Vector128<byte>.Zero.WithElement(0, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_byte_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_IndexOfWhereAllBitsSet_last=Make(Vector128<byte>.Zero.WithElement(15, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_byte_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_byte_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<byte>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_byte_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOfWhereAllBitsSet_first=Make(Vector128<byte>.Zero.WithElement(0, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_byte_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOfWhereAllBitsSet_last=Make(Vector128<byte>.Zero.WithElement(15, Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_byte_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<byte>[] dV128_byte_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<byte>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_byte_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_byte_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<short>[] dV128_short_Count_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_short_Count_absent[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_Count_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_short_Count_first[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_Count_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_short_Count_last[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_Count_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_short_Count_all[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_IndexOf_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_short_IndexOf_absent[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_IndexOf_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_short_IndexOf_first[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_IndexOf_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_short_IndexOf_last[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_IndexOf_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_short_IndexOf_all[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_LastIndexOf_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_short_LastIndexOf_absent[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_LastIndexOf_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_short_LastIndexOf_first[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_LastIndexOf_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_short_LastIndexOf_last[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_LastIndexOf_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_short_LastIndexOf_all[i & 255], (short)2); return r; }
static Vector128<short>[] dV128_short_Any_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_short_Any_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_Any_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_short_Any_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_Any_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_short_Any_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_Any_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_short_Any_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_All_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_short_All_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_All_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_short_All_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_All_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_short_All_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_All_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_short_All_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_None_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_short_None_absent[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_None_first=Make(Vector128<short>.Zero.WithElement(0, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_short_None_first[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_None_last=Make(Vector128<short>.Zero.WithElement(7, (short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_short_None_last[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_None_all=Make(Vector128.Create((short)2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_short_None_all[i & 255], (short)2) ? 1 : 0); return r; }
static Vector128<short>[] dV128_short_CountWhereAllBitsSet_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_short_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<short>[] dV128_short_CountWhereAllBitsSet_first=Make(Vector128<short>.Zero.WithElement(0, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_short_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<short>[] dV128_short_CountWhereAllBitsSet_last=Make(Vector128<short>.Zero.WithElement(7, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_short_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<short>[] dV128_short_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_short_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<short>[] dV128_short_IndexOfWhereAllBitsSet_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_short_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<short>[] dV128_short_IndexOfWhereAllBitsSet_first=Make(Vector128<short>.Zero.WithElement(0, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_short_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<short>[] dV128_short_IndexOfWhereAllBitsSet_last=Make(Vector128<short>.Zero.WithElement(7, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_short_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<short>[] dV128_short_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_short_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<short>[] dV128_short_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<short>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_short_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<short>[] dV128_short_LastIndexOfWhereAllBitsSet_first=Make(Vector128<short>.Zero.WithElement(0, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_short_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<short>[] dV128_short_LastIndexOfWhereAllBitsSet_last=Make(Vector128<short>.Zero.WithElement(7, Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_short_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<short>[] dV128_short_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<short>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_short_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_short_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<int>[] dV128_int_Count_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_int_Count_absent[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_Count_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_int_Count_first[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_Count_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_int_Count_last[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_Count_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_int_Count_all[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_IndexOf_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_int_IndexOf_absent[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_IndexOf_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_int_IndexOf_first[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_IndexOf_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_int_IndexOf_last[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_IndexOf_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_int_IndexOf_all[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_LastIndexOf_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_int_LastIndexOf_absent[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_LastIndexOf_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_int_LastIndexOf_first[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_LastIndexOf_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_int_LastIndexOf_last[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_LastIndexOf_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_int_LastIndexOf_all[i & 255], 2); return r; }
static Vector128<int>[] dV128_int_Any_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_int_Any_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_Any_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_int_Any_first[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_Any_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_int_Any_last[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_Any_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_int_Any_all[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_All_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_int_All_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_All_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_int_All_first[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_All_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_int_All_last[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_All_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_int_All_all[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_None_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_int_None_absent[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_None_first=Make(Vector128<int>.Zero.WithElement(0, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_int_None_first[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_None_last=Make(Vector128<int>.Zero.WithElement(3, 2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_int_None_last[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_None_all=Make(Vector128.Create(2));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_int_None_all[i & 255], 2) ? 1 : 0); return r; }
static Vector128<int>[] dV128_int_CountWhereAllBitsSet_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_int_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<int>[] dV128_int_CountWhereAllBitsSet_first=Make(Vector128<int>.Zero.WithElement(0, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_int_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<int>[] dV128_int_CountWhereAllBitsSet_last=Make(Vector128<int>.Zero.WithElement(3, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_int_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<int>[] dV128_int_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_int_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<int>[] dV128_int_IndexOfWhereAllBitsSet_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_int_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<int>[] dV128_int_IndexOfWhereAllBitsSet_first=Make(Vector128<int>.Zero.WithElement(0, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_int_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<int>[] dV128_int_IndexOfWhereAllBitsSet_last=Make(Vector128<int>.Zero.WithElement(3, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_int_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<int>[] dV128_int_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_int_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<int>[] dV128_int_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<int>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_int_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<int>[] dV128_int_LastIndexOfWhereAllBitsSet_first=Make(Vector128<int>.Zero.WithElement(0, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_int_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<int>[] dV128_int_LastIndexOfWhereAllBitsSet_last=Make(Vector128<int>.Zero.WithElement(3, Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_int_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<int>[] dV128_int_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<int>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_int_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_int_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<long>[] dV128_long_Count_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_long_Count_absent[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_Count_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_long_Count_first[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_Count_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_long_Count_last[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_Count_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_long_Count_all[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_IndexOf_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_long_IndexOf_absent[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_IndexOf_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_long_IndexOf_first[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_IndexOf_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_long_IndexOf_last[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_IndexOf_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_long_IndexOf_all[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_LastIndexOf_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_long_LastIndexOf_absent[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_LastIndexOf_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_long_LastIndexOf_first[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_LastIndexOf_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_long_LastIndexOf_last[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_LastIndexOf_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_long_LastIndexOf_all[i & 255], 2L); return r; }
static Vector128<long>[] dV128_long_Any_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_long_Any_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_Any_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_long_Any_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_Any_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_long_Any_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_Any_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_long_Any_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_All_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_long_All_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_All_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_long_All_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_All_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_long_All_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_All_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_long_All_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_None_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_long_None_absent[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_None_first=Make(Vector128<long>.Zero.WithElement(0, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_long_None_first[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_None_last=Make(Vector128<long>.Zero.WithElement(1, 2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_long_None_last[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_None_all=Make(Vector128.Create(2L));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_long_None_all[i & 255], 2L) ? 1 : 0); return r; }
static Vector128<long>[] dV128_long_CountWhereAllBitsSet_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_long_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<long>[] dV128_long_CountWhereAllBitsSet_first=Make(Vector128<long>.Zero.WithElement(0, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_long_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<long>[] dV128_long_CountWhereAllBitsSet_last=Make(Vector128<long>.Zero.WithElement(1, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_long_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<long>[] dV128_long_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_long_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<long>[] dV128_long_IndexOfWhereAllBitsSet_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_long_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<long>[] dV128_long_IndexOfWhereAllBitsSet_first=Make(Vector128<long>.Zero.WithElement(0, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_long_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<long>[] dV128_long_IndexOfWhereAllBitsSet_last=Make(Vector128<long>.Zero.WithElement(1, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_long_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<long>[] dV128_long_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_long_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<long>[] dV128_long_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<long>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_long_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<long>[] dV128_long_LastIndexOfWhereAllBitsSet_first=Make(Vector128<long>.Zero.WithElement(0, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_long_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<long>[] dV128_long_LastIndexOfWhereAllBitsSet_last=Make(Vector128<long>.Zero.WithElement(1, Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_long_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<long>[] dV128_long_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<long>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_long_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_long_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<float>[] dV128_float_Count_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_float_Count_absent[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_Count_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_float_Count_first[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_Count_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_float_Count_last[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_Count_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_float_Count_all[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_Count_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Count_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_float_Count_nan[i & 255], float.NaN); return r; }
static Vector128<float>[] dV128_float_IndexOf_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_float_IndexOf_absent[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_IndexOf_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_float_IndexOf_first[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_IndexOf_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_float_IndexOf_last[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_IndexOf_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_float_IndexOf_all[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_IndexOf_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_float_IndexOf_nan[i & 255], float.NaN); return r; }
static Vector128<float>[] dV128_float_LastIndexOf_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_float_LastIndexOf_absent[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_LastIndexOf_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_float_LastIndexOf_first[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_LastIndexOf_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_float_LastIndexOf_last[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_LastIndexOf_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_float_LastIndexOf_all[i & 255], 2f); return r; }
static Vector128<float>[] dV128_float_LastIndexOf_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_float_LastIndexOf_nan[i & 255], float.NaN); return r; }
static Vector128<float>[] dV128_float_Any_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_float_Any_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_Any_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_float_Any_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_Any_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_float_Any_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_Any_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_float_Any_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_Any_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_Any_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_float_Any_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_All_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_float_All_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_All_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_float_All_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_All_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_float_All_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_All_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_float_All_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_All_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_All_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_float_All_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_None_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_float_None_absent[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_None_first=Make(Vector128<float>.Zero.WithElement(0, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_float_None_first[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_None_last=Make(Vector128<float>.Zero.WithElement(3, 2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_float_None_last[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_None_all=Make(Vector128.Create(2f));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_float_None_all[i & 255], 2f) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_None_nan=Make(Vector128.Create(float.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_None_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_float_None_nan[i & 255], float.NaN) ? 1 : 0); return r; }
static Vector128<float>[] dV128_float_CountWhereAllBitsSet_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_float_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<float>[] dV128_float_CountWhereAllBitsSet_first=Make(Vector128<float>.Zero.WithElement(0, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_float_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<float>[] dV128_float_CountWhereAllBitsSet_last=Make(Vector128<float>.Zero.WithElement(3, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_float_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<float>[] dV128_float_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_float_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<float>[] dV128_float_IndexOfWhereAllBitsSet_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_float_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<float>[] dV128_float_IndexOfWhereAllBitsSet_first=Make(Vector128<float>.Zero.WithElement(0, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_float_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<float>[] dV128_float_IndexOfWhereAllBitsSet_last=Make(Vector128<float>.Zero.WithElement(3, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_float_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<float>[] dV128_float_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_float_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<float>[] dV128_float_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<float>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_float_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<float>[] dV128_float_LastIndexOfWhereAllBitsSet_first=Make(Vector128<float>.Zero.WithElement(0, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_float_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<float>[] dV128_float_LastIndexOfWhereAllBitsSet_last=Make(Vector128<float>.Zero.WithElement(3, Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_float_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<float>[] dV128_float_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<float>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_float_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_float_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<double>[] dV128_double_Count_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_double_Count_absent[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_Count_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_double_Count_first[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_Count_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_double_Count_last[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_Count_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_double_Count_all[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_Count_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Count_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.Count(dV128_double_Count_nan[i & 255], double.NaN); return r; }
static Vector128<double>[] dV128_double_IndexOf_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_double_IndexOf_absent[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_IndexOf_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_double_IndexOf_first[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_IndexOf_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_double_IndexOf_last[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_IndexOf_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_double_IndexOf_all[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_IndexOf_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOf(dV128_double_IndexOf_nan[i & 255], double.NaN); return r; }
static Vector128<double>[] dV128_double_LastIndexOf_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_double_LastIndexOf_absent[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_LastIndexOf_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_double_LastIndexOf_first[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_LastIndexOf_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_double_LastIndexOf_last[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_LastIndexOf_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_double_LastIndexOf_all[i & 255], 2d); return r; }
static Vector128<double>[] dV128_double_LastIndexOf_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOf_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOf(dV128_double_LastIndexOf_nan[i & 255], double.NaN); return r; }
static Vector128<double>[] dV128_double_Any_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Any_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_double_Any_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_Any_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Any_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_double_Any_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_Any_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Any_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_double_Any_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_Any_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Any_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_double_Any_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_Any_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_Any_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.Any(dV128_double_Any_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_All_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_All_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_double_All_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_All_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_All_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_double_All_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_All_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_All_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_double_All_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_All_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_All_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_double_All_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_All_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_All_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.All(dV128_double_All_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_None_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_None_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_double_None_absent[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_None_first=Make(Vector128<double>.Zero.WithElement(0, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_None_first(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_double_None_first[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_None_last=Make(Vector128<double>.Zero.WithElement(1, 2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_None_last(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_double_None_last[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_None_all=Make(Vector128.Create(2d));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_None_all(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_double_None_all[i & 255], 2d) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_None_nan=Make(Vector128.Create(double.NaN));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_None_nan(int n) { int r=0; for(int i=0;i<n;i++) r+=(Vector128.None(dV128_double_None_nan[i & 255], double.NaN) ? 1 : 0); return r; }
static Vector128<double>[] dV128_double_CountWhereAllBitsSet_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_CountWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_double_CountWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<double>[] dV128_double_CountWhereAllBitsSet_first=Make(Vector128<double>.Zero.WithElement(0, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_CountWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_double_CountWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<double>[] dV128_double_CountWhereAllBitsSet_last=Make(Vector128<double>.Zero.WithElement(1, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_CountWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_double_CountWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<double>[] dV128_double_CountWhereAllBitsSet_all=Make(Vector128.Create(Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_CountWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.CountWhereAllBitsSet(dV128_double_CountWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<double>[] dV128_double_IndexOfWhereAllBitsSet_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_double_IndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<double>[] dV128_double_IndexOfWhereAllBitsSet_first=Make(Vector128<double>.Zero.WithElement(0, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_double_IndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<double>[] dV128_double_IndexOfWhereAllBitsSet_last=Make(Vector128<double>.Zero.WithElement(1, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_double_IndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<double>[] dV128_double_IndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_IndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.IndexOfWhereAllBitsSet(dV128_double_IndexOfWhereAllBitsSet_all[i & 255]); return r; }
static Vector128<double>[] dV128_double_LastIndexOfWhereAllBitsSet_absent=Make(Vector128<double>.Zero);
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOfWhereAllBitsSet_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_double_LastIndexOfWhereAllBitsSet_absent[i & 255]); return r; }
static Vector128<double>[] dV128_double_LastIndexOfWhereAllBitsSet_first=Make(Vector128<double>.Zero.WithElement(0, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOfWhereAllBitsSet_first(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_double_LastIndexOfWhereAllBitsSet_first[i & 255]); return r; }
static Vector128<double>[] dV128_double_LastIndexOfWhereAllBitsSet_last=Make(Vector128<double>.Zero.WithElement(1, Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOfWhereAllBitsSet_last(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_double_LastIndexOfWhereAllBitsSet_last[i & 255]); return r; }
static Vector128<double>[] dV128_double_LastIndexOfWhereAllBitsSet_all=Make(Vector128.Create(Vector128<double>.AllBitsSet.GetElement(0)));
[MethodImpl(MethodImplOptions.NoInlining)] static int V128_double_LastIndexOfWhereAllBitsSet_all(int n) { int r=0; for(int i=0;i<n;i++) r+=Vector128.LastIndexOfWhereAllBitsSet(dV128_double_LastIndexOfWhereAllBitsSet_all[i & 255]); return r; }
static byte[] dSpan_byte_16_IndexOf_absent=MakeSpan<byte>(16,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_16_IndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_IndexOf_first=MakeSpan<byte>(16,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_16_IndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_IndexOf_last=MakeSpan<byte>(16,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_16_IndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_IndexOf_all=MakeSpan<byte>(16,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_16_IndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_LastIndexOf_absent=MakeSpan<byte>(16,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_16_LastIndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_LastIndexOf_first=MakeSpan<byte>(16,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_16_LastIndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_LastIndexOf_last=MakeSpan<byte>(16,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_16_LastIndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_LastIndexOf_all=MakeSpan<byte>(16,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_16_LastIndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_Count_absent=MakeSpan<byte>(16,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_16_Count_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_Count_first=MakeSpan<byte>(16,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_16_Count_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_Count_last=MakeSpan<byte>(16,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_16_Count_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_16_Count_all=MakeSpan<byte>(16,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_16_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_16_Count_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_IndexOf_absent=MakeSpan<byte>(64,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_64_IndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_IndexOf_first=MakeSpan<byte>(64,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_64_IndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_IndexOf_last=MakeSpan<byte>(64,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_64_IndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_IndexOf_all=MakeSpan<byte>(64,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_64_IndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_LastIndexOf_absent=MakeSpan<byte>(64,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_64_LastIndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_LastIndexOf_first=MakeSpan<byte>(64,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_64_LastIndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_LastIndexOf_last=MakeSpan<byte>(64,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_64_LastIndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_LastIndexOf_all=MakeSpan<byte>(64,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_64_LastIndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_Count_absent=MakeSpan<byte>(64,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_64_Count_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_Count_first=MakeSpan<byte>(64,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_64_Count_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_Count_last=MakeSpan<byte>(64,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_64_Count_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_64_Count_all=MakeSpan<byte>(64,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_64_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_64_Count_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_IndexOf_absent=MakeSpan<byte>(256,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_256_IndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_IndexOf_first=MakeSpan<byte>(256,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_256_IndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_IndexOf_last=MakeSpan<byte>(256,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_256_IndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_IndexOf_all=MakeSpan<byte>(256,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_256_IndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_LastIndexOf_absent=MakeSpan<byte>(256,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_256_LastIndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_LastIndexOf_first=MakeSpan<byte>(256,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_256_LastIndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_LastIndexOf_last=MakeSpan<byte>(256,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_256_LastIndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_LastIndexOf_all=MakeSpan<byte>(256,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_256_LastIndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_Count_absent=MakeSpan<byte>(256,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_256_Count_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_Count_first=MakeSpan<byte>(256,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_256_Count_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_Count_last=MakeSpan<byte>(256,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_256_Count_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_256_Count_all=MakeSpan<byte>(256,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_256_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_256_Count_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_IndexOf_absent=MakeSpan<byte>(4096,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_4096_IndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_IndexOf_first=MakeSpan<byte>(4096,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_4096_IndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_IndexOf_last=MakeSpan<byte>(4096,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_4096_IndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_IndexOf_all=MakeSpan<byte>(4096,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<byte>(dSpan_byte_4096_IndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_LastIndexOf_absent=MakeSpan<byte>(4096,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_4096_LastIndexOf_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_LastIndexOf_first=MakeSpan<byte>(4096,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_4096_LastIndexOf_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_LastIndexOf_last=MakeSpan<byte>(4096,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_4096_LastIndexOf_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_LastIndexOf_all=MakeSpan<byte>(4096,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<byte>(dSpan_byte_4096_LastIndexOf_all.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_Count_absent=MakeSpan<byte>(4096,(byte)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_4096_Count_absent.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_Count_first=MakeSpan<byte>(4096,(byte)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_4096_Count_first.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_Count_last=MakeSpan<byte>(4096,(byte)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_4096_Count_last.AsSpan(),(byte)2); return r; }
static byte[] dSpan_byte_4096_Count_all=MakeSpan<byte>(4096,(byte)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_byte_4096_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<byte>(dSpan_byte_4096_Count_all.AsSpan(),(byte)2); return r; }
static short[] dSpan_short_16_IndexOf_absent=MakeSpan<short>(16,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_16_IndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_IndexOf_first=MakeSpan<short>(16,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_16_IndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_IndexOf_last=MakeSpan<short>(16,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_16_IndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_IndexOf_all=MakeSpan<short>(16,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_16_IndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_LastIndexOf_absent=MakeSpan<short>(16,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_16_LastIndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_LastIndexOf_first=MakeSpan<short>(16,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_16_LastIndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_LastIndexOf_last=MakeSpan<short>(16,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_16_LastIndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_LastIndexOf_all=MakeSpan<short>(16,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_16_LastIndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_Count_absent=MakeSpan<short>(16,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_16_Count_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_Count_first=MakeSpan<short>(16,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_16_Count_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_Count_last=MakeSpan<short>(16,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_16_Count_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_16_Count_all=MakeSpan<short>(16,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_16_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_16_Count_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_IndexOf_absent=MakeSpan<short>(64,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_64_IndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_IndexOf_first=MakeSpan<short>(64,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_64_IndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_IndexOf_last=MakeSpan<short>(64,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_64_IndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_IndexOf_all=MakeSpan<short>(64,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_64_IndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_LastIndexOf_absent=MakeSpan<short>(64,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_64_LastIndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_LastIndexOf_first=MakeSpan<short>(64,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_64_LastIndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_LastIndexOf_last=MakeSpan<short>(64,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_64_LastIndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_LastIndexOf_all=MakeSpan<short>(64,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_64_LastIndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_Count_absent=MakeSpan<short>(64,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_64_Count_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_Count_first=MakeSpan<short>(64,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_64_Count_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_Count_last=MakeSpan<short>(64,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_64_Count_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_64_Count_all=MakeSpan<short>(64,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_64_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_64_Count_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_IndexOf_absent=MakeSpan<short>(256,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_256_IndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_IndexOf_first=MakeSpan<short>(256,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_256_IndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_IndexOf_last=MakeSpan<short>(256,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_256_IndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_IndexOf_all=MakeSpan<short>(256,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_256_IndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_LastIndexOf_absent=MakeSpan<short>(256,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_256_LastIndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_LastIndexOf_first=MakeSpan<short>(256,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_256_LastIndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_LastIndexOf_last=MakeSpan<short>(256,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_256_LastIndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_LastIndexOf_all=MakeSpan<short>(256,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_256_LastIndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_Count_absent=MakeSpan<short>(256,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_256_Count_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_Count_first=MakeSpan<short>(256,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_256_Count_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_Count_last=MakeSpan<short>(256,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_256_Count_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_256_Count_all=MakeSpan<short>(256,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_256_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_256_Count_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_IndexOf_absent=MakeSpan<short>(4096,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_4096_IndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_IndexOf_first=MakeSpan<short>(4096,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_4096_IndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_IndexOf_last=MakeSpan<short>(4096,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_4096_IndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_IndexOf_all=MakeSpan<short>(4096,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<short>(dSpan_short_4096_IndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_LastIndexOf_absent=MakeSpan<short>(4096,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_4096_LastIndexOf_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_LastIndexOf_first=MakeSpan<short>(4096,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_4096_LastIndexOf_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_LastIndexOf_last=MakeSpan<short>(4096,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_4096_LastIndexOf_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_LastIndexOf_all=MakeSpan<short>(4096,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<short>(dSpan_short_4096_LastIndexOf_all.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_Count_absent=MakeSpan<short>(4096,(short)2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_4096_Count_absent.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_Count_first=MakeSpan<short>(4096,(short)2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_4096_Count_first.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_Count_last=MakeSpan<short>(4096,(short)2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_4096_Count_last.AsSpan(),(short)2); return r; }
static short[] dSpan_short_4096_Count_all=MakeSpan<short>(4096,(short)2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_short_4096_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<short>(dSpan_short_4096_Count_all.AsSpan(),(short)2); return r; }
static int[] dSpan_int_16_IndexOf_absent=MakeSpan<int>(16,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_16_IndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_16_IndexOf_first=MakeSpan<int>(16,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_16_IndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_16_IndexOf_last=MakeSpan<int>(16,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_16_IndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_16_IndexOf_all=MakeSpan<int>(16,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_16_IndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_16_LastIndexOf_absent=MakeSpan<int>(16,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_16_LastIndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_16_LastIndexOf_first=MakeSpan<int>(16,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_16_LastIndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_16_LastIndexOf_last=MakeSpan<int>(16,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_16_LastIndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_16_LastIndexOf_all=MakeSpan<int>(16,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_16_LastIndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_16_Count_absent=MakeSpan<int>(16,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_16_Count_absent.AsSpan(),2); return r; }
static int[] dSpan_int_16_Count_first=MakeSpan<int>(16,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_16_Count_first.AsSpan(),2); return r; }
static int[] dSpan_int_16_Count_last=MakeSpan<int>(16,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_16_Count_last.AsSpan(),2); return r; }
static int[] dSpan_int_16_Count_all=MakeSpan<int>(16,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_16_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_16_Count_all.AsSpan(),2); return r; }
static int[] dSpan_int_64_IndexOf_absent=MakeSpan<int>(64,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_64_IndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_64_IndexOf_first=MakeSpan<int>(64,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_64_IndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_64_IndexOf_last=MakeSpan<int>(64,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_64_IndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_64_IndexOf_all=MakeSpan<int>(64,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_64_IndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_64_LastIndexOf_absent=MakeSpan<int>(64,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_64_LastIndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_64_LastIndexOf_first=MakeSpan<int>(64,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_64_LastIndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_64_LastIndexOf_last=MakeSpan<int>(64,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_64_LastIndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_64_LastIndexOf_all=MakeSpan<int>(64,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_64_LastIndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_64_Count_absent=MakeSpan<int>(64,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_64_Count_absent.AsSpan(),2); return r; }
static int[] dSpan_int_64_Count_first=MakeSpan<int>(64,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_64_Count_first.AsSpan(),2); return r; }
static int[] dSpan_int_64_Count_last=MakeSpan<int>(64,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_64_Count_last.AsSpan(),2); return r; }
static int[] dSpan_int_64_Count_all=MakeSpan<int>(64,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_64_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_64_Count_all.AsSpan(),2); return r; }
static int[] dSpan_int_256_IndexOf_absent=MakeSpan<int>(256,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_256_IndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_256_IndexOf_first=MakeSpan<int>(256,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_256_IndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_256_IndexOf_last=MakeSpan<int>(256,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_256_IndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_256_IndexOf_all=MakeSpan<int>(256,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_256_IndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_256_LastIndexOf_absent=MakeSpan<int>(256,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_256_LastIndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_256_LastIndexOf_first=MakeSpan<int>(256,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_256_LastIndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_256_LastIndexOf_last=MakeSpan<int>(256,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_256_LastIndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_256_LastIndexOf_all=MakeSpan<int>(256,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_256_LastIndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_256_Count_absent=MakeSpan<int>(256,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_256_Count_absent.AsSpan(),2); return r; }
static int[] dSpan_int_256_Count_first=MakeSpan<int>(256,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_256_Count_first.AsSpan(),2); return r; }
static int[] dSpan_int_256_Count_last=MakeSpan<int>(256,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_256_Count_last.AsSpan(),2); return r; }
static int[] dSpan_int_256_Count_all=MakeSpan<int>(256,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_256_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_256_Count_all.AsSpan(),2); return r; }
static int[] dSpan_int_4096_IndexOf_absent=MakeSpan<int>(4096,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_IndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_4096_IndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_4096_IndexOf_first=MakeSpan<int>(4096,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_IndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_4096_IndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_4096_IndexOf_last=MakeSpan<int>(4096,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_IndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_4096_IndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_4096_IndexOf_all=MakeSpan<int>(4096,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_IndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.IndexOf<int>(dSpan_int_4096_IndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_4096_LastIndexOf_absent=MakeSpan<int>(4096,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_LastIndexOf_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_4096_LastIndexOf_absent.AsSpan(),2); return r; }
static int[] dSpan_int_4096_LastIndexOf_first=MakeSpan<int>(4096,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_LastIndexOf_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_4096_LastIndexOf_first.AsSpan(),2); return r; }
static int[] dSpan_int_4096_LastIndexOf_last=MakeSpan<int>(4096,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_LastIndexOf_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_4096_LastIndexOf_last.AsSpan(),2); return r; }
static int[] dSpan_int_4096_LastIndexOf_all=MakeSpan<int>(4096,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_LastIndexOf_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.LastIndexOf<int>(dSpan_int_4096_LastIndexOf_all.AsSpan(),2); return r; }
static int[] dSpan_int_4096_Count_absent=MakeSpan<int>(4096,2,"absent");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_Count_absent(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_4096_Count_absent.AsSpan(),2); return r; }
static int[] dSpan_int_4096_Count_first=MakeSpan<int>(4096,2,"first");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_Count_first(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_4096_Count_first.AsSpan(),2); return r; }
static int[] dSpan_int_4096_Count_last=MakeSpan<int>(4096,2,"last");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_Count_last(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_4096_Count_last.AsSpan(),2); return r; }
static int[] dSpan_int_4096_Count_all=MakeSpan<int>(4096,2,"all");
[MethodImpl(MethodImplOptions.NoInlining)] static int Span_int_4096_Count_all(int n) { int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.Count<int>(dSpan_int_4096_Count_all.AsSpan(),2); return r; }
static T[] MakeSpan<T>(int n,T v,string pattern) {var a=new T[n]; if(pattern=="all") Array.Fill(a,v); else if(pattern!="absent") a[pattern=="first"?0:n-1]=v; return a;}
static T[] Make<T>(T v) { var a=new T[256]; Array.Fill(a,v); return a; }
static void Run(string name, Func<int,int> f, int expected) {
 if(Environment.GetEnvironmentVariable("PERF_FILTER") is string filter && !Array.Exists(filter.Split('|'),x=>name==x)) return;
 if(f(256)!=expected*256) throw new Exception(name+" correctness failed: "+f(256)+" expected "+expected*256);
 int n=4096; for(int i=0;i<3;i++) sink=f(n);
 long ticks=0,ops=0; var total=Stopwatch.StartNew(); do {long start=Stopwatch.GetTimestamp();sink=f(n);ticks+=Stopwatch.GetTimestamp()-start;ops+=n;}while(total.Elapsed.TotalMilliseconds<(int.TryParse(Environment.GetEnvironmentVariable("PERF_MS"),out int ms)?ms:10));
 Console.WriteLine($"{name},{ticks*1e9/Stopwatch.Frequency/ops:F5}"); }
 static void Main(){ Console.WriteLine("case,ns");
Run("V64_byte_Count_absent",V64_byte_Count_absent,0);
Run("V64_byte_Count_first",V64_byte_Count_first,1);
Run("V64_byte_Count_last",V64_byte_Count_last,1);
Run("V64_byte_Count_all",V64_byte_Count_all,8);
Run("V64_byte_IndexOf_absent",V64_byte_IndexOf_absent,-1);
Run("V64_byte_IndexOf_first",V64_byte_IndexOf_first,0);
Run("V64_byte_IndexOf_last",V64_byte_IndexOf_last,7);
Run("V64_byte_IndexOf_all",V64_byte_IndexOf_all,0);
Run("V64_byte_LastIndexOf_absent",V64_byte_LastIndexOf_absent,-1);
Run("V64_byte_LastIndexOf_first",V64_byte_LastIndexOf_first,0);
Run("V64_byte_LastIndexOf_last",V64_byte_LastIndexOf_last,7);
Run("V64_byte_LastIndexOf_all",V64_byte_LastIndexOf_all,7);
Run("V64_byte_Any_absent",V64_byte_Any_absent,0);
Run("V64_byte_Any_first",V64_byte_Any_first,1);
Run("V64_byte_Any_last",V64_byte_Any_last,1);
Run("V64_byte_Any_all",V64_byte_Any_all,1);
Run("V64_byte_All_absent",V64_byte_All_absent,0);
Run("V64_byte_All_first",V64_byte_All_first,0);
Run("V64_byte_All_last",V64_byte_All_last,0);
Run("V64_byte_All_all",V64_byte_All_all,1);
Run("V64_byte_None_absent",V64_byte_None_absent,1);
Run("V64_byte_None_first",V64_byte_None_first,0);
Run("V64_byte_None_last",V64_byte_None_last,0);
Run("V64_byte_None_all",V64_byte_None_all,0);
Run("V64_byte_CountWhereAllBitsSet_absent",V64_byte_CountWhereAllBitsSet_absent,0);
Run("V64_byte_CountWhereAllBitsSet_first",V64_byte_CountWhereAllBitsSet_first,1);
Run("V64_byte_CountWhereAllBitsSet_last",V64_byte_CountWhereAllBitsSet_last,1);
Run("V64_byte_CountWhereAllBitsSet_all",V64_byte_CountWhereAllBitsSet_all,8);
Run("V64_byte_IndexOfWhereAllBitsSet_absent",V64_byte_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_byte_IndexOfWhereAllBitsSet_first",V64_byte_IndexOfWhereAllBitsSet_first,0);
Run("V64_byte_IndexOfWhereAllBitsSet_last",V64_byte_IndexOfWhereAllBitsSet_last,7);
Run("V64_byte_IndexOfWhereAllBitsSet_all",V64_byte_IndexOfWhereAllBitsSet_all,0);
Run("V64_byte_LastIndexOfWhereAllBitsSet_absent",V64_byte_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_byte_LastIndexOfWhereAllBitsSet_first",V64_byte_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_byte_LastIndexOfWhereAllBitsSet_last",V64_byte_LastIndexOfWhereAllBitsSet_last,7);
Run("V64_byte_LastIndexOfWhereAllBitsSet_all",V64_byte_LastIndexOfWhereAllBitsSet_all,7);
Run("V64_short_Count_absent",V64_short_Count_absent,0);
Run("V64_short_Count_first",V64_short_Count_first,1);
Run("V64_short_Count_last",V64_short_Count_last,1);
Run("V64_short_Count_all",V64_short_Count_all,4);
Run("V64_short_IndexOf_absent",V64_short_IndexOf_absent,-1);
Run("V64_short_IndexOf_first",V64_short_IndexOf_first,0);
Run("V64_short_IndexOf_last",V64_short_IndexOf_last,3);
Run("V64_short_IndexOf_all",V64_short_IndexOf_all,0);
Run("V64_short_LastIndexOf_absent",V64_short_LastIndexOf_absent,-1);
Run("V64_short_LastIndexOf_first",V64_short_LastIndexOf_first,0);
Run("V64_short_LastIndexOf_last",V64_short_LastIndexOf_last,3);
Run("V64_short_LastIndexOf_all",V64_short_LastIndexOf_all,3);
Run("V64_short_Any_absent",V64_short_Any_absent,0);
Run("V64_short_Any_first",V64_short_Any_first,1);
Run("V64_short_Any_last",V64_short_Any_last,1);
Run("V64_short_Any_all",V64_short_Any_all,1);
Run("V64_short_All_absent",V64_short_All_absent,0);
Run("V64_short_All_first",V64_short_All_first,0);
Run("V64_short_All_last",V64_short_All_last,0);
Run("V64_short_All_all",V64_short_All_all,1);
Run("V64_short_None_absent",V64_short_None_absent,1);
Run("V64_short_None_first",V64_short_None_first,0);
Run("V64_short_None_last",V64_short_None_last,0);
Run("V64_short_None_all",V64_short_None_all,0);
Run("V64_short_CountWhereAllBitsSet_absent",V64_short_CountWhereAllBitsSet_absent,0);
Run("V64_short_CountWhereAllBitsSet_first",V64_short_CountWhereAllBitsSet_first,1);
Run("V64_short_CountWhereAllBitsSet_last",V64_short_CountWhereAllBitsSet_last,1);
Run("V64_short_CountWhereAllBitsSet_all",V64_short_CountWhereAllBitsSet_all,4);
Run("V64_short_IndexOfWhereAllBitsSet_absent",V64_short_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_short_IndexOfWhereAllBitsSet_first",V64_short_IndexOfWhereAllBitsSet_first,0);
Run("V64_short_IndexOfWhereAllBitsSet_last",V64_short_IndexOfWhereAllBitsSet_last,3);
Run("V64_short_IndexOfWhereAllBitsSet_all",V64_short_IndexOfWhereAllBitsSet_all,0);
Run("V64_short_LastIndexOfWhereAllBitsSet_absent",V64_short_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_short_LastIndexOfWhereAllBitsSet_first",V64_short_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_short_LastIndexOfWhereAllBitsSet_last",V64_short_LastIndexOfWhereAllBitsSet_last,3);
Run("V64_short_LastIndexOfWhereAllBitsSet_all",V64_short_LastIndexOfWhereAllBitsSet_all,3);
Run("V64_int_Count_absent",V64_int_Count_absent,0);
Run("V64_int_Count_first",V64_int_Count_first,1);
Run("V64_int_Count_last",V64_int_Count_last,1);
Run("V64_int_Count_all",V64_int_Count_all,2);
Run("V64_int_IndexOf_absent",V64_int_IndexOf_absent,-1);
Run("V64_int_IndexOf_first",V64_int_IndexOf_first,0);
Run("V64_int_IndexOf_last",V64_int_IndexOf_last,1);
Run("V64_int_IndexOf_all",V64_int_IndexOf_all,0);
Run("V64_int_LastIndexOf_absent",V64_int_LastIndexOf_absent,-1);
Run("V64_int_LastIndexOf_first",V64_int_LastIndexOf_first,0);
Run("V64_int_LastIndexOf_last",V64_int_LastIndexOf_last,1);
Run("V64_int_LastIndexOf_all",V64_int_LastIndexOf_all,1);
Run("V64_int_Any_absent",V64_int_Any_absent,0);
Run("V64_int_Any_first",V64_int_Any_first,1);
Run("V64_int_Any_last",V64_int_Any_last,1);
Run("V64_int_Any_all",V64_int_Any_all,1);
Run("V64_int_All_absent",V64_int_All_absent,0);
Run("V64_int_All_first",V64_int_All_first,0);
Run("V64_int_All_last",V64_int_All_last,0);
Run("V64_int_All_all",V64_int_All_all,1);
Run("V64_int_None_absent",V64_int_None_absent,1);
Run("V64_int_None_first",V64_int_None_first,0);
Run("V64_int_None_last",V64_int_None_last,0);
Run("V64_int_None_all",V64_int_None_all,0);
Run("V64_int_CountWhereAllBitsSet_absent",V64_int_CountWhereAllBitsSet_absent,0);
Run("V64_int_CountWhereAllBitsSet_first",V64_int_CountWhereAllBitsSet_first,1);
Run("V64_int_CountWhereAllBitsSet_last",V64_int_CountWhereAllBitsSet_last,1);
Run("V64_int_CountWhereAllBitsSet_all",V64_int_CountWhereAllBitsSet_all,2);
Run("V64_int_IndexOfWhereAllBitsSet_absent",V64_int_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_int_IndexOfWhereAllBitsSet_first",V64_int_IndexOfWhereAllBitsSet_first,0);
Run("V64_int_IndexOfWhereAllBitsSet_last",V64_int_IndexOfWhereAllBitsSet_last,1);
Run("V64_int_IndexOfWhereAllBitsSet_all",V64_int_IndexOfWhereAllBitsSet_all,0);
Run("V64_int_LastIndexOfWhereAllBitsSet_absent",V64_int_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_int_LastIndexOfWhereAllBitsSet_first",V64_int_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_int_LastIndexOfWhereAllBitsSet_last",V64_int_LastIndexOfWhereAllBitsSet_last,1);
Run("V64_int_LastIndexOfWhereAllBitsSet_all",V64_int_LastIndexOfWhereAllBitsSet_all,1);
Run("V64_long_Count_absent",V64_long_Count_absent,0);
Run("V64_long_Count_first",V64_long_Count_first,1);
Run("V64_long_Count_last",V64_long_Count_last,1);
Run("V64_long_Count_all",V64_long_Count_all,1);
Run("V64_long_IndexOf_absent",V64_long_IndexOf_absent,-1);
Run("V64_long_IndexOf_first",V64_long_IndexOf_first,0);
Run("V64_long_IndexOf_last",V64_long_IndexOf_last,0);
Run("V64_long_IndexOf_all",V64_long_IndexOf_all,0);
Run("V64_long_LastIndexOf_absent",V64_long_LastIndexOf_absent,-1);
Run("V64_long_LastIndexOf_first",V64_long_LastIndexOf_first,0);
Run("V64_long_LastIndexOf_last",V64_long_LastIndexOf_last,0);
Run("V64_long_LastIndexOf_all",V64_long_LastIndexOf_all,0);
Run("V64_long_Any_absent",V64_long_Any_absent,0);
Run("V64_long_Any_first",V64_long_Any_first,1);
Run("V64_long_Any_last",V64_long_Any_last,1);
Run("V64_long_Any_all",V64_long_Any_all,1);
Run("V64_long_All_absent",V64_long_All_absent,0);
Run("V64_long_All_first",V64_long_All_first,1);
Run("V64_long_All_last",V64_long_All_last,1);
Run("V64_long_All_all",V64_long_All_all,1);
Run("V64_long_None_absent",V64_long_None_absent,1);
Run("V64_long_None_first",V64_long_None_first,0);
Run("V64_long_None_last",V64_long_None_last,0);
Run("V64_long_None_all",V64_long_None_all,0);
Run("V64_long_CountWhereAllBitsSet_absent",V64_long_CountWhereAllBitsSet_absent,0);
Run("V64_long_CountWhereAllBitsSet_first",V64_long_CountWhereAllBitsSet_first,1);
Run("V64_long_CountWhereAllBitsSet_last",V64_long_CountWhereAllBitsSet_last,1);
Run("V64_long_CountWhereAllBitsSet_all",V64_long_CountWhereAllBitsSet_all,1);
Run("V64_long_IndexOfWhereAllBitsSet_absent",V64_long_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_long_IndexOfWhereAllBitsSet_first",V64_long_IndexOfWhereAllBitsSet_first,0);
Run("V64_long_IndexOfWhereAllBitsSet_last",V64_long_IndexOfWhereAllBitsSet_last,0);
Run("V64_long_IndexOfWhereAllBitsSet_all",V64_long_IndexOfWhereAllBitsSet_all,0);
Run("V64_long_LastIndexOfWhereAllBitsSet_absent",V64_long_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_long_LastIndexOfWhereAllBitsSet_first",V64_long_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_long_LastIndexOfWhereAllBitsSet_last",V64_long_LastIndexOfWhereAllBitsSet_last,0);
Run("V64_long_LastIndexOfWhereAllBitsSet_all",V64_long_LastIndexOfWhereAllBitsSet_all,0);
Run("V64_float_Count_absent",V64_float_Count_absent,0);
Run("V64_float_Count_first",V64_float_Count_first,1);
Run("V64_float_Count_last",V64_float_Count_last,1);
Run("V64_float_Count_all",V64_float_Count_all,2);
Run("V64_float_Count_nan",V64_float_Count_nan,0);
Run("V64_float_IndexOf_absent",V64_float_IndexOf_absent,-1);
Run("V64_float_IndexOf_first",V64_float_IndexOf_first,0);
Run("V64_float_IndexOf_last",V64_float_IndexOf_last,1);
Run("V64_float_IndexOf_all",V64_float_IndexOf_all,0);
Run("V64_float_IndexOf_nan",V64_float_IndexOf_nan,-1);
Run("V64_float_LastIndexOf_absent",V64_float_LastIndexOf_absent,-1);
Run("V64_float_LastIndexOf_first",V64_float_LastIndexOf_first,0);
Run("V64_float_LastIndexOf_last",V64_float_LastIndexOf_last,1);
Run("V64_float_LastIndexOf_all",V64_float_LastIndexOf_all,1);
Run("V64_float_LastIndexOf_nan",V64_float_LastIndexOf_nan,-1);
Run("V64_float_Any_absent",V64_float_Any_absent,0);
Run("V64_float_Any_first",V64_float_Any_first,1);
Run("V64_float_Any_last",V64_float_Any_last,1);
Run("V64_float_Any_all",V64_float_Any_all,1);
Run("V64_float_Any_nan",V64_float_Any_nan,0);
Run("V64_float_All_absent",V64_float_All_absent,0);
Run("V64_float_All_first",V64_float_All_first,0);
Run("V64_float_All_last",V64_float_All_last,0);
Run("V64_float_All_all",V64_float_All_all,1);
Run("V64_float_All_nan",V64_float_All_nan,0);
Run("V64_float_None_absent",V64_float_None_absent,1);
Run("V64_float_None_first",V64_float_None_first,0);
Run("V64_float_None_last",V64_float_None_last,0);
Run("V64_float_None_all",V64_float_None_all,0);
Run("V64_float_None_nan",V64_float_None_nan,1);
Run("V64_float_CountWhereAllBitsSet_absent",V64_float_CountWhereAllBitsSet_absent,0);
Run("V64_float_CountWhereAllBitsSet_first",V64_float_CountWhereAllBitsSet_first,1);
Run("V64_float_CountWhereAllBitsSet_last",V64_float_CountWhereAllBitsSet_last,1);
Run("V64_float_CountWhereAllBitsSet_all",V64_float_CountWhereAllBitsSet_all,2);
Run("V64_float_IndexOfWhereAllBitsSet_absent",V64_float_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_float_IndexOfWhereAllBitsSet_first",V64_float_IndexOfWhereAllBitsSet_first,0);
Run("V64_float_IndexOfWhereAllBitsSet_last",V64_float_IndexOfWhereAllBitsSet_last,1);
Run("V64_float_IndexOfWhereAllBitsSet_all",V64_float_IndexOfWhereAllBitsSet_all,0);
Run("V64_float_LastIndexOfWhereAllBitsSet_absent",V64_float_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_float_LastIndexOfWhereAllBitsSet_first",V64_float_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_float_LastIndexOfWhereAllBitsSet_last",V64_float_LastIndexOfWhereAllBitsSet_last,1);
Run("V64_float_LastIndexOfWhereAllBitsSet_all",V64_float_LastIndexOfWhereAllBitsSet_all,1);
Run("V64_double_Count_absent",V64_double_Count_absent,0);
Run("V64_double_Count_first",V64_double_Count_first,1);
Run("V64_double_Count_last",V64_double_Count_last,1);
Run("V64_double_Count_all",V64_double_Count_all,1);
Run("V64_double_Count_nan",V64_double_Count_nan,0);
Run("V64_double_IndexOf_absent",V64_double_IndexOf_absent,-1);
Run("V64_double_IndexOf_first",V64_double_IndexOf_first,0);
Run("V64_double_IndexOf_last",V64_double_IndexOf_last,0);
Run("V64_double_IndexOf_all",V64_double_IndexOf_all,0);
Run("V64_double_IndexOf_nan",V64_double_IndexOf_nan,-1);
Run("V64_double_LastIndexOf_absent",V64_double_LastIndexOf_absent,-1);
Run("V64_double_LastIndexOf_first",V64_double_LastIndexOf_first,0);
Run("V64_double_LastIndexOf_last",V64_double_LastIndexOf_last,0);
Run("V64_double_LastIndexOf_all",V64_double_LastIndexOf_all,0);
Run("V64_double_LastIndexOf_nan",V64_double_LastIndexOf_nan,-1);
Run("V64_double_Any_absent",V64_double_Any_absent,0);
Run("V64_double_Any_first",V64_double_Any_first,1);
Run("V64_double_Any_last",V64_double_Any_last,1);
Run("V64_double_Any_all",V64_double_Any_all,1);
Run("V64_double_Any_nan",V64_double_Any_nan,0);
Run("V64_double_All_absent",V64_double_All_absent,0);
Run("V64_double_All_first",V64_double_All_first,1);
Run("V64_double_All_last",V64_double_All_last,1);
Run("V64_double_All_all",V64_double_All_all,1);
Run("V64_double_All_nan",V64_double_All_nan,0);
Run("V64_double_None_absent",V64_double_None_absent,1);
Run("V64_double_None_first",V64_double_None_first,0);
Run("V64_double_None_last",V64_double_None_last,0);
Run("V64_double_None_all",V64_double_None_all,0);
Run("V64_double_None_nan",V64_double_None_nan,1);
Run("V64_double_CountWhereAllBitsSet_absent",V64_double_CountWhereAllBitsSet_absent,0);
Run("V64_double_CountWhereAllBitsSet_first",V64_double_CountWhereAllBitsSet_first,1);
Run("V64_double_CountWhereAllBitsSet_last",V64_double_CountWhereAllBitsSet_last,1);
Run("V64_double_CountWhereAllBitsSet_all",V64_double_CountWhereAllBitsSet_all,1);
Run("V64_double_IndexOfWhereAllBitsSet_absent",V64_double_IndexOfWhereAllBitsSet_absent,-1);
Run("V64_double_IndexOfWhereAllBitsSet_first",V64_double_IndexOfWhereAllBitsSet_first,0);
Run("V64_double_IndexOfWhereAllBitsSet_last",V64_double_IndexOfWhereAllBitsSet_last,0);
Run("V64_double_IndexOfWhereAllBitsSet_all",V64_double_IndexOfWhereAllBitsSet_all,0);
Run("V64_double_LastIndexOfWhereAllBitsSet_absent",V64_double_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V64_double_LastIndexOfWhereAllBitsSet_first",V64_double_LastIndexOfWhereAllBitsSet_first,0);
Run("V64_double_LastIndexOfWhereAllBitsSet_last",V64_double_LastIndexOfWhereAllBitsSet_last,0);
Run("V64_double_LastIndexOfWhereAllBitsSet_all",V64_double_LastIndexOfWhereAllBitsSet_all,0);
Run("V128_byte_Count_absent",V128_byte_Count_absent,0);
Run("V128_byte_Count_first",V128_byte_Count_first,1);
Run("V128_byte_Count_last",V128_byte_Count_last,1);
Run("V128_byte_Count_all",V128_byte_Count_all,16);
Run("V128_byte_IndexOf_absent",V128_byte_IndexOf_absent,-1);
Run("V128_byte_IndexOf_first",V128_byte_IndexOf_first,0);
Run("V128_byte_IndexOf_last",V128_byte_IndexOf_last,15);
Run("V128_byte_IndexOf_all",V128_byte_IndexOf_all,0);
Run("V128_byte_LastIndexOf_absent",V128_byte_LastIndexOf_absent,-1);
Run("V128_byte_LastIndexOf_first",V128_byte_LastIndexOf_first,0);
Run("V128_byte_LastIndexOf_last",V128_byte_LastIndexOf_last,15);
Run("V128_byte_LastIndexOf_all",V128_byte_LastIndexOf_all,15);
Run("V128_byte_Any_absent",V128_byte_Any_absent,0);
Run("V128_byte_Any_first",V128_byte_Any_first,1);
Run("V128_byte_Any_last",V128_byte_Any_last,1);
Run("V128_byte_Any_all",V128_byte_Any_all,1);
Run("V128_byte_All_absent",V128_byte_All_absent,0);
Run("V128_byte_All_first",V128_byte_All_first,0);
Run("V128_byte_All_last",V128_byte_All_last,0);
Run("V128_byte_All_all",V128_byte_All_all,1);
Run("V128_byte_None_absent",V128_byte_None_absent,1);
Run("V128_byte_None_first",V128_byte_None_first,0);
Run("V128_byte_None_last",V128_byte_None_last,0);
Run("V128_byte_None_all",V128_byte_None_all,0);
Run("V128_byte_CountWhereAllBitsSet_absent",V128_byte_CountWhereAllBitsSet_absent,0);
Run("V128_byte_CountWhereAllBitsSet_first",V128_byte_CountWhereAllBitsSet_first,1);
Run("V128_byte_CountWhereAllBitsSet_last",V128_byte_CountWhereAllBitsSet_last,1);
Run("V128_byte_CountWhereAllBitsSet_all",V128_byte_CountWhereAllBitsSet_all,16);
Run("V128_byte_IndexOfWhereAllBitsSet_absent",V128_byte_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_byte_IndexOfWhereAllBitsSet_first",V128_byte_IndexOfWhereAllBitsSet_first,0);
Run("V128_byte_IndexOfWhereAllBitsSet_last",V128_byte_IndexOfWhereAllBitsSet_last,15);
Run("V128_byte_IndexOfWhereAllBitsSet_all",V128_byte_IndexOfWhereAllBitsSet_all,0);
Run("V128_byte_LastIndexOfWhereAllBitsSet_absent",V128_byte_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_byte_LastIndexOfWhereAllBitsSet_first",V128_byte_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_byte_LastIndexOfWhereAllBitsSet_last",V128_byte_LastIndexOfWhereAllBitsSet_last,15);
Run("V128_byte_LastIndexOfWhereAllBitsSet_all",V128_byte_LastIndexOfWhereAllBitsSet_all,15);
Run("V128_short_Count_absent",V128_short_Count_absent,0);
Run("V128_short_Count_first",V128_short_Count_first,1);
Run("V128_short_Count_last",V128_short_Count_last,1);
Run("V128_short_Count_all",V128_short_Count_all,8);
Run("V128_short_IndexOf_absent",V128_short_IndexOf_absent,-1);
Run("V128_short_IndexOf_first",V128_short_IndexOf_first,0);
Run("V128_short_IndexOf_last",V128_short_IndexOf_last,7);
Run("V128_short_IndexOf_all",V128_short_IndexOf_all,0);
Run("V128_short_LastIndexOf_absent",V128_short_LastIndexOf_absent,-1);
Run("V128_short_LastIndexOf_first",V128_short_LastIndexOf_first,0);
Run("V128_short_LastIndexOf_last",V128_short_LastIndexOf_last,7);
Run("V128_short_LastIndexOf_all",V128_short_LastIndexOf_all,7);
Run("V128_short_Any_absent",V128_short_Any_absent,0);
Run("V128_short_Any_first",V128_short_Any_first,1);
Run("V128_short_Any_last",V128_short_Any_last,1);
Run("V128_short_Any_all",V128_short_Any_all,1);
Run("V128_short_All_absent",V128_short_All_absent,0);
Run("V128_short_All_first",V128_short_All_first,0);
Run("V128_short_All_last",V128_short_All_last,0);
Run("V128_short_All_all",V128_short_All_all,1);
Run("V128_short_None_absent",V128_short_None_absent,1);
Run("V128_short_None_first",V128_short_None_first,0);
Run("V128_short_None_last",V128_short_None_last,0);
Run("V128_short_None_all",V128_short_None_all,0);
Run("V128_short_CountWhereAllBitsSet_absent",V128_short_CountWhereAllBitsSet_absent,0);
Run("V128_short_CountWhereAllBitsSet_first",V128_short_CountWhereAllBitsSet_first,1);
Run("V128_short_CountWhereAllBitsSet_last",V128_short_CountWhereAllBitsSet_last,1);
Run("V128_short_CountWhereAllBitsSet_all",V128_short_CountWhereAllBitsSet_all,8);
Run("V128_short_IndexOfWhereAllBitsSet_absent",V128_short_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_short_IndexOfWhereAllBitsSet_first",V128_short_IndexOfWhereAllBitsSet_first,0);
Run("V128_short_IndexOfWhereAllBitsSet_last",V128_short_IndexOfWhereAllBitsSet_last,7);
Run("V128_short_IndexOfWhereAllBitsSet_all",V128_short_IndexOfWhereAllBitsSet_all,0);
Run("V128_short_LastIndexOfWhereAllBitsSet_absent",V128_short_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_short_LastIndexOfWhereAllBitsSet_first",V128_short_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_short_LastIndexOfWhereAllBitsSet_last",V128_short_LastIndexOfWhereAllBitsSet_last,7);
Run("V128_short_LastIndexOfWhereAllBitsSet_all",V128_short_LastIndexOfWhereAllBitsSet_all,7);
Run("V128_int_Count_absent",V128_int_Count_absent,0);
Run("V128_int_Count_first",V128_int_Count_first,1);
Run("V128_int_Count_last",V128_int_Count_last,1);
Run("V128_int_Count_all",V128_int_Count_all,4);
Run("V128_int_IndexOf_absent",V128_int_IndexOf_absent,-1);
Run("V128_int_IndexOf_first",V128_int_IndexOf_first,0);
Run("V128_int_IndexOf_last",V128_int_IndexOf_last,3);
Run("V128_int_IndexOf_all",V128_int_IndexOf_all,0);
Run("V128_int_LastIndexOf_absent",V128_int_LastIndexOf_absent,-1);
Run("V128_int_LastIndexOf_first",V128_int_LastIndexOf_first,0);
Run("V128_int_LastIndexOf_last",V128_int_LastIndexOf_last,3);
Run("V128_int_LastIndexOf_all",V128_int_LastIndexOf_all,3);
Run("V128_int_Any_absent",V128_int_Any_absent,0);
Run("V128_int_Any_first",V128_int_Any_first,1);
Run("V128_int_Any_last",V128_int_Any_last,1);
Run("V128_int_Any_all",V128_int_Any_all,1);
Run("V128_int_All_absent",V128_int_All_absent,0);
Run("V128_int_All_first",V128_int_All_first,0);
Run("V128_int_All_last",V128_int_All_last,0);
Run("V128_int_All_all",V128_int_All_all,1);
Run("V128_int_None_absent",V128_int_None_absent,1);
Run("V128_int_None_first",V128_int_None_first,0);
Run("V128_int_None_last",V128_int_None_last,0);
Run("V128_int_None_all",V128_int_None_all,0);
Run("V128_int_CountWhereAllBitsSet_absent",V128_int_CountWhereAllBitsSet_absent,0);
Run("V128_int_CountWhereAllBitsSet_first",V128_int_CountWhereAllBitsSet_first,1);
Run("V128_int_CountWhereAllBitsSet_last",V128_int_CountWhereAllBitsSet_last,1);
Run("V128_int_CountWhereAllBitsSet_all",V128_int_CountWhereAllBitsSet_all,4);
Run("V128_int_IndexOfWhereAllBitsSet_absent",V128_int_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_int_IndexOfWhereAllBitsSet_first",V128_int_IndexOfWhereAllBitsSet_first,0);
Run("V128_int_IndexOfWhereAllBitsSet_last",V128_int_IndexOfWhereAllBitsSet_last,3);
Run("V128_int_IndexOfWhereAllBitsSet_all",V128_int_IndexOfWhereAllBitsSet_all,0);
Run("V128_int_LastIndexOfWhereAllBitsSet_absent",V128_int_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_int_LastIndexOfWhereAllBitsSet_first",V128_int_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_int_LastIndexOfWhereAllBitsSet_last",V128_int_LastIndexOfWhereAllBitsSet_last,3);
Run("V128_int_LastIndexOfWhereAllBitsSet_all",V128_int_LastIndexOfWhereAllBitsSet_all,3);
Run("V128_long_Count_absent",V128_long_Count_absent,0);
Run("V128_long_Count_first",V128_long_Count_first,1);
Run("V128_long_Count_last",V128_long_Count_last,1);
Run("V128_long_Count_all",V128_long_Count_all,2);
Run("V128_long_IndexOf_absent",V128_long_IndexOf_absent,-1);
Run("V128_long_IndexOf_first",V128_long_IndexOf_first,0);
Run("V128_long_IndexOf_last",V128_long_IndexOf_last,1);
Run("V128_long_IndexOf_all",V128_long_IndexOf_all,0);
Run("V128_long_LastIndexOf_absent",V128_long_LastIndexOf_absent,-1);
Run("V128_long_LastIndexOf_first",V128_long_LastIndexOf_first,0);
Run("V128_long_LastIndexOf_last",V128_long_LastIndexOf_last,1);
Run("V128_long_LastIndexOf_all",V128_long_LastIndexOf_all,1);
Run("V128_long_Any_absent",V128_long_Any_absent,0);
Run("V128_long_Any_first",V128_long_Any_first,1);
Run("V128_long_Any_last",V128_long_Any_last,1);
Run("V128_long_Any_all",V128_long_Any_all,1);
Run("V128_long_All_absent",V128_long_All_absent,0);
Run("V128_long_All_first",V128_long_All_first,0);
Run("V128_long_All_last",V128_long_All_last,0);
Run("V128_long_All_all",V128_long_All_all,1);
Run("V128_long_None_absent",V128_long_None_absent,1);
Run("V128_long_None_first",V128_long_None_first,0);
Run("V128_long_None_last",V128_long_None_last,0);
Run("V128_long_None_all",V128_long_None_all,0);
Run("V128_long_CountWhereAllBitsSet_absent",V128_long_CountWhereAllBitsSet_absent,0);
Run("V128_long_CountWhereAllBitsSet_first",V128_long_CountWhereAllBitsSet_first,1);
Run("V128_long_CountWhereAllBitsSet_last",V128_long_CountWhereAllBitsSet_last,1);
Run("V128_long_CountWhereAllBitsSet_all",V128_long_CountWhereAllBitsSet_all,2);
Run("V128_long_IndexOfWhereAllBitsSet_absent",V128_long_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_long_IndexOfWhereAllBitsSet_first",V128_long_IndexOfWhereAllBitsSet_first,0);
Run("V128_long_IndexOfWhereAllBitsSet_last",V128_long_IndexOfWhereAllBitsSet_last,1);
Run("V128_long_IndexOfWhereAllBitsSet_all",V128_long_IndexOfWhereAllBitsSet_all,0);
Run("V128_long_LastIndexOfWhereAllBitsSet_absent",V128_long_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_long_LastIndexOfWhereAllBitsSet_first",V128_long_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_long_LastIndexOfWhereAllBitsSet_last",V128_long_LastIndexOfWhereAllBitsSet_last,1);
Run("V128_long_LastIndexOfWhereAllBitsSet_all",V128_long_LastIndexOfWhereAllBitsSet_all,1);
Run("V128_float_Count_absent",V128_float_Count_absent,0);
Run("V128_float_Count_first",V128_float_Count_first,1);
Run("V128_float_Count_last",V128_float_Count_last,1);
Run("V128_float_Count_all",V128_float_Count_all,4);
Run("V128_float_Count_nan",V128_float_Count_nan,0);
Run("V128_float_IndexOf_absent",V128_float_IndexOf_absent,-1);
Run("V128_float_IndexOf_first",V128_float_IndexOf_first,0);
Run("V128_float_IndexOf_last",V128_float_IndexOf_last,3);
Run("V128_float_IndexOf_all",V128_float_IndexOf_all,0);
Run("V128_float_IndexOf_nan",V128_float_IndexOf_nan,-1);
Run("V128_float_LastIndexOf_absent",V128_float_LastIndexOf_absent,-1);
Run("V128_float_LastIndexOf_first",V128_float_LastIndexOf_first,0);
Run("V128_float_LastIndexOf_last",V128_float_LastIndexOf_last,3);
Run("V128_float_LastIndexOf_all",V128_float_LastIndexOf_all,3);
Run("V128_float_LastIndexOf_nan",V128_float_LastIndexOf_nan,-1);
Run("V128_float_Any_absent",V128_float_Any_absent,0);
Run("V128_float_Any_first",V128_float_Any_first,1);
Run("V128_float_Any_last",V128_float_Any_last,1);
Run("V128_float_Any_all",V128_float_Any_all,1);
Run("V128_float_Any_nan",V128_float_Any_nan,0);
Run("V128_float_All_absent",V128_float_All_absent,0);
Run("V128_float_All_first",V128_float_All_first,0);
Run("V128_float_All_last",V128_float_All_last,0);
Run("V128_float_All_all",V128_float_All_all,1);
Run("V128_float_All_nan",V128_float_All_nan,0);
Run("V128_float_None_absent",V128_float_None_absent,1);
Run("V128_float_None_first",V128_float_None_first,0);
Run("V128_float_None_last",V128_float_None_last,0);
Run("V128_float_None_all",V128_float_None_all,0);
Run("V128_float_None_nan",V128_float_None_nan,1);
Run("V128_float_CountWhereAllBitsSet_absent",V128_float_CountWhereAllBitsSet_absent,0);
Run("V128_float_CountWhereAllBitsSet_first",V128_float_CountWhereAllBitsSet_first,1);
Run("V128_float_CountWhereAllBitsSet_last",V128_float_CountWhereAllBitsSet_last,1);
Run("V128_float_CountWhereAllBitsSet_all",V128_float_CountWhereAllBitsSet_all,4);
Run("V128_float_IndexOfWhereAllBitsSet_absent",V128_float_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_float_IndexOfWhereAllBitsSet_first",V128_float_IndexOfWhereAllBitsSet_first,0);
Run("V128_float_IndexOfWhereAllBitsSet_last",V128_float_IndexOfWhereAllBitsSet_last,3);
Run("V128_float_IndexOfWhereAllBitsSet_all",V128_float_IndexOfWhereAllBitsSet_all,0);
Run("V128_float_LastIndexOfWhereAllBitsSet_absent",V128_float_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_float_LastIndexOfWhereAllBitsSet_first",V128_float_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_float_LastIndexOfWhereAllBitsSet_last",V128_float_LastIndexOfWhereAllBitsSet_last,3);
Run("V128_float_LastIndexOfWhereAllBitsSet_all",V128_float_LastIndexOfWhereAllBitsSet_all,3);
Run("V128_double_Count_absent",V128_double_Count_absent,0);
Run("V128_double_Count_first",V128_double_Count_first,1);
Run("V128_double_Count_last",V128_double_Count_last,1);
Run("V128_double_Count_all",V128_double_Count_all,2);
Run("V128_double_Count_nan",V128_double_Count_nan,0);
Run("V128_double_IndexOf_absent",V128_double_IndexOf_absent,-1);
Run("V128_double_IndexOf_first",V128_double_IndexOf_first,0);
Run("V128_double_IndexOf_last",V128_double_IndexOf_last,1);
Run("V128_double_IndexOf_all",V128_double_IndexOf_all,0);
Run("V128_double_IndexOf_nan",V128_double_IndexOf_nan,-1);
Run("V128_double_LastIndexOf_absent",V128_double_LastIndexOf_absent,-1);
Run("V128_double_LastIndexOf_first",V128_double_LastIndexOf_first,0);
Run("V128_double_LastIndexOf_last",V128_double_LastIndexOf_last,1);
Run("V128_double_LastIndexOf_all",V128_double_LastIndexOf_all,1);
Run("V128_double_LastIndexOf_nan",V128_double_LastIndexOf_nan,-1);
Run("V128_double_Any_absent",V128_double_Any_absent,0);
Run("V128_double_Any_first",V128_double_Any_first,1);
Run("V128_double_Any_last",V128_double_Any_last,1);
Run("V128_double_Any_all",V128_double_Any_all,1);
Run("V128_double_Any_nan",V128_double_Any_nan,0);
Run("V128_double_All_absent",V128_double_All_absent,0);
Run("V128_double_All_first",V128_double_All_first,0);
Run("V128_double_All_last",V128_double_All_last,0);
Run("V128_double_All_all",V128_double_All_all,1);
Run("V128_double_All_nan",V128_double_All_nan,0);
Run("V128_double_None_absent",V128_double_None_absent,1);
Run("V128_double_None_first",V128_double_None_first,0);
Run("V128_double_None_last",V128_double_None_last,0);
Run("V128_double_None_all",V128_double_None_all,0);
Run("V128_double_None_nan",V128_double_None_nan,1);
Run("V128_double_CountWhereAllBitsSet_absent",V128_double_CountWhereAllBitsSet_absent,0);
Run("V128_double_CountWhereAllBitsSet_first",V128_double_CountWhereAllBitsSet_first,1);
Run("V128_double_CountWhereAllBitsSet_last",V128_double_CountWhereAllBitsSet_last,1);
Run("V128_double_CountWhereAllBitsSet_all",V128_double_CountWhereAllBitsSet_all,2);
Run("V128_double_IndexOfWhereAllBitsSet_absent",V128_double_IndexOfWhereAllBitsSet_absent,-1);
Run("V128_double_IndexOfWhereAllBitsSet_first",V128_double_IndexOfWhereAllBitsSet_first,0);
Run("V128_double_IndexOfWhereAllBitsSet_last",V128_double_IndexOfWhereAllBitsSet_last,1);
Run("V128_double_IndexOfWhereAllBitsSet_all",V128_double_IndexOfWhereAllBitsSet_all,0);
Run("V128_double_LastIndexOfWhereAllBitsSet_absent",V128_double_LastIndexOfWhereAllBitsSet_absent,-1);
Run("V128_double_LastIndexOfWhereAllBitsSet_first",V128_double_LastIndexOfWhereAllBitsSet_first,0);
Run("V128_double_LastIndexOfWhereAllBitsSet_last",V128_double_LastIndexOfWhereAllBitsSet_last,1);
Run("V128_double_LastIndexOfWhereAllBitsSet_all",V128_double_LastIndexOfWhereAllBitsSet_all,1);
Run("Span_byte_16_IndexOf_absent",Span_byte_16_IndexOf_absent,-1);
Run("Span_byte_16_IndexOf_first",Span_byte_16_IndexOf_first,0);
Run("Span_byte_16_IndexOf_last",Span_byte_16_IndexOf_last,15);
Run("Span_byte_16_IndexOf_all",Span_byte_16_IndexOf_all,0);
Run("Span_byte_16_LastIndexOf_absent",Span_byte_16_LastIndexOf_absent,-1);
Run("Span_byte_16_LastIndexOf_first",Span_byte_16_LastIndexOf_first,0);
Run("Span_byte_16_LastIndexOf_last",Span_byte_16_LastIndexOf_last,15);
Run("Span_byte_16_LastIndexOf_all",Span_byte_16_LastIndexOf_all,15);
Run("Span_byte_16_Count_absent",Span_byte_16_Count_absent,0);
Run("Span_byte_16_Count_first",Span_byte_16_Count_first,1);
Run("Span_byte_16_Count_last",Span_byte_16_Count_last,1);
Run("Span_byte_16_Count_all",Span_byte_16_Count_all,16);
Run("Span_byte_64_IndexOf_absent",Span_byte_64_IndexOf_absent,-1);
Run("Span_byte_64_IndexOf_first",Span_byte_64_IndexOf_first,0);
Run("Span_byte_64_IndexOf_last",Span_byte_64_IndexOf_last,63);
Run("Span_byte_64_IndexOf_all",Span_byte_64_IndexOf_all,0);
Run("Span_byte_64_LastIndexOf_absent",Span_byte_64_LastIndexOf_absent,-1);
Run("Span_byte_64_LastIndexOf_first",Span_byte_64_LastIndexOf_first,0);
Run("Span_byte_64_LastIndexOf_last",Span_byte_64_LastIndexOf_last,63);
Run("Span_byte_64_LastIndexOf_all",Span_byte_64_LastIndexOf_all,63);
Run("Span_byte_64_Count_absent",Span_byte_64_Count_absent,0);
Run("Span_byte_64_Count_first",Span_byte_64_Count_first,1);
Run("Span_byte_64_Count_last",Span_byte_64_Count_last,1);
Run("Span_byte_64_Count_all",Span_byte_64_Count_all,64);
Run("Span_byte_256_IndexOf_absent",Span_byte_256_IndexOf_absent,-1);
Run("Span_byte_256_IndexOf_first",Span_byte_256_IndexOf_first,0);
Run("Span_byte_256_IndexOf_last",Span_byte_256_IndexOf_last,255);
Run("Span_byte_256_IndexOf_all",Span_byte_256_IndexOf_all,0);
Run("Span_byte_256_LastIndexOf_absent",Span_byte_256_LastIndexOf_absent,-1);
Run("Span_byte_256_LastIndexOf_first",Span_byte_256_LastIndexOf_first,0);
Run("Span_byte_256_LastIndexOf_last",Span_byte_256_LastIndexOf_last,255);
Run("Span_byte_256_LastIndexOf_all",Span_byte_256_LastIndexOf_all,255);
Run("Span_byte_256_Count_absent",Span_byte_256_Count_absent,0);
Run("Span_byte_256_Count_first",Span_byte_256_Count_first,1);
Run("Span_byte_256_Count_last",Span_byte_256_Count_last,1);
Run("Span_byte_256_Count_all",Span_byte_256_Count_all,256);
Run("Span_byte_4096_IndexOf_absent",Span_byte_4096_IndexOf_absent,-1);
Run("Span_byte_4096_IndexOf_first",Span_byte_4096_IndexOf_first,0);
Run("Span_byte_4096_IndexOf_last",Span_byte_4096_IndexOf_last,4095);
Run("Span_byte_4096_IndexOf_all",Span_byte_4096_IndexOf_all,0);
Run("Span_byte_4096_LastIndexOf_absent",Span_byte_4096_LastIndexOf_absent,-1);
Run("Span_byte_4096_LastIndexOf_first",Span_byte_4096_LastIndexOf_first,0);
Run("Span_byte_4096_LastIndexOf_last",Span_byte_4096_LastIndexOf_last,4095);
Run("Span_byte_4096_LastIndexOf_all",Span_byte_4096_LastIndexOf_all,4095);
Run("Span_byte_4096_Count_absent",Span_byte_4096_Count_absent,0);
Run("Span_byte_4096_Count_first",Span_byte_4096_Count_first,1);
Run("Span_byte_4096_Count_last",Span_byte_4096_Count_last,1);
Run("Span_byte_4096_Count_all",Span_byte_4096_Count_all,4096);
Run("Span_short_16_IndexOf_absent",Span_short_16_IndexOf_absent,-1);
Run("Span_short_16_IndexOf_first",Span_short_16_IndexOf_first,0);
Run("Span_short_16_IndexOf_last",Span_short_16_IndexOf_last,15);
Run("Span_short_16_IndexOf_all",Span_short_16_IndexOf_all,0);
Run("Span_short_16_LastIndexOf_absent",Span_short_16_LastIndexOf_absent,-1);
Run("Span_short_16_LastIndexOf_first",Span_short_16_LastIndexOf_first,0);
Run("Span_short_16_LastIndexOf_last",Span_short_16_LastIndexOf_last,15);
Run("Span_short_16_LastIndexOf_all",Span_short_16_LastIndexOf_all,15);
Run("Span_short_16_Count_absent",Span_short_16_Count_absent,0);
Run("Span_short_16_Count_first",Span_short_16_Count_first,1);
Run("Span_short_16_Count_last",Span_short_16_Count_last,1);
Run("Span_short_16_Count_all",Span_short_16_Count_all,16);
Run("Span_short_64_IndexOf_absent",Span_short_64_IndexOf_absent,-1);
Run("Span_short_64_IndexOf_first",Span_short_64_IndexOf_first,0);
Run("Span_short_64_IndexOf_last",Span_short_64_IndexOf_last,63);
Run("Span_short_64_IndexOf_all",Span_short_64_IndexOf_all,0);
Run("Span_short_64_LastIndexOf_absent",Span_short_64_LastIndexOf_absent,-1);
Run("Span_short_64_LastIndexOf_first",Span_short_64_LastIndexOf_first,0);
Run("Span_short_64_LastIndexOf_last",Span_short_64_LastIndexOf_last,63);
Run("Span_short_64_LastIndexOf_all",Span_short_64_LastIndexOf_all,63);
Run("Span_short_64_Count_absent",Span_short_64_Count_absent,0);
Run("Span_short_64_Count_first",Span_short_64_Count_first,1);
Run("Span_short_64_Count_last",Span_short_64_Count_last,1);
Run("Span_short_64_Count_all",Span_short_64_Count_all,64);
Run("Span_short_256_IndexOf_absent",Span_short_256_IndexOf_absent,-1);
Run("Span_short_256_IndexOf_first",Span_short_256_IndexOf_first,0);
Run("Span_short_256_IndexOf_last",Span_short_256_IndexOf_last,255);
Run("Span_short_256_IndexOf_all",Span_short_256_IndexOf_all,0);
Run("Span_short_256_LastIndexOf_absent",Span_short_256_LastIndexOf_absent,-1);
Run("Span_short_256_LastIndexOf_first",Span_short_256_LastIndexOf_first,0);
Run("Span_short_256_LastIndexOf_last",Span_short_256_LastIndexOf_last,255);
Run("Span_short_256_LastIndexOf_all",Span_short_256_LastIndexOf_all,255);
Run("Span_short_256_Count_absent",Span_short_256_Count_absent,0);
Run("Span_short_256_Count_first",Span_short_256_Count_first,1);
Run("Span_short_256_Count_last",Span_short_256_Count_last,1);
Run("Span_short_256_Count_all",Span_short_256_Count_all,256);
Run("Span_short_4096_IndexOf_absent",Span_short_4096_IndexOf_absent,-1);
Run("Span_short_4096_IndexOf_first",Span_short_4096_IndexOf_first,0);
Run("Span_short_4096_IndexOf_last",Span_short_4096_IndexOf_last,4095);
Run("Span_short_4096_IndexOf_all",Span_short_4096_IndexOf_all,0);
Run("Span_short_4096_LastIndexOf_absent",Span_short_4096_LastIndexOf_absent,-1);
Run("Span_short_4096_LastIndexOf_first",Span_short_4096_LastIndexOf_first,0);
Run("Span_short_4096_LastIndexOf_last",Span_short_4096_LastIndexOf_last,4095);
Run("Span_short_4096_LastIndexOf_all",Span_short_4096_LastIndexOf_all,4095);
Run("Span_short_4096_Count_absent",Span_short_4096_Count_absent,0);
Run("Span_short_4096_Count_first",Span_short_4096_Count_first,1);
Run("Span_short_4096_Count_last",Span_short_4096_Count_last,1);
Run("Span_short_4096_Count_all",Span_short_4096_Count_all,4096);
Run("Span_int_16_IndexOf_absent",Span_int_16_IndexOf_absent,-1);
Run("Span_int_16_IndexOf_first",Span_int_16_IndexOf_first,0);
Run("Span_int_16_IndexOf_last",Span_int_16_IndexOf_last,15);
Run("Span_int_16_IndexOf_all",Span_int_16_IndexOf_all,0);
Run("Span_int_16_LastIndexOf_absent",Span_int_16_LastIndexOf_absent,-1);
Run("Span_int_16_LastIndexOf_first",Span_int_16_LastIndexOf_first,0);
Run("Span_int_16_LastIndexOf_last",Span_int_16_LastIndexOf_last,15);
Run("Span_int_16_LastIndexOf_all",Span_int_16_LastIndexOf_all,15);
Run("Span_int_16_Count_absent",Span_int_16_Count_absent,0);
Run("Span_int_16_Count_first",Span_int_16_Count_first,1);
Run("Span_int_16_Count_last",Span_int_16_Count_last,1);
Run("Span_int_16_Count_all",Span_int_16_Count_all,16);
Run("Span_int_64_IndexOf_absent",Span_int_64_IndexOf_absent,-1);
Run("Span_int_64_IndexOf_first",Span_int_64_IndexOf_first,0);
Run("Span_int_64_IndexOf_last",Span_int_64_IndexOf_last,63);
Run("Span_int_64_IndexOf_all",Span_int_64_IndexOf_all,0);
Run("Span_int_64_LastIndexOf_absent",Span_int_64_LastIndexOf_absent,-1);
Run("Span_int_64_LastIndexOf_first",Span_int_64_LastIndexOf_first,0);
Run("Span_int_64_LastIndexOf_last",Span_int_64_LastIndexOf_last,63);
Run("Span_int_64_LastIndexOf_all",Span_int_64_LastIndexOf_all,63);
Run("Span_int_64_Count_absent",Span_int_64_Count_absent,0);
Run("Span_int_64_Count_first",Span_int_64_Count_first,1);
Run("Span_int_64_Count_last",Span_int_64_Count_last,1);
Run("Span_int_64_Count_all",Span_int_64_Count_all,64);
Run("Span_int_256_IndexOf_absent",Span_int_256_IndexOf_absent,-1);
Run("Span_int_256_IndexOf_first",Span_int_256_IndexOf_first,0);
Run("Span_int_256_IndexOf_last",Span_int_256_IndexOf_last,255);
Run("Span_int_256_IndexOf_all",Span_int_256_IndexOf_all,0);
Run("Span_int_256_LastIndexOf_absent",Span_int_256_LastIndexOf_absent,-1);
Run("Span_int_256_LastIndexOf_first",Span_int_256_LastIndexOf_first,0);
Run("Span_int_256_LastIndexOf_last",Span_int_256_LastIndexOf_last,255);
Run("Span_int_256_LastIndexOf_all",Span_int_256_LastIndexOf_all,255);
Run("Span_int_256_Count_absent",Span_int_256_Count_absent,0);
Run("Span_int_256_Count_first",Span_int_256_Count_first,1);
Run("Span_int_256_Count_last",Span_int_256_Count_last,1);
Run("Span_int_256_Count_all",Span_int_256_Count_all,256);
Run("Span_int_4096_IndexOf_absent",Span_int_4096_IndexOf_absent,-1);
Run("Span_int_4096_IndexOf_first",Span_int_4096_IndexOf_first,0);
Run("Span_int_4096_IndexOf_last",Span_int_4096_IndexOf_last,4095);
Run("Span_int_4096_IndexOf_all",Span_int_4096_IndexOf_all,0);
Run("Span_int_4096_LastIndexOf_absent",Span_int_4096_LastIndexOf_absent,-1);
Run("Span_int_4096_LastIndexOf_first",Span_int_4096_LastIndexOf_first,0);
Run("Span_int_4096_LastIndexOf_last",Span_int_4096_LastIndexOf_last,4095);
Run("Span_int_4096_LastIndexOf_all",Span_int_4096_LastIndexOf_all,4095);
Run("Span_int_4096_Count_absent",Span_int_4096_Count_absent,0);
Run("Span_int_4096_Count_first",Span_int_4096_Count_first,1);
Run("Span_int_4096_Count_last",Span_int_4096_Count_last,1);
Run("Span_int_4096_Count_all",Span_int_4096_Count_all,4096);
}}
