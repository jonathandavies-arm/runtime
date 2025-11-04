// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace TestI121294
{
    public class Program
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        [Fact]
        public static int CheckI121294()
        {
            bool fail = true;


            if ((-M3()) >= 0)
            {
                ulong vr3 = default(ulong);
                System.Console.WriteLine(vr3);
                fail = false;
            }
        
            if (fail)
            {
                return 101;
            }
            return 100;
        }

        public static long M3()
        {
            ulong var0 = default(ulong);
            System.Console.WriteLine(var0);
            return -9223372036854775808L;
        }
    }
}
