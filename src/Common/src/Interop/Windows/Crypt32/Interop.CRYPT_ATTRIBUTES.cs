// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal unsafe struct CRYPT_ATTRIBUTES
        {
            internal int cAttr;
            internal CRYPT_ATTRIBUTE* rgAttr;
        }
    }
}
