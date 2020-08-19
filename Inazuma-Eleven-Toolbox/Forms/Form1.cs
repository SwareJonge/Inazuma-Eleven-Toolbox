using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INAZUMA11;
using System.IO;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileNamein = @"Game Files/EUR/IE2/Item.dat";

            for (int i = 0x0; i <= 0xAD70; i += 0x30)
            {
                byte[] Item_Dat = File.ReadAllBytes(fileNamein).Skip(i).Take(0x30).ToArray();

                string FullPlayerName =  Encoding.GetEncoding(932).GetString(Item_Dat.Take(0x18).ToArray());
                FullPlayerName = FullPlayerName.Replace("\0", "");
                int ScoutHexID = (i / 0x30);
                

                if (!FullPlayerName.Contains("boots") && !FullPlayerName.Contains("gloves") && !FullPlayerName.Contains("bracelet") && !FullPlayerName.Contains("pendant"))
                {
                    continue;
                }

                richTextBox1.AppendText("{ 0x" + ScoutHexID.ToString("X2") + ", \"" + FullPlayerName + "\"" + "},\n");
            }

        }
    }
}
