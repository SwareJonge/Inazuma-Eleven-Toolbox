using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DamienG.Security.Cryptography;
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

        public int PrestigePointsOffset = 0x4D4;
        public int FriendshipPointsOffset = 0x4D8;
        public int PlayerStartOffset = 0x13F8;
        public int length = 0x70;
        public bool isIE3 = false;
        
        int Checksum1Offset = 0x40;
        int Checksum1BlockStart = 0x44;
        int Checksum1BlockLength = 0x7C;

        int Checksum2Offset = 0x44;
        int Checksum2BlockStart = 0xC0;
        int Checksum2BlockLength = 0x7E8C;

        ItemClass IC = new ItemClass();
        ItemsIE2 ItemIE2 = new ItemsIE2();
        IECommonDictionary D = new IECommonDictionary();
        Moves M = new Moves();
        

        void SetOffsets(string GameVersion)
        {
            IC.EquipmentOffsetToStr = ItemIE2.EquipmentOffsetToStrIE2;
            if (GameVersion == "INAZUMA_ELEVEN3")
            {
                isIE3 = true;
                PrestigePointsOffset = 0x4E8;
                FriendshipPointsOffset = 0x4EC;
                PlayerStartOffset = 0x11F8;
                length = 0x6C;
                Checksum1BlockLength = 0x84;
                Checksum2BlockStart = 0xC8;
                Checksum2BlockLength = 0x59A0;
                ItemsIE3 ItemIE3 = new ItemsIE3();
                IC.EquipmentOffsetToStr = ItemIE3.EquipmentOffsetToStrIE3;
            }

        }

        string Filename = "";

        public byte[] SavedataFull = null;
        public byte[] ModifiedBlock = null;

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Filename = openFileDialog1.FileName;
                byte[] Save_Data = File.ReadAllBytes(Filename);
                string TestIfInazumaSave = Encoding.ASCII.GetString(Save_Data.Skip(0x4).Take(0x7).ToArray());
                string Game = Encoding.ASCII.GetString(Save_Data.Skip(0x4).Take(0x10).ToArray()).Replace("\0", "");
                SetOffsets(Game);
                label4.Text = Game;
                if (TestIfInazumaSave != "INAZUMA")
                {
                    MessageBox.Show("This is not an Inazuma Eleven DS Save File!");
                    return;
                }
                if (Save_Data[0x17] == 0x4A)
                {
                    MessageBox.Show("Japanese save files are not supported since they have not been tested");
                    return;
                }
                dataGridView1.Rows.Clear();
                numericPrestige.Enabled = true;
                numericFriendship.Enabled = true;
                textBox22.Enabled = true;
                dataGridView1.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;

                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                numericUpDown6.ReadOnly = false;

                numericUpDown17.Enabled = true;
                numericUpDown18.Enabled = true;
                //numericUpDown8.Enabled = true;
                //numericUpDown9.Enabled = true;
                //numericUpDown10.Enabled = true;
                //numericUpDown11.Enabled = true;
                //numericUpDown12.Enabled = true;
                //numericUpDown13.Enabled = true;
                //numericUpDown14.Enabled = true;
                //textBox19.Enabled = true;
                //textBox20.Enabled = true;
                //textBox21.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                Players P = new Players();               
                ModifiedBlock = File.ReadAllBytes(Filename);                

                if (Game == "INAZUMA_ELEVEN3" && openFileDialog1.FileName.EndsWith(".sav"))
                {                    
                    MessageBox.Show("Japanese save files are not supported since they have not been tested");
                    return;
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

        void PatchChecksums()
        {
            byte[] Block1 = ModifiedBlock.Skip(Checksum1BlockStart).Take(Checksum1BlockLength).ToArray();
            byte[] Block2 = ModifiedBlock.Skip(Checksum2BlockStart).Take(Checksum2BlockLength).ToArray();
            byte[] Checksum2 = BitConverter.GetBytes(Crc32.Compute(Block2));
            Block1 = WriteData(Block1, 0x0, Checksum2, 4);
            ModifiedBlock = WriteData(ModifiedBlock, 0x44, Block1, Block1.Length);

            byte[] Checksum1 = BitConverter.GetBytes(Crc32.Compute(Block1));
            ModifiedBlock = WriteData(ModifiedBlock, Checksum1Offset, Checksum1, 4);
        }




        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            LoadPlayer();
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void numericFriendship_ValueChanged(object sender, EventArgs e)
        {
            byte[] Friendship = BitConverter.GetBytes((uint)numericFriendship.Value);

            ModifiedBlock = WriteData(ModifiedBlock, FriendshipPointsOffset, Friendship, 4);
        }

        private void numericPrestige_ValueChanged(object sender, EventArgs e)
        {
            byte[] Prestige = BitConverter.GetBytes((uint)numericPrestige.Value);

            ModifiedBlock = WriteData(ModifiedBlock, PrestigePointsOffset, Prestige, 4);
        }

        byte[] WriteData(byte[] DataIn, int PatchOffset, byte[] DataTowrite, int Length)
        {
            for(int i = 0; i < Length; i++)
            {
                DataIn[PatchOffset + i] = DataTowrite[i];
            }
            return DataIn;
        }

        void LoadPlayer()
        {            
            Players P = new Players();

            int j = dataGridView1.CurrentRow.Index;
            byte[] Save_Data = ModifiedBlock;
            byte players = Save_Data[0x57];

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
            byte Move1Level = block[0x44];
            byte Move2Level = block[0x45];
            byte Move3Level = block[0x46];
            byte Move4Level = block[0x47];
            byte Move5Level = block[0x48];
            byte Move6Level = block[0x49];


            comboBox1.Text = D.MoveToStr[MoveS1];
            comboBox2.Text = D.MoveToStr[MoveS2];
            comboBox3.Text = D.MoveToStr[MoveS3];
            comboBox4.Text = D.MoveToStr[MoveS4];
            comboBox5.Text = D.MoveToStr[MoveS5];
            comboBox6.Text = D.MoveToStr[MoveS6];

            string Move1EvolveType = "";
            string Move2EvolveType = "";
            string Move3EvolveType = "";
            string Move4EvolveType = "";
            string Move5EvolveType = "";
            string Move6EvolveType = "";


            if (!isIE3)
            {
                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                numericUpDown6.ReadOnly = false;


                if (!M.IE2MoveGrowth.ContainsKey(comboBox1.Text))
                {
                    numericUpDown1.ReadOnly = true;
                }
                else Move1EvolveType = M.IE2MoveGrowth[comboBox1.Text];

                if (!M.IE2MoveGrowth.ContainsKey(comboBox2.Text))
                {
                    numericUpDown2.ReadOnly = true;
                }
                else Move2EvolveType = M.IE2MoveGrowth[comboBox2.Text];

                if (!M.IE2MoveGrowth.ContainsKey(comboBox3.Text))
                {
                    numericUpDown3.ReadOnly = true;
                }
                else Move3EvolveType = M.IE2MoveGrowth[comboBox3.Text];

                if (!M.IE2MoveGrowth.ContainsKey(comboBox4.Text))
                {
                    numericUpDown4.ReadOnly = true;
                }
                else Move4EvolveType = M.IE2MoveGrowth[comboBox4.Text];

                if (!M.IE2MoveGrowth.ContainsKey(comboBox5.Text))
                {
                    numericUpDown5.ReadOnly = true;
                }
                else Move5EvolveType = M.IE2MoveGrowth[comboBox5.Text];

                if (!M.IE2MoveGrowth.ContainsKey(comboBox6.Text))
                {
                    numericUpDown6.ReadOnly = true;
                }
                else Move6EvolveType = M.IE2MoveGrowth[comboBox6.Text];
            }             

            if (isIE3)
            {
                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                numericUpDown6.ReadOnly = false;

                if (!M.IE3MoveGrowth.ContainsKey(comboBox1.Text))
                {
                    numericUpDown1.ReadOnly = true;
                }
                else Move1EvolveType = M.IE3MoveGrowth[comboBox1.Text];

                if (!M.IE3MoveGrowth.ContainsKey(comboBox2.Text))
                {
                    numericUpDown2.ReadOnly = true;
                }
                else Move2EvolveType = M.IE3MoveGrowth[comboBox2.Text];

                if (!M.IE3MoveGrowth.ContainsKey(comboBox3.Text))
                {
                    numericUpDown3.ReadOnly = true;
                }
                else Move3EvolveType = M.IE3MoveGrowth[comboBox3.Text];

                if (!M.IE3MoveGrowth.ContainsKey(comboBox4.Text))
                {
                    numericUpDown4.ReadOnly = true;
                }
                else Move4EvolveType = M.IE3MoveGrowth[comboBox4.Text];

                if (!M.IE3MoveGrowth.ContainsKey(comboBox5.Text))
                {
                    numericUpDown5.ReadOnly = true;
                }
                else Move5EvolveType = M.IE3MoveGrowth[comboBox5.Text];

                if (!M.IE3MoveGrowth.ContainsKey(comboBox6.Text))
                {
                    numericUpDown6.ReadOnly = true;
                }
                else Move6EvolveType = M.IE3MoveGrowth[comboBox6.Text];
            }

            numericUpDown1.Minimum = M.GetMinMoveLevel(Move1EvolveType);
            numericUpDown2.Minimum = M.GetMinMoveLevel(Move2EvolveType);
            numericUpDown3.Minimum = M.GetMinMoveLevel(Move3EvolveType);
            numericUpDown4.Minimum = M.GetMinMoveLevel(Move4EvolveType);
            numericUpDown5.Minimum = M.GetMinMoveLevel(Move5EvolveType);
            numericUpDown6.Minimum = M.GetMinMoveLevel(Move6EvolveType);

            numericUpDown1.Maximum = M.GetMaxMoveLevel(Move1EvolveType);
            numericUpDown2.Maximum = M.GetMaxMoveLevel(Move2EvolveType);
            numericUpDown3.Maximum = M.GetMaxMoveLevel(Move3EvolveType);
            numericUpDown4.Maximum = M.GetMaxMoveLevel(Move4EvolveType);
            numericUpDown5.Maximum = M.GetMaxMoveLevel(Move5EvolveType);
            numericUpDown6.Maximum = M.GetMaxMoveLevel(Move6EvolveType);

            numericUpDown1.Value = M.GetCurrentMoveLevel(Move1Level, Move1EvolveType);
            numericUpDown2.Value = M.GetCurrentMoveLevel(Move2Level, Move2EvolveType);
            numericUpDown3.Value = M.GetCurrentMoveLevel(Move3Level, Move3EvolveType);
            numericUpDown4.Value = M.GetCurrentMoveLevel(Move4Level, Move4EvolveType);
            numericUpDown5.Value = M.GetCurrentMoveLevel(Move5Level, Move5EvolveType);
            numericUpDown6.Value = M.GetCurrentMoveLevel(Move6Level, Move6EvolveType);

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

            numericUpDown7.Value = PlayerLevel;
            textBox22.Text = P.HEXToPlayer[PlayerHEX];
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LoadPlayer();
        }

        void SaveFile()
        {
            // Create Backup
            SavedataFull = File.ReadAllBytes(Filename);
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(Filename + ".bak", FileMode.Create)))
            {
                binWriter.Write(SavedataFull);
            }
            PatchChecksums();
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(Filename, FileMode.Create)))
            {
                binWriter.Write(ModifiedBlock);
            }

            MessageBox.Show("Save has been modified!");
        }

        // TODO Make this look cleaner
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox1.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox1.Text];
                }
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox1.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox1.Text];
                }
            }
            byte Move1Level = block[0x44];
            byte TimesUsed = M.SetNewLevel(numericUpDown1.Value, MoveEvolveType);
            block[0x44] = TimesUsed;
            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox2.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox2.Text];
                }
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox2.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox2.Text];
                }
            }
            byte Move1Level = block[0x45];
            byte TimesUsed = M.SetNewLevel(numericUpDown2.Value, MoveEvolveType);
            block[0x45] = TimesUsed;
            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox3.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox3.Text];
                }
                
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox3.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox3.Text];
                }
                
            }
            byte Move1Level = block[0x46];
            byte TimesUsed = M.SetNewLevel(numericUpDown3.Value, MoveEvolveType);
            block[0x46] = TimesUsed;

            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox4.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox4.Text];
                }
                
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox4.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox4.Text];
                }
                
            }
            byte Move1Level = block[0x47];
            byte TimesUsed = M.SetNewLevel(numericUpDown4.Value, MoveEvolveType);
            block[0x47] = TimesUsed;

            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox5.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox5.Text];
                }
                
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox5.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox5.Text];
                }
                
            }
            byte Move1Level = block[0x48];
            byte TimesUsed = M.SetNewLevel(numericUpDown5.Value, MoveEvolveType);
            block[0x48] = TimesUsed;

            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(comboBox6.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[comboBox6.Text];
                }
                
            }
            else
            {
                if (M.IE2MoveGrowth.ContainsKey(comboBox6.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[comboBox6.Text];
                }
                
            }
            byte Move1Level = block[0x49];
            byte TimesUsed = M.SetNewLevel(numericUpDown6.Value, MoveEvolveType);
            block[0x49] = TimesUsed;

            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }
    }
}
