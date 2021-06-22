using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DamienG.Security.Cryptography;

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


        public class NDSIE3
        {
            static uint Mask1 = 0x00269EC3; // these are seeds and hash values
            static uint Mask2 = 0xB5BDCF5A;
            static uint Mask3 = 0x5D588B65;

            // FUN_02062b34 / FUN_0205FFB0 // Attempt at encrypting the IE3 NDS Saves but not with 100% success
            // buf: savefile buffer
            // len: Length: either 0x7F80 or 0x80 depending on how far you're in the game(0x7F80 99% of the time)
            public void EncryptSave(byte[] buf, UInt32 len)
            {
                ushort[] local_21c = new ushort[256];
                uint[] local = new uint[3]; // last 0xc bytes are stored here

                uint idk = (len - 0xc);

                uint idk2 = 0xDEAD;

                for (int i = 0; i < 3; i++)
                {
                    uint uVar13 = (idk2 * Mask3) + Mask1;
                    idk2 = (uVar13 * Mask3) + Mask1;
                    local[i] = idk2 >> 0x10 | uVar13 & 0xffff0000;
                }
                // The last Stage uses the first generated seeds So copy that to unk5 now
                byte[] unk5 = new byte[0xc];
                Buffer.BlockCopy(local, 0, unk5, 0, 0xc);

                for (int i = 0; i < idk; i++)
                {
                    local[2] = Mask3 * local[2] + Mask1;
                    if (i < 4 || 0x13 < i)
                    {
                        byte[] b = { buf[i], buf[i] };
                        ushort c = BitConverter.ToUInt16(b, 0); // concatenate these 2 bytes
                        buf[i] = (byte)(c >> (ushort)(8 - (((local[2] >> 0x10) << 3) >> 0x10)));
                    }
                }

                for (int i = 0; i < idk; i++)
                {
                    local[1] = Mask3 * local[1] + Mask1;
                    if (i < 4 || 0x13 < i)
                    {
                        buf[i] ^= (byte)(((local[1] >> 0x10) << 8) >> 0x10);
                    }
                }

                for (int i = 0; i < 0x100; i++)
                {
                    local[0] = Mask3 * local[0] + Mask1;
                    local_21c[i] = (ushort)(local[0] >> 0x10);
                }

                //int r9 = (int)idk - 1;
                for (uint i = idk - 1; -1 < (int)i; i--)
                {
                    int iVar7 = (int)i >> 0x1f;
                    Math.DivRem((int)(i + (idk * local_21c[((i * 0x1000000 + iVar7) >> 0x18 | iVar7 << 8) - iVar7] >> 0x10)), (int)idk, out int remainder);
                    if (((i < 4) || (i > 0x13)) && ((remainder < 4) || (remainder > 0x13)))
                    {
                        byte b = buf[i];
                        buf[i] = buf[remainder];
                        buf[remainder] = b;
                    }
                }

                uint uVar8 = (idk * 0x10000) >> 0x14;
                uint uVar4 = 0;

                if (uVar8 == 0)
                    uVar4 = Mask2 >> 0x10;
                else
                    uVar4 = uVar8 * (Mask2 >> 0x10) >> 0x10;

                uint uVar3 = Mask2;
                uint _uVar5 = uVar4 + 0x20;

                for (int i = 0; i < 0xc; i++)
                {
                    uVar3 = Mask3 * uVar3 + Mask1;
                    uint uVar6 = uVar3 >> 0x10;
                    if (uVar8 != 0)
                    {
                        uVar6 = uVar6 * uVar8 >> 0x10;
                    }
                    _uVar5 = _uVar5 + uVar6 + 0x2;

                    buf[idk + i] = buf[_uVar5];
                    buf[_uVar5] = unk5[i];
                }
                return;
            }

            public void DecryptSave(byte[] buf, UInt32 len)
            {
                uint idk = (len - 0xc);

                ushort[] local_21c = new ushort[256];
                uint[] local = new uint[3]; // last 0xc bytes are stored here

                byte[] unk5 = new byte[0xc];

                uint idk2 = (idk * 0x10000) >> 0x14;
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

                    byte bVar1 = buf[_Uvar5];
                    buf[_Uvar5] = buf[idk + i];
                    unk5[i] = bVar1;
                }

                Buffer.BlockCopy(unk5, 0, local, 0, unk5.Length);

                for (int i = 0; i < 0x100; i++)
                {
                    local[0] = Mask3 * local[0] + Mask1;
                    local_21c[i] = (ushort)(local[0] >> 0x10);
                }

                for (uint i = 0; i < idk; i++)
                {
                    int iVar7 = (int)i >> 0x1f;
                    Math.DivRem((int)(i + (idk * local_21c[((i * 0x1000000 + iVar7) >> 0x18 | iVar7 << 8) - iVar7] >> 0x10)), (int)idk, out int remainder);
                    if (((i < 4) || (i > 0x13)) && ((remainder < 4) || (remainder > 0x13)))
                    {
                        byte b = buf[i];
                        buf[i] = buf[remainder];
                        buf[remainder] = b;
                    }
                }

                for (int i = 0; i < idk; i++)
                {
                    local[1] = Mask3 * local[1] + Mask1;
                    local[2] = Mask3 * local[2] + Mask1;
                    if (i < 4 || 0x13 < i)
                    {
                        buf[i] ^= (byte)(((local[1] >> 0x10) << 8) >> 0x10);
                        byte[] b = { buf[i], buf[i] };
                        ushort c = BitConverter.ToUInt16(b, 0);
                        buf[i] = (byte)(c >> (ushort)(((local[2] >> 0x10) << 3) >> 0x10));
                    }
                }
            } 
        }
    }
}
