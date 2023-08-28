using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct AVSDKINFO
    {
        public ushort MajorNumber { get; set; }
        public ushort MinorNumber { get; set; }
        public uint BuildNumber { get; set; }
        public uint FunctionSupport { get; set; }
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] Reserved;
    };
}
