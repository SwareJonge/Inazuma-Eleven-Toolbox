using System;
using System.IO;

using DamienG.Security.Cryptography;

using Inazuma_Eleven_Toolbox.Logic;
namespace Inazuma_Eleven_Toolbox.Formats
{
    // The Goal Of this file is to read every save format of the Inazuma Eleven games in the DS Engine with a focus on Inazuma Eleven 2
    // As of now it's possible to read the Header and the savedata header no matter what version of the game is used(except for IE3 DS as the decryption is still an issue)
    class SRecordInfo
    {
        public uint headerCRC;
        public string gameVersion;
        public byte[] titleID;
        public uint magicNum;
        public uint st_dataOffset;
        //public uint _0x20; // might be the time of when the save was created        
        public bool saveExists;
        public byte version; // 
        //public byte[] _0x26 = new byte[0x1A];

        public SRecordInfo(BinaryReader br)
        {
            headerCRC = br.ReadUInt32();
            byte[] CRC = br.ReadBytes(0x3C);
            if (Crc32.Compute(CRC) == headerCRC)
            {
                Console.WriteLine("Valid Header Checksum");
                br.BaseStream.Position = 4; // because we read these 0x3c bytes we have to reset the stream position
                gameVersion = TextDecoder.Decode(br.ReadBytes(0x10));
                titleID = br.ReadBytes(4);
                magicNum = br.ReadUInt32();
                st_dataOffset = br.ReadUInt32();
                br.BaseStream.Position += 4;
                saveExists = br.ReadBoolean();
                version = br.ReadByte();
                br.BaseStream.Position += 0x1A;
            }
            else
            {
                Console.WriteLine("Invalid Header Checksum"); // replace this with a boolean that gets set to false if either the CRC is invalid or no save is detected
            }
        }
    }

    class st_data
    {
        public uint infoCRC;
        public uint gameDataCRC;
        public uint magicNum; // always 0x19150A04
        public uint blockEnd;
        public uint playTime;
        public byte chapter;
        public byte teamLvl;
        public byte storyTeamPlayerCount;
        public byte friends;
        public uint friendshipPoints;
        public string name; // 16 bytes long in every verison exception for the European version of IE3(20 bytes)
        // 4 bytes of padding for IE3 EU, 8 for the others
        public string teamName; // 20 bytes long in IE3, 16 bytes in the others
        //byte[] _0x44; // unknown 0x8 bytes
        public uint sRecordPassCRC;
        public uint sRecordPassEnd;
        //public uint _0x54; // unknown
        public ushort[] partyPlayers = new ushort[4];
        //public byte[] _0x60; // unknown what this does, most likely padding as it's all 0 in every save i checked


        public st_data(BinaryReader br)
        {
            int stringLen = 16;
            int allignSize = 8;
            long startPos = br.BaseStream.Position;

            infoCRC = br.ReadUInt32();
            gameDataCRC = br.ReadUInt32();
            magicNum = br.ReadUInt32();
            blockEnd = br.ReadUInt32();
            playTime = br.ReadUInt32();
            chapter = br.ReadByte();
            teamLvl = br.ReadByte();
            storyTeamPlayerCount = br.ReadByte();
            friends = br.ReadByte();
            friendshipPoints = br.ReadUInt32();

            if (blockEnd == 0x5A28) // start of SRecordPass in IE3 EUR
            {
                stringLen = 20;
                allignSize = 4;
            }

            name = TextDecoder.Decode(br.ReadBytes(stringLen));
            br.BaseStream.Position += allignSize;
            teamName = TextDecoder.Decode(br.ReadBytes(stringLen));
            br.BaseStream.Position += 8; // skip over the unknown bytes
            sRecordPassCRC = br.ReadUInt32();
            sRecordPassEnd = br.ReadUInt32();
            br.BaseStream.Position += 8; // skip over the unknown bytes

            for (int i = 0; i < 4; i++)
                partyPlayers[i] = br.ReadUInt16();

            br.BaseStream.Position += 0x20;

            long endPos = br.BaseStream.Position;
            Console.WriteLine("StartPos: {0:X}\nEndPos: {1:X}", startPos, endPos);

        }
    }

    class SaveFile
    {
        public SRecordInfo saveHeader;
        public st_data saveData;

        public SaveFile(BinaryReader br)
        {
            saveHeader = new SRecordInfo(br);
            saveData = new st_data(br);

        }
    }
}
