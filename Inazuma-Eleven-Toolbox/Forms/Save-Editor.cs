using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inazuma_Eleven_Toolbox.Dictionaries.ENG;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class Save_Editor : Form
    {
        public Save_Editor()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        string Filename = "";
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                numericPrestige.Enabled = true;
                numericFriendship.Enabled = true;
                comboBox7.Enabled = true;
                dataGridView1.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;
                numericUpDown17.Enabled = true;
                numericUpDown18.Enabled = true;
                numericUpDown8.Enabled = true;
                numericUpDown9.Enabled = true;
                numericUpDown10.Enabled = true;
                numericUpDown11.Enabled = true;
                numericUpDown12.Enabled = true;
                numericUpDown13.Enabled = true;
                numericUpDown14.Enabled = true;
                textBox19.Enabled = true;
                textBox20.Enabled = true;
                textBox21.Enabled = true;               
                Filename = openFileDialog1.FileName;


                Players P = new Players();
                byte[] Save_Data = File.ReadAllBytes(Filename);
                string Game = Encoding.ASCII.GetString(Save_Data.Skip(0x4).Take(0x10).ToArray()).Replace("\0", "");
                //Game = Game.Replace("\0", "");
                label4.Text = Game;

                bool isIE3 = false;
                if (Game == "INAZUMA_ELEVEN3")
                {
                    isIE3 = true;
                }


                int PrestigePointsOffset = 0x4D4;
                int FriendshipPointsOffset = 0x4D8;
                int PlayerStartOffset = 0x13F8;
                int length = 0x70;

                if (isIE3)
                {
                    PrestigePointsOffset = 0x4E8;
                    FriendshipPointsOffset = 0x4EC;
                    PlayerStartOffset = 0x11F8;
                    length = 0x6C;
                }

                numericPrestige.Value = BitConverter.ToInt32(Save_Data.Skip(PrestigePointsOffset).Take(4).ToArray(), 0);
                numericFriendship.Value = BitConverter.ToInt32(Save_Data.Skip(FriendshipPointsOffset).Take(4).ToArray(), 0);

                byte players = Save_Data[0x57];
                for (int i = PlayerStartOffset; i < PlayerStartOffset + (players * length); i += length)
                {
                    byte[] block = Save_Data.Skip(i).Take(length).ToArray();

                    short PlayerHEX = BitConverter.ToInt16(block.Skip(0x4).Take(2).ToArray(), 0);
                    byte PlayerLevel = block[0x4A];

                    dataGridView1.Rows.Add(((i - PlayerStartOffset ) / length + 1).ToString(), P.HEXToPlayer[PlayerHEX], PlayerLevel.ToString(), "0x" + PlayerHEX.ToString("X2"));
                }
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            IECommonDictionary D = new IECommonDictionary();
            Players P = new Players();
            
            int j = dataGridView1.CurrentRow.Index;
            byte[] Save_Data = File.ReadAllBytes(Filename);
            byte players = Save_Data[0x57];
            

            string Game = Encoding.ASCII.GetString(Save_Data.Skip(0x4).Take(0x10).ToArray()).Replace("\0", "");
            bool isIE3 = false;
            if (Game == "INAZUMA_ELEVEN3")
            {
                isIE3 = true;                
            }


            int PlayerStartOffset = 0x13F8;
            int length = 0x70;

            ItemClass IC = new ItemClass();
            ItemsIE2 ItemIE2 = new ItemsIE2();
            IC.EquipmentOffsetToStr = ItemIE2.EquipmentOffsetToStrIE2;


            if (isIE3)
            {
                PlayerStartOffset = 0x11F8;
                length = 0x6C;
                ItemsIE3 ItemIE3 = new ItemsIE3();
                IC.EquipmentOffsetToStr = ItemIE3.EquipmentOffsetToStrIE3;
            }

            byte[] block = Save_Data.Skip((j * length) + PlayerStartOffset).Take(length).ToArray();

            short PlayerHEX = BitConverter.ToInt16(block.Skip(0x4).Take(2).ToArray(), 0);
            uint EXP = BitConverter.ToUInt32(block.Skip(0x0).Take(4).ToArray(), 0);
            byte PlayerLevel = block[0x4A];

            short MoveS1 = BitConverter.ToInt16(block.Skip(0x38).Take(2).ToArray(), 0);
            short MoveS2 = BitConverter.ToInt16(block.Skip(0x3A).Take(2).ToArray(), 0);
            short MoveS3 = BitConverter.ToInt16(block.Skip(0x3C).Take(2).ToArray(), 0);
            short MoveS4 = BitConverter.ToInt16(block.Skip(0x3E).Take(2).ToArray(), 0);
            short MoveS5 = BitConverter.ToInt16(block.Skip(0x40).Take(2).ToArray(), 0);
            short MoveS6 = BitConverter.ToInt16(block.Skip(0x42).Take(2).ToArray(), 0);
            
            short Boots = BitConverter.ToInt16(block.Skip(0x10).Take(2).ToArray(), 0);
            short Other1 = BitConverter.ToInt16(block.Skip(0x12).Take(2).ToArray(), 0);
            short Other2 = BitConverter.ToInt16(block.Skip(0x14).Take(2).ToArray(), 0);



            ushort RemainingFP = BitConverter.ToUInt16(block.Skip(0x34).Take(2).ToArray(), 0);
            ushort RemainingTP = BitConverter.ToUInt16(block.Skip(0x36).Take(2).ToArray(), 0);

            byte TrainedKick = block[0x4F];
            byte TrainedBody = block[0x50];
            byte TrainedControl = block[0x52];
            byte TrainedGuard = block[0x51];
            byte TrainedSpeed = block[0x53];
            byte TrainedStamina = block[0x55];
            byte TrainedGuts = block[0x54];

            numericUpDown17.Value = RemainingFP;
            numericUpDown18.Value = RemainingTP;

            numericUpDown8.Value = (sbyte)TrainedKick;
            numericUpDown9.Value = (sbyte)TrainedBody;
            numericUpDown10.Value = (sbyte)TrainedControl;
            numericUpDown11.Value = (sbyte)TrainedGuard;
            numericUpDown12.Value = (sbyte)TrainedSpeed;
            numericUpDown13.Value = (sbyte)TrainedStamina;
            numericUpDown14.Value = (sbyte)TrainedGuts;

            textBox19.Text = IC.EquipmentOffsetToStr[Boots];
            textBox20.Text = IC.EquipmentOffsetToStr[Other1];
            textBox21.Text = IC.EquipmentOffsetToStr[Other2];

            comboBox1.Text = D.MoveToStr[MoveS1];
            comboBox2.Text = D.MoveToStr[MoveS2];
            comboBox3.Text = D.MoveToStr[MoveS3];
            comboBox4.Text = D.MoveToStr[MoveS4];
            comboBox5.Text = D.MoveToStr[MoveS5];
            comboBox6.Text = D.MoveToStr[MoveS6];

            numericUpDown7.Value = PlayerLevel;
            comboBox7.Text = P.HEXToPlayer[PlayerHEX];
        }

        private void numericFriendship_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
