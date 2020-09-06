using Inazuma_Eleven_Toolbox.Forms._Save_Editor.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inazuma_Eleven_Toolbox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Config.CheckConfigFileIsPresent())
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Test");
            }
        }
    }
}
