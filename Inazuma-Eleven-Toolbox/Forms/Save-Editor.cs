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
        public bool isIE2 = false;
        public bool isIE1 = false;

        int Checksum1Offset = 0x40;
        int Checksum1BlockStart = 0x44;
        int Checksum1BlockLength = 0x7C;

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
            else if (GameVersion == "INAZUMA_11_EU")
            {
                isIE1 = true;
                PrestigePointsOffset = 0x4D4;
                FriendshipPointsOffset = 0x4D8;
                PlayerStartOffset = 0x124C;
                length = 0x70;
                Checksum1BlockLength = 0x7C;
                Checksum2BlockStart = 0xC0;
                Checksum2BlockLength = 0x7D44;
                ItemsIE2 ItemIE2 = new ItemsIE2();
                IC.EquipmentOffsetToStr = ItemIE2.EquipmentOffsetToStrIE2;
            }
            else if (GameVersion == "INAZUMA2_12_EU")
            {
                isIE2 = true;
                PrestigePointsOffset = 0x4D4;
                FriendshipPointsOffset = 0x4D8;
                PlayerStartOffset = 0x13F8;
                length = 0x70;
                Checksum1BlockLength = 0x7C;
                Checksum2BlockStart = 0xC0;
                Checksum2BlockLength = 0x7E8C;
                ItemsIE2 ItemIE2 = new ItemsIE2();
                IC.EquipmentOffsetToStr = ItemIE2.EquipmentOffsetToStrIE2;
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
                
                if (TestIfInazumaSave != "INAZUMA")
                {
                    MessageBox.Show("This is not a Inazuma Eleven DS Save File!");
                    return;
                }
                if (Save_Data[0x17] == 0x4A)
                {
                    MessageBox.Show("Japanese save files are not supported since they have not been tested");
                    return;
                }
                if (Game == "INAZUMA_ELEVEN3" && openFileDialog1.FileName.EndsWith(".sav"))
                {
                    MessageBox.Show("The Japanese Version of IE3 is encrypted, the method to decrypt and encrypt has not been found yet.");
                    return;
                }

                label4.Text = Game;
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
                if(!isIE1)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }



                // These are used for stats, since i think they're unreliable to edit without knowing their current stats i think it's better to not include them

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

            string Move1EvolveType = SetReadOnly(numericUpDown1, comboBox1);
            string Move2EvolveType = SetReadOnly(numericUpDown2, comboBox2);
            string Move3EvolveType = SetReadOnly(numericUpDown3, comboBox3);
            string Move4EvolveType = SetReadOnly(numericUpDown4, comboBox4);
            string Move5EvolveType = SetReadOnly(numericUpDown5, comboBox5);
            string Move6EvolveType = SetReadOnly(numericUpDown6, comboBox6);

            SetMoveLevels(numericUpDown1, Move1EvolveType, Move1Level);
            SetMoveLevels(numericUpDown2, Move2EvolveType, Move2Level);
            SetMoveLevels(numericUpDown3, Move3EvolveType, Move3Level);
            SetMoveLevels(numericUpDown4, Move4EvolveType, Move4Level);
            SetMoveLevels(numericUpDown5, Move5EvolveType, Move5Level);
            SetMoveLevels(numericUpDown6, Move6EvolveType, Move6Level);

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

        public void SetMoveLevels(NumericUpDown MoveLevel, string EvolveType, byte TimesUsed)
        {
            MoveLevel.Minimum = M.GetMinMoveLevel(EvolveType);
            MoveLevel.Maximum = M.GetMaxMoveLevel(EvolveType);
            MoveLevel.Value = M.GetCurrentMoveLevel(TimesUsed, EvolveType);
        }

        public string SetReadOnly(NumericUpDown MoveLevel, ComboBox MoveName)
        {
            MoveLevel.ReadOnly = false;
            if (isIE2) 
            {
                if (!M.IE2MoveGrowth.ContainsKey(MoveName.Text))
                {
                    MoveLevel.ReadOnly = true;
                }
                else return M.IE2MoveGrowth[MoveName.Text];
            }
            if (isIE3)
            {
                if (!M.IE3MoveGrowth.ContainsKey(MoveName.Text))
                {
                    MoveLevel.ReadOnly = true;
                }
                else return M.IE3MoveGrowth[MoveName.Text];
            }
            // there are no movelevels in IE1 so don't edit them
            if (isIE1)
            {
                MoveLevel.ReadOnly = true;
                return "";
            }
            else
            {
                MoveLevel.ReadOnly = true;
                return "";
            }

        }

        void SaveMoveLevel(ComboBox MoveName, NumericUpDown MoveLevel, int LevelOffset)
        {
            int Player = dataGridView1.CurrentRow.Index;
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";
            if (isIE3)
            {
                if (M.IE3MoveGrowth.ContainsKey(MoveName.Text))
                {
                    MoveEvolveType = M.IE3MoveGrowth[MoveName.Text];
                }
            }
            if (isIE2)
            {
                if (M.IE2MoveGrowth.ContainsKey(MoveName.Text))
                {
                    MoveEvolveType = M.IE2MoveGrowth[MoveName.Text];
                }
            }
            byte Move1Level = block[LevelOffset];
            byte TimesUsed = M.SetNewLevel(MoveLevel.Value, MoveEvolveType);
            block[LevelOffset] = TimesUsed;
            WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox1, numericUpDown1, 0x44);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox2, numericUpDown2, 0x45);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox3, numericUpDown3, 0x46);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox4, numericUpDown4, 0x47);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox5, numericUpDown5, 0x48);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            SaveMoveLevel(comboBox6, numericUpDown6, 0x49);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetAllMaxLevels(dataGridView1.CurrentRow.Index);
        }

        void SetAllMaxLevels(int PlayerIndex)
        {
            byte[] block = ModifiedBlock.Skip((PlayerIndex * length) + PlayerStartOffset).Take(length).ToArray();
            // obtain all moves
            for (int i = 0; i < 6; i++)
            {
                short Move = BitConverter.ToInt16(block.Skip(0x38 + (i * 2)).Take(2).ToArray(), 0);
                string MoveName = D.MoveToStr[Move];
                string MoveEvolveType = "";
                if (isIE3)
                {
                    if (M.IE3MoveGrowth.ContainsKey(MoveName))
                    {
                        MoveEvolveType = M.IE3MoveGrowth[MoveName];
                        block[0x44 + i] = M.SetNewLevel(M.GetMaxMoveLevel(MoveEvolveType), MoveEvolveType);
                        ModifiedBlock = WriteData(ModifiedBlock, (PlayerIndex * length) + PlayerStartOffset, block, block.Length);
                    }
                    else continue; 
                }
                if (isIE2)
                {
                    if (M.IE2MoveGrowth.ContainsKey(MoveName))
                    {
                        MoveEvolveType = M.IE2MoveGrowth[MoveName];
                        block[0x44 + i] = M.SetNewLevel(M.GetMaxMoveLevel(MoveEvolveType), MoveEvolveType);
                        ModifiedBlock = WriteData(ModifiedBlock, (PlayerIndex * length) + PlayerStartOffset, block, block.Length);
                    }
                    else continue; 
                }              

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {            
            byte players = ModifiedBlock[0x57];
            for (int i = 0; i < players; i++)
            {
                SetAllMaxLevels(i);
            }
            MessageBox.Show("Edited Move Levels For All Players!");
        }
    }
}
