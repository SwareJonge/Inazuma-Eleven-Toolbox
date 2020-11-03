using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace INAZUMA11
{
    public static class Encryption
    {
        static void shiftBytes(byte[] buff, byte Byte1, byte Byte2)
        {
            byte b = buff[Byte1];
            buff[Byte1] = buff[Byte2];
            buff[Byte2] = b;
        }

        public static void Decrypt(ref byte[] data)
        {
            // First operation: XOR with 0xAD and shift bits
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= 0xAD;
                byte b = data[i];
                // do this twice
                for (int l = 0; l < 2; l++)
                {
                    b = (byte)((b << 7 | b >> 1) & 0xff);
                }
                data[i] = b;
            }
            
            // Second operation: shift bytes
            for (int i = 0; i < data.Length - 2; i += 3)
            {
                shiftBytes(data, (byte)i, (byte)(i + 2));
            }
            for (int i = 0; i < data.Length - 4; i += 5)
            {
                shiftBytes(data, (byte)i, (byte)(i + 4));
            }
            for (int i = 0; i < data.Length - 6; i += 7)
            {
                shiftBytes(data, (byte)i, (byte)(i + 6));
            }
            for (int i = 0; i < data.Length - 1; i += 2)
            {
                shiftBytes(data, (byte)i, (byte)(i + 1));
            }
        }
    }
}