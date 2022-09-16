using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inazuma_Eleven_Toolbox.Logic;

namespace Inazuma_Eleven_Toolbox.Formats
{
    class SubTitle
    {
        public int startFrame;
        public int endFrame;
        public int textLen; // should be length of text
        public string text;
        byte[] padding;

        public SubTitle(int StartFrame, int EndFrame, string txt)
        {
            startFrame = StartFrame;
            endFrame = EndFrame;
            byte[] encText = TextDecoder.Encode(txt);
            textLen = TextDecoder.GetPaddedLength(encText.Length);
            text = txt;
            padding = new byte[textLen - encText.Length];
        }

        public byte[] GetBytes() // there must be a faster way to do this but for now i'll use this
        {
            byte[] bytes = new byte[0xC + textLen];
            for (int i = 0; i < 4; i++)
                bytes[i] = BitConverter.GetBytes(startFrame)[i];

            for (int i = 0; i < 4; i++)
                bytes[i + 4] = BitConverter.GetBytes(endFrame)[i];

            for (int i = 0; i < 4; i++)
                bytes[i + 8] = BitConverter.GetBytes(textLen)[i];

            byte[] encText = TextDecoder.Encode(text);
            for (int i = 0; i < encText.Length; i++)
                bytes[i + 0xc] = encText[i];

            for (int i = 0; i < padding.Length; i++)
                bytes[i + encText.Length + 0xC] = padding[i];

            return bytes;
        }

        public static SubTitle[] Read(string file)
        {
            List<SubTitle> subTitles = new List<SubTitle>();

            using (BinaryReader br = new BinaryReader(File.OpenRead(file)))
            {
                while (true)
                {
                    int startFrame = br.ReadInt32();
                    if (startFrame == -1)
                        break;
                    int endFrame = br.ReadInt32();
                    int textLen = br.ReadInt32();
                    string text = TextDecoder.Decode(br.ReadBytes(textLen)).Replace("\0", "");
                    subTitles.Add(new SubTitle(startFrame, endFrame, text));
                }
            }
            return subTitles.ToArray();
        }

    }
}
