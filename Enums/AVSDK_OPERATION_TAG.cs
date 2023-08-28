namespace Avision.Enums
{
    internal enum AVSDK_OPERATION_TAG: ushort
    {
        TAG_PAPERLOAD = 0,              // CMDOP_READ/DT_BYTE.  have Paper or not, True or False
        TAG_DUPLEX = 1,						// support Duplex Scan, True or False
        TAG_IMAGEFILEPATH = 2,              // CMDOP_SEND/DT_ASCIIZ. Specify the file location of image.
        TAG_IDENTIFYINFO = 3,               // CMDOP_SEND/DT_ASCIIZ. Identification information for SI.
        TAG_SPLITLENGTH = 4,                // CMDOP_SEND/DT_DWORD. Split image by the specific length. Unit: 1/300 inch.
        TAG_IMAGEFILENAME = 5,              // CMDOP_SEND/DT_ASCIIZ. Specify the file name of image.      
        TAG_SAVE_THUMBNAIL = 6,             // CMDOP_SEND/DT_BYTE.  0: default,  1: cane save thumbnail file & use compress(jpg) 
        TAG_JPG_QUALITY = 7,                // CMDOP_SEND/DT_WORD.  Scale image size, value form 1 to 99.  
        TAG_IMAGE_COUNT = 8,                // CMDOP_SEND/DT_SHORT.  Accept this number of images. Allowed Values: -1 and 1 – 32767.  
        TAG_RESET_ROLLER = 9,               // CMDOP_SEND/DT_BYTE.  Reset scanner roller count. 0: None, 1: Pad, 2: ADF Roller, 3: Reverse Roller, 4: Pickup Roller, 255: All Roller.  
        TAG_DEVICEONLINE =10,               // CMDOP_SEND/DT_BYTE.  Device is connect or not. Connect is 1.  
        TAG_RGB_VALUE = 11,                  // CMDOP_SEND/DT_DWORD.  TAG_RGB_VALUE = R*256*256 + G*256 + B, and R/G/B's range is 0 - 255.  
        TAG_SM_FUNCTION_SUPPORT = 12,        // CMDOP_READ/DT_DWORD.  Get SmartImage's function support..  
        TAG_POWERSAVING = 13,                // CMDOP_SEND/DT_DWORD.  Power saving(1 - 240 minutes) .  
        TAG_POWEROFF = 14,                   // CMDOP_SEND/DT_DWORD.  Power off(0 - 480 minutes, 0:off).  
    };
}
