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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int rowCnt = dataGridView1.Rows.Count - 1;
                SubTitle[] subs = new SubTitle[rowCnt];

                for (int i = 0; i < rowCnt; i++)
                {
                    int FrameStart = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    int FrameEnd = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    string text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    subs[i] = new SubTitle(FrameStart, FrameEnd, text);
                }

                byte[] filebytes = { };
                for (int i = 0; i < rowCnt; i++)
                    filebytes = FileIO.Combine(filebytes, subs[i].GetBytes());

                filebytes = FileIO.Combine(filebytes, new byte[]{0xff, 0xff, 0xff, 0xff});

                File.WriteAllBytes(@"out.dat", filebytes);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Inazuma Eleven Game Data|*.dat";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                SubTitle[] subs = SubTitle.Read(ofd.FileName);
                for(int i = 0; i < subs.Length; i++)
                    dataGridView1.Rows.Add(subs[i].startFrame, subs[i].endFrame, subs[i].text);                
            }
        }
    }
}
