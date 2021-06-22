using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inazuma_Eleven_Toolbox.Dictionaries.ENG;
using Inazuma_Eleven_Toolbox.Utils;
using Inazuma_Eleven_Toolbox.Logic;

namespace Inazuma_Eleven_Toolbox.Forms
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void AddValuesFromUnitbase(int UnitBaseEndOffset, int UnitBaseBlockLength, int UnitStatBlockLength, string Game, string region)
        {
            /*                   StatsBlock Layout
 *           Length: 0x40 in IE(JAP) 0x50 in IE(EUR) & IE2, 0x48 in IE3
 *            IE3 doesn't have the garbage values
 * (short[3]) TP: 0x0 - MinTP, 0x2 - MaxTP, 0x4 - FPGrowthRate
 * short 0x6 - unk
 * (short[3]) FP: 0x8 - MinFP, 0xA - MaxFP, 0xC - TPGrowthRate
 * short 0xE - unk
 * (byte[2]) Kick: 0x10 - Min, 0x11 - Max, short 0x12 - GrowthRate
 * (byte[2]) Body: 0x14 - Min, 0x15 - Max, short 0x16 - GrowthRate
 * (byte[2]) Guard: 0x18 - Min, 0x19 - Max, short 0x1A - GrowthRate
 * (byte[2]) Control: 0x1C - Min, 0x1D - Max, short 0x1E - GrowthRate
 * (byte[2]) Speed: 0x20 - Min, 0x21 - Max, short 0x22 - GrowthRate
 * (byte[2]) Guts: 0x24 - Min, 0x25 - Max, short 0x26 - GrowthRate
 * (byte[2]) Stamina: 0x28 - Min, 0x29 - Max, short 0x2A - GrowthRate
 * (short[8]) Moves: 0x2C - MoveID_Slot1, 0x2E UnlockLevel, 0x30 - MoveID_Slot2, 0x32 UnlockLevel, (byte[8]) in IE(JAP)!!
 * 0x34 MoveID_Slot3, 0x36 UnlockLevel, 0x38 MoveID_Slot4, 0x3A UnlockLevel
 * (short[5]) 0x3C - Max total, unk, unk, unk, unk
 * Garbage data most likely */
            IECommonDictionary D = new IECommonDictionary();

            string PlayerNamesFileName = @"Game Files/" + region + "/" + Game + "/unitbase.dat";
            string StatsFileName = @"Game Files/" + region + "/" + Game + "/unitstat.dat";
            string MoveFileName = @"Game Files/" + region + "/" + Game + "/command.dat";
            string MoveNameFileName = @"Game Files/" + region + "/" + Game + "/command.STR";

            byte NicknameStartPosJAP = 0x10;
            byte StringLength = 0x20;
            byte NickNameLength = 0x20;
            byte EXPOffset = 0x40;
            byte ScoutIDOffset = 0x42;
            byte ElementOffset = 0x5A;
            byte GenderOffset = 0x52;
            int commandDatBlockSize = 0x1C;
            int cmdStrOffset = 0x14;


            byte[] NameFile = FileIO.ReadFile(PlayerNamesFileName);
            byte[] StatsFile = FileIO.ReadFile(StatsFileName);

            if (Game == "IE3")
            {
                EXPOffset = 0x4C;
                ScoutIDOffset = 0x4E;
                StringLength = 0x1C;
                ElementOffset = 0x62;
                NickNameLength = 0x10;
                GenderOffset = 0x5A;
                NicknameStartPosJAP = 0x1C;
                commandDatBlockSize = 0x24;
                cmdStrOffset = 0x18;
            }

            StringBuilder sb = new StringBuilder();

            byte[] NameBlock = new byte[UnitBaseBlockLength];
            byte[] StatsBlock = new byte[UnitStatBlockLength];

            for (int i = UnitBaseBlockLength; i <= UnitBaseEndOffset; i += UnitBaseBlockLength)
            {
                NameBlock = NameFile.Skip(i).Take(UnitBaseBlockLength).ToArray();
                ushort scoutID = BitConverter.ToUInt16(NameBlock.Skip(0x4E).Take(2).ToArray(), 0);
                StatsBlock = StatsFile.Skip((i / UnitBaseBlockLength) * UnitStatBlockLength).Take(UnitStatBlockLength).ToArray();

                if (Game == "IE3")
                {
                    Cryptography.Decrypt(ref StatsBlock);
                }

                string FullPlayerName = "";
                string PlayerNickName = "";
                switch (region)
                {
                    case "EUR":
                        {
                            FullPlayerName = TextDecoder.Decode(NameBlock.Skip(0).Take(0x1C).ToArray(), false);
                            PlayerNickName = TextDecoder.Decode(NameBlock.Skip(StringLength).Take(NickNameLength).ToArray(), false);
                            break;
                        }
                    case "JAP":
                        {
                            FullPlayerName = TextDecoder.Decode(NameBlock.Skip(0).Take(0x10).ToArray(), true);
                            PlayerNickName = TextDecoder.Decode(NameBlock.Skip(NicknameStartPosJAP).Take(0x10).ToArray(), true);
                            break;
                        }
                }

                ushort ScoutHexID = BitConverter.ToUInt16(NameBlock.Skip(ScoutIDOffset).Take(2).ToArray(), 0);
                byte EXPType = NameBlock[EXPOffset];
                byte Gender = NameBlock[GenderOffset];
                byte Position = NameBlock.Skip(GenderOffset).Take(4).ToArray()[3];
                byte PlayerSize = NameBlock.Skip(GenderOffset).Take(4).ToArray()[2];
                byte Element = NameBlock[ElementOffset];

                ushort MinFP = BitConverter.ToUInt16(StatsBlock.Skip(0).Take(2).ToArray(), 0);
                ushort MaxFP = BitConverter.ToUInt16(StatsBlock.Skip(2).Take(2).ToArray(), 0);
                byte FPgrowthRate = StatsBlock[0x4];

                ushort MinTP = BitConverter.ToUInt16(StatsBlock.Skip(0x8).Take(2).ToArray(), 0);
                ushort MaxTP = BitConverter.ToUInt16(StatsBlock.Skip(0xA).Take(2).ToArray(), 0);
                byte TPgrowthRate = StatsBlock[0xC];

                ushort MinKick = StatsBlock[0x10];
                ushort MaxKick = StatsBlock[0x11];
                ushort MinBody = StatsBlock[0x14];
                ushort MaxBody = StatsBlock[0x15];
                ushort MinGuard = StatsBlock[0x18];
                ushort MaxGuard = StatsBlock[0x19];
                ushort MinControl = StatsBlock[0x1C];
                ushort MaxControl = StatsBlock[0x1D];
                ushort MinSpeed = StatsBlock[0x20];
                ushort MaxSpeed = StatsBlock[0x21];
                ushort MinGuts = StatsBlock[0x24];
                ushort MaxGuts = StatsBlock[0x25];
                ushort MinStamina = StatsBlock[0x28];
                ushort MaxStamina = StatsBlock[0x29];

                byte[] growthRate = new byte[7];
                for (int K = 0; K < 7; K++)
                {
                    growthRate[K] = StatsBlock[0x12 + (K * 4)];
                }

                ushort[] Move = new ushort[4];
                ushort[] MoveObtainLevel = new ushort[4];

                string[] movenames = new string[4];

                ushort Maxtotal;

                if (Game == "IE" && region == "JAP")
                {
                    for(int j = 0; j < 4; j++)
                    {
                        Move[j] = StatsBlock[0x2C + (j * 2)];
                        MoveObtainLevel[j] = StatsBlock[0x2D + (j * 2)];
                        movenames[j] = D.MoveToStr[Move[j]];
                    }
                    Maxtotal = BitConverter.ToUInt16(StatsBlock.Skip(0x34).Take(2).ToArray(), 0);
                }
                else
                {
                    byte[] cmd_dat = FileIO.ReadFile(MoveFileName);
                    byte[] cmd_STR = FileIO.ReadFile(MoveNameFileName);
                    for (int j = 0; j < 4; j++)
                    {
                        Move[j] = BitConverter.ToUInt16(StatsBlock.Skip(0x2C + (j * 4)).Take(2).ToArray(), 0);
                        MoveObtainLevel[j] = StatsBlock[0x2E + (j * 4)]; // might be a 2 byte value too but since it can't be higher than 100 anyway, i'll leave it 1 byte
                        ushort cmdstrNameIdx = BitConverter.ToUInt16(cmd_dat.Skip((Move[j] * commandDatBlockSize) + cmdStrOffset).Take(2).ToArray(), 0);
                        movenames[j] = TextDecoder.Decode(cmd_STR.Skip(cmdstrNameIdx * 0x20).Take(0x20).ToArray(), false);
                    }
                    Array.Sort(MoveObtainLevel, movenames);
                    Maxtotal = BitConverter.ToUInt16(StatsBlock.Skip(0x3C).Take(2).ToArray(), 0);
                }

                ushort StatsTotal = (ushort)(MaxKick + MaxBody + MaxGuard + MaxControl + MaxSpeed + MaxGuts + MaxStamina);
                short Freedom = (short)(Maxtotal - StatsTotal); // has to be signed since in IE3 it can be negative               

#if DEBUG
                string consoleOutput = String.Concat("private static Player ", FullPlayerName.Replace(" ", "_").Replace("\'", "_").Replace(".", "_").Replace("-", "_").Replace("’", "_").Replace("?", "_"), " = new Player(" +
                MaxFP, ", ", MaxTP, ", ", (byte)MaxKick, ", ", (byte)MaxBody, ", ", (byte)MaxControl, ", ", (byte)MaxGuard, ", ", (byte)MaxSpeed, ", ", (byte)MaxStamina, ", ", (byte)MaxGuts, ", ", StatsTotal, ", "
                , MinFP, ", ", MinTP, ", ", (byte)MinKick, ", ", (byte)MinBody, ", ", (byte)MinControl, ", ", (byte)MinGuard, ", ", (byte)MinSpeed, ", ", (byte)MinStamina, ", ", (byte)MinGuts, ", "
                , FPgrowthRate, ", ", TPgrowthRate, ", ", growthRate[0], ", ", growthRate[1], ", ", growthRate[3], ", ", growthRate[2], ", ", growthRate[4], ", ", growthRate[6], ", ", growthRate[5], ", "
                , "0x", Move[0].ToString("X2"), ", 0x", Move[1].ToString("X2"), ", 0x", Move[2].ToString("X2"), ", 0x", Move[3].ToString("X2"), ", "
                , "0x", MoveObtainLevel[0].ToString("X2"), ", 0x", MoveObtainLevel[1].ToString("X2"), ", 0x", MoveObtainLevel[2].ToString("X2"), ", 0x", MoveObtainLevel[3].ToString("X2"), ", "
                , EXPType, "); // 0x", ScoutHexID.ToString("X2")); // Code for dumping structs
                sb.AppendLine(consoleOutput);
#else
                //Console.WriteLine("0x" + index.ToString("X2") + " 0x" + scoutID.ToString("X2") + " 0x" + (i / UnitBaseBlockLength).ToString("X2"));
                dataGridViewStats.Rows.Add(FullPlayerName, PlayerNickName,
                    D.PosByteToString(Position), D.GenderToString[Gender], D.SizeToString(PlayerSize), D.ElementToStr[Element], 
                    MaxFP, MaxTP, MaxKick, MaxBody, MaxControl, MaxGuard, MaxSpeed, MaxStamina, MaxGuts, Freedom, StatsTotal, Maxtotal,
                    movenames[0], D.MoveObtainLevel(MoveObtainLevel[0]),
                    movenames[1], D.MoveObtainLevel(MoveObtainLevel[1]),
                    movenames[2], D.MoveObtainLevel(MoveObtainLevel[2]),
                    movenames[3], D.MoveObtainLevel(MoveObtainLevel[3]),
                    "0x" +
                    ScoutHexID.ToString("X2")
                    );
#endif
            }
#if DEBUG
            Console.WriteLine(sb.ToString());
#endif
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

            string Abbr = "";
            int UnitBaseEnd = 0;
            int UnitStatsLengthBlock = 0;
            int UnitBaseLengthPerBlock = 0;

            switch (GameVersion)
            {
                case "Inazuma Eleven":
                    {
                        switch (Region)
                        {
                            case "EUR":
                                {
                                    Abbr = "IE";
                                    UnitBaseEnd = 0x305A0; // uses almost the same file as IE2 in the European release
                                    UnitStatsLengthBlock = 0x50;
                                    break;
                                }
                            case "JAP":
                                {
                                    Abbr = "IE";
                                    UnitBaseEnd = 0x1DA60;
                                    UnitStatsLengthBlock = 0x40;
                                    break;
                                }
                        }
                        UnitBaseLengthPerBlock = 0x60;
                        break;
                    }
                case "Inazuma Eleven 2":
                    {
                        UnitBaseEnd = 0x305A0;
                        Abbr = "IE2";
                        UnitBaseLengthPerBlock = 0x60;
                        UnitStatsLengthBlock = 0x50;
                        break;
                    }
                case "Inazuma Eleven 3":
                    {
                        Abbr = "IE3";
                        UnitBaseEnd = 0x3C678; // end is actually at 0x3C678 however these players are unobtainable EDIT: Team Ogre attacks only!
                        UnitBaseLengthPerBlock = 0x68;
                        UnitStatsLengthBlock = 0x48;
                        break;
                    }
            }

            if (isGameSelected && isRegionSpecified)
            {
                dataGridViewStats.Rows.Clear();
                AddValuesFromUnitbase(UnitBaseEnd, UnitBaseLengthPerBlock, UnitStatsLengthBlock, Abbr, Region);
            }
        }

    }
}

