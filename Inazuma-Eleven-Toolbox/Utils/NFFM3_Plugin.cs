using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inazuma_Eleven_Toolbox.Utils
{
    class NFFM3_Plugin
    {
        public static byte[] StringToByteArray(string hex)
        {
            return (from x in Enumerable.Range(0, hex.Length)
                    where x % 2 == 0
                    select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray<byte>();
        }
        public static void ExportPlayer(byte[] block, SaveFileDialog savePlayer)
        {
            // Merge all bytes into a string of bytes  
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < block.Length; i++)
            {
                // add " " after each byte
                builder.Append(block[i].ToString("X2") + " ");
            }
            // remove last " ", since NFFM doesn't have this last byte
            builder.Remove(0x143, 1);
            // save file
            File.WriteAllText(savePlayer.FileName, builder.ToString());
        }
    }
}
