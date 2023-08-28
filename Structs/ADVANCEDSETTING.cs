using System;
using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct ADVANCEDSETTING
    {
        public byte Multistream { get; set; }
        public byte PaperSize { get; set; }
        public ushort XPos { get; set; }
        public ushort YPos { get; set; }
        public uint Width { get; set; }
        public uint Length { get; set; }
        public byte ColorDetectionOutMode { get; set; }
        public byte ScanSource { get; set; }
        public byte Rotation { get; set; }
        public byte TransportTimeout { get; set; }
        public byte MultifeedDetection { get; set; }
        public byte StopScanMultifeed { get; set; }
        public byte FlipSide { get; set; }
        public byte BlankPageRemoval { get; set; }
        public byte Mirror { get; set; }
        public byte PunchHoleRemoval { get; set; }
        public byte EdgeFillColor { get; set; }
        public Int32 EdgeExtend { get; set; }
        public byte SplitImage { get; set; }
        public byte ProgressBarOff { get; set; }
        public byte BarcodeDetection { get; set; }
        public byte UseDefaultTwainSetting { get; set; }
        public byte AutoLevel { get; set; }
        public byte AutoOrientationMode { get; set; }
        public byte FeederDirection { get; set; }
        public byte AutoFeedTimeout { get; set; }
        public byte AutoCropBackground { get; set; }
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 123)]
        public byte[] Reserved;
        public BW BW;
        public Gray Gray;
        public Color Color;
        public AdjustCrop AdjustCrop;
        public Watermark Watermark;
        public Advanced Advanced;

        public static ADVANCEDSETTING GetDefault()
        {
            ADVANCEDSETTING def = new ADVANCEDSETTING()
            {
                Multistream = 0, // Front Lineart
                PaperSize = 6,   // PS_A4
                ScanSource = 1,  // Sheetfeed
                Rotation = 0,   // None
                Reserved = new byte[123]
                // other params use with default values
            };
            def.BW.Reserved = new byte[16];
            def.Gray.Reserved = new byte[16];
            def.Color.Reserved = new byte[16];
            def.Watermark.Reserved = new byte[16];
            def.Advanced.Reserved = new byte[16];
            return def;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct BW
    {
        public byte Binarization { get; set; }
        public byte Sensitivity { get; set; }
        public short Brightness { get; set; }
        public byte Threshold { get; set; }
        public ushort Resolution { get; set; }
        public byte Invert { get; set; }
        public byte Compression { get; set; }
        public byte ColorDropOut { get; set; }
        public byte AdvanceDrop { get; set; }
        public byte FilterThreshold { get; set; }
        public byte DropTolerance { get; set; }
        public byte RedDropValue { get; set; }
        public byte GreenDropValue { get; set; }
        public byte BlueDropValue { get; set; }
        public ushort NoiseNumber { get; set; }
        public ushort NoiseRadius { get; set; }
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct Gray
    {
        public byte GrayQuality { get; set; }
        public short Brightness { get; set; }
        public short Contrast { get; set; }
        public byte Threshold { get; set; }
        public ushort Resolution { get; set; }
        public byte Invert { get; set; }
        public byte Compression { get; set; }
        public byte ColorDropOut { get; set; }
        public byte AdvanceDrop { get; set; }
        public byte FilterThreshold { get; set; }
        public byte BackgroundLevel { get; set; }
        public byte DropTolerance { get; set; }
        public byte RedDropValue { get; set; }
        public byte GreenDropValue { get; set; }
        public byte BlueDropValue { get; set; }
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct Color
    {
        public byte ColorMatch { get; set; }
        public short Brightness { get; set; }
        public short Contrast { get; set; }
        public ushort Resolution { get; set; }
        public byte Invert { get; set; }
        public byte Compression { get; set; }
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct AdjustCrop
    {
        public short Left { get; set; }
        public short Top { get; set; }
        public short Right { get; set; }
        public short Bottom { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct Watermark
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct Advanced
    {
        public byte Gamma { get; set; }                 // Image gamma. 10 ~ 255. Default: 100. Value 0 means default
        public byte Blur { get; set; }                  // 0: Disable, 1: Enable
        public byte Sharpen { get; set; }               // 0: Disable, 1: Enable
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved;
    }
}
