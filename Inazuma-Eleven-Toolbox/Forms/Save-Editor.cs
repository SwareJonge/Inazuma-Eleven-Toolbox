using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Inazuma_Eleven_Toolbox.Utils;
using DamienG.Security.Cryptography;
using System.Windows.Forms;
using Inazuma_Eleven_Toolbox.Dictionaries.ENG;
using Inazuma_Eleven_Toolbox.Forms._Save_Editor.Config;
using Inazuma_Eleven_Toolbox.Logic;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class Save_Editor : Form
    {
        public Save_Editor()
        {
            InitializeComponent();
        }

        public int PrestigePointsOffset = 0;
        public int FriendshipPointsOffset = 0;
        int PlayerStartOffset = 0;
        public int length = 0;
        public bool isIE3 = false;
        public bool isIE2 = false;
        public bool isIE1 = false;

        int Checksum1Offset = 0x40;
        int Checksum1BlockStart = 0x44;
        int Checksum1BlockLength = 0;
        int ItemEndOffset = 0;
        int NameOffset = 0;
        byte max_Training = 0;

        int Checksum2BlockStart = 0;
        int Checksum2BlockLength = 0;

        IECommonDictionary D = new IECommonDictionary();
        PlayerFuncs P = new PlayerFuncs();

        int DataGridviewIndexFromCell(int index)
        {
            int i = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value) - 1;
            if (i == -1)
            {
                return dataGridView1.CurrentRow.Index;
            }
            else return i;
        }

        // isNDSSave will be used for the nds version if IE3
        bool SetOffsets(string GameVersion, string ndsTitleID, bool isNDSSave) 
        {
            // set defaults
            bool identifiedSave = true;
            isIE1 = false;
            isIE2 = false;
            isIE3 = false;
            Checksum1BlockLength = 0x7C;
            Checksum2BlockStart = 0xC0;
            ItemEndOffset = 0x45D;
            PrestigePointsOffset = 0x4D4;
            FriendshipPointsOffset = 0x4D8;
            NameOffset = 0x4C0;
            length = 0x70;
            max_Training = 50;

            bool JAPIE2 = (ndsTitleID == "BEBJ" || ndsTitleID == "BEEJ");
            if (GameVersion == "INAZUMA_11_EU" || JAPIE2) // The European version of IE1 is based of the Japanese version of IE2.
            {
                if (JAPIE2)
                    isIE2 = true;
                else
                    isIE1 = true;

                PlayerStartOffset = 0x124C;
                Checksum2BlockLength = 0x7D44;
            }
            else if (GameVersion == "INAZUMA2_12_EU")
            {
                isIE2 = true;
                PlayerStartOffset = 0x13F8;
                Checksum2BlockLength = 0x7E8C;
            }
            else if ((GameVersion == "INAZUMA_ELEVEN3") && (SavedataFull[0x38] != 0)) // make sure we know it's not the japanese version of the 123 release 
            {
                isIE3 = true;
                max_Training = 20;
                PrestigePointsOffset = 0x4E8;
                FriendshipPointsOffset = 0x4EC;
                PlayerStartOffset = 0x11F8;
                length = 0x6C;
                Checksum1BlockLength = 0x84;
                Checksum2BlockStart = 0xC8;
                Checksum2BlockLength = 0x59A0;
                ItemEndOffset = 0x4B7;
                NameOffset = 0x4C8;
            }
            else if (GameVersion.Contains("INAZUMA_ELEVEN")) // Inazuma eleven 1-2-3, Japanese Inazuma Eleven, USA Release of Inazuma Eleven 1
            {
                if (GameVersion.Contains("2"))
                {
                    isIE2 = true;
                    PlayerStartOffset = 0x1268;
                    Checksum2BlockLength = 0x7DC0;
                }
                else if (GameVersion.Contains("3"))
                {
                    isIE3 = true;
                    max_Training = 20;
                    length = 0x6C;
                    ItemEndOffset = 0x4AF;
                    PlayerStartOffset = 0x11B0;
                    Checksum2BlockLength = 0x5940;
                }
                else // works for all IE1 games except for the European but uses different formats for players so they're currently not loaded
                {
                    /*isIE1 = true;
                    NameOffset = 0x2C0;
                    PrestigePointsOffset = 0x2D4;
                    FriendshipPointsOffset = 0x2D8;
                    PlayerStartOffset = 0x1268;
                    length = 0x70;
                    Checksum2BlockLength = 0x54C0;*/
                    identifiedSave = false; // lock out save
                }
            }

            else identifiedSave = false; // lock out everything
            return identifiedSave;
        }

        string Filename = "";
        public byte[] SavedataFull = null;
        public byte[] ModifiedBlock = null;

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Title = "Open Save File";
            openFileDialog1.InitialDirectory = Config.SaveFolder;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Filename = openFileDialog1.FileName;
                Config.SaveFolder = Path.GetDirectoryName(Filename);
                Config.Save();
                SavedataFull = FileIO.ReadFile(Filename);

                string TestIfInazumaSave = Encoding.ASCII.GetString(SavedataFull.Skip(0x4).Take(0x7).ToArray());                
                if (TestIfInazumaSave != "INAZUMA")
                {
                    MessageBox.Show("This is not a Inazuma Eleven DS Save File!");
                    return;
                }

                string Game = Encoding.ASCII.GetString(SavedataFull.Skip(0x4).Take(0x10).ToArray()).Replace("\0", "");
                string ndsTitleID = Encoding.ASCII.GetString(SavedataFull.Skip(0x14).Take(0x4).ToArray()).Replace("\0", "");
                bool isNDSSave = Filename.EndsWith(".sav");

                if (Game == "INAZUMA_ELEVEN3" && isNDSSave)
                {
                    MessageBox.Show("The Japanese Version of IE3 is encrypted, the method to decrypt and encrypt has not been found yet.");
                    return;
                }
                
                ModifiedBlock = SavedataFull;

                bool identifiedGame = SetOffsets(Game, ndsTitleID, isNDSSave);
                if(!identifiedGame)
                {
                    MessageBox.Show("Couldn't identify save.");
                    return;
                }
                ItemClass.getItemSaveFilePos(isIE3);
                Moves.getMoveGrowth(isIE3);
                PlayerClass.getPlayerClass(isIE3);
                label4.Text = Game;
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                numericPrestige.Enabled = true;
                numericFriendship.Enabled = true;
                textBox22.Enabled = true;
                txtBoxName.Enabled = true;
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;
                numericUpDown7.Enabled = true;
                //numericUpDown17.Enabled = true;
                //numericUpDown18.Enabled = true;
                numericUpDown19.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;

                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                numericUpDown6.ReadOnly = false;
                numericUpDown7.ReadOnly = false;
                numericUpDown15.ReadOnly = false;
                numericUpDown16.ReadOnly = false;

                // set FP and TP Training to 20 or 50 dependant on the game
                numericUpDown15.Maximum = max_Training;
                numericUpDown16.Maximum = max_Training;


                if (!isIE1)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

                byte players = SavedataFull[0x57];
                if (players == 100)
                {
                    button4.Enabled = false;
                }

                // These are used for stats, since i think they're unreliable to edit without knowing their current stats, it's better to not include them

                //numericUpDown8.Enabled = true;
                //numericUpDown9.Enabled = true;
                //numericUpDown10.Enabled = true;
                //numericUpDown11.Enabled = true;
                //numericUpDown12.Enabled = true;
                //numericUpDown13.Enabled = true;
                //numericUpDown14.Enabled = true;
                numericUpDown15.Enabled = true;
                numericUpDown16.Enabled = true;
                //textBox19.Enabled = true;
                //textBox20.Enabled = true;
                //textBox21.Enabled = true;
                saveToolStripMenuItem.Enabled = true;                

                numericPrestige.Value = BitConverter.ToInt32(SavedataFull.Skip(PrestigePointsOffset).Take(4).ToArray(), 0);
                numericFriendship.Value = BitConverter.ToInt32(SavedataFull.Skip(FriendshipPointsOffset).Take(4).ToArray(), 0);
                // Need to figure out what encoding this game uses
                txtBoxName.Text = Encoding.UTF8.GetString(SavedataFull.Skip(NameOffset).Take(10).ToArray()).Replace("\0", "");

                LoadItems();

                LoadPlayersIntoDataGridView(players);
            }

        }


        void LoadPlayersIntoDataGridView(int Players)
        {
            dataGridView1.Rows.Clear();
            byte[] block = new byte[length];
            for (int i = PlayerStartOffset; i < PlayerStartOffset + (Players * length); i += length)
            {
                block = ModifiedBlock.Skip(i).Take(length).ToArray();

                short PlayerHEX = BitConverter.ToInt16(block.Skip(0x4).Take(2).ToArray(), 0);
                byte PlayerLevel = block[0x4A];

                dataGridView1.Rows.Add(((i - PlayerStartOffset) / length + 1).ToString(), P.HEXToPlayer[PlayerHEX], PlayerLevel.ToString(), "0x" + PlayerHEX.ToString("X2"));
            }
        }

        void LoadItems()
        {
            dataGridView2.Rows.Clear();
            string ItemName = "";
            for (int i = Checksum2BlockStart; i <= ItemEndOffset; i++)
            {
                if(ItemClass.ItemSaveFilePos.ContainsKey(i - Checksum2BlockStart))
                {
                    ItemName = ItemClass.ItemSaveFilePos[i - Checksum2BlockStart];
                    dataGridView2.Rows.Add(ItemName, ModifiedBlock[i], "0x" + (i - Checksum2BlockStart).ToString("X2"));
                }
            }
        }

        void SetNewItemAmount(byte Amount, int offset)
        {
            ModifiedBlock[offset] = Amount;
        }

        void PatchChecksum(int BlockStart, int Length, int ChecksumOffset)
        {
            byte[] block = ModifiedBlock.Skip(BlockStart).Take(Length).ToArray();
            byte[] Checksum = BitConverter.GetBytes(Crc32.Compute(block));
            ModifiedBlock = FileIO.WriteData(ModifiedBlock, ChecksumOffset, Checksum, Checksum.Length);
        }
        void PatchChecksums()
        {
            // Patch Second Checksum first since it's in the block of the first checksum
            PatchChecksum(Checksum2BlockStart, Checksum2BlockLength, Checksum1BlockStart); // Checksum1BlockStart is the same as CheckSum2Offset
            PatchChecksum(Checksum1BlockStart, Checksum1BlockLength, Checksum1Offset);
        }

        void ImportPlayer(int Index, bool isImportPlayer)
        {
            OpenFileDialog OpenPlayer = new OpenFileDialog
            {
                Title = "Open Player",
                RestoreDirectory = true,
                DefaultExt = "IEPlayer",
                FileName = "*.IEPlayer",
                InitialDirectory = Config.PlayerFolder
            };

            if (isIE3)
            {
                OpenPlayer.Filter = "Player Files (*.IE3Player, *.pla)|*.IE3Player; *.pla|IE Toolbox Player (*.IE3Player)|*.IE3Player|NFFM3 Player(*.pla)|*.pla";
                OpenPlayer.FileName = "";
            }
            if (OpenPlayer.ShowDialog() == DialogResult.OK)
            {
                Config.PlayerFolder = Path.GetDirectoryName(OpenPlayer.FileName);
                Config.Save();
                byte[] Player = FileIO.ReadFile(OpenPlayer.FileName).ToArray();
                if(OpenPlayer.FileName.EndsWith(".pla"))
                {
                    string hex = File.ReadAllText(OpenPlayer.FileName);
                    // Block Players From chronostone or galaxy
                    string a = new StringReader(hex).ReadLine();
                    if (a == "chronostone" || a == "galaxy")
                    {
                        MessageBox.Show("This is not a player from Inazuma Eleven 3!");
                        // return, don't execute further
                        return;
                    }                    
                    Player = NFFM3_Plugin.StringToByteArray(hex.Replace(" ", ""));
                }
                ModifiedBlock = FileIO.WriteData(ModifiedBlock, (Index * length) + PlayerStartOffset, Player, Player.Length);
                if(isImportPlayer)
                {
                    // Since we Added a Player, the game has to know this.
                    ModifiedBlock[0x57] = (byte)(ModifiedBlock[0x57] + 1);
                }
            }
        }

        void CheckIfIllegal(ushort ConsumablePoints, int PlayerIndex, NumericUpDown num, int offset)
        {
            if (ConsumablePoints >= max_Training)
            {
                num.Value = max_Training;                
            }
            else
            {
                num.Value = ConsumablePoints;
            }
        }

        void LoadPlayer()
        {
            int j = DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index);

            // Init This Before executing the for loop, should save some time
            byte[] block = new byte[length];
            if (j < 100)
            {                
                byte players = ModifiedBlock[0x57];
                block = ModifiedBlock.Skip((j * length) + PlayerStartOffset).Take(length).ToArray();

                uint EXP = BitConverter.ToUInt32(block.Skip(0x0).Take(4).ToArray(), 0);
                short PlayerHEX = BitConverter.ToInt16(block.Skip(0x4).Take(2).ToArray(), 0);

                // Make this bit a little more efficient / look cleaner by using for loops
                ushort[] ConsumablePoints = new ushort[2];
                ushort[] TrainedConsumablePoints = new ushort[2];
                // This is for FP and TP
                for (int i = 0; i < 4; i += 2)
                {
                    int k = i / 2;
                    ConsumablePoints[k] = BitConverter.ToUInt16(block.Skip(0x34 + i).Take(2).ToArray(), 0);
                    TrainedConsumablePoints[k] = BitConverter.ToUInt16(block.Skip(0x18 + i).Take(2).ToArray(), 0);
                }

                ushort[] move = new ushort[6];
                byte[] moveLevel = new byte[6];
                for(int i = 0; i < 12; i+=2)
                {
                    int k = i / 2; // since we need to do this multiple times, make it a local variable                  
                    move[k] = BitConverter.ToUInt16(block.Skip(0x38 + i).Take(2).ToArray(), 0);
                    moveLevel[k] = block[0x44 + k];
                }

                byte PlayerLevel = block[0x4A];

                sbyte[] TrainedValue = new sbyte[7];
                for(int i = 0; i < 7; i++)
                {
                    TrainedValue[i] = (sbyte)block[0x4F + i];
                }

                // Check if TP and FP are higher than the limit
                CheckIfIllegal(TrainedConsumablePoints[0], j, numericUpDown15, 0x18);
                CheckIfIllegal(TrainedConsumablePoints[1], j, numericUpDown16, 0x1A);      

                numericUpDown17.Value = ConsumablePoints[0];
                numericUpDown18.Value = ConsumablePoints[1];

                numericUpDown8.Value = TrainedValue[0];
                numericUpDown9.Value = TrainedValue[1];
                numericUpDown10.Value = TrainedValue[3];
                numericUpDown11.Value = TrainedValue[2];
                numericUpDown12.Value = TrainedValue[4];
                numericUpDown13.Value = TrainedValue[6];
                numericUpDown14.Value = TrainedValue[5];

                comboBox1.Text = D.MoveToStr[move[0]];
                comboBox2.Text = D.MoveToStr[move[1]];
                comboBox3.Text = D.MoveToStr[move[2]];
                comboBox4.Text = D.MoveToStr[move[3]];
                comboBox5.Text = D.MoveToStr[move[4]];
                comboBox6.Text = D.MoveToStr[move[5]];

                string Move1EvolveType = SetReadOnly(numericUpDown1, comboBox1);
                string Move2EvolveType = SetReadOnly(numericUpDown2, comboBox2);
                string Move3EvolveType = SetReadOnly(numericUpDown3, comboBox3);
                string Move4EvolveType = SetReadOnly(numericUpDown4, comboBox4);
                string Move5EvolveType = SetReadOnly(numericUpDown5, comboBox5);
                string Move6EvolveType = SetReadOnly(numericUpDown6, comboBox6);

                SetMoveLevels(numericUpDown1, Move1EvolveType, moveLevel[0]);
                SetMoveLevels(numericUpDown2, Move2EvolveType, moveLevel[1]);
                SetMoveLevels(numericUpDown3, Move3EvolveType, moveLevel[2]);
                SetMoveLevels(numericUpDown4, Move4EvolveType, moveLevel[3]);
                SetMoveLevels(numericUpDown5, Move5EvolveType, moveLevel[4]);
                SetMoveLevels(numericUpDown6, Move6EvolveType, moveLevel[5]);

                TextBox[] txtBoxEquip = { textBox19, textBox20, textBox21 };

                for (int i = 0; i < 0x3; i++)
                {
                    short Equipment = BitConverter.ToInt16(block.Skip(0x10 + (i * 2)).Take(2).ToArray(), 0);
                    displayEquipment(txtBoxEquip[i], Equipment);
                }

                numericUpDown7.Value = PlayerLevel;
                textBox22.Text = P.HEXToPlayer[PlayerHEX];
            }
            else return;
        }


        void displayEquipment(TextBox txtBox, short equipment)
        {
            if (equipment != 0)
                txtBox.Text = ItemClass.ItemSaveFilePos[equipment];
            else txtBox.Text = "None";
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
            MoveLevel.Minimum = Moves.GetMinMoveLevel(EvolveType);
            MoveLevel.Maximum = Moves.GetMaxMoveLevel(EvolveType);
            MoveLevel.Value = Moves.GetCurrentMoveLevel(TimesUsed, EvolveType);
        }

        public string SetReadOnly(NumericUpDown MoveLevel, ComboBox MoveName)
        {
            MoveLevel.ReadOnly = false;

            if (!Moves.MoveGrowth.ContainsKey(MoveName.Text))
            {
                MoveLevel.ReadOnly = true;
            }
            else return Moves.MoveGrowth[MoveName.Text];

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
            int Player = DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index);
            byte players = ModifiedBlock[0x57];
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();

            string MoveEvolveType = "";

            if (Moves.MoveGrowth.ContainsKey(MoveName.Text))
            {
                MoveEvolveType = Moves.MoveGrowth[MoveName.Text];
            }

            byte Move1Level = block[LevelOffset];
            byte TimesUsed = Moves.SetNewLevel(MoveLevel.Value, MoveEvolveType);
            block[LevelOffset] = TimesUsed;
            ModifiedBlock = FileIO.WriteData(ModifiedBlock, (Player * length) + PlayerStartOffset, block, block.Length);
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

                if (Moves.MoveGrowth.ContainsKey(MoveName))
                {
                    MoveEvolveType = Moves.MoveGrowth[MoveName];
                    block[0x44 + i] = Moves.SetNewLevel(Moves.GetMaxMoveLevel(MoveEvolveType), MoveEvolveType);
                    ModifiedBlock = FileIO.WriteData(ModifiedBlock, (PlayerIndex * length) + PlayerStartOffset, block, block.Length);
                }

            }
            LoadPlayer();
        }

        void SetConsumablePoints(int PlayerIndex, byte Value, int Patchoffset)
        {
            int PlayerOffset = (PlayerIndex * length);
            byte[] block = ModifiedBlock.Skip(PlayerOffset + PlayerStartOffset).Take(length).ToArray();
            block[Patchoffset] = Value;
            ModifiedBlock = FileIO.WriteData(ModifiedBlock, PlayerOffset + PlayerStartOffset, block, block.Length);
            LoadPlayer();
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
            SetAllMaxLevels(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index));
            MessageBox.Show("Edited move Levels for current player!");
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            byte players = ModifiedBlock[0x57];
            for (int i = 0; i < players; i++)
            {
                SetAllMaxLevels(i);
            }
            MessageBox.Show("Edited Move Levels For All Players!");
            LoadPlayer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = Checksum2BlockStart; i <= ItemEndOffset; i++)
            {
                if (ItemClass.ItemSaveFilePos.ContainsKey(i - Checksum2BlockStart))
                {
                    SetNewItemAmount((byte)numericUpDown19.Value, i);
                }
            }
                        
            LoadItems(); // Reload datagridview
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Player = DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index);
            byte[] block = ModifiedBlock.Skip((Player * length) + PlayerStartOffset).Take(length).ToArray();
            SaveFileDialog savePlayer = new SaveFileDialog
            {
                Title = "Save Player",
                FileName = textBox22.Text,
                DefaultExt = "IEPlayer",
                RestoreDirectory = true,                
                Filter = "IEPlayer Files (*.IEPlayer)|*.IEPlayer",                
                InitialDirectory = Config.PlayerFolder
            };

            if (isIE3)
            {                
                savePlayer.FilterIndex = Config.DefaultExportExt;
                savePlayer.Filter = "IE3Player Files (*.IE3Player)|*.IE3Player|NFFM3 Player File (*.pla)|*.pla";
                savePlayer.FileName = textBox22.Text;
            }

            if (savePlayer.ShowDialog() == DialogResult.OK)
            {
                Config.PlayerFolder = Path.GetDirectoryName(savePlayer.FileName);
                if(isIE3)
                {
                    Config.DefaultExportExt = savePlayer.FilterIndex;
                    Config.Save();
                }
               
                if (savePlayer.FileName.EndsWith(".pla"))
                {
                    NFFM3_Plugin.ExportPlayer(block, savePlayer);
                }
                else
                {
                    File.WriteAllBytes(savePlayer.FileName, block);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Catch Error, index 100 is player 101 and if we overwrite this then idk what kind of problems this would cause
            if (dataGridView1.CurrentRow.Index == 100)
            {
                MessageBox.Show("Error!");
                // don't execute function further
                return;
            }

            // Import the player after the block of the last player
            ImportPlayer(ModifiedBlock[0x57], true);
            // Reload Datagridview
            LoadPlayersIntoDataGridView(ModifiedBlock[0x57]);
            // To prevent having more than 100 players and thus corrupting the savefile, make an extra check here
            if (ModifiedBlock[0x57] == 100)
            {
                button4.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Catch Error, index 100 is player 101 and if we overwrite this then idk what kind of problems this would cause
            if (dataGridView1.CurrentRow.Index == 100)
            {
                MessageBox.Show("Error!");
                // don't execute function further
                return;
            }
            // Replace Player
            ImportPlayer(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index), false);
            // Reload Datagridview
            LoadPlayersIntoDataGridView(ModifiedBlock[0x57]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void numericFriendship_ValueChanged(object sender, EventArgs e)
        {
            byte[] Friendship = BitConverter.GetBytes((uint)numericFriendship.Value);

            ModifiedBlock = FileIO.WriteData(ModifiedBlock, FriendshipPointsOffset, Friendship, 4);
        }

        private void numericPrestige_ValueChanged(object sender, EventArgs e)
        {
            byte[] Prestige = BitConverter.GetBytes((uint)numericPrestige.Value);

            ModifiedBlock = FileIO.WriteData(ModifiedBlock, PrestigePointsOffset, Prestige, 4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string NewName = txtBoxName.Text;
            char[] NameBytes = NewName.ToArray();
            char[] arr = new char[10];

            for (int i = 0; i < NameBytes.Length; i++)
            {
                arr[i] = NameBytes[i];
            }
            // Fill up the empty bytes just in case
            for (int i = NameBytes.Length; i < arr.Length; i++)
            {
                arr[i] = '\0';
            }
            // Need to figure out what encoding this game uses, might need to block special characters
            ModifiedBlock = FileIO.WriteData(ModifiedBlock, NameOffset, Encoding.Default.GetBytes(arr), arr.Length);
            // SaveFileheader Name
            ModifiedBlock = FileIO.WriteData(ModifiedBlock, 0x5C, Encoding.Default.GetBytes(arr), arr.Length);
            MessageBox.Show("Edited Name!");
        }

        private void Save_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            SetConsumablePoints(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index), (byte)numericUpDown15.Value, 0x18);
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            SetConsumablePoints(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index), (byte)numericUpDown16.Value, 0x1A);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetConsumablePoints(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index), max_Training, 0x18); // FP
            SetConsumablePoints(DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index), max_Training, 0x1A); // TP
            MessageBox.Show("Edited TP and FP for current player!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte players = ModifiedBlock[0x57];
            for (int i = 0; i < players; i++)
            {
                SetConsumablePoints(i, max_Training, 0x18); // FP
                SetConsumablePoints(i, max_Training, 0x1A); // TP
            }
            MessageBox.Show("All players have max FP and TP now!");
        }

        void editPlayerlevel(byte level, int offset)
        {
            int PlayerBlockOffset = (offset * length);
            byte[] block = ModifiedBlock.Skip(PlayerStartOffset + PlayerBlockOffset).Take(length).ToArray();
            ushort ScoutID = BitConverter.ToUInt16(block.Skip(0x4).Take(2).ToArray(), 0);
            EXP E = new EXP();
            int EXPType = 0;

            ushort[] Moves = { };
            byte[] UnlockLevels = { };

            if (!PlayerClass.IEPlayer.ContainsKey(ScoutID))
            {
                MessageBox.Show("An unknown Error occured");
                return;
            }
            EXPType = PlayerClass.IEPlayer[ScoutID].EXPType;
            Moves = PlayerClass.IEPlayer[ScoutID].MoveHEXID;
            UnlockLevels = PlayerClass.IEPlayer[ScoutID].MoveUnlockLevel;

            block[0x4a] = level;

            uint EXPToWrite = E.TypeToExp[EXPType][block[0x4a] - 1];

            ushort[] MovesInBlock = new ushort[4];

            List <Tuple<byte, ushort>> myList = new List<Tuple<byte, ushort>>();
            for (int i = 0; i < 4; i++)
            {
                MovesInBlock[i] = BitConverter.ToUInt16(block.Skip(0x38 + i * 2).Take(2).ToArray(), 0);
                block[i] = BitConverter.GetBytes(EXPToWrite)[i]; // since we do a for loop with 4 bytes, we can save some lines of code and drop it here
                myList.Add(new Tuple<byte, ushort>(UnlockLevels[i], Moves[i]));
            } 

            myList.Sort(Comparer<Tuple<byte, ushort>>.Default); // Sort the List

            for (int i = 0; i < 4; i++) // these are checks for wheter or not a player has learned a move or not, done this way just to prevent possible bugs
            {                
                if(level >= myList[i].Item1 && !MovesInBlock.Contains(myList[i].Item2)) // if the player level is higher or equal to the player's level and the move we're trying to learn isn't learned yet, write it 
                {
                    for (int j = i; j < 4; j++) // finds empty slot
                    {
                        if (BitConverter.ToUInt16(block.Skip(0x38 + j * 2).Take(2).ToArray(), 0) == 0) // if slot is empty, write move
                        {
                            block = FileIO.WriteData(block, 0x38 + (j * 2), BitConverter.GetBytes(myList[i].Item2), BitConverter.GetBytes(myList[i].Item2).Length);
                            break; // break and don't exectue loop further
                        }
                    }                    
                }
            }

            ModifiedBlock = FileIO.WriteData(ModifiedBlock, PlayerStartOffset + PlayerBlockOffset, block, block.Length); // no extra formatting to do since the EXP offset is 0       
            LoadPlayer(); // once done, reload
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            int Player = DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index);
            editPlayerlevel((byte)numericUpDown7.Value, Player);
            dataGridView1.Rows[Player].Cells[2].Value = numericUpDown7.Value; // Reload DataGridview
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Player = DataGridviewIndexFromCell(dataGridView1.CurrentRow.Index);
            byte level = Convert.ToByte(dataGridView1.Rows[Player].Cells[2].Value);            
            editPlayerlevel(level, Player);
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Offset = dataGridView2.CurrentRow.Index; // doesn't matter if we sort it considering we determine the patchoffset by the HEX ID in row 3 and thus always patch the correct offset
            byte Amount = Convert.ToByte(dataGridView2.Rows[Offset].Cells[1].Value);
            int HEXID = int.Parse(dataGridView2.Rows[Offset].Cells[2].Value.ToString().Remove(0, 2), System.Globalization.NumberStyles.HexNumber);

            SetNewItemAmount(Amount, HEXID + Checksum2BlockStart);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView2.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }


        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
