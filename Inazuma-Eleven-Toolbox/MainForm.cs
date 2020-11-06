using Inazuma_Eleven_Toolbox.Forms._Save_Editor.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inazuma_Eleven_Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStatsFormShow_Click(object sender, EventArgs e)
        {
            Forms.StatsForm Statsfrm = new Forms.StatsForm();
            Statsfrm.Show();
        }

        private void btn_Save_Editor_Click(object sender, EventArgs e)
        {
            Forms.Save_Editor SavEdit = new Forms.Save_Editor();
            SavEdit.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
