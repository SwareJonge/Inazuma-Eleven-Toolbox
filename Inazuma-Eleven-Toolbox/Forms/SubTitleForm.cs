using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inazuma_Eleven_Toolbox.Formats;
using Inazuma_Eleven_Toolbox.Logic;
using Inazuma_Eleven_Toolbox.Utils;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class SubTitleForm : Form
    {
        public SubTitleForm()
        {
            InitializeComponent();
        }

        public string openedFile = @"Subtitle.dat";

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(openedFile))
                File.WriteAllBytes(openedFile + ".bak", File.ReadAllBytes(openedFile)); // Create a backup of the existing file just in case
            if (dataGridView1.Rows.Count != 0)
            {
                int rowCnt = dataGridView1.Rows.Count - 1;

                using (BinaryWriter bw = new BinaryWriter(new FileStream(openedFile, FileMode.Create)))
                {
                    for (int i = 0; i < rowCnt; i++)
                    {
                        int FrameStart = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        int FrameEnd = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        new SubTitle(FrameStart, FrameEnd, text).Write(bw);
                    }
                    bw.Write(0xffffffff); // End of File
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Inazuma Eleven Game Data|*.dat";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openedFile = ofd.FileName;
                dataGridView1.Rows.Clear();
                List<SubTitle> subs = SubTitle.ReadFile(openedFile);
                for(int i = 0; i < subs.Count; i++)
                    dataGridView1.Rows.Add(subs[i].startFrame, subs[i].endFrame, TextDecoder.Decode(subs[i].text));                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void btnInsertUp_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index, "", "", "");
        }

        private void btnInsertDown_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index + 1, "", "", "");
        }
    }
}
