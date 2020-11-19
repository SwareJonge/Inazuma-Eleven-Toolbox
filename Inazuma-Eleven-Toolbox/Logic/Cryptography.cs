using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Inazuma_Eleven_Toolbox.Logic
{
    public static class Cryptography
    {
        static void shiftBytes(byte[] buff, byte Byte1, byte Byte2)
        {
            byte b = buff[Byte1];
            buff[Byte1] = buff[Byte2];
            buff[Byte2] = b;
        }

        static void shiftBits(byte[] buff, byte dataSize, byte skipSize)
        {
            for(byte i = 0; i < buff.Length - dataSize; i += skipSize)
            {
                shiftBytes(buff, i, (byte)(i + dataSize));
            }
        }

        public static byte[] DecryptFile(byte[] buff, int blockSize)
        {
            byte[] block = new byte[blockSize];
            for (int i = 0; i < buff.Length; i += blockSize)
            {
                block = buff.Skip(i).Take(blockSize).ToArray();
                Decrypt(ref block);
                Array.Copy(block, 0, buff, i, blockSize);
            }
            return buff;
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

            // Second operation: shift bits and bytes
            shiftBits(data, 2, 3);
            shiftBits(data, 4, 5);
            shiftBits(data, 6, 7);
            shiftBits(data, 1, 2);
        }

        public static byte[] EncryptFile(byte[] buff, int blockSize)
        {
            byte[] block = new byte[blockSize];
            for (int i = 0; i < buff.Length; i+= blockSize)
            {
                block = buff.Skip(i).Take(blockSize).ToArray();
                Encrypt(ref block);
                Array.Copy(block, 0, buff, i, blockSize);
            }
            return buff;
        }

        public static void Encrypt(ref byte[] data)
        {
            // shift bits and bytes
            shiftBits(data, 1, 2);
            shiftBits(data, 6, 7);
            shiftBits(data, 4, 5);
            shiftBits(data, 2, 3);
            // shift bytes again
            for (int i = 0; i < data.Length; i++)
            {
                byte b = data[i];
                // do this twice
                for (int l = 0; l < 2; l++)
                {
                    b = (byte)((b >> 7 | b << 1) & 0xff);
                }
                // XOR with 0xAD
                b ^= 0xAD;
                data[i] = b;
            }

        }

    }
}
