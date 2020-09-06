using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inazuma_Eleven_Toolbox.Forms._Save_Editor.Config
{
    static partial class Config
    {
        public static bool CheckConfigFileIsPresent()
        {
            return File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        static public void Save()
        {
            Properties.Settings.Default.Save();
        }

        static public string SaveFolder
        {
            get
            {
                return Properties.Settings.Default.SaveFolder;
            }
            set
            {
                Properties.Settings.Default.SaveFolder = value;
            }
        }

        static public string PlayerFolder
        {
            get
            {
                return Properties.Settings.Default.PlayerFolder;
            }
            set
            {
                Properties.Settings.Default.PlayerFolder = value;
            }
        }

        static public int DefaultExportExt
        {
            get
            {
                return Properties.Settings.Default.DefaultExportExt;
            }
            set
            {
                Properties.Settings.Default.DefaultExportExt = value;
            }
        }


    }
}
