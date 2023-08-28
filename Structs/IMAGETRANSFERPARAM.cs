using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct IMAGETRANSFERPARAM
    {
        public IntPtr pImageData;
        public uint XferSize;
        public byte Status;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Reserved;
    };
}
