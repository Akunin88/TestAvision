namespace Avision.Enums
{
    internal enum CMDOP_DATA_TYPE: uint
    {
        DT_ASCIIZ = 0x00000002,     // C-string
        DT_SHORT = 0x00000003,     // 16 bit unsigned int
        DT_LONG = 0x00000004,     // 32 bit unsigned int
        DT_RATIONAL = 0x00000005,     // Combination of 2 LONG, one for
        // Fraction and the other for denominator
        // represent value=dwFraction/dwDenominator
        DT_BYTE = 0x00000006,     // 8 bit unsigned int
        DT_WORD = 0x00000007,
        DT_DWORD = 0x00000008,
        DT_UNDEFINED_BYTE = 0x00000009, // For byte-based dynamic structure 
        // needs to be determined on run time
        DT_SBYTE = 0x0000000A,     // 1 byte signed (twos-complement) integer
        DT_SSHORT = 0x0000000B,     // 2 byte signed (twos-complement) integer
        DT_SLONG = 0x0000000C,     // 4 byte signed (twos-complement) integer
        DT_SRATIONAL = 0x0000000D,     // Two 4 bytes signed(twos-complement) integer
        DT_FLOAT = 0x0000000E,     // single precision(4bytes) IEEE format
        DT_DOUBLE = 0x0000000F     // double precision(8bytes) IEEE format
    };
}
