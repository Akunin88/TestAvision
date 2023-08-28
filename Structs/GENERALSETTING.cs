using Avision.Enums;
using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct GENERALSETTING
    {
        public byte PixelType;				// PT_BW: Black and White, PT_GRAY: 8-bit Gray, PT_RGB: 24-bit Color
        public byte PaperSize;
        public ushort XPos;					// Unit = 1/300 inch
        public ushort YPos;					// Unit = 1/300 inch
        public uint Width;					// Unit = 1/300 inch
        public uint Length;					// Unit = 1/300 inch
        public ushort Resolution;
        public short Brightness;            // -100 ~ 100, 0: Defalut
        public short Contrast;              // -100 ~ 100, 0: Defalut
        public byte Threshold;              // 1 ~ 255, defalut: 128. Value 0 means default
        public byte Invert;                 // 0: Disable, 1: Enable
        public byte ScanSource;				// Value 0: Automatic, 1: Sheetfeed, 2: Flatbed
        public byte Duplex;
        public byte Rotation;				// Value 0: None, 1: Clockwise 90, 2: 180; 3: 270, 4: Auoto orientation
        public byte TransportTimeout;       // Waiting for the next scan job. 0: Disable
        public byte MultifeedDetection;     // 0: Disable, 1: Enable
        public byte StopScanMultifeed;      // Stop scanning after multifeed occurred. 0: Disable, 1: Enable, 2: Ask
        public byte Mirror;                 // 0: Disable, 1: Enable
        public byte ProgressBarOff;         // 0: Show progress bar, 1: Hide progress bar
        public byte BarcodeDetection;       // Barcode detection 0: Disable, 1: Enable
        public byte UseDefaultTwainSetting; // Default Twain Setting 0: no use, 1: use
        public byte AutoLevel;              // Value 0: Off, 1: On
        public byte AutoOrientationMode;    // 0: Quick, 1: Full Text, 2: Complexity
        public byte FeederDirection;        // 1: front in, back out,   0: no change
        public byte AutoFeedTimeout;        // 0: no use this setting,  1~254: n seconds,  255: unlimited seconds
        public byte BlankPageRemoval;       // Blank page removal. 0: Disable
        public byte ColorMatch;             // 0: None, 1: Photo, 2:Document, 3:Mix
        public byte AutoCropBackground;	    // 0: White, 1: Black, 2: Automatic

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] Reserved;

        internal static GENERALSETTING GetDefaut()
        {
            return new GENERALSETTING()
            {
                PixelType = (byte)DEFINE_PT_TYPE.PT_GRAY,
                PaperSize = 6,  // PS_A4
                ScanSource = 1, // Sheetfeed
                ProgressBarOff = 1,
                Resolution = 600,
                Reserved = new byte[56]
                // other params use with default values
            };
        }
    }
}
