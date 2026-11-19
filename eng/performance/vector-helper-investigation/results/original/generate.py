from pathlib import Path
p=Path(__file__).parent
(p/'Bench.csproj').write_text('<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net12.0</TargetFramework><AllowUnsafeBlocks>true</AllowUnsafeBlocks><Optimize>true</Optimize><EnableDefaultCompileItems>false</EnableDefaultCompileItems></PropertyGroup><ItemGroup><Compile Include="Program.cs"/></ItemGroup></Project>')
s=['using System; using System.Diagnostics; using System.Runtime.CompilerServices; using System.Runtime.Intrinsics; class Bench { static int sink;']
registrations=[]
for width in [64,128]:
 for typ,size,val in [('byte',1,'(byte)2'),('short',2,'(short)2'),('int',4,'2'),('long',8,'2L'),('float',4,'2f'),('double',8,'2d')]:
  lanes=width//8//size
  for op in ['Count','IndexOf','LastIndexOf','Any','All','None','CountWhereAllBitsSet','IndexOfWhereAllBitsSet','LastIndexOfWhereAllBitsSet']:
   bits='Where' in op
   for pattern in ['absent','first','last','all']+(['nan'] if typ in ['float','double'] and not bits else []):
    name=f'V{width}_{typ}_{op}_{pattern}';v=f'Vector{width}<{typ}>'; field='d'+name
    target=f'{typ}.NaN' if pattern=='nan' else val
    # NaN inputs include NaNs and the target is NaN; scalar Equals semantics.
    element=(f'Vector{width}<{typ}>.AllBitsSet.GetElement(0)' if bits else target)
    expr=f'Vector{width}<{typ}>.Zero'
    if pattern in ['all','nan']:expr=f'Vector{width}.Create({element})'
    elif pattern!='absent':expr+=f'.WithElement({0 if pattern=="first" else lanes-1}, {element})'
    s.append(f'static {v}[] {field}=Make({expr});')
    call=f'Vector{width}.{op}({field}[i & 255]'+(')' if bits else f', {target})')
    if op in ['Any','All','None']:call=f'({call} ? 1 : 0)'
    s.append(f'[MethodImpl(MethodImplOptions.NoInlining)] static int {name}(int n) {{ int r=0; for(int i=0;i<n;i++) r+={call}; return r; }}')
    matches=lanes if pattern=='all' else 0 if pattern in ['absent','nan'] else 1
    expected=matches if op.startswith('Count') else (-1 if not matches else 0 if pattern in ['first','all','nan'] or lanes==1 else lanes-1) if op.startswith('IndexOf') else (-1 if not matches else lanes-1 if pattern in ['last','all','nan'] else 0) if op.startswith('LastIndexOf') else int(matches>0) if op=='Any' else int(matches==lanes) if op=='All' else int(matches==0)
    registrations.append(f'Run("{name}",{name},{expected});')
for typ,val in [('byte','(byte)2'),('short','(short)2'),('int','2')]:
 for length in [16,64,256,4096]:
  for op in ['IndexOf','LastIndexOf','Count']:
   for pattern in ['absent','first','last','all']:
    name=f'Span_{typ}_{length}_{op}_{pattern}'; field='d'+name
    s.append(f'static {typ}[] {field}=MakeSpan<{typ}>({length},{val},"{pattern}");')
    s.append(f'[MethodImpl(MethodImplOptions.NoInlining)] static int {name}(int n) {{ int r=0; for(int i=0;i<n;i++) r+=MemoryExtensions.{op}<{typ}>({field}.AsSpan(),{val}); return r; }}')
    expected=(length if pattern=='all' else 0 if pattern=='absent' else 1) if op=='Count' else -1 if pattern=='absent' else (length-1 if pattern=='last' or (op=='LastIndexOf' and pattern=='all') else 0)
    registrations.append(f'Run("{name}",{name},{expected});')
s.append('static T[] MakeSpan<T>(int n,T v,string pattern) {var a=new T[n]; if(pattern=="all") Array.Fill(a,v); else if(pattern!="absent") a[pattern=="first"?0:n-1]=v; return a;}')
s.append('static T[] Make<T>(T v) { var a=new T[256]; Array.Fill(a,v); return a; }')
s.append('''static void Run(string name, Func<int,int> f, int expected) {
 if(Environment.GetEnvironmentVariable("PERF_FILTER") is string filter && !Array.Exists(filter.Split('|'),x=>name==x)) return;
 if(f(256)!=expected*256) throw new Exception(name+" correctness failed: "+f(256)+" expected "+expected*256);
 int n=4096; for(int i=0;i<3;i++) sink=f(n);
 long ticks=0,ops=0; var total=Stopwatch.StartNew(); do {long start=Stopwatch.GetTimestamp();sink=f(n);ticks+=Stopwatch.GetTimestamp()-start;ops+=n;}while(total.Elapsed.TotalMilliseconds<(int.TryParse(Environment.GetEnvironmentVariable("PERF_MS"),out int ms)?ms:10));
 Console.WriteLine($"{name},{ticks*1e9/Stopwatch.Frequency/ops:F5}"); }
 static void Main(){ Console.WriteLine("case,ns");''')
s+=registrations
s.append('}}')
(p/'Program.cs').write_text('\n'.join(s))
print(len(registrations),'cases')
