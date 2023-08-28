using System.ComponentModel;

namespace Avision.Enums
{
    internal enum DEFINE_PT_TYPE : byte
    {
        [Description("Black & White")]
        PT_BW = 0,
        [Description("8-bit Gray")]
        PT_GRAY = 1,
        [Description("24-bit Color")]
        PT_RGB = 2
    };
}
