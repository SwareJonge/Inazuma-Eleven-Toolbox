﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InazumaElevenStatsExtractor.Utils;
using INAZUMA11;

namespace InazumaElevenStatsExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddValuesFromUnitbase(int UnitBaseEndOffset, int UnitBaseBlockLength, int UnitStatBlockLength, string Game)
        {
            IDictionary<int, string> ElementToStr = new Dictionary<int, string>()
                {
                {0,"NPC"},
                     {1,"Air"},
                     {2,"Wood"},
                     {3,"Fire"},
                     {4,"Earth"}
                };

            IDictionary<int, string> GenderToString = new Dictionary<int, string>()
                {
                {0,"NPC"},
                     {1,"Male"},
                     {2,"Female"}
                };
            IDictionary<int, string> PosToString = new Dictionary<int, string>()
                {
                {0,"NPC"},
                     {0x60,"MF"},
                     {0x80,"FW"},
                     {100,"Garbage"},
                     {130,"Garbage"},
                     {0x40,"DF"},
                     {0x20,"GK"}
                };
            IDictionary<int, string> SizeToString = new Dictionary<int, string>()
                {
                {0,"Medium"},
                     {1,"Large"},
                     {2,"Small"}
                };

            IDictionary<int, string> MoveToStr = new Dictionary<int, string>()
                {
                    { 0x0, "None" },
                     // Skills
                     {0x33,"Keeper Plus"},
                     {0x34,"Speed Plus"},
                     {0x35,"Shoot Plus"},
                     {0x36,"Defence Plus"},
                     {0x37,"Offence Plus"},
                     {0x38,"Recovery"},
                     {0x39,"Trickery!"},
                     {0x3A,"Charm Up!"},
                     {0x3B,"Cool Up!"},
                     {0x3C,"Economy!"},
                     {0x3D,"Big Moves!"},
                     {0x3E,"Power Element"},
                     {0x3F,"Study"},
                     {0x40,"Slack off"},
                     {0x41,"Critical!"},
                     {0x42,"No Element"},
                     {0x43,"Lucky!"},
                     {0x44,"Jinx"},
                     {0x45,"Speed Force"},
                     {0x46,"Shot Force"},
                     {0x47,"Defence Force"},
                     {0x48,"Offence Force"},
                     {0x49,"Never Give Up"},
                     {0x4A,"Move It!"},
                     {0x4B,"Everyone Move It!"},
                     { 0x4C,"Comeback Kid" },
                     { 0x4D,"Put Your Back Into It!" },


                     //Dribble (IE1)
                     {0x65,"Clone Faker"},
                     {0x66,"Flurry Dash"},
                     {0x67,"Whirlwind Twister"},
                     {0x68,"Illusion Ball"},
                     {0x69,"Dash Accelerator"},
                     {0x6A,"Rolling Hell"},
                     {0x6B,"Heat Tackle"},
                     {0x6C,"Zigzag Spark"},
                     {0x6D,"Rodeo Clown"},
                     {0x6E,"Black Magic"},
                     {0x6F,"Super Armadillo"},
                     {0x70,"Poison Fog"},
                     {0x71,"Attack Scan"},
                     {0x72,"Bewildered"},
                     {0x73,"Boost Glider"},
                     {0x74,"Afterimage"},
                     {0x75,"Mole Fake"},
                     {0x76,"Whirlwind Cut"},
                     {0x77,"Monkey Turn"},
                     // Block (IE1)
                     {0x78,"The Wall"},
                     // IE3 ---------------------
                     { 0x79,"Diabolical Cut" },
                     // -------------------------
                     {0x7A,"Killer Slide"},
                     {0x7B,"Coil Turn"},
                     {0x7C,"Earthquake"},
                     {0x7D,"Quick Draw"},
                     {0x7E,"Spider Web"},
                     {0x7F,"Cyclone"},
                     {0x80,"Fake Ball"},
                     {0x81,"Shadow Stitch"},
                     {0x82,"Sumo Stomp"},
                     {0x83,"Horn Train"},
                     {0x84,"Hurricane Arrows"},
                     {0x85,"Spinning Cut"},
                     {0x86,"Defence Scan"},
                     {0x87,"Ghost Pull"},
                     {0x88,"Doppelganger"},
                     {0x89,"Bamboo Pattern"},
                     {0x8A,"Harvest"},
                     {0x8B,"Divine Stamp"},
                     //Shots (IE1)
                     {0x8C,"Inazuma Drop"},
                     {0x8D,"Dragon Crash"},
                     {0x8E,"Twin Boost"},
                     {0x8F,"Fire Tornado"},
                     {0x90,"Wrath Shot"},
                     {0x91,"Inazuma-1"},
                     {0x92,"Grenade Shot"},
                     {0x93,"Death Zone"},
                     {0x94,"Phantom Shot"},
                     {0x95,"Hawk Shot"},
                     {0x96,"Meteor Attack"},
                     {0x97,"Snake Shot"},
                     {0x98,"Spinning Shot"},
                     {0x99,"Comet Shot"},
                     {0x9A,"Rolling Kick"},
                     {0x9B,"Clone Shot"},
                     {0x9C,"Dynamite Shot"},
                     {0x9D,"Patriot Shot"},
                     {0x9E,"Spiral Shot"},
                     {0x9F,"Freeze Shot"},
                     { 0xA0,"Tiger Drive" },

                     //Keeper
                     {0xA1,"Tornado Catch"},
                     {0xA2,"God Hand(E)"},
                     {0xA3,"Power Shield"},
                     {0xA4,"Fireball Knuckle"},
                     {0xA5,"Shot Pocket"},
                     {0xA6,"Warp Space"},
                     {0xA7,"Counter Strike"},
                     {0xA8,"Sliding Goal"},
                     {0xA9,"Triple Defence"},
                     {0xAA,"Pressure Punch"},
                     {0xAB,"Toughness Block."},
                     {0xAC,"Full Power Shield"},
                     {0xAD,"Wood Chopper"},
                     {0xAE,"Whirlwind"},
                     {0xAF,"Rocket Kobushi"},
                     {0xB0,"Tsunami Wall"},
                     {0xB1,"Wild Claw"},
                     {0xB2,"Gigant Wall"},
                     {0xB3,"Mistral"},
                     {0xB4,"Tsunami Wall"},
                     {0xB5,"Blazing Knuckle"},
                     {0xB6,"Majin The Hand(E)"},
                     {0xB7,"Infinite Wall"},
                     //IE3 ----------------------------
                     { 0xB8,"Snow Angel" },
                     { 0xB9,"Barbarian Shield" },
                     
                     //    ----------------------------




                     {0xBA,"Majin The Hand(W)"},
                     {0xBB,"God Hand(W)"},
                     //IE3 ----------------------------
                     { 0xBC,"Ground Quake" },
                     { 0xBD,"Desert Blast" },
                     
                     //   ----------------------------

                     {0xBE,"Cross Drive"},
                     {0xBF,"Teleport Shot"},
                     {0xC0,"Psycho Shot"},
                     {0xC1,"Condor Dive"},
                     {0xC2,"Run Ball Run"},
                     {0xC3,"Triangle Z"},
                     {0xC4,"Utter Gutsiness Bat"},
                     {0xC5,"Reflect Buster"},
                     {0xC6,"Kung Fu Header"},
                     {0xC7,"Shine Drive"},
                     {0xC8,"Divine Arrows"},
                     {0xC9,"Back Tornado"},
                     {0xCA,"Tarzan Kick"},
                     {0xCB,"God Knows"},
                     {0xCC,"Dragon Tornado"},
                     {0xCD,"Dirt Ball"},
                     {0xCE,"Fire Rooster"},
                     {0xCF,"Inazuma Break"},
                     {0xD0,"The Galaxy(A)"},
                     {0xD1,"Emperor Penguin No. 2"},
                     // Why
                     {0xD2,"Heaven's Time"},
                     {0xD3,"Breakthrough"},
                     {0xD4,"Dash Storm"},
                     {0xD5,"Moonsault"},
                     {0xD6,"Magic"},
                     // Why is this format so stupid
                     {0xD7,"The Phoenix"},
                     {0xD8,"Baby Dragon"},
                     {0xD9,"Dark Tornado"},
                     {0xDA,"Inazuma Drop"},
                     {0xDB,"Inazuma Break(F)"},

                     // IE3
                     { 0xDC,"Am-Bush" },
{ 0xDD,"Gravestone" },
{ 0xDE,"Racing Flame" },
{ 0xDF,"Iron Wall" },
{ 0xE0,"Power Charge" },
{ 0xE1,"Vac Attack" },
{ 0xE2,"Yo-Yo Ball" },
{ 0xE3,"Rolling Slide" },

{ 0xE5,"Stone Prison" },
// -----------------------------------------------


                     // Block moves pt.2
                     {0xE6,"Mega Quake"},
                     {0xE7,"Blade Attack"},
                     {0xE8,"About Face"},

                     // IE3 
                     { 0xE9,"Excalibur" },
{ 0xEA,"Hellfire" },
{ 0xEB,"The Typhoon" },
{ 0xEC,"Whirlwind Drop" },
{ 0xED,"Thunder Beast" },
{ 0xEE,"Tiger Storm" },
{ 0xEF,"Dragon Slayer" },
{ 0xF0,"Gladius Arch" },
{ 0xF1,"Emperor Penguin No. 3" },
{ 0xF2,"Grand Fenrir" },
{ 0xF3,"Odin Sword" },
{ 0xF4,"Heavenly Drive" },
{ 0xF5,"Samba Strike" },
{ 0xF6,"The Dawn" },

{ 0xF7,"Big Bang" },
{ 0xF8,"The Hurricane" },
{ 0xF9,"Megalodon" },
{ 0xFA,"Paladin Strike" },
{ 0xFD,"Gunshot" },
{ 0xFE,"Fireball Screw" },
{ 0xFF,"Mirage Shot" },
{ 0x100,"Pegasus Shot" },
{ 0x101,"Unicorn Boost" },
{ 0x102,"Jet Stream" },
{ 0x103,"Grand Fire" },
{ 0x104,"Brave Shot" },



                     // Let's move over to IE2
                     // Shots
                     { 0x105,"Eternal Blizzard" },
{ 0x106, "Fireball Storm"},
{ 0x107, "Tsunami Boost"},
{ 0x108, "Death Zone 2"},
{ 0x109, "The Earth"},
{ 0x10A, "Rainbow Arc"},
{ 0x10B, "Astro Break"},
{ 0x10C, "Acrobat Bomber"},
{ 0x10D, "Kung Fu Fighting"},
{ 0x10E, "Double Grenade"},
{ 0x10F, "Gyro Head"},
{ 0x110, "Revolution V"},
{ 0x111, "Heel Kick"},
{ 0x112, "Dragon Cannon"},
{ 0x113, "Dual Strike"},
{ 0x114, "Legendary Wolf"},
{ 0x115, "Emperor Penguin No.1"},
{ 0x116, "Bed Of Roses"},
{ 0x117, "Utter Gutsiness Club"},
{ 0x118, "Double Wrath Shot"},
{ 0x119, "Land Dragon"},
{ 0x11A, "Tri-Pegasus"},
{ 0x11B, "Inazuma-1 Drop"},
{ 0x11C, "Ganymede Ray"},
{ 0x11D, "Leaping Thunder"},
{ 0x11E, "Eagle Buster"},
{ 0x11F, "Butterfly Trance"},
{ 0x120, "Cosmic Blast"},
{ 0x121, "Gaia Break"},
{ 0x122, "Spectacle Crash"},
{ 0x123, "Twin Boost F"},
{ 0x124, "Double Tornado"},
{ 0x125, "Security Shot"},
{ 0x126, "Supernova"},
{ 0x127, "Space Penguin"},
{ 0x128, "Wyvern Crash"},
{ 0x129, "Wyvern Blizzard"},
{ 0x12A, "Cross Fire"},
{ 0x12B, "Dark Phoenix"},
{ 0x12C, "Triple Boost"},
{ 0x12D, "Neo Galaxy"},
{ 0x12E, "Assault Shot"},
{ 0x12F, "God Break"},
{ 0x130, "Megaton Head"},
{ 0x131, "Steeple Shot"},
{ 0x132, "Meteor Blade"},
{ 0x133, "Gungnir"},
{ 0x134, "Atomic Flare"},
{ 0x135, "Northern Impact"},
{ 0x136, "Fire Blizzard(F)"},
{ 0x137, "Cross Fire"},
{ 0x138, "Fire Blizzard(A)"},
{ 0x139, "Meteor Blade"}, // unused one
//IE3
{ 0x13A,"Chaos Break" },
{ 0x13B,"Astro Gate" },
{ 0x13C,"Double Jaw" },
{ 0x13D,"Eiffel Tower" }, // Unused
{ 0x13E,"Slingshot" },
{ 0x13F,"Sweet Deal" },
{ 0x140,"Emperor Penguin X" },

//Dribble
{ 0x141, "Deceptor Dribble"},
{ 0x142, "Invisible Fake"},
{ 0x143, "Gale Dash"},
{ 0x144, "Three-Legged Rush"},
{ 0x145, "Aurora Dribble"},
{ 0x146, "Double Touch"},
{ 0x147, "Dual Pass"},
{ 0x148, "Bubble Gum"},
{ 0x149, "Prima Donna"},
{ 0x14A, "Armadillo Circus"},
{ 0x14B, "Breakthrough 2"},
{ 0x14C, "Triple Dash"},
{ 0x14D, "Lightning Sprint"},
{ 0x14E, "Aikido"},
{ 0x14F, "Mole Shuffle"},
{ 0x150, "Dark Whirlwind"},
{ 0x151, "Warp Drive"},
{ 0x152, "Meteor Shower"},
{ 0x153, "Southern Cross"},
{ 0x154, "Ribbon Shower"},
{ 0x155, "Big Fan"},
{ 0x156, "Flame Veil"},
{ 0x157, "Water Veil"},
// IE3
{ 0x158,"Field of Force" },
{ 0x159,"Kangaroo Kick" },
{ 0x15A,"Abaddon Drop" },
{ 0x15B,"Bewilder Blast" },
{ 0x15C,"The Ikaros" },
{ 0x15D,"Nightmare Trap" },
{ 0x15E,"Wind God's Dance" },
{ 0x15F,"Card Slap" },
{ 0x160,"Matador Feint" },
{ 0x161,"Super Elastico" },
{ 0x162,"Echo Ball" },
{ 0x163,"Liar Shot" },
{ 0x164,"Air Ride" },
{ 0x165,"Breakthrough 3" },
{ 0x166,"Dog Run" },
{ 0x167,"Sub-Terfuge" },
{ 0x168,"Ultra Moon" },
//Block
{ 0x169, "Shooting Star"},
{ 0x16A, "Land Of Ice"},
{ 0x16B, "Clone Defence"},
{ 0x16C, "Circus Block"},
{ 0x16D, "Heavy Mettle"},
{ 0x16E, "The Tower"},
{ 0x16F, "Photon Crash"},
{ 0x170, "Gravitation"},
{ 0x171, "Dual Storm"},
{ 0x172, "Supreme Spin"},
{ 0x173, "Fake Bomber"},
{ 0x174, "Volcano Cut"},
{ 0x175, "Super Sumo Stomp"},
{ 0x176, "Planet Shield"},
{ 0x177, "Sigma Zone"},
{ 0x178, "Double Cyclone"},
{ 0x179, "No Escape"},
{ 0x17A, "Flame Dance"},
{ 0x17B, "Asteroid Belt"},
{ 0x17C, "Body Shield"},
{ 0x17D, "Perimeter Zone"},
{ 0x17E, "Mega Wall"},
{ 0x17F, "Road Roller"},
{ 0x180, "Sleeping Dust"},
{ 0x181, "Ignite Steal"},
{ 0x182, "Whale Guard"},
{ 0x183, "Whirlwind Force"},
{ 0x184, "Mad Express"},
{ 0x185, "Frozen Steal"},
{ 0x186, "Stone Wall"},
{ 0x187, "Perfect Tower"},
// IE3
{ 0x188,"The Mountain" },
{ 0x189,"Zigzag Flame" },
{ 0x18A,"Heaven's Ascent" },
{ 0x18B,"Hell's Descent" },

//Catch
{ 0x191, "Mugen The Hand"},
{ 0x192, "Utter Gutsiness Catch"},
{ 0x193, "Fireball Head"},
{ 0x194, "Aurora Curtain"},
{ 0x195, "Table-Turner"},
{ 0x196, "Flame Breath"},
{ 0x197, "Beast Fang"},
{ 0x198, "Drill Smasher"},
{ 0x199, "Clone Block"},
// IE 3 fills up some unused IDs from IE2
{ 0x19A,"Dimensional Hand" },
{ 0x19B, "Claw Slash"},
{ 0x19C, "Dual Smash"},
{ 0x19D, "Double Rocket"},
{ 0x19E, "Flower Power"},
{ 0x19F, "Swan Dive"},
{ 0x1A0, "Triple God Hand"},
{ 0x1A1, "Black Hole"},
{ 0x1A2, "Safety First"},
{ 0x1A3, "Wormhole"},
{ 0x1A4, "Temporal Wall"},
{ 0x1A5, "Procyon Net"},
{ 0x1A6, "Fist Of Justice"},
{ 0x1A7, "Burnout"},
{ 0x1A8, "Ice Block"},
// IE3
{ 0x1A9,"Hammer of Fury" },
{ 0x1AA,"Soul Hand" },
{ 0x1AB,"God Hand X" },
{ 0x1AC,"Fiend Hand" },
{ 0x1AD,"God Catch" },
{ 0x1AE,"Storm Rider" },
{ 0x1AF,"Flash Upper" },
{ 0x1B0,"Nitro Slap" },
{ 0x1B1,"Barrier Reef" },
{ 0x1B2,"Giant Spider" },
{ 0x1B3,"Galatyn" },
{ 0x1B4,"Colosseum Guard" },
{ 0x1B5,"Million Hands" },
{ 0x1B6,"Capoeira Grab" },
{ 0x1B7,"The Stinger" },
{ 0x1B8,"Shot Trap" },
{ 0x1B9,"Card Protector" },
{ 0x1BA,"High Voltage" },
{ 0x1BB,"Omega Hand" },
{ 0x1BC,"Electrap" },
{ 0x1BD,"Celestial Zone" },
{ 0x1BE,"The End" },
{ 0x1BF,"Needle Hammer" },
{ 0x1C3,"Remote Combustion" },
{ 0x1C4,"X-Blast" },
{ 0x1C5,"Almighty Cannon" },
{ 0x1C6,"Dark Matter" },
{ 0x1C7,"Shadow Ray" },
{ 0x1C8,"Maximum Fire" },
{ 0x1C9,"Prime Legend" },
{ 0x1CA,"Doom Rain" },
{ 0x1CB,"Doom Spear" },
{ 0x1CC,"Doom Break" },
{ 0x1CD,"Shadow Ray" },
{ 0x1CE,"Celestial Smash" },
{ 0x1CF,"Clone Death Zone" },
{ 0x1D0,"Clone Penguin" },
{ 0x1D7,"Angel Ball" },
{ 0x1D8,"Devil Ball" }
                };

            ushort calcLevelDone(ushort GrowthRate)
            {
                if (GrowthRate == 1)
                {
                    GrowthRate = 3;
                }
                if (GrowthRate == 3)
                {
                    GrowthRate = 1;
                }
                return (ushort)(49 + (GrowthRate * 10));
            }

            dataGridView1.Rows.Clear();
            //int Teams = 0x26C0 / 0x140;
            int Players = (UnitBaseEndOffset / UnitBaseBlockLength) + 1;
            ImporterClass.Player[] Player = new ImporterClass.Player[Players];

            //string TeamNamesFile = @"Include\team.pkb";
            string PlayerNamesFile = @"Include/" + Game + "/unitbase.dat";
            string StatsFile = @"Include/" + Game + "/unitstat.dat";
            //for (int i = 0; i <= 0x26C0; i += 0x140)
            //{
            for (int J = UnitBaseBlockLength; J <= UnitBaseEndOffset; J += UnitBaseBlockLength)
            {
                int k = 0;
                if (J > 0)
                {
                    k = J / UnitBaseBlockLength;
                }
                else
                {
                    k = 0;
                }
                int K = k * UnitStatBlockLength;
                byte[] StatsBlock = File.ReadAllBytes(StatsFile).Skip(K).Take(UnitStatBlockLength).ToArray();
                byte StringLength = 0x20;
                byte NickNameLength = 0x20;
                byte ScoutIDOffset = 0x44;
                byte ElementOffset = 0x5A;
                byte GenderOffset = 0x52;
                if (Game == "IE3")
                {
                    Encryption.Decrypt(ref StatsBlock);
                    StringLength = 0x1C;
                    ScoutIDOffset = 0x50;
                    ElementOffset = 0x62;
                    NickNameLength = 0x10;
                    GenderOffset = 0x5A;
                }             

                string FullPlayerName = Encoding.Default.GetString(File.ReadAllBytes(PlayerNamesFile).Skip(J).Take(StringLength).ToArray());
                FullPlayerName = FullPlayerName.Replace("\0", "");
                string PlayerNickName = Encoding.Default.GetString(File.ReadAllBytes(PlayerNamesFile).Skip(J + StringLength).Take(NickNameLength).ToArray());
                PlayerNickName = PlayerNickName.Replace("\0", "");
                ushort ScoutHexID = (ushort)(BitConverter.ToUInt16(new byte[2] { File.ReadAllBytes(PlayerNamesFile).Skip(J + ScoutIDOffset).Take(2).ToArray()[0], File.ReadAllBytes(PlayerNamesFile).Skip(J + ScoutIDOffset).Take(0x2).ToArray()[1] }, 0));
                byte Gender = File.ReadAllBytes(PlayerNamesFile).Skip(J + GenderOffset).Take(4).ToArray()[0];
                byte Position = File.ReadAllBytes(PlayerNamesFile).Skip(J + GenderOffset).Take(4).ToArray()[3];
                byte PlayerSize = File.ReadAllBytes(PlayerNamesFile).Skip(J + GenderOffset).Take(4).ToArray()[2]; ;
                /*                   StatsBlock Layout
                 *           Length: 0x50 in IE & IE2, 0x48 in IE3
                 *            IE3 doesn't have the garbage values
                 * (short[3]) TP: 0x0 - MinTP, 0x2 - MaxTP, 0x4 - TPGrowthRate
                 * short 0x6 - unk
                 * (short[3]) FP: 0x8 - MinFP, 0xA - MaxFP, 0xC - FPGrowthRate
                 * short 0xE - unk
                 * (byte[2]) Kick: 0x10 - Min, 0x11 - Max, short 0x12 - GrowthRate
                 * (byte[2]) Body: 0x14 - Min, 0x15 - Max, short 0x16 - GrowthRate
                 * (byte[2]) Guard: 0x18 - Min, 0x19 - Max, short 0x1A - GrowthRate
                 * (byte[2]) Control: 0x1C - Min, 0x1D - Max, short 0x1E - GrowthRate
                 * (byte[2]) Speed: 0x20 - Min, 0x21 - Max, short 0x22 - GrowthRate
                 * (byte[2]) Guts: 0x24 - Min, 0x25 - Max, short 0x26 - GrowthRate
                 * (byte[2]) Stamina: 0x28 - Min, 0x29 - Max, short 0x2A - GrowthRate
                 * (short[8]) Moves: 0x2C - MoveID_Slot1, 0x2E UnlockLevel, 0x30 - MoveID_Slot2, 0x32 UnlockLevel,
                 * 0x34 MoveID_Slot3, 0x36 UnlockLevel, 0x38 MoveID_Slot4, 0x3A UnlockLevel
                 * (short[5]) 0x3C - Max totaal, unk, unk, unk, unk
                 * Garbage data most likely
                 */

                // FP
                Player[k].PlayerStatsStruct.MinFP = BitConverter.ToUInt16(new byte[2] { StatsBlock[0], StatsBlock[1] }, 0);
                Player[k].PlayerStatsStruct.MaxFP = BitConverter.ToUInt16(new byte[2] { StatsBlock[2], StatsBlock[3] }, 0);
                Player[k].PlayerStatsStruct.FPGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[4], StatsBlock[5] }, 0);
                ushort FPMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.FPGrowthRate);
                float FPPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxFP - Player[k].PlayerStatsStruct.MinFP) / (float)(FPMaxOpLevel - 1));
                // TP
                Player[k].PlayerStatsStruct.MinTP = BitConverter.ToUInt16(new byte[2] { StatsBlock[8], StatsBlock[9] }, 0);
                Player[k].PlayerStatsStruct.MaxTP = BitConverter.ToUInt16(new byte[2] { StatsBlock[0xA], StatsBlock[0xB] }, 0);
                Player[k].PlayerStatsStruct.TPGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0xC], StatsBlock[0xD] }, 0);
                ushort TPMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.TPGrowthRate);
                float TPPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxTP - Player[k].PlayerStatsStruct.MinTP) / (float)(TPMaxOpLevel - 1));
                // Kick
                Player[k].PlayerStatsStruct.MinKick = StatsBlock[0x10];
                Player[k].PlayerStatsStruct.MaxKick = StatsBlock[0x11];
                Player[k].PlayerStatsStruct.KickGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x12], StatsBlock[0x13] }, 0);
                ushort KickMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.KickGrowthRate);
                float KickPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxKick - Player[k].PlayerStatsStruct.MinKick) / (float)(KickMaxOpLevel - 1));
                // Body
                Player[k].PlayerStatsStruct.MinBody = StatsBlock[0x14];
                Player[k].PlayerStatsStruct.MaxBody = StatsBlock[0x15];
                Player[k].PlayerStatsStruct.BodyGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x16], StatsBlock[0x17] }, 0);
                ushort BodyMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.BodyGrowthRate);
                float BodyPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxBody - Player[k].PlayerStatsStruct.MinBody) / (float)(BodyMaxOpLevel - 1));
                // Guard
                Player[k].PlayerStatsStruct.MinGuard = StatsBlock[0x18];
                Player[k].PlayerStatsStruct.MaxGuard = StatsBlock[0x19];
                Player[k].PlayerStatsStruct.GuardGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x1A], StatsBlock[0x1B] }, 0);
                ushort GuardMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.GuardGrowthRate);
                float GuardPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxGuard - Player[k].PlayerStatsStruct.MinGuard) / (float)(GuardMaxOpLevel - 1));
                // Control
                Player[k].PlayerStatsStruct.MinControl = StatsBlock[0x1C];
                Player[k].PlayerStatsStruct.MaxControl = StatsBlock[0x1D];
                Player[k].PlayerStatsStruct.ControlGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x1E], StatsBlock[0x1F] }, 0);
                ushort ControlMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.ControlGrowthRate);
                float ControlPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxControl - Player[k].PlayerStatsStruct.MinControl) / (float)(ControlMaxOpLevel - 1));
                // Speed
                Player[k].PlayerStatsStruct.MinSpeed = StatsBlock[0x20];
                Player[k].PlayerStatsStruct.MaxSpeed = StatsBlock[0x21];
                Player[k].PlayerStatsStruct.SpeedGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x22], StatsBlock[0x23] }, 0);
                ushort SpeedMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.SpeedGrowthRate);
                float SpeedPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxSpeed - Player[k].PlayerStatsStruct.MinSpeed) / (float)(SpeedMaxOpLevel - 1));
                // Guts
                Player[k].PlayerStatsStruct.MinGuts = StatsBlock[0x24];
                Player[k].PlayerStatsStruct.MaxGuts = StatsBlock[0x25];
                Player[k].PlayerStatsStruct.GutsGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x26], StatsBlock[0x27] }, 0);
                ushort GutsMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.GutsGrowthRate);
                float GutsPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxGuts - Player[k].PlayerStatsStruct.MinGuts) / (float)(GutsMaxOpLevel - 1));
                // Stamina
                Player[k].PlayerStatsStruct.MinStamina = StatsBlock[0x28];
                Player[k].PlayerStatsStruct.MaxStamina = StatsBlock[0x29];
                Player[k].PlayerStatsStruct.StaminaGrowthRate = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x2A], StatsBlock[0x2B] }, 0);
                ushort StaminaMaxOpLevel = calcLevelDone(Player[k].PlayerStatsStruct.StaminaGrowthRate);
                float StaminaPerLevel = Math.Abs((float)(Player[k].PlayerStatsStruct.MaxStamina - Player[k].PlayerStatsStruct.MinStamina) / (float)(StaminaMaxOpLevel - 1));

                //Max Stats
                Player[k].PlayerStatsStruct.Maxtotal = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x3C], StatsBlock[0x3D] }, 0);

                // Moves
                string MoveObtainLevel(ushort ObtainLevel)
                {
                    if (ObtainLevel == 100)
                    {
                        return "Event";
                    }
                    else return "Lv." + ObtainLevel.ToString();
                }

                Player[k].PlayerStatsStruct.MovesStruct.Move1 = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x2C], StatsBlock[0x2D] }, 0);
                Player[k].PlayerStatsStruct.MovesStruct.Move1ObtainLevel = StatsBlock[0x2E];
                Player[k].PlayerStatsStruct.MovesStruct.Move2 = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x30], StatsBlock[0x31] }, 0);
                Player[k].PlayerStatsStruct.MovesStruct.Move2ObtainLevel = StatsBlock[0x32];
                Player[k].PlayerStatsStruct.MovesStruct.Move3 = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x34], StatsBlock[0x35] }, 0);
                Player[k].PlayerStatsStruct.MovesStruct.Move3btainLevel = StatsBlock[0x36];
                Player[k].PlayerStatsStruct.MovesStruct.Move4 = BitConverter.ToUInt16(new byte[2] { StatsBlock[0x38], StatsBlock[0x39] }, 0);
                Player[k].PlayerStatsStruct.MovesStruct.Move4ObtainLevel =StatsBlock[0x3A];

                //int j = 0;
                /*if (i > 0)
                {
                    j = i / 0x140 - 1;
                }
                else
                {
                    j = 0;
                }*/


                //Team[j].TeamName = Encoding.Default.GetString(File.ReadAllBytes(TeamNamesFile).Skip(i).Take(0x20).ToArray());

                Player[k].FullName = FullPlayerName;
                Player[k].NickName = PlayerNickName;
                Player[k].HEXid = ScoutHexID;
                Player[k].Element = File.ReadAllBytes(PlayerNamesFile).Skip(J + ElementOffset).Take(1).ToArray()[0];

                //dataGridView1.Columns[6].DefaultCellStyle.Format = "N3";
                dataGridView1.Rows.Add(Player[k].FullName, Player[k].NickName, ElementToStr[Player[k].Element],
                    GenderToString[Gender], SizeToString[PlayerSize],

                    Player[k].PlayerStatsStruct.MaxFP, "Lv." + FPMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxTP, "Lv." + TPMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxKick, "Lv." + KickMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxBody, "Lv." + BodyMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxControl, "Lv." + ControlMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxGuard, "Lv." + GuardMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxSpeed, "Lv." + SpeedMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxStamina, "Lv." + StaminaMaxOpLevel,
                    Player[k].PlayerStatsStruct.MaxGuts, "Lv." + GutsMaxOpLevel,
                    Player[k].PlayerStatsStruct.Freedom(),  Player[k].PlayerStatsStruct.StatsTotal(), Player[k].PlayerStatsStruct.Maxtotal,

                    Player[k].PlayerStatsStruct.MinFP, Player[k].PlayerStatsStruct.MinTP, Player[k].PlayerStatsStruct.MinKick,
                    Player[k].PlayerStatsStruct.MinBody, Player[k].PlayerStatsStruct.MinControl, Player[k].PlayerStatsStruct.MinGuard,
                    Player[k].PlayerStatsStruct.MinSpeed, Player[k].PlayerStatsStruct.MinStamina, Player[k].PlayerStatsStruct.MinGuts,

                    FPPerLevel, TPPerLevel, KickPerLevel, BodyPerLevel, ControlPerLevel, GuardPerLevel, SpeedPerLevel, StaminaPerLevel, GutsPerLevel,
                    MoveToStr[Player[k].PlayerStatsStruct.MovesStruct.Move1], MoveObtainLevel(Player[k].PlayerStatsStruct.MovesStruct.Move1ObtainLevel),
                    MoveToStr[Player[k].PlayerStatsStruct.MovesStruct.Move2], MoveObtainLevel(Player[k].PlayerStatsStruct.MovesStruct.Move2ObtainLevel),
                    MoveToStr[Player[k].PlayerStatsStruct.MovesStruct.Move3], MoveObtainLevel(Player[k].PlayerStatsStruct.MovesStruct.Move3btainLevel),
                    MoveToStr[Player[k].PlayerStatsStruct.MovesStruct.Move4], MoveObtainLevel(Player[k].PlayerStatsStruct.MovesStruct.Move4ObtainLevel),
                    "0x" + Player[k].HEXid.ToString("X2"));

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GameVersion = comboBox1.GetItemText(comboBox1.SelectedItem);
            string Region = comboBox2.GetItemText(comboBox2.SelectedItem);
            bool isGameSelected = true;
            if (GameVersion != "Inazuma Eleven" && GameVersion != "Inazuma Eleven 2" && GameVersion != "Inazuma Eleven 3")
            {
                MessageBox.Show("A game must be selected first! " + GameVersion);
                isGameSelected = false;
            }

            bool isRegionSpecified = true;
            if (Region != "EUR" && Region != "JAP")
            {
                MessageBox.Show("A region must be specified! " + Region);
                isRegionSpecified = false;
            }


            string Abbr = "";
            int UnitBaseEnd = 0;
            int UnitStatsLengthBlock = 0;
            int UnitBaseLengthPerBlock = 0;
            if (GameVersion == "Inazuma Eleven 3" && Region == "EUR")
            {
                UnitBaseEnd = 0x3BFF8;
                Abbr = "IE3";
                UnitBaseLengthPerBlock = 0x68;
                UnitStatsLengthBlock = 0x48;
            }
            else if (GameVersion == "Inazuma Eleven 2" && Region == "EUR")
            {
                UnitBaseEnd = 0x30540;
                Abbr = "IE2";
                UnitBaseLengthPerBlock = 0x60;
                UnitStatsLengthBlock = 0x50;
            }
            else if (GameVersion == "Inazuma Eleven" && Region == "EUR")
            {
                UnitBaseEnd = 0x30540; // uses almost the same file
                Abbr = "IE";
                UnitBaseLengthPerBlock = 0x60;
                UnitStatsLengthBlock = 0x50;
            }
            else
            {
                MessageBox.Show("There is no support for this game (yet)!");
                isGameSelected = false;
            }
            if(isGameSelected && isRegionSpecified)
            {
                AddValuesFromUnitbase(UnitBaseEnd, UnitBaseLengthPerBlock, UnitStatsLengthBlock, Abbr);
            }
        }
    }
}