// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport("api-ms-win-core-errorhandling-l1-1-0.dll")]
        internal extern static int GetLastError();
    }
}
