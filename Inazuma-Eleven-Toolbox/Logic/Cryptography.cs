using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Inazuma_Eleven_Toolbox.Logic
{
    public static class Cryptography
    {
        // CRC Algorithm used by IE3 NDS?
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
                        crc = (crc << 1) ^ POLY;
                    else
                        crc = crc << 1;
                }
            }
            return crc ^0xffffffff;
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
                idk2 = 0xC74E; // This seems to be random

                for (int i = 0; i < 3; i++)
                {
                    uVar13 = idk2 * Mask3 + Mask1;
                    idk2 = uVar13 * Mask3 + Mask1;
                    local[i] = idk2 >> 0x10 | uVar13 & 0xffff0000;
                }

                if (idk != 0)
                {
                    for (int i = 0; i < idk; i++)
                    {
                        local[1] = Mask3 * local[1] + Mask1;
                        local[2] = Mask3 * local[2] + Mask1;
                        if (i < 4 || 0x13 < i)
                        {
                            buf[i] = (byte)((buf[i] >> (int)(8 - (((local[2] >> 0x10) << 3) >> 0x10) & 0xff)));
                            buf[i] = (byte)(buf[i] ^ (((local[1] >> 0x10) << 8) >> 0x10));
                        }
                    }


                    for(int i = 0; i < 0x100; i++)
                    {
                        local[0] = Mask3 * local[0] + Mask1;
                        local_21c[i] = (ushort)(local[0] >> 0x10);
                    }

                    //int r9 = (int)idk - 1;
                    for (int r9 = (int)idk - 1; (uint)r9 > 0xffffffff; r9--)
                    {
                        int iVar7 = r9 >> 0x1f;
                        // Same applies here, this screws up the encryption
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

                    byte[] unk5 = new byte[0xc];
                    Buffer.BlockCopy(local, 0, unk5, 0, 0);

                    uint uVar3 = Mask2;
                    uint _uVar5 = uVar4 + 0x20;

                    for(int i = 0; i < 0xc; i++)
                    {
                        uVar3 = Mask3 * uVar3 + Mask1;
                        uVar6 = uVar3 >> 0x10;
                        if (uVar8 != 0)
                        {
                            uVar6 = uVar6 * uVar8 >> 0x10;
                        }
                        _uVar5 = _uVar5 + uVar6 + 0x2;

                        byte bVar1 = unk5[i];
                        buf[idk + i] = buf[_uVar5];
                        buf[_uVar5] = bVar1;
                    }

                    return;
                }
            }
            else // Reverse Encrypt basically
            {
                byte[] unk5 = new byte[0xc];

                idk2 = (idk * 0x10000) >> 0x14;
                uint uVar5;
                if (idk2 == 0)
                {
                    uVar5 = Mask2 >> 0x10;
                }
                else
                {
                    uVar5 = idk2 * (Mask2 >> 0x10) >> 0x10;
                }

                uint uVar3 = Mask2;
                uint _Uvar5 = uVar5 + 0x20;

                for (int i = 0; i < 0xC; i++)
                {
                    uVar3 = (Mask3 * uVar3) + Mask1;
                    uint _uVar6 = uVar3 >> 0x10;
                    if (idk2 != 0)
                    {
                        _uVar6 = (_uVar6 * idk2) >> 0x10;
                    }

                    _Uvar5 = _Uvar5 + _uVar6 + 0x2;

#if DEBUG // for When i actually finish this
                    // Check if it matches the game code(it does now)
                    Console.WriteLine("r0: 0x" + (0x022EFA44 + _Uvar5).ToString("X2"));
                    Console.WriteLine("r1: 0x" + i.ToString("X2"));
                    Console.WriteLine("r12: 0x" + (_uVar6 + 0x2).ToString("X2"));
#endif

                    byte bVar1 = buf[_Uvar5];
                    buf[_Uvar5] = buf[idk + i];
                    unk5[i] = bVar1;
                }
                
                Buffer.BlockCopy(unk5, 0, local, 0, unk5.Length);

                for(int i = 0; i< 0x100; i++)
                {
                    local[0] = Mask3 * local[0] + Mask1;
                    local_21c[i] = (ushort)(local[0] >> 0x10);
                }

                for (int r9 = (int)len - 0xd; (uint)r9 > 0xffffffff; r9--)
                {
                    int iVar7 = r9 >> 0x1f;
                    // This function here most likely screws up the algorithm
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
                        buf[i] = (byte)(buf[i] ^ (((local[1] >> 0x10) << 8) >> 0x10));
                        buf[i] = (byte)((buf[i] >> (int)(8 - (((local[2] >> 0x10) << 3) >> 0x10) & 0xff)));                        
                    }
                }


            }
        }
#endif

    }
}
