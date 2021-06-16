using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic
{
    public static class TextDecoder
    {
        static IDictionary<byte, string> CharTable = new Dictionary<byte, string>
        {
            {0x7B, "ß"}, {0x7C, "Ÿ"}, {0x7D, "ª"}, {0x7E, "º"},
            {0xA1, "Ù"}, {0xA2, "Ú"}, {0xA3, "Û"}, {0xA4, "Ü"},
            {0xA5, "¿"},
            {0xA6, "Í"}, {0xA7, "Ï"},
            {0xA8, "Ð"}, {0xA9, "Ñ"},
            {0xAA, "Ò"}, {0xAB, "Ó"}, {0xAC, "Ô"}, {0xAD, "Õ"}, {0xAF, "Ø"},
            {0xB1, "à"}, {0xB2, "á"}, {0xB3, "â"}, {0xB4, "ã"}, {0xB5, "ä"},
            {0xB6, "œ"}, {0xB7, "æ"}, {0xB8, "ç"},
            {0xB9, "è"}, {0xBA, "é"}, {0xBB, "ê"}, {0xBC, "ë"},
            {0xBD, "ì"}, {0xBE, "í"}, {0xBF, "î"}, {0xC0, "ï"},
            {0xC1, "ð"}, {0xC2, "ñ"},
            {0xC3, "ò"}, {0xC4, "ó"}, {0xC5, "ô"}, {0xC6, "õ"}, {0xC7, "ö"},
            {0xC9, "ù"}, {0xCA, "ú"}, {0xCB, "û"}, {0xCC, "ü"},
            {0xCD, "ý"}, {0xCE, "€"}, {0xCF, "ÿ"},
            {0xD0, "À"}, {0xD1, "Á"}, {0xD2, "Â"}, {0xD3, "Ã"}, {0xD4, "Ä"},
            {0xD5, "Œ"}, {0xD6, "Æ"}, {0xD7, "Ç"},
            {0xD8, "È"}, {0xD9, "É"}, {0xDA, "Ê"}, {0xDB, "Ë"},
            {0xDC, "Ì"}, {0xDD, "Î"},
            {0xDE, "Ý"}, {0xDF, "¡"}
        };

        public static string Decode(byte[] input, bool Japanese)
        {
            string output = "";
            int i = 0;
            if (!Japanese)
            {
                do
                {
                    if (input[i] == 0)
                        return "";
                    else if (input[i] < 0x7B)
                    {
                        output = String.Concat(output, Encoding.GetEncoding(932).GetString(input.Skip(i).Take(0x1).ToArray()));
                        i += 1;
                    }
                    else if (input[i] > 0x80 && input[i] < 0xA0) // Japanese Character
                    {
                        output = String.Concat(output, Encoding.GetEncoding(932).GetString(input.Skip(i).Take(0x2).ToArray()));
                        i += 2;
                    }
                    else // use our custom table
                    {
                        output = String.Concat(output, CharTable[input[i]]);
                        i += 1;
                    }

                }
                while (input[i] != 0);
            }
            else output = Encoding.GetEncoding(932).GetString(input).Replace("\0", "");

            return output;
        }
    }
}
