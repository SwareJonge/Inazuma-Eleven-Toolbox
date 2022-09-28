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
        public int textLen; // Padded Length of Text
        public byte[] text;

        public SubTitle(int StartFrame, int EndFrame, string txt)
        {
            byte[] encText = TextDecoder.Encode(txt);

            startFrame = StartFrame;
            endFrame = EndFrame;            
            textLen = TextDecoder.GetPaddedLength(encText.Length);
            text = encText;
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(startFrame);
            bw.Write(endFrame);
            bw.Write(textLen);
            bw.Write(text);
            bw.BaseStream.Position += (textLen - text.Length); // the worst way i could think of to make this more optimal but hey, it works
        } 

        public static List<SubTitle> ReadFile(string file)
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
                    string text = TextDecoder.Decode(br.ReadBytes(textLen));
                    subTitles.Add(new SubTitle(startFrame, endFrame, text));
                }
            }
            return subTitles;
        }

    }
}
