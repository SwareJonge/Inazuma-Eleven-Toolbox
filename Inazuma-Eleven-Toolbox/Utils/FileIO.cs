using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Utils
{
    class FileIO
    {
        // This function is Slightly faster than File.ReadAllBytes
        public static byte[] ReadFile(string Filename)
        {
            using (FileStream fsSource = new FileStream(Filename, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fsSource.Length];
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                return bytes;
            }
        }

        public static byte[] WriteData(byte[] DataIn, int PatchOffset, byte[] DataTowrite, int Length)
        {
            for (int i = 0; i < Length; i++)
            {
                DataIn[PatchOffset + i] = DataTowrite[i];
            }
            return DataIn;
        }

    }
}
