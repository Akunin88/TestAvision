using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Ansi)]
    internal struct SELECTSCANNERPARAM
    {
        public bool ShowSelect;
        public ushort Count;
        public IntPtr pAvailableScanner;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] DefaultScanner;
        public byte DeviceOnline; // 0: All;  1: Device on line only, 0x80: Only Search For Device Array (For AD230 series)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
        public byte[] Reserved;
    };
}
