using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct INITLIBPARAM
    {
        public IntPtr szLicense;
        public byte DriverMode;
        public IntPtr APWnd;
        public ushort MajorNumber;
        public ushort MinorNumber;
        public IntPtr szManufacturer;
        public IntPtr szProduct;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Reserved;
    };
}
