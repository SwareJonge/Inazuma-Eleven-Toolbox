using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Inazuma_Eleven_Toolbox.Logic
{
    public static class Cryptography
    {
        // CRC Algorithm used by IE3?
        public static UInt32 CRC32ACompute(byte[] buf, UInt32 len)
        {
            UInt32 crc = 0xffffffff;
            UInt32 POLY = 0x04c11db7;

            for (int i = 0; i < len; i++)
            {
                crc = crc ^ buf[i];
                for (int bit = 0; bit < 8; bit++)
                {
                    if ((crc & 0x80000000) != 0)
                        crc = POLY ^ (crc << 1);
                    else
                        crc = crc << 1;
                }
            }
            return ~crc;
        }

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

#if DEBUG
        // i shouldn't need to use this
        static int CARRY4(int a, int b, out bool overflowFlag)
        {
            unchecked
            {
                int c = a + b;
                overflowFlag = ((a ^ b) >= 0) & ((a ^ c) < 0);
                return c;
            }
        }
        static uint CONCAT44(uint a, uint b)
        {
            uint
              pow = 1;

            while (pow < b)
            {
                pow = ((pow << 2) + pow) << 1;
                a = ((a << 2) + a) << 1;
            }

            return a + b;
        }

        // this function is even worse
        static UInt32 FUN_0201fd4c(int param_1, uint param_2, uint param_3, uint param_4)
        {
            uint uVar1;
            bool bVar2;
            uint iVar3;
            //byte in_CY;
            bool flag;

            uVar1 = param_4 * 2;
            bVar2 = param_2 + uVar1 + 1 <= param_2;
            iVar3 = param_2 + uVar1 + (byte)CARRY4((int)param_2, (int)uVar1, out flag);
            CARRY4((int)param_2, (int)uVar1, out flag);
            if ((flag == false) && (!bVar2))
            {
                iVar3 = iVar3 - param_2;
            }
            int thing = 0;
            int thing2 = CARRY4((int)param_2, (int)uVar1, out flag);
            if (flag)
            {
                thing = thing2;
            }

            return CONCAT44(iVar3, (uint)(param_1 * 2 + thing));
        }

        // void FUN_0201fb7c(uint param_1,uint param_2)
        // Very inaccurately replicated
        static uint EncodeHelperFunc(uint param_1, uint param_2)
        {
            uint uVar1;
            uint uVar2;

            if (param_2 == 0)
            {
                return param_1;
            }
            if (param_2 <= param_1)
            {
                uVar1 = 0x1c;
                uVar2 = param_1 >> 4;
                if ((int)param_2 <= (int)(param_1 >> 0x10))
                {
                    uVar1 = 0xc;
                    uVar2 = param_1 >> 0x14;
                }
                if ((int)param_2 <= (int)(uVar2 >> 4))
                {
                    uVar1 = uVar1 - 8;
                    uVar2 = uVar2 >> 8;
                }
                if ((int)param_2 <= (int)uVar2)
                {
                    uVar1 = uVar1 - 4;
                    uVar2 = uVar2 >> 4;
                }

                for (int i = (int)uVar2; i < 0x1f; i++)
                {
                    uVar1 = FUN_0201fd4c(((int)param_1 << (int)(uVar2 & 0xff)) * 2, (uint)-param_2, uVar2 * 3, uVar1);
                }

                return uVar1;
            }
            return 0;
        }

        // FUN_02062b34 / FUN_0205FFB0 // Attempt at encrypting the IE3 NDS Saves but without success
        // flag: true is Encrypt, false is Decrypt
        // buf: savefile buffer
        // len: Length: either 0x7F80 or 0x80 depending on how far you're in the game(0x7F80 99% of the time)
        public static void EncodeDecodeSave(bool flag, byte[] buf, UInt32 len)
        {
            uint Mask1 = 0x00269EC3; // these are actually seeds and hash values
            uint Mask2 = 0xB5BDCF5A;
            uint Mask3 = 0x5D588B65;
            uint idk2;

            uint uVar6;
            uint uVar13;

            ushort[] local_21c = new ushort[256];

            uint[] local = new uint[3];

            uint idk = (len - 0xc);
            if (flag)
            {
                idk2 = 0x344A; // This seems to be random

                for (int i = 0; i < 3; i++)
                {
                    uVar13 = idk2 * Mask3 + Mask1;
                    idk2 = uVar13 * Mask3 + Mask1;
                    local[i] = (idk2 >> 0x10) | (uVar13 & 0xfff0000);
                }

                if (idk != 0)
                {
                    for (int i = 0; i < len; i++)
                    {
                        local[1] = Mask3 * local[1] + Mask1;
                        local[2] = Mask3 * local[2] + Mask1;
                        if (i < 4 || 0x13 < i)
                        {
                            int b = buf[i];
                            buf[i] = (byte)((b >> (int)(8 - (((local[2] >> 0x10) << 3) >> 0x10) & 0xff)));
                            buf[i] = (byte)(b ^ (((local[1] >> 0x10) << 8) >> 0x10));
                        }
                    }

                    int iVar9;
                    int j = 0;
                    do
                    {
                        local[0] = Mask3 * local[0] + Mask1;
                        iVar9 = j + 1;
                        local_21c[j] = (ushort)(local[0] >> 0x10);
                        j = iVar9;
                    } while (iVar9 < 0x100);

                    //uint r9 = len - 0xd;
                    for (int r9 = (int)len - 0xd; len > 0xffffffff; len--)
                    {
                        int iVar7 = r9 >> 0x1f;
                        uint r0 = EncodeHelperFunc((uint)(r9 + (idk * local_21c[((r9 * 0x1000000 + iVar7) >> 0x18 | iVar7 << 8) - iVar7] >> 0x10)), idk);
                        if (((r9 < 4) || (r9 > 0x13)) && ((r0 < 4) || (r0 > 0x13)))
                        {
                            byte b = buf[r9];
                            buf[r9] = buf[r0];
                            buf[r0] = b;
                        }
                    }

                    uint uVar8 = (idk * 0x10000) >> 0x14;
                    uint uVar4 = 0;

                    if (uVar8 == 0)
                        uVar4 = Mask2 >> 0x10;
                    else
                        uVar4 = uVar8 * (Mask2 >> 0x10) >> 0x10;

                    //byte idk3 = buf[uVar4 + 0x20];

                    byte[] part1 = BitConverter.GetBytes(local[0]);
                    byte[] part2 = BitConverter.GetBytes(local[1]);
                    byte[] part3 = BitConverter.GetBytes(local[2]);
                    byte[] unk5 = { part1[0], part1[1], part1[2], part1[3], part2[0], part2[1], part2[2], part2[3], part3[0], part3[1], part3[2], part3[3] };

                    uint k = 0;
                    do
                    {
                        uint uVar3 = Mask3 * Mask2 + Mask1;
                        uVar6 = uVar3 >> 0x10;
                        if (uVar8 != 0)
                        {
                            uVar6 = uVar6 * uVar8 >> 0x10;
                        }

                        buf[uVar4 + 0x20 + k] = buf[uVar4 + 0x20 + k + uVar6 + 0x2];
                        buf[uVar4 + k] = unk5[k];

                        //byte uVar1 = unk5[k];

                        k++;

                    } while (k < 0xC);

                    return;
                }
            }
            else // Reverse Encrypt basically
            {
                local[0] = 0x1E0C2E5; // NOTE These values come from the stack: Todo: find out what writes it to the stack
                local[1] = 0xF0FFFF3A;
                local[2] = 0x809DE5;

                byte[] part1 = BitConverter.GetBytes(local[0]);
                byte[] part2 = BitConverter.GetBytes(local[1]);
                byte[] part3 = BitConverter.GetBytes(local[2]);
                byte[] unk5 = { part1[0], part1[1], part1[2], part1[3], part2[0], part2[1], part2[2], part2[3], part3[0], part3[1], part3[2], part3[3] };

                idk2 = (uint)((int)idk * 0x10000) >> 0x14;
                if (idk2 == 0)
                {
                    uVar6 = Mask2 >> 0x10;
                }
                else
                {
                    uVar6 = idk2 * (Mask2 >> 0x10) >> 0x10;
                }

                uint k = 0;
                do
                {
                    uint uVar3 = Mask3 * Mask2 + Mask1;
                    uVar6 = uVar3 >> 0x10;
                    if (idk2 != 0)
                    {
                        uVar6 = uVar6 * idk2 >> 0x10;
                    }

                    buf[uVar6 + 0x20 + k] = buf[uVar6 + 0x20 + k + uVar6 + 0x2];
                    buf[uVar6 + k] = unk5[k];

                    //byte uVar1 = unk5[k];

                    k++;

                } while (k < 0xC);

                int iVar9;
                int j = 0;
                do
                {
                    local[0] = Mask3 * local[0] + Mask1;
                    iVar9 = j + 1;
                    local_21c[j] = (ushort)(local[0] >> 0x10);
                    j = iVar9;
                } while (iVar9 < 0x100);

                for (int r9 = (int)len - 0xd; len > 0xffffffff; len--)
                {
                    int iVar7 = r9 >> 0x1f;
                    uint r0 = EncodeHelperFunc((uint)(r9 + (idk * local_21c[((r9 * 0x1000000 + iVar7) >> 0x18 | iVar7 << 8) - iVar7] >> 0x10)), idk);
                    if (((r9 < 4) || (r9 > 0x13)) && ((r0 < 4) || (r0 > 0x13)))
                    {
                        byte b = buf[r9];
                        buf[r9] = buf[r0];
                        buf[r0] = b;
                    }
                }

                for (int i = 0; i < idk; i++)
                {
                    local[1] = Mask3 * local[1] + Mask1;
                    local[2] = Mask3 * local[2] + Mask1;
                    if (i < 4 || 0x13 < i)
                    {
                        int b = buf[i];
                        buf[i] = (byte)((b >> (int)(8 - (((local[2] >> 0x10) << 3) >> 0x10) & 0xff)));
                        buf[i] = (byte)(b ^ (((local[1] >> 0x10) << 8) >> 0x10));
                    }
                }
            }
        }
#endif

    }
}
