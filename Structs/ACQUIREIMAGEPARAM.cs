using System.Runtime.InteropServices;

namespace Avision.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    internal struct ACQUIREIMAGEPARAM
    {
        public byte ShowUI; // 0 (non-UI)  1 (Show drive UI)  2 (Show Image Control UI)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Reserved;
    };
}
