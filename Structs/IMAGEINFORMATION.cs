using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    internal struct IMAGEINFORMATION
    {
        public byte PixelType;			// PT_BW: Black and White, PT_GRAY: 8-bit Gray, PT_RGB: 24-bit Color
        public ushort Resolution;
        public uint Width;
        public uint Length;
        public uint BytesPerLine;
        public byte Compression;		// Supported type CP_NONE, CP_GROUP4, CP_JPEG
        public uint CompressedSize;		// Size of the compressed image, it should be 0 without any compression.
        public IntPtr pBarcodeAdderss;
        public byte PatchCode;
        public uint PageNumber;         // Page Number, 1, 2, 3, 4 ...
        public byte TopBottom;          // Top 1, Bottom 2
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public byte[] Reserved;
    };
}
