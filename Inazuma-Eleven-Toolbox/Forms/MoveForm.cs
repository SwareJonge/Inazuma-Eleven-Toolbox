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
using Inazuma_Eleven_Toolbox.Logic;
using Inazuma_Eleven_Toolbox.Dictionaries.ENG;
using Inazuma_Eleven_Toolbox.Utils;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();
        }

        IECommonDictionary Dict = new IECommonDictionary();
        public string commandDat = "";
        public string commandSTR = "";
        public byte[] cmd = { };
        public byte[] cmd_str = { };

        string getGrowthType(byte input)
        {
            if (input == 0)
                return "None";

            string type1 = "";
            string type2 = "";
            var low = input & 0x03;
            var high = input - low;

            if (high == 0)
                type1 = "L ";
            else if (high == 100)
                type1 = "Shin ";
            else if (high == 200)
                type1 = "V ";

            if (low == 1)
                type2 = "(Normal)";
            else if (low == 2)
                type2 = "(Fast)";
            else if (low == 3)
                type2 = "(Slow)";

            return String.Concat(type1, type2);
        }

        byte getPwrInc(byte input)
        {
            if (input == 0)
                return 0 ;

            byte increment = 0;
            byte[] shinTable = { 0xA, 0x8, 0xC };
            byte[] lTable = { 0x10, 0xE, 0x12 };

            var low = input & 0x03;
            var high = input - low;            

            if (high == 0) // L/G Move
                increment = lTable[low - 1];
            else if (high == 100 || high == 200) // Shin and V Moves
                increment = shinTable[low - 1];
            return increment;
        }
        
        string getSecondaryType(byte Keeper, byte FieldPlayer, byte MoveType)
        {
            string[] KeeperMoveTypeList = { "Catch", "Punch", "Power Punch" };
            if (MoveType == 4 || MoveType == 8)
            {
                return KeeperMoveTypeList[Keeper];
            }
            else
            {
                if (FieldPlayer == 1)
                    return "Long";
                else if (FieldPlayer == 2 || FieldPlayer == 4)
                    return "Block";
                else if (FieldPlayer == 8)
                    return "Chain";
            }
            return "";
        }

        string lookUpRestrictions(byte PlayerAmount, ushort restriction, ushort restriction2, string Game)
        {
            if (restriction == 0)
                return "";
            /*else if (restriction > 1 && restriction < 5 && restriction2 < 1)
                return "Player With " + Dict.ElementToStr[restriction] + " Element";
            else
            {
                if (PlayerAmount > 1)
                {
                    string output = "";
                    if (restriction == 1)
                        output = "Any";
                    if (restriction2 == 1)
                        output = String.Concat(output, " Any");
                    return output;
                }
            }*/

            if (restriction > 0x64 && restriction < 0x1D9) // Lookup Move in command.dat
            {
                int cmdStrOffset = 0x14;
                int blockSize = 0x1C;
                if (Game == "IE3")
                {
                    cmdStrOffset = 0x18;
                    blockSize = 0x24;
                }
                ushort STRIdx = BitConverter.ToUInt16(cmd.Skip((restriction * blockSize) + cmdStrOffset).Take(2).ToArray(), 0);
                return "Player With " + TextDecoder.Decode(cmd_str.Skip(STRIdx * 0x20).Take(0x20).ToArray());
            }            
            // Different Type of restriction, either body type, gender or Element.
            else return "";

        }

        private void AddValuesFromCommandDat(int EndOffset, int BlockSize, string Game, string region)
        {           
            commandDat = @"Game Files/" + region + "/" + Game + "/command.dat";
            commandSTR = @"Game Files/" + region + "/" + Game + "/command.STR";
            if (File.Exists(commandDat) && File.Exists(commandSTR))
            {
                string[] TypeList = { "None", "Normal Dribble", "Normal Block", "Normal Shot", "Normal Catch", "Dribble", "Block", "Shoot", "Keeper", "Skill", "", "", "", "", "", "", "", "", "", "", "Debug" };
                cmd = FileIO.ReadFile(commandDat);
                cmd_str = FileIO.ReadFile(commandSTR);

                int cmdStrOffset = 0x14;
                if (Game == "IE3")
                {
                    cmdStrOffset = 0x18;
                }

                // BlockSize = 0x24 for IE3 and 0x1C for IE2 and IE1
                for (int i = 0; i < cmd.Length; i += BlockSize)
                {
                    ushort cmdstrNameIdx = BitConverter.ToUInt16(cmd.Skip(i + cmdStrOffset).Take(2).ToArray(), 0);
                    string MoveName = TextDecoder.Decode(cmd_str.Skip(cmdstrNameIdx * 32).Take(0x20).ToArray());

                    if (MoveName == "") // No Need for empty spaces
                        continue;

                    byte type = cmd[i];
                    byte FoulRate = cmd[i + 0x1];

                    ushort cmdstrSummaryIdx = BitConverter.ToUInt16(cmd.Skip(i + cmdStrOffset + 2).Take(2).ToArray(), 0);
                    string MoveSummary = TextDecoder.Decode(cmd_str.Skip((cmdstrSummaryIdx) * 32).ToArray());
                    byte TP = cmd[i + 4];
                    byte power = cmd[i + 6];
                    byte Element = cmd[i + 8];
                    byte prtnerAmnt = cmd[i + 0xA];
                    ushort coopPlayerRestriction = BitConverter.ToUInt16(cmd.Skip(i + 0xC).Take(0x2).ToArray(), 0);
                    ushort RestrictionFlg2 = BitConverter.ToUInt16(cmd.Skip(i + 0x10).Take(0x2).ToArray(), 0);

                    byte KeeperEfctType = cmd[i + (cmdStrOffset - 0x6)]; // Only For Keeper Moves: 0 is Catch, 1 is Punching 1, 2 is Punching 2
                    byte EfctType2 = cmd[i + (cmdStrOffset - 0x5)]; // For Other Moves: 1 = Long Shot, 2 = Block(Block Move) 4 = Block(Shooting Move) 8 = Shoot Chain
                    byte Evolve_Type = cmd[i + (cmdStrOffset - 0x4)];
                    byte max_Power = (byte)(power + getPwrInc(Evolve_Type));
                    
                    string HEX = "0x" + (i / BlockSize).ToString("X2");
                    /*Move Name, Move Type, Element, Base Power, Max power, Tp Cost, Foul Rate, Evolve Type, Secondary Type, Summary */
                    dataGridView1.Rows.Add(MoveName, TypeList[type], Dict.ElementToStr[Element], power, max_Power, TP, FoulRate + "%", getGrowthType(Evolve_Type), getSecondaryType(KeeperEfctType, EfctType2, type), MoveSummary, HEX, lookUpRestrictions(prtnerAmnt, coopPlayerRestriction, RestrictionFlg2, Game));
                    Console.WriteLine(HEX + " 0x" + prtnerAmnt.ToString("X2"));
                }
            }
            else MessageBox.Show("Couldn\'t find command.dat or command.STR!");

        }

        private void btn_Show_Stats_Click(object sender, EventArgs e)
        {
            string GameVersion = cmbBoxGameVer.GetItemText(cmbBoxGameVer.SelectedItem);
            string Region = cmbBoxRGN.GetItemText(cmbBoxRGN.SelectedItem);
            bool isGameSelected = true;

            if (GameVersion != "Inazuma Eleven" && GameVersion != "Inazuma Eleven 2" && GameVersion != "Inazuma Eleven 3")
            {
                MessageBox.Show("A game must be selected first! ");
                isGameSelected = false;
            }
            bool isRegionSpecified = true;
            if (Region != "EUR" && Region != "JAP")
            {
                MessageBox.Show("A region must be specified! ");
                isRegionSpecified = false;
            }

            if (GameVersion == "Inazuma Eleven" && Region  == "JAP")
            {
                MessageBox.Show("Currently Not Supported.");
                return;
            }

            int commandDatEnd = 0;
            int commandDatBlockSize = 0;
            string Abbr = "";

            if(GameVersion == "Inazuma Eleven" || GameVersion == "Inazuma Eleven 2")
            {
                commandDatEnd = 0x3800;
                commandDatBlockSize = 0x1C;
            }
            else if (GameVersion == "Inazuma Eleven 3")
            {
                commandDatEnd = 0x4800;
                commandDatBlockSize = 0x24;
            }

            if (GameVersion.Contains("2"))
            {
                Abbr = "IE2";
            }
            else if (GameVersion.Contains("3"))
            {
                Abbr = "IE3";
            }
            else Abbr = "IE";

            if (isGameSelected && isRegionSpecified)
            {
                dataGridView1.Rows.Clear();
                AddValuesFromCommandDat(commandDatEnd, commandDatBlockSize, Abbr, Region);
            }

        }
    }
}
