using System.ComponentModel;

namespace Avision.Enums
{
    internal enum AVSDK_ERROR_CODE : int
    {
        [Description("Success")]
        SDK_SUCCESS = 0,
        [Description("Failure")]
        SDK_ERR_FAILURE = -1,
        [Description("Invalid license")]
        ERR_LICENSE_INVALID = -100,
        [Description("Expired license")]
        ERR_LICENSE_EXPIRED = -101,
        [Description("Null handle")]
        ERR_NULL_HANDLE = -102,
        [Description("Operation error")]
        ERR_OPERATION = -201,
        [Description("Unexpected sequence")]
        ERR_SEQUENCE = -202,
        [Description("ERR_SDK_NOMEMORY")]
        ERR_SDK_NOMEMORY = -300,
        [Description("ERR_TRANSFER_FAIL")]
        ERR_TRANSFER_FAIL = -301,
        [Description("No Paper")]
        ERR_NO_PAPER = -302,
    };
}
