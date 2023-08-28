using System.ComponentModel;

namespace Avision.Enums
{
    public enum DEFINE_DRIVER_TYPE : byte
    {
        [Description("TWAIN")]
        DRIVER_TWAIN = 0,
        [Description("ISIS")]
        DRIVER_ISIS = 1,
        [Description("LLD")]
        DRIVER_LLD = 2,
    };
}
