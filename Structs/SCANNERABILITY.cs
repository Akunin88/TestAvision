using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    internal struct SCANNERABILITY
    {
        public ushort ScanMethod { get; set; }				// bit 0: Flatbed, bit 1: Sheetfeed, bit 2: Duplex
        public uint MaxWidth { get; set; }					// Unit = 1/300 inch
        public uint MaxLength { get; set; }					// Unit = 1/300 inch
        public ushort MaxResolution { get; set; }			// Dots Per Pixel
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] InternalName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] FirmwareVersion;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public byte[] SerialNumber;
        public byte SupportBarcode { get; set; }
        public byte SupportImprinter { get; set; }
        public byte SupportMICR { get; set; }
        public uint MaxLongLength { get; set; }	          // Unit = 1/300 inch
        public uint MinWidth { get; set; }	               // Unit = 1/300 inch
        public uint MinLength { get; set; }					// Unit = 1/300 inch
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
        public byte[] Reserved;
    };
}
