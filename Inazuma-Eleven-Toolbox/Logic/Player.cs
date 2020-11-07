using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Logic
{
    public struct Player
    {        
        public Player(ushort fp, ushort tp, byte kick, byte body, byte control, byte guard, byte speed, byte stamina, byte guts, ushort maxtotal,
            byte minfp, byte mintp, byte minkick, byte minbody, byte mincontrol, byte minguard, byte minspeed, byte minstamina, byte minguts,
            byte fpgrowthrate, byte tpgrowthrate, byte kickgrowthrate, byte bodygrowthrate, byte controlgrowthrate, byte guardgrowthrate, byte speedgrowthrate, byte staminagrowthrate, byte gutsgrowthrate,
            byte exptype)
        {
            FP = fp;
            TP = tp;
            Kick = kick;
            Body = body;
            Control = control;
            Guard = guard;
            Speed = speed;
            Stamina = stamina;
            Guts = guts;
            MaxTotal = maxtotal;

            minFP = minfp;
            minTP = mintp;
            minKick = minkick;
            minBody = minbody;
            minControl = mincontrol;
            minGuard = minguard;
            minSpeed = minspeed;
            minStamina = minstamina;
            minGuts = minguts;

            FPGrowthRate = fpgrowthrate;
            TPGrowthRate = tpgrowthrate;
            KickGrowthRate = kickgrowthrate;
            BodyGrowthRate = bodygrowthrate;
            ControlGrowthRate = controlgrowthrate;
            GuardGrowthRate = guardgrowthrate;
            SpeedGrowthRate = speedgrowthrate;
            StaminaGrowthRate = staminagrowthrate;
            GutsGrowthRate = gutsgrowthrate;

            EXPType = exptype;
            Freedom = (short)(maxtotal - (Kick + Body + Guard + Control + Speed + Guts + Stamina));
        }

        public ushort FP { get; }
        public ushort TP { get; }        

        public byte Kick { get; }
        public byte Body { get; }
        public byte Control { get; }
        public byte Guard { get; }
        public byte Speed { get; }
        public byte Stamina { get; }
        public byte Guts { get; }

        public ushort minFP { get; }
        public ushort minTP { get; }

        public byte minKick { get; }
        public byte minBody { get; }
        public byte minControl { get; }
        public byte minGuard { get; }
        public byte minSpeed { get; }
        public byte minStamina { get; }
        public byte minGuts { get; }

        public byte FPGrowthRate { get; }
        public byte TPGrowthRate { get; }

        public byte KickGrowthRate { get; }
        public byte BodyGrowthRate { get; }
        public byte ControlGrowthRate { get; }
        public byte GuardGrowthRate { get; }
        public byte SpeedGrowthRate { get; }
        public byte StaminaGrowthRate { get; }
        public byte GutsGrowthRate { get; }

        public ushort MaxTotal { get; }
        public short Freedom { get; }        

        public byte EXPType { get; }
    }

    public static class PlayerClass
    {
        public class IE2
        {

            private static Player Mark_Evans = new Player(191, 184, 72, 72, 70, 77, 68, 69, 79, 507, 37, 41, 13, 16, 15, 17, 8, 16, 20, 5, 1, 5, 2, 5, 2, 5, 5, 5, 6); // 0x01
            private static Player Nathan_Swift = new Player(169, 156, 64, 58, 68, 54, 76, 58, 56, 434, 64, 74, 13, 12, 12, 11, 18, 12, 11, 4, 4, 4, 4, 4, 4, 2, 4, 4, 2); // 0x02
            private static Player Jack_Wallside = new Player(206, 165, 62, 68, 62, 66, 49, 54, 54, 415, 39, 63, 8, 11, 8, 16, 9, 11, 11, 4, 1, 2, 1, 1, 2, 4, 2, 4, 3); // 0x03
            private static Player Jim_Wraith = new Player(195, 140, 58, 53, 75, 59, 53, 62, 60, 420, 43, 33, 7, 14, 11, 11, 12, 13, 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x04
            private static Player Tod_Ironside = new Player(184, 161, 54, 55, 53, 56, 59, 56, 65, 398, 39, 33, 8, 8, 9, 7, 7, 14, 9, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x05
            private static Player Steve_Grim = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x06
            private static Player Tim_Saunders = new Player(156, 149, 63, 76, 61, 60, 55, 48, 58, 421, 46, 55, 11, 8, 14, 9, 12, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x07
            private static Player Sam_Kincaid = new Player(167, 136, 71, 57, 56, 56, 52, 56, 76, 424, 50, 41, 9, 11, 6, 11, 10, 9, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x08
            private static Player Maxwell_Carson = new Player(156, 160, 60, 56, 78, 64, 60, 56, 62, 436, 51, 63, 11, 12, 18, 12, 16, 9, 9, 4, 2, 4, 2, 2, 2, 1, 4, 1, 1); // 0x09
            private static Player Axel_Blaze = new Player(200, 176, 79, 66, 76, 64, 72, 68, 60, 485, 49, 63, 18, 16, 13, 14, 14, 12, 12, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2); // 0x0A
            private static Player Kevin_Dragonfly = new Player(195, 144, 71, 60, 59, 61, 60, 64, 70, 445, 51, 60, 17, 15, 10, 12, 9, 14, 8, 1, 4, 2, 1, 4, 4, 2, 1, 2, 2); // 0x0B
            private static Player William_Glass = new Player(147, 168, 56, 51, 68, 57, 56, 53, 60, 401, 31, 21, 7, 8, 7, 11, 7, 5, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5); // 0x0C
            private static Player Nelly_Raimon_IE1 = new Player(140, 197, 79, 51, 45, 52, 44, 49, 62, 382, 33, 21, 8, 5, 5, 4, 6, 4, 7, 4, 2, 4, 4, 4, 4, 4, 4, 4, 1); // 0x0D
            private static Player Celia_Hills_IE1 = new Player(138, 149, 48, 54, 69, 45, 69, 51, 70, 406, 19, 29, 5, 6, 8, 7, 6, 6, 7, 4, 4, 4, 4, 4, 4, 2, 4, 4, 1); // 0x0E
            private static Player Silvia_Woods_IE1 = new Player(143, 116, 44, 72, 52, 69, 51, 64, 68, 420, 19, 27, 8, 6, 6, 6, 5, 5, 5, 4, 4, 4, 4, 4, 2, 4, 4, 4, 1); // 0x0F
            private static Player Nash = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x10
            private static Player Sater = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x11
            private static Player Isaacs = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x12
            private static Player Frank_Wintersea = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x13
            private static Player Joseph_King = new Player(200, 153, 72, 75, 69, 72, 55, 74, 60, 477, 55, 96, 15, 11, 13, 16, 13, 14, 14, 1, 3, 1, 2, 1, 3, 1, 1, 2, 1); // 0x15
            private static Player Peter_Drent = new Player(165, 144, 71, 54, 67, 64, 44, 59, 62, 421, 64, 89, 14, 17, 14, 18, 12, 14, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x16
            private static Player Ben_Simmons = new Player(191, 169, 68, 63, 72, 60, 69, 70, 69, 471, 68, 76, 11, 12, 14, 16, 12, 14, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x17
            private static Player Alan_Master = new Player(165, 168, 64, 64, 72, 69, 64, 62, 66, 461, 64, 64, 12, 10, 13, 16, 15, 17, 11, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x18
            private static Player Gus_Martin = new Player(189, 149, 76, 67, 73, 67, 63, 66, 63, 475, 62, 66, 13, 10, 12, 14, 12, 13, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x19
            private static Player Herman_Waldon = new Player(189, 188, 76, 64, 72, 79, 70, 57, 69, 487, 69, 72, 16, 10, 15, 12, 16, 16, 14, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x1A
            private static Player John_Bloom = new Player(195, 153, 61, 71, 67, 70, 71, 54, 62, 456, 60, 74, 12, 13, 12, 11, 17, 11, 14, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x1B
            private static Player Derek_Swing = new Player(171, 184, 70, 56, 76, 59, 69, 60, 61, 451, 69, 68, 12, 11, 13, 10, 14, 13, 11, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x1C
            private static Player Daniel_Hatch = new Player(184, 133, 75, 69, 68, 68, 78, 61, 64, 483, 54, 76, 20, 11, 14, 15, 14, 17, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x1D
            private static Player Jude_Sharp_RA = new Player(191, 180, 63, 79, 79, 79, 76, 76, 68, 520, 58, 78, 18, 19, 15, 17, 13, 15, 13, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1); // 0x1E
            private static Player David_Samford = new Player(193, 193, 70, 60, 78, 66, 66, 67, 71, 478, 62, 90, 16, 12, 17, 13, 17, 13, 16, 1, 3, 3, 2, 3, 1, 1, 2, 2, 3); // 0x1F
            private static Player Bob_Carlton = new Player(147, 170, 58, 55, 63, 54, 45, 62, 70, 407, 44, 54, 11, 12, 11, 14, 13, 11, 11, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x20
            private static Player Cliff_Tomlinson = new Player(149, 157, 53, 60, 52, 61, 54, 52, 53, 385, 46, 54, 14, 12, 12, 13, 14, 13, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x21
            private static Player Jim_Lawrenson = new Player(167, 137, 54, 57, 57, 63, 53, 56, 55, 395, 55, 55, 12, 12, 14, 11, 11, 14, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x22
            private static Player Barry_Potts = new Player(171, 136, 53, 52, 54, 56, 52, 60, 44, 371, 58, 49, 12, 12, 14, 11, 13, 11, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x23
            private static Player Steve_Ingham = new Player(169, 133, 61, 53, 57, 52, 47, 54, 46, 370, 50, 54, 14, 11, 12, 14, 11, 13, 13, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x24
            private static Player Nathan_Jones = new Player(165, 156, 58, 56, 70, 68, 56, 60, 68, 436, 43, 76, 15, 11, 20, 17, 10, 17, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 2); // 0x29
            private static Player Russell_Walk = new Player(140, 137, 60, 53, 60, 52, 63, 65, 58, 411, 42, 56, 14, 10, 14, 12, 17, 13, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2A
            private static Player Jason_Jones = new Player(151, 152, 52, 54, 57, 57, 60, 54, 63, 397, 55, 56, 12, 9, 12, 10, 13, 12, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2B
            private static Player Ken_Furan = new Player(151, 156, 55, 59, 47, 70, 52, 61, 48, 392, 30, 47, 14, 15, 11, 16, 11, 14, 9, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x2C
            private static Player Jerry_Fulton = new Player(187, 132, 52, 58, 56, 61, 56, 79, 53, 415, 49, 66, 12, 10, 14, 10, 12, 10, 13, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x2D
            private static Player Ray_Mannings = new Player(145, 136, 55, 62, 60, 52, 56, 61, 62, 408, 48, 51, 13, 8, 11, 11, 14, 8, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x2E
            private static Player Robert_Mayer = new Player(187, 137, 54, 52, 60, 52, 62, 75, 61, 416, 54, 55, 13, 11, 12, 12, 12, 12, 12, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x2F
            private static Player Alexander_Brave = new Player(180, 144, 57, 65, 60, 52, 71, 56, 55, 416, 54, 74, 11, 12, 11, 10, 11, 11, 12, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x30
            private static Player Johan_Tassman = new Player(171, 165, 62, 64, 56, 48, 60, 62, 63, 415, 69, 85, 15, 17, 15, 13, 15, 10, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x31
            private static Player Troy_Moon = new Player(211, 153, 61, 70, 77, 52, 79, 69, 67, 475, 58, 55, 18, 11, 13, 16, 14, 10, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x32
            private static Player Burt_Wolf = new Player(184, 152, 68, 52, 52, 51, 56, 62, 60, 401, 54, 70, 17, 15, 15, 13, 13, 10, 13, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x33
            private static Player Rob_Crombie = new Player(200, 156, 47, 46, 50, 40, 51, 74, 56, 364, 38, 53, 9, 11, 7, 19, 11, 14, 10, 2, 2, 2, 3, 4, 2, 1, 2, 1, 1); // 0x34
            private static Player Chuck_Dollman = new Player(129, 104, 52, 53, 45, 48, 49, 53, 55, 355, 37, 49, 11, 10, 7, 9, 9, 8, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x35
            private static Player Uxley_Allen = new Player(149, 112, 48, 51, 51, 50, 48, 55, 44, 347, 36, 52, 11, 9, 8, 9, 9, 11, 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x36
            private static Player Phil_Noir = new Player(121, 120, 52, 45, 48, 52, 52, 58, 45, 352, 31, 41, 9, 10, 9, 9, 8, 11, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x37
            private static Player Mick_Askley = new Player(143, 100, 55, 50, 54, 44, 48, 56, 54, 361, 40, 48, 8, 8, 10, 8, 11, 11, 9, 4, 5, 4, 4, 5, 4, 1, 4, 4, 3); // 0x38
            private static Player Charlie_Boardfield = new Player(217, 100, 68, 44, 44, 69, 60, 62, 69, 416, 69, 48, 18, 10, 12, 16, 9, 13, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x3D
            private static Player Hugo_Tallgeese = new Player(189, 101, 44, 52, 56, 46, 64, 67, 54, 383, 66, 44, 7, 10, 10, 16, 13, 14, 9, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x3E
            private static Player Wilson_Fishman = new Player(167, 113, 52, 64, 51, 51, 51, 62, 51, 382, 69, 51, 11, 18, 9, 8, 14, 11, 9, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x3F
            private static Player Peter_Johnson_ = new Player(167, 109, 48, 52, 48, 48, 54, 57, 50, 357, 61, 33, 9, 9, 7, 16, 15, 13, 11, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x40
            private static Player Leonard_O_Shea = new Player(195, 113, 78, 52, 47, 64, 55, 69, 68, 433, 66, 40, 19, 11, 9, 19, 7, 12, 9, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0x41
            private static Player Cham_Lion = new Player(176, 101, 44, 45, 45, 55, 53, 60, 48, 350, 61, 45, 10, 10, 14, 9, 17, 13, 7, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x42
            private static Player Steve_Eagle = new Player(193, 148, 61, 68, 62, 52, 68, 71, 68, 450, 76, 51, 13, 15, 17, 11, 18, 13, 10, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x43
            private static Player Bruce_Monkey = new Player(184, 100, 54, 64, 51, 48, 53, 52, 54, 376, 56, 43, 7, 12, 7, 9, 10, 14, 8, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x44
            private static Player Gary_Lancaster = new Player(191, 108, 78, 66, 49, 64, 54, 52, 67, 430, 69, 48, 16, 16, 9, 17, 5, 17, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x45
            private static Player Harry_Snake = new Player(184, 112, 55, 63, 62, 49, 55, 65, 45, 394, 56, 49, 9, 15, 16, 9, 13, 12, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x46
            private static Player Adrian_Speed = new Player(195, 133, 63, 47, 69, 55, 79, 42, 47, 402, 80, 51, 14, 10, 17, 7, 20, 14, 11, 1, 1, 4, 2, 2, 4, 1, 1, 1, 2); // 0x47
            private static Player Alan_Coe = new Player(132, 112, 52, 45, 53, 51, 48, 46, 49, 344, 40, 33, 11, 11, 11, 10, 9, 11, 10, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x48
            private static Player Philip_Anders = new Player(123, 132, 52, 51, 48, 52, 52, 51, 46, 352, 37, 66, 10, 10, 8, 9, 10, 7, 8, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x49
            private static Player Rocky_Rackham = new Player(123, 121, 53, 53, 53, 44, 51, 44, 47, 345, 36, 43, 8, 7, 9, 10, 13, 9, 9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x4A
            private static Player Matt_Mouseman = new Player(158, 112, 42, 50, 52, 44, 79, 54, 45, 366, 42, 41, 4, 5, 11, 4, 23, 11, 9, 4, 5, 4, 4, 5, 4, 1, 4, 4, 2); // 0x4B
            private static Player Chad_Bullford = new Player(171, 174, 41, 68, 48, 77, 31, 51, 64, 380, 32, 40, 9, 19, 9, 20, 10, 8, 11, 2, 2, 2, 3, 4, 2, 1, 2, 1, 2); // 0x4C
            private static Player Thomas_Feldt = new Player(206, 177, 75, 69, 68, 76, 75, 78, 76, 517, 48, 66, 11, 14, 13, 13, 13, 11, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51
            private static Player Harry_Leading = new Player(140, 112, 52, 52, 44, 47, 50, 52, 48, 345, 75, 76, 16, 16, 15, 16, 13, 20, 17, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x52
            private static Player Terry_Stronger = new Player(145, 121, 44, 46, 46, 52, 47, 52, 52, 339, 74, 80, 16, 15, 14, 17, 15, 23, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x53
            private static Player Philip_Marvel = new Player(143, 108, 44, 53, 52, 48, 49, 50, 51, 347, 75, 76, 13, 13, 15, 17, 16, 20, 13, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x54
            private static Player Noel_Good = new Player(134, 117, 44, 44, 48, 55, 44, 48, 45, 328, 76, 60, 15, 15, 15, 15, 16, 21, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x55
            private static Player Tyron_Rock = new Player(149, 112, 51, 46, 46, 48, 48, 47, 52, 338, 74, 76, 14, 17, 14, 17, 15, 20, 14, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x56
            private static Player Francis_Tell = new Player(145, 109, 44, 53, 48, 46, 45, 44, 47, 327, 69, 76, 14, 19, 13, 15, 17, 19, 14, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x57
            private static Player Samuel_Buster = new Player(125, 113, 55, 46, 52, 49, 48, 50, 49, 349, 69, 68, 23, 22, 15, 15, 15, 21, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x58
            private static Player Jonathan_Seller = new Player(132, 113, 55, 50, 50, 49, 55, 45, 46, 350, 80, 64, 15, 19, 15, 15, 15, 20, 17, 1, 2, 2, 2, 3, 2, 1, 1, 4, 3); // 0x59
            private static Player Victor_Kind = new Player(134, 109, 49, 53, 48, 51, 48, 53, 46, 348, 78, 70, 14, 18, 17, 14, 17, 21, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5A
            private static Player Neil_Turner = new Player(121, 108, 48, 48, 52, 52, 44, 50, 45, 339, 73, 74, 14, 20, 17, 16, 20, 20, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x5B
            private static Player Reg_Underwood = new Player(121, 115, 44, 40, 40, 69, 48, 42, 70, 353, 81, 72, 17, 17, 16, 17, 21, 22, 17, 1, 1, 4, 2, 2, 2, 1, 1, 1, 1); // 0x5C
            private static Player Patrick_Stiller = new Player(134, 117, 53, 45, 47, 52, 44, 46, 53, 340, 66, 76, 16, 14, 16, 16, 13, 19, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5D
            private static Player Charles_Oughtry = new Player(127, 113, 55, 52, 45, 45, 46, 44, 48, 335, 73, 74, 14, 16, 13, 17, 13, 22, 15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5E
            private static Player Clive_Mooney = new Player(138, 101, 53, 49, 54, 50, 55, 53, 46, 360, 76, 72, 13, 17, 13, 15, 17, 20, 13, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x5F
            private static Player Neil_Waters = new Player(151, 101, 52, 48, 51, 52, 45, 54, 45, 347, 81, 76, 13, 17, 16, 17, 16, 20, 17, 4, 5, 4, 4, 5, 4, 1, 4, 4, 2); // 0x60
            private static Player Sam_Idol = new Player(165, 161, 60, 58, 54, 55, 58, 45, 67, 397, 43, 43, 8, 8, 7, 17, 10, 11, 8, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x65
            private static Player Marcus_Train = new Player(149, 152, 61, 60, 53, 56, 52, 41, 54, 377, 32, 51, 11, 8, 9, 7, 9, 11, 7, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x66
            private static Player Light_Nobel = new Player(154, 164, 60, 55, 56, 58, 61, 44, 61, 395, 44, 51, 8, 9, 9, 8, 9, 9, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x67
            private static Player Walter_Valiant = new Player(158, 132, 62, 62, 61, 55, 56, 50, 71, 417, 31, 36, 11, 15, 9, 8, 9, 11, 7, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x68
            private static Player Spencer_Gates = new Player(149, 152, 59, 52, 56, 58, 56, 40, 62, 383, 46, 40, 7, 9, 11, 7, 9, 7, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x69
            private static Player Josh_Spear = new Player(158, 133, 54, 56, 56, 62, 55, 44, 60, 387, 36, 45, 8, 11, 9, 8, 8, 7, 8, 4, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x6A
            private static Player Gaby_Farmer = new Player(171, 152, 58, 62, 52, 61, 54, 47, 59, 393, 43, 51, 10, 10, 9, 7, 11, 10, 8, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6B
            private static Player A__Woodbridge = new Player(167, 137, 60, 60, 52, 58, 54, 41, 66, 391, 34, 52, 9, 10, 9, 9, 7, 7, 10, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x6C
            private static Player Gus_Gamer = new Player(173, 137, 58, 60, 59, 52, 55, 45, 69, 398, 37, 52, 10, 7, 14, 8, 7, 8, 7, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6D
            private static Player Mark_Gambling = new Player(143, 149, 52, 56, 58, 63, 53, 51, 64, 397, 34, 49, 10, 9, 11, 7, 11, 7, 10, 4, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x6E
            private static Player Theodore_Master = new Player(147, 152, 57, 57, 55, 56, 52, 47, 60, 384, 30, 41, 10, 8, 11, 8, 9, 9, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6F
            private static Player Ham_Signalman = new Player(151, 137, 54, 56, 55, 52, 53, 48, 59, 377, 39, 51, 7, 8, 11, 11, 10, 8, 11, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x70
            private static Player Bill_Formby = new Player(158, 137, 54, 58, 61, 45, 46, 48, 51, 363, 40, 43, 10, 9, 10, 9, 8, 9, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x71
            private static Player Grant_Eldorado = new Player(158, 144, 49, 63, 61, 69, 43, 28, 49, 362, 37, 68, 11, 11, 8, 18, 8, 10, 10, 4, 3, 5, 4, 4, 2, 4, 4, 1, 1); // 0x72
            private static Player Mike_Vox = new Player(162, 144, 48, 55, 57, 51, 44, 50, 47, 352, 33, 39, 8, 10, 8, 9, 11, 9, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x73
            private static Player Ollie_Webb = new Player(143, 141, 44, 62, 54, 48, 44, 51, 49, 352, 33, 41, 10, 9, 8, 7, 9, 9, 9, 4, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x74
            private static Player Morgan_Sanders = new Player(167, 164, 53, 59, 44, 64, 52, 55, 62, 389, 56, 86, 10, 9, 19, 20, 13, 16, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x79
            private static Player Newton_Flust = new Player(169, 129, 62, 61, 56, 60, 55, 60, 63, 417, 54, 58, 11, 16, 12, 17, 10, 17, 13, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x7A
            private static Player Jim_Hillfort = new Player(147, 141, 55, 62, 60, 53, 54, 63, 61, 408, 58, 62, 13, 14, 10, 19, 11, 13, 13, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x7B
            private static Player Galen_Thunderbird = new Player(145, 153, 63, 60, 63, 62, 54, 57, 60, 419, 78, 78, 20, 16, 10, 17, 7, 15, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0x7C
            private static Player Finn_Stoned = new Player(151, 149, 54, 53, 57, 56, 55, 58, 63, 396, 54, 51, 14, 19, 13, 19, 10, 16, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x7D
            private static Player Phil_Wingate = new Player(176, 152, 60, 56, 60, 57, 54, 68, 61, 416, 70, 62, 19, 11, 19, 15, 13, 16, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x7E
            private static Player Jez_Shell = new Player(156, 133, 53, 63, 59, 56, 47, 65, 60, 403, 44, 63, 13, 10, 12, 14, 12, 14, 15, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x7F
            private static Player Jupiter_Jumper = new Player(176, 140, 56, 61, 53, 56, 69, 68, 59, 422, 60, 59, 16, 14, 16, 12, 19, 16, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 2); // 0x80
            private static Player Sam_Samurai = new Player(160, 176, 60, 60, 60, 60, 56, 60, 53, 409, 45, 66, 16, 11, 14, 14, 16, 17, 13, 1, 2, 2, 2, 3, 2, 1, 1, 4, 3); // 0x81
            private static Player Hank_Sullivan = new Player(140, 140, 60, 55, 59, 44, 60, 60, 56, 394, 32, 56, 14, 12, 18, 12, 15, 17, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x82
            private static Player Sail_Bluesea = new Player(180, 180, 52, 61, 61, 54, 60, 68, 55, 411, 44, 54, 17, 16, 18, 14, 17, 17, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x83
            private static Player John_Reynolds = new Player(171, 137, 62, 56, 56, 53, 60, 54, 57, 398, 51, 51, 19, 11, 12, 11, 11, 17, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x84
            private static Player Dan_Hopper = new Player(145, 136, 52, 58, 62, 62, 55, 61, 54, 404, 44, 58, 12, 12, 13, 16, 11, 15, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x85
            private static Player Cal_Trops = new Player(145, 144, 58, 61, 69, 55, 59, 57, 54, 413, 43, 60, 11, 10, 18, 13, 11, 13, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0x86
            private static Player Winston_Falls = new Player(165, 132, 56, 56, 52, 63, 64, 55, 62, 408, 56, 58, 11, 14, 11, 10, 18, 16, 15, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x87
            private static Player Kevin_Castle = new Player(156, 132, 53, 60, 52, 68, 52, 52, 52, 389, 48, 56, 12, 14, 14, 18, 12, 13, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0x88
            private static Player Albert_Green = new Player(169, 109, 50, 53, 60, 73, 53, 64, 77, 430, 60, 55, 10, 17, 16, 17, 11, 19, 15, 2, 5, 2, 1, 1, 3, 1, 2, 3, 2); // 0x8D
            private static Player Seward_Hayseed = new Player(193, 128, 42, 56, 52, 77, 58, 68, 61, 414, 67, 64, 10, 15, 12, 17, 13, 16, 16, 1, 5, 1, 1, 1, 3, 1, 1, 1, 1); // 0x8E
            private static Player Kent_Work = new Player(171, 109, 44, 57, 54, 70, 54, 65, 60, 404, 54, 55, 7, 15, 11, 19, 12, 20, 16, 1, 5, 4, 2, 2, 3, 1, 1, 1, 1); // 0x8F
            private static Player Mark_Hillvalley_ = new Player(187, 108, 40, 56, 52, 79, 63, 66, 53, 409, 63, 51, 7, 13, 13, 18, 11, 19, 15, 2, 5, 2, 3, 4, 3, 1, 2, 1, 1); // 0x90
            private static Player Herb_Sherman = new Player(176, 116, 49, 60, 62, 79, 52, 70, 56, 428, 64, 49, 8, 15, 12, 17, 13, 20, 17, 1, 5, 1, 1, 1, 3, 1, 1, 1, 1); // 0x91
            private static Player Joe_Small = new Player(178, 100, 40, 54, 54, 68, 56, 63, 56, 391, 54, 55, 11, 17, 11, 17, 12, 17, 14, 1, 5, 4, 2, 2, 3, 1, 1, 1, 1); // 0x92
            private static Player Ike_Steiner = new Player(180, 116, 42, 55, 63, 76, 53, 60, 55, 404, 57, 66, 10, 13, 12, 17, 12, 20, 14, 2, 5, 2, 1, 1, 3, 1, 2, 3, 2); // 0x93
            private static Player Orville_Newman = new Player(169, 125, 71, 70, 46, 72, 62, 66, 71, 458, 67, 56, 19, 16, 9, 15, 13, 20, 17, 2, 5, 2, 1, 1, 3, 1, 2, 3, 1); // 0x94
            private static Player Tom_Walters = new Player(193, 104, 63, 58, 52, 73, 71, 61, 70, 448, 58, 63, 13, 16, 12, 15, 14, 20, 14, 2, 5, 2, 1, 1, 3, 1, 2, 3, 3); // 0x95
            private static Player Daniel_Dawson = new Player(187, 108, 57, 55, 56, 75, 64, 66, 76, 449, 57, 59, 16, 16, 11, 16, 14, 18, 16, 1, 5, 1, 1, 1, 3, 1, 1, 1, 2); // 0x96
            private static Player Stuart_Racoonfur = new Player(165, 101, 56, 62, 62, 74, 66, 63, 72, 455, 61, 51, 17, 15, 15, 14, 15, 16, 17, 1, 5, 4, 2, 2, 3, 1, 1, 1, 3); // 0x97
            private static Player Lorne_Mower = new Player(189, 164, 46, 56, 41, 72, 62, 61, 60, 398, 38, 78, 7, 12, 7, 17, 12, 11, 10, 4, 1, 1, 1, 1, 3, 1, 1, 1, 2); // 0x98
            private static Player Homer_Grower = new Player(187, 113, 53, 53, 44, 76, 61, 68, 61, 416, 38, 60, 10, 11, 9, 16, 10, 10, 13, 4, 5, 2, 3, 4, 3, 1, 2, 1, 1); // 0x99
            private static Player Rolf_Howells = new Player(171, 117, 48, 62, 54, 75, 54, 60, 56, 409, 37, 63, 8, 11, 9, 15, 13, 13, 14, 4, 5, 4, 2, 2, 3, 1, 1, 1, 1); // 0x9A
            private static Player Luke_Lively = new Player(182, 116, 47, 57, 44, 73, 56, 63, 54, 394, 40, 52, 7, 14, 8, 14, 14, 13, 12, 4, 5, 2, 3, 4, 3, 1, 2, 1, 1); // 0x9B
            private static Player Ben_Nevis = new Player(195, 120, 52, 56, 51, 70, 59, 64, 53, 405, 45, 60, 7, 12, 9, 17, 11, 10, 12, 4, 5, 2, 1, 1, 3, 1, 2, 3, 2); // 0x9C
            private static Player John_Neville = new Player(127, 140, 78, 62, 54, 79, 48, 51, 44, 416, 85, 100, 13, 10, 17, 23, 7, 6, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0xA1
            private static Player Malcolm_Night = new Player(209, 180, 63, 76, 68, 78, 67, 64, 70, 486, 76, 85, 14, 13, 12, 13, 10, 14, 14, 1, 2, 2, 2, 3, 2, 1, 1, 4, 3); // 0xA2
            private static Player Alfred_Meenan = new Player(169, 149, 61, 55, 55, 60, 55, 53, 52, 391, 51, 90, 13, 12, 11, 15, 18, 11, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 3); // 0xA3
            private static Player Dan_Mirthful = new Player(165, 129, 59, 70, 49, 65, 46, 51, 52, 392, 64, 52, 19, 16, 12, 17, 7, 8, 7, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0xA4
            private static Player Ricky_Clover = new Player(156, 137, 53, 52, 56, 52, 67, 45, 54, 379, 52, 80, 13, 18, 13, 18, 11, 12, 12, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0xA5
            private static Player Toby_Damian = new Player(173, 133, 54, 56, 55, 56, 57, 56, 55, 389, 51, 89, 12, 17, 15, 14, 16, 11, 11, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0xA6
            private static Player York_Nashmith = new Player(154, 132, 52, 62, 57, 61, 54, 52, 56, 394, 55, 90, 11, 16, 13, 12, 15, 11, 14, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xA7
            private static Player Zachary_Moore = new Player(149, 145, 52, 60, 60, 52, 63, 53, 58, 398, 56, 85, 14, 16, 15, 11, 15, 10, 15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xA8
            private static Player Marvin_Murdock = new Player(195, 161, 68, 61, 61, 66, 60, 60, 61, 437, 61, 90, 20, 23, 13, 12, 16, 19, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xA9
            private static Player Thomas_Murdock = new Player(180, 152, 68, 70, 65, 60, 64, 62, 61, 450, 67, 107, 20, 15, 20, 13, 14, 18, 19, 1, 1, 4, 2, 2, 4, 1, 1, 1, 2); // 0xAA
            private static Player Tyler_Murdock = new Player(167, 157, 79, 64, 68, 56, 60, 59, 54, 440, 62, 107, 23, 14, 14, 13, 21, 18, 20, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0xAB
            private static Player Simon_Calier = new Player(112, 168, 50, 41, 46, 71, 45, 48, 47, 348, 58, 63, 14, 12, 17, 16, 13, 10, 10, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2); // 0xAC
            private static Player Brody_Gloom = new Player(136, 125, 54, 46, 48, 53, 45, 52, 54, 352, 52, 55, 13, 17, 13, 13, 11, 11, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0xAD
            private static Player Victor_Talis = new Player(145, 177, 55, 52, 52, 46, 47, 45, 48, 345, 58, 84, 13, 13, 10, 14, 10, 13, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xAE
            private static Player Eren_Middleton = new Player(140, 112, 48, 44, 55, 47, 55, 54, 52, 355, 54, 51, 11, 12, 11, 20, 14, 11, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0xAF
            private static Player Peter_Wells = new Player(121, 101, 52, 48, 52, 43, 52, 55, 52, 354, 58, 52, 10, 10, 13, 16, 11, 11, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB0
            private static Player Paul_Siddon = new Player(145, 120, 79, 79, 71, 79, 44, 74, 76, 502, 56, 93, 21, 23, 13, 23, 10, 18, 18, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0xB5
            private static Player Apollo_Light = new Player(136, 144, 79, 79, 62, 73, 53, 48, 55, 449, 78, 76, 14, 17, 19, 20, 22, 20, 19, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0xB6
            private static Player Jeff_Iron = new Player(171, 156, 60, 64, 78, 69, 70, 64, 62, 467, 69, 100, 13, 21, 16, 19, 21, 15, 12, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0xB7
            private static Player Lane_War = new Player(138, 153, 71, 79, 70, 72, 56, 57, 60, 465, 56, 64, 17, 18, 16, 17, 12, 12, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0xB8
            private static Player Danny_Wood = new Player(136, 124, 62, 68, 66, 79, 50, 53, 64, 442, 54, 78, 22, 14, 13, 17, 8, 14, 22, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xB9
            private static Player Artie_Mishman = new Player(127, 184, 62, 66, 76, 67, 44, 45, 58, 418, 50, 86, 14, 20, 21, 15, 17, 14, 12, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xBA
            private static Player Arion_Matlock = new Player(162, 180, 56, 69, 69, 68, 57, 62, 62, 443, 51, 74, 12, 23, 16, 20, 10, 14, 15, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0xBB
            private static Player Wesley_Knox = new Player(187, 132, 60, 76, 64, 63, 71, 64, 77, 475, 76, 92, 16, 21, 22, 13, 20, 17, 17, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0xBC
            private static Player Jonas_Demetrius = new Player(151, 149, 77, 64, 79, 56, 68, 63, 68, 475, 80, 104, 23, 17, 18, 12, 15, 13, 15, 2, 1, 2, 1, 1, 2, 1, 2, 3, 3); // 0xBD
            private static Player Byron_Love = new Player(167, 184, 79, 69, 77, 70, 72, 68, 67, 502, 54, 100, 16, 22, 21, 17, 17, 14, 13, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0xBE
            private static Player Henry_House = new Player(193, 165, 48, 68, 60, 67, 64, 70, 60, 437, 58, 70, 6, 15, 15, 15, 16, 16, 13, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xBF
            private static Player Iggy_Russ = new Player(182, 149, 71, 67, 66, 79, 44, 71, 64, 462, 68, 62, 14, 15, 16, 22, 8, 15, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xC0
            private static Player Gus_Heeley = new Player(191, 165, 78, 69, 61, 50, 65, 60, 70, 453, 69, 76, 19, 16, 13, 8, 17, 16, 17, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0xC1
            private static Player Harry_Closs = new Player(191, 64, 63, 60, 66, 79, 69, 71, 65, 473, 58, 36, 16, 13, 15, 20, 15, 15, 16, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0xC2
            private static Player Andy_Chronic = new Player(178, 169, 48, 66, 62, 79, 63, 61, 66, 445, 62, 68, 8, 13, 15, 22, 14, 17, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0xC3
            private static Player Ned_Yousef = new Player(173, 152, 69, 78, 79, 67, 63, 62, 62, 480, 62, 72, 17, 23, 21, 17, 16, 16, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0xC4
            private static Player Herman_Muller = new Player(143, 109, 40, 50, 44, 47, 44, 46, 45, 316, 19, 63, 8, 7, 8, 11, 6, 8, 4, 5, 5, 5, 5, 5, 2, 5, 5, 5, 1); // 0xC9
            private static Player Keth_Claus = new Player(112, 84, 41, 41, 48, 40, 60, 40, 46, 316, 18, 35, 6, 6, 8, 6, 14, 5, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCA
            private static Player Robert_Silver = new Player(125, 73, 46, 41, 51, 44, 41, 48, 44, 315, 30, 32, 7, 11, 5, 8, 4, 8, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCB
            private static Player Izzy_Island = new Player(136, 65, 42, 40, 48, 41, 41, 48, 44, 304, 25, 54, 5, 5, 6, 6, 6, 7, 8, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xCC
            private static Player Sothern_Newman = new Player(127, 60, 45, 44, 48, 60, 43, 49, 47, 336, 22, 20, 6, 8, 5, 17, 8, 8, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xCD
            private static Player Irwin_Hall = new Player(162, 69, 40, 48, 51, 43, 41, 40, 41, 304, 21, 44, 4, 10, 8, 7, 6, 8, 8, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCE
            private static Player Taylor_Higgins = new Player(134, 65, 44, 43, 50, 48, 40, 48, 40, 313, 25, 21, 8, 11, 7, 8, 7, 4, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xCF
            private static Player Jamie_Cool = new Player(162, 76, 47, 40, 44, 48, 52, 52, 51, 334, 30, 54, 6, 4, 5, 7, 14, 8, 4, 5, 5, 5, 5, 5, 5, 2, 5, 5, 3); // 0xD0
            private static Player Hans_Randall = new Player(169, 65, 64, 40, 40, 51, 48, 56, 44, 343, 26, 60, 10, 6, 5, 5, 8, 5, 12, 5, 5, 2, 5, 5, 5, 5, 5, 2, 2); // 0xD1
            private static Player Michael_Riverside = new Player(138, 77, 51, 46, 50, 49, 40, 43, 48, 327, 25, 20, 7, 8, 8, 8, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xD2
            private static Player Millie_Moonlight = new Player(167, 148, 44, 40, 60, 42, 51, 40, 46, 323, 20, 48, 6, 4, 13, 5, 5, 5, 11, 5, 2, 5, 5, 2, 5, 5, 5, 5, 1); // 0xD3
            private static Player Karl_Blue = new Player(114, 76, 46, 48, 47, 44, 51, 46, 48, 330, 33, 39, 8, 7, 16, 6, 6, 4, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xD4
            private static Player Theakston_Plank = new Player(121, 80, 48, 50, 42, 45, 58, 41, 51, 335, 26, 36, 8, 7, 4, 8, 15, 8, 8, 5, 5, 5, 5, 5, 5, 2, 5, 5, 3); // 0xD5
            private static Player Ken_Cake = new Player(123, 88, 49, 40, 40, 40, 51, 49, 46, 315, 24, 33, 9, 6, 7, 4, 8, 6, 7, 5, 5, 2, 5, 5, 5, 5, 5, 5, 1); // 0xD6
            private static Player Mitch_Grumble = new Player(110, 65, 48, 48, 43, 48, 40, 46, 41, 314, 19, 29, 6, 4, 9, 6, 4, 6, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xD7
            private static Player Bart_Grantham = new Player(101, 180, 38, 35, 29, 66, 28, 29, 64, 289, 26, 54, 6, 5, 5, 15, 8, 7, 6, 5, 1, 5, 5, 5, 2, 5, 5, 5, 1); // 0xD8
            private static Player Joe_Ingram = new Player(149, 113, 44, 71, 52, 74, 47, 57, 78, 423, 50, 43, 11, 10, 10, 12, 8, 11, 6, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xDD
            private static Player Kendall_Sefton = new Player(151, 109, 53, 49, 61, 54, 67, 54, 55, 393, 45, 47, 11, 9, 12, 11, 11, 8, 7, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xDE
            private static Player Jason_Strike = new Player(132, 109, 48, 50, 64, 47, 56, 51, 53, 369, 31, 52, 8, 10, 8, 11, 12, 11, 7, 4, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xDF
            private static Player Norman_Porter = new Player(145, 112, 45, 56, 44, 60, 44, 52, 46, 347, 40, 36, 8, 11, 11, 12, 8, 11, 7, 4, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE0
            private static Player Maxwell_Claus = new Player(136, 120, 62, 53, 55, 44, 53, 55, 49, 371, 42, 41, 12, 9, 10, 9, 14, 7, 4, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE1
            private static Player Bruce_Chaney = new Player(136, 121, 46, 48, 48, 45, 66, 48, 49, 350, 31, 36, 14, 11, 9, 7, 13, 9, 5, 4, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xE2
            private static Player Leroy_Rhymes = new Player(140, 140, 47, 48, 52, 53, 46, 45, 48, 339, 34, 64, 10, 8, 13, 7, 9, 11, 5, 4, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE3
            private static Player Mildford_Scott = new Player(129, 109, 44, 52, 47, 50, 55, 52, 44, 344, 44, 47, 10, 16, 10, 10, 11, 7, 8, 4, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xE4
            private static Player Lou_Edmonds = new Player(143, 124, 60, 68, 45, 51, 44, 54, 71, 393, 37, 39, 11, 14, 9, 9, 9, 7, 5, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE5
            private static Player Cameron_Morefield = new Player(167, 129, 59, 56, 58, 52, 48, 52, 72, 397, 34, 63, 13, 13, 11, 10, 8, 9, 7, 4, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE6
            private static Player Greg_Bernard = new Player(123, 165, 49, 55, 63, 51, 51, 56, 65, 390, 38, 72, 9, 9, 15, 11, 10, 8, 4, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE7
            private static Player Peter_Banker = new Player(138, 122, 50, 45, 51, 63, 50, 45, 75, 379, 42, 62, 11, 10, 14, 18, 7, 9, 4, 4, 2, 4, 4, 4, 2, 4, 4, 2, 2); // 0xE8
            private static Player Saul_Tunk = new Player(145, 109, 55, 53, 44, 62, 55, 47, 54, 370, 32, 48, 11, 9, 11, 19, 8, 8, 8, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE9
            private static Player Alan_Most = new Player(191, 165, 65, 60, 60, 68, 63, 61, 64, 441, 26, 39, 8, 5, 7, 6, 8, 7, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xEA
            private static Player Paul_Caperock = new Player(140, 113, 54, 50, 46, 45, 58, 48, 53, 354, 43, 49, 8, 7, 9, 10, 12, 11, 6, 4, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xEB
            private static Player Julius_Molehill = new Player(123, 113, 53, 48, 68, 48, 55, 49, 46, 367, 30, 48, 7, 7, 12, 7, 11, 10, 7, 4, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xEC
            private static Player Suzanne_Yuma = new Player(129, 80, 44, 44, 43, 56, 49, 46, 45, 327, 31, 45, 11, 7, 11, 20, 10, 9, 18, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0xF1
            private static Player Tammy_Fielding = new Player(121, 81, 44, 49, 48, 51, 48, 44, 40, 324, 30, 21, 6, 7, 6, 7, 14, 8, 13, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xF2
            private static Player Alex_Lovely = new Player(138, 85, 49, 44, 44, 44, 44, 51, 44, 320, 42, 48, 10, 9, 8, 11, 10, 7, 17, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xF3
            private static Player Louis_Hillside = new Player(136, 72, 60, 52, 51, 41, 41, 48, 49, 342, 42, 39, 19, 17, 10, 8, 9, 11, 14, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xF4
            private static Player Ness_Sheldon = new Player(127, 84, 42, 48, 45, 53, 42, 40, 43, 313, 34, 44, 10, 14, 10, 16, 9, 8, 16, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xF5
            private static Player Lizzy_Squirrel = new Player(129, 137, 43, 44, 50, 45, 47, 45, 44, 318, 32, 76, 7, 7, 11, 14, 10, 9, 20, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0xF6
            private static Player Kippy_Jones = new Player(123, 129, 48, 51, 47, 51, 43, 42, 51, 333, 33, 27, 6, 7, 5, 5, 7, 5, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0xF7
            private static Player Fayette_Riversong = new Player(121, 61, 40, 50, 50, 48, 40, 42, 47, 317, 45, 51, 7, 11, 12, 8, 8, 8, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xF8
            private static Player Samantha_Moonlight = new Player(123, 68, 52, 43, 42, 48, 41, 44, 50, 320, 38, 51, 11, 12, 11, 10, 10, 9, 14, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0xF9
            private static Player Mitch_Sandstone = new Player(125, 61, 54, 58, 41, 48, 45, 46, 51, 343, 37, 47, 20, 15, 11, 11, 8, 10, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0xFA

            private static Player Eddie_Prentice = new Player(116, 73, 46, 46, 56, 44, 42, 48, 49, 331, 39, 45, 9, 8, 18, 9, 9, 9, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xFB
            private static Player Alf_Holmes = new Player(81, 174, 34, 28, 34, 64, 39, 31, 77, 307, 36, 69, 7, 10, 10, 19, 7, 4, 13, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0xFC
            private static Player Ian_Stager = new Player(129, 81, 40, 49, 44, 51, 49, 50, 51, 334, 42, 76, 11, 8, 8, 8, 8, 8, 17, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0xFD
            private static Player Fred_Crumb = new Player(121, 72, 40, 44, 44, 43, 44, 48, 45, 308, 40, 37, 9, 11, 10, 7, 14, 11, 16, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0xFE
            private static Player Doug_Baughan = new Player(116, 68, 45, 41, 46, 48, 40, 51, 44, 315, 43, 45, 8, 9, 14, 9, 7, 9, 16, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0xFF
            private static Player Pip_Daltry = new Player(114, 60, 44, 45, 49, 51, 49, 40, 43, 321, 18, 20, 5, 4, 8, 7, 5, 5, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x100
            private static Player Seymour_Hillman = new Player(215, 185, 70, 68, 64, 71, 68, 75, 72, 488, 69, 93, 12, 12, 11, 10, 12, 13, 15, 2, 1, 2, 1, 1, 2, 1, 2, 3, 3); // 0x105
            private static Player Charles_Island = new Player(215, 172, 71, 79, 71, 68, 69, 63, 64, 485, 68, 78, 13, 14, 16, 11, 11, 12, 11, 1, 2, 2, 2, 3, 2, 1, 1, 4, 2); // 0x106
            private static Player Garret_Hairtown = new Player(202, 173, 70, 65, 65, 62, 73, 60, 71, 466, 63, 60, 12, 13, 16, 14, 16, 11, 11, 1, 1, 4, 2, 2, 4, 1, 1, 1, 3); // 0x107
            private static Player Arthur_Sweet = new Player(193, 156, 74, 75, 66, 65, 65, 68, 61, 474, 68, 70, 15, 16, 11, 14, 13, 15, 11, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x108
            private static Player Peter_Mildred = new Player(215, 184, 72, 71, 69, 70, 74, 69, 78, 503, 55, 64, 14, 13, 10, 13, 11, 11, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x109
            private static Player Josh_Nathaniel = new Player(209, 172, 64, 73, 73, 75, 71, 66, 65, 487, 62, 60, 14, 11, 15, 10, 14, 13, 12, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x10A
            private static Player Edward_Gladstone = new Player(187, 177, 68, 66, 68, 60, 72, 63, 69, 466, 62, 66, 14, 12, 12, 11, 13, 12, 12, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x10B
            private static Player Tyler_Thomas = new Player(200, 197, 73, 72, 76, 76, 79, 72, 70, 518, 54, 76, 11, 12, 10, 10, 11, 11, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x10C
            private static Player Joseph_Yosemite = new Player(191, 189, 62, 72, 72, 76, 65, 62, 65, 474, 64, 68, 18, 11, 15, 14, 14, 12, 13, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x10D
            private static Player Ian_Suffolk = new Player(209, 172, 71, 68, 70, 69, 77, 68, 68, 491, 62, 63, 14, 13, 12, 11, 13, 13, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x10E
            private static Player Constant_Builder = new Player(195, 173, 69, 69, 64, 60, 63, 77, 64, 466, 66, 64, 16, 20, 14, 14, 13, 15, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 2); // 0x10F
            private static Player Ted_Poe = new Player(217, 173, 64, 68, 79, 70, 69, 64, 69, 483, 57, 68, 13, 14, 13, 10, 14, 14, 12, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x110
            private static Player Marshall_Heart = new Player(209, 181, 60, 62, 66, 63, 72, 65, 64, 452, 68, 80, 14, 12, 12, 11, 12, 13, 11, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x111
            private static Player Dom_Foreman = new Player(193, 149, 76, 72, 64, 64, 68, 72, 70, 486, 66, 76, 10, 12, 11, 11, 11, 14, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x112
            private static Player Slot_MacHines = new Player(213, 173, 68, 68, 75, 71, 76, 68, 73, 499, 69, 76, 12, 12, 14, 11, 13, 13, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x113
            private static Player Bill_Steakspear = new Player(193, 173, 62, 75, 78, 68, 68, 67, 68, 486, 61, 60, 11, 11, 17, 11, 11, 11, 10, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x114
            private static Player Layton = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x119
            private static Player Luke = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x11A
            private static Player Anton = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x11B
            private static Player Don_Paolo = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x11C
            private static Player Flora = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x11D
            private static Player Chelmey = new Player(154, 144, 62, 64, 71, 64, 71, 71, 71, 474, 43, 51, 13, 9, 11, 11, 10, 7, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x11E
            private static Player Jimmy_Mach = new Player(158, 149, 52, 61, 60, 58, 79, 76, 50, 436, 74, 32, 8, 6, 11, 5, 20, 18, 6, 5, 5, 1, 1, 1, 1, 2, 2, 1, 3); // 0x12D
            private static Player Tony_Hacker = new Player(79, 168, 52, 60, 67, 69, 76, 75, 64, 463, 22, 63, 12, 12, 11, 12, 14, 16, 14, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x12E
            private static Player Dan_Rhino = new Player(88, 144, 72, 58, 60, 53, 69, 62, 53, 427, 25, 36, 9, 9, 9, 8, 12, 11, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x12F
            private static Player Vin_Fleetwood = new Player(99, 88, 71, 64, 61, 69, 68, 68, 65, 466, 19, 32, 13, 13, 12, 10, 13, 12, 11, 1, 1, 5, 5, 5, 5, 5, 5, 5, 1); // 0x130
            private static Player George_Winters = new Player(140, 180, 44, 72, 76, 68, 79, 70, 73, 482, 42, 76, 14, 17, 14, 15, 19, 17, 13, 5, 5, 5, 5, 5, 5, 2, 2, 5, 4); // 0x131
            private static Player Den_Hidden = new Player(121, 153, 73, 60, 64, 76, 44, 79, 60, 456, 52, 52, 12, 12, 12, 13, 14, 12, 13, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x132
            private static Player Shaun_Imago = new Player(123, 132, 42, 36, 30, 55, 60, 60, 60, 343, 32, 36, 10, 9, 7, 11, 17, 11, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x133
            private static Player Joe_Straiter = new Player(171, 132, 56, 53, 52, 71, 58, 58, 59, 407, 55, 66, 15, 10, 12, 4, 10, 10, 13, 1, 1, 2, 4, 4, 2, 4, 1, 4, 1); // 0x134
            private static Player Rupert_Spiers = new Player(127, 152, 55, 64, 70, 70, 74, 68, 63, 464, 46, 55, 15, 14, 10, 10, 20, 15, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x135
            private static Player Mark_Sudor = new Player(118, 133, 64, 63, 55, 62, 45, 62, 52, 403, 44, 52, 7, 8, 8, 11, 10, 7, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x136
            private static Player Ringo_Stagg = new Player(140, 165, 60, 65, 57, 67, 56, 56, 63, 424, 30, 47, 11, 9, 7, 15, 10, 13, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x137
            private static Player Jody_MacGough = new Player(83, 140, 41, 52, 58, 52, 67, 70, 61, 401, 18, 38, 8, 8, 9, 10, 11, 10, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x138
            private static Player Jeeves_Dropper = new Player(96, 142, 45, 61, 58, 53, 68, 60, 54, 399, 26, 46, 9, 7, 8, 11, 14, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x139
            private static Player Dan_Dandy = new Player(154, 150, 61, 43, 44, 63, 68, 65, 68, 412, 51, 61, 11, 13, 8, 11, 17, 13, 12, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x13A
            private static Player Rory_Boomer = new Player(171, 156, 71, 62, 57, 56, 60, 65, 79, 450, 49, 27, 19, 15, 11, 10, 11, 10, 14, 1, 5, 2, 1, 1, 1, 1, 1, 1, 1); // 0x13B
            private static Player Tim_Toppel = new Player(176, 172, 69, 65, 64, 60, 64, 69, 61, 452, 25, 31, 8, 6, 6, 6, 6, 7, 7, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x13C
            private static Player Ames_Shivers = new Player(160, 138, 61, 56, 58, 56, 55, 63, 54, 403, 54, 69, 13, 14, 14, 16, 16, 13, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x13D
            private static Player Chris_Glover = new Player(105, 156, 67, 62, 60, 76, 38, 67, 52, 422, 32, 50, 10, 11, 9, 14, 7, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x13E
            private static Player Thor_Toise = new Player(118, 110, 52, 54, 48, 41, 50, 59, 53, 357, 42, 20, 14, 12, 10, 7, 9, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x13F
            private static Player Colin_Salts = new Player(132, 110, 63, 44, 46, 41, 44, 48, 41, 327, 46, 50, 11, 11, 10, 8, 10, 10, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x140
            private static Player Christian_Dear = new Player(118, 100, 59, 64, 76, 64, 44, 52, 55, 414, 36, 35, 15, 14, 11, 7, 9, 8, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x141
            private static Player Iggy_Loyaller = new Player(83, 158, 61, 62, 53, 62, 34, 64, 53, 389, 31, 42, 9, 11, 10, 11, 11, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x142
            private static Player Conan_Fox = new Player(85, 152, 44, 56, 56, 53, 62, 55, 63, 389, 32, 46, 10, 7, 10, 11, 17, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x143
            private static Player Spike_Coiffs = new Player(147, 158, 40, 60, 77, 43, 53, 58, 52, 383, 34, 39, 17, 17, 19, 14, 14, 17, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x144
            private static Player Roger_Rocket = new Player(136, 142, 40, 29, 35, 59, 78, 56, 52, 349, 44, 35, 11, 6, 4, 11, 19, 14, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x145
            private static Player Bill_Teller = new Player(81, 156, 44, 59, 78, 63, 63, 57, 59, 423, 25, 74, 13, 6, 21, 9, 14, 11, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x146
            private static Player Billy_Nomates = new Player(132, 160, 76, 64, 64, 77, 40, 76, 65, 462, 52, 65, 10, 14, 12, 15, 12, 12, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x147
            private static Player Harry_Caine = new Player(125, 161, 73, 70, 60, 64, 64, 60, 62, 453, 56, 54, 11, 15, 16, 15, 14, 15, 13, 5, 1, 2, 4, 4, 4, 4, 4, 4, 3); // 0x148
            private static Player Martin_Sheller = new Player(215, 154, 68, 57, 57, 69, 36, 68, 62, 417, 37, 35, 10, 10, 7, 14, 11, 7, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x149
            private static Player Alfie_Fine = new Player(138, 133, 66, 52, 52, 69, 50, 68, 57, 414, 31, 40, 11, 9, 10, 10, 9, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x14A
            private static Player Cameron_Mann = new Player(154, 146, 60, 59, 58, 61, 52, 53, 54, 397, 33, 42, 10, 10, 11, 9, 9, 9, 7, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x14B
            private static Player Don_Keys = new Player(129, 150, 45, 36, 32, 53, 64, 55, 56, 341, 42, 40, 7, 10, 7, 10, 14, 12, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x14C
            private static Player Sonny_East = new Player(125, 108, 59, 60, 50, 40, 49, 63, 68, 389, 39, 35, 13, 13, 8, 11, 7, 11, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x14D
            private static Player Dan_Carpenter = new Player(145, 144, 40, 54, 60, 42, 52, 56, 60, 364, 44, 38, 9, 13, 13, 8, 8, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x14E
            private static Player Doug_Walker = new Player(158, 142, 45, 52, 70, 42, 56, 57, 61, 383, 36, 53, 9, 13, 17, 10, 8, 10, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x14F
            private static Player Frank_Drake = new Player(171, 158, 57, 58, 60, 57, 64, 66, 52, 414, 66, 53, 13, 12, 12, 13, 13, 16, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x150
            private static Player Chris_Massey = new Player(77, 146, 66, 58, 53, 53, 56, 62, 59, 407, 44, 53, 16, 7, 10, 14, 10, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x151
            private static Player Carl_Sacks = new Player(156, 144, 60, 62, 56, 61, 55, 52, 55, 401, 56, 50, 14, 11, 12, 10, 14, 11, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x152
            private static Player Biff_Beeston = new Player(103, 150, 56, 68, 41, 60, 55, 69, 57, 406, 19, 66, 7, 9, 14, 13, 10, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x153
            private static Player Lou_Beigh = new Player(79, 130, 42, 53, 63, 52, 68, 53, 60, 391, 34, 39, 14, 11, 9, 7, 15, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x154
            private static Player Marv_Errick = new Player(129, 174, 74, 71, 64, 76, 43, 68, 60, 456, 57, 55, 12, 13, 14, 17, 11, 13, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x155
            private static Player Bob_Whittle = new Player(140, 164, 60, 68, 70, 64, 70, 64, 62, 458, 31, 65, 15, 13, 13, 11, 19, 15, 13, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x156
            private static Player Bert_Neptune = new Player(178, 178, 64, 70, 64, 64, 62, 61, 61, 446, 60, 78, 16, 17, 17, 13, 16, 16, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x157
            private static Player Sol_Crater = new Player(171, 138, 53, 52, 52, 56, 52, 57, 56, 378, 45, 57, 12, 12, 11, 11, 10, 11, 13, 2, 4, 2, 4, 4, 2, 2, 2, 4, 1); // 0x158
            private static Player Percy_Coldstair = new Player(107, 156, 42, 59, 56, 52, 65, 64, 63, 401, 20, 40, 7, 10, 11, 8, 11, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x159
            private static Player Dusky_Sunfield = new Player(112, 122, 59, 56, 69, 51, 42, 60, 61, 398, 31, 36, 15, 11, 19, 9, 11, 7, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x15A
            private static Player Rocky_Shears = new Player(167, 158, 58, 58, 60, 79, 63, 60, 60, 438, 52, 63, 14, 12, 13, 12, 11, 14, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x15B
            private static Player Percy_Stent = new Player(151, 173, 76, 63, 60, 62, 68, 69, 67, 465, 57, 49, 10, 17, 13, 17, 16, 13, 15, 5, 1, 2, 4, 4, 4, 4, 4, 4, 2); // 0x15C
            private static Player Art_Pendragon = new Player(132, 136, 60, 65, 46, 63, 63, 71, 59, 427, 30, 63, 8, 10, 10, 17, 13, 14, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x15D
            private static Player Dom_Ittory = new Player(160, 132, 51, 52, 60, 44, 62, 62, 52, 383, 34, 48, 9, 11, 13, 11, 8, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x15E
            private static Player Chaz_Biggins = new Player(176, 98, 63, 61, 28, 63, 57, 64, 56, 392, 70, 23, 14, 7, 7, 15, 10, 14, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x15F
            private static Player Sly_O_Hands = new Player(158, 176, 56, 72, 79, 79, 45, 61, 69, 461, 49, 48, 12, 14, 12, 17, 13, 11, 14, 5, 1, 2, 1, 5, 2, 5, 2, 1, 3); // 0x160
            private static Player Sean_Lavender = new Player(116, 132, 67, 52, 56, 58, 62, 71, 54, 420, 46, 52, 13, 7, 14, 13, 9, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x161
            private static Player Ace_Server = new Player(151, 168, 76, 69, 63, 78, 46, 77, 68, 477, 56, 55, 13, 12, 14, 14, 10, 10, 13, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x162
            private static Player Horace_Nelson = new Player(92, 142, 65, 56, 53, 57, 56, 71, 59, 417, 31, 53, 17, 9, 13, 15, 10, 11, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x163
            private static Player Rex_George = new Player(189, 157, 68, 68, 60, 60, 62, 67, 66, 451, 58, 66, 15, 16, 15, 15, 15, 15, 16, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x164
            private static Player Philip_Prince = new Player(77, 152, 43, 52, 52, 60, 68, 67, 59, 401, 30, 35, 10, 8, 11, 8, 17, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x165
            private static Player Heath_Rower = new Player(160, 146, 56, 56, 53, 56, 59, 52, 56, 388, 52, 57, 10, 11, 12, 12, 12, 14, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x166
            private static Player Kim_Arite = new Player(132, 150, 55, 68, 53, 79, 61, 55, 61, 432, 36, 47, 9, 7, 9, 17, 8, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x167
            private static Player Jay_Archer = new Player(198, 144, 54, 69, 44, 66, 58, 64, 60, 415, 81, 61, 11, 7, 12, 16, 12, 17, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x168
            private static Player Bo_Ling = new Player(147, 146, 45, 55, 79, 50, 56, 57, 52, 394, 39, 44, 10, 7, 21, 11, 10, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x169
            private static Player Chuck_Hardy = new Player(173, 134, 49, 57, 70, 45, 52, 62, 62, 397, 32, 47, 8, 12, 14, 9, 10, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x16A
            private static Player Ben_Evolent = new Player(169, 154, 68, 52, 60, 60, 52, 59, 52, 403, 60, 74, 6, 15, 14, 13, 15, 15, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x16B
            private static Player Will_Noble = new Player(134, 158, 48, 48, 54, 41, 52, 48, 45, 336, 42, 65, 8, 11, 14, 8, 10, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x16C
            private static Player Jack_Frosty = new Player(178, 166, 65, 70, 64, 65, 67, 60, 68, 459, 27, 25, 5, 6, 6, 4, 7, 6, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x16D
            private static Player Larry_Helps = new Player(77, 158, 46, 54, 57, 59, 60, 54, 55, 385, 25, 53, 10, 8, 8, 11, 18, 13, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x16E
            private static Player Monty_Patten = new Player(162, 192, 63, 60, 63, 61, 52, 54, 60, 413, 49, 55, 13, 10, 10, 12, 12, 13, 13, 4, 1, 4, 4, 4, 4, 4, 4, 4, 1); // 0x16F
            private static Player Chunk_Gorman = new Player(79, 146, 48, 56, 57, 60, 63, 52, 52, 388, 34, 42, 13, 8, 11, 8, 15, 11, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x170
            private static Player Balt_Decker = new Player(169, 174, 56, 46, 47, 60, 75, 61, 67, 412, 51, 51, 11, 13, 6, 13, 17, 15, 12, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x171
            private static Player Drew_Crenshaw = new Player(147, 130, 46, 59, 69, 48, 61, 53, 63, 399, 30, 38, 7, 13, 13, 10, 11, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x172
            private static Player Stan_Trum = new Player(77, 134, 48, 54, 58, 56, 71, 59, 59, 405, 31, 36, 11, 9, 7, 8, 15, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x173
            private static Player Sham_Spike = new Player(156, 140, 60, 58, 52, 56, 55, 56, 58, 395, 54, 65, 15, 14, 13, 17, 15, 17, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x174
            private static Player Rainier_Welkin = new Player(147, 154, 48, 60, 68, 76, 56, 61, 52, 421, 45, 70, 8, 9, 14, 17, 10, 10, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x175
            private static Player Evan_Yielding = new Player(160, 160, 53, 46, 50, 60, 76, 65, 64, 414, 43, 59, 11, 12, 6, 10, 18, 15, 14, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x176
            private static Player Phil_Anthropic = new Player(136, 124, 77, 77, 78, 78, 68, 43, 75, 496, 36, 53, 14, 12, 12, 12, 12, 8, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x177
            private static Player Fane_Club = new Player(138, 128, 45, 50, 44, 69, 48, 43, 49, 348, 34, 47, 10, 7, 10, 10, 9, 9, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x178
            private static Player Slim_Lanky = new Player(118, 142, 44, 36, 35, 58, 66, 55, 63, 357, 44, 53, 7, 7, 6, 10, 15, 11, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x179
            private static Player Pearson_Gaze = new Player(112, 158, 44, 36, 30, 55, 70, 62, 57, 354, 46, 34, 8, 8, 7, 9, 17, 13, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x17A
            private static Player Edward_Albion = new Player(171, 132, 60, 60, 69, 56, 68, 62, 61, 436, 43, 55, 14, 14, 19, 13, 17, 11, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x17B
            private static Player Stu_Dent = new Player(116, 176, 68, 34, 44, 29, 73, 62, 56, 366, 39, 32, 15, 7, 8, 4, 19, 8, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x17C
            private static Player Barry_Straw = new Player(132, 106, 38, 72, 48, 38, 73, 41, 47, 357, 36, 51, 7, 19, 9, 7, 16, 10, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x17D
            private static Player Bobby_Peel = new Player(165, 146, 60, 62, 55, 56, 59, 52, 62, 406, 55, 51, 12, 13, 13, 12, 10, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x17E
            private static Player Dan_Castella = new Player(158, 140, 60, 59, 56, 52, 63, 56, 54, 400, 48, 65, 10, 11, 11, 13, 12, 11, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x17F
            private static Player Bill_Moony = new Player(103, 152, 79, 53, 56, 60, 64, 61, 52, 425, 28, 50, 8, 11, 11, 8, 12, 12, 11, 5, 5, 5, 1, 1, 1, 2, 5, 1, 1); // 0x180
            private static Player Buddy_Goodman = new Player(118, 113, 47, 75, 48, 48, 43, 45, 76, 382, 40, 50, 9, 7, 8, 11, 8, 7, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x181
            private static Player Dex_Territy = new Player(167, 154, 60, 52, 58, 52, 59, 56, 56, 393, 63, 65, 14, 14, 15, 16, 14, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x182
            private static Player Vinny_O_Gaines = new Player(158, 133, 46, 61, 64, 52, 52, 52, 55, 382, 33, 44, 10, 13, 13, 9, 9, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x183
            private static Player Ray_Deo = new Player(81, 158, 60, 52, 52, 54, 52, 61, 55, 386, 38, 36, 13, 9, 11, 17, 10, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x184
            private static Player Archie_Meades = new Player(118, 120, 57, 54, 40, 70, 49, 62, 53, 385, 30, 34, 17, 13, 8, 10, 9, 7, 9, 1, 5, 1, 1, 1, 5, 1, 1, 1, 2); // 0x185
            private static Player Dave_Chaucer = new Player(101, 158, 71, 59, 56, 53, 58, 71, 56, 424, 39, 53, 14, 10, 12, 15, 10, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x186
            private static Player Billy_Blanc = new Player(134, 198, 60, 58, 48, 45, 48, 52, 79, 390, 32, 31, 17, 12, 10, 8, 8, 10, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x187
            private static Player Creed_Craving = new Player(127, 152, 61, 60, 62, 60, 52, 58, 53, 406, 31, 53, 10, 7, 9, 14, 8, 12, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x188
            private static Player Phil_Rosey = new Player(123, 172, 54, 64, 56, 69, 57, 54, 60, 414, 34, 46, 11, 7, 8, 16, 7, 11, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x189
            private static Player Harry_Redcastle = new Player(121, 178, 63, 60, 53, 69, 52, 56, 60, 413, 40, 69, 9, 10, 11, 17, 9, 12, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x18A
            private static Player Sonny_Welkin = new Player(167, 144, 68, 62, 54, 60, 35, 68, 54, 401, 37, 44, 9, 11, 10, 10, 11, 12, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x18B
            private static Player Teddy_Kodiak = new Player(154, 148, 58, 57, 60, 54, 55, 61, 52, 397, 48, 65, 12, 13, 12, 12, 14, 13, 12, 2, 2, 2, 2, 2, 2, 4, 2, 2, 3); // 0x18C
            private static Player Lloyd_Tabb = new Player(83, 130, 41, 52, 62, 56, 62, 59, 63, 395, 24, 40, 10, 8, 10, 8, 17, 10, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x18D
            private static Player Francis_Paine = new Player(116, 137, 47, 60, 52, 56, 60, 56, 62, 393, 20, 47, 11, 10, 11, 7, 15, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x18E
            private static Player Griff_Strummer = new Player(158, 170, 60, 52, 60, 60, 55, 57, 57, 401, 54, 51, 10, 14, 11, 12, 10, 10, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x18F
            private static Player Bryce_Bergman = new Player(165, 140, 45, 61, 59, 60, 64, 69, 60, 418, 75, 44, 10, 19, 11, 10, 12, 17, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x190
            private static Player Fingus_Inky = new Player(85, 136, 58, 71, 48, 64, 55, 63, 52, 411, 21, 61, 11, 9, 11, 15, 11, 13, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x191
            private static Player Walter_Geyser = new Player(96, 132, 63, 68, 42, 60, 58, 60, 53, 404, 30, 50, 9, 9, 10, 16, 11, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x192
            private static Player Les_Knightley = new Player(129, 194, 56, 64, 60, 66, 55, 52, 52, 405, 46, 36, 10, 11, 7, 16, 10, 11, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x193
            private static Player Conor_Abley = new Player(94, 148, 64, 58, 62, 67, 38, 78, 62, 429, 39, 39, 11, 10, 9, 11, 7, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x194
            private static Player Ainsley_Burns = new Player(171, 144, 46, 58, 68, 51, 60, 62, 63, 408, 38, 47, 9, 11, 16, 9, 11, 11, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x195
            private static Player Pete_Grimes = new Player(158, 176, 44, 53, 60, 41, 52, 62, 52, 364, 42, 73, 9, 11, 13, 8, 8, 9, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x196
            private static Player Manny_Steele = new Player(215, 140, 56, 60, 43, 61, 60, 78, 55, 413, 79, 65, 9, 10, 12, 15, 13, 16, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x197
            private static Player Trey_Hugger = new Player(99, 142, 36, 73, 60, 73, 35, 28, 58, 363, 20, 48, 8, 17, 14, 17, 6, 6, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x198
            private static Player Jack_Mate = new Player(136, 153, 62, 68, 61, 69, 53, 60, 56, 429, 39, 39, 10, 11, 10, 16, 10, 11, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x199
            private static Player Mike_Chequer = new Player(151, 132, 63, 54, 54, 53, 55, 53, 56, 388, 50, 49, 11, 13, 13, 14, 10, 13, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x19A
            private static Player Berty_Adman = new Player(129, 136, 48, 52, 56, 59, 71, 62, 55, 403, 20, 33, 11, 9, 7, 9, 17, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x19B
            private static Player Troy_Carr = new Player(169, 180, 56, 56, 63, 63, 53, 61, 63, 415, 61, 66, 13, 17, 17, 13, 15, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x19C
            private static Player Hollis_Ticure = new Player(193, 138, 58, 60, 53, 59, 52, 69, 52, 403, 64, 80, 16, 13, 15, 17, 15, 13, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x19D
            private static Player Guy_Dance = new Player(81, 144, 42, 58, 63, 62, 60, 67, 55, 407, 33, 48, 11, 8, 10, 11, 14, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x19E
            private static Player Jack_Trumper = new Player(171, 174, 40, 58, 68, 44, 57, 57, 52, 376, 34, 77, 10, 10, 14, 11, 8, 10, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x19F
            private static Player John_Corder = new Player(145, 132, 56, 63, 62, 61, 62, 56, 52, 412, 44, 56, 12, 12, 10, 11, 10, 12, 11, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x1A0
            private static Player Nigel_Bramel = new Player(107, 136, 47, 55, 60, 52, 70, 63, 56, 403, 21, 48, 10, 8, 11, 11, 15, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1A1
            private static Player Hank_O_Chief = new Player(129, 110, 58, 62, 48, 45, 46, 56, 58, 373, 32, 24, 17, 14, 7, 11, 10, 8, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1A2
            private static Player Jess_Uplement = new Player(118, 102, 57, 60, 40, 42, 50, 52, 52, 353, 33, 20, 17, 13, 8, 9, 11, 7, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1A3
            private static Player Alec_Smart = new Player(116, 118, 45, 48, 50, 40, 51, 47, 45, 326, 36, 40, 9, 8, 7, 11, 11, 8, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x1A4
            private static Player Rob_Anchor = new Player(204, 144, 61, 57, 74, 53, 61, 71, 55, 432, 26, 43, 16, 9, 10, 14, 8, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x1A5
            private static Player Brent_Cross = new Player(140, 112, 63, 52, 40, 49, 49, 58, 57, 368, 46, 34, 15, 12, 9, 9, 9, 11, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1A6
            private static Player Albert_Wister = new Player(88, 148, 51, 60, 61, 52, 64, 64, 56, 408, 22, 43, 8, 10, 9, 9, 10, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1A7
            private static Player Nev_Erin = new Player(121, 176, 60, 70, 71, 61, 76, 68, 71, 477, 32, 58, 14, 10, 14, 13, 19, 17, 14, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1A8
            private static Player Caz_Yewell = new Player(187, 138, 70, 53, 56, 63, 67, 68, 60, 437, 46, 57, 14, 12, 10, 13, 13, 13, 14, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x1A9
            private static Player Conor_Trail = new Player(103, 136, 60, 60, 49, 70, 55, 76, 59, 429, 18, 55, 10, 8, 14, 17, 14, 16, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x1AA
            private static Player Manuel_Gere = new Player(158, 136, 42, 62, 70, 51, 52, 57, 59, 393, 31, 48, 8, 13, 14, 9, 9, 11, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1AB
            private static Player Per_Hockside = new Player(107, 150, 42, 55, 57, 54, 69, 67, 62, 406, 30, 35, 10, 9, 8, 10, 14, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1AC
            private static Player Lee_Gleagle = new Player(110, 124, 49, 49, 44, 50, 46, 40, 44, 322, 39, 47, 9, 10, 10, 11, 9, 11, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x1AD
            private static Player Paul_Pitcher = new Player(147, 164, 45, 59, 67, 46, 55, 54, 61, 387, 34, 88, 9, 9, 19, 8, 10, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1AE
            private static Player Turner_Fortune = new Player(127, 113, 29, 36, 50, 77, 40, 46, 42, 320, 31, 47, 8, 4, 9, 16, 9, 8, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1AF
            private static Player Walter_Walken = new Player(127, 128, 44, 42, 48, 49, 50, 51, 73, 357, 46, 34, 9, 10, 8, 10, 8, 10, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1B0
            private static Player Sal_Curie = new Player(156, 132, 48, 56, 62, 51, 52, 62, 55, 386, 31, 47, 8, 12, 16, 7, 7, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1B1
            private static Player Silver_Platt = new Player(167, 138, 56, 58, 59, 53, 52, 52, 63, 393, 56, 65, 12, 12, 12, 10, 10, 14, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1B2
            private static Player Nick_Yergrub = new Player(99, 152, 62, 70, 48, 76, 52, 76, 62, 446, 20, 59, 10, 11, 14, 14, 12, 16, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1B3
            private static Player Mal_Inger = new Player(165, 130, 51, 56, 63, 48, 59, 55, 60, 392, 43, 48, 10, 14, 15, 9, 10, 11, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1B4
            private static Player Jim_Cook = new Player(118, 106, 52, 61, 47, 42, 41, 56, 56, 355, 33, 34, 17, 14, 11, 9, 7, 9, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x1B5
            private static Player Gus_Potter = new Player(77, 150, 46, 56, 58, 59, 67, 61, 61, 408, 31, 34, 9, 7, 8, 9, 12, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1B6
            private static Player Handel_Turnon = new Player(132, 128, 56, 52, 44, 44, 51, 60, 60, 367, 31, 36, 15, 14, 10, 11, 8, 11, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x1B7
            private static Player Peter_Malus = new Player(125, 133, 63, 63, 56, 53, 60, 61, 53, 409, 42, 33, 16, 11, 12, 17, 8, 10, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1B8
            private static Player Colin_Lection = new Player(158, 154, 56, 57, 52, 60, 52, 62, 52, 391, 67, 69, 16, 13, 16, 17, 14, 16, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1B9
            private static Player Brock_Twigg = new Player(213, 190, 48, 48, 51, 78, 45, 49, 70, 389, 42, 51, 10, 7, 10, 8, 10, 7, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1BA
            private static Player Paddy_Rise = new Player(123, 174, 56, 69, 60, 66, 56, 60, 60, 427, 45, 39, 8, 7, 11, 17, 7, 14, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1BB
            private static Player Dustin_Westend = new Player(79, 130, 47, 54, 60, 52, 68, 60, 54, 395, 30, 50, 8, 11, 8, 9, 12, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1BC
            private static Player Alfonse_Way = new Player(129, 140, 50, 32, 32, 53, 60, 60, 60, 347, 44, 36, 11, 8, 8, 9, 15, 12, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x1BD
            private static Player Pippin_Flowers = new Player(140, 178, 63, 71, 52, 60, 60, 56, 60, 422, 38, 50, 7, 10, 10, 15, 9, 11, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x1BE
            private static Player Euan_Stamper = new Player(110, 102, 75, 40, 45, 51, 50, 44, 79, 384, 37, 50, 10, 8, 11, 11, 10, 10, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1BF
            private static Player Paddy_Prunus = new Player(125, 116, 52, 60, 48, 53, 48, 61, 63, 385, 34, 24, 13, 10, 7, 8, 9, 10, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1C0
            private static Player Brian_Presser = new Player(134, 168, 59, 68, 56, 65, 57, 55, 63, 423, 34, 35, 8, 7, 7, 15, 9, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1C1
            private static Player Pete_LeGume = new Player(182, 164, 62, 68, 62, 64, 67, 64, 60, 447, 70, 61, 14, 16, 14, 13, 15, 16, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x1C2
            private static Player Shylock_Watson = new Player(121, 118, 43, 42, 41, 45, 40, 44, 49, 304, 40, 42, 11, 11, 8, 9, 11, 11, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x1C3
            private static Player Ed_Ripp = new Player(85, 130, 42, 52, 53, 60, 65, 70, 57, 399, 28, 42, 7, 8, 8, 9, 11, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1C4
            private static Player Hike_Basher = new Player(149, 152, 60, 60, 54, 56, 61, 54, 63, 408, 69, 69, 13, 17, 17, 14, 14, 16, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x1C5
            private static Player Anthony_Phinder = new Player(173, 132, 54, 53, 56, 60, 60, 61, 56, 400, 63, 66, 15, 15, 13, 17, 14, 14, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1C6
            private static Player Duncan_Jump = new Player(209, 120, 40, 48, 48, 40, 43, 76, 48, 343, 94, 38, 9, 8, 9, 11, 10, 20, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x1C7
            private static Player Lucky_Winn = new Player(99, 140, 52, 66, 48, 60, 61, 66, 56, 409, 25, 55, 7, 10, 10, 14, 11, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x1C8
            private static Player Gene_Bates = new Player(184, 156, 60, 63, 61, 60, 35, 64, 56, 399, 75, 48, 7, 11, 8, 14, 7, 20, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1C9
            private static Player Randolf_Finn = new Player(96, 150, 66, 63, 63, 56, 63, 68, 63, 442, 45, 44, 15, 8, 14, 17, 10, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1CA
            private static Player Ron_Away = new Player(132, 154, 49, 29, 32, 55, 67, 60, 60, 352, 39, 34, 11, 9, 7, 9, 14, 12, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1CB
            private static Player Rick_Hatter = new Player(191, 156, 60, 61, 64, 65, 64, 62, 64, 440, 67, 72, 15, 16, 13, 14, 17, 16, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x1CC
            private static Player Grant_Mardy = new Player(121, 113, 60, 55, 40, 42, 40, 56, 60, 353, 39, 24, 14, 13, 9, 10, 10, 9, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x1CD
            private static Player Shawn_Broker = new Player(211, 158, 40, 62, 56, 52, 52, 70, 62, 394, 80, 34, 8, 10, 11, 11, 14, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1CE
            private static Player Anthony_Coyne = new Player(134, 172, 55, 60, 52, 60, 60, 53, 56, 396, 33, 50, 9, 11, 9, 14, 9, 13, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1CF
            private static Player Healey_Proctor = new Player(145, 168, 44, 56, 70, 41, 52, 52, 56, 371, 40, 70, 8, 9, 15, 8, 8, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1D0
            private static Player Ade_Posting = new Player(99, 122, 31, 44, 47, 67, 60, 48, 43, 340, 32, 39, 8, 4, 6, 16, 16, 11, 6, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1D1
            private static Player Doug_Outon = new Player(121, 128, 30, 46, 60, 32, 44, 44, 48, 304, 28, 29, 8, 10, 14, 8, 8, 6, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1D2
            private static Player Ebenezer_Marner = new Player(121, 130, 42, 36, 31, 56, 68, 63, 55, 351, 43, 35, 7, 9, 8, 8, 17, 14, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1D3
            private static Player Davy_Johns = new Player(88, 118, 68, 51, 41, 60, 71, 56, 40, 387, 33, 28, 7, 7, 6, 9, 4, 5, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D4
            private static Player Bos_Horne = new Player(85, 146, 60, 61, 54, 56, 59, 68, 55, 413, 36, 42, 17, 11, 14, 15, 10, 8, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D5
            private static Player Nick_Orner = new Player(156, 156, 41, 46, 40, 42, 53, 58, 56, 336, 38, 33, 11, 17, 15, 17, 7, 10, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1D6
            private static Player Nathin_Gaunt = new Player(79, 140, 40, 56, 52, 61, 76, 52, 61, 398, 22, 44, 12, 11, 10, 7, 20, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1D7
            private static Player Quentin_Quartz = new Player(103, 156, 60, 52, 57, 67, 31, 62, 58, 387, 45, 51, 20, 11, 10, 14, 8, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D8
            private static Player Andrew_Meikle = new Player(165, 168, 48, 56, 61, 48, 63, 53, 62, 391, 31, 72, 10, 9, 19, 11, 10, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1D9
            private static Player Gary_Salmon = new Player(169, 144, 56, 53, 59, 60, 63, 60, 58, 409, 56, 58, 14, 14, 12, 11, 13, 12, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1DA
            private static Player Fontaine_Tapper = new Player(101, 130, 44, 56, 63, 54, 65, 60, 58, 400, 30, 51, 12, 8, 8, 11, 20, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1DB
            private static Player Leon_Lawn = new Player(110, 194, 60, 55, 49, 46, 40, 69, 52, 371, 39, 24, 16, 12, 11, 7, 10, 8, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x1DC
            private static Player Jim_Sweatman = new Player(145, 170, 40, 55, 68, 48, 55, 52, 53, 371, 42, 78, 7, 7, 17, 9, 11, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1DD
            private static Player Cole_Coaker = new Player(90, 132, 47, 52, 60, 52, 62, 59, 58, 390, 20, 50, 10, 9, 8, 10, 15, 13, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1DE
            private static Player Stu_Born = new Player(114, 102, 60, 56, 40, 48, 46, 56, 52, 358, 30, 34, 13, 14, 7, 7, 9, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1DF
            private static Player Romeo_Montague = new Player(173, 158, 57, 60, 63, 60, 56, 61, 55, 412, 69, 70, 14, 15, 16, 17, 13, 17, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1E0
            private static Player Drew_Straitedge = new Player(118, 124, 49, 46, 44, 44, 46, 42, 47, 318, 44, 47, 9, 9, 10, 10, 11, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1E1
            private static Player Dash_Dotter = new Player(96, 142, 51, 52, 61, 52, 65, 62, 58, 401, 18, 36, 7, 9, 7, 8, 14, 10, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1E2
            private static Player Gill_O_Mend = new Player(160, 142, 56, 60, 56, 55, 57, 52, 57, 393, 46, 50, 11, 14, 10, 12, 12, 13, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x1E3
            private static Player Pay_Chance = new Player(173, 141, 59, 56, 53, 59, 60, 56, 56, 399, 62, 68, 15, 15, 16, 16, 17, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x1E4
            private static Player Bill_Aegis = new Player(79, 152, 63, 62, 40, 60, 56, 68, 55, 404, 26, 63, 7, 11, 12, 13, 13, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1E5
            private static Player Tosh_Coach = new Player(99, 96, 34, 70, 39, 78, 37, 32, 32, 322, 33, 28, 8, 7, 6, 5, 8, 8, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1E6
            private static Player Carl_Gnu = new Player(77, 152, 42, 55, 53, 62, 71, 72, 54, 409, 19, 36, 10, 8, 7, 11, 14, 18, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1E7
            private static Player Paul_Sapp = new Player(217, 144, 62, 61, 44, 64, 55, 68, 56, 410, 33, 55, 8, 8, 14, 14, 13, 14, 9, 5, 1, 1, 5, 1, 5, 1, 2, 1, 1); // 0x1E8
            private static Player Macky_Valley = new Player(116, 108, 54, 59, 43, 44, 47, 52, 78, 377, 43, 35, 15, 12, 9, 8, 10, 10, 17, 1, 5, 1, 1, 1, 1, 1, 1, 5, 1); // 0x1E9
            private static Player Troy_Trucker = new Player(77, 156, 66, 53, 63, 58, 60, 79, 52, 431, 32, 42, 15, 11, 12, 16, 10, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1EA
            private static Player Haden_Seek = new Player(88, 138, 41, 63, 54, 54, 70, 63, 62, 407, 25, 40, 14, 10, 10, 11, 17, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1EB
            private static Player Kevin_Doors = new Player(173, 164, 70, 66, 68, 71, 62, 63, 63, 463, 56, 68, 14, 15, 17, 15, 15, 15, 13, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x1EC
            private static Player Skip_Rooter = new Player(182, 138, 61, 55, 61, 61, 58, 67, 61, 424, 54, 42, 14, 11, 13, 15, 9, 10, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1ED
            private static Player Rip_Airman = new Player(94, 134, 48, 52, 54, 53, 65, 66, 59, 397, 20, 40, 10, 11, 11, 9, 13, 12, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1EE
            private static Player Stu_Shiner = new Player(165, 132, 59, 62, 60, 52, 60, 58, 57, 408, 69, 66, 16, 13, 16, 17, 17, 16, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1EF
            private static Player Matt_Matickal = new Player(121, 132, 40, 36, 36, 61, 71, 56, 57, 357, 46, 46, 7, 10, 8, 8, 14, 13, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1F0
            private static Player Philip_Flagg = new Player(193, 148, 40, 29, 32, 53, 60, 33, 60, 307, 63, 53, 9, 8, 5, 10, 19, 5, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1F1
            private static Player Alf_Groundsman = new Player(165, 136, 60, 60, 55, 68, 56, 62, 55, 416, 62, 72, 15, 16, 16, 17, 14, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x1F2
            private static Player Ernie_Riddell = new Player(143, 140, 44, 57, 76, 44, 53, 53, 60, 387, 32, 44, 8, 12, 16, 8, 9, 11, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1F3
            private static Player Len_Stint = new Player(156, 140, 52, 59, 60, 60, 57, 63, 56, 407, 54, 72, 16, 15, 16, 16, 16, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x1F4
            private static Player Holly_Cricket = new Player(118, 156, 61, 70, 48, 63, 63, 67, 56, 428, 31, 55, 11, 9, 12, 15, 14, 15, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1F5
            private static Player Dave_Altair = new Player(213, 136, 61, 63, 57, 58, 53, 69, 60, 421, 66, 39, 15, 9, 10, 15, 9, 11, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1F6
            private static Player Jim_Reed = new Player(123, 112, 45, 45, 42, 53, 54, 46, 48, 333, 32, 36, 6, 5, 7, 7, 12, 11, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x1F7
            private static Player Gwyn_Penn = new Player(165, 176, 49, 57, 71, 43, 58, 53, 61, 392, 37, 80, 9, 11, 15, 10, 11, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1F8
            private static Player Spike_Needle = new Player(151, 130, 42, 32, 39, 60, 71, 59, 54, 357, 48, 47, 9, 8, 8, 10, 16, 12, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1F9
            private static Player Ifan_Tassy = new Player(140, 113, 60, 51, 57, 56, 58, 63, 60, 405, 33, 28, 5, 8, 11, 6, 4, 6, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1FA
            private static Player Eggbert_Heading = new Player(217, 140, 68, 53, 58, 71, 38, 76, 62, 426, 38, 43, 9, 9, 10, 12, 11, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x1FB
            private static Player Pascal_Blaise = new Player(118, 142, 49, 56, 60, 61, 68, 45, 57, 396, 30, 36, 12, 9, 9, 7, 15, 4, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1FC
            private static Player Will_Whist = new Player(138, 138, 61, 36, 30, 52, 62, 54, 53, 348, 40, 46, 11, 9, 7, 11, 16, 10, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1FD
            private static Player Ewan_Liner = new Player(85, 146, 50, 75, 63, 52, 65, 63, 56, 424, 20, 42, 11, 9, 9, 9, 13, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1FE
            private static Player Buster_Locke = new Player(127, 118, 56, 58, 49, 43, 49, 56, 58, 369, 67, 29, 15, 11, 10, 11, 9, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x1FF
            private static Player Rex_Plorer = new Player(110, 141, 48, 53, 58, 63, 65, 60, 53, 400, 28, 51, 12, 9, 8, 8, 16, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x200
            private static Player Webber_Poster = new Player(121, 106, 55, 56, 46, 45, 40, 56, 56, 354, 33, 28, 14, 13, 10, 9, 10, 7, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x201
            private static Player Sid_Parting = new Player(134, 133, 68, 60, 63, 69, 47, 64, 52, 423, 36, 45, 10, 10, 7, 11, 9, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x202
            private static Player Eaton_Rampage = new Player(110, 112, 51, 44, 48, 50, 73, 47, 37, 350, 43, 42, 9, 8, 7, 8, 8, 10, 6, 4, 4, 4, 4, 4, 4, 2, 4, 4, 3); // 0x203
            private static Player Parker_Leaper = new Player(167, 129, 54, 53, 62, 60, 58, 56, 56, 399, 46, 51, 14, 13, 11, 14, 12, 12, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x204
            private static Player Hank_Halberd = new Player(195, 156, 62, 62, 59, 61, 37, 62, 55, 398, 68, 38, 9, 11, 10, 12, 11, 14, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x205
            private static Player Robin_Catching = new Player(132, 112, 48, 49, 51, 48, 78, 49, 47, 370, 37, 50, 8, 10, 7, 9, 18, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x206
            private static Player Trey_Spotter = new Player(149, 132, 47, 54, 61, 51, 51, 44, 52, 360, 22, 64, 7, 6, 12, 8, 8, 6, 6, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x207
            private static Player Onslow_Ball = new Player(85, 146, 58, 69, 47, 70, 61, 63, 60, 428, 33, 62, 8, 7, 10, 13, 13, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x208
            private static Player Tex_Tingle = new Player(132, 121, 40, 51, 54, 45, 60, 44, 45, 339, 32, 32, 8, 6, 7, 4, 13, 10, 4, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x209
            private static Player Sam_Gale = new Player(151, 129, 48, 52, 66, 44, 55, 60, 63, 388, 33, 37, 11, 12, 14, 7, 11, 8, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x20A
            private static Player Ryder_Waverly = new Player(125, 146, 49, 39, 33, 62, 60, 62, 56, 361, 45, 48, 10, 8, 6, 11, 15, 13, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x20B
            private static Player Leaf_Scarlett = new Player(167, 145, 56, 57, 60, 56, 60, 53, 60, 402, 64, 68, 16, 13, 13, 14, 14, 16, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x20C
            private static Player Horace_Coop = new Player(151, 116, 54, 59, 44, 48, 50, 60, 53, 368, 43, 36, 13, 12, 10, 8, 9, 7, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x20D
            private static Player Ness_Lockley = new Player(77, 186, 44, 56, 60, 63, 68, 52, 62, 405, 21, 48, 13, 10, 9, 19, 17, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x20E
            private static Player Olef_Tennant = new Player(94, 198, 62, 54, 68, 60, 52, 28, 57, 381, 27, 96, 12, 12, 14, 14, 14, 8, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x20F
            private static Player Len_Scapp = new Player(127, 150, 41, 36, 33, 56, 74, 56, 63, 359, 37, 43, 9, 10, 5, 11, 16, 10, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x210
            private static Player Monty_Hillary = new Player(88, 146, 42, 56, 59, 63, 65, 64, 52, 401, 27, 42, 11, 7, 8, 9, 13, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x211
            private static Player Penfold_Pulper = new Player(99, 158, 41, 52, 59, 59, 71, 64, 62, 408, 19, 40, 7, 7, 9, 9, 11, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x212
            private static Player Thomas_Cott = new Player(147, 150, 53, 59, 53, 56, 63, 59, 56, 399, 68, 68, 14, 17, 17, 13, 15, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x213
            private static Player Spike_Thorne = new Player(105, 130, 53, 64, 48, 61, 52, 62, 56, 396, 34, 61, 11, 8, 12, 13, 12, 15, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x214
            private static Player Lincoln_Hawking = new Player(173, 154, 57, 52, 62, 73, 54, 63, 60, 421, 69, 68, 16, 16, 16, 14, 16, 16, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x215
            private static Player Ted_Larkin = new Player(94, 136, 60, 59, 62, 63, 62, 70, 58, 434, 34, 39, 16, 9, 12, 15, 11, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x216
            private static Player Madison_Cabinet = new Player(167, 172, 40, 52, 61, 42, 60, 63, 57, 375, 31, 66, 9, 9, 16, 9, 10, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x217
            private static Player Odo_Cologne = new Player(171, 138, 40, 57, 52, 57, 60, 37, 60, 363, 70, 47, 10, 10, 11, 7, 13, 8, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x218
            private static Player Nester_Damus = new Player(143, 156, 63, 60, 63, 61, 53, 54, 56, 410, 44, 58, 12, 10, 13, 12, 12, 12, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x219
            private static Player Herb_Ivore = new Player(156, 152, 56, 61, 60, 61, 59, 57, 60, 414, 44, 53, 12, 13, 12, 14, 12, 12, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x21A
            private static Player Homer_Pidgeon = new Player(213, 130, 60, 60, 56, 52, 60, 77, 56, 421, 37, 44, 16, 9, 14, 15, 8, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x21B
            private static Player Rob_Ottley = new Player(103, 146, 43, 53, 55, 52, 68, 61, 56, 388, 21, 46, 12, 11, 11, 8, 16, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x21C
            private static Player Scott_Springer = new Player(96, 134, 78, 59, 63, 53, 52, 60, 54, 419, 40, 43, 14, 10, 12, 14, 8, 11, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x21D
            private static Player Viv_Grey = new Player(140, 198, 55, 57, 42, 44, 47, 61, 56, 362, 37, 92, 17, 10, 9, 11, 10, 11, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x21E
            private static Player Don_Snow = new Player(200, 130, 60, 58, 60, 64, 35, 64, 61, 402, 42, 43, 10, 8, 9, 12, 9, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x21F
            private static Player Hal_Mullet = new Player(81, 132, 43, 76, 55, 60, 68, 68, 55, 425, 26, 35, 8, 9, 11, 10, 10, 18, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x220
            private static Player Isaiah_Shutt = new Player(107, 134, 64, 68, 54, 60, 52, 56, 52, 406, 46, 43, 17, 10, 12, 15, 11, 8, 11, 5, 1, 2, 1, 1, 2, 2, 2, 1, 1); // 0x221
            private static Player Ace_Irvin = new Player(151, 172, 43, 52, 65, 51, 55, 60, 63, 389, 32, 78, 9, 10, 17, 7, 8, 11, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x222
            private static Player Spike_Pitt = new Player(149, 132, 60, 52, 55, 57, 61, 54, 63, 402, 38, 38, 7, 7, 10, 8, 10, 11, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x223
            private static Player Innes_Caving = new Player(147, 140, 44, 42, 48, 57, 69, 57, 56, 373, 36, 44, 11, 8, 6, 10, 15, 12, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x224
            private static Player Keanu_Dell = new Player(160, 142, 46, 55, 68, 51, 61, 52, 29, 362, 40, 40, 9, 11, 17, 8, 11, 9, 6, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x225
            private static Player Casey_Novak = new Player(149, 140, 60, 64, 51, 69, 57, 62, 63, 426, 44, 65, 7, 11, 14, 15, 12, 17, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x226
            private static Player Ed_Halley = new Player(103, 146, 44, 39, 29, 54, 79, 30, 56, 331, 33, 46, 11, 10, 8, 11, 20, 6, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x227
            private static Player Burt_Mocking = new Player(134, 190, 61, 61, 51, 51, 45, 57, 58, 384, 37, 27, 17, 13, 8, 10, 11, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x228
            private static Player Oscar_Petty = new Player(129, 156, 76, 71, 63, 70, 44, 78, 82, 484, 56, 54, 10, 11, 14, 17, 14, 12, 11, 5, 1, 2, 1, 1, 2, 5, 2, 5, 1); // 0x229
            private static Player Waite_Forrit = new Player(165, 140, 61, 55, 59, 58, 59, 68, 59, 419, 55, 34, 16, 9, 12, 16, 10, 14, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x22A
            private static Player Bennett_Byers = new Player(96, 134, 57, 63, 48, 68, 52, 60, 54, 402, 21, 54, 9, 11, 12, 13, 12, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x22B
            private static Player Mo_Eisner = new Player(101, 134, 48, 56, 61, 56, 66, 60, 62, 409, 26, 51, 11, 11, 10, 11, 17, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x22C
            private static Player Miles_Seaford = new Player(125, 150, 40, 35, 29, 60, 70, 52, 56, 342, 36, 38, 10, 10, 7, 10, 17, 13, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x22D
            private static Player Sayer_Lemon = new Player(167, 144, 52, 61, 54, 52, 63, 59, 53, 394, 57, 77, 14, 16, 13, 14, 15, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x22E
            private static Player Carey_Ginu = new Player(88, 132, 40, 52, 60, 62, 78, 55, 60, 407, 33, 34, 14, 7, 7, 8, 16, 11, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x22F
            private static Player Cass_Crocker = new Player(125, 146, 68, 51, 64, 38, 44, 40, 44, 349, 24, 61, 7, 8, 10, 6, 7, 8, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x230
            private static Player Paul_Downs = new Player(173, 194, 48, 52, 71, 41, 53, 57, 62, 384, 42, 34, 9, 13, 17, 8, 11, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x231
            private static Player Darrel_Jeeling = new Player(173, 150, 47, 60, 68, 46, 58, 59, 53, 391, 36, 47, 10, 14, 15, 11, 11, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x232
            private static Player Nobby_Shinn = new Player(204, 194, 57, 56, 50, 41, 48, 58, 52, 362, 44, 27, 17, 12, 11, 11, 10, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x233
            private static Player Theo_Broma = new Player(140, 128, 52, 54, 49, 49, 41, 55, 53, 353, 30, 25, 17, 10, 10, 10, 8, 7, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x234
            private static Player Ramsey_Faroe = new Player(217, 82, 37, 77, 32, 71, 30, 79, 34, 360, 32, 25, 5, 8, 7, 4, 7, 5, 7, 4, 1, 1, 4, 1, 4, 1, 4, 1, 1); // 0x235
            private static Player Buster_Chopps = new Player(169, 92, 59, 56, 57, 59, 58, 60, 79, 428, 58, 39, 12, 13, 13, 12, 12, 12, 14, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1); // 0x236
            private static Player Vince_Bull = new Player(112, 133, 55, 56, 52, 60, 64, 64, 57, 408, 26, 33, 7, 7, 10, 10, 11, 11, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x237
            private static Player Pat_Maclean = new Player(167, 168, 63, 64, 62, 69, 60, 60, 68, 446, 58, 50, 11, 10, 13, 12, 14, 13, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x238
            private static Player Walter_Card = new Player(79, 186, 32, 30, 79, 33, 39, 36, 35, 284, 20, 32, 5, 8, 6, 4, 7, 4, 5, 1, 4, 1, 1, 4, 1, 1, 1, 1, 1); // 0x239
            private static Player Derek_Terr = new Player(110, 138, 50, 32, 31, 61, 77, 58, 59, 368, 37, 36, 8, 11, 6, 10, 13, 14, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x23A
            private static Player Alton_Oldhat = new Player(121, 104, 60, 62, 48, 40, 47, 60, 62, 379, 31, 36, 14, 14, 9, 10, 9, 11, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x23B
            private static Player Cal_Cooler = new Player(191, 152, 68, 56, 61, 60, 55, 69, 57, 426, 55, 66, 10, 13, 12, 11, 12, 10, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x23C
            private static Player Tom_Felix = new Player(143, 150, 54, 60, 71, 63, 71, 61, 59, 439, 55, 59, 11, 10, 18, 13, 18, 14, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x23D
            private static Player Terry_Orr = new Player(217, 126, 50, 43, 40, 44, 71, 79, 68, 395, 39, 42, 11, 8, 7, 11, 8, 9, 7, 5, 1, 1, 1, 1, 1, 1, 2, 1, 1); // 0x23E
            private static Player Rudolph_Rainder = new Player(132, 134, 48, 33, 38, 56, 67, 55, 58, 355, 36, 43, 8, 9, 7, 11, 17, 10, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x23F
            private static Player Nick_Swagg = new Player(143, 149, 68, 69, 71, 64, 64, 64, 60, 460, 48, 66, 12, 13, 16, 17, 15, 15, 14, 5, 1, 2, 4, 4, 4, 4, 4, 4, 2); // 0x240
            private static Player Hal_Leeward = new Player(160, 138, 55, 71, 75, 56, 58, 63, 56, 434, 51, 55, 12, 13, 14, 14, 12, 14, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x241
            private static Player Arthur_Dox = new Player(81, 144, 60, 67, 40, 66, 60, 68, 55, 416, 32, 50, 11, 10, 13, 14, 12, 17, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x242
            private static Player Reese_Ickle = new Player(169, 142, 53, 60, 62, 58, 52, 61, 54, 400, 60, 74, 17, 13, 17, 16, 17, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x243
            private static Player Finn_Attick = new Player(182, 178, 61, 61, 68, 69, 60, 70, 65, 454, 70, 80, 14, 16, 14, 16, 15, 16, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x244
            private static Player Col_Lector = new Player(121, 166, 55, 71, 59, 64, 57, 58, 55, 419, 44, 73, 7, 9, 10, 14, 7, 11, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x245
            private static Player Crispin_Shooter = new Player(134, 198, 32, 46, 72, 29, 51, 40, 51, 321, 32, 48, 6, 6, 17, 4, 8, 5, 6, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x246
            private static Player Stu_Perstitious = new Player(147, 170, 40, 56, 69, 40, 63, 53, 53, 374, 31, 73, 10, 10, 17, 8, 9, 10, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x247
            private static Player Ashley_Fay = new Player(123, 100, 62, 56, 40, 51, 40, 57, 52, 358, 46, 39, 14, 11, 8, 7, 7, 11, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x248
            private static Player Luke_Raffles = new Player(107, 154, 62, 59, 56, 52, 63, 68, 60, 420, 45, 40, 15, 8, 13, 16, 11, 10, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x249
            private static Player Stu_Helmsley = new Player(151, 144, 56, 53, 62, 56, 63, 60, 58, 408, 55, 77, 14, 17, 15, 14, 17, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x24A
            private static Player Terrence_Anthem = new Player(92, 158, 63, 55, 56, 60, 63, 64, 57, 418, 36, 50, 15, 8, 13, 14, 7, 10, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x24B
            private static Player Gene_Bottle = new Player(83, 138, 62, 60, 40, 68, 52, 69, 52, 403, 21, 50, 7, 9, 14, 14, 13, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x24C
            private static Player Sam_O_Reilly = new Player(118, 104, 63, 54, 44, 44, 41, 55, 56, 357, 32, 27, 17, 12, 10, 8, 9, 11, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x24D
            private static Player Ches_Nutcracker = new Player(88, 92, 71, 77, 69, 71, 78, 28, 70, 464, 19, 35, 14, 12, 12, 12, 12, 4, 14, 1, 1, 2, 2, 2, 2, 2, 1, 2, 1); // 0x24E
            private static Player Victor_Grand = new Player(94, 158, 66, 53, 60, 52, 59, 60, 53, 403, 40, 50, 14, 11, 13, 15, 10, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x24F
            private static Player Ant_Hophila = new Player(94, 138, 49, 59, 55, 52, 71, 59, 59, 404, 31, 35, 13, 8, 11, 8, 15, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x250
            private static Player Hunter_Glory = new Player(138, 176, 62, 70, 63, 71, 53, 55, 60, 434, 37, 89, 7, 9, 9, 15, 9, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x251
            private static Player Joe_Rassock = new Player(154, 165, 44, 52, 66, 48, 60, 52, 60, 382, 46, 70, 10, 10, 16, 11, 11, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x252
            private static Player Patch_Borgnine = new Player(92, 115, 32, 45, 51, 44, 53, 50, 44, 319, 33, 25, 9, 7, 8, 6, 12, 10, 6, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x253
            private static Player Ted_Fast = new Player(99, 130, 52, 64, 42, 70, 53, 61, 59, 401, 30, 58, 10, 10, 14, 17, 14, 13, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x254
            private static Player Clay_Modlin = new Player(209, 154, 63, 61, 61, 62, 36, 65, 52, 400, 75, 46, 16, 10, 12, 13, 10, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x255
            private static Player Alan_Mode = new Player(125, 120, 56, 58, 48, 40, 47, 63, 62, 374, 42, 20, 15, 12, 8, 9, 11, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x256
            private static Player Harry_Harper = new Player(103, 132, 43, 52, 60, 60, 60, 56, 52, 383, 20, 43, 10, 8, 8, 10, 17, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x257
            private static Player Pascal_Richter = new Player(167, 138, 51, 60, 62, 45, 52, 60, 57, 387, 46, 43, 8, 10, 20, 8, 9, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x258
            private static Player Beau_Fort = new Player(145, 137, 48, 48, 45, 60, 68, 52, 54, 375, 32, 40, 8, 11, 6, 10, 13, 12, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x259
            private static Player Reid_Scarlet = new Player(94, 148, 61, 62, 50, 69, 54, 64, 57, 417, 19, 63, 7, 11, 10, 17, 11, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x25A
            private static Player Joe_Lamkin = new Player(162, 152, 52, 60, 56, 53, 62, 58, 56, 397, 62, 66, 15, 15, 16, 15, 17, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x25B
            private static Player Dylan_Magpie = new Player(83, 156, 48, 52, 58, 59, 74, 66, 57, 414, 34, 53, 8, 11, 7, 8, 12, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x25C
            private static Player Gil_Rivers = new Player(114, 196, 54, 61, 55, 63, 61, 59, 59, 412, 43, 48, 8, 8, 10, 13, 8, 10, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x25D
            private static Player Des_Tiny = new Player(171, 156, 52, 53, 53, 59, 53, 63, 62, 395, 55, 76, 16, 16, 13, 14, 17, 13, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x25E
            private static Player Saul_Dowd = new Player(147, 130, 52, 56, 58, 54, 61, 53, 63, 397, 42, 51, 10, 13, 11, 14, 14, 12, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x25F
            private static Player Kit_Chapman = new Player(125, 153, 69, 59, 57, 54, 53, 62, 61, 415, 37, 47, 17, 11, 11, 17, 9, 9, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x260
            private static Player Fry_Vollity = new Player(88, 150, 66, 52, 52, 54, 61, 65, 56, 406, 31, 48, 13, 9, 14, 16, 9, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x261
            private static Player Clark_Roach = new Player(85, 144, 66, 54, 57, 60, 36, 63, 56, 392, 45, 35, 8, 11, 11, 12, 8, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x262
            private static Player Samuel_Peeps = new Player(191, 138, 55, 68, 40, 67, 60, 62, 56, 408, 67, 48, 9, 11, 13, 15, 11, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x263
            private static Player Dai_Hart = new Player(81, 90, 36, 39, 36, 36, 39, 36, 28, 250, 30, 31, 7, 8, 5, 8, 6, 4, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x264
            private static Player Horty_Courture = new Player(103, 126, 29, 48, 43, 48, 60, 47, 42, 317, 30, 21, 7, 8, 5, 7, 11, 10, 6, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x265
            private static Player Bob_Baggum = new Player(149, 156, 49, 53, 66, 62, 56, 54, 62, 402, 38, 40, 9, 13, 14, 8, 8, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x266
            private static Player Ollie_Twister = new Player(158, 142, 59, 53, 60, 52, 52, 53, 60, 389, 48, 61, 14, 12, 14, 12, 14, 12, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x267
            private static Player Fred_Makepeace = new Player(88, 115, 40, 63, 29, 76, 42, 55, 40, 345, 22, 50, 6, 6, 9, 12, 7, 11, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x268
            private static Player Walker_Sleep = new Player(149, 158, 63, 61, 62, 56, 52, 52, 60, 406, 48, 54, 10, 12, 11, 13, 13, 10, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x269
            private static Player Sean_Trawler = new Player(173, 144, 57, 60, 62, 54, 52, 65, 54, 404, 56, 74, 15, 14, 13, 15, 13, 15, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x26A
            private static Player Ken_Sewer = new Player(116, 108, 45, 47, 44, 73, 44, 46, 48, 347, 34, 39, 8, 7, 9, 9, 9, 7, 7, 2, 2, 2, 2, 2, 4, 2, 2, 2, 2); // 0x26B
            private static Player Bamber_Shoot = new Player(167, 178, 43, 63, 65, 44, 52, 58, 58, 383, 42, 84, 10, 9, 15, 7, 9, 7, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x26C
            private static Player Sly_Winker = new Player(125, 156, 48, 34, 28, 62, 72, 52, 52, 348, 38, 53, 8, 9, 8, 9, 13, 11, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x26D
            private static Player Teller_Scoap = new Player(195, 142, 49, 60, 56, 62, 70, 71, 52, 420, 68, 39, 11, 8, 10, 10, 12, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x26E
            private static Player Sam_Firman = new Player(90, 144, 60, 54, 60, 57, 52, 67, 52, 402, 38, 36, 15, 9, 14, 13, 10, 8, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x26F
            private static Player Bear_Turnbull = new Player(77, 148, 51, 54, 60, 59, 62, 60, 52, 398, 28, 50, 11, 10, 9, 7, 18, 14, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x270
            private static Player Tabor_Drummond = new Player(114, 146, 40, 34, 29, 55, 61, 58, 57, 334, 45, 39, 9, 7, 7, 11, 17, 13, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x271
            private static Player Brook_Atwater = new Player(151, 148, 57, 60, 54, 56, 53, 60, 59, 399, 56, 66, 15, 15, 14, 16, 13, 17, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x272
            private static Player Ike_Doerflinger = new Player(138, 152, 53, 60, 58, 61, 52, 56, 52, 392, 33, 36, 9, 11, 7, 13, 9, 12, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x273
            private static Player Aessop_Fabel = new Player(105, 156, 64, 54, 53, 53, 61, 63, 60, 408, 36, 38, 16, 7, 10, 15, 11, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x274
            private static Player Grant_Slammer = new Player(149, 152, 48, 57, 63, 43, 57, 54, 58, 380, 43, 46, 9, 12, 16, 10, 9, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x275
            private static Player Robin_Cruise = new Player(103, 156, 64, 58, 55, 68, 32, 61, 56, 394, 46, 35, 7, 9, 11, 11, 10, 11, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x276
            private static Player Mark_Perfect = new Player(92, 140, 44, 60, 61, 60, 68, 65, 62, 420, 31, 46, 7, 8, 9, 11, 11, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x277
            private static Player Rolly_Kerr = new Player(158, 134, 44, 62, 64, 45, 77, 52, 56, 400, 45, 38, 9, 13, 17, 9, 13, 11, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x278
            private static Player Moses_Pumper = new Player(85, 138, 63, 67, 46, 70, 60, 68, 54, 428, 18, 58, 11, 7, 13, 16, 11, 15, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x279
            private static Player Knight_Reader = new Player(123, 106, 44, 48, 46, 72, 51, 49, 47, 357, 39, 44, 8, 10, 11, 10, 6, 11, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x27A
            private static Player Cash_Barganier = new Player(167, 156, 43, 35, 38, 52, 76, 37, 61, 342, 55, 50, 10, 10, 5, 11, 14, 8, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x27B
            private static Player Brendan_Branch = new Player(79, 142, 44, 58, 60, 61, 68, 56, 55, 402, 20, 36, 11, 11, 11, 10, 16, 10, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x27C
            private static Player Clark_Rain = new Player(156, 152, 44, 60, 69, 42, 59, 52, 53, 379, 34, 39, 9, 12, 17, 11, 8, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x27D
            private static Player Luther_Rio = new Player(101, 142, 46, 56, 55, 52, 64, 69, 60, 402, 22, 53, 9, 10, 11, 10, 10, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x27E
            private static Player Florian_Hutter = new Player(165, 196, 55, 54, 52, 56, 59, 62, 57, 395, 51, 89, 10, 13, 13, 12, 11, 11, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x27F
            private static Player Scamp_Shrimplin = new Player(156, 144, 47, 58, 68, 45, 52, 53, 60, 383, 31, 51, 8, 14, 15, 9, 11, 7, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x280
            private static Player Adam_Nesiac = new Player(158, 78, 68, 70, 55, 76, 52, 61, 55, 437, 45, 66, 13, 12, 11, 11, 14, 14, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x281
            private static Player Rab_Acus = new Player(77, 196, 48, 63, 53, 52, 64, 57, 58, 395, 20, 39, 13, 8, 11, 9, 15, 12, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x282
            private static Player Chris_Miles = new Player(129, 190, 58, 69, 60, 60, 52, 57, 56, 412, 44, 38, 9, 7, 10, 17, 10, 12, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x283
            private static Player Shemmy_Ramis = new Player(173, 130, 60, 60, 60, 60, 62, 63, 56, 421, 45, 44, 13, 9, 13, 14, 8, 16, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x284
            private static Player Lon_Grainger = new Player(213, 146, 60, 52, 55, 52, 63, 72, 60, 414, 62, 51, 15, 8, 10, 15, 10, 16, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x285
            private static Player Manny_Atom = new Player(213, 148, 67, 59, 54, 68, 64, 61, 54, 427, 73, 43, 8, 9, 9, 13, 14, 13, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x286
            private static Player Bill_Tardy = new Player(107, 138, 63, 63, 56, 61, 52, 60, 59, 414, 32, 43, 14, 9, 13, 13, 9, 11, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x287
            private static Player Fox_Copier = new Player(147, 200, 60, 52, 56, 54, 53, 56, 60, 391, 60, 93, 13, 15, 13, 13, 16, 17, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x288
            private static Player Cletus_Badden = new Player(173, 154, 58, 56, 54, 53, 56, 63, 56, 396, 62, 61, 14, 16, 16, 16, 16, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x289
            private static Player Skip_Sofrenic = new Player(217, 146, 60, 66, 49, 61, 54, 79, 61, 430, 82, 59, 11, 7, 12, 13, 12, 21, 11, 5, 1, 1, 5, 1, 5, 1, 5, 1, 1); // 0x28A
            private static Player Mat_Char = new Player(83, 142, 40, 58, 52, 55, 70, 54, 62, 391, 25, 34, 12, 9, 7, 9, 15, 13, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x28B
            private static Player Trey_Cultivator = new Player(169, 168, 42, 56, 73, 51, 61, 62, 60, 405, 42, 74, 9, 8, 14, 11, 11, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x28C
            private static Player Vinny_Trioquist = new Player(125, 102, 60, 52, 45, 45, 40, 57, 54, 353, 38, 29, 15, 13, 10, 11, 9, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x28D
            private static Player Ton_Nino = new Player(151, 150, 66, 60, 63, 56, 55, 71, 63, 434, 48, 28, 18, 15, 11, 14, 11, 12, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x28E
            private static Player Oscar_Esher = new Player(81, 94, 35, 31, 28, 36, 38, 32, 32, 232, 27, 20, 8, 8, 8, 6, 6, 8, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x28F
            private static Player Saul_Searcher = new Player(83, 150, 46, 59, 58, 62, 66, 52, 54, 397, 26, 43, 14, 10, 7, 8, 15, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x290
            private static Player Gerry_Attrick = new Player(96, 142, 60, 65, 44, 70, 62, 60, 60, 421, 27, 53, 10, 11, 12, 16, 12, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x291
            private static Player Adam_Icklock = new Player(138, 128, 45, 44, 42, 48, 42, 42, 44, 307, 40, 40, 8, 9, 7, 8, 9, 7, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x292
            private static Player Sol_Stiss = new Player(173, 166, 47, 62, 64, 40, 61, 62, 52, 388, 44, 76, 9, 8, 13, 9, 7, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x293
            private static Player Des_Ainer = new Player(160, 158, 71, 60, 61, 63, 34, 60, 59, 408, 67, 69, 15, 15, 13, 14, 5, 16, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x294
            private static Player Homer_Sockshell = new Player(147, 173, 60, 64, 55, 69, 53, 61, 62, 424, 33, 52, 11, 9, 8, 16, 9, 13, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x295
            private static Player Harley_Trotter = new Player(112, 141, 70, 56, 56, 59, 61, 71, 54, 427, 40, 43, 15, 10, 11, 16, 10, 11, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x296
            private static Player Mark_Skidfree = new Player(138, 132, 60, 63, 59, 62, 48, 71, 58, 421, 34, 41, 11, 9, 8, 11, 10, 8, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x297
            private static Player Del_Iverryboy = new Player(160, 136, 54, 55, 64, 46, 54, 54, 57, 384, 44, 52, 7, 14, 15, 8, 9, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x298
            private static Player Scean_Spector = new Player(138, 154, 47, 30, 28, 56, 62, 56, 60, 339, 46, 35, 8, 11, 4, 10, 15, 11, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x299
            private static Player Nick_Knack = new Player(151, 133, 52, 54, 68, 48, 53, 57, 60, 392, 38, 44, 7, 12, 14, 8, 10, 7, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x29A
            private static Player Dusty_Rellicks = new Player(90, 134, 48, 60, 60, 56, 72, 60, 52, 408, 19, 43, 7, 9, 10, 9, 11, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x29B
            private static Player Sandy_Insolls = new Player(204, 133, 44, 40, 46, 52, 66, 70, 57, 375, 74, 41, 9, 10, 5, 10, 13, 18, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x29C
            private static Player Gregory_Bones = new Player(140, 129, 49, 60, 53, 60, 68, 66, 63, 419, 31, 45, 7, 9, 10, 9, 13, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x29D
            private static Player Loughrey_Mose = new Player(143, 178, 77, 69, 62, 52, 52, 73, 61, 446, 43, 39, 15, 13, 11, 11, 14, 12, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x29E
            private static Player Willow_Withers = new Player(90, 152, 42, 56, 59, 55, 60, 62, 76, 410, 22, 46, 11, 7, 8, 10, 14, 10, 19, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x29F
            private static Player Winn_deBreeze = new Player(145, 158, 62, 52, 53, 60, 52, 52, 60, 391, 52, 55, 12, 11, 12, 14, 12, 12, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2A0
            private static Player Buster_Clout = new Player(112, 156, 60, 62, 63, 69, 59, 56, 63, 432, 37, 39, 9, 16, 9, 13, 10, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2A1
            private static Player Errol_Lorre = new Player(154, 188, 60, 63, 53, 56, 52, 61, 58, 403, 31, 51, 9, 10, 8, 9, 11, 9, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x2A2
            private static Player Fred_Ferrell = new Player(217, 130, 61, 52, 59, 64, 32, 77, 56, 401, 39, 50, 9, 10, 11, 10, 10, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2A3
            private static Player Rod_Headstock = new Player(129, 106, 59, 59, 41, 44, 42, 59, 56, 360, 45, 28, 17, 14, 8, 8, 11, 10, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2A4
            private static Player Tim_Piece = new Player(156, 144, 47, 61, 54, 60, 66, 60, 62, 410, 50, 38, 12, 8, 9, 8, 15, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2A5
            private static Player Patrick_Edie = new Player(173, 140, 51, 58, 72, 40, 60, 56, 53, 390, 36, 50, 8, 11, 14, 10, 8, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2A6
            private static Player Art_Teest = new Player(94, 138, 53, 64, 50, 71, 56, 64, 52, 410, 24, 63, 8, 11, 14, 13, 12, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2A7
            private static Player Bill_Mumm = new Player(195, 168, 55, 76, 68, 70, 48, 72, 68, 457, 49, 48, 17, 12, 14, 16, 14, 17, 12, 4, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x2A8
            private static Player Luke_O_Cyte = new Player(94, 152, 61, 52, 54, 65, 36, 62, 58, 388, 37, 46, 8, 7, 9, 11, 8, 9, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2A9
            private static Player Ernest_Byer = new Player(211, 178, 56, 57, 52, 57, 61, 78, 61, 422, 42, 61, 14, 13, 14, 10, 12, 14, 13, 2, 2, 4, 4, 4, 4, 4, 2, 4, 1); // 0x2AA
            private static Player Isaac_Goss = new Player(145, 156, 63, 52, 57, 53, 54, 58, 56, 393, 49, 59, 12, 10, 13, 11, 12, 13, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x2AB
            private static Player Walter_Poseur = new Player(90, 146, 44, 61, 63, 61, 68, 60, 55, 412, 20, 44, 11, 8, 9, 9, 13, 13, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2AC
            private static Player Andy_Roff = new Player(103, 130, 52, 71, 45, 60, 60, 69, 54, 411, 25, 58, 10, 10, 12, 15, 14, 16, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2AD
            private static Player Ashley_Dale = new Player(187, 160, 54, 60, 78, 60, 70, 61, 68, 451, 51, 63, 11, 13, 17, 12, 12, 12, 12, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2AE
            private static Player Rich_Cave = new Player(81, 156, 44, 63, 59, 56, 63, 71, 63, 419, 19, 42, 7, 9, 8, 10, 13, 10, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x2AF
            private static Player Taka_Tanaka = new Player(83, 144, 62, 57, 55, 63, 33, 67, 58, 395, 43, 40, 8, 11, 8, 17, 7, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B0
            private static Player Manny_Carbs = new Player(151, 140, 50, 55, 68, 42, 53, 59, 54, 381, 42, 35, 7, 12, 16, 8, 10, 8, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2B1
            private static Player Al_Reddie = new Player(173, 174, 49, 53, 60, 50, 63, 63, 56, 394, 33, 68, 9, 13, 16, 7, 10, 9, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2B2
            private static Player Rush_Tooset = new Player(92, 134, 69, 52, 62, 63, 54, 66, 53, 419, 36, 46, 16, 11, 12, 17, 9, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2B3
            private static Player Rod_Opsin = new Player(173, 144, 61, 52, 58, 52, 56, 71, 60, 410, 62, 48, 14, 8, 12, 13, 10, 11, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B4
            private static Player Peyton_Pope = new Player(105, 148, 60, 62, 52, 58, 53, 62, 61, 408, 46, 34, 17, 7, 12, 15, 11, 8, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B5
            private static Player Drew_Straws = new Player(160, 132, 60, 52, 55, 55, 62, 58, 52, 394, 67, 66, 13, 13, 16, 13, 16, 13, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x2B6
            private static Player Trey_Dalbum = new Player(112, 126, 52, 54, 41, 49, 45, 62, 60, 363, 40, 32, 15, 11, 9, 8, 9, 8, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2B7
            private static Player Harly_Profett = new Player(103, 152, 61, 60, 61, 64, 32, 63, 59, 400, 43, 39, 11, 11, 8, 13, 8, 15, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x2B8
            private static Player Hank_O_Buff = new Player(112, 137, 46, 61, 60, 62, 66, 67, 52, 414, 20, 47, 7, 10, 10, 10, 12, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2B9
            private static Player Ash_Cloud = new Player(92, 136, 40, 59, 61, 62, 61, 70, 52, 405, 18, 48, 7, 8, 8, 11, 11, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2BA
            private static Player Stan_Dupp = new Player(191, 134, 58, 65, 47, 67, 53, 69, 54, 413, 43, 47, 9, 9, 14, 15, 13, 15, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2BB
            private static Player Max_Bright = new Player(147, 133, 50, 44, 41, 55, 67, 52, 58, 367, 30, 45, 9, 7, 5, 7, 13, 12, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x2BC
            private static Player Bill_Phee = new Player(99, 130, 70, 52, 52, 60, 60, 69, 60, 423, 33, 51, 17, 10, 11, 14, 9, 11, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2BD
            private static Player Lee_Figreene = new Player(151, 156, 42, 52, 64, 44, 63, 55, 56, 376, 45, 35, 10, 11, 16, 8, 9, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x2BE
            private static Player Den_Taligene = new Player(129, 122, 72, 49, 50, 48, 50, 40, 70, 379, 36, 44, 11, 8, 9, 8, 9, 9, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2BF
            private static Player Adam_Hesive = new Player(136, 150, 52, 71, 56, 60, 62, 60, 53, 414, 40, 44, 11, 21, 9, 21, 10, 14, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C0
            private static Player Mel_Lowe = new Player(134, 160, 67, 77, 59, 74, 60, 77, 66, 480, 26, 72, 10, 10, 14, 20, 16, 20, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C1
            private static Player Rip_Winkle = new Player(96, 140, 67, 64, 59, 64, 34, 71, 57, 416, 31, 47, 11, 14, 9, 13, 8, 7, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2C2
            private static Player Ben_deLimms = new Player(107, 144, 45, 60, 58, 58, 62, 56, 52, 391, 34, 50, 13, 11, 9, 9, 13, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2C3
            private static Player Pauly_Ontology = new Player(118, 148, 41, 31, 34, 54, 62, 63, 54, 339, 42, 40, 8, 10, 6, 9, 13, 11, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2C4
            private static Player Walter_Mendip = new Player(116, 102, 61, 62, 40, 51, 42, 54, 59, 369, 38, 27, 15, 12, 10, 7, 7, 11, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x2C5
            private static Player Bud_Hunter = new Player(134, 132, 47, 56, 59, 52, 63, 64, 56, 397, 22, 51, 11, 10, 10, 8, 10, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2C6
            private static Player Sonny_Rentman = new Player(118, 178, 56, 71, 60, 69, 62, 63, 57, 438, 42, 34, 9, 10, 8, 16, 8, 13, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C7
            private static Player Cam_Vass = new Player(154, 148, 43, 60, 61, 45, 52, 61, 52, 374, 31, 46, 7, 12, 16, 10, 7, 9, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2C8
            private static Player Shay_Chez = new Player(134, 156, 56, 66, 59, 61, 63, 52, 63, 420, 44, 46, 8, 9, 9, 13, 9, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C9
            private static Player Cory_Andish = new Player(134, 136, 59, 70, 47, 69, 62, 62, 57, 426, 30, 60, 8, 8, 14, 17, 12, 16, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CA
            private static Player Glen_Adeer = new Player(132, 156, 62, 61, 60, 67, 55, 56, 56, 417, 40, 36, 8, 8, 7, 15, 10, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CB
            private static Player Norry_Sheets = new Player(83, 146, 57, 68, 43, 71, 56, 60, 60, 415, 31, 62, 10, 11, 12, 14, 12, 16, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CC
            private static Player Lou_Paster = new Player(193, 196, 58, 62, 63, 56, 60, 70, 55, 424, 49, 55, 12, 12, 11, 12, 13, 11, 11, 2, 2, 4, 4, 4, 4, 4, 2, 4, 1); // 0x2CD
            private static Player Aran_Cheeks = new Player(154, 130, 50, 63, 64, 42, 57, 63, 62, 401, 37, 35, 10, 13, 17, 11, 8, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2CE
            private static Player Abe_Seiler = new Player(77, 144, 70, 61, 60, 54, 54, 60, 52, 411, 45, 40, 14, 10, 14, 16, 9, 8, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2CF
            private static Player Al_Urgy = new Player(101, 130, 62, 68, 46, 60, 55, 67, 61, 419, 18, 61, 9, 11, 12, 15, 11, 16, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2D0
            private static Player Conn_Pass = new Player(160, 154, 45, 61, 76, 41, 54, 55, 56, 388, 45, 77, 11, 9, 15, 11, 9, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2D1
            private static Player Heath_Cover = new Player(145, 113, 54, 45, 51, 49, 47, 44, 52, 342, 34, 49, 10, 10, 10, 11, 9, 7, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x2D2
            private static Player Mack_Ramey = new Player(125, 102, 60, 53, 48, 44, 48, 61, 52, 366, 33, 36, 14, 13, 8, 10, 11, 9, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2D3
            private static Player Miles_Ryan = new Player(171, 174, 59, 48, 46, 69, 76, 64, 65, 427, 58, 65, 11, 13, 6, 11, 19, 14, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2D4
            private static Player Ike_Banner = new Player(123, 104, 59, 73, 50, 48, 46, 60, 57, 393, 31, 29, 15, 10, 8, 9, 10, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x2D5
            private static Player Frank_Meyer = new Player(123, 178, 54, 62, 52, 63, 63, 56, 61, 411, 30, 50, 11, 8, 9, 15, 9, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2D6
            private static Player Phil_Fog = new Player(165, 140, 67, 60, 52, 56, 60, 68, 63, 426, 66, 35, 16, 8, 11, 16, 7, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2D7
            private static Player Bob_Lioteck = new Player(149, 156, 58, 53, 58, 56, 63, 60, 52, 400, 45, 63, 13, 14, 12, 12, 13, 12, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2D8
            private static Player Rory_Polisher = new Player(173, 142, 47, 59, 61, 43, 58, 61, 62, 391, 36, 42, 10, 11, 14, 10, 8, 9, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2D9
            private static Player Tex_Curvator = new Player(110, 164, 53, 70, 52, 67, 63, 52, 60, 417, 34, 35, 9, 10, 8, 16, 9, 10, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DA
            private static Player Perry_Pincher = new Player(162, 140, 58, 56, 55, 52, 59, 63, 61, 404, 55, 47, 13, 11, 11, 14, 13, 13, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2DB
            private static Player Al_Plates = new Player(171, 136, 44, 59, 64, 50, 62, 58, 61, 398, 43, 44, 9, 11, 14, 8, 11, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x2DC
            private static Player Bane_Marie = new Player(112, 190, 52, 67, 58, 60, 56, 58, 58, 409, 39, 34, 8, 7, 8, 15, 11, 11, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DD
            private static Player Cam_Broadsheet = new Player(103, 142, 44, 60, 60, 56, 60, 71, 52, 403, 33, 36, 8, 10, 10, 9, 12, 12, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2DE
            private static Player Mo_Hawkes = new Player(140, 141, 60, 69, 47, 63, 60, 62, 60, 421, 30, 52, 8, 11, 11, 17, 12, 15, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DF
            private static Player Chris_Pecracker = new Player(162, 153, 52, 57, 66, 44, 54, 60, 62, 395, 38, 74, 10, 10, 14, 10, 9, 9, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2E0
            private static Player Andy_Crafter = new Player(143, 141, 56, 56, 53, 61, 58, 61, 59, 404, 55, 60, 14, 14, 12, 12, 11, 14, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x2E1
            private static Player Boe_Tyer = new Player(151, 149, 49, 59, 65, 51, 53, 63, 62, 402, 45, 76, 8, 8, 15, 7, 8, 11, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2E2
            private static Player Dave_O_Resis = new Player(149, 113, 48, 52, 48, 44, 51, 55, 52, 350, 36, 45, 9, 9, 9, 9, 11, 7, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2E3
            private static Player Victor_Mancey = new Player(121, 152, 55, 63, 60, 66, 56, 54, 53, 407, 40, 49, 8, 11, 9, 16, 9, 11, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2E4
            private static Player Ray_Dioset = new Player(127, 145, 65, 53, 52, 66, 50, 66, 59, 411, 46, 37, 10, 8, 11, 12, 9, 10, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2E5
            private static Player Preston_Gumbs = new Player(129, 101, 61, 62, 55, 45, 48, 63, 63, 397, 39, 25, 15, 12, 10, 8, 8, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2E6
            private static Player Tiny_Forester = new Player(162, 137, 55, 62, 70, 47, 60, 63, 61, 418, 30, 45, 11, 13, 15, 8, 7, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2E7
            private static Player Cardin_Hands = new Player(118, 148, 61, 52, 53, 62, 51, 71, 54, 404, 43, 36, 10, 10, 9, 10, 8, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2E8
            private static Player Callan_Trens = new Player(121, 153, 62, 61, 57, 65, 55, 52, 57, 409, 40, 40, 10, 8, 9, 14, 9, 12, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2E9
            private static Player Tim_Mittus = new Player(110, 129, 68, 56, 62, 56, 53, 65, 60, 420, 33, 51, 17, 9, 11, 13, 11, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EA
            private static Player Keenan_Brainard = new Player(94, 152, 52, 68, 43, 61, 62, 63, 56, 405, 26, 53, 9, 9, 13, 17, 14, 14, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x2EB
            private static Player Orson_Douvre = new Player(118, 148, 71, 52, 52, 63, 52, 68, 52, 410, 33, 37, 14, 10, 14, 16, 9, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EC
            private static Player Sandy_Hope = new Player(83, 134, 68, 58, 52, 70, 32, 60, 63, 403, 38, 43, 9, 9, 10, 13, 8, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2ED
            private static Player Ort_Omaton = new Player(90, 156, 63, 54, 61, 60, 72, 70, 53, 433, 43, 38, 10, 9, 8, 12, 18, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EE
            private static Player Clerk_Welcome = new Player(123, 120, 71, 72, 51, 48, 51, 42, 51, 386, 32, 35, 9, 11, 9, 10, 7, 9, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x2EF
            private static Player Rob_Ottman = new Player(121, 108, 58, 52, 55, 48, 54, 54, 58, 379, 42, 32, 15, 13, 10, 9, 7, 11, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2F0
            private static Player Cam_O_Miles = new Player(83, 132, 70, 53, 56, 63, 28, 62, 55, 387, 31, 39, 11, 9, 7, 13, 8, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x2F1
            private static Player Jack_Pott = new Player(169, 150, 54, 60, 52, 54, 61, 63, 53, 397, 42, 61, 13, 12, 12, 12, 12, 10, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x2F2
            private static Player Florian_Selles = new Player(158, 150, 52, 60, 59, 63, 59, 52, 52, 397, 63, 76, 14, 16, 16, 15, 16, 17, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2F3
            private static Player Finn_Sawyer = new Player(158, 136, 48, 59, 76, 46, 62, 59, 59, 409, 33, 34, 10, 10, 17, 8, 8, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2F4
            private static Player Bobby_Constable = new Player(169, 154, 61, 61, 62, 62, 52, 61, 54, 413, 60, 80, 15, 13, 15, 15, 15, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x2F5
            private static Player Ray_Menn = new Player(105, 158, 45, 62, 56, 61, 68, 63, 61, 416, 24, 47, 10, 7, 8, 10, 10, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2F6
            private static Player Odo_Toilette = new Player(85, 142, 44, 60, 59, 58, 66, 63, 52, 402, 32, 53, 7, 7, 9, 10, 12, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2F7
            private static Player Tel_Egram = new Player(145, 144, 48, 60, 62, 43, 62, 62, 57, 394, 46, 34, 8, 11, 16, 9, 11, 10, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2F8
            private static Player Char_Shumaker = new Player(171, 132, 60, 60, 59, 57, 57, 59, 55, 407, 68, 69, 17, 17, 16, 16, 14, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2F9
            private static Player Sim_Pathy = new Player(149, 178, 76, 58, 64, 41, 57, 62, 56, 414, 40, 73, 9, 10, 16, 9, 9, 10, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2FA
            private static Player Jon_Driedon = new Player(191, 190, 32, 56, 60, 62, 57, 69, 75, 411, 48, 65, 7, 13, 12, 13, 10, 14, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x2FB
            private static Player Monty_Burrows = new Player(114, 136, 29, 32, 65, 38, 60, 57, 64, 345, 33, 53, 11, 10, 16, 9, 13, 14, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2FC
            private static Player Gaston_Berry = new Player(180, 174, 42, 37, 38, 33, 73, 71, 63, 357, 45, 40, 9, 6, 7, 5, 17, 11, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x2FD
            private static Player Cruz_Ligner = new Player(169, 152, 59, 53, 52, 60, 62, 59, 58, 403, 43, 47, 13, 12, 13, 13, 14, 10, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2FE
            private static Player Irv_Washinton = new Player(134, 128, 44, 40, 51, 42, 44, 51, 46, 318, 40, 50, 9, 10, 10, 9, 9, 9, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x2FF
            private static Player Shem_Bassey = new Player(147, 144, 54, 52, 56, 60, 55, 60, 63, 400, 55, 62, 11, 11, 10, 10, 12, 13, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x300
            private static Player Pres_Cripton = new Player(123, 156, 56, 64, 53, 60, 52, 53, 62, 400, 44, 35, 11, 11, 10, 15, 10, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x301
            private static Player Winston_Windfall = new Player(140, 129, 50, 48, 40, 62, 68, 58, 53, 379, 33, 48, 9, 9, 4, 8, 16, 12, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x302
            private static Player Rich_Eden = new Player(127, 149, 59, 71, 54, 64, 56, 52, 61, 417, 45, 45, 7, 7, 11, 17, 7, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x303
            private static Player Teagen_Brewer = new Player(147, 132, 47, 42, 40, 60, 67, 57, 56, 369, 37, 40, 11, 8, 6, 11, 15, 12, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x304
            private static Player Ry_Sling = new Player(165, 190, 46, 56, 71, 44, 63, 55, 54, 389, 37, 62, 7, 9, 17, 7, 7, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x305
            private static Player Bard_Crooner = new Player(127, 116, 56, 48, 48, 60, 40, 54, 52, 358, 19, 29, 4, 7, 6, 10, 8, 7, 5, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x306
            private static Player Armstrong_Peck = new Player(114, 108, 53, 48, 54, 57, 42, 54, 47, 355, 27, 22, 8, 8, 6, 9, 6, 8, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x307
            private static Player Carey_Vanpark = new Player(112, 101, 51, 44, 45, 55, 57, 63, 52, 367, 24, 24, 5, 4, 5, 4, 7, 9, 6, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x308
            private static Player Garland_Gathers = new Player(118, 124, 56, 44, 52, 44, 52, 61, 46, 355, 24, 32, 12, 8, 10, 14, 7, 6, 5, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x309
            private static Player David_Burnum = new Player(138, 104, 44, 51, 52, 46, 48, 46, 49, 336, 26, 29, 4, 9, 13, 7, 8, 7, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x30A
            private static Player Tad_Trinket = new Player(149, 132, 44, 47, 52, 43, 53, 52, 48, 339, 34, 54, 5, 7, 11, 8, 8, 7, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x30B
            private static Player Harvey_Lifter = new Player(129, 101, 52, 53, 51, 52, 53, 46, 52, 359, 33, 43, 11, 9, 9, 9, 7, 10, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x30C
            private static Player Kurt_Price = new Player(116, 84, 45, 48, 47, 51, 41, 43, 42, 317, 27, 24, 5, 6, 5, 6, 4, 7, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x30D
            private static Player Cameron_Hameha = new Player(129, 116, 44, 49, 58, 44, 46, 55, 50, 346, 20, 37, 4, 9, 14, 8, 6, 5, 6, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x30E
            private static Player Will_Stonehead = new Player(121, 156, 70, 57, 57, 65, 51, 70, 59, 429, 31, 45, 10, 10, 9, 10, 10, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x30F
            private static Player Hugh_Marble = new Player(136, 112, 61, 59, 46, 46, 45, 54, 61, 372, 37, 36, 17, 14, 9, 10, 9, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x310
            private static Player Urson_Brown = new Player(129, 182, 57, 61, 40, 48, 43, 59, 56, 364, 38, 34, 15, 10, 10, 9, 9, 11, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x311
            private static Player Bo_Luger = new Player(158, 148, 78, 56, 54, 56, 54, 58, 61, 417, 54, 54, 18, 14, 12, 14, 14, 13, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x312
            private static Player Kim_Ono = new Player(138, 152, 53, 60, 74, 61, 60, 56, 55, 419, 38, 46, 8, 11, 7, 17, 9, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x313
            private static Player Bully_Thrower = new Player(171, 156, 44, 54, 69, 41, 61, 55, 57, 381, 36, 53, 10, 10, 16, 9, 10, 10, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x314
            private static Player Bill_Wordsworthy = new Player(116, 122, 45, 73, 40, 43, 42, 41, 46, 330, 43, 46, 9, 9, 10, 9, 9, 7, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x315
            private static Player Mo_Lusk = new Player(136, 196, 56, 60, 60, 71, 53, 62, 56, 418, 46, 35, 7, 8, 10, 17, 10, 14, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x316
            private static Player Ben_Curd = new Player(127, 152, 70, 77, 58, 79, 68, 68, 65, 485, 34, 70, 13, 11, 13, 17, 16, 17, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x317
            private static Player Powers_Squatts = new Player(187, 156, 62, 62, 40, 71, 28, 60, 56, 379, 70, 54, 9, 10, 14, 13, 5, 13, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x318
            private static Player Paisley_Onepiece = new Player(77, 150, 62, 61, 51, 60, 52, 61, 60, 407, 25, 61, 10, 11, 12, 17, 13, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x319
            private static Player Gauge_Diven = new Player(118, 186, 54, 61, 59, 61, 57, 55, 55, 402, 44, 81, 11, 11, 11, 17, 8, 11, 7, 1, 2, 1, 5, 1, 5, 1, 1, 1, 1); // 0x31A
            private static Player Zane_Laughead = new Player(217, 150, 56, 63, 44, 70, 57, 67, 54, 411, 66, 48, 8, 9, 11, 17, 12, 13, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x31B
            private static Player Daz_Tighthead = new Player(156, 170, 68, 76, 62, 69, 63, 70, 64, 472, 44, 61, 12, 12, 10, 18, 10, 15, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x31C
            private static Player Sandy_Beecher = new Player(129, 136, 61, 59, 52, 59, 58, 65, 62, 416, 37, 51, 16, 9, 12, 14, 9, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x31D
            private static Player Ty_Priter = new Player(209, 154, 71, 53, 61, 52, 62, 60, 54, 413, 44, 50, 17, 10, 10, 17, 9, 8, 11, 2, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x31E
            private static Player Nick_Savers = new Player(134, 170, 71, 70, 68, 72, 40, 76, 65, 462, 54, 50, 13, 12, 13, 13, 12, 10, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x31F
            private static Player Percy_Wrench = new Player(121, 102, 63, 60, 48, 48, 40, 60, 59, 378, 37, 23, 15, 12, 9, 9, 10, 7, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x320
            private static Player Max_Scara = new Player(127, 198, 62, 62, 40, 40, 40, 52, 52, 348, 38, 23, 15, 11, 9, 8, 9, 8, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x321
            private static Player Jonny_Strutt = new Player(140, 120, 40, 48, 53, 55, 57, 47, 46, 346, 26, 25, 11, 4, 8, 6, 13, 8, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x322
            private static Player Larry_Oldman = new Player(94, 118, 36, 49, 44, 40, 53, 54, 41, 317, 28, 25, 5, 8, 6, 7, 9, 10, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x323
            private static Player Dom_Anding = new Player(81, 150, 52, 60, 43, 62, 61, 69, 63, 410, 31, 66, 7, 10, 14, 16, 14, 13, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x324
            private static Player Pip_Goodweather = new Player(143, 156, 53, 59, 57, 59, 60, 61, 52, 401, 45, 59, 13, 10, 10, 11, 12, 14, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x325
            private static Player Bamber_Mandrina = new Player(213, 80, 32, 71, 31, 78, 36, 79, 30, 357, 26, 27, 8, 5, 5, 5, 7, 8, 7, 4, 1, 1, 4, 1, 4, 1, 4, 1, 1); // 0x326
            private static Player Scrap_Salvadge = new Player(114, 104, 60, 57, 44, 44, 68, 57, 52, 382, 40, 29, 17, 11, 11, 10, 8, 7, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x327
            private static Player Michael_Angeloni = new Player(156, 158, 40, 60, 74, 46, 60, 56, 61, 397, 30, 51, 10, 13, 17, 11, 9, 9, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x328
            private static Player Ryder_Wheeling = new Player(121, 101, 60, 55, 49, 44, 48, 56, 49, 361, 25, 37, 12, 4, 11, 14, 6, 8, 6, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x329
            private static Player Stu_Venier = new Player(96, 150, 41, 59, 58, 52, 62, 68, 54, 394, 26, 50, 11, 8, 10, 8, 12, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x32A
            private static Player Linden_Dray = new Player(151, 142, 41, 57, 64, 45, 57, 55, 60, 379, 39, 46, 11, 10, 17, 7, 11, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x32B
            private static Player Patsy_Cornish = new Player(151, 158, 41, 56, 62, 43, 58, 62, 57, 379, 42, 53, 8, 11, 16, 8, 11, 7, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x32C
            private static Player Sharkey_Gobble = new Player(160, 146, 54, 62, 59, 60, 57, 58, 52, 402, 68, 62, 16, 17, 16, 15, 13, 14, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x32D
            private static Player Olly_Popman = new Player(83, 158, 67, 63, 61, 58, 53, 60, 62, 424, 43, 50, 15, 11, 13, 15, 8, 10, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x32E
            private static Player Tyche_Winham = new Player(81, 150, 60, 56, 59, 58, 63, 60, 52, 408, 34, 35, 17, 11, 12, 13, 9, 10, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x32F
            private static Player Page_Helper = new Player(103, 136, 49, 55, 57, 59, 77, 54, 52, 403, 34, 53, 13, 10, 10, 9, 16, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x330
            private static Player Barry_Lugh = new Player(96, 146, 42, 58, 59, 54, 64, 67, 62, 406, 32, 35, 8, 8, 10, 11, 14, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x331
            private static Player Jen_Quibble = new Player(94, 144, 56, 67, 40, 70, 62, 67, 58, 420, 18, 62, 10, 9, 13, 15, 12, 13, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x332
            private static Player Dan_Drobium = new Player(156, 150, 52, 60, 62, 53, 56, 62, 57, 402, 60, 72, 15, 15, 15, 13, 13, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x333
            private static Player Lyle_O_Day = new Player(158, 146, 60, 61, 56, 52, 60, 60, 62, 411, 64, 74, 13, 15, 17, 16, 14, 14, 15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x334
            private static Player Crane_Clawson = new Player(145, 157, 60, 64, 60, 68, 56, 52, 61, 421, 32, 40, 11, 10, 11, 17, 10, 14, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x335
            private static Player Raven_Crowe = new Player(101, 146, 70, 55, 52, 66, 37, 67, 61, 408, 30, 47, 9, 9, 11, 10, 10, 10, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x336
            private static Player Shirley_Ladyman = new Player(167, 150, 51, 31, 30, 53, 68, 60, 62, 355, 69, 40, 9, 7, 6, 8, 15, 14, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x337
            private static Player Cody_Barani = new Player(140, 132, 47, 35, 32, 61, 68, 61, 52, 356, 32, 44, 10, 7, 8, 7, 15, 14, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x338
            private static Player Bob_Shishker = new Player(200, 138, 44, 54, 52, 56, 62, 37, 57, 362, 58, 51, 8, 9, 9, 8, 12, 7, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x339
            private static Player Pica_Vellosum = new Player(145, 132, 59, 56, 56, 56, 52, 60, 63, 402, 56, 55, 10, 12, 11, 14, 13, 10, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x33A
            private static Player Sascha_Powder = new Player(123, 158, 51, 36, 33, 60, 68, 56, 60, 364, 46, 50, 10, 10, 8, 11, 18, 11, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x33B
            private static Player Gore_Lyath = new Player(143, 140, 52, 54, 63, 53, 59, 56, 62, 399, 61, 72, 14, 16, 14, 15, 17, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x33C
            private static Player Marty_Gras = new Player(132, 115, 58, 53, 40, 51, 47, 53, 58, 360, 42, 25, 15, 14, 9, 9, 9, 7, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x33D
            private static Player Bob_Dingnagian = new Player(107, 140, 46, 56, 59, 60, 60, 63, 59, 403, 24, 42, 10, 11, 10, 10, 13, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x33E
            private static Player Hugh_Dyer = new Player(77, 136, 48, 56, 61, 52, 70, 71, 60, 418, 21, 48, 10, 8, 11, 8, 18, 15, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x33F
            private static Player Carl_Penter = new Player(96, 140, 66, 53, 54, 52, 59, 73, 58, 415, 33, 43, 14, 11, 10, 17, 10, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x340
            private static Player Jebb_Ettow = new Player(165, 133, 60, 60, 63, 56, 56, 57, 54, 406, 49, 59, 11, 11, 12, 13, 10, 12, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x341
            private static Player Julian_Siezer = new Player(167, 148, 40, 32, 34, 58, 64, 60, 58, 346, 54, 44, 10, 9, 7, 9, 15, 17, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x342
            private static Player Bill_Dozer = new Player(154, 136, 54, 57, 52, 56, 54, 52, 59, 384, 54, 72, 16, 15, 17, 17, 17, 17, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x343
            private static Player Benny_Factor = new Player(154, 142, 56, 61, 54, 56, 58, 63, 58, 406, 61, 63, 14, 14, 15, 17, 15, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x344
            private static Player Roman_Candler = new Player(171, 194, 44, 52, 70, 45, 62, 52, 53, 378, 34, 77, 11, 8, 13, 10, 9, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x345
            private static Player Ray_Whitehead = new Player(92, 158, 49, 59, 62, 60, 70, 62, 58, 420, 22, 39, 13, 9, 11, 9, 18, 12, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x346
            private static Player Aston_Isher = new Player(217, 142, 66, 54, 53, 54, 60, 57, 57, 401, 80, 39, 15, 8, 13, 16, 9, 11, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x347
            private static Player Grover_Bearing = new Player(149, 138, 61, 54, 52, 57, 52, 58, 60, 394, 58, 61, 13, 12, 14, 10, 13, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x348
            private static Player Andy_Sided = new Player(134, 157, 63, 66, 60, 67, 59, 59, 52, 426, 38, 40, 7, 9, 8, 15, 10, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x349
            private static Player Phil_O_Biblist = new Player(160, 142, 65, 58, 60, 67, 30, 52, 61, 393, 61, 35, 11, 9, 11, 12, 11, 14, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x34A
            private static Player Roy_Plimsole = new Player(105, 130, 47, 52, 56, 55, 69, 58, 57, 394, 28, 35, 10, 11, 11, 9, 14, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x34B
            private static Player Jem_Paste = new Player(88, 138, 46, 57, 63, 55, 61, 64, 56, 402, 33, 35, 8, 7, 7, 10, 11, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x34C
            private static Player Mike_Creasewell = new Player(110, 150, 58, 67, 58, 67, 54, 60, 63, 427, 43, 40, 7, 9, 8, 17, 10, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x34D
            private static Player Hale_Quinn = new Player(191, 142, 61, 69, 57, 68, 35, 75, 52, 417, 32, 34, 9, 11, 11, 14, 9, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x34E
            private static Player Al_Askan = new Player(149, 140, 49, 63, 76, 69, 53, 56, 62, 428, 42, 34, 9, 13, 13, 9, 11, 7, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x34F
            private static Player Scot_Chopper = new Player(132, 146, 48, 28, 30, 62, 70, 59, 56, 353, 33, 34, 9, 9, 6, 9, 15, 10, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x350
            private static Player Nick_Templeton = new Player(151, 153, 45, 58, 67, 47, 55, 59, 52, 383, 30, 64, 10, 8, 17, 9, 9, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x351
            private static Player Butler_Chambers = new Player(123, 124, 71, 58, 40, 42, 48, 60, 56, 375, 44, 38, 14, 10, 10, 9, 10, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x352
            private static Player Pip_Skinner = new Player(167, 142, 41, 52, 65, 46, 56, 57, 53, 370, 42, 39, 10, 13, 15, 10, 8, 7, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x353
            private static Player Dan_Vega = new Player(167, 154, 66, 64, 62, 60, 64, 62, 68, 446, 26, 29, 7, 8, 6, 6, 6, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x354
            private static Player Manny_Kinsland = new Player(77, 148, 55, 63, 46, 68, 56, 60, 57, 405, 21, 62, 10, 9, 13, 15, 12, 17, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x355
            private static Player Chick_Adiddy = new Player(110, 152, 52, 62, 56, 69, 63, 56, 55, 413, 31, 91, 11, 10, 9, 15, 11, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x356
            private static Player Jig_Charleston = new Player(103, 150, 60, 76, 61, 56, 56, 69, 61, 439, 43, 38, 15, 8, 12, 14, 11, 7, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x357
            private static Player Powers_Flawless = new Player(132, 188, 57, 65, 52, 60, 60, 58, 56, 408, 46, 53, 9, 8, 9, 16, 10, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x358
            private static Player Alistair_Horizon = new Player(162, 176, 42, 63, 77, 40, 61, 61, 59, 403, 46, 65, 10, 10, 16, 8, 8, 8, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x359
            private static Player Tim_Bergoods = new Player(198, 134, 51, 52, 62, 52, 78, 39, 62, 396, 67, 44, 9, 8, 7, 8, 16, 6, 9, 2, 5, 1, 1, 1, 1, 2, 2, 1, 2); // 0x35A
            private static Player Lux_Sidebottom = new Player(81, 158, 40, 59, 52, 60, 63, 61, 54, 389, 18, 36, 7, 11, 10, 9, 12, 14, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x35B
            private static Player Nat_Picker = new Player(125, 134, 51, 32, 28, 56, 68, 52, 56, 343, 33, 36, 9, 11, 5, 11, 15, 11, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x35C
            private static Player Harold_Derry = new Player(107, 104, 38, 34, 34, 68, 60, 64, 68, 366, 18, 23, 6, 7, 6, 6, 14, 15, 5, 5, 5, 1, 1, 5, 2, 2, 5, 2, 1); // 0x35D
            private static Player Josh_Rogan = new Player(129, 117, 55, 60, 52, 47, 52, 53, 52, 371, 32, 28, 14, 13, 8, 7, 8, 7, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x35E
            private static Player Ronny_O_Mania = new Player(145, 148, 62, 63, 56, 56, 54, 54, 60, 405, 56, 64, 12, 10, 12, 10, 13, 11, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x35F
            private static Player Buck_Teachey = new Player(134, 164, 54, 60, 54, 60, 60, 52, 56, 396, 32, 44, 9, 11, 11, 14, 7, 11, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x360
            private static Player Rayburn_Lightly = new Player(165, 145, 55, 54, 55, 60, 57, 61, 58, 400, 61, 62, 16, 16, 14, 14, 14, 17, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x361
            private static Player Pat_Greene = new Player(112, 118, 53, 56, 44, 41, 46, 58, 63, 361, 32, 39, 16, 14, 7, 10, 10, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x362
            private static Player Sylver_Stone = new Player(138, 136, 46, 57, 52, 56, 68, 66, 62, 407, 22, 36, 9, 9, 10, 10, 10, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x363
            private static Player Equin_Knocks = new Player(125, 161, 60, 60, 58, 64, 60, 56, 54, 412, 43, 41, 10, 9, 8, 15, 10, 11, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x364
            private static Player Hans_Bigger = new Player(169, 132, 59, 60, 52, 60, 56, 53, 60, 400, 45, 63, 13, 14, 13, 13, 12, 13, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x365
            private static Player Creed_Wrighter = new Player(165, 180, 55, 56, 58, 53, 56, 60, 53, 391, 42, 91, 14, 14, 11, 11, 11, 12, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x366
            private static Player Fran_Zimmer = new Player(114, 137, 60, 56, 53, 61, 55, 64, 56, 405, 39, 36, 17, 8, 13, 16, 10, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x367
            private static Player Chaz_Anover = new Player(151, 158, 53, 62, 53, 61, 58, 56, 53, 396, 55, 69, 15, 17, 16, 14, 17, 13, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x368
            private static Player Kurt_O_Graphy = new Player(85, 152, 45, 56, 56, 53, 62, 68, 52, 392, 32, 46, 7, 9, 9, 9, 12, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x369
            private static Player Pace_Storey = new Player(114, 128, 52, 48, 61, 55, 53, 58, 52, 379, 22, 25, 8, 11, 11, 5, 7, 6, 5, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x36A
            private static Player Paddy_Streehan = new Player(127, 126, 58, 61, 47, 43, 41, 58, 55, 363, 44, 21, 17, 14, 7, 7, 11, 8, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x36B
            private static Player Carson_Haynes = new Player(118, 162, 58, 60, 56, 58, 57, 60, 66, 415, 36, 42, 9, 9, 10, 15, 9, 10, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36C
            private static Player Earl_Grayson = new Player(169, 150, 64, 65, 60, 71, 67, 64, 60, 451, 46, 47, 11, 10, 10, 13, 10, 13, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x36D
            private static Player Pip_Aminty = new Player(125, 156, 61, 67, 61, 70, 59, 55, 57, 430, 39, 48, 7, 11, 7, 17, 8, 13, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36E
            private static Player Noel_Vacancies = new Player(138, 194, 57, 65, 59, 70, 52, 62, 54, 419, 44, 34, 9, 9, 9, 17, 7, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36F
            private static Player Jon_Quill = new Player(206, 150, 68, 62, 56, 53, 54, 63, 54, 410, 42, 40, 14, 7, 13, 16, 11, 11, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x370
            private static Player Bill_Looney = new Player(114, 172, 52, 61, 72, 63, 61, 53, 52, 414, 44, 53, 7, 10, 7, 16, 7, 11, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x371
            private static Player Dan_Nettles = new Player(189, 136, 62, 60, 58, 60, 61, 38, 53, 392, 70, 47, 16, 8, 10, 14, 9, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x372
            private static Player Clark_Watcher = new Player(83, 142, 45, 56, 56, 63, 69, 60, 55, 404, 27, 42, 14, 8, 9, 8, 19, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x373
            private static Player Tim_Eisback = new Player(83, 136, 48, 58, 57, 57, 69, 60, 58, 407, 30, 44, 11, 11, 7, 8, 11, 10, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x374
            private static Player Sam_Aritan = new Player(125, 100, 52, 61, 47, 47, 49, 57, 62, 375, 31, 39, 16, 13, 9, 11, 7, 11, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x375
            private static Player Cal_Emarry = new Player(105, 150, 42, 56, 52, 55, 68, 57, 60, 390, 22, 40, 12, 10, 8, 9, 16, 11, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x376
            private static Player Bambis_Shakin = new Player(118, 134, 50, 57, 59, 57, 76, 55, 60, 414, 39, 42, 12, 7, 9, 9, 15, 14, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x377
            private static Player Zin_Giber = new Player(103, 144, 41, 59, 54, 58, 74, 59, 54, 399, 25, 53, 11, 9, 10, 9, 20, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x378
            private static Player Wes_Abbey = new Player(167, 158, 68, 64, 64, 61, 62, 66, 60, 445, 56, 54, 14, 14, 12, 12, 13, 11, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x379
            private static Player Alec_Dote = new Player(149, 198, 41, 55, 64, 40, 60, 58, 60, 378, 34, 81, 7, 7, 16, 8, 8, 7, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x37A
            private static Player Dougie_McFlea = new Player(171, 142, 52, 56, 62, 61, 57, 59, 59, 406, 56, 54, 12, 12, 11, 13, 13, 13, 11, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x37B
            private static Player Jacky_Lantern = new Player(103, 156, 60, 46, 45, 67, 34, 54, 49, 355, 34, 39, 8, 4, 7, 9, 6, 8, 5, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x37C
            private static Player Matt_Tudor = new Player(90, 124, 29, 46, 44, 79, 56, 62, 50, 366, 19, 25, 5, 5, 6, 7, 11, 9, 6, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x37D
            private static Player Gabriel_Shekinah = new Player(79, 132, 62, 58, 82, 60, 50, 64, 56, 432, 32, 50, 7, 7, 11, 13, 17, 11, 10, 5, 1, 2, 1, 2, 2, 5, 2, 1, 1); // 0x37E
            private static Player Biron_Pendexter = new Player(112, 192, 62, 68, 53, 71, 63, 60, 59, 436, 31, 50, 10, 9, 8, 13, 9, 12, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x37F
            private static Player Rod_Entwhistle = new Player(107, 136, 66, 58, 56, 68, 39, 79, 60, 426, 33, 35, 11, 9, 9, 11, 8, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x380
            private static Player Toby_Patient = new Player(195, 152, 44, 57, 55, 60, 71, 32, 58, 377, 67, 42, 14, 10, 8, 8, 17, 6, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x381
            private static Player Glen_Garry = new Player(118, 126, 48, 51, 44, 44, 51, 48, 40, 326, 36, 44, 10, 8, 7, 10, 7, 10, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x382
            private static Player Bill_Yards = new Player(129, 108, 61, 55, 47, 46, 44, 57, 60, 370, 44, 24, 16, 11, 8, 8, 7, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x383
            private static Player Kay_Acker = new Player(182, 144, 58, 71, 48, 60, 62, 74, 60, 433, 56, 47, 9, 9, 11, 17, 11, 17, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x384
            private static Player Django_Keyes = new Player(85, 198, 43, 76, 46, 76, 42, 38, 41, 362, 18, 23, 10, 5, 9, 6, 11, 5, 8, 2, 2, 2, 2, 2, 4, 2, 2, 2, 1); // 0x385
            private static Player John_Demi = new Player(167, 148, 59, 62, 60, 71, 62, 60, 57, 431, 64, 70, 14, 17, 13, 13, 16, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x386
            private static Player Sage_Wisdom = new Player(83, 146, 49, 63, 60, 56, 64, 52, 59, 403, 19, 48, 12, 11, 11, 9, 19, 14, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x387
            private static Player Nick_Washing = new Player(193, 152, 54, 69, 48, 67, 53, 64, 60, 415, 61, 57, 10, 10, 11, 14, 11, 14, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x388
            private static Player Steve_Pinner = new Player(96, 130, 43, 52, 61, 62, 61, 52, 61, 392, 18, 35, 12, 9, 11, 11, 20, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x389
            private static Player Vance_Bookings = new Player(99, 156, 49, 33, 39, 55, 66, 76, 56, 374, 33, 43, 8, 9, 4, 8, 16, 19, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x38A
            private static Player Bud_Dahman = new Player(118, 100, 54, 56, 51, 48, 43, 59, 54, 365, 36, 34, 15, 11, 11, 9, 8, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x38B
            private static Player Reagan_Boneman = new Player(158, 154, 54, 57, 54, 63, 58, 63, 60, 409, 57, 55, 11, 11, 10, 12, 10, 12, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x38C
            private static Player Erhard_Blower = new Player(173, 138, 54, 60, 62, 55, 54, 56, 52, 393, 42, 47, 10, 11, 12, 12, 13, 11, 11, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x38D
            private static Player Jack_Tradesman = new Player(145, 136, 59, 54, 61, 60, 56, 61, 61, 412, 54, 76, 17, 17, 15, 15, 17, 17, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x38E
            private static Player Rufus_Judge = new Player(165, 134, 52, 58, 52, 61, 52, 52, 63, 390, 26, 28, 7, 5, 6, 7, 4, 6, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x38F
            private static Player Ace_Fettick = new Player(121, 176, 42, 44, 49, 69, 43, 40, 61, 348, 42, 51, 13, 12, 11, 11, 12, 12, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x390
            private static Player Lance_Lotts = new Player(121, 142, 62, 56, 53, 59, 63, 61, 62, 416, 31, 50, 14, 11, 12, 16, 8, 15, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x391
            private static Player Attley_Hightable = new Player(162, 164, 46, 62, 69, 48, 55, 59, 57, 396, 39, 88, 9, 8, 18, 8, 11, 7, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x392
            private static Player Jim_Nastick = new Player(110, 182, 60, 61, 55, 64, 55, 59, 59, 413, 43, 42, 8, 11, 9, 16, 11, 13, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x393
            private static Player Theo_Riser = new Player(140, 126, 42, 60, 60, 64, 43, 44, 48, 361, 42, 50, 12, 14, 10, 13, 12, 12, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x394
            private static Player Weldon_Wrought = new Player(165, 170, 41, 55, 62, 42, 62, 55, 58, 375, 37, 61, 10, 7, 15, 11, 10, 9, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x395
            private static Player Seymour_Senary = new Player(83, 144, 45, 55, 52, 56, 71, 62, 59, 400, 32, 47, 8, 9, 9, 9, 10, 13, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x396
            private static Player Finn_Carper = new Player(129, 112, 62, 52, 49, 60, 42, 63, 57, 385, 30, 21, 13, 11, 10, 17, 9, 10, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x397
            private static Player Herc_Bigsby = new Player(118, 154, 56, 62, 56, 71, 54, 60, 56, 415, 34, 35, 8, 9, 7, 13, 7, 13, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x398
            private static Player Bramley_Cox = new Player(158, 158, 64, 62, 54, 71, 61, 52, 60, 424, 57, 55, 13, 14, 11, 11, 12, 14, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x399
            private static Player Mitch_Hett = new Player(160, 192, 54, 53, 72, 59, 57, 58, 55, 408, 56, 59, 14, 14, 14, 11, 12, 13, 12, 4, 2, 4, 4, 2, 4, 4, 4, 4, 3); // 0x39A
            private static Player Mo_Zarella = new Player(99, 150, 70, 60, 61, 66, 29, 63, 53, 402, 30, 35, 10, 11, 10, 12, 9, 9, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x39B
            private static Player Scout_Messenger = new Player(154, 156, 69, 61, 56, 58, 63, 56, 52, 415, 51, 48, 11, 13, 10, 14, 12, 14, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x39C
            private static Player Paul_Chucker = new Player(112, 106, 61, 52, 51, 44, 43, 63, 58, 372, 40, 28, 16, 12, 8, 11, 8, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x39D
            private static Player Andy_Wallpole = new Player(81, 154, 61, 61, 62, 54, 56, 67, 56, 417, 31, 34, 17, 11, 14, 15, 9, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x39E
            private static Player Solomon_Justice = new Player(145, 148, 62, 60, 53, 53, 59, 62, 56, 405, 68, 62, 15, 16, 13, 16, 14, 17, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x39F
            private static Player Mark_Tinney = new Player(149, 136, 60, 58, 56, 53, 52, 53, 60, 392, 55, 68, 16, 17, 13, 17, 14, 15, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3A0
            private static Player Archy_Medez = new Player(151, 138, 53, 60, 62, 54, 63, 60, 58, 410, 55, 68, 16, 15, 15, 17, 17, 13, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x3A1
            private static Player Jay_Pan = new Player(143, 115, 64, 79, 48, 52, 36, 52, 77, 408, 58, 74, 16, 16, 15, 16, 5, 16, 20, 5, 5, 1, 2, 2, 1, 5, 5, 2, 1); // 0x3A2
            private static Player Jonah_Troutman = new Player(151, 158, 47, 59, 68, 48, 55, 57, 58, 392, 33, 63, 8, 7, 14, 11, 8, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3A3
            private static Player Carl_Nivor = new Player(101, 154, 48, 52, 58, 52, 67, 64, 56, 397, 27, 38, 8, 8, 11, 10, 13, 14, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3A4
            private static Player Phil_Occifer = new Player(169, 176, 51, 55, 65, 44, 60, 61, 62, 398, 42, 63, 11, 9, 14, 7, 11, 9, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3A5
            private static Player Noah_Gerkin = new Player(123, 124, 75, 49, 48, 49, 44, 40, 43, 348, 32, 50, 7, 8, 11, 9, 7, 7, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3A6
            private static Player Colin_Eager = new Player(121, 115, 52, 60, 45, 49, 48, 52, 56, 362, 42, 31, 16, 12, 9, 8, 11, 7, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x3A7
            private static Player Don_Ringo = new Player(121, 102, 50, 48, 77, 47, 43, 48, 39, 352, 46, 59, 11, 12, 12, 14, 13, 13, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3A8
            private static Player Nick_Crew = new Player(149, 172, 45, 57, 60, 43, 60, 59, 61, 385, 33, 62, 11, 8, 14, 11, 11, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3A9
            private static Player Ivor_Parrot = new Player(127, 110, 62, 52, 48, 51, 41, 62, 56, 372, 46, 21, 13, 11, 10, 11, 8, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x3AA
            private static Player Matthew_Pencil = new Player(107, 115, 34, 41, 43, 50, 53, 51, 44, 316, 21, 21, 8, 7, 4, 4, 10, 9, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3AB
            private static Player Ropert_Chapp = new Player(92, 148, 61, 64, 50, 62, 55, 63, 62, 417, 19, 59, 10, 7, 12, 14, 12, 13, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3AC
            private static Player Hal_LeButt = new Player(158, 192, 41, 52, 68, 44, 59, 63, 60, 387, 38, 61, 9, 8, 13, 7, 9, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3AD
            private static Player Al_Chemmy = new Player(138, 168, 69, 68, 60, 65, 64, 62, 60, 448, 46, 20, 7, 7, 6, 7, 8, 6, 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3AE
            private static Player Rob_Zervatory = new Player(173, 154, 68, 52, 58, 57, 62, 63, 52, 412, 74, 34, 13, 7, 14, 14, 10, 20, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3AF
            private static Player Joe_Stick = new Player(145, 188, 48, 63, 61, 43, 54, 62, 58, 389, 40, 73, 10, 9, 15, 8, 8, 8, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3B0
            private static Player Nick_Turine = new Player(127, 141, 70, 62, 59, 63, 44, 64, 53, 415, 34, 35, 11, 8, 8, 14, 7, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3B1
            private static Player Marc_O_Lepsy = new Player(127, 136, 68, 61, 58, 60, 57, 62, 57, 423, 33, 37, 16, 9, 13, 13, 9, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x3B2
            private static Player Jim_Makegood = new Player(105, 154, 42, 52, 62, 57, 64, 70, 60, 407, 32, 40, 9, 10, 9, 8, 15, 13, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3B3
            private static Player Vin_Spinner = new Player(127, 198, 46, 29, 39, 59, 68, 60, 60, 361, 67, 104, 11, 9, 7, 15, 15, 15, 17, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3B4
            private static Player Grew_Driver = new Player(165, 172, 67, 64, 64, 64, 68, 64, 64, 455, 19, 36, 5, 5, 5, 4, 6, 8, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x3B5
            private static Player Ed_Dupee = new Player(116, 136, 40, 28, 38, 53, 68, 60, 60, 347, 40, 50, 7, 11, 5, 11, 14, 14, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3B6
            private static Player Hank_Shortman = new Player(165, 152, 47, 52, 74, 43, 52, 61, 52, 381, 33, 51, 9, 12, 14, 8, 10, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3B7
            private static Player Aaron_Peacy = new Player(77, 156, 42, 54, 56, 59, 71, 52, 52, 386, 28, 35, 11, 11, 11, 9, 15, 12, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3B8
            private static Player Harvey_Sweats = new Player(96, 130, 66, 61, 60, 68, 35, 60, 54, 404, 36, 48, 7, 8, 8, 11, 10, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3B9
            private static Player Harry_Overton = new Player(77, 130, 52, 68, 44, 68, 62, 60, 56, 410, 33, 58, 7, 8, 12, 14, 13, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3BA
            private static Player Archie_Tate = new Player(118, 144, 40, 28, 31, 52, 71, 53, 60, 335, 33, 51, 8, 11, 4, 8, 16, 11, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3BB
            private static Player Neville_List = new Player(77, 178, 40, 57, 55, 52, 74, 70, 52, 400, 31, 38, 9, 11, 7, 9, 16, 18, 8, 5, 5, 1, 1, 1, 1, 2, 2, 1, 3); // 0x3BC
            private static Player Lee_Dorr = new Player(114, 120, 48, 44, 42, 42, 44, 47, 48, 315, 42, 44, 11, 7, 7, 7, 10, 9, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x3BD
            private static Player Sam_Which = new Player(92, 138, 69, 63, 60, 62, 56, 60, 56, 426, 45, 34, 17, 9, 10, 15, 8, 9, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x3BE
            private static Player Dwight_Self = new Player(105, 152, 65, 52, 54, 53, 56, 70, 56, 406, 32, 34, 14, 10, 14, 14, 8, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x3BF
            private static Player Shep_Shank = new Player(96, 146, 48, 55, 61, 53, 62, 55, 61, 395, 18, 46, 14, 7, 9, 7, 15, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3C0
            private static Player Dylan_Swan = new Player(134, 128, 44, 40, 40, 43, 49, 41, 47, 304, 37, 53, 9, 9, 7, 7, 9, 10, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x3C1
            private static Player Theo_Bernoulli = new Player(103, 148, 60, 70, 51, 68, 56, 70, 55, 430, 34, 55, 7, 8, 11, 17, 14, 16, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3C2
            private static Player Sul_Tarner = new Player(125, 192, 60, 60, 57, 65, 52, 54, 54, 402, 38, 53, 7, 7, 11, 14, 8, 11, 11, 1, 2, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3C3
            private static Player Silas_Scrooge = new Player(176, 164, 70, 73, 68, 65, 64, 67, 60, 467, 76, 87, 17, 19, 18, 17, 19, 18, 17, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3C4
            private static Player Mario_Nette = new Player(127, 110, 43, 45, 47, 48, 48, 44, 42, 317, 31, 35, 7, 11, 11, 10, 10, 7, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x3C5
            private static Player Telly_Fonbocks = new Player(154, 136, 62, 54, 60, 53, 59, 52, 52, 392, 57, 65, 15, 14, 17, 17, 13, 15, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3C6
            private static Player Bones_Size = new Player(99, 142, 45, 55, 61, 59, 74, 60, 54, 408, 31, 42, 12, 9, 11, 10, 13, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3C7
            private static Player Frank_Koshar = new Player(96, 156, 54, 61, 40, 64, 58, 67, 56, 400, 26, 61, 9, 7, 13, 16, 11, 13, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3C8
            private static Player Keifer_Tiliser = new Player(129, 160, 63, 60, 62, 64, 62, 63, 53, 427, 36, 34, 9, 8, 11, 17, 11, 10, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3C9
            private static Player Jak_Hammerslam = new Player(88, 158, 43, 59, 52, 63, 66, 64, 60, 407, 18, 36, 8, 11, 10, 9, 13, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3CA
            private static Player Rob_Freeby = new Player(195, 156, 65, 63, 55, 67, 28, 60, 56, 394, 74, 51, 9, 11, 10, 14, 10, 14, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3CB
            private static Player Chris_Talise = new Player(116, 132, 41, 34, 32, 59, 68, 60, 57, 351, 43, 36, 9, 8, 8, 9, 17, 13, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3CC
            private static Player Derek_Longhand = new Player(140, 162, 63, 68, 53, 68, 62, 58, 61, 433, 40, 48, 9, 11, 8, 14, 11, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3CD
            private static Player Manny_Gerry = new Player(165, 136, 43, 57, 72, 46, 57, 60, 52, 387, 34, 36, 11, 12, 19, 10, 9, 10, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3CE
            private static Player Des_Count = new Player(112, 150, 62, 60, 63, 71, 63, 60, 54, 433, 43, 40, 7, 9, 9, 14, 8, 12, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3CF
            private static Player Rocky_Rollans = new Player(125, 162, 62, 71, 61, 68, 63, 63, 56, 444, 39, 62, 8, 8, 11, 16, 10, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3D0
            private static Player Shaun_Staid = new Player(101, 154, 43, 61, 53, 61, 79, 77, 56, 430, 20, 53, 8, 7, 10, 10, 14, 13, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3D1
            private static Player Heath_Freke = new Player(101, 136, 64, 56, 63, 52, 56, 61, 60, 412, 32, 38, 15, 11, 12, 17, 10, 9, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3D2
            private static Player Olly_Gammy = new Player(191, 108, 51, 68, 50, 44, 48, 69, 66, 396, 43, 51, 9, 12, 11, 9, 8, 12, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3D3
            private static Player Aidan_Model = new Player(140, 106, 64, 54, 40, 49, 44, 61, 60, 372, 39, 36, 18, 10, 11, 10, 9, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x3D4
            private static Player Mick_Thatcher = new Player(156, 198, 44, 59, 72, 44, 54, 52, 61, 386, 31, 40, 9, 12, 15, 10, 8, 10, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D5
            private static Player Owen_Greenfield = new Player(187, 156, 60, 67, 72, 64, 63, 63, 60, 449, 55, 80, 17, 13, 15, 17, 14, 16, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3D6
            private static Player Charlie_Krelborn = new Player(162, 158, 41, 59, 65, 41, 61, 55, 62, 384, 42, 80, 11, 7, 16, 11, 11, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D7
            private static Player Rory_Circles = new Player(116, 132, 45, 37, 36, 55, 62, 63, 63, 361, 32, 46, 10, 9, 6, 7, 13, 12, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3D8
            private static Player Barry_Sterr = new Player(169, 138, 41, 63, 61, 48, 53, 62, 61, 389, 36, 35, 9, 11, 16, 9, 8, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D9
            private static Player John_Baird = new Player(116, 192, 56, 60, 54, 65, 57, 60, 60, 412, 32, 46, 9, 9, 7, 15, 9, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3DA
            private static Player Tyson_Moodey = new Player(92, 146, 40, 54, 61, 55, 77, 61, 61, 409, 21, 53, 14, 9, 8, 9, 17, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3DB
            private static Player Al_Istatin = new Player(182, 140, 61, 57, 60, 59, 56, 65, 59, 417, 61, 44, 14, 10, 12, 13, 10, 14, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3DC
            private static Player Paddy_Popper = new Player(96, 130, 74, 61, 63, 52, 53, 55, 57, 415, 24, 34, 10, 10, 10, 11, 16, 12, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3DD
            private static Player Dwayne_Woo = new Player(169, 130, 63, 63, 54, 60, 56, 77, 63, 436, 49, 50, 13, 10, 14, 14, 7, 17, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3DE
            private static Player Pete_Sadow = new Player(103, 146, 40, 62, 52, 61, 76, 72, 60, 423, 26, 51, 9, 10, 10, 7, 16, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3DF
            private static Player Troy_Glodight = new Player(154, 150, 60, 60, 60, 79, 62, 56, 52, 429, 54, 53, 14, 12, 12, 17, 11, 10, 11, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x3E0
            private static Player Chris_Hypogee = new Player(167, 154, 46, 60, 62, 48, 56, 52, 59, 383, 32, 43, 10, 14, 14, 10, 10, 11, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3E1
            private static Player Connor_Bation = new Player(140, 124, 55, 59, 45, 41, 44, 56, 61, 361, 46, 35, 17, 14, 8, 8, 8, 8, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3E2
            private static Player Rhys_Masher = new Player(140, 102, 58, 52, 49, 48, 45, 55, 61, 368, 34, 36, 17, 10, 10, 9, 7, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3E3
            private static Player Charlie_Shearing = new Player(165, 158, 59, 61, 52, 55, 62, 60, 56, 405, 34, 35, 5, 6, 4, 6, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x3E4
            private static Player Al_Mannack = new Player(103, 156, 40, 56, 63, 63, 63, 60, 55, 400, 25, 47, 12, 9, 11, 11, 16, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3E5
            private static Player Nathan_Weyton = new Player(125, 132, 45, 33, 33, 54, 64, 63, 60, 352, 33, 48, 9, 8, 5, 9, 17, 12, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3E6
            private static Player Simon_Stryker = new Player(151, 160, 45, 60, 61, 46, 56, 59, 60, 387, 36, 62, 9, 8, 17, 9, 11, 10, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3E7
            private static Player Will_Bayeux = new Player(151, 136, 61, 57, 55, 62, 58, 55, 52, 400, 45, 62, 11, 10, 10, 13, 10, 12, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3E8
            private static Player Thomas_Ediston = new Player(127, 150, 59, 76, 60, 68, 56, 53, 75, 447, 40, 48, 9, 7, 11, 14, 9, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3E9
            private static Player Aubry_Dient = new Player(107, 150, 63, 61, 55, 64, 35, 69, 60, 407, 43, 48, 9, 7, 9, 12, 10, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3EA
            private static Player Les_Tarrant = new Player(123, 118, 52, 63, 40, 44, 47, 53, 56, 355, 34, 29, 13, 14, 11, 7, 9, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3EB
            private static Player Sim_Cope = new Player(79, 134, 42, 56, 63, 56, 68, 60, 60, 405, 33, 44, 13, 9, 11, 11, 15, 14, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3EC
            private static Player Cal_O_Rees = new Player(107, 154, 49, 62, 56, 52, 67, 63, 52, 401, 32, 34, 14, 8, 7, 10, 16, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3ED
            private static Player Ringo_Spinning = new Player(94, 158, 60, 62, 44, 65, 52, 62, 60, 405, 18, 55, 10, 8, 10, 14, 11, 14, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3EE
            private static Player Dec_O_Rator = new Player(134, 106, 55, 62, 50, 45, 49, 54, 59, 374, 44, 20, 15, 10, 11, 11, 11, 8, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3EF
            private static Player Pat_Shinko = new Player(110, 152, 43, 37, 28, 61, 76, 56, 59, 360, 38, 50, 11, 9, 4, 9, 15, 14, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x3F0
            private static Player Ryan_Ferry = new Player(143, 113, 58, 58, 51, 46, 44, 60, 61, 378, 46, 25, 13, 10, 7, 9, 10, 11, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x3F1
            private static Player Les_Belisha = new Player(121, 176, 59, 68, 54, 65, 53, 62, 55, 416, 45, 89, 9, 8, 9, 13, 7, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3F2
            private static Player Tim_Crochett = new Player(125, 186, 52, 62, 57, 70, 62, 62, 53, 418, 46, 39, 8, 9, 9, 17, 9, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3F3
            private static Player Hiroshi_Dot = new Player(187, 154, 58, 70, 40, 67, 53, 68, 53, 409, 26, 53, 8, 9, 13, 16, 14, 6, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3F4
            private static Player Jack_Nimble = new Player(167, 142, 50, 56, 61, 43, 55, 56, 62, 383, 31, 42, 10, 10, 16, 8, 8, 9, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3F5
            private static Player Patch_Upright = new Player(143, 156, 51, 62, 69, 44, 60, 52, 57, 395, 38, 76, 9, 9, 17, 8, 9, 11, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3F6
            private static Player Joe_Nalist = new Player(191, 142, 63, 53, 55, 68, 38, 68, 58, 403, 43, 48, 8, 8, 8, 13, 11, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x3F7
            private static Player Esau_Fagus = new Player(85, 156, 46, 52, 46, 58, 41, 43, 40, 326, 27, 31, 6, 5, 6, 13, 6, 9, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3F8
            private static Player Braden_Bakewell = new Player(90, 125, 76, 33, 39, 48, 70, 40, 44, 350, 28, 20, 15, 7, 7, 6, 13, 10, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3F9
            private static Player Virgil_Lantis = new Player(79, 104, 72, 58, 36, 62, 48, 55, 40, 371, 20, 36, 5, 8, 11, 13, 10, 13, 6, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3FA
            private static Player Norm_Drilling = new Player(158, 134, 57, 53, 54, 58, 60, 57, 54, 393, 69, 68, 14, 14, 15, 16, 16, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x3FB
            private static Player Kurt_Tweedy = new Player(94, 138, 53, 62, 44, 65, 60, 71, 52, 407, 28, 54, 10, 11, 11, 13, 12, 15, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3FC
            private static Player Solomon_Osaka = new Player(143, 158, 47, 59, 68, 42, 54, 54, 55, 379, 32, 73, 7, 7, 13, 11, 10, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3FD
            private static Player Pike_Tucker = new Player(134, 154, 44, 34, 28, 61, 64, 56, 55, 342, 43, 43, 11, 10, 7, 11, 14, 14, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x3FE
            private static Player Gary_Osoto = new Player(103, 142, 48, 60, 57, 56, 71, 61, 53, 406, 25, 46, 13, 8, 8, 11, 14, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3FF
            private static Player Dec_Orum = new Player(209, 140, 70, 56, 63, 56, 63, 74, 60, 442, 37, 39, 17, 8, 11, 15, 7, 10, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x400
            private static Player Alan_Carte = new Player(121, 115, 75, 52, 45, 40, 51, 56, 60, 379, 33, 21, 15, 13, 9, 9, 11, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x401
            private static Player Morgan_Iser = new Player(162, 140, 62, 53, 59, 52, 55, 60, 54, 395, 56, 50, 12, 14, 12, 12, 14, 13, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x402
            private static Player Ken_Broad = new Player(187, 136, 45, 32, 31, 55, 62, 60, 52, 337, 57, 44, 9, 11, 5, 7, 16, 10, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x403
            private static Player Scot_Enguard = new Player(195, 152, 65, 60, 64, 60, 60, 62, 64, 435, 32, 24, 17, 11, 7, 11, 9, 10, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x404
            private static Player Dick_Turbin = new Player(136, 156, 44, 31, 36, 54, 64, 56, 60, 345, 33, 44, 9, 10, 8, 9, 16, 11, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x405
            private static Player Benedict_Eggers = new Player(101, 148, 64, 60, 58, 71, 36, 65, 62, 416, 43, 40, 9, 10, 8, 11, 9, 7, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x406
            private static Player Beau_Painton = new Player(92, 134, 67, 52, 62, 52, 52, 60, 60, 405, 45, 38, 16, 11, 14, 17, 7, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x407
            private static Player Butch_Pythons = new Player(110, 158, 63, 67, 61, 61, 60, 52, 54, 418, 34, 50, 8, 9, 11, 17, 8, 13, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x408
            private static Player Sam_Murray = new Player(107, 142, 67, 54, 52, 69, 35, 68, 59, 404, 38, 44, 11, 7, 11, 13, 10, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x409
            private static Player Eathan_Ringer = new Player(88, 156, 63, 61, 61, 63, 36, 66, 61, 411, 43, 39, 7, 7, 8, 12, 8, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x40A
            private static Player Jack_Lumbar = new Player(189, 150, 58, 60, 51, 64, 52, 72, 55, 412, 20, 55, 11, 11, 14, 16, 12, 15, 7, 5, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x40B
            private static Player Todd_Tempole = new Player(140, 165, 61, 70, 56, 65, 56, 54, 55, 417, 39, 52, 8, 9, 7, 14, 11, 13, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x40C
            private static Player Jacob_Grimley = new Player(138, 194, 69, 58, 44, 51, 44, 62, 62, 390, 31, 25, 5, 11, 9, 10, 11, 9, 9, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0x40D
            private static Player John_Coralli = new Player(160, 136, 76, 53, 52, 56, 53, 59, 60, 409, 42, 62, 12, 11, 13, 12, 14, 10, 12, 4, 4, 5, 4, 4, 4, 4, 4, 4, 3); // 0x40E
            private static Player Drew_Faxon = new Player(83, 150, 40, 52, 62, 56, 64, 54, 54, 382, 19, 44, 12, 9, 10, 9, 13, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x40F
            private static Player Cole_Easteroll = new Player(123, 106, 40, 51, 48, 42, 45, 49, 40, 315, 33, 51, 9, 7, 10, 10, 9, 9, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x410
            private static Player Cam_Lensman = new Player(158, 174, 41, 56, 66, 46, 52, 56, 52, 369, 31, 61, 8, 10, 16, 11, 8, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x411
            private static Player Tighe_Windsor = new Player(206, 154, 64, 61, 56, 60, 32, 73, 60, 406, 72, 44, 11, 8, 11, 12, 7, 19, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x412
            private static Player Phil_Dippedes = new Player(96, 146, 44, 63, 60, 52, 70, 59, 60, 408, 30, 44, 10, 9, 10, 9, 13, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x413
            private static Player Lenny_Lakeman = new Player(138, 113, 54, 60, 52, 46, 48, 52, 63, 375, 31, 32, 17, 14, 7, 8, 8, 11, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x414
            private static Player Vaughn_DeVille = new Player(125, 129, 55, 62, 55, 55, 61, 66, 59, 413, 33, 43, 8, 7, 8, 8, 12, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x415
            private static Player Arthur_Myrddin = new Player(158, 140, 60, 58, 63, 61, 55, 60, 54, 411, 42, 59, 12, 14, 13, 14, 10, 14, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x416
            private static Player Guy_Forker = new Player(129, 88, 50, 50, 44, 51, 48, 44, 46, 333, 34, 25, 5, 6, 8, 5, 7, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x417
            private static Player Bob_Stretcher = new Player(127, 113, 44, 49, 54, 52, 46, 54, 49, 348, 34, 39, 10, 8, 11, 10, 7, 9, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x418
            private static Player Spike_Clutcher = new Player(116, 137, 53, 53, 53, 54, 60, 55, 56, 384, 27, 47, 13, 8, 10, 7, 14, 13, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x419
            private static Player Austin_Tayssus = new Player(154, 132, 47, 56, 69, 47, 58, 63, 57, 397, 30, 42, 7, 12, 16, 8, 8, 10, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x41A
            private static Player Tom_Stevenson = new Player(127, 132, 52, 56, 60, 60, 66, 59, 52, 405, 28, 48, 12, 11, 11, 9, 15, 10, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x41B
            private static Player Ricky_Charmers = new Player(116, 132, 54, 52, 52, 62, 60, 60, 63, 403, 20, 45, 11, 10, 10, 10, 15, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x41C
            private static Player Max_Hurt = new Player(132, 132, 45, 59, 52, 60, 69, 65, 63, 413, 25, 45, 10, 9, 10, 8, 12, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x41D
            private static Player Dexter_Raleigh = new Player(118, 146, 46, 34, 35, 59, 69, 55, 60, 358, 34, 43, 8, 9, 4, 10, 19, 11, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x41E
            private static Player Pete_Pang = new Player(173, 138, 60, 70, 56, 69, 61, 58, 52, 426, 55, 69, 14, 16, 13, 15, 17, 16, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x41F
            private static Player Sam_Fitspire = new Player(88, 136, 63, 63, 42, 60, 56, 64, 60, 408, 24, 66, 7, 9, 13, 16, 13, 16, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x420
            private static Player Carter_Nightly = new Player(176, 166, 68, 65, 63, 61, 68, 60, 63, 448, 67, 72, 17, 17, 17, 13, 17, 15, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x421
            private static Player Daley_Switcher = new Player(132, 176, 61, 66, 63, 63, 59, 60, 56, 428, 46, 43, 8, 9, 7, 15, 8, 11, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x422
            private static Player Dexter_Ambie = new Player(103, 146, 68, 59, 57, 54, 61, 61, 52, 412, 46, 38, 17, 9, 12, 14, 11, 11, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x423
            private static Player Gill_Able = new Player(211, 140, 68, 52, 60, 60, 59, 76, 60, 435, 43, 38, 15, 8, 12, 16, 8, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x424
            private static Player Drew_Reiner = new Player(165, 168, 66, 71, 70, 66, 62, 68, 63, 466, 43, 54, 12, 12, 10, 11, 11, 10, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x425
            private static Player Kevin_Boardman = new Player(145, 130, 41, 60, 75, 42, 56, 61, 62, 397, 30, 44, 9, 12, 15, 11, 11, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x426
            private static Player Andy_Craft = new Player(134, 106, 40, 40, 47, 44, 47, 41, 40, 299, 30, 53, 8, 7, 10, 10, 7, 11, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x427
            private static Player Julius_Vernon = new Player(140, 184, 77, 45, 44, 76, 39, 51, 48, 380, 44, 40, 11, 9, 10, 7, 4, 8, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x428
            private static Player Robin_Sherwood = new Player(125, 108, 49, 79, 40, 70, 40, 49, 40, 367, 33, 47, 10, 7, 11, 11, 10, 8, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x429
            private static Player Ei_King = new Player(101, 148, 71, 55, 56, 56, 60, 68, 70, 436, 42, 50, 17, 9, 11, 17, 11, 7, 14, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x42A
            private static Player Travis_McClean = new Player(107, 138, 70, 52, 54, 64, 39, 66, 57, 402, 42, 39, 9, 11, 9, 13, 9, 10, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x42B
            private static Player Rusty_Spoakes = new Player(138, 154, 40, 36, 33, 61, 68, 62, 54, 354, 38, 46, 11, 9, 6, 8, 20, 14, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x42C
            private static Player Clint_Wester = new Player(169, 154, 67, 68, 67, 68, 64, 68, 60, 462, 32, 29, 4, 6, 5, 8, 7, 6, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x42D
            private static Player Pete_Nokeyo = new Player(83, 144, 42, 54, 52, 55, 73, 54, 59, 389, 31, 46, 14, 9, 9, 9, 15, 10, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x42E
            private static Player Will_Racer = new Player(171, 158, 56, 61, 56, 60, 60, 54, 60, 407, 55, 48, 10, 14, 11, 13, 12, 12, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x42F
            private static Player Ollie_Seeker = new Player(112, 133, 71, 60, 52, 58, 52, 63, 62, 418, 42, 40, 17, 7, 14, 17, 8, 8, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x430
            private static Player Graham_Hush = new Player(127, 184, 56, 65, 60, 63, 58, 58, 54, 414, 31, 53, 7, 11, 9, 15, 9, 12, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x431
            private static Player Ronny_Knowles = new Player(103, 138, 60, 62, 40, 60, 60, 62, 52, 396, 34, 53, 10, 10, 12, 14, 13, 17, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x432
            private static Player Les_Abel = new Player(90, 156, 46, 57, 57, 52, 64, 56, 52, 384, 20, 53, 13, 10, 8, 9, 15, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x433
            private static Player Reg_Thrift = new Player(94, 146, 45, 56, 54, 63, 77, 53, 60, 408, 25, 42, 10, 11, 9, 9, 14, 10, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x434
            private static Player Jools_Iceberg = new Player(158, 132, 48, 52, 65, 48, 56, 57, 54, 380, 33, 48, 9, 12, 16, 11, 9, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x435
            private static Player Mark_Brent = new Player(92, 154, 40, 54, 52, 60, 64, 62, 60, 392, 27, 44, 14, 10, 8, 9, 15, 11, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x436
            private static Player Vern_Ironfist = new Player(195, 136, 44, 63, 61, 56, 67, 71, 52, 414, 21, 48, 10, 9, 9, 8, 10, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x437
            private static Player Rob_Burnsides = new Player(195, 150, 46, 55, 61, 62, 69, 63, 54, 410, 67, 47, 7, 7, 9, 9, 16, 16, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x438
            private static Player Ace_Bragg = new Player(189, 152, 67, 68, 65, 68, 66, 67, 60, 461, 69, 80, 15, 15, 15, 16, 15, 14, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0x439
            private static Player Claude_Snap = new Player(195, 154, 66, 62, 61, 64, 67, 68, 68, 456, 68, 61, 15, 14, 15, 13, 13, 14, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x43A
            private static Player Paul_Rush = new Player(176, 156, 60, 71, 60, 68, 79, 62, 67, 467, 49, 63, 14, 12, 11, 13, 20, 14, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x43B
            private static Player Guile_Crocket = new Player(158, 172, 63, 47, 44, 61, 72, 71, 66, 424, 54, 60, 10, 12, 4, 14, 20, 15, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x43C
            private static Player Carey_Bean = new Player(160, 174, 60, 49, 40, 69, 68, 61, 60, 407, 55, 57, 11, 14, 4, 12, 19, 14, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x43D
            private static Player John_Maggie = new Player(121, 76, 76, 79, 61, 72, 31, 79, 72, 470, 30, 38, 19, 16, 14, 19, 7, 16, 17, 5, 5, 2, 2, 5, 2, 5, 2, 2, 2); // 0x43E
            private static Player Chops_Denton = new Player(191, 132, 79, 76, 46, 70, 56, 76, 53, 456, 81, 47, 20, 16, 7, 17, 9, 18, 16, 2, 5, 2, 2, 5, 2, 5, 2, 2, 1); // 0x43F
            private static Player Bobby_Yellow = new Player(129, 100, 47, 44, 46, 52, 48, 49, 44, 330, 57, 56, 11, 12, 14, 10, 13, 12, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x440
            private static Player Ace_Breaker = new Player(112, 170, 57, 60, 67, 71, 71, 68, 70, 464, 44, 61, 13, 12, 14, 12, 20, 16, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x441
            private static Player Percy_Verence = new Player(127, 173, 52, 62, 64, 68, 68, 72, 60, 446, 20, 60, 10, 10, 12, 11, 17, 15, 14, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x442
            private static Player Erik_Eagle = new Player(154, 197, 79, 60, 76, 64, 63, 53, 71, 466, 67, 66, 13, 16, 23, 14, 20, 17, 19, 4, 2, 2, 2, 2, 5, 1, 4, 4, 1); // 0x443
            private static Player Bobby_Shearer = new Player(202, 176, 76, 61, 72, 76, 60, 72, 72, 489, 67, 76, 12, 10, 13, 19, 14, 11, 12, 1, 1, 2, 2, 4, 2, 2, 2, 2, 3); // 0x444
            private static Player Paul_Peabody = new Player(217, 192, 65, 76, 62, 69, 64, 73, 74, 483, 28, 24, 10, 11, 6, 12, 13, 11, 9, 4, 2, 5, 5, 5, 5, 5, 2, 2, 1); // 0x445
            private static Player Chester_Horse_Jr = new Player(158, 129, 55, 72, 71, 58, 63, 59, 59, 437, 18, 36, 8, 7, 5, 10, 7, 6, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x446
            private static Player Chester_Horse_Jr_2 = new Player(158, 129, 55, 72, 71, 58, 63, 59, 59, 437, 18, 36, 8, 7, 5, 10, 7, 6, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x447
            private static Player Sagaminator = new Player(195, 165, 77, 71, 60, 70, 64, 70, 67, 479, 82, 93, 17, 20, 16, 20, 20, 18, 18, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x448
            private static Player Jude_Sharp = new Player(191, 180, 63, 79, 79, 79, 76, 76, 68, 520, 58, 78, 18, 19, 15, 17, 13, 15, 13, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1); // 0x449
            private static Player Shadow_Cimmerian = new Player(193, 176, 60, 74, 68, 73, 63, 60, 64, 462, 32, 47, 13, 11, 16, 12, 14, 10, 9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x44A
            private static Player Arnold_Horrel = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x44D
            private static Player Donovan_Lardy = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x44E
            private static Player Sonny_Raimon = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x44F
            private static Player Ray_Dark = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x450
            private static Player George_Firewill = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x451
            private static Player Gregory_Smith = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x452
            private static Player David_Evans = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x453
            private static Player Tom_Dark = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x454
            private static Player Gregory_Smith_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x455
            private static Player Celia_Hills_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x456
            private static Player Julia_Blaze = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x457
            private static Player Harry_Evans = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x458
            private static Player Sharon_Evans = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x459
            private static Player Unknown = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x45A
            private static Player Shearer_shadow = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x45B
            private static Player Wintersea_shadow = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x45C
            private static Player Zak_Wallside = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x45D
            private static Player Mr_Veteran = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x45E
            private static Player Dark_shadow = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x45F
            private static Player Stephen_Black = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x461
            private static Player Hekyll_Jyde = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x462
            private static Player Harry_Savage = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x463
            private static Player Newton_Thomas = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x464
            private static Player Manny_Artic = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x465
            private static Player Sammy_Igajima = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x466
            private static Player Turtle_Newfield = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x467
            private static Player Seth_Nichols = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x468
            private static Player Clint_Loggan = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x469
            private static Player Thug_1 = new Player(255, 255, 84, 84, 84, 84, 84, 84, 84, 588, 39, 47, 13, 13, 13, 13, 16, 13, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x47F
            private static Player Thug_2 = new Player(255, 255, 84, 84, 84, 84, 84, 84, 84, 588, 39, 47, 13, 18, 13, 13, 13, 13, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x480
            private static Player Thug_3 = new Player(255, 255, 84, 84, 84, 84, 84, 84, 84, 588, 39, 47, 13, 13, 13, 13, 16, 13, 13, 1, 1, 1, 1, 1, 1, 3, 1, 1, 3); // 0x481
            private static Player Thug_4 = new Player(255, 255, 84, 84, 84, 84, 84, 84, 84, 588, 39, 47, 13, 13, 13, 13, 13, 13, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x482
            private static Player Aquilina_Schiller = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x515
            private static Player Astram_B__Schiller = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x516
            private static Player Godric_Wyles = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x517
            private static Player Stewart_Vanguard = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x518
            private static Player US_President = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x519
            private static Player Shawn_Froste_Kid = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51A
            private static Player Aiden_Froste_Kid = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51B
            private static Player Xavier_Foster = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51C
            private static Player Lina_shadow = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51D
            private static Player Axel_robe = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51E
            private static Player Character_robe = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x51F
            private static Player Alpine_coach = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x520
            private static Player Cloister_coach = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x521
            private static Player Fauxshore_coach = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x522
            private static Player Mary_Times_Coach = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x523
            private static Player Fauxshore_Head = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x524           
            private static Player Deer = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x537
            private static Player Bear = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x538            
            private static Player Sue_s_mother = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x569
            private static Player Froste_s_father = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x56A
            private static Player Froste_s_mother = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x56B
            private static Player Julia_wheelchair = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x56C
            private static Player RG_Field_Stop = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x56D
            private static Player RG_Goal_Stop = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x56E
            private static Player Reception_Robot = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x56F
            private static Player Raimon_boy_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5DD
            private static Player Raimon_boy_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x5DE
            private static Player Raimon_boy_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x5DF
            private static Player Raimon_boy_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5E0
            private static Player Raimon_boy_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5E1
            private static Player Raimon_boy_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5E2
            private static Player Raimon_boy_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x5E3
            private static Player Raimon_boy_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5E4
            private static Player Raimon_boy_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5E5
            private static Player Raimon_boy_10 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x5E6
            private static Player Raimon_boy_11 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5E7
            private static Player Raimon_boy_12 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5E8
            private static Player Raimon_boy_13 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5E9
            private static Player Raimon_boy_14 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5EA
            private static Player Raimon_boy_15 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5EB
            private static Player Raimon_boy_16 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5EC
            private static Player Raimon_boy_17 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5ED
            private static Player Raimon_boy_18 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x5EE
            private static Player Raimon_boy_19 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5EF
            private static Player Raimon_boy_20 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F0
            private static Player Raimon_boy_21 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F1
            private static Player Raimon_boy_22 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F2
            private static Player Raimon_boy_23 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x5F3
            private static Player Raimon_boy_24 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F4
            private static Player Raimon_boy_25 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F5
            private static Player Raimon_boy_26 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F6
            private static Player Raimon_boy_27 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F7
            private static Player Raimon_boy_28 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F8
            private static Player Raimon_boy_29 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5F9
            private static Player Raimon_boy_30 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FA
            private static Player Raimon_boy_31 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FB
            private static Player Raimon_boy_32 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FC
            private static Player Raimon_boy_33 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FD
            private static Player Raimon_boy_34 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FE
            private static Player Raimon_boy_35 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x5FF
            private static Player Raimon_boy_36 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x600
            private static Player Raimon_boy_37 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x601
            private static Player Raimon_boy_38 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x602
            private static Player Raimon_boy_39 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x603
            private static Player Raimon_boy_40 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x604
            private static Player Raimon_boy_41 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x605
            private static Player Raimon_boy_42 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x606
            private static Player Raimon_boy_43 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x607
            private static Player Raimon_boy_44 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x608
            private static Player Raimon_boy_45 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x609
            private static Player Raimon_boy_46 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60A
            private static Player Raimon_boy_47 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60B
            private static Player Raimon_boy_48 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60C
            private static Player Raimon_boy_49 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60D
            private static Player Raimon_boy_50 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60E
            private static Player Raimon_boy_51 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x60F
            private static Player Raimon_boy_52 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x610
            private static Player Raimon_boy_53 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x611
            private static Player Raimon_boy_54 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x612
            private static Player Connor_Newlin = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x613
            private static Player Raimon_boy_56 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x614
            private static Player Raimon_boy_57 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x615
            private static Player Raimon_boy_58 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x616
            private static Player Raimon_boy_59 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x617
            private static Player Raimon_boy_60 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x618
            private static Player Raimon_girl_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x619
            private static Player Raimon_girl_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61A
            private static Player Raimon_girl_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61B
            private static Player Raimon_girl_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61C
            private static Player Raimon_girl_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61D
            private static Player Raimon_girl_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61E
            private static Player Raimon_girl_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x61F
            private static Player Raimon_girl_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x620
            private static Player Raimon_girl_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x621
            private static Player Raimon_girl_10 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x622
            private static Player Raimon_girl_11 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x623
            private static Player Raimon_girl_12 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x624
            private static Player Raimon_girl_13 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x625
            private static Player Raimon_girl_14 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x626
            private static Player Raimon_girl_15 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x627
            private static Player Raimon_girl_16 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x628
            private static Player Raimon_girl_17 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x629
            private static Player Raimon_girl_18 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62A
            private static Player Raimon_girl_19 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62B
            private static Player Raimon_girl_20 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62C
            private static Player Raimon_girl_21 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62D
            private static Player Raimon_girl_22 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62E
            private static Player Raimon_girl_23 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x62F
            private static Player Raimon_girl_24 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x630
            private static Player Raimon_girl_25 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x631
            private static Player Raimon_girl_26 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x632
            private static Player Raimon_girl_27 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x633
            private static Player Raimon_girl_28 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x634
            private static Player Raimon_girl_29 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x635
            private static Player Raimon_girl_30 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x636
            private static Player Teacher_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x641
            private static Player Teacher_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x642
            private static Player Teacher_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x643
            private static Player Teacher_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x644
            private static Player Teacher_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x645
            private static Player Teacher_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x646
            private static Player Teacher_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x647
            private static Player Teacher_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x648
            private static Player Teacher_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x649
            private static Player Lady_teacher_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x655
            private static Player Lady_teacher_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x656
            private static Player Lady_teacher_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x657
            private static Player Lady_teacher_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x658
            private static Player Lady_teacher_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x659
            private static Player Lady_teacher_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x65A
            private static Player Lady_teacher_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x65B
            private static Player Lady_teacher_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x65C
            private static Player Lady_teacher_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x65D
            private static Player Cat = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x669
            private static Player Chicken = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x66A
            private static Player Dog = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x66B
            private static Player Rabbit = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x66C
            private static Player Regular_guy_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x673
            private static Player Regular_guy_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x674
            private static Player Regular_guy_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x675
            private static Player Regular_guy_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x676
            private static Player Regular_guy_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x677
            private static Player Regular_guy_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x678
            private static Player Regular_guy_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x679
            private static Player Regular_guy_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x67A
            private static Player Regular_guy_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x67B
            private static Player Regular_guy_10 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x67C
            private static Player Regular_guy_11 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x67D
            private static Player Regular_guy_12 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x67E
            private static Player Regular_girl_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x687
            private static Player Regular_girl_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x688
            private static Player Regular_girl_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x689
            private static Player Regular_girl_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68A
            private static Player Regular_girl_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68B
            private static Player Regular_girl_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68C
            private static Player Regular_girl_7 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68D
            private static Player Regular_girl_8 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68E
            private static Player Regular_girl_9 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x68F
            private static Player Regular_girl_10 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x690
            private static Player Regular_girl_11 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x691
            private static Player Regular_girl_12 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x692
            private static Player Ken_s_mum = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x693
            private static Player Old_man_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x69B
            private static Player Old_man_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x69C
            private static Player Old_man_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x69D
            private static Player Old_man_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x69E
            private static Player Old_man_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x69F
            private static Player Old_man_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A0
            private static Player Old_man = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A1
            private static Player Old_woman_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A5
            private static Player Old_woman_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A6
            private static Player Old_woman_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A7
            private static Player Old_woman_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A8
            private static Player Old_woman_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6A9
            private static Player Old_woman_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6AA
            private static Player Boy_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6AF
            private static Player Boy_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B0
            private static Player Boy_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B1
            private static Player Boy_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B2
            private static Player Boy_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B3
            private static Player Boy_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B4
            private static Player Ken = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B5
            private static Player Oswald = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B6
            private static Player Girl_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6B9
            private static Player Girl_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6BA
            private static Player Girl_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6BB
            private static Player Girl_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6BC
            private static Player Girl_5 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6BD
            private static Player Girl_6 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6BE
            private static Player Staff_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C3
            private static Player Staff_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C4
            private static Player Staff_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C5
            private static Player Staff_4 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C6
            private static Player Shopkeeper = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C7
            private static Player Maid_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C8
            private static Player Maid_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6C9
            private static Player Maid_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6CA
            private static Player Doctor_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6CD
            private static Player Doctor_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6CE
            private static Player Nurse_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D2
            private static Player Nurse_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D3
            private static Player Nurse_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D4
            private static Player Railway_worker_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D7
            private static Player Railman_Unused = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D8
            private static Player Police_officer_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6D9
            private static Player Police_officer = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6DA
            private static Player Flash_staff = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6DB
            private static Player Nelly_s_aide = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6DC
            private static Player Zeus_clerk_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6DD
            private static Player Zeus_suit = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6DE
            private static Player Academy_guy_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E1
            private static Player Academy_guy_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E2
            private static Player Academy_guy_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E3
            private static Player Wild_guy_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E6
            private static Player Wild_guy_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E7
            private static Player Wild_guy_3 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x6E8
            private static Player Mountford = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x7D1
            private static Player Oldfield = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x7D2
            private static Player Map_point_1 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x7D3
            private static Player Map_point_2 = new Player(1, 0, 1, 1, 1, 1, 1, 1, 1, 7, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x7D4
            private static Player Grent_Chaos = new Player(193, 152, 79, 64, 64, 77, 76, 65, 76, 501, 61, 96, 14, 16, 13, 17, 14, 13, 17, 1, 1, 3, 1, 1, 3, 1, 1, 1, 4); // 0x821
            private static Player Baller_Chaos = new Player(187, 102, 76, 64, 60, 68, 71, 68, 76, 483, 55, 103, 15, 16, 14, 16, 17, 13, 15, 1, 1, 1, 1, 1, 1, 1, 1, 3, 2); // 0x822
            private static Player Clear_Chaos = new Player(198, 106, 68, 61, 65, 76, 79, 76, 79, 504, 58, 103, 15, 16, 14, 15, 13, 17, 15, 1, 1, 1, 1, 1, 1, 3, 1, 3, 5); // 0x823
            private static Player Gocker_Chaos = new Player(204, 106, 79, 66, 66, 69, 73, 62, 75, 490, 60, 92, 13, 14, 13, 16, 13, 15, 15, 1, 1, 3, 1, 1, 1, 1, 1, 1, 2); // 0x824
            private static Player Bomber_Chaos = new Player(217, 120, 74, 79, 72, 61, 79, 74, 69, 508, 61, 99, 15, 17, 16, 17, 17, 13, 14, 3, 1, 1, 1, 1, 1, 3, 1, 1, 2); // 0x825
            private static Player Heat_Chaos = new Player(211, 102, 72, 79, 68, 60, 79, 79, 72, 509, 68, 97, 17, 13, 17, 16, 14, 13, 15, 3, 1, 1, 3, 1, 1, 3, 1, 1, 2); // 0x826
            private static Player Droll_Chaos = new Player(217, 106, 76, 68, 73, 68, 79, 76, 71, 511, 58, 96, 16, 17, 14, 15, 17, 17, 16, 3, 1, 1, 1, 1, 1, 3, 1, 1, 5); // 0x827
            private static Player Rhine_Chaos = new Player(217, 126, 70, 76, 74, 61, 77, 73, 70, 501, 58, 107, 16, 16, 16, 16, 17, 15, 15, 3, 1, 1, 1, 1, 1, 3, 1, 1, 3); // 0x828
            private static Player Bryce_Whitingale_Chaos = new Player(204, 150, 78, 78, 79, 79, 79, 72, 76, 541, 56, 92, 17, 17, 15, 17, 16, 16, 14, 1, 1, 3, 1, 3, 3, 3, 1, 1, 4); // 0x829
            private static Player Claude_Beacons_Chaos = new Player(213, 130, 76, 79, 73, 72, 79, 76, 77, 532, 68, 91, 14, 16, 16, 15, 13, 14, 16, 1, 1, 3, 3, 1, 1, 3, 3, 1, 4); // 0x82A
            private static Player Neppten_Chaos = new Player(193, 106, 68, 76, 76, 68, 79, 75, 79, 521, 67, 89, 15, 16, 15, 13, 15, 15, 16, 1, 1, 1, 1, 1, 1, 3, 1, 3, 4); // 0x82B
            private static Player Galileo = new Player(202, 85, 77, 68, 58, 67, 58, 76, 59, 463, 48, 37, 22, 16, 16, 19, 21, 17, 16, 5, 5, 5, 5, 5, 5, 1, 4, 4, 5); // 0x835
            private static Player Coral = new Player(147, 73, 53, 57, 76, 63, 79, 56, 56, 440, 57, 43, 14, 17, 15, 17, 21, 18, 13, 3, 5, 3, 3, 3, 3, 2, 3, 3, 2); // 0x836
            private static Player Gigs = new Player(147, 97, 60, 55, 69, 67, 70, 56, 55, 432, 66, 45, 15, 14, 12, 20, 22, 17, 17, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x837
            private static Player Ganymede = new Player(189, 81, 64, 68, 67, 58, 69, 68, 56, 450, 57, 47, 15, 15, 20, 22, 20, 18, 16, 2, 5, 2, 2, 2, 2, 2, 2, 2, 1); // 0x838
            private static Player Charon = new Player(167, 88, 56, 55, 57, 70, 61, 52, 70, 421, 42, 37, 13, 20, 17, 20, 19, 16, 15, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x839
            private static Player Pandora = new Player(147, 81, 60, 61, 76, 54, 66, 60, 60, 437, 44, 39, 17, 15, 16, 16, 23, 15, 17, 2, 5, 2, 2, 2, 2, 2, 2, 2, 3); // 0x83A
            private static Player Grengo = new Player(176, 96, 56, 66, 52, 69, 57, 67, 65, 432, 64, 33, 13, 18, 11, 19, 23, 14, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x83B
            private static Player Io = new Player(165, 76, 52, 60, 66, 69, 73, 67, 63, 450, 56, 49, 17, 15, 18, 19, 21, 15, 17, 3, 5, 3, 3, 3, 3, 3, 3, 3, 1); // 0x83C
            private static Player Rihm = new Player(121, 72, 60, 61, 72, 61, 68, 63, 57, 442, 57, 47, 15, 19, 16, 18, 20, 12, 18, 2, 5, 2, 2, 4, 4, 2, 4, 2, 2); // 0x83D
            private static Player Janus = new Player(173, 89, 63, 63, 73, 61, 68, 51, 71, 450, 55, 47, 16, 19, 19, 16, 19, 17, 17, 2, 5, 2, 2, 4, 4, 2, 4, 2, 4); // 0x83E
            private static Player Diam = new Player(154, 97, 79, 69, 68, 61, 52, 67, 52, 448, 63, 44, 20, 18, 19, 18, 21, 16, 15, 3, 5, 3, 2, 3, 3, 3, 3, 3, 5); // 0x83F
            private static Player Dvalin = new Player(195, 72, 80, 70, 57, 60, 60, 69, 54, 450, 54, 66, 21, 19, 16, 17, 22, 17, 20, 1, 5, 1, 1, 1, 1, 1, 1, 1, 5); // 0x849
            private static Player Kenville = new Player(173, 69, 59, 53, 64, 52, 64, 70, 60, 422, 68, 54, 20, 16, 18, 18, 22, 18, 18, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2); // 0x84A
            private static Player Mole = new Player(151, 76, 71, 59, 73, 56, 76, 62, 58, 455, 55, 59, 18, 16, 18, 16, 22, 16, 18, 2, 5, 2, 2, 2, 2, 2, 2, 2, 1); // 0x84B
            private static Player Kayson = new Player(162, 84, 67, 65, 68, 60, 68, 70, 64, 462, 57, 41, 18, 19, 18, 18, 23, 19, 18, 4, 5, 4, 4, 4, 4, 4, 4, 4, 2); // 0x84C
            private static Player Tytan = new Player(193, 77, 70, 64, 54, 52, 60, 78, 74, 452, 82, 41, 19, 19, 19, 17, 21, 20, 17, 2, 5, 2, 2, 2, 2, 2, 2, 2, 1); // 0x84D
            private static Player Fedora = new Player(127, 93, 63, 56, 63, 52, 60, 57, 60, 411, 56, 45, 17, 12, 17, 12, 23, 18, 20, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x84E
            private static Player Krypto = new Player(129, 85, 59, 71, 61, 56, 72, 53, 62, 434, 58, 55, 13, 17, 20, 17, 23, 17, 18, 4, 5, 2, 2, 4, 2, 4, 4, 4, 2); // 0x84F
            private static Player Sworm = new Player(160, 69, 53, 68, 75, 63, 71, 61, 68, 459, 56, 35, 20, 16, 20, 15, 20, 19, 19, 4, 5, 2, 2, 4, 4, 2, 4, 2, 1); // 0x850
            private static Player Mercury = new Player(149, 76, 70, 58, 61, 52, 71, 53, 53, 418, 70, 52, 16, 17, 17, 17, 22, 20, 14, 3, 5, 3, 3, 3, 3, 3, 3, 3, 4); // 0x851
            private static Player Metron = new Player(149, 72, 70, 60, 71, 63, 67, 65, 64, 460, 66, 56, 18, 17, 20, 18, 21, 17, 19, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x852
            private static Player Zell = new Player(180, 72, 69, 64, 52, 75, 63, 68, 60, 451, 80, 49, 17, 20, 18, 15, 20, 20, 19, 2, 5, 2, 2, 2, 2, 2, 2, 2, 5); // 0x853
            private static Player Dvalin_FW = new Player(195, 72, 85, 80, 57, 55, 75, 69, 54, 475, 54, 66, 21, 19, 16, 17, 22, 17, 20, 1, 5, 1, 1, 1, 1, 1, 1, 1, 5); // 0x854
            private static Player Nero = new Player(169, 89, 77, 60, 57, 63, 78, 60, 70, 465, 55, 59, 17, 20, 18, 18, 21, 16, 16, 5, 5, 1, 1, 1, 1, 1, 1, 1, 4); // 0x85D
            private static Player Gele = new Player(158, 88, 57, 53, 60, 55, 79, 60, 56, 420, 74, 62, 18, 20, 20, 16, 23, 19, 17, 1, 5, 2, 2, 2, 2, 2, 2, 2, 2); // 0x85E
            private static Player Kiburn = new Player(156, 77, 56, 63, 77, 54, 62, 60, 62, 434, 60, 62, 16, 18, 18, 17, 22, 17, 20, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2); // 0x85F
            private static Player Zohen = new Player(156, 72, 68, 76, 71, 70, 77, 56, 56, 474, 63, 55, 19, 14, 17, 15, 23, 19, 20, 2, 5, 4, 4, 4, 4, 4, 4, 4, 2); // 0x860
            private static Player Hauser = new Player(167, 89, 64, 66, 65, 66, 58, 68, 66, 453, 82, 37, 16, 16, 17, 14, 23, 18, 20, 1, 5, 2, 2, 2, 2, 2, 2, 2, 2); // 0x861
            private static Player Kormer = new Player(165, 80, 60, 64, 78, 61, 65, 55, 60, 443, 61, 51, 20, 14, 18, 13, 21, 19, 17, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x862
            private static Player Kiwill = new Player(154, 81, 55, 58, 68, 57, 69, 59, 61, 427, 70, 48, 18, 18, 16, 17, 19, 20, 20, 4, 5, 4, 4, 4, 4, 4, 4, 4, 5); // 0x863
            private static Player Ark = new Player(165, 77, 56, 60, 78, 69, 72, 62, 70, 467, 72, 56, 16, 13, 16, 15, 19, 19, 20, 2, 5, 4, 4, 4, 4, 4, 4, 4, 3); // 0x864
            private static Player Wittz = new Player(195, 88, 68, 67, 62, 63, 70, 68, 67, 465, 69, 59, 22, 20, 18, 16, 19, 17, 16, 3, 5, 3, 3, 3, 3, 3, 3, 3, 4); // 0x865
            private static Player Bellatrix = new Player(158, 97, 65, 65, 79, 55, 78, 64, 68, 474, 68, 62, 17, 17, 17, 15, 21, 15, 17, 5, 5, 1, 1, 1, 1, 1, 1, 1, 4); // 0x866
            private static Player Xene = new Player(178, 92, 79, 79, 73, 63, 62, 68, 63, 487, 82, 59, 18, 18, 18, 19, 20, 18, 20, 4, 5, 2, 2, 2, 2, 2, 2, 2, 5); // 0x867
            private static Player Dvalin2 = new Player(195, 72, 85, 80, 57, 55, 75, 69, 54, 475, 54, 66, 21, 19, 16, 17, 22, 17, 20, 1, 5, 1, 1, 1, 1, 1, 1, 1, 5); // 0x871
            private static Player Kenville2 = new Player(143, 77, 56, 62, 69, 57, 65, 71, 53, 433, 64, 49, 16, 17, 16, 18, 20, 17, 20, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2); // 0x872
            private static Player Mole2 = new Player(162, 97, 63, 63, 74, 56, 73, 55, 55, 439, 55, 51, 18, 13, 18, 18, 22, 16, 17, 2, 5, 2, 2, 2, 2, 2, 2, 2, 1); // 0x873
            private static Player Kayson2 = new Player(154, 85, 63, 61, 64, 65, 68, 67, 68, 456, 69, 51, 20, 18, 16, 18, 22, 18, 17, 4, 5, 4, 4, 4, 4, 4, 4, 4, 2); // 0x874
            private static Player Tytan2 = new Player(209, 84, 75, 68, 55, 61, 56, 71, 72, 458, 67, 39, 18, 16, 19, 20, 21, 20, 20, 2, 5, 2, 2, 2, 2, 2, 2, 2, 1); // 0x875
            private static Player Fedora2 = new Player(151, 93, 71, 57, 68, 57, 61, 54, 65, 433, 45, 44, 18, 10, 19, 12, 23, 20, 17, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x876
            private static Player Krypto2 = new Player(140, 81, 62, 63, 62, 56, 68, 57, 58, 426, 42, 64, 16, 15, 16, 15, 21, 17, 18, 4, 5, 4, 4, 4, 4, 4, 4, 4, 2); // 0x877
            private static Player Sworm2 = new Player(162, 84, 62, 65, 68, 68, 72, 62, 60, 457, 67, 48, 17, 16, 19, 15, 23, 18, 16, 4, 5, 4, 4, 4, 4, 4, 4, 4, 1); // 0x878
            private static Player Mercury2 = new Player(171, 92, 61, 62, 61, 52, 79, 57, 61, 433, 70, 48, 16, 15, 18, 19, 23, 20, 13, 3, 5, 3, 3, 3, 3, 3, 3, 3, 4); // 0x879
            private static Player Metron2 = new Player(149, 77, 66, 68, 67, 68, 68, 65, 68, 470, 56, 49, 20, 17, 18, 18, 20, 19, 17, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x87A
            private static Player Zell2 = new Player(193, 96, 73, 66, 53, 76, 60, 73, 70, 471, 76, 33, 20, 17, 19, 14, 22, 20, 19, 2, 5, 2, 2, 2, 2, 2, 2, 2, 5); // 0x87B
            private static Player Cam_Mando = new Player(213, 197, 76, 74, 72, 78, 68, 77, 68, 513, 67, 99, 18, 20, 20, 21, 20, 17, 18, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x885
            private static Player Harry_Boufante = new Player(187, 193, 79, 79, 72, 79, 76, 71, 79, 535, 82, 85, 16, 18, 17, 21, 18, 17, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x886
            private static Player Todd_Stuhl = new Player(191, 185, 76, 68, 69, 77, 78, 73, 72, 513, 66, 89, 20, 18, 17, 20, 20, 18, 19, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x887
            private static Player Aspen_Blewit = new Player(211, 169, 70, 72, 71, 79, 76, 75, 70, 513, 68, 82, 17, 20, 17, 21, 18, 20, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x888
            private static Player Marismus_Oregon = new Player(200, 184, 73, 68, 68, 79, 68, 75, 79, 510, 79, 90, 20, 19, 18, 21, 20, 19, 18, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x889
            private static Player Garjan_Cypress = new Player(195, 181, 69, 79, 72, 78, 78, 78, 79, 533, 82, 88, 18, 23, 17, 18, 21, 20, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x88A
            private static Player Judas_Deathcap = new Player(198, 169, 70, 79, 70, 71, 79, 79, 68, 516, 72, 80, 17, 21, 19, 18, 23, 18, 16, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x88B
            private static Player Chase_Faithfull = new Player(189, 172, 72, 79, 79, 76, 79, 73, 70, 528, 75, 81, 19, 20, 19, 17, 19, 18, 19, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x88C
            private static Player Chris_Ticker = new Player(204, 180, 72, 77, 79, 70, 79, 77, 69, 523, 69, 86, 18, 18, 21, 16, 22, 19, 16, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x88D
            private static Player Roy_Daring = new Player(217, 197, 79, 68, 79, 70, 70, 70, 69, 505, 74, 107, 21, 18, 18, 17, 20, 16, 20, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x88E
            private static Player Scaber_Enoki = new Player(191, 197, 79, 76, 69, 76, 74, 76, 78, 528, 68, 101, 23, 18, 18, 16, 16, 18, 19, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x88F
            private static Player Robot_S = new Player(191, 176, 60, 63, 53, 70, 55, 78, 68, 447, 78, 60, 14, 14, 11, 14, 10, 20, 16, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x899
            private static Player Robot_P = new Player(187, 173, 56, 52, 52, 62, 52, 70, 66, 410, 73, 80, 12, 14, 10, 17, 10, 19, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x89A
            private static Player Robot_T = new Player(213, 168, 62, 52, 59, 66, 56, 68, 66, 429, 75, 68, 12, 12, 11, 16, 12, 17, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x89B
            private static Player Robot_V = new Player(187, 168, 57, 56, 58, 70, 60, 77, 60, 438, 75, 80, 14, 14, 13, 15, 12, 18, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x89C
            private static Player Robot_C = new Player(217, 153, 58, 62, 62, 63, 57, 78, 61, 441, 79, 72, 13, 13, 12, 16, 12, 19, 15, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x89D
            private static Player Robot_O = new Player(211, 157, 52, 60, 53, 56, 62, 69, 64, 416, 78, 78, 12, 13, 12, 12, 13, 20, 16, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1); // 0x89E
            private static Player Robot_B = new Player(215, 157, 61, 62, 60, 52, 57, 69, 61, 422, 79, 66, 13, 15, 11, 13, 11, 19, 14, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x89F
            private static Player Robot_G = new Player(200, 176, 58, 54, 63, 60, 54, 70, 65, 424, 67, 72, 12, 12, 17, 12, 10, 17, 15, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x8A0
            private static Player Robot_K = new Player(187, 153, 57, 55, 64, 52, 52, 70, 71, 421, 73, 72, 12, 12, 17, 13, 10, 20, 15, 2, 4, 2, 3, 4, 2, 1, 2, 1, 1); // 0x8A1
            private static Player Robot_F = new Player(215, 160, 63, 59, 55, 58, 62, 69, 62, 428, 78, 72, 14, 11, 10, 10, 16, 18, 15, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x8A2
            private static Player Robot_L = new Player(198, 157, 68, 53, 58, 55, 52, 70, 68, 424, 68, 72, 15, 10, 13, 11, 10, 16, 16, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x8A3
            private static Player Seymour_Hillman_young = new Player(213, 173, 61, 60, 69, 65, 60, 74, 77, 466, 51, 76, 16, 17, 13, 13, 16, 19, 18, 2, 1, 2, 1, 1, 2, 1, 2, 3, 3); // 0x8AD
            private static Player Charles_Island_young = new Player(204, 197, 62, 64, 68, 67, 75, 71, 66, 473, 32, 66, 12, 14, 14, 10, 13, 14, 12, 1, 1, 4, 2, 2, 4, 1, 1, 1, 2); // 0x8AE
            private static Player Garret_Hairtown_young = new Player(215, 152, 68, 75, 64, 68, 66, 70, 68, 479, 40, 78, 9, 12, 11, 11, 11, 14, 10, 2, 4, 2, 3, 4, 2, 1, 2, 1, 3); // 0x8AF
            private static Player Arthur_Sweet_young = new Player(213, 185, 65, 79, 76, 73, 60, 68, 67, 488, 36, 80, 8, 8, 7, 13, 11, 10, 9, 1, 2, 2, 2, 3, 2, 1, 1, 4, 1); // 0x8B0
            private static Player Peter_Mildred_young = new Player(195, 193, 68, 64, 63, 63, 61, 68, 78, 465, 42, 72, 11, 9, 8, 8, 9, 10, 11, 2, 1, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8B1
            private static Player Josh_Nathaniel_young = new Player(187, 180, 68, 78, 75, 68, 79, 76, 78, 522, 39, 78, 10, 8, 13, 8, 11, 9, 9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x8B2
            private static Player Edward_Gladstone_young = new Player(215, 192, 68, 61, 67, 62, 68, 69, 70, 465, 46, 78, 15, 14, 14, 15, 16, 20, 17, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x8B3
            private static Player Tyler_Thomas_young = new Player(211, 189, 70, 63, 70, 62, 62, 70, 73, 470, 58, 68, 15, 17, 17, 14, 13, 20, 17, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x8B4
            private static Player Joseph_Yosemite_young = new Player(209, 173, 69, 64, 62, 65, 60, 68, 69, 457, 43, 68, 16, 15, 13, 15, 14, 18, 16, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x8B5
            private static Player Ian_Suffolk_young = new Player(217, 177, 64, 70, 69, 60, 61, 73, 76, 473, 45, 60, 16, 14, 15, 17, 16, 16, 20, 2, 1, 2, 1, 1, 2, 1, 2, 3, 1); // 0x8B6
            private static Player Constant_Builder_young = new Player(189, 188, 63, 61, 63, 62, 60, 78, 72, 459, 44, 74, 13, 16, 15, 17, 13, 18, 19, 2, 1, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8B7
            private static Player Grent = new Player(182, 81, 78, 60, 52, 61, 52, 56, 60, 419, 50, 64, 11, 19, 19, 22, 21, 16, 15, 1, 5, 4, 2, 2, 4, 1, 1, 1, 4); // 0x8C1
            private static Player Baller = new Player(187, 93, 65, 64, 62, 65, 61, 58, 71, 446, 50, 60, 13, 14, 15, 16, 23, 17, 20, 1, 5, 4, 2, 2, 4, 1, 1, 1, 2); // 0x8C2
            private static Player Balcke = new Player(178, 69, 71, 64, 57, 63, 57, 60, 62, 434, 48, 48, 10, 15, 17, 16, 23, 14, 20, 1, 5, 2, 2, 3, 2, 1, 1, 4, 1); // 0x8C3
            private static Player Seats = new Player(184, 93, 66, 62, 63, 68, 56, 56, 70, 441, 48, 60, 10, 14, 15, 17, 19, 15, 20, 1, 5, 4, 2, 2, 4, 1, 1, 1, 1); // 0x8C4
            private static Player Bomber = new Player(200, 85, 55, 63, 68, 62, 64, 70, 65, 447, 46, 62, 17, 16, 18, 15, 21, 17, 17, 2, 5, 2, 1, 1, 2, 1, 2, 3, 3); // 0x8C5
            private static Player Heat = new Player(193, 72, 52, 79, 60, 60, 62, 71, 55, 439, 70, 56, 18, 18, 14, 14, 23, 16, 15, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8C6
            private static Player Lean = new Player(217, 97, 55, 72, 70, 63, 69, 61, 52, 442, 63, 68, 16, 16, 17, 15, 23, 16, 15, 2, 5, 2, 1, 1, 2, 1, 2, 3, 1); // 0x8C7
            private static Player Bountine = new Player(211, 69, 63, 62, 67, 62, 68, 67, 64, 453, 45, 60, 17, 13, 17, 14, 20, 19, 17, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8C8
            private static Player Sidern = new Player(171, 96, 52, 69, 59, 52, 62, 70, 69, 433, 79, 74, 16, 17, 14, 14, 21, 20, 19, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8C9
            private static Player Claude_Beacons = new Player(187, 96, 69, 71, 64, 64, 66, 70, 63, 467, 67, 79, 21, 20, 17, 15, 23, 17, 18, 2, 5, 2, 1, 1, 2, 1, 2, 3, 4); // 0x8CA
            private static Player Neppten = new Player(180, 93, 60, 65, 61, 63, 61, 67, 60, 437, 79, 80, 18, 13, 15, 17, 19, 19, 18, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8CB
            private static Player Beluga = new Player(193, 85, 70, 68, 53, 66, 60, 60, 64, 441, 50, 79, 11, 17, 20, 19, 23, 16, 15, 1, 5, 2, 2, 3, 2, 1, 1, 4, 2); // 0x8D5
            private static Player Arkew = new Player(176, 80, 70, 67, 56, 60, 62, 52, 69, 436, 43, 80, 13, 19, 20, 19, 21, 14, 13, 1, 5, 4, 2, 2, 4, 1, 1, 1, 1); // 0x8D6
            private static Player Clear = new Player(167, 84, 65, 67, 60, 62, 60, 60, 68, 442, 58, 60, 12, 14, 16, 18, 21, 17, 17, 1, 5, 2, 2, 3, 2, 1, 1, 4, 5); // 0x8D7
            private static Player Gocker = new Player(195, 96, 69, 70, 52, 64, 53, 54, 63, 425, 49, 88, 12, 19, 20, 18, 23, 14, 17, 1, 5, 2, 2, 3, 2, 1, 1, 4, 2); // 0x8D8
            private static Player Icer = new Player(213, 93, 58, 68, 63, 60, 70, 65, 54, 438, 61, 80, 17, 16, 16, 16, 22, 18, 15, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8D9
            private static Player Balen = new Player(211, 79, 58, 69, 67, 58, 64, 60, 62, 438, 57, 64, 18, 18, 16, 17, 19, 20, 14, 2, 5, 2, 1, 1, 2, 1, 2, 3, 3); // 0x8DA
            private static Player Droll = new Player(198, 84, 62, 68, 62, 59, 69, 62, 61, 443, 52, 72, 18, 14, 20, 16, 22, 20, 17, 2, 5, 2, 1, 1, 2, 1, 2, 3, 5); // 0x8DB
            private static Player Rhine = new Player(215, 79, 63, 71, 61, 55, 60, 60, 60, 430, 46, 64, 16, 16, 17, 14, 20, 19, 16, 2, 5, 2, 1, 1, 2, 1, 2, 3, 3); // 0x8DC
            private static Player Blown = new Player(189, 77, 59, 60, 56, 55, 68, 65, 64, 427, 54, 70, 13, 16, 15, 13, 20, 16, 17, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8DD
            private static Player Bryce_Whitingale = new Player(189, 96, 78, 65, 76, 74, 66, 67, 68, 494, 81, 79, 22, 14, 22, 21, 21, 17, 20, 2, 5, 2, 1, 1, 2, 1, 2, 3, 4); // 0x8DE
            private static Player Frost = new Player(182, 81, 60, 64, 62, 56, 68, 68, 63, 441, 62, 64, 13, 15, 14, 14, 20, 17, 18, 2, 5, 2, 1, 1, 2, 1, 2, 3, 2); // 0x8DF
            private static Player Ken_Ironwall = new Player(206, 145, 68, 69, 60, 66, 52, 68, 56, 439, 44, 62, 18, 16, 14, 14, 14, 16, 13, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x8FD
            private static Player Timothy_Western = new Player(143, 144, 57, 60, 74, 61, 69, 53, 63, 437, 37, 48, 10, 14, 12, 13, 17, 13, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x8FE
            private static Player Wallace_Hammond = new Player(129, 120, 65, 63, 68, 56, 68, 52, 59, 431, 48, 55, 14, 11, 18, 11, 21, 12, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x8FF
            private static Player Shirley_Stevens = new Player(173, 176, 64, 60, 59, 60, 56, 60, 54, 413, 54, 76, 17, 15, 12, 16, 12, 14, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x900
            private static Player Ian_Smith = new Player(167, 157, 71, 67, 64, 58, 56, 66, 61, 443, 54, 62, 13, 17, 11, 11, 14, 20, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0x901
            private static Player Taylor_Firepool = new Player(169, 136, 57, 57, 62, 66, 60, 56, 61, 419, 40, 47, 10, 11, 13, 11, 13, 13, 13, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x902
            private static Player Marge_Fielding = new Player(129, 129, 60, 58, 64, 53, 69, 58, 60, 422, 33, 66, 14, 12, 13, 14, 17, 10, 14, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x903
            private static Player Marshall_Firsthand = new Player(169, 161, 63, 58, 55, 55, 68, 62, 62, 423, 33, 54, 12, 16, 11, 14, 12, 12, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0x904
            private static Player Holly_Mirror = new Player(138, 117, 67, 64, 60, 71, 60, 68, 64, 454, 50, 55, 19, 13, 15, 13, 14, 20, 19, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0x905
            private static Player Victoria_Vanguard = new Player(167, 176, 70, 69, 78, 66, 52, 69, 67, 471, 50, 48, 15, 11, 16, 10, 19, 20, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x906
            private static Player Joe_Kenneddy = new Player(169, 129, 60, 68, 65, 64, 53, 57, 56, 423, 49, 66, 18, 12, 18, 13, 17, 18, 20, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x907
            private static Player Ian_Sights = new Player(171, 132, 52, 58, 60, 63, 69, 65, 62, 429, 36, 78, 17, 18, 17, 17, 11, 12, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0x908
            private static Player Greene_Beray = new Player(123, 133, 63, 60, 73, 54, 52, 54, 60, 416, 40, 85, 14, 13, 7, 10, 11, 8, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x909
            private static Player Ryan_Tappin = new Player(160, 132, 68, 48, 68, 52, 54, 58, 59, 407, 46, 48, 17, 15, 13, 16, 12, 13, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x90A
            private static Player Linda_Shadey = new Player(129, 112, 69, 67, 70, 60, 54, 57, 56, 433, 27, 35, 12, 11, 13, 10, 10, 10, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x90B
            private static Player Sid_Safehouse = new Player(169, 117, 59, 67, 59, 71, 57, 64, 58, 435, 63, 68, 9, 15, 17, 17, 10, 14, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x90C
            private static Player Adam_Ropes = new Player(195, 129, 62, 56, 62, 62, 77, 67, 66, 452, 73, 76, 18, 17, 17, 15, 13, 14, 13, 1, 4, 4, 4, 4, 1, 4, 1, 4, 1); // 0x911
            private static Player Joaquine_Downtown = new Player(127, 133, 57, 54, 68, 59, 58, 56, 60, 412, 57, 55, 13, 13, 15, 15, 15, 12, 19, 1, 4, 4, 4, 4, 4, 4, 1, 4, 5); // 0x912
            private static Player Milton_Bindings = new Player(169, 153, 52, 67, 57, 55, 54, 60, 62, 407, 58, 48, 16, 15, 15, 19, 17, 16, 16, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x913
            private static Player Spike_Gleeson = new Player(154, 149, 60, 63, 65, 52, 52, 60, 69, 421, 58, 66, 19, 19, 20, 20, 20, 13, 13, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x914
            private static Player Sean_Snowfield = new Player(195, 169, 59, 65, 60, 72, 72, 76, 68, 472, 32, 51, 17, 14, 15, 12, 7, 11, 16, 2, 4, 4, 4, 4, 2, 4, 2, 4, 4); // 0x915
            private static Player Kerry_Bootgaiter = new Player(154, 136, 62, 59, 57, 60, 63, 64, 60, 425, 42, 64, 14, 13, 14, 15, 18, 13, 16, 2, 4, 4, 4, 4, 4, 4, 2, 4, 5); // 0x916
            private static Player Maddox_Rock = new Player(167, 140, 56, 60, 61, 54, 61, 53, 65, 410, 52, 60, 14, 15, 13, 18, 14, 12, 15, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x917
            private static Player Robert_Skipolson = new Player(132, 137, 56, 52, 62, 53, 68, 54, 55, 400, 42, 60, 13, 16, 18, 16, 15, 11, 14, 1, 4, 4, 4, 4, 4, 4, 1, 4, 5); // 0x918
            private static Player Shawn_Froste = new Player(187, 136, 72, 71, 68, 64, 68, 69, 53, 465, 56, 66, 16, 14, 16, 15, 18, 14, 14, 1, 2, 4, 2, 2, 2, 2, 1, 4, 2); // 0x919
            private static Player Roland_Climbstein = new Player(156, 129, 65, 62, 52, 59, 58, 58, 61, 415, 58, 36, 19, 16, 16, 18, 16, 14, 14, 1, 4, 1, 1, 4, 4, 4, 1, 4, 2); // 0x91A
            private static Player Quentin_Rackner = new Player(145, 149, 56, 57, 56, 58, 64, 65, 64, 420, 52, 59, 20, 13, 14, 18, 17, 15, 18, 1, 4, 4, 4, 4, 4, 4, 1, 4, 4); // 0x91B
            private static Player Trent_Peggs = new Player(147, 144, 60, 60, 59, 66, 57, 66, 78, 446, 56, 64, 17, 15, 16, 17, 10, 11, 16, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x91C
            private static Player Martin_Ursus = new Player(189, 132, 60, 69, 56, 68, 56, 58, 56, 423, 57, 51, 13, 19, 11, 12, 12, 18, 19, 1, 4, 4, 4, 4, 4, 4, 1, 4, 1); // 0x91D
            private static Player Pete_Bogg = new Player(123, 109, 60, 54, 69, 57, 60, 53, 58, 411, 43, 66, 18, 17, 11, 16, 17, 15, 16, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x91E
            private static Player Gem_Strata = new Player(143, 116, 56, 57, 52, 53, 60, 53, 60, 391, 44, 64, 17, 16, 14, 20, 16, 20, 13, 1, 4, 4, 4, 4, 4, 4, 1, 4, 3); // 0x91F
            private static Player Horace_Onlign = new Player(132, 113, 55, 63, 52, 52, 60, 58, 60, 400, 51, 35, 14, 14, 17, 16, 14, 17, 15, 1, 4, 4, 4, 4, 4, 4, 1, 4, 1); // 0x920
            private static Player Shawn_Froste_Aiden = new Player(187, 136, 76, 69, 64, 68, 77, 60, 50, 464, 56, 66, 20, 15, 14, 11, 18, 16, 13, 1, 2, 2, 2, 1, 4, 2, 1, 2, 2); // 0x921
            private static Player Shawn_Froste_Fusion = new Player(190, 140, 80, 71, 68, 68, 77, 70, 57, 491, 56, 66, 16, 14, 16, 14, 20, 17, 13, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2); // 0x922
            private static Player Crane_Kik = new Player(200, 149, 71, 71, 76, 62, 58, 75, 69, 482, 36, 68, 19, 14, 17, 16, 15, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0x925
            private static Player Parry_Waxon = new Player(171, 129, 64, 64, 68, 64, 62, 60, 60, 442, 52, 76, 14, 19, 17, 17, 17, 16, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x926
            private static Player Bri_Spark = new Player(187, 149, 56, 53, 62, 52, 57, 69, 64, 413, 45, 70, 17, 19, 17, 17, 17, 15, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x927
            private static Player Max_Fortune = new Player(213, 129, 56, 67, 55, 59, 68, 71, 70, 446, 45, 74, 17, 15, 17, 14, 18, 15, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x928
            private static Player Brendan_Water = new Player(193, 144, 53, 58, 67, 56, 62, 59, 53, 408, 56, 55, 15, 18, 13, 17, 16, 20, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x929
            private static Player Junior_Fardream = new Player(187, 153, 58, 53, 70, 62, 60, 66, 63, 432, 55, 80, 13, 17, 16, 15, 13, 16, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x92A
            private static Player Ian_Telektual = new Player(191, 149, 60, 57, 62, 52, 61, 69, 56, 417, 55, 64, 19, 16, 15, 18, 17, 17, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x92B
            private static Player Lee_Dinglite = new Player(184, 164, 57, 52, 70, 61, 56, 68, 64, 428, 48, 48, 20, 15, 18, 13, 16, 16, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x92C
            private static Player Marshall_Artz = new Player(215, 160, 63, 56, 68, 63, 68, 74, 76, 468, 62, 93, 14, 11, 16, 18, 16, 15, 18, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x92D
            private static Player Tyke_Wando = new Player(149, 132, 60, 56, 65, 61, 70, 58, 55, 425, 58, 66, 17, 15, 14, 14, 18, 17, 20, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x92E
            private static Player Dirk_Artz = new Player(154, 180, 77, 55, 68, 57, 72, 52, 71, 452, 49, 66, 18, 11, 13, 19, 17, 17, 16, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x92F
            private static Player Scott_Banyan = new Player(198, 160, 63, 71, 64, 64, 65, 61, 70, 458, 54, 80, 12, 15, 15, 18, 17, 17, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x930
            private static Player Earnest_Bookworm = new Player(162, 145, 53, 70, 60, 60, 55, 55, 70, 423, 44, 54, 13, 17, 13, 17, 11, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x931
            private static Player Ollie_Gami = new Player(171, 133, 62, 57, 59, 58, 57, 60, 58, 411, 52, 59, 12, 17, 11, 15, 16, 17, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x932
            private static Player Roman_Kandel = new Player(176, 149, 60, 61, 54, 52, 57, 58, 60, 402, 40, 76, 18, 19, 17, 13, 16, 17, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x933
            private static Player Don_Ation = new Player(151, 165, 69, 60, 54, 57, 52, 56, 57, 405, 37, 64, 11, 15, 16, 12, 10, 16, 18, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x934
            private static Player Scott_Banyan_FW = new Player(198, 160, 76, 82, 82, 59, 64, 72, 80, 515, 54, 80, 12, 15, 15, 18, 17, 17, 14, 4, 4, 4, 2, 2, 4, 4, 4, 2, 3); // 0x935
            private static Player Joseph_King_Redux = new Player(200, 153, 72, 75, 69, 72, 55, 74, 60, 477, 55, 96, 15, 11, 13, 16, 13, 14, 14, 1, 3, 1, 2, 1, 3, 1, 1, 2, 1); // 0x939
            private static Player Rowan_Beltzer = new Player(149, 136, 60, 62, 63, 60, 64, 69, 58, 436, 61, 78, 17, 17, 11, 15, 18, 13, 17, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1); // 0x93A
            private static Player Blade_Healen = new Player(147, 136, 53, 56, 70, 60, 62, 63, 62, 426, 62, 93, 14, 13, 11, 14, 20, 16, 17, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2); // 0x93B
            private static Player Argie_Bargie = new Player(200, 153, 76, 60, 62, 64, 64, 79, 60, 465, 61, 92, 16, 17, 15, 18, 10, 14, 17, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1); // 0x93C
            private static Player Lee_Bamboo = new Player(149, 137, 68, 62, 68, 69, 62, 59, 62, 450, 63, 78, 17, 14, 10, 16, 18, 17, 12, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1); // 0x93D
            private static Player Eton_Messer = new Player(154, 165, 60, 63, 70, 52, 68, 56, 67, 436, 57, 88, 11, 16, 18, 17, 17, 15, 17, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1); // 0x93E
            private static Player Jonah_Spark = new Player(195, 156, 62, 64, 61, 62, 70, 63, 74, 456, 49, 76, 11, 11, 14, 12, 15, 13, 14, 1, 2, 1, 2, 1, 1, 2, 1, 1, 1); // 0x93F
            private static Player Sue_Sparrow = new Player(158, 164, 57, 63, 64, 54, 62, 59, 60, 419, 66, 103, 16, 12, 11, 11, 17, 10, 14, 1, 2, 1, 2, 3, 1, 2, 1, 1, 2); // 0x940
            private static Player Riley_Jamm = new Player(154, 129, 70, 55, 64, 64, 60, 69, 60, 442, 48, 99, 18, 19, 16, 20, 17, 13, 18, 1, 2, 1, 2, 1, 1, 1, 2, 1, 2); // 0x941
            private static Player Caleb_Stonewall = new Player(182, 169, 75, 60, 78, 60, 64, 66, 69, 472, 55, 99, 18, 16, 15, 10, 19, 18, 18, 1, 3, 1, 2, 1, 1, 1, 2, 2, 4); // 0x942
            private static Player David_Samford_Redux = new Player(193, 193, 70, 60, 78, 66, 66, 67, 71, 478, 62, 90, 16, 12, 17, 13, 17, 13, 16, 1, 3, 3, 2, 3, 1, 1, 2, 2, 3); // 0x943
            private static Player Jimbo_Cellar = new Player(165, 149, 52, 76, 56, 72, 54, 63, 68, 441, 76, 72, 13, 16, 14, 15, 14, 10, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x944
            private static Player Zenn_Wildhorse = new Player(165, 137, 60, 57, 61, 61, 60, 56, 64, 419, 48, 54, 16, 16, 17, 14, 17, 13, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x945
            private static Player Dawson_Little = new Player(169, 153, 73, 54, 61, 54, 65, 60, 53, 420, 60, 58, 10, 14, 17, 14, 14, 12, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x946
            private static Player Cosimo_Beck = new Player(149, 132, 59, 52, 63, 60, 61, 52, 68, 415, 62, 64, 20, 14, 20, 13, 12, 10, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x947
            private static Player Maston_Color = new Player(169, 156, 68, 53, 59, 64, 53, 66, 69, 432, 55, 60, 10, 18, 14, 10, 19, 13, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x948
            private static Player Darren_LaChance = new Player(217, 157, 60, 76, 66, 79, 56, 71, 64, 472, 42, 47, 14, 14, 19, 16, 15, 18, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x94D
            private static Player Drancis_Fake = new Player(162, 160, 55, 56, 60, 55, 60, 60, 60, 406, 62, 54, 15, 20, 14, 16, 19, 16, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x94E
            private static Player Mick_Mishap = new Player(160, 136, 60, 60, 53, 60, 59, 66, 60, 418, 58, 51, 18, 20, 13, 15, 13, 20, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x94F
            private static Player Louis_Leave = new Player(191, 129, 69, 63, 60, 70, 60, 64, 52, 438, 67, 51, 20, 14, 16, 16, 11, 20, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x950
            private static Player Maurice_Badgame = new Player(206, 133, 73, 66, 52, 60, 57, 65, 71, 444, 49, 56, 14, 19, 20, 18, 17, 18, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x951
            private static Player Cannon_Random = new Player(169, 148, 53, 62, 60, 53, 68, 63, 55, 414, 54, 51, 17, 14, 13, 11, 20, 17, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x952
            private static Player Ulric_Richmen = new Player(151, 133, 62, 61, 59, 55, 57, 61, 58, 413, 54, 66, 18, 17, 20, 17, 17, 20, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x953
            private static Player Dave_Fate = new Player(143, 136, 54, 64, 54, 56, 70, 62, 61, 421, 60, 39, 14, 17, 17, 13, 16, 11, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x954
            private static Player Spencer_Duskplay = new Player(147, 140, 77, 52, 62, 57, 52, 64, 53, 417, 64, 56, 16, 17, 19, 16, 15, 18, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x955
            private static Player Jonathan_Luckyman = new Player(173, 149, 65, 62, 62, 71, 69, 61, 64, 454, 68, 49, 18, 17, 20, 13, 20, 16, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4); // 0x956
            private static Player Joe_Poker = new Player(158, 129, 54, 62, 63, 55, 67, 55, 64, 420, 57, 63, 15, 13, 11, 11, 17, 18, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x957
            private static Player Wiley_Cracker = new Player(138, 140, 52, 64, 56, 66, 60, 56, 56, 410, 44, 51, 19, 18, 11, 19, 16, 10, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x958
            private static Player Mark_Failing = new Player(145, 133, 61, 61, 56, 57, 54, 54, 55, 398, 38, 68, 16, 20, 17, 15, 12, 14, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x959
            private static Player Alton_Cotts = new Player(171, 169, 60, 68, 62, 71, 54, 68, 71, 454, 55, 48, 13, 18, 11, 19, 10, 12, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x95A
            private static Player Mike_Passing = new Player(127, 141, 52, 56, 71, 57, 68, 57, 63, 424, 36, 37, 14, 12, 20, 12, 13, 14, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x95B
            private static Player Knowle_Bathers = new Player(180, 100, 59, 59, 52, 58, 59, 71, 62, 420, 78, 45, 17, 16, 12, 15, 14, 18, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x95C
            private static Player Rocky_Black = new Player(204, 104, 76, 72, 52, 76, 50, 72, 72, 470, 70, 60, 18, 20, 14, 18, 15, 20, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x961
            private static Player Chad_Taylor = new Player(165, 140, 61, 55, 60, 53, 58, 61, 57, 405, 70, 72, 15, 20, 16, 20, 16, 18, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x962
            private static Player Victor_Hills = new Player(191, 140, 68, 61, 64, 71, 52, 60, 68, 444, 57, 76, 17, 19, 14, 18, 17, 15, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x963
            private static Player Hurley_Kane = new Player(171, 145, 72, 70, 71, 73, 71, 71, 65, 493, 68, 62, 21, 20, 17, 17, 15, 17, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4); // 0x964
            private static Player Hector_Redding = new Player(145, 145, 62, 57, 63, 54, 56, 62, 56, 410, 55, 66, 12, 15, 16, 19, 16, 20, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x965
            private static Player Mackenzie_Fordline = new Player(158, 156, 60, 57, 53, 56, 61, 53, 60, 400, 55, 45, 13, 13, 20, 20, 17, 17, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x966
            private static Player Cadence_Soundtown = new Player(173, 149, 61, 56, 62, 62, 60, 63, 60, 424, 78, 76, 14, 20, 19, 18, 17, 13, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x967
            private static Player Dora_Delight = new Player(173, 109, 59, 60, 53, 55, 52, 59, 60, 398, 56, 60, 15, 18, 17, 19, 17, 18, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x968
            private static Player Tom_Contented = new Player(160, 141, 64, 60, 69, 52, 54, 59, 59, 417, 42, 56, 20, 18, 19, 18, 20, 19, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x969
            private static Player Joston_Easton = new Player(165, 164, 61, 67, 60, 66, 68, 64, 55, 441, 55, 70, 20, 19, 18, 20, 18, 17, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x96A
            private static Player Spring_Millpond = new Player(209, 129, 59, 63, 76, 60, 77, 57, 55, 447, 55, 81, 20, 19, 20, 20, 17, 14, 15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4); // 0x96B
            private static Player Gaston_Cooley = new Player(173, 137, 57, 63, 52, 64, 59, 59, 66, 420, 57, 89, 10, 18, 19, 18, 15, 14, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x96C
            private static Player Bevan_Breakfast = new Player(151, 113, 58, 66, 71, 62, 61, 52, 70, 440, 54, 45, 13, 17, 18, 20, 16, 18, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x96D
            private static Player Jack_Griddle = new Player(165, 140, 60, 53, 58, 56, 61, 62, 61, 411, 57, 41, 14, 10, 19, 17, 15, 15, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x96E
            private static Player Stan_Andagi = new Player(162, 120, 65, 52, 58, 61, 56, 68, 69, 429, 58, 72, 15, 14, 15, 19, 12, 18, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x96F
            private static Player Coral_Talent = new Player(151, 157, 63, 52, 57, 63, 65, 58, 60, 418, 57, 22, 10, 10, 20, 13, 17, 10, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5); // 0x970
            private static Player Thomas_Feldt_DE = new Player(238, 240, 75, 75, 79, 93, 69, 80, 79, 550, 88, 110, 19, 19, 17, 23, 18, 17, 19, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0x975
            private static Player Malcolm_Night_DE = new Player(236, 208, 86, 75, 93, 93, 79, 83, 83, 592, 72, 79, 20, 20, 22, 22, 19, 18, 17, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0x976
            private static Player Shadow_Cimmerian_DE = new Player(234, 225, 93, 79, 77, 85, 93, 78, 74, 579, 86, 84, 22, 17, 22, 20, 20, 19, 19, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0x977
            private static Player Jim_Wraith_DE = new Player(236, 201, 70, 74, 93, 93, 68, 74, 74, 546, 85, 81, 18, 16, 25, 25, 15, 15, 17, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3); // 0x978
            private static Player Tod_Ironside_DE = new Player(217, 199, 78, 77, 93, 75, 72, 66, 93, 554, 77, 75, 14, 18, 25, 16, 16, 15, 25, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0x979
            private static Player Steve_Grim_DE = new Player(214, 213, 85, 86, 85, 74, 84, 85, 85, 584, 46, 67, 13, 7, 9, 11, 7, 9, 8, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x97A
            private static Player Tim_Saunders_DE = new Player(210, 225, 80, 74, 93, 93, 69, 93, 70, 572, 61, 89, 19, 14, 25, 24, 16, 23, 17, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0x97B
            private static Player Sam_Kincaid_DE = new Player(212, 192, 75, 70, 69, 93, 77, 66, 93, 543, 70, 74, 20, 18, 16, 25, 16, 14, 24, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x97C
            private static Player Maxwell_Carson_DE = new Player(195, 223, 74, 93, 93, 82, 77, 70, 75, 564, 59, 83, 16, 25, 23, 19, 22, 16, 18, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1); // 0x97D
            private static Player Nathan_Swift_DE = new Player(238, 218, 93, 74, 83, 71, 93, 93, 66, 573, 101, 81, 22, 16, 18, 17, 24, 24, 18, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x97E
            private static Player Kevin_Dragonfly_DE = new Player(232, 240, 93, 74, 70, 75, 64, 77, 83, 536, 77, 117, 24, 17, 14, 18, 17, 18, 19, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2); // 0x97F
            private static Player Daisy_Fields = new Player(182, 133, 60, 61, 70, 67, 69, 52, 71, 450, 67, 80, 16, 18, 14, 19, 13, 20, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4); // 0x989
            private static Player Alexia_Sand = new Player(151, 137, 61, 56, 61, 65, 60, 52, 52, 407, 48, 54, 17, 20, 19, 15, 17, 19, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5); // 0x98A
            private static Player Hellen_Hearth = new Player(123, 144, 63, 52, 56, 55, 60, 55, 57, 398, 48, 52, 17, 17, 18, 11, 11, 20, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x98B
            private static Player Rose_Pinkpetal = new Player(138, 133, 52, 60, 68, 60, 66, 52, 52, 410, 54, 55, 14, 18, 19, 19, 18, 14, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x98C
            private static Player Esther_Greenland = new Player(154, 132, 62, 67, 60, 58, 68, 52, 63, 430, 58, 66, 17, 20, 19, 13, 14, 18, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x98D
            private static Player Bela_Bluebells = new Player(125, 116, 56, 55, 64, 63, 61, 63, 59, 421, 55, 48, 14, 16, 18, 17, 16, 15, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x98E
            private static Player Natalie_Sunrise = new Player(160, 156, 57, 58, 63, 57, 67, 60, 58, 420, 50, 64, 19, 17, 16, 17, 16, 15, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x98F
            private static Player Hillary_Bush = new Player(143, 132, 63, 66, 59, 71, 53, 60, 54, 426, 68, 66, 16, 14, 14, 20, 16, 18, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x990
            private static Player Mary_Moor = new Player(143, 129, 56, 65, 58, 56, 66, 54, 69, 424, 82, 64, 18, 15, 14, 17, 19, 15, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x991
            private static Player Suzette_Hartland = new Player(162, 153, 62, 65, 70, 62, 68, 60, 64, 451, 61, 81, 20, 18, 16, 16, 18, 16, 18, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x992
            private static Player Lily_Willow = new Player(151, 132, 67, 64, 62, 63, 53, 56, 61, 426, 56, 72, 19, 13, 20, 15, 17, 18, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4); // 0x993
            private static Player Dell_Closeout = new Player(145, 133, 52, 60, 52, 60, 55, 58, 52, 389, 50, 63, 10, 19, 15, 16, 14, 16, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0x994
            private static Player Amy_Spires = new Player(121, 112, 54, 55, 56, 55, 52, 60, 52, 384, 44, 49, 17, 20, 18, 16, 11, 16, 17, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x995
            private static Player Peony_Cash = new Player(154, 124, 52, 58, 60, 52, 58, 62, 68, 410, 55, 80, 18, 15, 17, 11, 14, 19, 19, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0x996
            private static Player Gayle_Revel = new Player(167, 109, 71, 64, 60, 56, 64, 63, 70, 448, 48, 58, 16, 16, 13, 18, 17, 14, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x997
            private static Player Janine_Brook = new Player(149, 109, 62, 70, 63, 62, 61, 57, 58, 433, 54, 33, 15, 16, 14, 11, 11, 17, 15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x998
            private static Player Colin_Binder = new Player(167, 132, 58, 61, 79, 52, 55, 59, 79, 443, 58, 76, 14, 5, 16, 5, 13, 15, 5, 5, 2, 5, 5, 2, 5, 5, 5, 5, 2); // 0x99D
            private static Player Larry_Pogue = new Player(217, 149, 79, 67, 58, 68, 52, 56, 57, 437, 94, 86, 21, 10, 4, 14, 7, 11, 10, 2, 2, 2, 5, 5, 5, 5, 2, 2, 3); // 0x99E
            private static Player Rob_Cardson = new Player(187, 165, 77, 68, 69, 79, 62, 78, 60, 493, 21, 39, 12, 15, 17, 22, 8, 6, 8, 2, 5, 5, 2, 2, 2, 5, 5, 5, 1); // 0x99F
            private static Player Ken_Mayfield = new Player(156, 197, 79, 62, 53, 79, 63, 63, 56, 455, 63, 62, 15, 13, 13, 17, 14, 15, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4); // 0x9A0
            private static Player Casey_Leather = new Player(140, 145, 56, 62, 79, 76, 52, 79, 60, 464, 44, 47, 13, 11, 23, 14, 12, 14, 14, 1, 1, 1, 1, 2, 1, 1, 5, 1, 2); // 0x9A1
            private static Player Ethan_Swallow = new Player(151, 156, 57, 53, 60, 60, 79, 74, 71, 454, 49, 36, 6, 7, 8, 5, 21, 23, 22, 5, 5, 5, 5, 5, 5, 2, 2, 2, 1); // 0x9A2
            private static Player Bob_Daruma = new Player(213, 129, 52, 52, 50, 52, 68, 79, 79, 432, 55, 21, 8, 6, 5, 6, 21, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9A3
            private static Player Mitch_Blackston = new Player(162, 153, 77, 69, 61, 56, 64, 57, 78, 462, 25, 25, 22, 8, 6, 4, 5, 8, 6, 1, 1, 2, 1, 1, 1, 1, 1, 1, 2); // 0x9A4
            private static Player Aurelia_Dingle = new Player(134, 192, 42, 48, 79, 63, 71, 47, 42, 392, 28, 24, 5, 7, 8, 8, 6, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5); // 0x9A5
            private static Player Canon_Evans = new Player(193, 180, 60, 79, 64, 79, 70, 72, 77, 501, 30, 84, 12, 17, 14, 17, 9, 15, 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 6); // 0x9A6
            private static Player Syon_Blaze = new Player(209, 185, 70, 60, 76, 67, 72, 64, 68, 477, 51, 56, 20, 14, 12, 14, 15, 13, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x9A7
            private static Player Thor_Stoutberg = new Player(191, 149, 71, 62, 68, 75, 68, 71, 68, 483, 57, 49, 19, 19, 14, 20, 14, 13, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x9A8
            private static Player Nelly_Raimon = new Player(140, 197, 79, 51, 45, 52, 44, 49, 62, 382, 33, 21, 8, 5, 5, 4, 6, 4, 7, 4, 2, 4, 4, 4, 4, 4, 4, 4, 1); // 0x9A9
            private static Player Celia_Hills = new Player(138, 149, 48, 54, 69, 45, 69, 51, 70, 406, 19, 29, 5, 6, 8, 7, 6, 6, 7, 4, 4, 4, 4, 4, 4, 2, 4, 4, 1); // 0x9AA
            private static Player Silvia_Woods = new Player(143, 116, 44, 72, 52, 69, 51, 64, 68, 420, 19, 27, 8, 6, 6, 6, 5, 5, 5, 4, 4, 4, 4, 4, 2, 4, 4, 4, 1); // 0x9AB
            private static Player Hidetoshi_Nakata = new Player(193, 192, 72, 80, 85, 72, 74, 81, 82, 546, 78, 96, 19, 19, 18, 20, 20, 18, 20, 1, 2, 2, 2, 2, 1, 1, 1, 2, 1); // 0x9AC
            private static Player Curtis_Croon = new Player(209, 188, 68, 55, 52, 64, 31, 68, 28, 366, 43, 51, 11, 9, 8, 11, 9, 10, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9C5
            private static Player Georgio_Plumber = new Player(145, 136, 67, 68, 58, 56, 58, 69, 64, 440, 42, 32, 19, 13, 14, 10, 10, 10, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x9C6
            private static Player Vince_Firewall = new Player(123, 136, 68, 56, 57, 60, 51, 71, 56, 419, 38, 47, 8, 9, 10, 13, 10, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9C7
            private static Player Roy_Diggins = new Player(136, 140, 52, 60, 52, 58, 60, 52, 59, 393, 26, 52, 13, 8, 10, 11, 14, 14, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x9C8
            private static Player Quill_Inker = new Player(154, 140, 60, 59, 52, 60, 58, 61, 56, 406, 43, 48, 11, 10, 12, 13, 11, 13, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9C9
            private static Player Bertram_Manning = new Player(136, 152, 57, 66, 60, 61, 75, 76, 67, 462, 30, 60, 14, 11, 10, 12, 15, 17, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x9CA
            private static Player Laura_Quilter = new Player(193, 152, 52, 64, 79, 55, 61, 65, 66, 442, 48, 51, 11, 14, 20, 12, 13, 12, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9CB
            private static Player Des_Igner = new Player(123, 105, 44, 49, 46, 52, 50, 55, 54, 350, 40, 43, 10, 9, 10, 8, 9, 11, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9CC
            private static Player Jarmon_Fisk = new Player(127, 132, 52, 61, 50, 66, 60, 60, 61, 410, 34, 48, 8, 7, 13, 16, 10, 17, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x9CD
            private static Player Hugh_Tinter = new Player(125, 156, 76, 66, 65, 71, 42, 78, 70, 468, 44, 63, 12, 14, 12, 14, 10, 14, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x9CE
            private static Player Tim_Pression = new Player(112, 140, 40, 32, 29, 69, 64, 52, 57, 343, 31, 53, 9, 11, 4, 10, 17, 12, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x9CF
            private static Player Claire_Taker = new Player(129, 109, 48, 50, 48, 52, 52, 48, 52, 350, 38, 39, 10, 9, 9, 9, 8, 9, 9, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0x9D0
            private static Player Heath_Planner = new Player(83, 146, 40, 54, 57, 53, 70, 67, 53, 394, 20, 43, 10, 11, 7, 9, 14, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9D1
            private static Player Pace_Keeping = new Player(165, 138, 52, 56, 57, 53, 60, 60, 52, 390, 61, 66, 15, 15, 16, 16, 16, 16, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9D2
            private static Player Arthur_Easley = new Player(165, 142, 59, 56, 69, 54, 58, 56, 78, 430, 39, 51, 11, 8, 8, 10, 8, 9, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9D3
            private static Player Carl_Rhodes = new Player(125, 125, 55, 60, 49, 63, 44, 63, 44, 378, 30, 37, 8, 6, 11, 13, 9, 12, 6, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x9D4
            private static Player Eugene_Conwell = new Player(145, 140, 56, 63, 56, 53, 60, 48, 52, 388, 70, 80, 16, 14, 13, 17, 14, 10, 15, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x9D5
            private static Player Arnan_Wheelie = new Player(162, 154, 54, 54, 56, 63, 57, 58, 55, 397, 55, 73, 17, 17, 16, 16, 14, 15, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0x9D6
            private static Player Stu_Boilin = new Player(145, 129, 56, 63, 63, 60, 53, 53, 62, 410, 57, 63, 14, 10, 14, 11, 10, 11, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9D7
            private static Player Marvin_Reading = new Player(143, 152, 70, 52, 53, 36, 55, 56, 79, 401, 43, 50, 10, 11, 10, 6, 11, 14, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9D8
            private static Player Callie_Graffy = new Player(134, 137, 55, 62, 47, 71, 60, 62, 58, 415, 26, 47, 10, 10, 13, 14, 12, 17, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x9D9
            private static Player Ant_Anomy = new Player(134, 158, 68, 60, 65, 65, 70, 63, 60, 451, 46, 29, 4, 4, 8, 5, 4, 5, 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0x9DA
            private static Player Laurie_Nowlin = new Player(129, 100, 49, 53, 52, 44, 53, 55, 47, 353, 51, 47, 14, 14, 12, 12, 12, 13, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9DB
            private static Player Lucille_Strummon = new Player(79, 142, 66, 60, 63, 64, 28, 64, 55, 400, 40, 46, 11, 10, 11, 13, 9, 8, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9DC
            private static Player Leon_Hotair = new Player(167, 136, 55, 58, 63, 63, 52, 52, 53, 396, 61, 72, 15, 14, 14, 14, 15, 17, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9DD
            private static Player John_Bleach = new Player(110, 141, 44, 52, 62, 56, 65, 54, 53, 386, 27, 45, 13, 9, 11, 9, 15, 10, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9DE
            private static Player Carey_Filling = new Player(132, 118, 40, 47, 48, 43, 42, 48, 48, 316, 40, 36, 8, 8, 10, 7, 10, 11, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x9DF
            private static Player Conn_Fuchus = new Player(129, 156, 75, 68, 69, 79, 45, 72, 64, 472, 51, 59, 14, 13, 14, 13, 13, 13, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9E0
            private static Player Iain_Igma = new Player(154, 132, 63, 60, 60, 60, 52, 60, 60, 415, 61, 63, 15, 15, 15, 15, 16, 14, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9E1
            private static Player Carrie_O_Kea = new Player(138, 109, 54, 52, 52, 47, 44, 52, 52, 353, 50, 55, 12, 14, 12, 13, 12, 11, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9E2
            private static Player Ebirina = new Player(171, 132, 45, 56, 66, 49, 52, 56, 53, 377, 43, 53, 9, 12, 17, 9, 9, 7, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x9E3
            private static Player Stuart_Leafe = new Player(134, 133, 55, 52, 55, 56, 63, 60, 54, 395, 30, 52, 11, 10, 7, 8, 16, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9E4
            private static Player Cole_Stoaker = new Player(114, 144, 49, 34, 34, 52, 79, 53, 53, 354, 32, 28, 8, 8, 5, 7, 6, 6, 4, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x9E5
            private static Player Justin_Primm = new Player(134, 148, 50, 53, 54, 52, 62, 67, 54, 392, 28, 47, 9, 7, 10, 9, 12, 14, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9E6
            private static Player Mark_Smudge = new Player(127, 140, 56, 71, 45, 68, 60, 64, 52, 416, 22, 58, 8, 7, 10, 14, 12, 16, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9E7
            private static Player Travis_Borer = new Player(167, 170, 62, 63, 68, 68, 71, 60, 29, 421, 42, 38, 14, 14, 9, 7, 8, 7, 5, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0x9E8
            private static Player Anton_Donce = new Player(116, 118, 53, 56, 42, 72, 42, 58, 61, 384, 37, 36, 13, 12, 8, 9, 9, 10, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0x9E9
            private static Player Chase_Spoor = new Player(140, 140, 64, 57, 62, 60, 52, 64, 52, 411, 38, 43, 16, 7, 14, 14, 10, 9, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9EA
            private static Player George_Barros = new Player(143, 176, 62, 76, 64, 76, 65, 66, 68, 477, 55, 48, 13, 12, 14, 18, 14, 15, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9EB
            private static Player Olivia_Baker = new Player(169, 156, 59, 60, 78, 59, 60, 67, 66, 449, 55, 49, 10, 15, 17, 13, 14, 12, 12, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x9EC
            private static Player Gem_Shorn = new Player(123, 84, 73, 72, 76, 79, 56, 72, 71, 499, 44, 70, 17, 16, 20, 21, 18, 19, 20, 5, 1, 2, 4, 4, 4, 4, 4, 4, 3); // 0x9ED
            private static Player Lou_Daguerre = new Player(136, 100, 52, 56, 51, 46, 44, 61, 53, 363, 32, 20, 15, 14, 9, 9, 10, 9, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0x9EE
            private static Player Ollie_Tuckney = new Player(171, 152, 52, 60, 76, 56, 70, 60, 68, 442, 52, 58, 14, 15, 17, 12, 14, 14, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x9EF
            private static Player Manuel_Kinart = new Player(96, 140, 50, 63, 52, 62, 77, 63, 57, 424, 27, 36, 12, 11, 9, 10, 17, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9F0
            private static Player Skip_Vinall = new Player(125, 152, 70, 66, 64, 75, 51, 79, 60, 465, 50, 63, 11, 13, 11, 15, 14, 12, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9F1
            private static Player Junior_Gambit = new Player(81, 158, 49, 60, 58, 55, 79, 57, 59, 417, 21, 34, 7, 5, 6, 7, 6, 8, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x9F2
            private static Player Florian_Fauna = new Player(217, 152, 63, 79, 61, 54, 60, 77, 59, 453, 56, 78, 14, 16, 15, 13, 14, 16, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0x9F3
            private static Player Clark_Tappen = new Player(88, 158, 40, 56, 62, 61, 62, 64, 56, 401, 18, 29, 6, 4, 6, 5, 6, 7, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9F4
            private static Player Ryan_O_Laugh = new Player(162, 144, 54, 57, 56, 55, 58, 58, 60, 398, 55, 74, 17, 13, 14, 13, 15, 14, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0x9F5
            private static Player Rod_Sweeper = new Player(134, 152, 63, 60, 62, 68, 52, 61, 56, 422, 34, 40, 11, 7, 8, 15, 8, 12, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9F6
            private static Player Reg_Strimmer = new Player(81, 154, 60, 57, 58, 60, 63, 68, 58, 424, 38, 50, 14, 8, 10, 16, 8, 9, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9F7
            private static Player Will_Ramin = new Player(107, 142, 41, 61, 52, 58, 70, 63, 56, 401, 30, 38, 14, 8, 7, 9, 15, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9F8
            private static Player Andy_Fudge = new Player(145, 156, 68, 78, 76, 65, 44, 73, 63, 467, 54, 34, 15, 11, 13, 17, 15, 19, 13, 1, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9F9
            private static Player Tate_Immy = new Player(165, 148, 68, 46, 68, 40, 62, 68, 48, 400, 62, 34, 11, 10, 17, 8, 11, 17, 10, 4, 1, 1, 5, 2, 5, 1, 4, 5, 2); // 0x9FA
            private static Player Gerald_Pourer = new Player(211, 140, 63, 60, 35, 60, 36, 79, 58, 391, 80, 35, 7, 8, 11, 14, 10, 20, 8, 5, 1, 2, 1, 1, 2, 1, 2, 1, 1); // 0x9FB
            private static Player Nate_Checker = new Player(129, 164, 62, 62, 60, 68, 76, 61, 61, 450, 44, 47, 17, 14, 10, 12, 19, 14, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9FC
            private static Player Bomber_Pikes = new Player(149, 158, 49, 61, 64, 53, 56, 62, 60, 405, 34, 34, 10, 13, 17, 13, 7, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9FD
            private static Player Gary_Burdine = new Player(99, 98, 71, 70, 69, 72, 76, 36, 73, 467, 28, 36, 12, 11, 11, 14, 14, 8, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0x9FE
            private static Player Chloe_Glazier = new Player(147, 185, 48, 62, 67, 76, 59, 58, 53, 423, 31, 33, 7, 12, 15, 18, 8, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9FF
            private static Player Reed_Harpen = new Player(127, 136, 64, 55, 56, 65, 48, 68, 52, 408, 31, 52, 7, 11, 10, 11, 9, 10, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA00
            private static Player Beat_Scatton = new Player(129, 129, 52, 51, 48, 60, 65, 61, 60, 397, 37, 39, 9, 7, 6, 11, 15, 10, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA01
            private static Player Al_Itchen = new Player(136, 153, 55, 54, 59, 53, 64, 68, 63, 416, 18, 52, 8, 8, 7, 11, 11, 11, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA02
            private static Player Rock_Poulon = new Player(138, 144, 52, 68, 50, 63, 52, 64, 62, 411, 30, 64, 11, 8, 13, 14, 10, 17, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA03
            private static Player Beau_Hammock = new Player(145, 141, 60, 61, 59, 60, 55, 63, 54, 412, 58, 64, 10, 12, 13, 12, 13, 11, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA04
            private static Player Clef_Bassett = new Player(125, 137, 44, 55, 62, 57, 68, 60, 61, 407, 27, 37, 12, 7, 10, 7, 15, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA05
            private static Player Ovie_Whisker = new Player(167, 166, 72, 57, 66, 40, 55, 52, 58, 400, 38, 63, 11, 10, 15, 9, 8, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA06
            private static Player Bill_Clanger = new Player(151, 134, 73, 60, 60, 62, 54, 55, 56, 420, 69, 68, 15, 13, 15, 14, 15, 14, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA07
            private static Player Mary_Cramer = new Player(90, 124, 29, 47, 45, 50, 60, 49, 40, 320, 20, 31, 10, 4, 8, 5, 12, 11, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA08
            private static Player Ralph_Vance = new Player(187, 164, 61, 69, 74, 54, 65, 66, 63, 452, 49, 51, 10, 14, 16, 13, 11, 13, 13, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA09
            private static Player Ray_Bowing = new Player(195, 176, 61, 69, 66, 70, 60, 65, 66, 457, 51, 55, 10, 13, 13, 11, 12, 14, 13, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xA0A
            private static Player Vick_Pointer = new Player(151, 129, 68, 60, 53, 57, 61, 61, 62, 422, 55, 24, 20, 17, 10, 13, 12, 11, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xA0B
            private static Player Skip_Docker = new Player(132, 154, 76, 71, 70, 70, 50, 68, 62, 467, 45, 39, 8, 7, 6, 8, 7, 5, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA0C
            private static Player Becky_Shuffle = new Player(149, 152, 68, 72, 70, 68, 48, 68, 69, 463, 52, 28, 17, 13, 15, 17, 16, 20, 10, 1, 5, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA0D
            private static Player Esther_Egerer = new Player(149, 137, 75, 52, 57, 63, 52, 61, 68, 428, 56, 29, 18, 16, 11, 12, 11, 10, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA0E
            private static Player Mia_Pitchford = new Player(88, 140, 62, 68, 47, 67, 55, 60, 54, 413, 27, 66, 11, 8, 11, 16, 12, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA0F
            private static Player Philippa_Konik = new Player(83, 92, 65, 65, 63, 66, 68, 29, 66, 422, 21, 21, 14, 14, 11, 10, 14, 4, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA10
            private static Player Amy_Stinger = new Player(169, 154, 44, 61, 63, 48, 63, 57, 52, 388, 46, 68, 7, 9, 17, 9, 10, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA11
            private static Player Nancy_Polearm = new Player(180, 164, 60, 69, 63, 68, 69, 70, 64, 463, 61, 62, 15, 17, 16, 15, 15, 15, 15, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0xA12
            private static Player Sally_Tare = new Player(129, 108, 57, 56, 49, 45, 44, 61, 61, 373, 36, 27, 14, 14, 10, 7, 7, 9, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0xA13
            private static Player Anna_Bugeisha = new Player(154, 156, 60, 43, 41, 60, 74, 64, 68, 410, 57, 57, 12, 13, 5, 11, 18, 14, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA14
            private static Player Stu_Hoofer = new Player(193, 152, 56, 64, 76, 52, 63, 62, 68, 441, 58, 54, 11, 15, 18, 13, 14, 13, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA15
            private static Player Coe_Dachy = new Player(116, 129, 62, 59, 60, 66, 48, 64, 63, 422, 31, 40, 9, 10, 10, 14, 11, 10, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA16
            private static Player Flip_Sliden = new Player(147, 149, 56, 67, 64, 64, 74, 69, 66, 460, 39, 54, 17, 10, 11, 14, 18, 17, 12, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA17
            private static Player Jesse_Spiller = new Player(158, 129, 68, 66, 56, 61, 56, 67, 71, 445, 43, 33, 19, 17, 10, 12, 12, 12, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 4); // 0xA18
            private static Player Kate_Later = new Player(160, 158, 50, 60, 70, 43, 61, 62, 57, 403, 45, 53, 7, 11, 16, 8, 8, 10, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA19
            private static Player Clara_Tompkins = new Player(136, 102, 68, 36, 41, 32, 40, 61, 58, 336, 31, 32, 13, 7, 8, 6, 9, 9, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xA1A
            private static Player Betty_Backer = new Player(158, 152, 53, 73, 70, 70, 48, 68, 69, 451, 45, 66, 16, 12, 15, 15, 13, 20, 12, 5, 5, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA1B
            private static Player Thomas_Worth = new Player(140, 169, 69, 60, 69, 67, 65, 69, 68, 467, 45, 58, 14, 15, 14, 16, 14, 16, 17, 5, 1, 2, 4, 4, 4, 4, 4, 4, 3); // 0xA1C
            private static Player Brenda_Brandish = new Player(77, 194, 68, 61, 60, 64, 31, 64, 55, 403, 32, 42, 11, 10, 9, 12, 5, 7, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA1D
            private static Player Isla_Pullens = new Player(110, 166, 79, 65, 60, 79, 49, 68, 68, 468, 58, 57, 12, 13, 13, 17, 12, 12, 14, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA1E
            private static Player Bob_Jammen = new Player(96, 168, 79, 67, 71, 73, 29, 79, 68, 466, 27, 29, 7, 5, 5, 5, 7, 8, 7, 5, 1, 5, 1, 1, 2, 5, 2, 1, 2); // 0xA1F
            private static Player Hank_Cranker = new Player(114, 140, 57, 67, 44, 69, 52, 60, 55, 404, 24, 66, 11, 9, 10, 17, 12, 16, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA20
            private static Player Prunella_Keep = new Player(162, 129, 57, 52, 55, 59, 53, 61, 58, 395, 54, 52, 12, 14, 11, 12, 11, 12, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA21
            private static Player Jimmy_Brim = new Player(123, 113, 43, 44, 63, 51, 46, 50, 53, 350, 18, 39, 8, 8, 11, 8, 7, 5, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA22
            private static Player Verity_Soliz = new Player(151, 198, 44, 60, 60, 51, 60, 62, 57, 394, 36, 73, 8, 9, 14, 10, 11, 9, 10, 4, 2, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA23
            private static Player Yve_Dunbar = new Player(209, 126, 55, 70, 65, 76, 60, 79, 79, 484, 58, 55, 13, 12, 11, 23, 12, 11, 23, 2, 5, 5, 1, 2, 2, 1, 2, 2, 4); // 0xA24
            private static Player Cat_Selima = new Player(105, 132, 63, 68, 57, 60, 57, 70, 53, 428, 30, 55, 13, 12, 10, 17, 12, 19, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA25
            private static Player Aurie_Garmer = new Player(129, 136, 56, 66, 44, 70, 52, 65, 56, 409, 26, 47, 9, 9, 12, 17, 11, 16, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA26
            private static Player Lana_Service = new Player(156, 193, 62, 77, 66, 74, 66, 62, 71, 478, 44, 62, 10, 14, 12, 17, 11, 16, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA27
            private static Player Claire_Voyant = new Player(160, 180, 64, 69, 66, 68, 66, 60, 61, 454, 49, 55, 12, 12, 11, 18, 13, 14, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA28
            private static Player Algy_Kelp = new Player(94, 140, 62, 68, 48, 65, 60, 62, 56, 421, 19, 29, 6, 8, 7, 4, 5, 5, 6, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA29
            private static Player Ann_Taisie = new Player(189, 149, 71, 64, 68, 67, 65, 63, 70, 468, 60, 72, 16, 16, 17, 13, 16, 14, 16, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xA2A
            private static Player Kelly_Scrivens = new Player(151, 112, 61, 56, 52, 52, 54, 60, 52, 387, 40, 20, 14, 11, 8, 7, 8, 7, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA2B
            private static Player Fern_Mycota = new Player(121, 105, 58, 55, 52, 57, 49, 57, 48, 376, 33, 27, 5, 5, 4, 10, 5, 6, 5, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA2C
            private static Player Lara_Creamer = new Player(169, 180, 51, 59, 60, 40, 58, 56, 56, 380, 43, 38, 11, 12, 14, 9, 8, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA2D
            private static Player Kim_Knotted = new Player(96, 134, 45, 59, 56, 62, 68, 57, 60, 407, 24, 34, 14, 8, 11, 11, 15, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA2E
            private static Player Nina_Trowel = new Player(140, 122, 61, 53, 46, 45, 40, 56, 54, 355, 44, 39, 17, 12, 8, 11, 8, 8, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA2F
            private static Player Harriet_Reaching = new Player(182, 153, 60, 65, 67, 64, 62, 62, 65, 445, 68, 76, 16, 14, 16, 15, 13, 17, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xA30
            private static Player Sadey_Stewer = new Player(110, 144, 61, 57, 62, 54, 60, 63, 56, 413, 36, 52, 17, 9, 13, 13, 7, 10, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA31
            private static Player June_Stagner = new Player(118, 133, 55, 56, 61, 59, 61, 65, 60, 417, 26, 51, 8, 10, 9, 9, 13, 10, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA32
            private static Player Lacey_Threader = new Player(171, 153, 52, 48, 49, 64, 71, 71, 64, 419, 58, 47, 14, 14, 7, 10, 17, 15, 13, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA33
            private static Player Marcy_Laise = new Player(127, 133, 62, 56, 60, 54, 60, 68, 60, 420, 38, 47, 15, 11, 12, 17, 8, 10, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA34
            private static Player Bella_Shaded = new Player(121, 149, 73, 71, 64, 68, 54, 74, 71, 475, 55, 49, 10, 13, 14, 15, 14, 14, 14, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA35
            private static Player Walter_Trope = new Player(134, 164, 69, 70, 60, 77, 68, 76, 60, 480, 30, 62, 14, 11, 13, 18, 14, 20, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA36
            private static Player Flora_Summars = new Player(140, 153, 62, 65, 63, 71, 53, 52, 58, 424, 36, 39, 11, 10, 11, 15, 11, 11, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA37
            private static Player Lucia_Ander = new Player(154, 152, 55, 58, 60, 60, 56, 52, 63, 404, 55, 76, 16, 14, 17, 13, 13, 13, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA38
            private static Player Rosy_Roker = new Player(88, 136, 46, 54, 63, 55, 69, 69, 63, 419, 33, 35, 8, 11, 7, 10, 11, 11, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA39
            private static Player Pam_Vision = new Player(173, 169, 61, 71, 61, 71, 70, 70, 68, 472, 51, 54, 14, 14, 11, 19, 10, 17, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA3A
            private static Player Ruth_Karnes = new Player(215, 148, 61, 63, 53, 63, 61, 73, 60, 434, 67, 42, 13, 9, 11, 16, 10, 19, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA3B
            private static Player Rose_Bedd = new Player(116, 136, 70, 59, 53, 70, 45, 60, 52, 409, 43, 37, 9, 10, 10, 10, 9, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA3C
            private static Player Bailey_Sitter = new Player(143, 138, 63, 64, 53, 56, 56, 69, 62, 423, 51, 28, 20, 15, 12, 12, 11, 13, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA3D
            private static Player Adel_Tactor = new Player(107, 130, 66, 60, 63, 64, 32, 64, 75, 424, 36, 48, 10, 11, 11, 12, 10, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA3E
            private static Player Emma_Barres = new Player(129, 109, 45, 50, 47, 55, 45, 53, 54, 349, 42, 40, 7, 11, 11, 11, 9, 9, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA3F
            private static Player Orpah_Talkington = new Player(147, 152, 52, 44, 43, 71, 69, 68, 64, 411, 54, 58, 13, 13, 6, 12, 18, 13, 12, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA40
            private static Player Sable_Tatter = new Player(149, 152, 60, 64, 64, 64, 70, 68, 69, 459, 46, 52, 16, 12, 11, 11, 17, 14, 14, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA41
            private static Player Shu_Maimai = new Player(165, 142, 70, 53, 60, 68, 32, 64, 79, 426, 33, 53, 8, 9, 10, 12, 8, 6, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA42
            private static Player Sym_Copate = new Player(125, 152, 71, 75, 63, 76, 71, 72, 68, 496, 27, 62, 12, 10, 14, 18, 15, 19, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA43
            private static Player Jerry_Bateman = new Player(140, 129, 53, 51, 51, 52, 71, 52, 56, 386, 45, 33, 8, 9, 8, 11, 15, 12, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA44
            private static Player Fonda_Katz = new Player(156, 129, 62, 53, 60, 62, 58, 59, 59, 413, 49, 47, 12, 14, 12, 12, 11, 12, 11, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xA45
            private static Player Beck_Hand = new Player(138, 152, 56, 60, 70, 68, 72, 72, 71, 469, 31, 49, 12, 10, 11, 12, 15, 16, 13, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA46
            private static Player Sandra_Mudd = new Player(143, 129, 47, 62, 70, 44, 56, 61, 61, 401, 30, 44, 11, 10, 13, 8, 7, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA47
            private static Player Alexis_Watchorn = new Player(134, 129, 46, 48, 41, 59, 66, 59, 54, 373, 30, 48, 8, 8, 8, 7, 16, 12, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA48
            private static Player Pete_Manter = new Player(151, 138, 63, 62, 72, 56, 54, 55, 52, 414, 51, 48, 12, 12, 12, 12, 10, 14, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA49
            private static Player Chris_Country = new Player(156, 165, 52, 45, 44, 68, 68, 60, 71, 408, 45, 64, 10, 13, 4, 10, 20, 14, 12, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA4A
            private static Player Paul_Steed = new Player(92, 172, 71, 76, 72, 64, 48, 68, 68, 467, 32, 63, 16, 14, 14, 14, 13, 18, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA4B
            private static Player Ben_Whistler = new Player(140, 132, 53, 42, 43, 60, 71, 60, 54, 383, 33, 52, 9, 8, 7, 11, 16, 13, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA4C
            private static Player Roman_Blac = new Player(145, 188, 60, 76, 60, 68, 68, 64, 62, 458, 50, 55, 13, 10, 11, 17, 12, 14, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA4D
            private static Player Lewis_Brownie = new Player(77, 102, 61, 69, 63, 79, 64, 72, 64, 472, 27, 68, 12, 10, 17, 19, 16, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA4E
            private static Player Connor_Seuer = new Player(187, 157, 62, 61, 70, 66, 60, 60, 60, 439, 55, 76, 15, 17, 15, 15, 15, 16, 16, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xA4F
            private static Player Kaya_Haskell = new Player(88, 134, 69, 61, 52, 66, 39, 64, 52, 403, 39, 40, 8, 7, 10, 11, 9, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA50
            private static Player Minnie_Stratio = new Player(145, 156, 40, 55, 65, 50, 52, 57, 56, 375, 32, 78, 11, 10, 16, 9, 7, 11, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA51
            private static Player Elegance_Stuckon = new Player(121, 140, 54, 68, 44, 67, 56, 68, 55, 412, 22, 55, 9, 10, 12, 15, 14, 14, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA52
            private static Player Odette_Musetta = new Player(132, 129, 64, 55, 61, 60, 44, 62, 53, 399, 43, 48, 8, 10, 7, 14, 9, 11, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA53
            private static Player Gertrude_Choker = new Player(158, 148, 52, 59, 54, 52, 60, 57, 54, 388, 61, 63, 14, 14, 17, 17, 14, 16, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xA54
            private static Player Polly_Targest = new Player(145, 164, 55, 66, 59, 71, 53, 52, 55, 411, 44, 45, 7, 8, 8, 15, 11, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA55
            private static Player Odessa_Ryder = new Player(145, 137, 52, 57, 58, 56, 52, 60, 56, 391, 58, 49, 12, 12, 13, 14, 11, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA56
            private static Player Robyn_Weaver = new Player(125, 121, 52, 47, 49, 49, 52, 52, 48, 349, 45, 39, 8, 9, 9, 7, 10, 11, 9, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5); // 0xA57
            private static Player Tess_Masters = new Player(121, 153, 67, 56, 54, 60, 41, 62, 61, 401, 46, 45, 10, 10, 11, 12, 9, 8, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA58
            private static Player Cale_Sticklin = new Player(145, 164, 59, 60, 61, 68, 55, 61, 58, 422, 38, 48, 8, 9, 9, 13, 11, 14, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA59
            private static Player Farris_Stickman = new Player(123, 152, 56, 66, 60, 60, 56, 60, 56, 414, 42, 36, 9, 9, 10, 15, 8, 13, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA5A
            private static Player Tim_Personator = new Player(121, 145, 66, 56, 56, 68, 47, 70, 60, 423, 31, 37, 7, 9, 8, 11, 8, 10, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA5B
            private static Player Sherlock_Sagers = new Player(90, 156, 68, 54, 52, 69, 28, 68, 60, 399, 32, 51, 8, 7, 9, 12, 7, 8, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA5C
            private static Player Ryan_Haywood = new Player(154, 148, 54, 53, 52, 55, 56, 52, 53, 375, 46, 57, 11, 10, 12, 10, 13, 13, 11, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA5D
            private static Player Osier_Twining = new Player(145, 132, 47, 44, 47, 52, 63, 59, 63, 375, 36, 43, 11, 10, 7, 8, 13, 12, 9, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA5E
            private static Player Rock_Scowlon = new Player(138, 144, 48, 47, 40, 60, 64, 56, 57, 372, 46, 39, 9, 8, 7, 10, 16, 11, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA5F
            private static Player Al_Stringer = new Player(149, 138, 52, 54, 52, 57, 52, 61, 52, 380, 54, 50, 10, 14, 12, 11, 11, 13, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA60
            private static Player Bill_Fierce = new Player(171, 132, 64, 60, 53, 61, 53, 62, 55, 408, 56, 39, 15, 7, 14, 15, 8, 15, 10, 2, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA61
            private static Player Rob_Otts = new Player(140, 113, 43, 46, 45, 44, 44, 41, 43, 306, 42, 34, 5, 7, 5, 8, 6, 5, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA62
            private static Player Chad_Jowell = new Player(90, 148, 72, 62, 63, 61, 60, 60, 55, 433, 40, 39, 15, 11, 12, 17, 11, 10, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA63
            private static Player Egon_Omercer = new Player(136, 157, 76, 68, 52, 60, 52, 64, 71, 443, 49, 63, 10, 15, 11, 12, 12, 14, 12, 5, 1, 2, 1, 1, 1, 1, 1, 1, 3); // 0xA64
            private static Player Luis_Springs = new Player(173, 140, 56, 52, 55, 53, 58, 63, 79, 416, 58, 50, 12, 11, 10, 10, 11, 11, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA65
            private static Player Bruce_Barkley = new Player(217, 121, 78, 77, 55, 68, 70, 76, 77, 501, 46, 51, 20, 14, 11, 11, 10, 11, 23, 2, 5, 2, 1, 5, 5, 1, 2, 2, 4); // 0xA66
            private static Player Chip_Spacek = new Player(121, 153, 70, 69, 69, 77, 47, 73, 62, 467, 55, 56, 10, 14, 13, 15, 14, 14, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA67
            private static Player Mason_Tirell = new Player(129, 132, 54, 60, 55, 60, 63, 62, 62, 416, 26, 48, 11, 11, 11, 10, 12, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA68
            private static Player Dale_Riverhead = new Player(110, 172, 71, 64, 60, 64, 65, 71, 62, 457, 50, 65, 12, 14, 13, 15, 16, 15, 15, 5, 1, 2, 4, 4, 4, 4, 4, 4, 3); // 0xA69
            private static Player Adelpha_Lovelace = new Player(151, 177, 71, 68, 65, 72, 67, 60, 67, 470, 57, 59, 11, 13, 12, 19, 13, 17, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 5); // 0xA6A
            private static Player Egon_Timing = new Player(107, 144, 51, 54, 48, 52, 42, 51, 43, 341, 34, 36, 7, 7, 8, 13, 6, 8, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA6B
            private static Player Tony_Frogge = new Player(138, 112, 54, 60, 45, 46, 52, 56, 56, 369, 31, 28, 17, 14, 9, 9, 10, 9, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xA6C
            private static Player Fred_Punch = new Player(145, 154, 50, 68, 74, 68, 60, 57, 52, 429, 38, 78, 7, 8, 15, 11, 8, 9, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA6D
            private static Player Hannibal_Whipp = new Player(160, 134, 41, 62, 64, 40, 55, 58, 63, 383, 34, 36, 8, 15, 13, 7, 7, 8, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA6E
            private static Player Luke_Severin = new Player(162, 144, 56, 62, 56, 52, 57, 62, 63, 408, 42, 60, 11, 12, 14, 11, 12, 13, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA6F
            private static Player Harry_Keenan = new Player(158, 181, 67, 68, 67, 79, 71, 71, 62, 485, 55, 52, 11, 13, 13, 16, 13, 15, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA70
            private static Player Nick_Uman = new Player(134, 129, 70, 60, 56, 60, 55, 60, 53, 414, 31, 49, 16, 10, 11, 16, 9, 9, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA71
            private static Player Mac_Robat = new Player(110, 149, 61, 76, 58, 71, 70, 78, 65, 479, 22, 60, 12, 14, 14, 19, 15, 19, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA72
            private static Player Ace_Slider = new Player(125, 154, 72, 67, 64, 73, 48, 68, 68, 460, 46, 59, 13, 12, 14, 15, 10, 14, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA73
            private static Player Olivia_Twist = new Player(167, 132, 71, 60, 55, 56, 55, 64, 68, 429, 54, 28, 17, 16, 10, 11, 13, 13, 13, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA74
            private static Player Wiley_Blinks = new Player(154, 146, 54, 64, 35, 61, 33, 55, 60, 362, 68, 68, 17, 13, 8, 17, 5, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA75
            private static Player Shona_Shopbell = new Player(127, 152, 76, 64, 62, 60, 62, 64, 60, 448, 43, 51, 13, 15, 16, 16, 16, 17, 13, 5, 1, 2, 4, 4, 4, 4, 4, 4, 4); // 0xA76
            private static Player Crystal_Clears = new Player(149, 130, 54, 60, 62, 56, 71, 59, 54, 416, 60, 68, 13, 17, 16, 14, 14, 13, 14, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xA77
            private static Player Beata_Pummel = new Player(195, 84, 29, 64, 62, 61, 68, 71, 70, 425, 56, 34, 6, 15, 16, 17, 15, 15, 13, 1, 1, 4, 1, 1, 1, 1, 1, 1, 1); // 0xA78
            private static Player Aya_Strand = new Player(180, 174, 71, 61, 64, 68, 64, 69, 68, 465, 42, 63, 16, 12, 12, 13, 12, 11, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA79
            private static Player Tara_Gaudier = new Player(132, 160, 64, 73, 63, 68, 60, 72, 63, 463, 22, 60, 12, 10, 17, 18, 14, 18, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA7A
            private static Player James_Hearson = new Player(121, 110, 44, 49, 44, 41, 45, 51, 40, 314, 76, 85, 19, 16, 16, 20, 16, 18, 17, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xA7B
            private static Player Anne_Somnia = new Player(79, 130, 44, 52, 52, 60, 67, 60, 52, 387, 18, 43, 10, 10, 7, 9, 10, 12, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA7C
            private static Player Pearl_Wann = new Player(107, 158, 49, 59, 58, 62, 78, 56, 57, 419, 18, 34, 12, 9, 9, 9, 18, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA7D
            private static Player Hugh_Dunnit = new Player(123, 170, 76, 68, 67, 78, 44, 72, 65, 470, 48, 58, 14, 13, 14, 16, 14, 13, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA7E
            private static Player Steve_Squander = new Player(189, 153, 77, 63, 36, 67, 28, 64, 76, 411, 60, 80, 17, 17, 7, 13, 5, 15, 17, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA7F
            private static Player Lehman_Rind = new Player(173, 130, 40, 54, 68, 45, 58, 59, 58, 382, 30, 47, 10, 12, 17, 7, 8, 10, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA80
            private static Player Ian_Fantile = new Player(112, 148, 51, 36, 30, 53, 76, 60, 53, 359, 42, 50, 11, 8, 8, 9, 17, 10, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xA81
            private static Player Zach_Putter = new Player(165, 132, 59, 52, 54, 56, 54, 52, 58, 385, 61, 77, 13, 15, 16, 17, 17, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA82
            private static Player Juan_Word = new Player(121, 109, 60, 56, 45, 48, 52, 52, 57, 370, 31, 32, 15, 13, 9, 8, 10, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xA83
            private static Player Alex_Copple = new Player(125, 152, 72, 71, 68, 69, 68, 64, 67, 479, 43, 49, 13, 15, 16, 15, 14, 16, 15, 5, 1, 2, 4, 4, 4, 4, 4, 4, 2); // 0xA84
            private static Player Jan_Jared = new Player(129, 117, 59, 54, 52, 59, 45, 53, 50, 372, 30, 20, 5, 7, 6, 8, 5, 5, 5, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA85
            private static Player Bigsby_Pigford = new Player(156, 152, 56, 53, 51, 64, 68, 60, 68, 420, 46, 52, 14, 13, 4, 11, 16, 14, 12, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA86
            private static Player Erica_Hogland = new Player(149, 145, 44, 59, 66, 53, 52, 52, 57, 383, 33, 41, 9, 13, 16, 9, 10, 8, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA87
            private static Player Ramona_Wriston = new Player(103, 130, 60, 71, 65, 60, 39, 49, 62, 406, 42, 44, 7, 9, 9, 12, 8, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA88
            private static Player Mark_Izushy = new Player(123, 164, 79, 64, 61, 77, 51, 69, 70, 471, 56, 58, 12, 12, 13, 15, 11, 11, 13, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA89
            private static Player Vince_Tinct = new Player(125, 152, 76, 70, 61, 56, 60, 69, 68, 460, 58, 58, 13, 15, 14, 14, 13, 10, 11, 5, 1, 2, 1, 1, 1, 1, 1, 1, 3); // 0xA8A
            private static Player Daryl_Floor = new Player(132, 133, 70, 60, 60, 52, 63, 71, 52, 428, 32, 33, 13, 9, 13, 15, 9, 7, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA8B
            private static Player Becca_Pilgreen = new Player(160, 177, 64, 76, 60, 74, 68, 66, 71, 479, 44, 56, 10, 13, 12, 18, 12, 17, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA8C
            private static Player Langley_Span = new Player(136, 140, 56, 64, 54, 69, 57, 61, 63, 424, 21, 47, 9, 11, 10, 13, 11, 17, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA8D
            private static Player Swithin_Sainte = new Player(160, 138, 52, 62, 52, 61, 57, 62, 56, 402, 58, 59, 11, 13, 14, 10, 10, 14, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xA8E
            private static Player Dan_Cawarry = new Player(154, 156, 69, 53, 52, 63, 56, 62, 71, 426, 57, 62, 12, 13, 12, 14, 11, 13, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xA8F
            private static Player Hans_Freesing = new Player(136, 165, 68, 71, 76, 65, 44, 73, 65, 462, 19, 68, 13, 13, 16, 14, 15, 16, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA90
            private static Player Peter_Fakhoury = new Player(77, 134, 50, 52, 57, 63, 79, 60, 63, 424, 26, 50, 10, 9, 10, 8, 14, 12, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA91
            private static Player Steve_Sancey = new Player(92, 80, 68, 69, 72, 70, 73, 33, 78, 463, 31, 32, 13, 13, 10, 11, 11, 4, 12, 1, 1, 2, 2, 2, 2, 2, 1, 2, 2); // 0xA92
            private static Player Michael_Gibe = new Player(158, 136, 56, 62, 63, 52, 72, 53, 63, 421, 69, 65, 15, 16, 15, 17, 16, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xA93
            private static Player Skeet_Blaston = new Player(154, 198, 57, 53, 56, 63, 55, 56, 61, 401, 64, 69, 17, 13, 15, 16, 17, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA94
            private static Player Achilles_Chinner = new Player(180, 156, 61, 63, 61, 70, 68, 69, 68, 460, 63, 73, 13, 13, 13, 17, 16, 15, 16, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2); // 0xA95
            private static Player Scott_Tickle = new Player(90, 130, 56, 71, 44, 64, 55, 61, 53, 404, 33, 54, 8, 8, 11, 16, 11, 16, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA96
            private static Player Junior_Cage = new Player(107, 138, 42, 59, 58, 60, 79, 55, 63, 416, 21, 43, 12, 9, 8, 8, 10, 11, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA97
            private static Player Terry_Namby = new Player(125, 104, 49, 41, 42, 47, 40, 45, 46, 310, 32, 69, 14, 8, 9, 11, 7, 9, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xA98
            private static Player Joe_Chugger = new Player(158, 180, 64, 77, 66, 73, 65, 66, 63, 474, 45, 62, 14, 11, 10, 19, 13, 16, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA99
            private static Player Sonny_Cinders = new Player(132, 118, 73, 55, 46, 47, 46, 55, 54, 376, 33, 38, 16, 12, 11, 10, 10, 8, 8, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0xA9A
            private static Player Cash_Winfall = new Player(147, 140, 45, 56, 67, 50, 56, 53, 53, 380, 38, 47, 9, 14, 14, 10, 10, 11, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA9B
            private static Player Lou_Fauntleroy = new Player(138, 170, 57, 67, 68, 61, 72, 68, 71, 464, 40, 54, 13, 13, 12, 13, 18, 15, 13, 5, 5, 1, 1, 1, 1, 2, 5, 1, 4); // 0xA9C
            private static Player Carol_Chanter = new Player(116, 144, 46, 61, 54, 54, 64, 60, 52, 391, 33, 51, 9, 8, 9, 9, 13, 14, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA9D
            private static Player Guy_Kogan = new Player(125, 149, 60, 76, 74, 60, 46, 69, 60, 445, 18, 63, 16, 10, 15, 13, 13, 16, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA9E
            private static Player Max_Motto = new Player(151, 198, 63, 55, 57, 56, 54, 55, 56, 396, 60, 72, 16, 13, 16, 14, 15, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xA9F
            private static Player Perry_Postiche = new Player(217, 138, 70, 59, 56, 61, 56, 55, 57, 414, 44, 44, 17, 8, 12, 15, 9, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA0
            private static Player Nelson_Levene = new Player(116, 141, 60, 59, 52, 64, 51, 62, 56, 404, 44, 35, 8, 9, 11, 11, 11, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAA1
            private static Player Kurt_Sermons = new Player(136, 164, 78, 67, 60, 74, 53, 69, 64, 465, 49, 55, 12, 14, 13, 15, 12, 13, 12, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA2
            private static Player Ed_Hartsell = new Player(90, 140, 61, 61, 58, 62, 52, 64, 58, 416, 30, 51, 13, 10, 13, 14, 11, 9, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA3
            private static Player Chester_Takes = new Player(123, 176, 60, 68, 63, 68, 59, 52, 56, 426, 32, 85, 8, 11, 10, 14, 8, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAA4
            private static Player Curtis_Rebell = new Player(169, 152, 56, 61, 74, 62, 60, 62, 68, 443, 58, 60, 11, 15, 17, 13, 10, 13, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xAA5
            private static Player Cody_Fink = new Player(116, 149, 57, 67, 62, 66, 70, 78, 65, 465, 19, 66, 12, 13, 12, 14, 15, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAA6
            private static Player Siria_Chattsley = new Player(169, 177, 64, 72, 61, 69, 67, 60, 68, 461, 51, 54, 11, 12, 10, 19, 11, 15, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xAA7
            private static Player Darren_Catt = new Player(132, 136, 68, 58, 53, 61, 40, 67, 60, 407, 39, 35, 10, 11, 11, 12, 8, 9, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAA8
            private static Player Garry_Planer = new Player(171, 145, 52, 54, 63, 54, 62, 54, 60, 399, 40, 49, 8, 14, 15, 8, 7, 8, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xAA9
            private static Player Glenn_Broth = new Player(167, 152, 55, 60, 52, 61, 60, 52, 56, 396, 54, 80, 14, 13, 16, 16, 17, 16, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xAAA
            private static Player Harry_Angue = new Player(134, 137, 53, 68, 53, 61, 57, 69, 59, 420, 25, 63, 10, 9, 12, 15, 14, 16, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAAB
            private static Player Benny_Terra = new Player(77, 118, 35, 32, 29, 44, 56, 40, 72, 308, 19, 39, 7, 4, 4, 8, 13, 9, 7, 5, 5, 1, 1, 5, 1, 2, 5, 2, 1); // 0xAAC
            private static Player Jasmine_Veile = new Player(149, 161, 72, 60, 70, 72, 52, 72, 65, 463, 46, 47, 12, 11, 14, 15, 10, 11, 12, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAAD
            private static Player Belle_Allure = new Player(145, 161, 62, 55, 44, 62, 72, 66, 69, 430, 52, 56, 12, 11, 7, 11, 17, 15, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xAAE
            private static Player Doug_Lapp = new Player(167, 172, 66, 76, 62, 76, 67, 64, 70, 481, 49, 62, 13, 11, 12, 20, 14, 14, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xAAF
            private static Player Eric_Motter = new Player(149, 132, 49, 53, 60, 79, 53, 54, 59, 407, 43, 39, 9, 12, 13, 7, 7, 7, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xAB0
            private static Player Gyll_Netters = new Player(125, 156, 40, 38, 36, 60, 60, 61, 76, 371, 45, 53, 8, 9, 5, 10, 15, 12, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xAB1
            private static Player Farrah_Fairway = new Player(143, 198, 54, 62, 52, 59, 63, 52, 60, 402, 46, 48, 12, 14, 11, 13, 12, 13, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xAB2
            private static Player Jess_Winkles = new Player(195, 165, 61, 69, 70, 69, 68, 65, 71, 473, 54, 76, 17, 14, 13, 15, 16, 17, 16, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xAB3
            private static Player Barbara_Clector = new Player(99, 136, 44, 57, 59, 53, 71, 52, 63, 399, 32, 51, 12, 9, 9, 7, 17, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xAB4
            private static Player Marilyn_Henshaw = new Player(138, 172, 68, 66, 71, 74, 49, 75, 60, 463, 48, 66, 13, 12, 12, 14, 12, 10, 14, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAB5
            private static Player Nancy_Pickney = new Player(116, 100, 56, 60, 51, 41, 49, 54, 63, 374, 32, 39, 13, 14, 10, 8, 8, 10, 7, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xAB6
            private static Player Clay_Turnor = new Player(209, 152, 76, 68, 60, 71, 44, 78, 65, 462, 79, 62, 12, 13, 12, 15, 14, 13, 12, 2, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAB7
            private static Player Horace_Shlock = new Player(154, 144, 53, 63, 61, 52, 57, 52, 53, 391, 55, 60, 11, 11, 12, 11, 13, 11, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xAB8
            private static Player Sabrina_Passman = new Player(129, 153, 78, 70, 67, 71, 53, 69, 70, 478, 42, 54, 12, 12, 14, 17, 12, 11, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAB9
            private static Player Harpo_Thermier = new Player(147, 130, 56, 52, 59, 70, 53, 62, 59, 411, 55, 72, 16, 16, 15, 17, 16, 15, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xABA
            private static Player August_Dyers = new Player(171, 161, 70, 61, 62, 66, 70, 62, 60, 451, 64, 60, 13, 17, 17, 17, 14, 14, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xABB
            private static Player Nev_Puffer = new Player(176, 157, 58, 68, 70, 52, 70, 65, 64, 447, 57, 59, 12, 16, 20, 10, 10, 12, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xABC
            private static Player Elata_Mighty = new Player(162, 80, 63, 76, 64, 79, 68, 69, 66, 485, 42, 46, 10, 13, 13, 18, 13, 15, 13, 1, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0xABD
            private static Player Ben_Danna = new Player(127, 169, 60, 72, 57, 75, 69, 71, 62, 466, 32, 66, 13, 14, 14, 19, 16, 20, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xABE
            private static Player Elsa_Roamer = new Player(132, 194, 28, 48, 52, 37, 40, 40, 48, 293, 26, 28, 7, 9, 12, 7, 4, 6, 6, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xABF
            private static Player Archy_Seago = new Player(171, 197, 66, 64, 79, 57, 56, 61, 64, 447, 58, 28, 20, 17, 7, 10, 12, 13, 14, 1, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0xAC0
            private static Player Erhardt_Knead = new Player(217, 142, 48, 33, 38, 53, 79, 38, 54, 343, 92, 39, 10, 9, 5, 9, 21, 5, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAC1
            private static Player Lynne_Mandel = new Player(151, 133, 63, 60, 59, 59, 59, 63, 54, 417, 62, 78, 14, 16, 15, 15, 15, 15, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xAC2
            private static Player Craig_Placid = new Player(149, 136, 61, 63, 57, 63, 57, 58, 79, 438, 58, 59, 13, 10, 12, 12, 11, 14, 12, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1); // 0xAC3
            private static Player Leon_Morcey = new Player(134, 160, 62, 72, 58, 70, 66, 76, 65, 469, 30, 76, 12, 14, 15, 20, 13, 18, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAC4
            private static Player Dom_Edarry = new Player(143, 133, 57, 54, 56, 52, 59, 52, 60, 390, 42, 49, 10, 10, 11, 12, 14, 12, 12, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xAC5
            private static Player Jay_Asher = new Player(151, 189, 69, 70, 73, 63, 49, 69, 60, 453, 45, 63, 17, 11, 17, 13, 17, 18, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 5); // 0xAC6
            private static Player Toby_Cohill = new Player(162, 172, 61, 52, 52, 54, 58, 59, 76, 412, 51, 66, 14, 12, 13, 13, 13, 14, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xAC7
            private static Player Nolene_Ider = new Player(110, 132, 53, 56, 54, 60, 62, 68, 55, 408, 28, 47, 11, 11, 11, 7, 12, 13, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xAC8
            private static Player Hoots_Knightly = new Player(140, 173, 69, 76, 52, 70, 65, 74, 63, 469, 30, 62, 11, 11, 15, 19, 14, 19, 13, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAC9
            private static Player Bash_Beaton = new Player(162, 184, 60, 77, 70, 68, 67, 68, 68, 478, 48, 47, 10, 13, 13, 19, 13, 14, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xACA
            private static Player Terry_Toolan = new Player(169, 158, 55, 63, 54, 60, 56, 61, 78, 427, 61, 77, 17, 15, 14, 14, 15, 16, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xACB
            private static Player Callum_Biddy = new Player(118, 100, 43, 44, 66, 44, 65, 51, 53, 366, 30, 42, 10, 8, 14, 10, 17, 10, 7, 5, 5, 1, 5, 2, 5, 2, 5, 1, 3); // 0xACC
            private static Player Alan_Sumner = new Player(215, 173, 44, 68, 76, 79, 77, 68, 72, 484, 64, 80, 12, 15, 17, 20, 14, 16, 16, 5, 5, 5, 2, 5, 2, 5, 5, 5, 4); // 0xACD
            private static Player Trixy_Wonder = new Player(173, 133, 63, 60, 62, 55, 63, 59, 59, 421, 45, 60, 13, 12, 12, 12, 13, 11, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4); // 0xACE
            private static Player Colet_First = new Player(171, 130, 61, 52, 55, 60, 60, 58, 52, 398, 64, 20, 4, 5, 6, 8, 6, 7, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xACF
            private static Player Mac_Gabbon = new Player(145, 142, 79, 52, 61, 52, 54, 63, 58, 419, 50, 65, 18, 13, 14, 12, 10, 11, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xAD0
            private static Player Tip_Bolster = new Player(151, 136, 44, 60, 70, 46, 58, 55, 52, 385, 34, 36, 8, 12, 13, 7, 7, 10, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xAD1
            private static Player Draco_Scallon = new Player(173, 137, 56, 52, 57, 52, 61, 56, 56, 390, 57, 56, 13, 10, 14, 13, 11, 12, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0xAD2
            private static Player Sofia_Brashier = new Player(151, 172, 61, 68, 61, 78, 71, 64, 68, 471, 48, 64, 11, 12, 12, 19, 14, 13, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 4); // 0xAD3
            private static Player Tam_Boyish = new Player(134, 172, 62, 68, 71, 60, 70, 60, 62, 453, 40, 66, 17, 12, 14, 14, 19, 16, 13, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xAD4
            private static Player Mat_Halled = new Player(156, 177, 64, 75, 60, 72, 66, 62, 67, 466, 49, 47, 11, 12, 13, 16, 11, 16, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAD5
            private static Player James_Strang = new Player(217, 140, 49, 53, 60, 60, 60, 78, 56, 416, 72, 42, 13, 7, 10, 9, 17, 16, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAD6
            private static Player Ian_Watchen = new Player(118, 149, 55, 70, 61, 67, 72, 72, 60, 457, 18, 56, 14, 10, 12, 11, 14, 15, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAD7
            private static Player Rose_Snelgrove = new Player(134, 108, 55, 57, 51, 44, 51, 59, 54, 371, 30, 35, 14, 14, 9, 9, 10, 9, 9, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xAD8
            private static Player Bert_Emmerson = new Player(154, 140, 40, 63, 72, 45, 55, 56, 52, 383, 40, 36, 10, 13, 15, 9, 7, 11, 11, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xAD9
            private static Player Irving_Gusher = new Player(169, 153, 76, 66, 63, 60, 71, 60, 71, 467, 30, 20, 17, 6, 7, 5, 8, 8, 4, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xADA
            private static Player Lionel_Silent = new Player(121, 160, 76, 71, 58, 56, 60, 63, 60, 444, 54, 51, 10, 13, 12, 14, 11, 10, 13, 5, 1, 2, 1, 1, 1, 1, 1, 1, 2); // 0xADB
            private static Player Owen_Rage = new Player(121, 110, 46, 64, 51, 48, 44, 51, 43, 347, 42, 48, 9, 9, 11, 10, 10, 9, 8, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xADC
            private static Player Alice_Nutty = new Player(112, 148, 67, 54, 52, 52, 54, 64, 52, 395, 38, 37, 16, 10, 11, 14, 9, 8, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xADD
            private static Player Conrad_Jacket = new Player(118, 158, 58, 75, 69, 71, 78, 55, 52, 458, 39, 35, 11, 11, 8, 7, 11, 9, 10, 2, 2, 2, 3, 3, 3, 3, 2, 2, 1); // 0xADE
            private static Player Hilda_Bronski = new Player(140, 140, 66, 60, 60, 64, 46, 62, 55, 413, 36, 45, 10, 8, 8, 11, 11, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xADF
            private static Player Clint_Peacock = new Player(169, 145, 63, 52, 63, 55, 55, 55, 58, 401, 55, 68, 14, 13, 15, 15, 17, 17, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xAE0
            private static Player Pace_Maker = new Player(81, 152, 64, 56, 60, 70, 34, 61, 60, 405, 37, 53, 10, 10, 9, 13, 7, 10, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAE1
            private static Player Vanity_Percy = new Player(121, 129, 62, 52, 62, 71, 42, 66, 61, 416, 36, 36, 11, 8, 9, 14, 10, 7, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAE2
            private static Player Phil_Pagoda = new Player(149, 172, 68, 63, 64, 71, 45, 68, 61, 440, 58, 66, 14, 13, 12, 17, 11, 12, 13, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAE3
            private static Player Niki_Colbeck = new Player(129, 132, 55, 64, 51, 68, 59, 65, 59, 421, 27, 51, 10, 7, 12, 13, 11, 13, 7, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAE4
            private static Player Guy_Pinnay = new Player(182, 158, 60, 55, 54, 62, 58, 71, 61, 421, 31, 51, 15, 8, 10, 17, 11, 11, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAE5
            private static Player Wayne_Fluke = new Player(156, 198, 56, 52, 62, 57, 60, 56, 53, 396, 56, 93, 12, 11, 10, 13, 12, 11, 10, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4); // 0xAE6
            private static Player Red_Dayers = new Player(143, 152, 60, 63, 57, 60, 52, 60, 57, 409, 37, 48, 9, 9, 9, 16, 10, 10, 9, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAE7
            private static Player Shay_Diebold = new Player(169, 133, 68, 64, 58, 52, 63, 60, 67, 432, 54, 35, 19, 16, 11, 12, 13, 11, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xAE8
            private static Player Tigh_Gerwhite = new Player(217, 177, 79, 76, 44, 79, 71, 40, 68, 457, 66, 81, 17, 15, 9, 19, 17, 5, 16, 2, 5, 2, 5, 5, 5, 5, 2, 5, 2); // 0xAE9
            private static Player Cerise_Crane = new Player(189, 172, 48, 77, 71, 76, 72, 76, 72, 492, 64, 76, 14, 15, 14, 18, 13, 16, 14, 5, 5, 5, 2, 5, 2, 5, 5, 5, 4); // 0xAEA
            private static Player Drack_Gorn = new Player(217, 190, 71, 37, 79, 72, 74, 71, 70, 474, 57, 63, 15, 10, 17, 15, 16, 14, 15, 5, 5, 5, 2, 2, 5, 5, 5, 5, 2); // 0xAEB
            private static Player Terry_Pinn = new Player(118, 169, 42, 76, 72, 70, 79, 68, 78, 485, 45, 76, 14, 17, 17, 14, 17, 20, 16, 5, 5, 5, 5, 5, 5, 2, 2, 5, 2); // 0xAEC
            private static Player Justin_Cush = new Player(145, 152, 71, 70, 69, 76, 52, 77, 70, 485, 44, 54, 12, 10, 13, 16, 10, 12, 12, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAED
            private static Player Bert_McClure = new Player(147, 133, 44, 50, 50, 52, 63, 63, 54, 376, 36, 37, 10, 8, 7, 8, 13, 14, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAEE
            private static Player Richard_Trogg = new Player(154, 157, 54, 53, 47, 71, 72, 64, 65, 426, 55, 62, 10, 13, 8, 11, 18, 14, 14, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAEF
            private static Player Shirly_Quirk = new Player(110, 104, 44, 48, 44, 52, 60, 52, 55, 355, 22, 29, 8, 6, 6, 7, 12, 8, 7, 5, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xAF0
            private static Player Elias_Lens = new Player(88, 140, 60, 67, 48, 69, 55, 60, 52, 411, 30, 65, 10, 10, 11, 15, 13, 15, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAF1
            private static Player Terry_Dryden = new Player(121, 112, 45, 47, 41, 47, 50, 51, 50, 331, 39, 39, 8, 8, 9, 10, 8, 7, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xAF2
            private static Player Ardel_Kernel = new Player(81, 130, 40, 53, 59, 55, 69, 61, 54, 391, 26, 47, 9, 8, 10, 9, 12, 12, 10, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAF3
            private static Player Carl_Belcher = new Player(169, 136, 52, 57, 59, 60, 55, 56, 62, 401, 46, 61, 14, 12, 11, 12, 12, 11, 13, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xAF4
            private static Player Mal_Maroon = new Player(77, 142, 45, 53, 56, 54, 67, 60, 56, 391, 19, 38, 10, 8, 8, 7, 11, 12, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xAF5
            private static Player Ralph_Fary = new Player(167, 144, 68, 67, 60, 58, 60, 61, 64, 438, 54, 21, 19, 17, 14, 11, 11, 13, 13, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xAF6
            private static Player Floyd_Spades = new Player(112, 132, 64, 52, 63, 57, 56, 64, 62, 418, 44, 39, 17, 7, 14, 13, 7, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAF7
            private static Player Remy_Diggun = new Player(165, 129, 58, 61, 54, 56, 62, 59, 54, 404, 64, 66, 15, 13, 17, 13, 13, 17, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xAF8
            private static Player Bern_Macmahon = new Player(171, 129, 55, 55, 57, 53, 60, 57, 60, 397, 64, 70, 17, 16, 16, 14, 15, 15, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xAF9
            private static Player Wally_Cooper = new Player(173, 144, 70, 65, 48, 60, 63, 71, 52, 429, 50, 54, 8, 9, 12, 14, 10, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAFA
            private static Player Griff_Hardcasel = new Player(169, 148, 61, 63, 70, 62, 63, 60, 66, 445, 45, 27, 17, 15, 16, 14, 17, 13, 17, 1, 5, 1, 4, 4, 4, 4, 4, 4, 2); // 0xAFB
            private static Player Pat_Lubow = new Player(123, 109, 51, 47, 49, 40, 49, 44, 45, 325, 93, 107, 21, 20, 23, 21, 22, 21, 22, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xAFC
            private static Player Wilma_Morgan = new Player(162, 138, 64, 60, 52, 80, 56, 69, 61, 442, 56, 29, 19, 14, 13, 14, 14, 12, 11, 1, 5, 1, 1, 1, 2, 1, 1, 1, 2); // 0xAFD
            private static Player Carys_Chaparon = new Player(145, 170, 78, 55, 62, 82, 78, 55, 56, 466, 46, 51, 11, 12, 13, 11, 13, 13, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xAFE
            private static Player Claire_Hostess = new Player(173, 133, 69, 60, 60, 56, 59, 60, 61, 425, 48, 36, 19, 15, 11, 12, 14, 14, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xAFF
            private static Player Katy_Punter = new Player(158, 176, 49, 53, 66, 51, 57, 57, 62, 395, 43, 68, 9, 10, 14, 7, 8, 7, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xB00
            private static Player Pete_Pimento = new Player(180, 136, 67, 53, 63, 52, 52, 61, 60, 408, 45, 38, 15, 11, 12, 17, 9, 11, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB01
            private static Player Mary_Hugland = new Player(121, 115, 74, 73, 76, 42, 48, 49, 46, 408, 44, 40, 11, 9, 9, 9, 10, 8, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB02
            private static Player Lee_Screener = new Player(167, 184, 48, 61, 78, 44, 55, 52, 60, 398, 36, 68, 7, 7, 14, 10, 10, 7, 9, 5, 2, 5, 5, 2, 5, 5, 5, 5, 1); // 0xB03
            private static Player Camilla_Textor = new Player(138, 137, 44, 53, 63, 52, 71, 52, 56, 391, 32, 33, 12, 11, 11, 11, 15, 12, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB04
            private static Player Bish_Beaton = new Player(158, 130, 68, 76, 70, 62, 49, 73, 62, 460, 54, 24, 13, 13, 16, 17, 15, 16, 12, 1, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB05
            private static Player Simeon_Squareyes = new Player(147, 132, 68, 67, 56, 54, 62, 69, 64, 440, 43, 22, 19, 15, 13, 14, 14, 10, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB06
            private static Player Stu_Borneman = new Player(151, 142, 58, 63, 56, 58, 57, 59, 74, 425, 48, 54, 12, 12, 13, 12, 12, 10, 14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB07
            private static Player Herbie_Garnet = new Player(134, 124, 50, 48, 61, 43, 44, 44, 52, 342, 18, 37, 5, 11, 12, 7, 8, 4, 8, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB08
            private static Player Arvin_Inkwell = new Player(149, 150, 54, 56, 57, 61, 56, 54, 52, 390, 22, 28, 4, 8, 7, 6, 6, 4, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB09
            private static Player Rayce_Sprinton = new Player(165, 198, 48, 56, 64, 49, 63, 60, 56, 396, 31, 73, 9, 9, 16, 7, 11, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xB0A
            private static Player Dreama_Bartle = new Player(125, 149, 67, 59, 60, 52, 62, 65, 58, 423, 45, 39, 17, 10, 12, 14, 9, 9, 11, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB0B
            private static Player Jane_Ledbelly = new Player(125, 101, 44, 50, 52, 53, 48, 53, 52, 352, 42, 45, 10, 9, 8, 8, 8, 10, 11, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB0C
            private static Player Dory_O_Bonn = new Player(129, 110, 42, 40, 51, 40, 43, 40, 51, 307, 42, 42, 10, 11, 11, 10, 11, 9, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xB0D
            private static Player Selma_Heaver = new Player(169, 174, 42, 53, 63, 43, 61, 61, 62, 385, 43, 74, 8, 7, 16, 7, 8, 7, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB0E
            private static Player Kath_Leaflin = new Player(169, 156, 52, 53, 60, 56, 56, 57, 56, 390, 69, 72, 15, 14, 17, 17, 13, 15, 16, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xB0F
            private static Player Marg_Shuttle = new Player(127, 136, 64, 58, 56, 55, 60, 68, 60, 421, 36, 47, 17, 9, 12, 13, 8, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB10
            private static Player Duke_Scrubine = new Player(123, 156, 56, 71, 60, 60, 55, 55, 60, 417, 32, 40, 8, 11, 10, 17, 8, 10, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB11
            private static Player Waylon_Tripp = new Player(169, 136, 60, 57, 56, 62, 60, 54, 55, 404, 55, 51, 10, 12, 14, 13, 11, 14, 12, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xB12
            private static Player Jim_Bunner = new Player(114, 129, 53, 60, 62, 58, 70, 62, 59, 424, 21, 47, 10, 8, 7, 9, 14, 14, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB13
            private static Player Jon_Izumo = new Player(136, 153, 63, 68, 56, 73, 67, 76, 66, 469, 18, 60, 12, 13, 15, 17, 13, 17, 10, 1, 1, 1, 5, 1, 5, 1, 1, 1, 4); // 0xB14
            private static Player Del_Brighton = new Player(110, 133, 60, 60, 48, 68, 56, 60, 58, 410, 18, 58, 9, 11, 10, 15, 10, 15, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB15
            private static Player Haden_Safe = new Player(160, 137, 60, 60, 52, 62, 52, 62, 69, 417, 50, 33, 18, 15, 11, 11, 11, 12, 13, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB16
            private static Player Lisle_Plotter = new Player(147, 140, 68, 63, 57, 52, 60, 64, 64, 428, 58, 21, 17, 15, 12, 13, 13, 14, 12, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB17
            private static Player Fen_Skates = new Player(110, 132, 52, 70, 44, 65, 57, 65, 52, 405, 28, 59, 11, 8, 13, 17, 11, 15, 8, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB18
            private static Player Rhoda_Dough = new Player(94, 134, 65, 57, 54, 61, 48, 66, 62, 413, 32, 40, 9, 7, 11, 12, 11, 9, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB19
            private static Player Neil_Seating = new Player(123, 192, 59, 52, 76, 40, 48, 61, 52, 388, 32, 36, 13, 12, 8, 10, 9, 11, 9, 1, 2, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB1A
            private static Player Flo_Nighting = new Player(96, 198, 47, 54, 48, 56, 45, 47, 51, 348, 26, 27, 6, 8, 7, 13, 6, 11, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB1B
            private static Player Elinor_Maven = new Player(158, 149, 57, 55, 45, 65, 77, 62, 61, 422, 43, 66, 11, 14, 6, 12, 19, 13, 11, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xB1C
            private static Player Kay_Gateley = new Player(123, 154, 62, 68, 62, 68, 56, 60, 71, 447, 45, 43, 7, 9, 10, 17, 11, 14, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB1D
            private static Player Dexter_Caise = new Player(83, 152, 68, 57, 56, 63, 34, 62, 59, 399, 44, 47, 9, 9, 10, 13, 9, 8, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB1E
            private static Player Serena_Besse = new Player(191, 176, 64, 70, 70, 70, 69, 60, 65, 468, 30, 35, 10, 11, 17, 10, 9, 10, 10, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xB1F
            private static Player Adrian_Heartly = new Player(123, 164, 71, 64, 70, 63, 66, 60, 63, 457, 44, 23, 5, 8, 4, 6, 8, 8, 6, 1, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xB20
            private static Player Cary_Fearless = new Player(105, 152, 65, 61, 60, 58, 61, 70, 68, 443, 32, 53, 13, 9, 12, 16, 10, 9, 9, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB21
            private static Player Wally_Waymire = new Player(149, 137, 53, 56, 61, 55, 52, 62, 53, 392, 45, 47, 13, 11, 12, 11, 13, 12, 14, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3); // 0xB22
            private static Player Ted_Autumn = new Player(217, 173, 78, 69, 46, 78, 68, 44, 74, 457, 78, 90, 16, 16, 9, 20, 13, 8, 13, 2, 5, 2, 5, 5, 5, 5, 2, 5, 4); // 0xB23
            private static Player Boomer_Smolen = new Player(125, 136, 60, 65, 46, 64, 54, 70, 57, 416, 25, 52, 7, 7, 14, 13, 13, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB24
            private static Player Hank_Ershef = new Player(125, 141, 45, 56, 56, 60, 69, 63, 63, 412, 21, 36, 14, 8, 11, 7, 17, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB25
            private static Player Tim_Opener = new Player(134, 182, 45, 39, 34, 74, 77, 55, 59, 383, 33, 93, 11, 8, 6, 17, 15, 14, 10, 5, 5, 1, 1, 5, 2, 2, 5, 1, 1); // 0xB26
            private static Player Hide_King = new Player(103, 130, 49, 60, 55, 69, 65, 62, 55, 415, 18, 38, 8, 7, 10, 10, 10, 14, 9, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB27
            private static Player Beth_Doodle = new Player(116, 132, 50, 55, 62, 62, 70, 70, 57, 426, 19, 47, 9, 10, 8, 8, 10, 10, 11, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xB28
            private static Player Lamar_Bonesteel = new Player(121, 140, 46, 28, 28, 53, 65, 55, 52, 327, 43, 50, 8, 8, 4, 9, 14, 13, 8, 5, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xB29
            private static Player Dom_Round = new Player(134, 117, 44, 46, 48, 49, 44, 48, 55, 334, 30, 47, 10, 11, 9, 11, 8, 8, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB2A
            private static Player Chip_Stocks = new Player(151, 176, 65, 73, 67, 78, 62, 66, 64, 475, 58, 49, 14, 11, 11, 17, 10, 15, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB2B
            private static Player Blake_Nailor = new Player(169, 70, 48, 69, 75, 78, 32, 60, 54, 416, 38, 20, 9, 13, 16, 16, 8, 9, 7, 4, 1, 1, 2, 2, 2, 1, 4, 1, 2); // 0xB2C
            private static Player Dotty_Hickman = new Player(114, 149, 53, 68, 61, 61, 76, 72, 65, 456, 27, 49, 11, 14, 10, 10, 13, 14, 12, 5, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xB2D
            private static Player Wright_Tandem = new Player(162, 129, 56, 60, 61, 63, 53, 56, 58, 407, 56, 72, 13, 15, 15, 13, 17, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xB2E
            private static Player Shaun_Bonnie = new Player(118, 65, 46, 46, 45, 47, 46, 43, 44, 317, 28, 33, 6, 4, 8, 8, 7, 4, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB2F
            private static Player Andrew_Hooper = new Player(187, 130, 62, 64, 63, 63, 55, 72, 62, 441, 68, 28, 16, 14, 14, 14, 11, 16, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB30
            private static Player Toya_Boyde = new Player(132, 120, 49, 53, 44, 48, 54, 51, 47, 346, 42, 36, 9, 11, 11, 8, 8, 7, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0xB31
            private static Player Taryn_Shyder = new Player(162, 132, 63, 68, 68, 71, 71, 63, 66, 470, 57, 21, 19, 13, 17, 16, 15, 17, 16, 1, 5, 1, 4, 4, 4, 4, 4, 4, 4); // 0xB32
            private static Player Jasmin_Trier = new Player(110, 136, 43, 46, 68, 52, 51, 44, 72, 376, 31, 78, 7, 11, 17, 16, 11, 11, 10, 4, 3, 4, 4, 3, 2, 4, 4, 4, 1); // 0xB33
            private static Player Dave_Lung = new Player(145, 185, 66, 76, 70, 74, 70, 66, 69, 491, 42, 66, 14, 11, 13, 17, 12, 17, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB34
            private static Player Teal_Redsky = new Player(149, 172, 77, 54, 60, 63, 55, 60, 79, 448, 37, 53, 15, 9, 9, 10, 11, 8, 15, 1, 1, 2, 1, 1, 1, 1, 1, 2, 4); // 0xB35
            private static Player Truman_Verdy = new Player(173, 152, 54, 53, 56, 79, 60, 61, 79, 442, 30, 50, 7, 10, 7, 17, 7, 10, 16, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2); // 0xB36
            private static Player Chance_Cerulean = new Player(158, 154, 58, 77, 60, 59, 55, 52, 79, 440, 37, 47, 11, 16, 9, 9, 10, 8, 14, 1, 1, 1, 2, 1, 1, 1, 1, 2, 2); // 0xB37
            private static Player Amy_Peach = new Player(162, 160, 63, 57, 76, 52, 60, 57, 79, 444, 37, 42, 9, 8, 15, 10, 10, 11, 15, 1, 1, 1, 1, 2, 1, 1, 1, 2, 2); // 0xB38
            private static Player Virgil_Amber = new Player(145, 160, 60, 56, 60, 76, 55, 61, 76, 444, 38, 47, 8, 7, 7, 16, 10, 8, 14, 1, 1, 1, 1, 1, 2, 1, 1, 2, 3); // 0xB39
            private static Player Grant_Stodgell = new Player(154, 154, 79, 52, 56, 52, 56, 57, 44, 396, 19, 44, 12, 5, 5, 7, 4, 6, 6, 1, 2, 2, 1, 1, 1, 1, 1, 1, 4); // 0xB3A
            private static Player Payne_Outler = new Player(147, 130, 61, 61, 58, 78, 55, 52, 42, 407, 50, 34, 6, 11, 7, 12, 6, 6, 7, 2, 1, 1, 2, 1, 2, 1, 1, 1, 3); // 0xB3B
            private static Player Malcolm_Shirker = new Player(167, 134, 63, 79, 52, 53, 68, 70, 44, 429, 26, 23, 6, 14, 5, 7, 9, 11, 7, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2); // 0xB3C
            private static Player Hanna_Slack = new Player(158, 162, 56, 52, 79, 53, 58, 56, 49, 403, 26, 47, 7, 5, 10, 4, 5, 6, 5, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2); // 0xB3D
            private static Player Dom_Poppy = new Player(165, 142, 63, 66, 60, 79, 56, 58, 49, 431, 20, 29, 5, 9, 5, 13, 7, 7, 7, 1, 1, 1, 2, 1, 2, 1, 1, 1, 3); // 0xB3E
            private static Player Portia_Maricle = new Player(114, 137, 55, 63, 59, 55, 65, 71, 58, 426, 19, 47, 11, 10, 8, 8, 14, 13, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB3F
            private static Player Susan_Doiley = new Player(118, 129, 67, 52, 59, 54, 63, 71, 54, 420, 44, 41, 14, 10, 12, 13, 10, 11, 7, 5, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB40
            private static Player Hannah_Breer = new Player(138, 112, 40, 44, 50, 49, 44, 46, 46, 319, 44, 40, 9, 9, 8, 9, 11, 8, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xB41
            private static Player Phil_Seebold = new Player(143, 129, 60, 56, 61, 56, 62, 54, 57, 406, 46, 55, 10, 12, 11, 10, 13, 14, 13, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1); // 0xB42
            private static Player Bobbie_Tomey = new Player(145, 140, 60, 72, 56, 56, 53, 61, 65, 423, 57, 28, 18, 14, 13, 10, 14, 12, 11, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB43
            private static Player Randolph_Lords = new Player(123, 166, 56, 70, 55, 62, 56, 60, 60, 419, 38, 39, 8, 8, 9, 13, 9, 12, 11, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB44
            private static Player Robin_Traylor = new Player(134, 160, 60, 71, 61, 68, 78, 71, 60, 469, 32, 51, 13, 13, 14, 12, 16, 16, 13, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB45
            private static Player Fawn_Blossom = new Player(121, 144, 46, 55, 55, 40, 46, 52, 53, 347, 25, 56, 6, 8, 13, 5, 7, 8, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xB46
            private static Player Isabell_Mish = new Player(154, 181, 67, 70, 68, 79, 68, 68, 61, 481, 48, 47, 11, 12, 14, 18, 12, 16, 12, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB47
            private static Player Rudy_Stemper = new Player(112, 130, 44, 36, 35, 54, 68, 52, 69, 358, 34, 44, 9, 9, 7, 11, 14, 13, 10, 5, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xB48
            private static Player Betty_Evenson = new Player(149, 153, 50, 57, 68, 55, 54, 55, 52, 391, 46, 64, 7, 11, 17, 9, 11, 9, 9, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB49
            private static Player Harpo_Kendrick = new Player(134, 161, 62, 65, 71, 60, 78, 72, 63, 471, 27, 62, 14, 13, 14, 12, 16, 16, 14, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB4A
            private static Player Colin_Glower = new Player(169, 172, 47, 56, 76, 48, 60, 56, 56, 399, 45, 77, 9, 8, 14, 8, 9, 11, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xB4B
            private static Player Tailor_Wilden = new Player(151, 128, 57, 56, 45, 52, 53, 60, 58, 381, 39, 36, 14, 12, 9, 7, 10, 9, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1); // 0xB4C
            private static Player Sim_Cebus = new Player(151, 164, 79, 66, 64, 79, 51, 71, 60, 470, 48, 55, 10, 14, 13, 14, 14, 10, 12, 5, 1, 2, 1, 1, 2, 5, 2, 1, 4); // 0xB4D
            private static Player Sam_Banks = new Player(96, 156, 54, 56, 58, 77, 28, 79, 68, 420, 18, 51, 14, 13, 11, 13, 7, 21, 14, 5, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0xB4E
            private static Player Frank_Homey = new Player(90, 134, 40, 53, 60, 53, 64, 68, 60, 398, 24, 39, 11, 10, 7, 9, 14, 10, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB4F
            private static Player Gregg_Deremer = new Player(156, 150, 76, 56, 67, 45, 62, 63, 28, 397, 30, 65, 7, 10, 14, 11, 9, 9, 7, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB50
            private static Player Verne_Spring = new Player(200, 188, 71, 44, 77, 72, 79, 73, 78, 494, 63, 68, 14, 13, 16, 15, 17, 14, 17, 5, 5, 5, 2, 2, 5, 5, 5, 5, 4); // 0xB51
            private static Player Bryan_Klamm = new Player(134, 133, 51, 56, 55, 55, 66, 59, 53, 395, 30, 36, 14, 9, 10, 7, 13, 11, 8, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB52
            private static Player Colt_Youngstein = new Player(171, 178, 69, 72, 79, 63, 50, 71, 62, 466, 52, 47, 15, 13, 15, 15, 15, 18, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB53
            private static Player Will_Kilmon = new Player(143, 109, 51, 49, 52, 48, 44, 53, 55, 352, 45, 43, 10, 7, 10, 7, 9, 11, 9, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB54
            private static Player Milly_Vacey = new Player(147, 140, 68, 70, 55, 59, 55, 71, 64, 442, 45, 27, 18, 16, 14, 11, 12, 12, 10, 1, 5, 1, 1, 1, 1, 1, 1, 1, 4); // 0xB55
            private static Player Dany_Destiny = new Player(202, 149, 54, 61, 62, 54, 60, 68, 62, 421, 69, 35, 16, 16, 12, 15, 12, 20, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xB56
            private static Player Gary_Primo = new Player(147, 170, 79, 57, 52, 55, 54, 60, 40, 397, 31, 46, 12, 6, 7, 6, 5, 6, 8, 1, 2, 2, 1, 1, 1, 1, 1, 1, 4); // 0xB57
            private static Player Bobby_Duo = new Player(151, 142, 62, 60, 55, 79, 60, 53, 51, 420, 55, 21, 4, 8, 5, 13, 5, 5, 5, 2, 1, 1, 2, 1, 2, 1, 1, 1, 2); // 0xB58
            private static Player Stan_Treece = new Player(143, 140, 56, 79, 59, 57, 65, 66, 51, 433, 22, 38, 4, 11, 5, 6, 8, 8, 6, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2); // 0xB59
            private static Player Lillie_Quattro = new Player(160, 156, 53, 60, 79, 58, 53, 54, 48, 405, 34, 38, 4, 6, 10, 6, 8, 6, 8, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2); // 0xB5A
            private static Player Eddy_Pentaris = new Player(154, 146, 55, 71, 60, 78, 55, 56, 40, 415, 33, 28, 8, 10, 6, 12, 8, 5, 8, 1, 1, 1, 2, 1, 2, 1, 1, 1, 3); // 0xB5B
            private static Player Candice_Mell = new Player(81, 132, 69, 52, 61, 53, 60, 61, 55, 411, 31, 47, 7, 11, 11, 9, 14, 13, 7, 5, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB5C
            private static Player Alex_Dauger = new Player(165, 182, 71, 76, 68, 73, 64, 63, 63, 478, 49, 62, 12, 14, 12, 20, 10, 13, 14, 1, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB5D
            private static Player Joe_Divide = new Player(147, 144, 61, 62, 52, 56, 59, 63, 63, 416, 54, 35, 19, 15, 10, 12, 12, 11, 13, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB5E
            private static Player Sam_Willing = new Player(165, 136, 55, 63, 56, 52, 55, 60, 62, 403, 43, 48, 12, 10, 14, 10, 13, 12, 10, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1); // 0xB5F
            private static Player Mary_Antoine = new Player(132, 173, 76, 77, 79, 68, 76, 44, 47, 467, 28, 103, 10, 13, 22, 10, 21, 7, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5); // 0xB60
            private static Player Edward_Baron = new Player(147, 169, 79, 76, 74, 77, 44, 48, 52, 450, 34, 72, 23, 18, 18, 19, 6, 4, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5); // 0xB61
            private static Player Tim_Platton = new Player(145, 132, 52, 60, 60, 53, 63, 60, 52, 400, 51, 55, 12, 10, 12, 11, 12, 12, 11, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xB62
            private static Player Argento_Salvage = new Player(193, 172, 60, 65, 60, 66, 70, 68, 69, 458, 62, 62, 17, 17, 17, 14, 17, 13, 17, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2); // 0xB63
            private static Player Finn_Geld = new Player(217, 173, 79, 68, 77, 79, 43, 79, 46, 471, 81, 66, 23, 19, 18, 19, 7, 20, 7, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5); // 0xB64
            private static Player Ian_Moray = new Player(165, 140, 63, 60, 52, 56, 52, 60, 54, 397, 62, 72, 16, 15, 16, 14, 15, 14, 17, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xB65
            private static Player Gil_Holden = new Player(149, 156, 44, 60, 66, 50, 57, 60, 61, 398, 42, 80, 7, 8, 13, 11, 10, 9, 10, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB66
            private static Player Doyle_Palmer = new Player(162, 133, 59, 55, 57, 57, 63, 53, 56, 400, 60, 60, 15, 15, 15, 15, 16, 15, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2); // 0xB67
            private static Player Audry_Orange = new Player(134, 112, 52, 53, 48, 48, 48, 56, 44, 349, 28, 24, 10, 5, 8, 14, 6, 7, 6, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB68
            private static Player May_Apple = new Player(127, 132, 40, 44, 52, 48, 46, 44, 49, 323, 34, 47, 6, 7, 11, 8, 8, 4, 4, 4, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB69
            private static Player Ginny_White = new Player(110, 80, 51, 52, 48, 40, 44, 52, 47, 334, 28, 20, 12, 9, 7, 6, 6, 7, 4, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xB6A
            private static Player Angus_Hogg = new Player(136, 61, 44, 44, 41, 44, 43, 45, 54, 315, 27, 32, 12, 11, 7, 7, 7, 8, 8, 1, 5, 1, 1, 1, 1, 1, 1, 1, 3); // 0xB6B
            private static Player In_Chikita = new Player(143, 146, 66, 66, 59, 62, 61, 60, 68, 442, 52, 29, 17, 15, 10, 14, 13, 14, 13, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xB6C
            private static Player Sabrina_Carow = new Player(165, 136, 68, 63, 60, 60, 52, 68, 69, 440, 43, 33, 18, 15, 13, 13, 12, 12, 14, 1, 5, 1, 1, 1, 1, 1, 1, 1, 2); // 0xB6D
            private static Player Bob_Beelzy = new Player(127, 165, 68, 69, 64, 73, 52, 78, 67, 471, 46, 51, 13, 10, 10, 15, 12, 13, 10, 5, 1, 2, 1, 1, 2, 5, 2, 1, 4); // 0xB6E
            private static Player Patt_Howell = new Player(149, 146, 61, 60, 60, 53, 60, 56, 63, 413, 70, 66, 17, 14, 15, 17, 14, 16, 15, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3); // 0xB6F
            private static Player Ol_Factory = new Player(83, 132, 69, 56, 57, 64, 36, 62, 62, 406, 43, 39, 9, 10, 9, 12, 9, 7, 8, 5, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB70
            private static Player Tom_Skipper = new Player(217, 140, 76, 72, 79, 64, 56, 52, 79, 478, 79, 101, 23, 21, 19, 12, 13, 5, 14, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4); // 0xB71
            private static Player Axel_Blaze_IE1 = new Player(200, 176, 79, 66, 76, 64, 72, 68, 60, 485, 49, 63, 18, 16, 13, 14, 14, 12, 12, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2); // 0xB72

            public IDictionary<int, Player> IE2Player = new Dictionary<int, Player>
            {
                { 0x01, Mark_Evans},
{ 0x02, Nathan_Swift},
{ 0x03, Jack_Wallside},
{ 0x04, Jim_Wraith},
{ 0x05, Tod_Ironside},
{ 0x06, Steve_Grim},
{ 0x07, Tim_Saunders},
{ 0x08, Sam_Kincaid},
{ 0x09, Maxwell_Carson},
{ 0x0A, Axel_Blaze},
{ 0x0B, Kevin_Dragonfly},
{ 0x0C, William_Glass},
{ 0x0D, Nelly_Raimon_IE1},
{ 0x0E, Celia_Hills_IE1},
{ 0x0F, Silvia_Woods_IE1},
{ 0x10, Nash},
{ 0x11, Sater},
{ 0x12, Isaacs},
{ 0x13, Frank_Wintersea},
{ 0x15, Joseph_King},
{ 0x16, Peter_Drent},
{ 0x17, Ben_Simmons},
{ 0x18, Alan_Master},
{ 0x19, Gus_Martin},
{ 0x1A, Herman_Waldon},
{ 0x1B, John_Bloom},
{ 0x1C, Derek_Swing},
{ 0x1D, Daniel_Hatch},
{ 0x1E, Jude_Sharp_RA},
{ 0x1F, David_Samford},
{ 0x20, Bob_Carlton},
{ 0x21, Cliff_Tomlinson},
{ 0x22, Jim_Lawrenson},
{ 0x23, Barry_Potts},
{ 0x24, Steve_Ingham},
{ 0x29, Nathan_Jones},
{ 0x2A, Russell_Walk},
{ 0x2B, Jason_Jones},
{ 0x2C, Ken_Furan},
{ 0x2D, Jerry_Fulton},
{ 0x2E, Ray_Mannings},
{ 0x2F, Robert_Mayer},
{ 0x30, Alexander_Brave},
{ 0x31, Johan_Tassman},
{ 0x32, Troy_Moon},
{ 0x33, Burt_Wolf},
{ 0x34, Rob_Crombie},
{ 0x35, Chuck_Dollman},
{ 0x36, Uxley_Allen},
{ 0x37, Phil_Noir},
{ 0x38, Mick_Askley},
{ 0x3D, Charlie_Boardfield},
{ 0x3E, Hugo_Tallgeese},
{ 0x3F, Wilson_Fishman},
{ 0x40, Peter_Johnson_},
{ 0x41, Leonard_O_Shea},
{ 0x42, Cham_Lion},
{ 0x43, Steve_Eagle},
{ 0x44, Bruce_Monkey},
{ 0x45, Gary_Lancaster},
{ 0x46, Harry_Snake},
{ 0x47, Adrian_Speed},
{ 0x48, Alan_Coe},
{ 0x49, Philip_Anders},
{ 0x4A, Rocky_Rackham},
{ 0x4B, Matt_Mouseman},
{ 0x4C, Chad_Bullford},
{ 0x51, Thomas_Feldt},
{ 0x52, Harry_Leading},
{ 0x53, Terry_Stronger},
{ 0x54, Philip_Marvel},
{ 0x55, Noel_Good},
{ 0x56, Tyron_Rock},
{ 0x57, Francis_Tell},
{ 0x58, Samuel_Buster},
{ 0x59, Jonathan_Seller},
{ 0x5A, Victor_Kind},
{ 0x5B, Neil_Turner},
{ 0x5C, Reg_Underwood},
{ 0x5D, Patrick_Stiller},
{ 0x5E, Charles_Oughtry},
{ 0x5F, Clive_Mooney},
{ 0x60, Neil_Waters},
{ 0x65, Sam_Idol},
{ 0x66, Marcus_Train},
{ 0x67, Light_Nobel},
{ 0x68, Walter_Valiant},
{ 0x69, Spencer_Gates},
{ 0x6A, Josh_Spear},
{ 0x6B, Gaby_Farmer},
{ 0x6C, A__Woodbridge},
{ 0x6D, Gus_Gamer},
{ 0x6E, Mark_Gambling},
{ 0x6F, Theodore_Master},
{ 0x70, Ham_Signalman},
{ 0x71, Bill_Formby},
{ 0x72, Grant_Eldorado},
{ 0x73, Mike_Vox},
{ 0x74, Ollie_Webb},
{ 0x79, Morgan_Sanders},
{ 0x7A, Newton_Flust},
{ 0x7B, Jim_Hillfort},
{ 0x7C, Galen_Thunderbird},
{ 0x7D, Finn_Stoned},
{ 0x7E, Phil_Wingate},
{ 0x7F, Jez_Shell},
{ 0x80, Jupiter_Jumper},
{ 0x81, Sam_Samurai},
{ 0x82, Hank_Sullivan},
{ 0x83, Sail_Bluesea},
{ 0x84, John_Reynolds},
{ 0x85, Dan_Hopper},
{ 0x86, Cal_Trops},
{ 0x87, Winston_Falls},
{ 0x88, Kevin_Castle},
{ 0x8D, Albert_Green},
{ 0x8E, Seward_Hayseed},
{ 0x8F, Kent_Work},
{ 0x90, Mark_Hillvalley_},
{ 0x91, Herb_Sherman},
{ 0x92, Joe_Small},
{ 0x93, Ike_Steiner},
{ 0x94, Orville_Newman},
{ 0x95, Tom_Walters},
{ 0x96, Daniel_Dawson},
{ 0x97, Stuart_Racoonfur},
{ 0x98, Lorne_Mower},
{ 0x99, Homer_Grower},
{ 0x9A, Rolf_Howells},
{ 0x9B, Luke_Lively},
{ 0x9C, Ben_Nevis},
{ 0xA1, John_Neville},
{ 0xA2, Malcolm_Night},
{ 0xA3, Alfred_Meenan},
{ 0xA4, Dan_Mirthful},
{ 0xA5, Ricky_Clover},
{ 0xA6, Toby_Damian},
{ 0xA7, York_Nashmith},
{ 0xA8, Zachary_Moore},
{ 0xA9, Marvin_Murdock},
{ 0xAA, Thomas_Murdock},
{ 0xAB, Tyler_Murdock},
{ 0xAC, Simon_Calier},
{ 0xAD, Brody_Gloom},
{ 0xAE, Victor_Talis},
{ 0xAF, Eren_Middleton},
{ 0xB0, Peter_Wells},
{ 0xB5, Paul_Siddon},
{ 0xB6, Apollo_Light},
{ 0xB7, Jeff_Iron},
{ 0xB8, Lane_War},
{ 0xB9, Danny_Wood},
{ 0xBA, Artie_Mishman},
{ 0xBB, Arion_Matlock},
{ 0xBC, Wesley_Knox},
{ 0xBD, Jonas_Demetrius},
{ 0xBE, Byron_Love},
{ 0xBF, Henry_House},
{ 0xC0, Iggy_Russ},
{ 0xC1, Gus_Heeley},
{ 0xC2, Harry_Closs},
{ 0xC3, Andy_Chronic},
{ 0xC4, Ned_Yousef},
{ 0xC9, Herman_Muller},
{ 0xCA, Keth_Claus},
{ 0xCB, Robert_Silver},
{ 0xCC, Izzy_Island},
{ 0xCD, Sothern_Newman},
{ 0xCE, Irwin_Hall},
{ 0xCF, Taylor_Higgins},
{ 0xD0, Jamie_Cool},
{ 0xD1, Hans_Randall},
{ 0xD2, Michael_Riverside},
{ 0xD3, Millie_Moonlight},
{ 0xD4, Karl_Blue},
{ 0xD5, Theakston_Plank},
{ 0xD6, Ken_Cake},
{ 0xD7, Mitch_Grumble},
{ 0xD8, Bart_Grantham},
{ 0xDD, Joe_Ingram},
{ 0xDE, Kendall_Sefton},
{ 0xDF, Jason_Strike},
{ 0xE0, Norman_Porter},
{ 0xE1, Maxwell_Claus},
{ 0xE2, Bruce_Chaney},
{ 0xE3, Leroy_Rhymes},
{ 0xE4, Mildford_Scott},
{ 0xE5, Lou_Edmonds},
{ 0xE6, Cameron_Morefield},
{ 0xE7, Greg_Bernard},
{ 0xE8, Peter_Banker},
{ 0xE9, Saul_Tunk},
{ 0xEA, Alan_Most},
{ 0xEB, Paul_Caperock},
{ 0xEC, Julius_Molehill},
{ 0xF1, Suzanne_Yuma},
{ 0xF2, Tammy_Fielding},
{ 0xF3, Alex_Lovely},
{ 0xF4, Louis_Hillside},
{ 0xF5, Ness_Sheldon},
{ 0xF6, Lizzy_Squirrel},
{ 0xF7, Kippy_Jones},
{ 0xF8, Fayette_Riversong},
{ 0xF9, Samantha_Moonlight},
{ 0xFA, Mitch_Sandstone},
{ 0xFB, Eddie_Prentice},
{ 0xFC, Alf_Holmes},
{ 0xFD, Ian_Stager},
{ 0xFE, Fred_Crumb},
{ 0xFF, Doug_Baughan},
{ 0x100, Pip_Daltry},
{ 0x105, Seymour_Hillman},
{ 0x106, Charles_Island},
{ 0x107, Garret_Hairtown},
{ 0x108, Arthur_Sweet},
{ 0x109, Peter_Mildred},
{ 0x10A, Josh_Nathaniel},
{ 0x10B, Edward_Gladstone},
{ 0x10C, Tyler_Thomas},
{ 0x10D, Joseph_Yosemite},
{ 0x10E, Ian_Suffolk},
{ 0x10F, Constant_Builder},
{ 0x110, Ted_Poe},
{ 0x111, Marshall_Heart},
{ 0x112, Dom_Foreman},
{ 0x113, Slot_MacHines},
{ 0x114, Bill_Steakspear},
{ 0x119, Layton},
{ 0x11A, Luke},
{ 0x11B, Anton},
{ 0x11C, Don_Paolo},
{ 0x11D, Flora},
{ 0x11E, Chelmey},
{ 0x12D, Jimmy_Mach},
{ 0x12E, Tony_Hacker},
{ 0x12F, Dan_Rhino},
{ 0x130, Vin_Fleetwood},
{ 0x131, George_Winters},
{ 0x132, Den_Hidden},
{ 0x133, Shaun_Imago},
{ 0x134, Joe_Straiter},
{ 0x135, Rupert_Spiers},
{ 0x136, Mark_Sudor},
{ 0x137, Ringo_Stagg},
{ 0x138, Jody_MacGough},
{ 0x139, Jeeves_Dropper},
{ 0x13A, Dan_Dandy},
{ 0x13B, Rory_Boomer},
{ 0x13C, Tim_Toppel},
{ 0x13D, Ames_Shivers},
{ 0x13E, Chris_Glover},
{ 0x13F, Thor_Toise},
{ 0x140, Colin_Salts},
{ 0x141, Christian_Dear},
{ 0x142, Iggy_Loyaller},
{ 0x143, Conan_Fox},
{ 0x144, Spike_Coiffs},
{ 0x145, Roger_Rocket},
{ 0x146, Bill_Teller},
{ 0x147, Billy_Nomates},
{ 0x148, Harry_Caine},
{ 0x149, Martin_Sheller},
{ 0x14A, Alfie_Fine},
{ 0x14B, Cameron_Mann},
{ 0x14C, Don_Keys},
{ 0x14D, Sonny_East},
{ 0x14E, Dan_Carpenter},
{ 0x14F, Doug_Walker},
{ 0x150, Frank_Drake},
{ 0x151, Chris_Massey},
{ 0x152, Carl_Sacks},
{ 0x153, Biff_Beeston},
{ 0x154, Lou_Beigh},
{ 0x155, Marv_Errick},
{ 0x156, Bob_Whittle},
{ 0x157, Bert_Neptune},
{ 0x158, Sol_Crater},
{ 0x159, Percy_Coldstair},
{ 0x15A, Dusky_Sunfield},
{ 0x15B, Rocky_Shears},
{ 0x15C, Percy_Stent},
{ 0x15D, Art_Pendragon},
{ 0x15E, Dom_Ittory},
{ 0x15F, Chaz_Biggins},
{ 0x160, Sly_O_Hands},
{ 0x161, Sean_Lavender},
{ 0x162, Ace_Server},
{ 0x163, Horace_Nelson},
{ 0x164, Rex_George},
{ 0x165, Philip_Prince},
{ 0x166, Heath_Rower},
{ 0x167, Kim_Arite},
{ 0x168, Jay_Archer},
{ 0x169, Bo_Ling},
{ 0x16A, Chuck_Hardy},
{ 0x16B, Ben_Evolent},
{ 0x16C, Will_Noble},
{ 0x16D, Jack_Frosty},
{ 0x16E, Larry_Helps},
{ 0x16F, Monty_Patten},
{ 0x170, Chunk_Gorman},
{ 0x171, Balt_Decker},
{ 0x172, Drew_Crenshaw},
{ 0x173, Stan_Trum},
{ 0x174, Sham_Spike},
{ 0x175, Rainier_Welkin},
{ 0x176, Evan_Yielding},
{ 0x177, Phil_Anthropic},
{ 0x178, Fane_Club},
{ 0x179, Slim_Lanky},
{ 0x17A, Pearson_Gaze},
{ 0x17B, Edward_Albion},
{ 0x17C, Stu_Dent},
{ 0x17D, Barry_Straw},
{ 0x17E, Bobby_Peel},
{ 0x17F, Dan_Castella},
{ 0x180, Bill_Moony},
{ 0x181, Buddy_Goodman},
{ 0x182, Dex_Territy},
{ 0x183, Vinny_O_Gaines},
{ 0x184, Ray_Deo},
{ 0x185, Archie_Meades},
{ 0x186, Dave_Chaucer},
{ 0x187, Billy_Blanc},
{ 0x188, Creed_Craving},
{ 0x189, Phil_Rosey},
{ 0x18A, Harry_Redcastle},
{ 0x18B, Sonny_Welkin},
{ 0x18C, Teddy_Kodiak},
{ 0x18D, Lloyd_Tabb},
{ 0x18E, Francis_Paine},
{ 0x18F, Griff_Strummer},
{ 0x190, Bryce_Bergman},
{ 0x191, Fingus_Inky},
{ 0x192, Walter_Geyser},
{ 0x193, Les_Knightley},
{ 0x194, Conor_Abley},
{ 0x195, Ainsley_Burns},
{ 0x196, Pete_Grimes},
{ 0x197, Manny_Steele},
{ 0x198, Trey_Hugger},
{ 0x199, Jack_Mate},
{ 0x19A, Mike_Chequer},
{ 0x19B, Berty_Adman},
{ 0x19C, Troy_Carr},
{ 0x19D, Hollis_Ticure},
{ 0x19E, Guy_Dance},
{ 0x19F, Jack_Trumper},
{ 0x1A0, John_Corder},
{ 0x1A1, Nigel_Bramel},
{ 0x1A2, Hank_O_Chief},
{ 0x1A3, Jess_Uplement},
{ 0x1A4, Alec_Smart},
{ 0x1A5, Rob_Anchor},
{ 0x1A6, Brent_Cross},
{ 0x1A7, Albert_Wister},
{ 0x1A8, Nev_Erin},
{ 0x1A9, Caz_Yewell},
{ 0x1AA, Conor_Trail},
{ 0x1AB, Manuel_Gere},
{ 0x1AC, Per_Hockside},
{ 0x1AD, Lee_Gleagle},
{ 0x1AE, Paul_Pitcher},
{ 0x1AF, Turner_Fortune},
{ 0x1B0, Walter_Walken},
{ 0x1B1, Sal_Curie},
{ 0x1B2, Silver_Platt},
{ 0x1B3, Nick_Yergrub},
{ 0x1B4, Mal_Inger},
{ 0x1B5, Jim_Cook},
{ 0x1B6, Gus_Potter},
{ 0x1B7, Handel_Turnon},
{ 0x1B8, Peter_Malus},
{ 0x1B9, Colin_Lection},
{ 0x1BA, Brock_Twigg},
{ 0x1BB, Paddy_Rise},
{ 0x1BC, Dustin_Westend},
{ 0x1BD, Alfonse_Way},
{ 0x1BE, Pippin_Flowers},
{ 0x1BF, Euan_Stamper},
{ 0x1C0, Paddy_Prunus},
{ 0x1C1, Brian_Presser},
{ 0x1C2, Pete_LeGume},
{ 0x1C3, Shylock_Watson},
{ 0x1C4, Ed_Ripp},
{ 0x1C5, Hike_Basher},
{ 0x1C6, Anthony_Phinder},
{ 0x1C7, Duncan_Jump},
{ 0x1C8, Lucky_Winn},
{ 0x1C9, Gene_Bates},
{ 0x1CA, Randolf_Finn},
{ 0x1CB, Ron_Away},
{ 0x1CC, Rick_Hatter},
{ 0x1CD, Grant_Mardy},
{ 0x1CE, Shawn_Broker},
{ 0x1CF, Anthony_Coyne},
{ 0x1D0, Healey_Proctor},
{ 0x1D1, Ade_Posting},
{ 0x1D2, Doug_Outon},
{ 0x1D3, Ebenezer_Marner},
{ 0x1D4, Davy_Johns},
{ 0x1D5, Bos_Horne},
{ 0x1D6, Nick_Orner},
{ 0x1D7, Nathin_Gaunt},
{ 0x1D8, Quentin_Quartz},
{ 0x1D9, Andrew_Meikle},
{ 0x1DA, Gary_Salmon},
{ 0x1DB, Fontaine_Tapper},
{ 0x1DC, Leon_Lawn},
{ 0x1DD, Jim_Sweatman},
{ 0x1DE, Cole_Coaker},
{ 0x1DF, Stu_Born},
{ 0x1E0, Romeo_Montague},
{ 0x1E1, Drew_Straitedge},
{ 0x1E2, Dash_Dotter},
{ 0x1E3, Gill_O_Mend},
{ 0x1E4, Pay_Chance},
{ 0x1E5, Bill_Aegis},
{ 0x1E6, Tosh_Coach},
{ 0x1E7, Carl_Gnu},
{ 0x1E8, Paul_Sapp},
{ 0x1E9, Macky_Valley},
{ 0x1EA, Troy_Trucker},
{ 0x1EB, Haden_Seek},
{ 0x1EC, Kevin_Doors},
{ 0x1ED, Skip_Rooter},
{ 0x1EE, Rip_Airman},
{ 0x1EF, Stu_Shiner},
{ 0x1F0, Matt_Matickal},
{ 0x1F1, Philip_Flagg},
{ 0x1F2, Alf_Groundsman},
{ 0x1F3, Ernie_Riddell},
{ 0x1F4, Len_Stint},
{ 0x1F5, Holly_Cricket},
{ 0x1F6, Dave_Altair},
{ 0x1F7, Jim_Reed},
{ 0x1F8, Gwyn_Penn},
{ 0x1F9, Spike_Needle},
{ 0x1FA, Ifan_Tassy},
{ 0x1FB, Eggbert_Heading},
{ 0x1FC, Pascal_Blaise},
{ 0x1FD, Will_Whist},
{ 0x1FE, Ewan_Liner},
{ 0x1FF, Buster_Locke},
{ 0x200, Rex_Plorer},
{ 0x201, Webber_Poster},
{ 0x202, Sid_Parting},
{ 0x203, Eaton_Rampage},
{ 0x204, Parker_Leaper},
{ 0x205, Hank_Halberd},
{ 0x206, Robin_Catching},
{ 0x207, Trey_Spotter},
{ 0x208, Onslow_Ball},
{ 0x209, Tex_Tingle},
{ 0x20A, Sam_Gale},
{ 0x20B, Ryder_Waverly},
{ 0x20C, Leaf_Scarlett},
{ 0x20D, Horace_Coop},
{ 0x20E, Ness_Lockley},
{ 0x20F, Olef_Tennant},
{ 0x210, Len_Scapp},
{ 0x211, Monty_Hillary},
{ 0x212, Penfold_Pulper},
{ 0x213, Thomas_Cott},
{ 0x214, Spike_Thorne},
{ 0x215, Lincoln_Hawking},
{ 0x216, Ted_Larkin},
{ 0x217, Madison_Cabinet},
{ 0x218, Odo_Cologne},
{ 0x219, Nester_Damus},
{ 0x21A, Herb_Ivore},
{ 0x21B, Homer_Pidgeon},
{ 0x21C, Rob_Ottley},
{ 0x21D, Scott_Springer},
{ 0x21E, Viv_Grey},
{ 0x21F, Don_Snow},
{ 0x220, Hal_Mullet},
{ 0x221, Isaiah_Shutt},
{ 0x222, Ace_Irvin},
{ 0x223, Spike_Pitt},
{ 0x224, Innes_Caving},
{ 0x225, Keanu_Dell},
{ 0x226, Casey_Novak},
{ 0x227, Ed_Halley},
{ 0x228, Burt_Mocking},
{ 0x229, Oscar_Petty},
{ 0x22A, Waite_Forrit},
{ 0x22B, Bennett_Byers},
{ 0x22C, Mo_Eisner},
{ 0x22D, Miles_Seaford},
{ 0x22E, Sayer_Lemon},
{ 0x22F, Carey_Ginu},
{ 0x230, Cass_Crocker},
{ 0x231, Paul_Downs},
{ 0x232, Darrel_Jeeling},
{ 0x233, Nobby_Shinn},
{ 0x234, Theo_Broma},
{ 0x235, Ramsey_Faroe},
{ 0x236, Buster_Chopps},
{ 0x237, Vince_Bull},
{ 0x238, Pat_Maclean},
{ 0x239, Walter_Card},
{ 0x23A, Derek_Terr},
{ 0x23B, Alton_Oldhat},
{ 0x23C, Cal_Cooler},
{ 0x23D, Tom_Felix},
{ 0x23E, Terry_Orr},
{ 0x23F, Rudolph_Rainder},
{ 0x240, Nick_Swagg},
{ 0x241, Hal_Leeward},
{ 0x242, Arthur_Dox},
{ 0x243, Reese_Ickle},
{ 0x244, Finn_Attick},
{ 0x245, Col_Lector},
{ 0x246, Crispin_Shooter},
{ 0x247, Stu_Perstitious},
{ 0x248, Ashley_Fay},
{ 0x249, Luke_Raffles},
{ 0x24A, Stu_Helmsley},
{ 0x24B, Terrence_Anthem},
{ 0x24C, Gene_Bottle},
{ 0x24D, Sam_O_Reilly},
{ 0x24E, Ches_Nutcracker},
{ 0x24F, Victor_Grand},
{ 0x250, Ant_Hophila},
{ 0x251, Hunter_Glory},
{ 0x252, Joe_Rassock},
{ 0x253, Patch_Borgnine},
{ 0x254, Ted_Fast},
{ 0x255, Clay_Modlin},
{ 0x256, Alan_Mode},
{ 0x257, Harry_Harper},
{ 0x258, Pascal_Richter},
{ 0x259, Beau_Fort},
{ 0x25A, Reid_Scarlet},
{ 0x25B, Joe_Lamkin},
{ 0x25C, Dylan_Magpie},
{ 0x25D, Gil_Rivers},
{ 0x25E, Des_Tiny},
{ 0x25F, Saul_Dowd},
{ 0x260, Kit_Chapman},
{ 0x261, Fry_Vollity},
{ 0x262, Clark_Roach},
{ 0x263, Samuel_Peeps},
{ 0x264, Dai_Hart},
{ 0x265, Horty_Courture},
{ 0x266, Bob_Baggum},
{ 0x267, Ollie_Twister},
{ 0x268, Fred_Makepeace},
{ 0x269, Walker_Sleep},
{ 0x26A, Sean_Trawler},
{ 0x26B, Ken_Sewer},
{ 0x26C, Bamber_Shoot},
{ 0x26D, Sly_Winker},
{ 0x26E, Teller_Scoap},
{ 0x26F, Sam_Firman},
{ 0x270, Bear_Turnbull},
{ 0x271, Tabor_Drummond},
{ 0x272, Brook_Atwater},
{ 0x273, Ike_Doerflinger},
{ 0x274, Aessop_Fabel},
{ 0x275, Grant_Slammer},
{ 0x276, Robin_Cruise},
{ 0x277, Mark_Perfect},
{ 0x278, Rolly_Kerr},
{ 0x279, Moses_Pumper},
{ 0x27A, Knight_Reader},
{ 0x27B, Cash_Barganier},
{ 0x27C, Brendan_Branch},
{ 0x27D, Clark_Rain},
{ 0x27E, Luther_Rio},
{ 0x27F, Florian_Hutter},
{ 0x280, Scamp_Shrimplin},
{ 0x281, Adam_Nesiac},
{ 0x282, Rab_Acus},
{ 0x283, Chris_Miles},
{ 0x284, Shemmy_Ramis},
{ 0x285, Lon_Grainger},
{ 0x286, Manny_Atom},
{ 0x287, Bill_Tardy},
{ 0x288, Fox_Copier},
{ 0x289, Cletus_Badden},
{ 0x28A, Skip_Sofrenic},
{ 0x28B, Mat_Char},
{ 0x28C, Trey_Cultivator},
{ 0x28D, Vinny_Trioquist},
{ 0x28E, Ton_Nino},
{ 0x28F, Oscar_Esher},
{ 0x290, Saul_Searcher},
{ 0x291, Gerry_Attrick},
{ 0x292, Adam_Icklock},
{ 0x293, Sol_Stiss},
{ 0x294, Des_Ainer},
{ 0x295, Homer_Sockshell},
{ 0x296, Harley_Trotter},
{ 0x297, Mark_Skidfree},
{ 0x298, Del_Iverryboy},
{ 0x299, Scean_Spector},
{ 0x29A, Nick_Knack},
{ 0x29B, Dusty_Rellicks},
{ 0x29C, Sandy_Insolls},
{ 0x29D, Gregory_Bones},
{ 0x29E, Loughrey_Mose},
{ 0x29F, Willow_Withers},
{ 0x2A0, Winn_deBreeze},
{ 0x2A1, Buster_Clout},
{ 0x2A2, Errol_Lorre},
{ 0x2A3, Fred_Ferrell},
{ 0x2A4, Rod_Headstock},
{ 0x2A5, Tim_Piece},
{ 0x2A6, Patrick_Edie},
{ 0x2A7, Art_Teest},
{ 0x2A8, Bill_Mumm},
{ 0x2A9, Luke_O_Cyte},
{ 0x2AA, Ernest_Byer},
{ 0x2AB, Isaac_Goss},
{ 0x2AC, Walter_Poseur},
{ 0x2AD, Andy_Roff},
{ 0x2AE, Ashley_Dale},
{ 0x2AF, Rich_Cave},
{ 0x2B0, Taka_Tanaka},
{ 0x2B1, Manny_Carbs},
{ 0x2B2, Al_Reddie},
{ 0x2B3, Rush_Tooset},
{ 0x2B4, Rod_Opsin},
{ 0x2B5, Peyton_Pope},
{ 0x2B6, Drew_Straws},
{ 0x2B7, Trey_Dalbum},
{ 0x2B8, Harly_Profett},
{ 0x2B9, Hank_O_Buff},
{ 0x2BA, Ash_Cloud},
{ 0x2BB, Stan_Dupp},
{ 0x2BC, Max_Bright},
{ 0x2BD, Bill_Phee},
{ 0x2BE, Lee_Figreene},
{ 0x2BF, Den_Taligene},
{ 0x2C0, Adam_Hesive},
{ 0x2C1, Mel_Lowe},
{ 0x2C2, Rip_Winkle},
{ 0x2C3, Ben_deLimms},
{ 0x2C4, Pauly_Ontology},
{ 0x2C5, Walter_Mendip},
{ 0x2C6, Bud_Hunter},
{ 0x2C7, Sonny_Rentman},
{ 0x2C8, Cam_Vass},
{ 0x2C9, Shay_Chez},
{ 0x2CA, Cory_Andish},
{ 0x2CB, Glen_Adeer},
{ 0x2CC, Norry_Sheets},
{ 0x2CD, Lou_Paster},
{ 0x2CE, Aran_Cheeks},
{ 0x2CF, Abe_Seiler},
{ 0x2D0, Al_Urgy},
{ 0x2D1, Conn_Pass},
{ 0x2D2, Heath_Cover},
{ 0x2D3, Mack_Ramey},
{ 0x2D4, Miles_Ryan},
{ 0x2D5, Ike_Banner},
{ 0x2D6, Frank_Meyer},
{ 0x2D7, Phil_Fog},
{ 0x2D8, Bob_Lioteck},
{ 0x2D9, Rory_Polisher},
{ 0x2DA, Tex_Curvator},
{ 0x2DB, Perry_Pincher},
{ 0x2DC, Al_Plates},
{ 0x2DD, Bane_Marie},
{ 0x2DE, Cam_Broadsheet},
{ 0x2DF, Mo_Hawkes},
{ 0x2E0, Chris_Pecracker},
{ 0x2E1, Andy_Crafter},
{ 0x2E2, Boe_Tyer},
{ 0x2E3, Dave_O_Resis},
{ 0x2E4, Victor_Mancey},
{ 0x2E5, Ray_Dioset},
{ 0x2E6, Preston_Gumbs},
{ 0x2E7, Tiny_Forester},
{ 0x2E8, Cardin_Hands},
{ 0x2E9, Callan_Trens},
{ 0x2EA, Tim_Mittus},
{ 0x2EB, Keenan_Brainard},
{ 0x2EC, Orson_Douvre},
{ 0x2ED, Sandy_Hope},
{ 0x2EE, Ort_Omaton},
{ 0x2EF, Clerk_Welcome},
{ 0x2F0, Rob_Ottman},
{ 0x2F1, Cam_O_Miles},
{ 0x2F2, Jack_Pott},
{ 0x2F3, Florian_Selles},
{ 0x2F4, Finn_Sawyer},
{ 0x2F5, Bobby_Constable},
{ 0x2F6, Ray_Menn},
{ 0x2F7, Odo_Toilette},
{ 0x2F8, Tel_Egram},
{ 0x2F9, Char_Shumaker},
{ 0x2FA, Sim_Pathy},
{ 0x2FB, Jon_Driedon},
{ 0x2FC, Monty_Burrows},
{ 0x2FD, Gaston_Berry},
{ 0x2FE, Cruz_Ligner},
{ 0x2FF, Irv_Washinton},
{ 0x300, Shem_Bassey},
{ 0x301, Pres_Cripton},
{ 0x302, Winston_Windfall},
{ 0x303, Rich_Eden},
{ 0x304, Teagen_Brewer},
{ 0x305, Ry_Sling},
{ 0x306, Bard_Crooner},
{ 0x307, Armstrong_Peck},
{ 0x308, Carey_Vanpark},
{ 0x309, Garland_Gathers},
{ 0x30A, David_Burnum},
{ 0x30B, Tad_Trinket},
{ 0x30C, Harvey_Lifter},
{ 0x30D, Kurt_Price},
{ 0x30E, Cameron_Hameha},
{ 0x30F, Will_Stonehead},
{ 0x310, Hugh_Marble},
{ 0x311, Urson_Brown},
{ 0x312, Bo_Luger},
{ 0x313, Kim_Ono},
{ 0x314, Bully_Thrower},
{ 0x315, Bill_Wordsworthy},
{ 0x316, Mo_Lusk},
{ 0x317, Ben_Curd},
{ 0x318, Powers_Squatts},
{ 0x319, Paisley_Onepiece},
{ 0x31A, Gauge_Diven},
{ 0x31B, Zane_Laughead},
{ 0x31C, Daz_Tighthead},
{ 0x31D, Sandy_Beecher},
{ 0x31E, Ty_Priter},
{ 0x31F, Nick_Savers},
{ 0x320, Percy_Wrench},
{ 0x321, Max_Scara},
{ 0x322, Jonny_Strutt},
{ 0x323, Larry_Oldman},
{ 0x324, Dom_Anding},
{ 0x325, Pip_Goodweather},
{ 0x326, Bamber_Mandrina},
{ 0x327, Scrap_Salvadge},
{ 0x328, Michael_Angeloni},
{ 0x329, Ryder_Wheeling},
{ 0x32A, Stu_Venier},
{ 0x32B, Linden_Dray},
{ 0x32C, Patsy_Cornish},
{ 0x32D, Sharkey_Gobble},
{ 0x32E, Olly_Popman},
{ 0x32F, Tyche_Winham},
{ 0x330, Page_Helper},
{ 0x331, Barry_Lugh},
{ 0x332, Jen_Quibble},
{ 0x333, Dan_Drobium},
{ 0x334, Lyle_O_Day},
{ 0x335, Crane_Clawson},
{ 0x336, Raven_Crowe},
{ 0x337, Shirley_Ladyman},
{ 0x338, Cody_Barani},
{ 0x339, Bob_Shishker},
{ 0x33A, Pica_Vellosum},
{ 0x33B, Sascha_Powder},
{ 0x33C, Gore_Lyath},
{ 0x33D, Marty_Gras},
{ 0x33E, Bob_Dingnagian},
{ 0x33F, Hugh_Dyer},
{ 0x340, Carl_Penter},
{ 0x341, Jebb_Ettow},
{ 0x342, Julian_Siezer},
{ 0x343, Bill_Dozer},
{ 0x344, Benny_Factor},
{ 0x345, Roman_Candler},
{ 0x346, Ray_Whitehead},
{ 0x347, Aston_Isher},
{ 0x348, Grover_Bearing},
{ 0x349, Andy_Sided},
{ 0x34A, Phil_O_Biblist},
{ 0x34B, Roy_Plimsole},
{ 0x34C, Jem_Paste},
{ 0x34D, Mike_Creasewell},
{ 0x34E, Hale_Quinn},
{ 0x34F, Al_Askan},
{ 0x350, Scot_Chopper},
{ 0x351, Nick_Templeton},
{ 0x352, Butler_Chambers},
{ 0x353, Pip_Skinner},
{ 0x354, Dan_Vega},
{ 0x355, Manny_Kinsland},
{ 0x356, Chick_Adiddy},
{ 0x357, Jig_Charleston},
{ 0x358, Powers_Flawless},
{ 0x359, Alistair_Horizon},
{ 0x35A, Tim_Bergoods},
{ 0x35B, Lux_Sidebottom},
{ 0x35C, Nat_Picker},
{ 0x35D, Harold_Derry},
{ 0x35E, Josh_Rogan},
{ 0x35F, Ronny_O_Mania},
{ 0x360, Buck_Teachey},
{ 0x361, Rayburn_Lightly},
{ 0x362, Pat_Greene},
{ 0x363, Sylver_Stone},
{ 0x364, Equin_Knocks},
{ 0x365, Hans_Bigger},
{ 0x366, Creed_Wrighter},
{ 0x367, Fran_Zimmer},
{ 0x368, Chaz_Anover},
{ 0x369, Kurt_O_Graphy},
{ 0x36A, Pace_Storey},
{ 0x36B, Paddy_Streehan},
{ 0x36C, Carson_Haynes},
{ 0x36D, Earl_Grayson},
{ 0x36E, Pip_Aminty},
{ 0x36F, Noel_Vacancies},
{ 0x370, Jon_Quill},
{ 0x371, Bill_Looney},
{ 0x372, Dan_Nettles},
{ 0x373, Clark_Watcher},
{ 0x374, Tim_Eisback},
{ 0x375, Sam_Aritan},
{ 0x376, Cal_Emarry},
{ 0x377, Bambis_Shakin},
{ 0x378, Zin_Giber},
{ 0x379, Wes_Abbey},
{ 0x37A, Alec_Dote},
{ 0x37B, Dougie_McFlea},
{ 0x37C, Jacky_Lantern},
{ 0x37D, Matt_Tudor},
{ 0x37E, Gabriel_Shekinah},
{ 0x37F, Biron_Pendexter},
{ 0x380, Rod_Entwhistle},
{ 0x381, Toby_Patient},
{ 0x382, Glen_Garry},
{ 0x383, Bill_Yards},
{ 0x384, Kay_Acker},
{ 0x385, Django_Keyes},
{ 0x386, John_Demi},
{ 0x387, Sage_Wisdom},
{ 0x388, Nick_Washing},
{ 0x389, Steve_Pinner},
{ 0x38A, Vance_Bookings},
{ 0x38B, Bud_Dahman},
{ 0x38C, Reagan_Boneman},
{ 0x38D, Erhard_Blower},
{ 0x38E, Jack_Tradesman},
{ 0x38F, Rufus_Judge},
{ 0x390, Ace_Fettick},
{ 0x391, Lance_Lotts},
{ 0x392, Attley_Hightable},
{ 0x393, Jim_Nastick},
{ 0x394, Theo_Riser},
{ 0x395, Weldon_Wrought},
{ 0x396, Seymour_Senary},
{ 0x397, Finn_Carper},
{ 0x398, Herc_Bigsby},
{ 0x399, Bramley_Cox},
{ 0x39A, Mitch_Hett},
{ 0x39B, Mo_Zarella},
{ 0x39C, Scout_Messenger},
{ 0x39D, Paul_Chucker},
{ 0x39E, Andy_Wallpole},
{ 0x39F, Solomon_Justice},
{ 0x3A0, Mark_Tinney},
{ 0x3A1, Archy_Medez},
{ 0x3A2, Jay_Pan},
{ 0x3A3, Jonah_Troutman},
{ 0x3A4, Carl_Nivor},
{ 0x3A5, Phil_Occifer},
{ 0x3A6, Noah_Gerkin},
{ 0x3A7, Colin_Eager},
{ 0x3A8, Don_Ringo},
{ 0x3A9, Nick_Crew},
{ 0x3AA, Ivor_Parrot},
{ 0x3AB, Matthew_Pencil},
{ 0x3AC, Ropert_Chapp},
{ 0x3AD, Hal_LeButt},
{ 0x3AE, Al_Chemmy},
{ 0x3AF, Rob_Zervatory},
{ 0x3B0, Joe_Stick},
{ 0x3B1, Nick_Turine},
{ 0x3B2, Marc_O_Lepsy},
{ 0x3B3, Jim_Makegood},
{ 0x3B4, Vin_Spinner},
{ 0x3B5, Grew_Driver},
{ 0x3B6, Ed_Dupee},
{ 0x3B7, Hank_Shortman},
{ 0x3B8, Aaron_Peacy},
{ 0x3B9, Harvey_Sweats},
{ 0x3BA, Harry_Overton},
{ 0x3BB, Archie_Tate},
{ 0x3BC, Neville_List},
{ 0x3BD, Lee_Dorr},
{ 0x3BE, Sam_Which},
{ 0x3BF, Dwight_Self},
{ 0x3C0, Shep_Shank},
{ 0x3C1, Dylan_Swan},
{ 0x3C2, Theo_Bernoulli},
{ 0x3C3, Sul_Tarner},
{ 0x3C4, Silas_Scrooge},
{ 0x3C5, Mario_Nette},
{ 0x3C6, Telly_Fonbocks},
{ 0x3C7, Bones_Size},
{ 0x3C8, Frank_Koshar},
{ 0x3C9, Keifer_Tiliser},
{ 0x3CA, Jak_Hammerslam},
{ 0x3CB, Rob_Freeby},
{ 0x3CC, Chris_Talise},
{ 0x3CD, Derek_Longhand},
{ 0x3CE, Manny_Gerry},
{ 0x3CF, Des_Count},
{ 0x3D0, Rocky_Rollans},
{ 0x3D1, Shaun_Staid},
{ 0x3D2, Heath_Freke},
{ 0x3D3, Olly_Gammy},
{ 0x3D4, Aidan_Model},
{ 0x3D5, Mick_Thatcher},
{ 0x3D6, Owen_Greenfield},
{ 0x3D7, Charlie_Krelborn},
{ 0x3D8, Rory_Circles},
{ 0x3D9, Barry_Sterr},
{ 0x3DA, John_Baird},
{ 0x3DB, Tyson_Moodey},
{ 0x3DC, Al_Istatin},
{ 0x3DD, Paddy_Popper},
{ 0x3DE, Dwayne_Woo},
{ 0x3DF, Pete_Sadow},
{ 0x3E0, Troy_Glodight},
{ 0x3E1, Chris_Hypogee},
{ 0x3E2, Connor_Bation},
{ 0x3E3, Rhys_Masher},
{ 0x3E4, Charlie_Shearing},
{ 0x3E5, Al_Mannack},
{ 0x3E6, Nathan_Weyton},
{ 0x3E7, Simon_Stryker},
{ 0x3E8, Will_Bayeux},
{ 0x3E9, Thomas_Ediston},
{ 0x3EA, Aubry_Dient},
{ 0x3EB, Les_Tarrant},
{ 0x3EC, Sim_Cope},
{ 0x3ED, Cal_O_Rees},
{ 0x3EE, Ringo_Spinning},
{ 0x3EF, Dec_O_Rator},
{ 0x3F0, Pat_Shinko},
{ 0x3F1, Ryan_Ferry},
{ 0x3F2, Les_Belisha},
{ 0x3F3, Tim_Crochett},
{ 0x3F4, Hiroshi_Dot},
{ 0x3F5, Jack_Nimble},
{ 0x3F6, Patch_Upright},
{ 0x3F7, Joe_Nalist},
{ 0x3F8, Esau_Fagus},
{ 0x3F9, Braden_Bakewell},
{ 0x3FA, Virgil_Lantis},
{ 0x3FB, Norm_Drilling},
{ 0x3FC, Kurt_Tweedy},
{ 0x3FD, Solomon_Osaka},
{ 0x3FE, Pike_Tucker},
{ 0x3FF, Gary_Osoto},
{ 0x400, Dec_Orum},
{ 0x401, Alan_Carte},
{ 0x402, Morgan_Iser},
{ 0x403, Ken_Broad},
{ 0x404, Scot_Enguard},
{ 0x405, Dick_Turbin},
{ 0x406, Benedict_Eggers},
{ 0x407, Beau_Painton},
{ 0x408, Butch_Pythons},
{ 0x409, Sam_Murray},
{ 0x40A, Eathan_Ringer},
{ 0x40B, Jack_Lumbar},
{ 0x40C, Todd_Tempole},
{ 0x40D, Jacob_Grimley},
{ 0x40E, John_Coralli},
{ 0x40F, Drew_Faxon},
{ 0x410, Cole_Easteroll},
{ 0x411, Cam_Lensman},
{ 0x412, Tighe_Windsor},
{ 0x413, Phil_Dippedes},
{ 0x414, Lenny_Lakeman},
{ 0x415, Vaughn_DeVille},
{ 0x416, Arthur_Myrddin},
{ 0x417, Guy_Forker},
{ 0x418, Bob_Stretcher},
{ 0x419, Spike_Clutcher},
{ 0x41A, Austin_Tayssus},
{ 0x41B, Tom_Stevenson},
{ 0x41C, Ricky_Charmers},
{ 0x41D, Max_Hurt},
{ 0x41E, Dexter_Raleigh},
{ 0x41F, Pete_Pang},
{ 0x420, Sam_Fitspire},
{ 0x421, Carter_Nightly},
{ 0x422, Daley_Switcher},
{ 0x423, Dexter_Ambie},
{ 0x424, Gill_Able},
{ 0x425, Drew_Reiner},
{ 0x426, Kevin_Boardman},
{ 0x427, Andy_Craft},
{ 0x428, Julius_Vernon},
{ 0x429, Robin_Sherwood},
{ 0x42A, Ei_King},
{ 0x42B, Travis_McClean},
{ 0x42C, Rusty_Spoakes},
{ 0x42D, Clint_Wester},
{ 0x42E, Pete_Nokeyo},
{ 0x42F, Will_Racer},
{ 0x430, Ollie_Seeker},
{ 0x431, Graham_Hush},
{ 0x432, Ronny_Knowles},
{ 0x433, Les_Abel},
{ 0x434, Reg_Thrift},
{ 0x435, Jools_Iceberg},
{ 0x436, Mark_Brent},
{ 0x437, Vern_Ironfist},
{ 0x438, Rob_Burnsides},
{ 0x439, Ace_Bragg},
{ 0x43A, Claude_Snap},
{ 0x43B, Paul_Rush},
{ 0x43C, Guile_Crocket},
{ 0x43D, Carey_Bean},
{ 0x43E, John_Maggie},
{ 0x43F, Chops_Denton},
{ 0x440, Bobby_Yellow},
{ 0x441, Ace_Breaker},
{ 0x442, Percy_Verence},
{ 0x443, Erik_Eagle},
{ 0x444, Bobby_Shearer},
{ 0x445, Paul_Peabody},
{ 0x446, Chester_Horse_Jr},
{ 0x447, Chester_Horse_Jr_2},
{ 0x448, Sagaminator},
{ 0x449, Jude_Sharp},
{ 0x44A, Shadow_Cimmerian},
{ 0x44D, Arnold_Horrel},
{ 0x44E, Donovan_Lardy},
{ 0x44F, Sonny_Raimon},
{ 0x450, Ray_Dark},
{ 0x451, George_Firewill},
{ 0x452, Gregory_Smith},
{ 0x453, David_Evans},
{ 0x454, Tom_Dark},
{ 0x455, Gregory_Smith_2},
{ 0x456, Celia_Hills_2},
{ 0x457, Julia_Blaze},
{ 0x458, Harry_Evans},
{ 0x459, Sharon_Evans},
{ 0x45A, Unknown},
{ 0x45B, Shearer_shadow},
{ 0x45C, Wintersea_shadow},
{ 0x45D, Zak_Wallside},
{ 0x45E, Mr_Veteran},
{ 0x45F, Dark_shadow},
{ 0x461, Stephen_Black},
{ 0x462, Hekyll_Jyde},
{ 0x463, Harry_Savage},
{ 0x464, Newton_Thomas},
{ 0x465, Manny_Artic},
{ 0x466, Sammy_Igajima},
{ 0x467, Turtle_Newfield},
{ 0x468, Seth_Nichols},
{ 0x469, Clint_Loggan},
{ 0x47F, Thug_1},
{ 0x480, Thug_2},
{ 0x481, Thug_3},
{ 0x482, Thug_4},
/*{ 0x483, Suit},
{ 0x484, Suit},
{ 0x485, Suit},
{ 0x486, Suit},
{ 0x487, Suit},
{ 0x488, Suit},
{ 0x489, Suit},
{ 0x48A, Suit},
{ 0x48B, Suit},
{ 0x48C, Suit},
{ 0x48D, Suit},
{ 0x48E, Suit},*/
{ 0x515, Aquilina_Schiller},
{ 0x516, Astram_B__Schiller},
{ 0x517, Godric_Wyles},
{ 0x518, Stewart_Vanguard},
{ 0x519, US_President},
{ 0x51A, Shawn_Froste_Kid},
{ 0x51B, Aiden_Froste_Kid},
{ 0x51C, Xavier_Foster},
{ 0x51D, Lina_shadow},
{ 0x51E, Axel_robe},
{ 0x51F, Character_robe},
{ 0x520, Alpine_coach},
{ 0x521, Cloister_coach},
{ 0x522, Fauxshore_coach},
{ 0x523, Mary_Times_Coach},
{ 0x524, Fauxshore_Head},
/*{ 0x525, Swimmer_(M)},
{ 0x526, Swimmer_(M)},
{ 0x527, Swimmer_(M)},
{ 0x528, Swimmer_(F)},
{ 0x529, Swimmer_(F)},
{ 0x52A, Swimmer_(F)},
{ 0x52B, Aloha_(M)},
{ 0x52C, Aloha_(M)},
{ 0x52D, Aloha_(M)},
{ 0x52E, Kimono_(F)},
{ 0x52F, Kimono_(F)},
{ 0x530, Kimono_(F)},
{ 0x531, Arctic_Suit_(M)},
{ 0x532, Arctic_Suit_(M)},
{ 0x533, Arctic_Suit_(M)},
{ 0x534, Alius_Staff},
{ 0x535, Alius_Staff},
{ 0x536, Alius_Staff},*/
/*{ 0x539, Umbrella_pupil_(M)},
{ 0x53A, Umbrella_pupil_(M)},
{ 0x53B, Umbrella_pupil_(M)},
{ 0x53C, Umbrella_pupil_(M)},
{ 0x53D, Umbrella_pupil_(F)},
{ 0x53E, Umbrella_pupil_(F)},
{ 0x53F, Umbrella_pupil_(F)},
{ 0x540, Umbrella_pupil_(F)},
{ 0x541, Alpine_pupil_(M)},
{ 0x542, Alpine_pupil_(M)},
{ 0x543, Alpine_pupil_(M)},
{ 0x544, Alpine_pupil_(M)},
{ 0x545, Alpine_pupil_(F)},
{ 0x546, Alpine_pupil_(F)},
{ 0x547, Alpine_pupil_(F)},
{ 0x548, Alpine_pupil_(F)},
{ 0x549, Cloister_pupil_(M)},
{ 0x54A, Cloister_pupil_(M)},
{ 0x54B, Cloister_pupil_(M)},
{ 0x54C, Cloister_pupil_(M)},
{ 0x54D, Cloister_pupil_(F)},
{ 0x54E, Cloister_pupil_(F)},
{ 0x54F, Cloister_pupil_(F)},
{ 0x550, Cloister_pupil_(F)},
{ 0x551, Fauxshore_pupil_(M)},
{ 0x552, Fauxshore_pupil_(M)},
{ 0x553, Fauxshore_pupil_(M)},
{ 0x554, Fauxshore_pupil_(M)},
{ 0x555, Fauxshore_pupil_(F)},
{ 0x556, Fauxshore_pupil_(F)},
{ 0x557, Fauxshore_pupil_(F)},
{ 0x558, Fauxshore_pupil_(F)},
{ 0x559, Mary_Times_pupil_(M)},
{ 0x55A, Mary_Times_pupil_(M)},
{ 0x55B, Mary_Times_pupil_(M)},
{ 0x55C, Mary_Times_pupil_(M)},
{ 0x55D, Mary_Times_pupil_(F)},
{ 0x55E, Mary_Times_pupil_(F)},
{ 0x55F, Mary_Times_pupil_(F)},
{ 0x560, Mary_Times_pupil_(F)},
{ 0x561, Redux_pupil_(M)},
{ 0x562, Redux_pupil_(M)},
{ 0x563, Redux_pupil_(M)},
{ 0x564, Redux_pupil_(M)},
{ 0x565, Redux_pupil_(F)},
{ 0x566, Redux_pupil_(F)},
{ 0x567, Redux_pupil_(F)},
{ 0x568, Redux_pupil_(F)},*/
{ 0x569, Sue_s_mother},
{ 0x56A, Froste_s_father},
{ 0x56B, Froste_s_mother},
{ 0x56C, Julia_wheelchair},
{ 0x56D, RG_Field_Stop},
{ 0x56E, RG_Goal_Stop},
{ 0x56F, Reception_Robot},
{ 0x5DD, Raimon_boy_1},
{ 0x5DE, Raimon_boy_2},
{ 0x5DF, Raimon_boy_3},
{ 0x5E0, Raimon_boy_4},
{ 0x5E1, Raimon_boy_5},
{ 0x5E2, Raimon_boy_6},
{ 0x5E3, Raimon_boy_7},
{ 0x5E4, Raimon_boy_8},
{ 0x5E5, Raimon_boy_9},
{ 0x5E6, Raimon_boy_10},
{ 0x5E7, Raimon_boy_11},
{ 0x5E8, Raimon_boy_12},
{ 0x5E9, Raimon_boy_13},
{ 0x5EA, Raimon_boy_14},
{ 0x5EB, Raimon_boy_15},
{ 0x5EC, Raimon_boy_16},
{ 0x5ED, Raimon_boy_17},
{ 0x5EE, Raimon_boy_18},
{ 0x5EF, Raimon_boy_19},
{ 0x5F0, Raimon_boy_20},
{ 0x5F1, Raimon_boy_21},
{ 0x5F2, Raimon_boy_22},
{ 0x5F3, Raimon_boy_23},
{ 0x5F4, Raimon_boy_24},
{ 0x5F5, Raimon_boy_25},
{ 0x5F6, Raimon_boy_26},
{ 0x5F7, Raimon_boy_27},
{ 0x5F8, Raimon_boy_28},
{ 0x5F9, Raimon_boy_29},
{ 0x5FA, Raimon_boy_30},
{ 0x5FB, Raimon_boy_31},
{ 0x5FC, Raimon_boy_32},
{ 0x5FD, Raimon_boy_33},
{ 0x5FE, Raimon_boy_34},
{ 0x5FF, Raimon_boy_35},
{ 0x600, Raimon_boy_36},
{ 0x601, Raimon_boy_37},
{ 0x602, Raimon_boy_38},
{ 0x603, Raimon_boy_39},
{ 0x604, Raimon_boy_40},
{ 0x605, Raimon_boy_41},
{ 0x606, Raimon_boy_42},
{ 0x607, Raimon_boy_43},
{ 0x608, Raimon_boy_44},
{ 0x609, Raimon_boy_45},
{ 0x60A, Raimon_boy_46},
{ 0x60B, Raimon_boy_47},
{ 0x60C, Raimon_boy_48},
{ 0x60D, Raimon_boy_49},
{ 0x60E, Raimon_boy_50},
{ 0x60F, Raimon_boy_51},
{ 0x610, Raimon_boy_52},
{ 0x611, Raimon_boy_53},
{ 0x612, Raimon_boy_54},
{ 0x613, Connor_Newlin},
{ 0x614, Raimon_boy_56},
{ 0x615, Raimon_boy_57},
{ 0x616, Raimon_boy_58},
{ 0x617, Raimon_boy_59},
{ 0x618, Raimon_boy_60},
{ 0x619, Raimon_girl_1},
{ 0x61A, Raimon_girl_2},
{ 0x61B, Raimon_girl_3},
{ 0x61C, Raimon_girl_4},
{ 0x61D, Raimon_girl_5},
{ 0x61E, Raimon_girl_6},
{ 0x61F, Raimon_girl_7},
{ 0x620, Raimon_girl_8},
{ 0x621, Raimon_girl_9},
{ 0x622, Raimon_girl_10},
{ 0x623, Raimon_girl_11},
{ 0x624, Raimon_girl_12},
{ 0x625, Raimon_girl_13},
{ 0x626, Raimon_girl_14},
{ 0x627, Raimon_girl_15},
{ 0x628, Raimon_girl_16},
{ 0x629, Raimon_girl_17},
{ 0x62A, Raimon_girl_18},
{ 0x62B, Raimon_girl_19},
{ 0x62C, Raimon_girl_20},
{ 0x62D, Raimon_girl_21},
{ 0x62E, Raimon_girl_22},
{ 0x62F, Raimon_girl_23},
{ 0x630, Raimon_girl_24},
{ 0x631, Raimon_girl_25},
{ 0x632, Raimon_girl_26},
{ 0x633, Raimon_girl_27},
{ 0x634, Raimon_girl_28},
{ 0x635, Raimon_girl_29},
{ 0x636, Raimon_girl_30},
{ 0x641, Teacher_1},
{ 0x642, Teacher_2},
{ 0x643, Teacher_3},
{ 0x644, Teacher_4},
{ 0x645, Teacher_5},
{ 0x646, Teacher_6},
{ 0x647, Teacher_7},
{ 0x648, Teacher_8},
{ 0x649, Teacher_9},
{ 0x655, Lady_teacher_1},
{ 0x656, Lady_teacher_2},
{ 0x657, Lady_teacher_3},
{ 0x658, Lady_teacher_4},
{ 0x659, Lady_teacher_5},
{ 0x65A, Lady_teacher_6},
{ 0x65B, Lady_teacher_7},
{ 0x65C, Lady_teacher_8},
{ 0x65D, Lady_teacher_9},
{ 0x669, Cat},
{ 0x66A, Chicken},
{ 0x66B, Dog},
{ 0x66C, Rabbit},
{ 0x673, Regular_guy_1},
{ 0x674, Regular_guy_2},
{ 0x675, Regular_guy_3},
{ 0x676, Regular_guy_4},
{ 0x677, Regular_guy_5},
{ 0x678, Regular_guy_6},
{ 0x679, Regular_guy_7},
{ 0x67A, Regular_guy_8},
{ 0x67B, Regular_guy_9},
{ 0x67C, Regular_guy_10},
{ 0x67D, Regular_guy_11},
{ 0x67E, Regular_guy_12},
{ 0x687, Regular_girl_1},
{ 0x688, Regular_girl_2},
{ 0x689, Regular_girl_3},
{ 0x68A, Regular_girl_4},
{ 0x68B, Regular_girl_5},
{ 0x68C, Regular_girl_6},
{ 0x68D, Regular_girl_7},
{ 0x68E, Regular_girl_8},
{ 0x68F, Regular_girl_9},
{ 0x690, Regular_girl_10},
{ 0x691, Regular_girl_11},
{ 0x692, Regular_girl_12},
{ 0x693, Ken_s_mum},
{ 0x69B, Old_man_1},
{ 0x69C, Old_man_2},
{ 0x69D, Old_man_3},
{ 0x69E, Old_man_4},
{ 0x69F, Old_man_5},
{ 0x6A0, Old_man_6},
{ 0x6A1, Old_man},
{ 0x6A5, Old_woman_1},
{ 0x6A6, Old_woman_2},
{ 0x6A7, Old_woman_3},
{ 0x6A8, Old_woman_4},
{ 0x6A9, Old_woman_5},
{ 0x6AA, Old_woman_6},
{ 0x6AF, Boy_1},
{ 0x6B0, Boy_2},
{ 0x6B1, Boy_3},
{ 0x6B2, Boy_4},
{ 0x6B3, Boy_5},
{ 0x6B4, Boy_6},
{ 0x6B5, Ken},
{ 0x6B6, Oswald},
{ 0x6B9, Girl_1},
{ 0x6BA, Girl_2},
{ 0x6BB, Girl_3},
{ 0x6BC, Girl_4},
{ 0x6BD, Girl_5},
{ 0x6BE, Girl_6},
{ 0x6C3, Staff_1},
{ 0x6C4, Staff_2},
{ 0x6C5, Staff_3},
{ 0x6C6, Staff_4},
{ 0x6C7, Shopkeeper},
{ 0x6C8, Maid_1},
{ 0x6C9, Maid_2},
{ 0x6CA, Maid_3},
{ 0x6CD, Doctor_1},
{ 0x6CE, Doctor_2},
{ 0x6D2, Nurse_1},
{ 0x6D3, Nurse_2},
{ 0x6D4, Nurse_3},
{ 0x6D7, Railway_worker_1},
{ 0x6D8, Railman_Unused},
{ 0x6D9, Police_officer_1},
{ 0x6DA, Police_officer},
{ 0x6DB, Flash_staff},
{ 0x6DC, Nelly_s_aide},
{ 0x6DD, Zeus_clerk_1},
{ 0x6DE, Zeus_suit},
{ 0x6E1, Academy_guy_1},
{ 0x6E2, Academy_guy_2},
{ 0x6E3, Academy_guy_3},
{ 0x6E6, Wild_guy_1},
{ 0x6E7, Wild_guy_2},
{ 0x6E8, Wild_guy_3},
{ 0x7D1, Mountford},
{ 0x7D2, Oldfield},
{ 0x7D3, Map_point_1},
{ 0x7D4, Map_point_2},
{ 0x821, Grent_Chaos},
{ 0x822, Baller_Chaos},
{ 0x823, Clear_Chaos},
{ 0x824, Gocker_Chaos},
{ 0x825, Bomber_Chaos},
{ 0x826, Heat_Chaos},
{ 0x827, Droll_Chaos},
{ 0x828, Rhine_Chaos},
{ 0x829, Bryce_Whitingale_Chaos},
{ 0x82A, Claude_Beacons_Chaos},
{ 0x82B, Neppten_Chaos},
{ 0x835, Galileo},
{ 0x836, Coral},
{ 0x837, Gigs},
{ 0x838, Ganymede},
{ 0x839, Charon},
{ 0x83A, Pandora},
{ 0x83B, Grengo},
{ 0x83C, Io},
{ 0x83D, Rihm},
{ 0x83E, Janus},
{ 0x83F, Diam},
{ 0x849, Dvalin},
{ 0x84A, Kenville},
{ 0x84B, Mole},
{ 0x84C, Kayson},
{ 0x84D, Tytan},
{ 0x84E, Fedora},
{ 0x84F, Krypto},
{ 0x850, Sworm},
{ 0x851, Mercury},
{ 0x852, Metron},
{ 0x853, Zell},
{ 0x854, Dvalin_FW},
{ 0x85D, Nero},
{ 0x85E, Gele},
{ 0x85F, Kiburn},
{ 0x860, Zohen},
{ 0x861, Hauser},
{ 0x862, Kormer},
{ 0x863, Kiwill},
{ 0x864, Ark},
{ 0x865, Wittz},
{ 0x866, Bellatrix},
{ 0x867, Xene},
{ 0x871, Dvalin2},
{ 0x872, Kenville2},
{ 0x873, Mole2},
{ 0x874, Kayson2},
{ 0x875, Tytan2},
{ 0x876, Fedora2},
{ 0x877, Krypto2},
{ 0x878, Sworm2},
{ 0x879, Mercury2},
{ 0x87A, Metron2},
{ 0x87B, Zell2},
{ 0x885, Cam_Mando},
{ 0x886, Harry_Boufante},
{ 0x887, Todd_Stuhl},
{ 0x888, Aspen_Blewit},
{ 0x889, Marismus_Oregon},
{ 0x88A, Garjan_Cypress},
{ 0x88B, Judas_Deathcap},
{ 0x88C, Chase_Faithfull},
{ 0x88D, Chris_Ticker},
{ 0x88E, Roy_Daring},
{ 0x88F, Scaber_Enoki},
{ 0x899, Robot_S},
{ 0x89A, Robot_P},
{ 0x89B, Robot_T},
{ 0x89C, Robot_V},
{ 0x89D, Robot_C},
{ 0x89E, Robot_O},
{ 0x89F, Robot_B},
{ 0x8A0, Robot_G},
{ 0x8A1, Robot_K},
{ 0x8A2, Robot_F},
{ 0x8A3, Robot_L},
{ 0x8AD, Seymour_Hillman_young},
{ 0x8AE, Charles_Island_young},
{ 0x8AF, Garret_Hairtown_young},
{ 0x8B0, Arthur_Sweet_young},
{ 0x8B1, Peter_Mildred_young},
{ 0x8B2, Josh_Nathaniel_young},
{ 0x8B3, Edward_Gladstone_young},
{ 0x8B4, Tyler_Thomas_young},
{ 0x8B5, Joseph_Yosemite_young},
{ 0x8B6, Ian_Suffolk_young},
{ 0x8B7, Constant_Builder_young},
{ 0x8C1, Grent},
{ 0x8C2, Baller},
{ 0x8C3, Balcke},
{ 0x8C4, Seats},
{ 0x8C5, Bomber},
{ 0x8C6, Heat},
{ 0x8C7, Lean},
{ 0x8C8, Bountine},
{ 0x8C9, Sidern},
{ 0x8CA, Claude_Beacons},
{ 0x8CB, Neppten},
{ 0x8D5, Beluga},
{ 0x8D6, Arkew},
{ 0x8D7, Clear},
{ 0x8D8, Gocker},
{ 0x8D9, Icer},
{ 0x8DA, Balen},
{ 0x8DB, Droll},
{ 0x8DC, Rhine},
{ 0x8DD, Blown},
{ 0x8DE, Bryce_Whitingale},
{ 0x8DF, Frost},
{ 0x8FD, Ken_Ironwall},
{ 0x8FE, Timothy_Western},
{ 0x8FF, Wallace_Hammond},
{ 0x900, Shirley_Stevens},
{ 0x901, Ian_Smith},
{ 0x902, Taylor_Firepool},
{ 0x903, Marge_Fielding},
{ 0x904, Marshall_Firsthand},
{ 0x905, Holly_Mirror},
{ 0x906, Victoria_Vanguard},
{ 0x907, Joe_Kenneddy},
{ 0x908, Ian_Sights},
{ 0x909, Greene_Beray},
{ 0x90A, Ryan_Tappin},
{ 0x90B, Linda_Shadey},
{ 0x90C, Sid_Safehouse},
{ 0x911, Adam_Ropes},
{ 0x912, Joaquine_Downtown},
{ 0x913, Milton_Bindings},
{ 0x914, Spike_Gleeson},
{ 0x915, Sean_Snowfield},
{ 0x916, Kerry_Bootgaiter},
{ 0x917, Maddox_Rock},
{ 0x918, Robert_Skipolson},
{ 0x919, Shawn_Froste},
{ 0x91A, Roland_Climbstein},
{ 0x91B, Quentin_Rackner},
{ 0x91C, Trent_Peggs},
{ 0x91D, Martin_Ursus},
{ 0x91E, Pete_Bogg},
{ 0x91F, Gem_Strata},
{ 0x920, Horace_Onlign},
{ 0x921, Shawn_Froste_Aiden},
{ 0x922, Shawn_Froste_Fusion},
{ 0x925, Crane_Kik},
{ 0x926, Parry_Waxon},
{ 0x927, Bri_Spark},
{ 0x928, Max_Fortune},
{ 0x929, Brendan_Water},
{ 0x92A, Junior_Fardream},
{ 0x92B, Ian_Telektual},
{ 0x92C, Lee_Dinglite},
{ 0x92D, Marshall_Artz},
{ 0x92E, Tyke_Wando},
{ 0x92F, Dirk_Artz},
{ 0x930, Scott_Banyan},
{ 0x931, Earnest_Bookworm},
{ 0x932, Ollie_Gami},
{ 0x933, Roman_Kandel},
{ 0x934, Don_Ation},
{ 0x935, Scott_Banyan_FW},
{ 0x939, Joseph_King_Redux},
{ 0x93A, Rowan_Beltzer},
{ 0x93B, Blade_Healen},
{ 0x93C, Argie_Bargie},
{ 0x93D, Lee_Bamboo},
{ 0x93E, Eton_Messer},
{ 0x93F, Jonah_Spark},
{ 0x940, Sue_Sparrow},
{ 0x941, Riley_Jamm},
{ 0x942, Caleb_Stonewall},
{ 0x943, David_Samford_Redux},
{ 0x944, Jimbo_Cellar},
{ 0x945, Zenn_Wildhorse},
{ 0x946, Dawson_Little},
{ 0x947, Cosimo_Beck},
{ 0x948, Maston_Color},
{ 0x94D, Darren_LaChance},
{ 0x94E, Drancis_Fake},
{ 0x94F, Mick_Mishap},
{ 0x950, Louis_Leave},
{ 0x951, Maurice_Badgame},
{ 0x952, Cannon_Random},
{ 0x953, Ulric_Richmen},
{ 0x954, Dave_Fate},
{ 0x955, Spencer_Duskplay},
{ 0x956, Jonathan_Luckyman},
{ 0x957, Joe_Poker},
{ 0x958, Wiley_Cracker},
{ 0x959, Mark_Failing},
{ 0x95A, Alton_Cotts},
{ 0x95B, Mike_Passing},
{ 0x95C, Knowle_Bathers},
{ 0x961, Rocky_Black},
{ 0x962, Chad_Taylor},
{ 0x963, Victor_Hills},
{ 0x964, Hurley_Kane},
{ 0x965, Hector_Redding},
{ 0x966, Mackenzie_Fordline},
{ 0x967, Cadence_Soundtown},
{ 0x968, Dora_Delight},
{ 0x969, Tom_Contented},
{ 0x96A, Joston_Easton},
{ 0x96B, Spring_Millpond},
{ 0x96C, Gaston_Cooley},
{ 0x96D, Bevan_Breakfast},
{ 0x96E, Jack_Griddle},
{ 0x96F, Stan_Andagi},
{ 0x970, Coral_Talent},
{ 0x975, Thomas_Feldt_DE},
{ 0x976, Malcolm_Night_DE},
{ 0x977, Shadow_Cimmerian_DE},
{ 0x978, Jim_Wraith_DE},
{ 0x979, Tod_Ironside_DE},
{ 0x97A, Steve_Grim_DE},
{ 0x97B, Tim_Saunders_DE},
{ 0x97C, Sam_Kincaid_DE},
{ 0x97D, Maxwell_Carson_DE},
{ 0x97E, Nathan_Swift_DE},
{ 0x97F, Kevin_Dragonfly_DE},
{ 0x989, Daisy_Fields},
{ 0x98A, Alexia_Sand},
{ 0x98B, Hellen_Hearth},
{ 0x98C, Rose_Pinkpetal},
{ 0x98D, Esther_Greenland},
{ 0x98E, Bela_Bluebells},
{ 0x98F, Natalie_Sunrise},
{ 0x990, Hillary_Bush},
{ 0x991, Mary_Moor},
{ 0x992, Suzette_Hartland},
{ 0x993, Lily_Willow},
{ 0x994, Dell_Closeout},
{ 0x995, Amy_Spires},
{ 0x996, Peony_Cash},
{ 0x997, Gayle_Revel},
{ 0x998, Janine_Brook},
{ 0x99D, Colin_Binder},
{ 0x99E, Larry_Pogue},
{ 0x99F, Rob_Cardson},
{ 0x9A0, Ken_Mayfield},
{ 0x9A1, Casey_Leather},
{ 0x9A2, Ethan_Swallow},
{ 0x9A3, Bob_Daruma},
{ 0x9A4, Mitch_Blackston},
{ 0x9A5, Aurelia_Dingle},
{ 0x9A6, Canon_Evans},
{ 0x9A7, Syon_Blaze},
{ 0x9A8, Thor_Stoutberg},
{ 0x9A9, Nelly_Raimon},
{ 0x9AA, Celia_Hills},
{ 0x9AB, Silvia_Woods},
{ 0x9AC, Hidetoshi_Nakata},
/*{ 0x9B1, ???},
{ 0x9B2, ???},
{ 0x9B3, ???},
{ 0x9B4, ???},
{ 0x9B5, ???},
{ 0x9B6, ???},
{ 0x9B7, ???},
{ 0x9B8, ???},
{ 0x9B9, ???},
{ 0x9BA, ???},
{ 0x9BB, ???},*/
{ 0x9C5, Curtis_Croon},
{ 0x9C6, Georgio_Plumber},
{ 0x9C7, Vince_Firewall},
{ 0x9C8, Roy_Diggins},
{ 0x9C9, Quill_Inker},
{ 0x9CA, Bertram_Manning},
{ 0x9CB, Laura_Quilter},
{ 0x9CC, Des_Igner},
{ 0x9CD, Jarmon_Fisk},
{ 0x9CE, Hugh_Tinter},
{ 0x9CF, Tim_Pression},
{ 0x9D0, Claire_Taker},
{ 0x9D1, Heath_Planner},
{ 0x9D2, Pace_Keeping},
{ 0x9D3, Arthur_Easley},
{ 0x9D4, Carl_Rhodes},
{ 0x9D5, Eugene_Conwell},
{ 0x9D6, Arnan_Wheelie},
{ 0x9D7, Stu_Boilin},
{ 0x9D8, Marvin_Reading},
{ 0x9D9, Callie_Graffy},
{ 0x9DA, Ant_Anomy},
{ 0x9DB, Laurie_Nowlin},
{ 0x9DC, Lucille_Strummon},
{ 0x9DD, Leon_Hotair},
{ 0x9DE, John_Bleach},
{ 0x9DF, Carey_Filling},
{ 0x9E0, Conn_Fuchus},
{ 0x9E1, Iain_Igma},
{ 0x9E2, Carrie_O_Kea},
{ 0x9E3, Ebirina},
{ 0x9E4, Stuart_Leafe},
{ 0x9E5, Cole_Stoaker},
{ 0x9E6, Justin_Primm},
{ 0x9E7, Mark_Smudge},
{ 0x9E8, Travis_Borer},
{ 0x9E9, Anton_Donce},
{ 0x9EA, Chase_Spoor},
{ 0x9EB, George_Barros},
{ 0x9EC, Olivia_Baker},
{ 0x9ED, Gem_Shorn},
{ 0x9EE, Lou_Daguerre},
{ 0x9EF, Ollie_Tuckney},
{ 0x9F0, Manuel_Kinart},
{ 0x9F1, Skip_Vinall},
{ 0x9F2, Junior_Gambit},
{ 0x9F3, Florian_Fauna},
{ 0x9F4, Clark_Tappen},
{ 0x9F5, Ryan_O_Laugh},
{ 0x9F6, Rod_Sweeper},
{ 0x9F7, Reg_Strimmer},
{ 0x9F8, Will_Ramin},
{ 0x9F9, Andy_Fudge},
{ 0x9FA, Tate_Immy},
{ 0x9FB, Gerald_Pourer},
{ 0x9FC, Nate_Checker},
{ 0x9FD, Bomber_Pikes},
{ 0x9FE, Gary_Burdine},
{ 0x9FF, Chloe_Glazier},
{ 0xA00, Reed_Harpen},
{ 0xA01, Beat_Scatton},
{ 0xA02, Al_Itchen},
{ 0xA03, Rock_Poulon},
{ 0xA04, Beau_Hammock},
{ 0xA05, Clef_Bassett},
{ 0xA06, Ovie_Whisker},
{ 0xA07, Bill_Clanger},
{ 0xA08, Mary_Cramer},
{ 0xA09, Ralph_Vance},
{ 0xA0A, Ray_Bowing},
{ 0xA0B, Vick_Pointer},
{ 0xA0C, Skip_Docker},
{ 0xA0D, Becky_Shuffle},
{ 0xA0E, Esther_Egerer},
{ 0xA0F, Mia_Pitchford},
{ 0xA10, Philippa_Konik},
{ 0xA11, Amy_Stinger},
{ 0xA12, Nancy_Polearm},
{ 0xA13, Sally_Tare},
{ 0xA14, Anna_Bugeisha},
{ 0xA15, Stu_Hoofer},
{ 0xA16, Coe_Dachy},
{ 0xA17, Flip_Sliden},
{ 0xA18, Jesse_Spiller},
{ 0xA19, Kate_Later},
{ 0xA1A, Clara_Tompkins},
{ 0xA1B, Betty_Backer},
{ 0xA1C, Thomas_Worth},
{ 0xA1D, Brenda_Brandish},
{ 0xA1E, Isla_Pullens},
{ 0xA1F, Bob_Jammen},
{ 0xA20, Hank_Cranker},
{ 0xA21, Prunella_Keep},
{ 0xA22, Jimmy_Brim},
{ 0xA23, Verity_Soliz},
{ 0xA24, Yve_Dunbar},
{ 0xA25, Cat_Selima},
{ 0xA26, Aurie_Garmer},
{ 0xA27, Lana_Service},
{ 0xA28, Claire_Voyant},
{ 0xA29, Algy_Kelp},
{ 0xA2A, Ann_Taisie},
{ 0xA2B, Kelly_Scrivens},
{ 0xA2C, Fern_Mycota},
{ 0xA2D, Lara_Creamer},
{ 0xA2E, Kim_Knotted},
{ 0xA2F, Nina_Trowel},
{ 0xA30, Harriet_Reaching},
{ 0xA31, Sadey_Stewer},
{ 0xA32, June_Stagner},
{ 0xA33, Lacey_Threader},
{ 0xA34, Marcy_Laise},
{ 0xA35, Bella_Shaded},
{ 0xA36, Walter_Trope},
{ 0xA37, Flora_Summars},
{ 0xA38, Lucia_Ander},
{ 0xA39, Rosy_Roker},
{ 0xA3A, Pam_Vision},
{ 0xA3B, Ruth_Karnes},
{ 0xA3C, Rose_Bedd},
{ 0xA3D, Bailey_Sitter},
{ 0xA3E, Adel_Tactor},
{ 0xA3F, Emma_Barres},
{ 0xA40, Orpah_Talkington},
{ 0xA41, Sable_Tatter},
{ 0xA42, Shu_Maimai},
{ 0xA43, Sym_Copate},
{ 0xA44, Jerry_Bateman},
{ 0xA45, Fonda_Katz},
{ 0xA46, Beck_Hand},
{ 0xA47, Sandra_Mudd},
{ 0xA48, Alexis_Watchorn},
{ 0xA49, Pete_Manter},
{ 0xA4A, Chris_Country},
{ 0xA4B, Paul_Steed},
{ 0xA4C, Ben_Whistler},
{ 0xA4D, Roman_Blac},
{ 0xA4E, Lewis_Brownie},
{ 0xA4F, Connor_Seuer},
{ 0xA50, Kaya_Haskell},
{ 0xA51, Minnie_Stratio},
{ 0xA52, Elegance_Stuckon},
{ 0xA53, Odette_Musetta},
{ 0xA54, Gertrude_Choker},
{ 0xA55, Polly_Targest},
{ 0xA56, Odessa_Ryder},
{ 0xA57, Robyn_Weaver},
{ 0xA58, Tess_Masters},
{ 0xA59, Cale_Sticklin},
{ 0xA5A, Farris_Stickman},
{ 0xA5B, Tim_Personator},
{ 0xA5C, Sherlock_Sagers},
{ 0xA5D, Ryan_Haywood},
{ 0xA5E, Osier_Twining},
{ 0xA5F, Rock_Scowlon},
{ 0xA60, Al_Stringer},
{ 0xA61, Bill_Fierce},
{ 0xA62, Rob_Otts},
{ 0xA63, Chad_Jowell},
{ 0xA64, Egon_Omercer},
{ 0xA65, Luis_Springs},
{ 0xA66, Bruce_Barkley},
{ 0xA67, Chip_Spacek},
{ 0xA68, Mason_Tirell},
{ 0xA69, Dale_Riverhead},
{ 0xA6A, Adelpha_Lovelace},
{ 0xA6B, Egon_Timing},
{ 0xA6C, Tony_Frogge},
{ 0xA6D, Fred_Punch},
{ 0xA6E, Hannibal_Whipp},
{ 0xA6F, Luke_Severin},
{ 0xA70, Harry_Keenan},
{ 0xA71, Nick_Uman},
{ 0xA72, Mac_Robat},
{ 0xA73, Ace_Slider},
{ 0xA74, Olivia_Twist},
{ 0xA75, Wiley_Blinks},
{ 0xA76, Shona_Shopbell},
{ 0xA77, Crystal_Clears},
{ 0xA78, Beata_Pummel},
{ 0xA79, Aya_Strand},
{ 0xA7A, Tara_Gaudier},
{ 0xA7B, James_Hearson},
{ 0xA7C, Anne_Somnia},
{ 0xA7D, Pearl_Wann},
{ 0xA7E, Hugh_Dunnit},
{ 0xA7F, Steve_Squander},
{ 0xA80, Lehman_Rind},
{ 0xA81, Ian_Fantile},
{ 0xA82, Zach_Putter},
{ 0xA83, Juan_Word},
{ 0xA84, Alex_Copple},
{ 0xA85, Jan_Jared},
{ 0xA86, Bigsby_Pigford},
{ 0xA87, Erica_Hogland},
{ 0xA88, Ramona_Wriston},
{ 0xA89, Mark_Izushy},
{ 0xA8A, Vince_Tinct},
{ 0xA8B, Daryl_Floor},
{ 0xA8C, Becca_Pilgreen},
{ 0xA8D, Langley_Span},
{ 0xA8E, Swithin_Sainte},
{ 0xA8F, Dan_Cawarry},
{ 0xA90, Hans_Freesing},
{ 0xA91, Peter_Fakhoury},
{ 0xA92, Steve_Sancey},
{ 0xA93, Michael_Gibe},
{ 0xA94, Skeet_Blaston},
{ 0xA95, Achilles_Chinner},
{ 0xA96, Scott_Tickle},
{ 0xA97, Junior_Cage},
{ 0xA98, Terry_Namby},
{ 0xA99, Joe_Chugger},
{ 0xA9A, Sonny_Cinders},
{ 0xA9B, Cash_Winfall},
{ 0xA9C, Lou_Fauntleroy},
{ 0xA9D, Carol_Chanter},
{ 0xA9E, Guy_Kogan},
{ 0xA9F, Max_Motto},
{ 0xAA0, Perry_Postiche},
{ 0xAA1, Nelson_Levene},
{ 0xAA2, Kurt_Sermons},
{ 0xAA3, Ed_Hartsell},
{ 0xAA4, Chester_Takes},
{ 0xAA5, Curtis_Rebell},
{ 0xAA6, Cody_Fink},
{ 0xAA7, Siria_Chattsley},
{ 0xAA8, Darren_Catt},
{ 0xAA9, Garry_Planer},
{ 0xAAA, Glenn_Broth},
{ 0xAAB, Harry_Angue},
{ 0xAAC, Benny_Terra},
{ 0xAAD, Jasmine_Veile},
{ 0xAAE, Belle_Allure},
{ 0xAAF, Doug_Lapp},
{ 0xAB0, Eric_Motter},
{ 0xAB1, Gyll_Netters},
{ 0xAB2, Farrah_Fairway},
{ 0xAB3, Jess_Winkles},
{ 0xAB4, Barbara_Clector},
{ 0xAB5, Marilyn_Henshaw},
{ 0xAB6, Nancy_Pickney},
{ 0xAB7, Clay_Turnor},
{ 0xAB8, Horace_Shlock},
{ 0xAB9, Sabrina_Passman},
{ 0xABA, Harpo_Thermier},
{ 0xABB, August_Dyers},
{ 0xABC, Nev_Puffer},
{ 0xABD, Elata_Mighty},
{ 0xABE, Ben_Danna},
{ 0xABF, Elsa_Roamer},
{ 0xAC0, Archy_Seago},
{ 0xAC1, Erhardt_Knead},
{ 0xAC2, Lynne_Mandel},
{ 0xAC3, Craig_Placid},
{ 0xAC4, Leon_Morcey},
{ 0xAC5, Dom_Edarry},
{ 0xAC6, Jay_Asher},
{ 0xAC7, Toby_Cohill},
{ 0xAC8, Nolene_Ider},
{ 0xAC9, Hoots_Knightly},
{ 0xACA, Bash_Beaton},
{ 0xACB, Terry_Toolan},
{ 0xACC, Callum_Biddy},
{ 0xACD, Alan_Sumner},
{ 0xACE, Trixy_Wonder},
{ 0xACF, Colet_First},
{ 0xAD0, Mac_Gabbon},
{ 0xAD1, Tip_Bolster},
{ 0xAD2, Draco_Scallon},
{ 0xAD3, Sofia_Brashier},
{ 0xAD4, Tam_Boyish},
{ 0xAD5, Mat_Halled},
{ 0xAD6, James_Strang},
{ 0xAD7, Ian_Watchen},
{ 0xAD8, Rose_Snelgrove},
{ 0xAD9, Bert_Emmerson},
{ 0xADA, Irving_Gusher},
{ 0xADB, Lionel_Silent},
{ 0xADC, Owen_Rage},
{ 0xADD, Alice_Nutty},
{ 0xADE, Conrad_Jacket},
{ 0xADF, Hilda_Bronski},
{ 0xAE0, Clint_Peacock},
{ 0xAE1, Pace_Maker},
{ 0xAE2, Vanity_Percy},
{ 0xAE3, Phil_Pagoda},
{ 0xAE4, Niki_Colbeck},
{ 0xAE5, Guy_Pinnay},
{ 0xAE6, Wayne_Fluke},
{ 0xAE7, Red_Dayers},
{ 0xAE8, Shay_Diebold},
{ 0xAE9, Tigh_Gerwhite},
{ 0xAEA, Cerise_Crane},
{ 0xAEB, Drack_Gorn},
{ 0xAEC, Terry_Pinn},
{ 0xAED, Justin_Cush},
{ 0xAEE, Bert_McClure},
{ 0xAEF, Richard_Trogg},
{ 0xAF0, Shirly_Quirk},
{ 0xAF1, Elias_Lens},
{ 0xAF2, Terry_Dryden},
{ 0xAF3, Ardel_Kernel},
{ 0xAF4, Carl_Belcher},
{ 0xAF5, Mal_Maroon},
{ 0xAF6, Ralph_Fary},
{ 0xAF7, Floyd_Spades},
{ 0xAF8, Remy_Diggun},
{ 0xAF9, Bern_Macmahon},
{ 0xAFA, Wally_Cooper},
{ 0xAFB, Griff_Hardcasel},
{ 0xAFC, Pat_Lubow},
{ 0xAFD, Wilma_Morgan},
{ 0xAFE, Carys_Chaparon},
{ 0xAFF, Claire_Hostess},
{ 0xB00, Katy_Punter},
{ 0xB01, Pete_Pimento},
{ 0xB02, Mary_Hugland},
{ 0xB03, Lee_Screener},
{ 0xB04, Camilla_Textor},
{ 0xB05, Bish_Beaton},
{ 0xB06, Simeon_Squareyes},
{ 0xB07, Stu_Borneman},
{ 0xB08, Herbie_Garnet},
{ 0xB09, Arvin_Inkwell},
{ 0xB0A, Rayce_Sprinton},
{ 0xB0B, Dreama_Bartle},
{ 0xB0C, Jane_Ledbelly},
{ 0xB0D, Dory_O_Bonn},
{ 0xB0E, Selma_Heaver},
{ 0xB0F, Kath_Leaflin},
{ 0xB10, Marg_Shuttle},
{ 0xB11, Duke_Scrubine},
{ 0xB12, Waylon_Tripp},
{ 0xB13, Jim_Bunner},
{ 0xB14, Jon_Izumo},
{ 0xB15, Del_Brighton},
{ 0xB16, Haden_Safe},
{ 0xB17, Lisle_Plotter},
{ 0xB18, Fen_Skates},
{ 0xB19, Rhoda_Dough},
{ 0xB1A, Neil_Seating},
{ 0xB1B, Flo_Nighting},
{ 0xB1C, Elinor_Maven},
{ 0xB1D, Kay_Gateley},
{ 0xB1E, Dexter_Caise},
{ 0xB1F, Serena_Besse},
{ 0xB20, Adrian_Heartly},
{ 0xB21, Cary_Fearless},
{ 0xB22, Wally_Waymire},
{ 0xB23, Ted_Autumn},
{ 0xB24, Boomer_Smolen},
{ 0xB25, Hank_Ershef},
{ 0xB26, Tim_Opener},
{ 0xB27, Hide_King},
{ 0xB28, Beth_Doodle},
{ 0xB29, Lamar_Bonesteel},
{ 0xB2A, Dom_Round},
{ 0xB2B, Chip_Stocks},
{ 0xB2C, Blake_Nailor},
{ 0xB2D, Dotty_Hickman},
{ 0xB2E, Wright_Tandem},
{ 0xB2F, Shaun_Bonnie},
{ 0xB30, Andrew_Hooper},
{ 0xB31, Toya_Boyde},
{ 0xB32, Taryn_Shyder},
{ 0xB33, Jasmin_Trier},
{ 0xB34, Dave_Lung},
{ 0xB35, Teal_Redsky},
{ 0xB36, Truman_Verdy},
{ 0xB37, Chance_Cerulean},
{ 0xB38, Amy_Peach},
{ 0xB39, Virgil_Amber},
{ 0xB3A, Grant_Stodgell},
{ 0xB3B, Payne_Outler},
{ 0xB3C, Malcolm_Shirker},
{ 0xB3D, Hanna_Slack},
{ 0xB3E, Dom_Poppy},
{ 0xB3F, Portia_Maricle},
{ 0xB40, Susan_Doiley},
{ 0xB41, Hannah_Breer},
{ 0xB42, Phil_Seebold},
{ 0xB43, Bobbie_Tomey},
{ 0xB44, Randolph_Lords},
{ 0xB45, Robin_Traylor},
{ 0xB46, Fawn_Blossom},
{ 0xB47, Isabell_Mish},
{ 0xB48, Rudy_Stemper},
{ 0xB49, Betty_Evenson},
{ 0xB4A, Harpo_Kendrick},
{ 0xB4B, Colin_Glower},
{ 0xB4C, Tailor_Wilden},
{ 0xB4D, Sim_Cebus},
{ 0xB4E, Sam_Banks},
{ 0xB4F, Frank_Homey},
{ 0xB50, Gregg_Deremer},
{ 0xB51, Verne_Spring},
{ 0xB52, Bryan_Klamm},
{ 0xB53, Colt_Youngstein},
{ 0xB54, Will_Kilmon},
{ 0xB55, Milly_Vacey},
{ 0xB56, Dany_Destiny},
{ 0xB57, Gary_Primo},
{ 0xB58, Bobby_Duo},
{ 0xB59, Stan_Treece},
{ 0xB5A, Lillie_Quattro},
{ 0xB5B, Eddy_Pentaris},
{ 0xB5C, Candice_Mell},
{ 0xB5D, Alex_Dauger},
{ 0xB5E, Joe_Divide},
{ 0xB5F, Sam_Willing},
{ 0xB60, Mary_Antoine},
{ 0xB61, Edward_Baron},
{ 0xB62, Tim_Platton},
{ 0xB63, Argento_Salvage},
{ 0xB64, Finn_Geld},
{ 0xB65, Ian_Moray},
{ 0xB66, Gil_Holden},
{ 0xB67, Doyle_Palmer},
{ 0xB68, Audry_Orange},
{ 0xB69, May_Apple},
{ 0xB6A, Ginny_White},
{ 0xB6B, Angus_Hogg},
{ 0xB6C, In_Chikita},
{ 0xB6D, Sabrina_Carow},
{ 0xB6E, Bob_Beelzy},
{ 0xB6F, Patt_Howell},
{ 0xB70, Ol_Factory},
{ 0xB71, Tom_Skipper},
{ 0xB72, Axel_Blaze_IE1},
            };
        }
        public class IE3
        {

            private static Player Mark_Evans = new Player(125, 135, 53, 53, 49, 80, 52, 69, 79, 435, 47, 94, 13, 16, 25, 25, 18, 26, 30, 94, 1, 5, 2, 5, 2, 5, 5, 5, 6); // 0x01
            private static Player Nathan_Swift = new Player(124, 122, 64, 58, 68, 57, 76, 58, 40, 421, 64, 59, 23, 22, 22, 21, 28, 22, 21, 59, 4, 4, 4, 4, 5, 2, 4, 4, 2); // 0x02
            private static Player Jack_Wallside = new Player(113, 116, 40, 53, 62, 66, 49, 65, 54, 389, 59, 48, 18, 21, 18, 26, 19, 21, 21, 48, 1, 2, 1, 1, 2, 5, 2, 4, 3); // 0x03
            private static Player Jim_Wraith = new Player(113, 127, 58, 53, 75, 63, 53, 62, 60, 424, 43, 33, 7, 14, 11, 11, 12, 13, 8, 33, 1, 1, 1, 1, 1, 1, 1, 5, 3); // 0x04
            private static Player Tod_Ironside = new Player(118, 114, 54, 55, 53, 56, 59, 56, 65, 398, 59, 43, 23, 18, 9, 22, 17, 24, 19, 43, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x05
            private static Player Steve_Grim = new Player(120, 120, 60, 60, 62, 60, 62, 64, 62, 430, 43, 51, 13, 9, 11, 11, 10, 7, 11, 51, 1, 5, 1, 1, 1, 1, 1, 1, 2); // 0x06
            private static Player Tim_Saunders = new Player(132, 115, 63, 76, 61, 60, 55, 48, 58, 421, 46, 55, 11, 8, 14, 9, 12, 10, 11, 55, 2, 2, 2, 2, 2, 2, 5, 2, 1); // 0x07
            private static Player Sam_Kincaid = new Player(125, 123, 65, 57, 56, 56, 58, 56, 76, 424, 50, 41, 9, 11, 6, 11, 10, 9, 14, 41, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0x08
            private static Player Maxwell_Carson = new Player(125, 127, 51, 56, 72, 64, 60, 56, 57, 416, 61, 73, 21, 22, 28, 22, 26, 19, 19, 73, 2, 4, 2, 2, 2, 1, 5, 1, 1); // 0x09
            private static Player Axel_Blaze = new Player(133, 123, 78, 66, 62, 58, 63, 60, 60, 447, 69, 82, 28, 26, 23, 24, 24, 22, 22, 82, 2, 2, 2, 1, 5, 1, 1, 1, 2); // 0x0A
            private static Player Kevin_Dragonfly = new Player(122, 124, 79, 60, 49, 53, 51, 64, 70, 426, 61, 88, 27, 25, 20, 22, 19, 24, 18, 88, 4, 2, 1, 4, 4, 5, 1, 2, 2); // 0x0B
            private static Player William_Glass = new Player(98, 144, 56, 51, 68, 57, 56, 53, 60, 401, 31, 21, 7, 8, 7, 11, 7, 5, 7, 21, 5, 5, 5, 5, 5, 5, 5, 5, 5); // 0x0C
            private static Player Joseph_King = new Player(129, 129, 55, 53, 69, 75, 55, 64, 60, 431, 60, 96, 15, 11, 13, 16, 13, 14, 14, 96, 3, 1, 2, 1, 3, 1, 5, 2, 1); // 0x15
            private static Player Peter_Drent = new Player(130, 108, 54, 64, 59, 71, 44, 63, 62, 417, 64, 89, 14, 17, 14, 18, 12, 14, 10, 89, 5, 2, 3, 5, 2, 1, 2, 1, 2); // 0x16
            private static Player Ben_Simmons = new Player(124, 120, 58, 63, 62, 60, 59, 55, 69, 426, 68, 76, 11, 12, 14, 16, 12, 14, 10, 76, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x17
            private static Player Alan_Master = new Player(120, 124, 60, 64, 58, 69, 59, 62, 66, 438, 65, 64, 12, 10, 13, 16, 15, 17, 11, 64, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x18
            private static Player Gus_Martin = new Player(118, 128, 62, 52, 70, 62, 63, 60, 52, 421, 62, 66, 13, 10, 12, 14, 12, 13, 12, 66, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x19
            private static Player Herman_Waldon = new Player(120, 121, 62, 60, 72, 59, 65, 57, 52, 427, 69, 72, 16, 10, 15, 12, 16, 16, 14, 72, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x1A
            private static Player John_Bloom = new Player(117, 124, 51, 71, 67, 52, 68, 54, 62, 425, 60, 74, 12, 13, 12, 11, 17, 11, 14, 74, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x1B
            private static Player Derek_Swing = new Player(122, 124, 45, 56, 76, 59, 69, 60, 61, 426, 69, 68, 12, 11, 13, 10, 14, 13, 11, 68, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x1C
            private static Player Daniel_Hatch = new Player(111, 121, 60, 55, 68, 68, 52, 61, 64, 428, 66, 76, 20, 11, 14, 15, 14, 17, 16, 76, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x1D
            private static Player Jude_Sharp_RA = new Player(123, 126, 63, 59, 79, 52, 68, 56, 68, 445, 70, 75, 28, 29, 25, 27, 23, 25, 23, 75, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x1E
            private static Player David_Samford_RA = new Player(124, 126, 70, 60, 61, 53, 58, 70, 67, 439, 72, 100, 26, 22, 27, 23, 27, 23, 26, 100, 3, 3, 5, 3, 1, 1, 2, 2, 3); // 0x1F
            private static Player Bob_Carlton = new Player(108, 130, 58, 55, 63, 62, 65, 62, 55, 420, 44, 54, 11, 12, 11, 14, 13, 11, 11, 54, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x20
            private static Player Cliff_Tomlinson = new Player(105, 125, 53, 60, 52, 61, 54, 52, 53, 385, 46, 54, 14, 12, 12, 13, 14, 13, 14, 54, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x21
            private static Player Jim_Lawrenson = new Player(112, 118, 54, 57, 70, 63, 53, 56, 55, 408, 55, 55, 12, 12, 14, 11, 11, 14, 12, 55, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0x22
            private static Player Barry_Potts = new Player(126, 121, 53, 52, 54, 56, 52, 60, 44, 371, 58, 49, 12, 12, 14, 11, 13, 11, 12, 49, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x23
            private static Player Steve_Ingham = new Player(125, 120, 61, 53, 57, 52, 47, 54, 46, 370, 50, 54, 14, 11, 12, 14, 11, 13, 13, 54, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x24
            private static Player Nathan_Jones = new Player(118, 116, 52, 56, 61, 73, 56, 54, 53, 405, 43, 76, 15, 11, 20, 17, 10, 17, 16, 76, 1, 5, 2, 2, 4, 1, 1, 1, 2); // 0x29
            private static Player Russell_Walk = new Player(107, 113, 56, 47, 68, 52, 64, 59, 46, 392, 42, 56, 14, 10, 14, 12, 17, 13, 12, 56, 1, 5, 1, 1, 1, 1, 1, 1, 1); // 0x2A
            private static Player Jason_Jones = new Player(112, 108, 52, 54, 57, 57, 60, 54, 63, 397, 55, 56, 12, 9, 12, 10, 13, 12, 14, 56, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x2B
            private static Player Ken_Furan = new Player(123, 128, 55, 66, 47, 70, 52, 61, 48, 399, 30, 47, 14, 15, 11, 16, 11, 14, 9, 47, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x2C
            private static Player Jerry_Fulton = new Player(126, 106, 52, 58, 56, 61, 56, 79, 53, 415, 49, 66, 12, 10, 14, 10, 12, 10, 13, 66, 5, 2, 3, 5, 2, 1, 2, 1, 1); // 0x2D
            private static Player Ray_Mannings = new Player(101, 112, 55, 62, 51, 52, 56, 65, 62, 403, 48, 51, 13, 8, 11, 11, 14, 8, 10, 51, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x2E
            private static Player Robert_Mayer = new Player(97, 137, 54, 48, 60, 52, 73, 54, 61, 402, 54, 55, 13, 11, 12, 12, 12, 12, 12, 55, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x2F
            private static Player Alexander_Brave = new Player(98, 127, 57, 68, 60, 52, 62, 56, 55, 410, 54, 74, 11, 12, 11, 10, 11, 11, 12, 74, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x30
            private static Player Johan_Tassman = new Player(105, 135, 62, 64, 56, 48, 60, 62, 63, 415, 69, 85, 15, 17, 15, 13, 15, 10, 14, 85, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x31
            private static Player Troy_Moon = new Player(109, 115, 61, 70, 45, 52, 74, 53, 60, 415, 58, 55, 18, 11, 13, 16, 14, 10, 16, 55, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x32
            private static Player Burt_Wolf = new Player(110, 132, 72, 52, 52, 51, 56, 46, 60, 389, 54, 70, 17, 15, 15, 13, 13, 10, 13, 70, 1, 2, 1, 5, 2, 1, 2, 3, 1); // 0x33
            private static Player Rob_Crombie = new Player(137, 94, 47, 51, 50, 40, 64, 74, 56, 382, 38, 53, 9, 11, 7, 19, 11, 14, 10, 53, 2, 2, 3, 5, 2, 1, 2, 1, 1); // 0x34
            private static Player Chuck_Dollman = new Player(98, 96, 52, 66, 45, 48, 53, 53, 50, 367, 37, 49, 11, 10, 7, 9, 9, 8, 11, 49, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x35
            private static Player Uxley_Allen = new Player(100, 112, 48, 54, 67, 50, 48, 58, 44, 369, 36, 52, 11, 9, 8, 9, 9, 11, 8, 52, 1, 1, 1, 1, 1, 1, 5, 1, 3); // 0x36
            private static Player Phil_Noir = new Player(95, 120, 56, 45, 48, 58, 52, 69, 45, 373, 31, 41, 9, 10, 9, 9, 8, 11, 10, 41, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x37
            private static Player Mick_Askley = new Player(116, 100, 64, 50, 54, 44, 48, 56, 54, 370, 40, 48, 8, 8, 10, 8, 11, 11, 9, 48, 5, 4, 4, 5, 5, 1, 4, 4, 3); // 0x38
            private static Player Charlie_Boardfield = new Player(124, 128, 48, 64, 50, 69, 60, 54, 62, 407, 69, 48, 18, 10, 12, 16, 9, 13, 10, 48, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x3D
            private static Player Hugo_Tallgeese = new Player(104, 101, 52, 44, 56, 46, 64, 67, 54, 383, 66, 44, 7, 10, 10, 16, 13, 14, 9, 44, 1, 2, 1, 5, 2, 1, 2, 3, 1); // 0x3E
            private static Player Wilson_Fishman = new Player(113, 113, 52, 64, 51, 51, 46, 69, 51, 384, 69, 51, 11, 18, 9, 8, 14, 11, 9, 51, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x3F
            private static Player Peter_Johnson_ = new Player(97, 94, 61, 52, 48, 48, 54, 57, 50, 370, 61, 33, 9, 9, 7, 16, 15, 13, 11, 33, 1, 4, 2, 2, 5, 1, 1, 1, 3); // 0x40
            private static Player Leonard_O_Shea = new Player(138, 109, 78, 52, 42, 64, 51, 54, 58, 399, 66, 40, 19, 11, 9, 19, 7, 12, 9, 40, 4, 2, 3, 5, 2, 1, 2, 1, 3); // 0x41
            private static Player Cham_Lion = new Player(112, 101, 46, 47, 49, 60, 57, 60, 48, 367, 61, 45, 10, 10, 14, 9, 17, 13, 7, 45, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x42
            private static Player Steve_Eagle = new Player(117, 120, 56, 68, 67, 49, 68, 53, 68, 429, 76, 51, 13, 15, 17, 11, 18, 13, 10, 51, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x43
            private static Player Bruce_Monkey = new Player(108, 96, 54, 64, 56, 48, 53, 52, 54, 381, 56, 43, 7, 12, 7, 9, 10, 14, 8, 43, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x44
            private static Player Gary_Lancaster = new Player(121, 94, 78, 66, 41, 64, 48, 52, 67, 416, 69, 48, 16, 16, 9, 17, 5, 17, 10, 48, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x45
            private static Player Harry_Snake = new Player(106, 123, 55, 63, 62, 49, 55, 65, 45, 394, 56, 49, 9, 15, 16, 9, 13, 12, 10, 49, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x46
            private static Player Adrian_Speed = new Player(99, 112, 59, 47, 69, 46, 84, 42, 47, 394, 80, 51, 14, 10, 17, 7, 20, 14, 11, 51, 1, 4, 2, 2, 5, 1, 1, 1, 2); // 0x47
            private static Player Alan_Coe = new Player(97, 117, 54, 49, 57, 51, 48, 51, 49, 359, 40, 33, 11, 11, 11, 10, 9, 11, 10, 33, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x48
            private static Player Philip_Anders = new Player(115, 124, 56, 53, 48, 58, 52, 55, 46, 368, 37, 66, 10, 10, 8, 9, 10, 7, 8, 66, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x49
            private static Player Rocky_Rackham = new Player(120, 106, 53, 53, 53, 44, 51, 68, 47, 369, 36, 43, 8, 7, 9, 10, 13, 9, 9, 43, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x4A
            private static Player Matt_Mouseman = new Player(113, 94, 42, 50, 52, 44, 79, 54, 45, 366, 42, 41, 4, 5, 11, 4, 23, 11, 9, 41, 5, 4, 4, 5, 4, 1, 4, 4, 2); // 0x4B
            private static Player Chad_Bullford = new Player(126, 129, 41, 68, 48, 77, 31, 51, 64, 380, 32, 40, 9, 19, 9, 20, 10, 8, 11, 40, 2, 2, 3, 5, 2, 1, 2, 1, 2); // 0x4C
            private static Player Thomas_Feldt = new Player(137, 131, 56, 69, 58, 76, 68, 50, 52, 429, 48, 66, 11, 14, 13, 13, 13, 11, 13, 66, 1, 5, 1, 1, 1, 1, 1, 1, 1); // 0x51
            private static Player Harry_Leading = new Player(109, 112, 52, 59, 48, 47, 61, 57, 48, 372, 75, 76, 16, 16, 15, 16, 13, 20, 17, 76, 1, 5, 2, 2, 4, 1, 1, 1, 3); // 0x52
            private static Player Terry_Stronger = new Player(112, 121, 48, 46, 50, 57, 47, 55, 68, 371, 74, 80, 16, 15, 14, 17, 15, 23, 16, 80, 1, 1, 5, 1, 1, 1, 1, 1, 2); // 0x53
            private static Player Philip_Marvel = new Player(127, 95, 50, 62, 52, 48, 52, 57, 51, 372, 75, 76, 13, 13, 15, 17, 16, 20, 13, 76, 5, 2, 3, 5, 2, 1, 2, 1, 2); // 0x54
            private static Player Noel_Good = new Player(113, 110, 47, 47, 48, 60, 48, 71, 50, 371, 76, 60, 15, 15, 15, 15, 16, 21, 15, 60, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x55
            private static Player Tyron_Rock = new Player(106, 104, 56, 46, 63, 48, 48, 52, 52, 365, 74, 76, 14, 17, 14, 17, 15, 20, 14, 76, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x56
            private static Player Francis_Tell = new Player(101, 118, 47, 53, 53, 60, 62, 48, 47, 370, 69, 76, 14, 19, 13, 15, 17, 19, 14, 76, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x57
            private static Player Samuel_Buster = new Player(115, 98, 55, 67, 52, 49, 48, 50, 49, 370, 69, 68, 23, 22, 15, 15, 15, 21, 14, 68, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0x58
            private static Player Jonathan_Seller = new Player(120, 113, 55, 54, 50, 49, 55, 58, 46, 367, 80, 64, 15, 19, 15, 15, 15, 20, 17, 64, 2, 2, 2, 3, 2, 1, 1, 5, 3); // 0x59
            private static Player Victor_Kind = new Player(107, 109, 49, 53, 64, 51, 50, 53, 49, 369, 78, 70, 14, 18, 17, 14, 17, 21, 16, 70, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x5A
            private static Player Neil_Turner = new Player(121, 125, 57, 58, 70, 52, 62, 60, 55, 414, 74, 74, 14, 20, 17, 16, 20, 20, 16, 74, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x5B
            private static Player Reg_Underwood = new Player(122, 105, 44, 40, 40, 69, 48, 61, 70, 372, 81, 72, 17, 17, 16, 17, 21, 22, 17, 72, 1, 5, 2, 2, 2, 1, 1, 1, 1); // 0x5C
            private static Player Patrick_Stiller = new Player(103, 137, 56, 48, 47, 55, 50, 46, 60, 362, 66, 76, 16, 14, 16, 16, 13, 19, 16, 76, 1, 5, 1, 1, 1, 1, 1, 1, 1); // 0x5D
            private static Player Charles_Oughtry = new Player(110, 113, 55, 52, 45, 58, 46, 44, 67, 367, 73, 74, 14, 16, 13, 17, 13, 22, 15, 74, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x5E
            private static Player Clive_Mooney = new Player(109, 101, 58, 49, 54, 50, 55, 58, 46, 370, 76, 72, 13, 17, 13, 15, 17, 20, 13, 72, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0x5F
            private static Player Neil_Waters = new Player(98, 101, 48, 64, 51, 52, 45, 64, 45, 369, 81, 76, 13, 17, 16, 17, 16, 20, 17, 76, 5, 4, 4, 5, 4, 1, 4, 4, 2); // 0x60
            private static Player Sam_Idol = new Player(101, 141, 60, 58, 54, 55, 58, 65, 47, 397, 43, 43, 8, 8, 7, 17, 10, 11, 8, 43, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x65
            private static Player Marcus_Train = new Player(98, 116, 61, 60, 53, 56, 52, 41, 54, 377, 32, 51, 11, 8, 9, 7, 9, 11, 7, 51, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x66
            private static Player Light_Nobel = new Player(94, 124, 60, 55, 56, 58, 61, 57, 48, 395, 44, 51, 8, 9, 9, 8, 9, 9, 9, 51, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x67
            private static Player Walter_Valiant = new Player(123, 107, 62, 62, 61, 55, 56, 50, 71, 417, 31, 36, 11, 15, 9, 8, 9, 11, 7, 36, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x68
            private static Player Spencer_Gates = new Player(107, 128, 59, 52, 56, 58, 56, 40, 62, 383, 46, 40, 7, 9, 11, 7, 9, 7, 9, 40, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x69
            private static Player Josh_Spear = new Player(96, 105, 54, 56, 64, 62, 55, 44, 49, 384, 36, 45, 8, 11, 9, 8, 8, 7, 8, 45, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x6A
            private static Player Gaby_Farmer = new Player(112, 120, 58, 62, 52, 61, 54, 47, 59, 393, 43, 51, 10, 10, 9, 7, 11, 10, 8, 51, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6B
            private static Player A__Woodbridge = new Player(114, 126, 60, 60, 52, 58, 54, 41, 51, 376, 34, 52, 9, 10, 9, 9, 7, 7, 10, 52, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x6C
            private static Player Gus_Gamer = new Player(105, 108, 58, 60, 59, 52, 55, 45, 59, 388, 37, 52, 10, 7, 14, 8, 7, 8, 7, 52, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6D
            private static Player Mark_Gambling = new Player(109, 121, 52, 56, 58, 63, 53, 51, 64, 397, 34, 49, 10, 9, 11, 7, 11, 7, 10, 49, 3, 5, 4, 4, 5, 4, 4, 1, 3); // 0x6E
            private static Player Theodore_Master = new Player(118, 104, 57, 57, 55, 56, 52, 47, 53, 377, 30, 41, 10, 8, 11, 8, 9, 9, 9, 41, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x6F
            private static Player Ham_Signalman = new Player(117, 105, 54, 56, 55, 52, 53, 48, 59, 377, 39, 51, 7, 8, 11, 11, 10, 8, 11, 51, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x70
            private static Player Bill_Formby = new Player(99, 123, 54, 58, 61, 45, 46, 48, 48, 360, 40, 43, 10, 9, 10, 9, 8, 9, 9, 43, 3, 5, 4, 4, 5, 4, 4, 1, 2); // 0x71
            private static Player Grant_Eldorado = new Player(120, 98, 53, 63, 61, 72, 48, 28, 49, 374, 37, 68, 11, 11, 8, 18, 8, 10, 10, 68, 3, 5, 4, 4, 2, 4, 4, 1, 1); // 0x72
            private static Player Mike_Vox = new Player(100, 117, 48, 55, 60, 53, 46, 50, 47, 359, 33, 39, 8, 10, 8, 9, 11, 9, 9, 39, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x73
            private static Player Ollie_Webb = new Player(116, 114, 46, 62, 54, 52, 49, 59, 49, 371, 33, 41, 10, 9, 8, 7, 9, 9, 9, 41, 3, 5, 4, 4, 5, 4, 4, 1, 1); // 0x74
            private static Player Morgan_Sanders = new Player(100, 138, 53, 59, 46, 73, 52, 55, 62, 400, 56, 86, 10, 9, 19, 20, 13, 16, 17, 86, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x79
            private static Player Newton_Flust = new Player(124, 129, 62, 61, 56, 60, 55, 60, 63, 417, 54, 58, 11, 16, 12, 17, 10, 17, 13, 58, 1, 4, 2, 2, 5, 1, 1, 1, 3); // 0x7A
            private static Player Jim_Hillfort = new Player(104, 113, 55, 62, 60, 53, 54, 63, 61, 408, 58, 62, 13, 14, 10, 19, 11, 13, 13, 62, 1, 5, 2, 2, 4, 1, 1, 1, 3); // 0x7B
            private static Player Galen_Thunderbird = new Player(122, 110, 63, 60, 63, 62, 54, 57, 60, 419, 78, 78, 20, 16, 10, 17, 7, 15, 14, 78, 5, 2, 3, 5, 2, 1, 2, 1, 3); // 0x7C
            private static Player Finn_Stoned = new Player(116, 107, 54, 53, 57, 56, 55, 58, 63, 396, 54, 51, 14, 19, 13, 19, 10, 16, 15, 51, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0x7D
            private static Player Phil_Wingate = new Player(105, 126, 60, 56, 60, 57, 54, 68, 61, 416, 70, 62, 19, 11, 19, 15, 13, 16, 16, 62, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x7E
            private static Player Jez_Shell = new Player(102, 109, 53, 63, 59, 56, 47, 65, 60, 403, 44, 63, 13, 10, 12, 14, 12, 14, 15, 63, 1, 4, 2, 2, 5, 1, 1, 1, 3); // 0x7F
            private static Player Jupiter_Jumper = new Player(102, 114, 56, 58, 53, 56, 69, 68, 59, 419, 60, 59, 16, 14, 16, 12, 19, 16, 16, 59, 1, 4, 2, 2, 5, 1, 1, 1, 2); // 0x80
            private static Player Sam_Samurai = new Player(112, 121, 62, 60, 60, 60, 56, 60, 53, 411, 45, 66, 16, 11, 14, 14, 16, 17, 13, 66, 2, 2, 2, 3, 2, 1, 1, 5, 3); // 0x81
            private static Player Hank_Sullivan = new Player(103, 114, 60, 55, 59, 44, 60, 60, 56, 394, 32, 56, 14, 12, 18, 12, 15, 17, 17, 56, 1, 5, 1, 1, 1, 1, 1, 1, 2); // 0x82
            private static Player Sail_Bluesea = new Player(122, 122, 52, 61, 61, 54, 60, 68, 55, 411, 64, 54, 17, 16, 18, 14, 17, 17, 17, 54, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0x83
            private static Player John_Reynolds = new Player(117, 116, 62, 56, 56, 53, 60, 54, 57, 398, 51, 51, 19, 11, 12, 11, 11, 17, 14, 51, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x84
            private static Player Dan_Hopper = new Player(115, 102, 52, 58, 62, 62, 55, 61, 54, 404, 44, 58, 12, 12, 13, 16, 11, 15, 16, 58, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x85
            private static Player Cal_Trops = new Player(104, 107, 58, 61, 69, 55, 59, 57, 54, 413, 43, 60, 11, 10, 18, 13, 11, 13, 15, 60, 4, 2, 3, 5, 2, 1, 2, 1, 3); // 0x86
            private static Player Winston_Falls = new Player(111, 105, 56, 56, 52, 63, 64, 55, 62, 408, 56, 58, 11, 14, 11, 10, 18, 16, 15, 58, 1, 4, 2, 2, 5, 1, 1, 1, 3); // 0x87
            private static Player Kevin_Castle = new Player(103, 129, 53, 60, 52, 68, 52, 68, 52, 405, 48, 56, 12, 14, 14, 18, 12, 13, 15, 56, 4, 2, 3, 5, 2, 1, 2, 1, 3); // 0x88
            private static Player Albert_Green = new Player(128, 114, 50, 53, 60, 73, 53, 64, 77, 430, 60, 55, 10, 17, 16, 17, 11, 19, 15, 55, 5, 2, 1, 5, 3, 1, 2, 3, 2); // 0x8D
            private static Player Seward_Hayseed = new Player(134, 105, 42, 56, 52, 77, 58, 68, 61, 414, 67, 64, 10, 15, 12, 17, 13, 16, 16, 64, 5, 1, 1, 1, 3, 5, 1, 1, 1); // 0x8E
            private static Player Kent_Work = new Player(135, 102, 44, 57, 54, 70, 54, 65, 60, 404, 54, 55, 7, 15, 11, 19, 12, 20, 16, 55, 5, 4, 2, 2, 3, 1, 1, 5, 1); // 0x8F
            private static Player Mark_Hillvalley_ = new Player(134, 108, 40, 56, 52, 79, 63, 66, 53, 409, 63, 51, 7, 13, 13, 18, 11, 19, 15, 51, 5, 2, 3, 5, 3, 1, 2, 1, 1); // 0x90
            private static Player Herb_Sherman = new Player(133, 108, 49, 60, 62, 79, 52, 70, 56, 428, 64, 49, 8, 15, 12, 17, 13, 20, 17, 49, 5, 1, 1, 5, 3, 1, 1, 1, 1); // 0x91
            private static Player Joe_Small = new Player(137, 106, 40, 54, 54, 68, 56, 63, 56, 391, 54, 55, 11, 17, 11, 17, 12, 17, 14, 55, 5, 5, 2, 2, 3, 1, 1, 1, 1); // 0x92
            private static Player Ike_Steiner = new Player(139, 104, 42, 55, 63, 76, 53, 60, 55, 404, 57, 66, 10, 13, 12, 17, 12, 20, 14, 66, 5, 2, 1, 5, 3, 1, 2, 3, 2); // 0x93
            private static Player Orville_Newman = new Player(135, 108, 71, 40, 46, 72, 62, 66, 71, 428, 67, 56, 19, 16, 9, 15, 13, 20, 17, 56, 5, 2, 5, 1, 3, 1, 2, 3, 1); // 0x94
            private static Player Tom_Walters = new Player(137, 105, 59, 58, 52, 66, 61, 61, 70, 427, 58, 63, 13, 16, 12, 15, 14, 20, 14, 63, 5, 2, 1, 1, 3, 5, 2, 3, 3); // 0x95
            private static Player Daniel_Dawson = new Player(128, 108, 53, 52, 53, 72, 60, 62, 72, 424, 57, 59, 16, 16, 11, 16, 14, 18, 16, 59, 5, 1, 1, 1, 3, 5, 1, 1, 2); // 0x96
            private static Player Stuart_Racoonfur = new Player(139, 110, 50, 52, 58, 70, 62, 59, 68, 419, 61, 51, 17, 15, 15, 14, 15, 16, 17, 51, 5, 4, 2, 2, 3, 5, 1, 1, 3); // 0x97
            private static Player Lorne_Mower = new Player(126, 108, 46, 56, 41, 72, 62, 61, 60, 398, 38, 78, 7, 12, 7, 17, 12, 11, 10, 78, 1, 1, 1, 1, 3, 1, 1, 5, 2); // 0x98
            private static Player Homer_Grower = new Player(132, 106, 53, 53, 44, 76, 61, 68, 61, 416, 38, 60, 10, 11, 9, 16, 10, 10, 13, 60, 5, 2, 3, 5, 3, 1, 2, 1, 1); // 0x99
            private static Player Rolf_Howells = new Player(131, 107, 48, 62, 54, 75, 54, 60, 56, 409, 37, 63, 8, 11, 9, 15, 13, 13, 14, 63, 5, 5, 2, 2, 3, 1, 1, 1, 1); // 0x9A
            private static Player Luke_Lively = new Player(132, 108, 47, 57, 44, 73, 56, 63, 54, 394, 40, 52, 7, 14, 8, 14, 14, 13, 12, 52, 5, 2, 3, 5, 3, 1, 2, 1, 1); // 0x9B
            private static Player Ben_Nevis = new Player(133, 118, 52, 56, 51, 70, 59, 64, 53, 405, 45, 60, 7, 12, 9, 17, 11, 10, 12, 60, 5, 2, 5, 1, 3, 1, 2, 3, 2); // 0x9C
            private static Player John_Neville = new Player(127, 140, 78, 62, 54, 79, 48, 51, 44, 416, 85, 100, 13, 10, 17, 23, 7, 6, 5, 100, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0xA1
            private static Player Malcolm_Night = new Player(105, 122, 63, 69, 54, 62, 67, 53, 52, 420, 76, 85, 14, 13, 12, 13, 10, 14, 14, 85, 2, 2, 2, 3, 2, 1, 1, 5, 3); // 0xA2
            private static Player Alfred_Meenan = new Player(115, 118, 61, 55, 55, 60, 55, 53, 52, 391, 51, 90, 13, 12, 11, 15, 18, 11, 10, 90, 2, 2, 2, 3, 2, 1, 1, 5, 3); // 0xA3
            private static Player Dan_Mirthful = new Player(118, 105, 59, 70, 49, 65, 46, 51, 52, 392, 64, 52, 19, 16, 12, 17, 7, 8, 7, 52, 5, 2, 3, 5, 2, 1, 2, 1, 1); // 0xA4
            private static Player Ricky_Clover = new Player(123, 104, 53, 52, 56, 52, 67, 45, 54, 379, 52, 80, 13, 18, 13, 18, 11, 12, 12, 80, 4, 2, 3, 5, 2, 1, 2, 1, 3); // 0xA5
            private static Player Toby_Damian = new Player(120, 114, 54, 56, 55, 56, 57, 56, 55, 389, 51, 89, 12, 17, 15, 14, 16, 11, 11, 89, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0xA6
            private static Player York_Nashmith = new Player(121, 115, 52, 62, 57, 61, 54, 52, 56, 394, 55, 90, 11, 16, 13, 12, 15, 11, 14, 90, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xA7
            private static Player Zachary_Moore = new Player(118, 105, 52, 60, 60, 52, 63, 53, 58, 398, 56, 85, 14, 16, 15, 11, 15, 10, 15, 85, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0xA8
            private static Player Marvin_Murdock = new Player(106, 138, 57, 61, 61, 52, 60, 60, 69, 420, 71, 100, 30, 33, 23, 22, 26, 29, 26, 100, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xA9
            private static Player Thomas_Murdock = new Player(117, 120, 65, 67, 62, 57, 62, 58, 58, 429, 67, 107, 20, 15, 20, 13, 14, 18, 19, 107, 1, 4, 2, 2, 5, 1, 1, 1, 2); // 0xAA
            private static Player Tyler_Murdock = new Player(118, 122, 74, 60, 68, 56, 60, 59, 54, 431, 62, 107, 23, 14, 14, 13, 21, 18, 20, 107, 5, 2, 1, 5, 2, 1, 2, 3, 1); // 0xAB
            private static Player Simon_Calier = new Player(113, 115, 52, 46, 46, 71, 50, 68, 58, 391, 58, 63, 14, 12, 17, 16, 13, 10, 10, 63, 1, 1, 1, 5, 2, 1, 1, 1, 2); // 0xAC
            private static Player Brody_Gloom = new Player(126, 118, 54, 46, 48, 53, 45, 52, 54, 352, 52, 55, 13, 17, 13, 13, 11, 11, 14, 55, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0xAD
            private static Player Victor_Talis = new Player(118, 119, 55, 52, 52, 46, 47, 45, 48, 345, 58, 84, 13, 13, 10, 14, 10, 13, 10, 84, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xAE
            private static Player Eren_Middleton = new Player(122, 113, 48, 44, 55, 47, 55, 54, 52, 355, 54, 51, 11, 12, 11, 20, 14, 11, 10, 51, 4, 2, 3, 5, 2, 1, 2, 1, 3); // 0xAF
            private static Player Peter_Wells = new Player(120, 104, 52, 48, 52, 43, 52, 55, 52, 354, 58, 52, 10, 10, 13, 16, 11, 11, 12, 52, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0xB0
            private static Player Paul_Siddon = new Player(107, 140, 60, 59, 50, 81, 44, 56, 70, 420, 56, 93, 21, 23, 13, 23, 10, 18, 18, 93, 5, 2, 3, 5, 2, 1, 2, 1, 1); // 0xB5
            private static Player Apollo_Light = new Player(108, 128, 69, 70, 62, 73, 53, 48, 55, 430, 78, 76, 14, 17, 19, 20, 22, 20, 19, 76, 1, 5, 2, 2, 4, 1, 1, 1, 3); // 0xB6
            private static Player Jeff_Iron = new Player(103, 131, 60, 60, 65, 69, 62, 58, 58, 432, 69, 100, 13, 21, 16, 19, 21, 15, 12, 100, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0xB7
            private static Player Lane_War = new Player(112, 125, 61, 72, 65, 68, 56, 57, 60, 439, 56, 64, 17, 18, 16, 17, 12, 12, 14, 64, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0xB8
            private static Player Danny_Wood = new Player(114, 126, 62, 68, 60, 67, 50, 53, 64, 424, 54, 78, 22, 14, 13, 17, 8, 14, 22, 78, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xB9
            private static Player Artie_Mishman = new Player(102, 122, 62, 56, 76, 60, 44, 45, 58, 401, 50, 86, 14, 20, 21, 15, 17, 14, 12, 86, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xBA
            private static Player Arion_Matlock = new Player(106, 124, 56, 58, 69, 62, 57, 57, 62, 421, 51, 74, 12, 23, 16, 20, 10, 14, 15, 74, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0xBB
            private static Player Wesley_Knox = new Player(106, 128, 60, 63, 62, 63, 71, 56, 57, 432, 76, 92, 16, 21, 22, 13, 20, 17, 17, 92, 1, 5, 2, 2, 4, 1, 1, 1, 3); // 0xBC
            private static Player Jonas_Demetrius = new Player(128, 130, 70, 59, 64, 56, 60, 63, 62, 434, 80, 104, 23, 17, 18, 12, 15, 13, 15, 104, 1, 2, 1, 5, 2, 1, 2, 3, 3); // 0xBD
            private static Player Byron_Love = new Player(108, 132, 79, 69, 77, 59, 61, 49, 52, 446, 54, 100, 16, 22, 21, 17, 17, 14, 13, 100, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xBE
            private static Player Henry_House = new Player(126, 128, 48, 68, 60, 67, 64, 70, 60, 437, 58, 70, 6, 15, 15, 15, 16, 16, 13, 70, 3, 3, 3, 3, 5, 3, 3, 3, 1); // 0xBF
            private static Player Iggy_Russ = new Player(111, 125, 68, 62, 66, 70, 44, 59, 64, 433, 68, 62, 14, 15, 16, 22, 8, 15, 14, 62, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0xC0
            private static Player Gus_Heeley = new Player(110, 127, 72, 60, 62, 51, 63, 60, 55, 423, 69, 76, 19, 16, 13, 8, 17, 16, 17, 76, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0xC1
            private static Player Harry_Closs = new Player(105, 125, 54, 60, 66, 68, 55, 53, 65, 421, 58, 36, 16, 13, 15, 20, 15, 15, 16, 36, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0xC2
            private static Player Andy_Chronic = new Player(108, 126, 48, 66, 62, 62, 60, 59, 66, 423, 62, 68, 8, 13, 15, 22, 14, 17, 15, 68, 5, 2, 3, 5, 2, 1, 2, 1, 2); // 0xC3
            private static Player Ned_Yousef = new Player(109, 130, 59, 71, 62, 58, 63, 60, 51, 424, 62, 72, 17, 23, 21, 17, 16, 16, 16, 72, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0xC4
            private static Player Herman_Muller = new Player(100, 119, 40, 50, 44, 58, 44, 46, 45, 327, 44, 63, 8, 7, 8, 11, 6, 8, 4, 63, 5, 5, 5, 5, 2, 5, 5, 5, 1); // 0xC9
            private static Player Keth_Claus = new Player(109, 104, 41, 41, 48, 40, 60, 40, 46, 316, 43, 35, 6, 6, 8, 6, 14, 5, 6, 35, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCA
            private static Player Robert_Silver = new Player(113, 93, 46, 41, 51, 44, 41, 48, 44, 315, 45, 32, 7, 11, 5, 8, 4, 8, 6, 32, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCB
            private static Player Izzy_Island = new Player(107, 85, 42, 40, 48, 41, 41, 48, 44, 304, 45, 54, 5, 5, 6, 6, 6, 7, 8, 54, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xCC
            private static Player Sothern_Newman = new Player(98, 80, 45, 44, 48, 60, 43, 49, 47, 336, 42, 20, 6, 8, 5, 17, 8, 8, 7, 20, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xCD
            private static Player Irwin_Hall = new Player(131, 89, 40, 48, 51, 43, 41, 40, 41, 304, 41, 44, 4, 10, 8, 7, 6, 8, 8, 44, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xCE
            private static Player Taylor_Higgins = new Player(114, 85, 44, 43, 50, 48, 40, 48, 40, 313, 45, 21, 8, 11, 7, 8, 7, 4, 7, 21, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xCF
            private static Player Jamie_Cool = new Player(108, 96, 47, 40, 44, 48, 52, 52, 51, 334, 45, 54, 6, 4, 5, 7, 14, 8, 4, 54, 5, 5, 5, 5, 5, 2, 5, 5, 3); // 0xD0
            private static Player Hans_Randall = new Player(107, 120, 65, 55, 44, 52, 52, 58, 58, 384, 46, 60, 10, 6, 5, 5, 8, 5, 12, 60, 5, 2, 5, 5, 5, 5, 5, 2, 2); // 0xD1
            private static Player Michael_Riverside = new Player(106, 97, 51, 46, 50, 49, 40, 43, 48, 327, 45, 20, 7, 8, 8, 8, 6, 5, 5, 20, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xD2
            private static Player Millie_Moonlight = new Player(95, 148, 44, 40, 60, 42, 61, 40, 46, 333, 44, 48, 6, 4, 13, 5, 5, 5, 11, 48, 2, 5, 5, 2, 5, 5, 5, 5, 1); // 0xD3
            private static Player Karl_Blue = new Player(112, 96, 46, 48, 47, 44, 51, 46, 48, 330, 48, 39, 8, 7, 16, 6, 6, 4, 6, 39, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xD4
            private static Player Theakston_Plank = new Player(120, 100, 48, 50, 42, 45, 58, 41, 51, 335, 46, 36, 8, 7, 4, 8, 15, 8, 8, 36, 5, 5, 5, 5, 5, 2, 5, 5, 3); // 0xD5
            private static Player Ken_Cake = new Player(122, 108, 49, 40, 40, 40, 51, 49, 46, 315, 44, 33, 9, 6, 7, 4, 8, 6, 7, 33, 5, 2, 5, 5, 5, 5, 5, 5, 1); // 0xD6
            private static Player Mitch_Grumble = new Player(111, 85, 48, 48, 43, 48, 40, 46, 41, 314, 44, 29, 6, 4, 9, 6, 4, 6, 7, 29, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xD7
            private static Player Bart_Grantham = new Player(102, 115, 45, 42, 37, 71, 30, 32, 58, 315, 49, 54, 6, 5, 5, 15, 8, 7, 6, 54, 1, 5, 5, 5, 2, 5, 5, 5, 1); // 0xD8
            private static Player Joe_Ingram = new Player(105, 119, 44, 51, 52, 68, 47, 57, 78, 397, 50, 43, 11, 10, 10, 12, 8, 11, 6, 43, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xDD
            private static Player Kendall_Sefton = new Player(114, 109, 53, 69, 61, 54, 67, 54, 55, 413, 45, 47, 11, 9, 12, 11, 11, 8, 7, 47, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xDE
            private static Player Jason_Strike = new Player(115, 109, 53, 55, 69, 52, 61, 56, 58, 404, 31, 52, 8, 10, 8, 11, 12, 11, 7, 52, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xDF
            private static Player Norman_Porter = new Player(122, 112, 50, 61, 49, 65, 49, 57, 51, 382, 40, 36, 8, 11, 11, 12, 8, 11, 7, 36, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE0
            private static Player Maxwell_Claus = new Player(130, 105, 62, 53, 55, 44, 53, 55, 49, 371, 42, 41, 12, 9, 10, 9, 14, 7, 4, 41, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE1
            private static Player Bruce_Chaney = new Player(118, 121, 51, 53, 53, 50, 66, 53, 54, 380, 31, 36, 14, 11, 9, 7, 13, 9, 5, 36, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xE2
            private static Player Leroy_Rhymes = new Player(117, 121, 56, 58, 73, 53, 46, 45, 62, 393, 34, 64, 10, 8, 13, 7, 9, 11, 5, 64, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE3
            private static Player Mildford_Scott = new Player(117, 109, 50, 58, 53, 54, 55, 52, 54, 376, 44, 47, 10, 16, 10, 10, 11, 7, 8, 47, 4, 4, 4, 4, 5, 4, 4, 2, 2); // 0xE4
            private static Player Lou_Edmonds = new Player(125, 124, 60, 68, 45, 51, 44, 72, 71, 411, 37, 39, 11, 14, 9, 9, 9, 7, 5, 39, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE5
            private static Player Cameron_Morefield = new Player(122, 129, 59, 56, 58, 52, 48, 52, 72, 397, 34, 63, 13, 13, 11, 10, 8, 9, 7, 63, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xE6
            private static Player Greg_Bernard = new Player(109, 132, 49, 55, 70, 51, 51, 56, 65, 397, 38, 72, 9, 9, 15, 11, 10, 8, 4, 72, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE7
            private static Player Peter_Banker = new Player(102, 133, 50, 45, 51, 63, 50, 45, 75, 379, 42, 62, 11, 10, 14, 18, 7, 9, 4, 62, 2, 4, 4, 5, 2, 4, 4, 2, 2); // 0xE8
            private static Player Saul_Tunk = new Player(118, 109, 55, 53, 44, 62, 55, 47, 54, 370, 32, 48, 11, 9, 11, 19, 8, 8, 8, 48, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xE9
            private static Player Alan_Most = new Player(113, 145, 45, 40, 42, 38, 44, 61, 43, 313, 26, 39, 8, 5, 7, 6, 8, 7, 6, 39, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xEA
            private static Player Paul_Caperock = new Player(126, 113, 54, 50, 46, 63, 58, 48, 53, 372, 43, 49, 8, 7, 9, 10, 12, 11, 6, 49, 4, 4, 4, 4, 5, 4, 4, 2, 1); // 0xEB
            private static Player Julius_Molehill = new Player(127, 113, 53, 48, 68, 48, 55, 49, 68, 389, 30, 48, 7, 7, 12, 7, 11, 10, 7, 48, 4, 4, 4, 4, 5, 4, 4, 2, 3); // 0xEC
            private static Player Suzanne_Yuma = new Player(85, 140, 44, 60, 43, 77, 49, 46, 80, 399, 31, 45, 11, 7, 11, 20, 10, 9, 18, 45, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0xF1
            private static Player Tammy_Fielding = new Player(80, 132, 44, 49, 62, 58, 75, 44, 58, 390, 30, 21, 6, 7, 6, 7, 14, 8, 13, 21, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xF2
            private static Player Alex_Lovely = new Player(128, 122, 55, 53, 51, 57, 52, 62, 54, 384, 42, 48, 10, 9, 8, 11, 10, 7, 17, 48, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xF3
            private static Player Louis_Hillside = new Player(136, 128, 60, 72, 51, 49, 45, 48, 66, 391, 42, 39, 19, 17, 10, 8, 9, 11, 14, 39, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xF4
            private static Player Ness_Sheldon = new Player(105, 129, 42, 68, 68, 68, 42, 68, 43, 399, 34, 44, 10, 14, 10, 16, 9, 8, 16, 44, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xF5
            private static Player Lizzy_Squirrel = new Player(92, 137, 61, 66, 50, 45, 72, 45, 44, 383, 32, 76, 7, 7, 11, 14, 10, 9, 20, 76, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0xF6
            private static Player Kippy_Jones = new Player(82, 150, 57, 51, 80, 51, 43, 42, 51, 375, 33, 27, 6, 7, 5, 5, 7, 5, 15, 27, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0xF7
            private static Player Fayette_Riversong = new Player(121, 120, 63, 65, 51, 57, 59, 58, 55, 408, 45, 51, 7, 11, 12, 8, 8, 8, 15, 51, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xF8
            private static Player Samantha_Moonlight = new Player(108, 130, 59, 65, 66, 54, 51, 52, 50, 397, 48, 51, 11, 12, 11, 10, 10, 9, 14, 51, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0xF9
            private static Player Mitch_Sandstone = new Player(110, 124, 70, 67, 41, 52, 45, 55, 70, 400, 37, 47, 20, 15, 11, 11, 8, 10, 15, 47, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0xFA
            private static Player Eddie_Prentice = new Player(116, 128, 62, 70, 56, 58, 65, 48, 49, 408, 39, 45, 9, 8, 18, 9, 9, 9, 15, 45, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xFB
            private static Player Alf_Holmes = new Player(100, 128, 37, 38, 62, 70, 57, 55, 77, 396, 36, 69, 7, 10, 10, 19, 7, 4, 13, 69, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0xFC
            private static Player Ian_Stager = new Player(89, 142, 78, 49, 62, 51, 49, 50, 51, 390, 42, 76, 11, 8, 8, 8, 8, 8, 17, 76, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0xFD
            private static Player Fred_Crumb = new Player(104, 128, 58, 54, 58, 56, 59, 63, 51, 399, 40, 37, 9, 11, 10, 7, 14, 11, 16, 37, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0xFE
            private static Player Doug_Baughan = new Player(116, 126, 75, 41, 46, 48, 64, 64, 44, 382, 43, 45, 8, 9, 14, 9, 7, 9, 16, 45, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0xFF
            private static Player Pip_Daltry = new Player(99, 145, 58, 59, 49, 74, 49, 40, 43, 372, 35, 20, 5, 4, 8, 7, 5, 5, 15, 20, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0x100
            private static Player Seymour_Hillman = new Player(118, 132, 51, 67, 63, 74, 48, 55, 71, 429, 69, 93, 12, 12, 11, 10, 12, 13, 15, 93, 1, 2, 1, 1, 2, 1, 5, 3, 3); // 0x105
            private static Player Charles_Island = new Player(114, 118, 66, 62, 61, 68, 60, 52, 54, 423, 68, 78, 13, 14, 16, 11, 11, 12, 11, 78, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x106
            private static Player Garret_Hairtown = new Player(105, 120, 50, 55, 64, 64, 63, 61, 51, 408, 63, 60, 12, 13, 16, 14, 16, 11, 11, 60, 1, 5, 2, 2, 4, 1, 1, 1, 3); // 0x107
            private static Player Arthur_Sweet = new Player(120, 121, 58, 65, 66, 64, 55, 58, 61, 427, 68, 70, 15, 16, 11, 14, 13, 15, 11, 70, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x108
            private static Player Peter_Mildred = new Player(106, 120, 57, 57, 69, 66, 58, 68, 62, 437, 55, 64, 14, 13, 10, 13, 11, 11, 11, 64, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0x109
            private static Player Josh_Nathaniel = new Player(107, 117, 60, 60, 60, 60, 60, 60, 60, 420, 62, 60, 14, 11, 15, 10, 14, 13, 12, 60, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x10A
            private static Player Edward_Gladstone = new Player(118, 109, 60, 62, 64, 60, 61, 53, 69, 429, 62, 66, 14, 12, 12, 11, 13, 12, 12, 66, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x10B
            private static Player Tyler_Thomas = new Player(122, 114, 65, 65, 70, 62, 67, 52, 50, 431, 54, 76, 11, 12, 10, 10, 11, 11, 12, 76, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x10C
            private static Player Joseph_Yosemite = new Player(123, 126, 51, 52, 68, 65, 65, 62, 65, 428, 64, 68, 18, 11, 15, 14, 14, 12, 13, 68, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x10D
            private static Player Ian_Suffolk = new Player(115, 120, 66, 68, 50, 61, 57, 63, 62, 427, 62, 63, 14, 13, 12, 11, 13, 13, 14, 63, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x10E
            private static Player Constant_Builder = new Player(117, 115, 70, 61, 64, 40, 60, 70, 72, 437, 66, 64, 16, 20, 14, 14, 13, 15, 14, 64, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0x10F
            private static Player Ted_Poe = new Player(119, 128, 44, 62, 68, 69, 59, 64, 69, 435, 57, 68, 13, 14, 13, 10, 14, 14, 12, 68, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x110
            private static Player Marshall_Heart = new Player(105, 104, 52, 68, 60, 53, 58, 60, 66, 417, 68, 80, 14, 12, 12, 11, 12, 13, 11, 80, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x111
            private static Player Dom_Foreman = new Player(108, 121, 62, 61, 59, 60, 49, 75, 62, 428, 66, 76, 10, 12, 11, 11, 11, 14, 10, 76, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x112
            private static Player Slot_MacHines = new Player(120, 125, 56, 56, 63, 59, 64, 56, 61, 415, 69, 76, 12, 12, 14, 11, 13, 13, 13, 76, 1, 5, 1, 1, 1, 1, 1, 1, 3); // 0x113
            private static Player Bill_Steakspear = new Player(122, 124, 52, 64, 67, 57, 57, 56, 57, 410, 61, 60, 11, 11, 17, 11, 11, 11, 10, 60, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x114
            private static Player Jimmy_Mach = new Player(117, 99, 51, 56, 56, 54, 67, 65, 50, 399, 67, 46, 8, 6, 11, 5, 20, 18, 6, 46, 5, 1, 1, 1, 1, 2, 2, 5, 3); // 0x12D
            private static Player Tony_Hacker = new Player(102, 118, 51, 56, 60, 61, 65, 65, 58, 416, 46, 58, 12, 12, 11, 12, 14, 16, 14, 58, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x12E
            private static Player Dan_Rhino = new Player(118, 97, 63, 54, 56, 51, 61, 57, 51, 393, 47, 48, 9, 9, 9, 8, 12, 11, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x12F
            private static Player Vin_Fleetwood = new Player(126, 104, 62, 58, 56, 61, 60, 60, 59, 416, 44, 46, 13, 13, 12, 10, 13, 12, 11, 46, 1, 5, 5, 5, 5, 5, 5, 5, 1); // 0x130
            private static Player George_Winters = new Player(125, 122, 56, 63, 65, 60, 47, 62, 63, 416, 54, 63, 14, 17, 14, 15, 19, 17, 13, 63, 5, 5, 5, 5, 5, 2, 2, 5, 4); // 0x131
            private static Player Den_Hidden = new Player(120, 100, 63, 56, 58, 65, 46, 67, 56, 411, 58, 54, 12, 12, 12, 13, 14, 12, 13, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x132
            private static Player Shaun_Imago = new Player(120, 92, 45, 41, 38, 53, 56, 56, 56, 345, 50, 48, 10, 9, 7, 11, 17, 11, 9, 48, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x133
            private static Player Joe_Straiter = new Player(122, 92, 53, 51, 51, 62, 54, 54, 55, 380, 59, 59, 15, 10, 12, 4, 10, 10, 13, 59, 1, 2, 4, 5, 2, 4, 1, 4, 1); // 0x134
            private static Player Rupert_Spiers = new Player(122, 100, 53, 58, 62, 62, 64, 60, 57, 416, 56, 55, 15, 14, 10, 10, 20, 15, 11, 55, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x135
            private static Player Mark_Sudor = new Player(120, 92, 58, 57, 53, 57, 47, 57, 51, 380, 55, 54, 7, 8, 8, 11, 10, 7, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x136
            private static Player Ringo_Stagg = new Player(121, 105, 56, 59, 54, 60, 53, 53, 57, 392, 49, 52, 11, 9, 7, 15, 10, 13, 10, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x137
            private static Player Jody_MacGough = new Player(138, 95, 44, 51, 54, 51, 60, 62, 56, 378, 44, 49, 8, 8, 9, 10, 11, 10, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x138
            private static Player Jeeves_Dropper = new Player(126, 96, 47, 56, 54, 51, 60, 56, 52, 376, 48, 52, 9, 7, 8, 11, 14, 12, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x139
            private static Player Dan_Dandy = new Player(114, 109, 56, 45, 46, 57, 60, 59, 60, 383, 57, 57, 11, 13, 8, 11, 17, 13, 12, 57, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x13A
            private static Player Rory_Boomer = new Player(124, 101, 62, 57, 54, 53, 56, 59, 67, 408, 57, 45, 19, 15, 11, 10, 11, 10, 14, 45, 5, 2, 1, 5, 1, 1, 1, 1, 1); // 0x13B
            private static Player Tim_Toppel = new Player(125, 108, 61, 59, 58, 56, 58, 61, 56, 409, 47, 46, 8, 6, 6, 6, 6, 7, 7, 46, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0x13C
            private static Player Ames_Shivers = new Player(118, 94, 56, 53, 54, 53, 53, 57, 52, 378, 59, 60, 13, 14, 14, 16, 16, 13, 13, 60, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x13D
            private static Player Chris_Glover = new Player(94, 112, 60, 57, 56, 65, 42, 60, 51, 391, 50, 53, 10, 11, 9, 14, 7, 9, 11, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x13E
            private static Player Thor_Toise = new Player(131, 105, 51, 52, 48, 44, 50, 55, 51, 351, 54, 42, 14, 12, 10, 7, 9, 10, 9, 42, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x13F
            private static Player Colin_Salts = new Player(118, 105, 57, 46, 47, 44, 46, 48, 44, 332, 56, 53, 11, 11, 10, 8, 10, 10, 10, 53, 2, 2, 2, 2, 2, 2, 5, 2, 1); // 0x140
            private static Player Christian_Dear = new Player(120, 93, 55, 58, 65, 58, 46, 51, 53, 386, 52, 48, 15, 14, 11, 7, 9, 8, 10, 48, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x141
            private static Player Iggy_Loyaller = new Player(122, 102, 56, 57, 51, 57, 40, 58, 51, 370, 49, 50, 9, 11, 10, 11, 11, 7, 10, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x142
            private static Player Conan_Fox = new Player(122, 100, 46, 53, 53, 51, 57, 53, 57, 370, 50, 52, 10, 7, 10, 11, 17, 13, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x143
            private static Player Spike_Coiffs = new Player(106, 114, 44, 56, 66, 45, 51, 54, 51, 367, 51, 49, 17, 17, 19, 14, 14, 17, 7, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x144
            private static Player Roger_Rocket = new Player(133, 96, 44, 37, 41, 55, 66, 53, 51, 347, 55, 48, 11, 6, 4, 11, 19, 14, 8, 48, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x145
            private static Player Bill_Teller = new Player(122, 101, 46, 55, 66, 57, 57, 54, 55, 390, 47, 62, 13, 6, 21, 9, 14, 11, 11, 62, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x146
            private static Player Billy_Nomates = new Player(119, 103, 65, 58, 58, 66, 44, 65, 59, 415, 58, 59, 10, 14, 12, 15, 12, 12, 11, 59, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x147
            private static Player Harry_Caine = new Player(120, 103, 63, 62, 56, 58, 58, 56, 57, 410, 60, 55, 11, 15, 16, 15, 14, 15, 13, 55, 1, 2, 4, 4, 4, 5, 4, 4, 3); // 0x148
            private static Player Martin_Sheller = new Player(129, 101, 60, 54, 54, 61, 41, 60, 57, 387, 52, 48, 10, 10, 7, 14, 11, 7, 9, 48, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x149
            private static Player Alfie_Fine = new Player(93, 126, 59, 51, 51, 61, 50, 60, 54, 386, 49, 49, 11, 9, 10, 10, 9, 9, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x14A
            private static Player Cameron_Mann = new Player(114, 106, 56, 55, 54, 56, 51, 51, 52, 375, 50, 50, 10, 10, 11, 9, 9, 9, 7, 50, 1, 5, 1, 1, 1, 1, 1, 1, 1); // 0x14B
            private static Player Don_Keys = new Player(121, 99, 47, 41, 39, 51, 58, 53, 53, 342, 54, 49, 7, 10, 7, 10, 14, 12, 10, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x14C
            private static Player Sonny_East = new Player(120, 99, 55, 56, 50, 44, 49, 57, 60, 371, 52, 48, 13, 13, 8, 11, 7, 11, 8, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x14D
            private static Player Dan_Carpenter = new Player(102, 109, 44, 52, 56, 45, 51, 53, 56, 357, 55, 49, 9, 13, 13, 8, 8, 11, 8, 49, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x14E
            private static Player Doug_Walker = new Player(117, 96, 47, 51, 62, 45, 53, 54, 56, 368, 52, 54, 9, 13, 17, 10, 8, 10, 9, 54, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x14F
            private static Player Frank_Drake = new Player(124, 102, 54, 54, 56, 54, 58, 59, 51, 386, 64, 54, 13, 12, 12, 13, 13, 16, 13, 54, 4, 5, 4, 4, 4, 4, 4, 4, 1); // 0x150
            private static Player Chris_Massey = new Player(118, 97, 59, 54, 51, 51, 53, 57, 55, 380, 55, 54, 16, 7, 10, 14, 10, 8, 10, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x151
            private static Player Carl_Sacks = new Player(116, 97, 56, 57, 53, 56, 53, 51, 53, 379, 60, 53, 14, 11, 12, 10, 14, 11, 10, 53, 2, 2, 2, 2, 2, 2, 5, 2, 2); // 0x152
            private static Player Biff_Beeston = new Player(122, 99, 53, 60, 44, 56, 53, 61, 54, 381, 44, 59, 7, 9, 14, 13, 10, 15, 11, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x153
            private static Player Lou_Beigh = new Player(101, 115, 45, 51, 57, 51, 60, 51, 56, 371, 51, 49, 14, 11, 9, 7, 15, 14, 9, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x154
            private static Player Marv_Errick = new Player(119, 109, 64, 62, 58, 65, 45, 60, 56, 410, 60, 55, 12, 13, 14, 17, 11, 13, 10, 55, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x155
            private static Player Bob_Whittle = new Player(121, 105, 56, 60, 62, 58, 62, 58, 57, 413, 49, 59, 15, 13, 13, 11, 19, 15, 13, 59, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x156
            private static Player Bert_Neptune = new Player(125, 110, 58, 62, 58, 58, 57, 56, 56, 405, 61, 64, 16, 17, 17, 13, 16, 16, 14, 64, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x157
            private static Player Sol_Crater = new Player(122, 94, 51, 51, 51, 53, 51, 54, 53, 364, 55, 56, 12, 12, 11, 11, 10, 11, 13, 56, 4, 2, 5, 4, 2, 2, 2, 4, 1); // 0x158
            private static Player Percy_Coldstair = new Player(94, 114, 45, 55, 53, 51, 59, 58, 57, 378, 45, 49, 7, 10, 11, 8, 11, 14, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x159
            private static Player Dusky_Sunfield = new Player(120, 88, 55, 53, 61, 50, 45, 56, 56, 376, 49, 48, 15, 11, 19, 9, 11, 7, 9, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x15A
            private static Player Rocky_Shears = new Player(120, 102, 54, 54, 56, 67, 57, 56, 56, 400, 58, 58, 14, 12, 13, 12, 11, 14, 12, 58, 4, 5, 4, 4, 4, 4, 4, 4, 1); // 0x15B
            private static Player Percy_Stent = new Player(112, 108, 65, 57, 56, 57, 60, 61, 60, 416, 60, 53, 10, 17, 13, 17, 16, 13, 15, 53, 1, 2, 4, 4, 5, 4, 4, 4, 2); // 0x15C
            private static Player Art_Pendragon = new Player(135, 93, 56, 59, 47, 57, 57, 62, 55, 393, 49, 58, 8, 10, 10, 17, 13, 14, 8, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x15D
            private static Player Dom_Ittory = new Player(118, 92, 50, 51, 56, 46, 57, 57, 51, 368, 51, 52, 9, 11, 13, 11, 8, 9, 9, 52, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x15E
            private static Player Chaz_Biggins = new Player(125, 92, 57, 56, 36, 57, 54, 58, 53, 371, 65, 43, 14, 7, 7, 15, 10, 14, 9, 43, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x15F
            private static Player Sly_O_Hands = new Player(117, 109, 53, 63, 67, 67, 47, 56, 61, 414, 57, 52, 12, 14, 12, 17, 13, 11, 14, 52, 1, 2, 1, 5, 2, 5, 2, 1, 3); // 0x160
            private static Player Sean_Lavender = new Player(99, 130, 60, 51, 53, 54, 57, 62, 52, 389, 56, 54, 13, 7, 14, 13, 9, 9, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x161
            private static Player Ace_Server = new Player(112, 106, 65, 61, 57, 66, 47, 66, 60, 422, 60, 55, 13, 12, 14, 14, 10, 10, 13, 55, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x162
            private static Player Horace_Nelson = new Player(91, 126, 59, 53, 51, 54, 53, 62, 55, 387, 49, 54, 17, 9, 13, 15, 10, 11, 7, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x163
            private static Player Rex_George = new Player(126, 102, 60, 60, 56, 56, 57, 60, 59, 408, 60, 59, 15, 16, 15, 15, 15, 15, 16, 59, 4, 4, 5, 4, 4, 4, 4, 4, 1); // 0x164
            private static Player Philip_Prince = new Player(94, 114, 45, 51, 51, 56, 60, 60, 55, 378, 49, 48, 10, 8, 11, 8, 17, 12, 8, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x165
            private static Player Heath_Rower = new Player(118, 97, 53, 53, 51, 53, 55, 51, 53, 369, 58, 56, 10, 11, 12, 12, 12, 14, 12, 56, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x166
            private static Player Kim_Arite = new Player(135, 99, 53, 60, 51, 67, 56, 53, 56, 396, 52, 52, 9, 7, 9, 17, 8, 12, 11, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x167
            private static Player Jay_Archer = new Player(123, 97, 52, 61, 46, 59, 54, 58, 56, 386, 70, 57, 11, 7, 12, 16, 12, 17, 8, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x168
            private static Player Bo_Ling = new Player(106, 113, 47, 53, 67, 50, 53, 54, 51, 375, 52, 51, 10, 7, 21, 11, 10, 10, 10, 51, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x169
            private static Player Chuck_Hardy = new Player(124, 93, 49, 54, 62, 47, 51, 57, 57, 377, 50, 52, 8, 12, 14, 9, 10, 9, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x16A
            private static Player Ben_Evolent = new Player(120, 101, 60, 51, 56, 56, 51, 55, 51, 380, 61, 62, 6, 15, 14, 13, 15, 15, 15, 62, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x16B
            private static Player Will_Noble = new Player(133, 102, 48, 48, 52, 44, 51, 48, 47, 338, 54, 59, 8, 11, 14, 8, 10, 10, 11, 59, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x16C
            private static Player Jack_Frosty = new Player(125, 105, 59, 62, 58, 59, 60, 56, 60, 414, 48, 44, 5, 6, 6, 4, 7, 6, 5, 44, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x16D
            private static Player Larry_Helps = new Player(118, 102, 47, 52, 54, 55, 56, 52, 53, 369, 47, 54, 10, 8, 8, 11, 18, 13, 10, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x16E
            private static Player Monty_Patten = new Player(118, 116, 57, 56, 57, 56, 51, 52, 56, 385, 57, 55, 13, 10, 10, 12, 12, 13, 13, 55, 1, 4, 4, 4, 4, 5, 4, 4, 1); // 0x16F
            private static Player Chunk_Gorman = new Player(101, 116, 48, 53, 54, 56, 57, 51, 51, 370, 51, 50, 13, 8, 11, 8, 15, 11, 11, 50, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x170
            private static Player Balt_Decker = new Player(120, 109, 53, 47, 48, 56, 65, 56, 60, 385, 57, 54, 11, 13, 6, 13, 17, 15, 12, 54, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x171
            private static Player Drew_Crenshaw = new Player(107, 110, 47, 55, 61, 48, 56, 51, 57, 375, 49, 49, 7, 13, 13, 10, 11, 9, 9, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x172
            private static Player Stan_Trum = new Player(118, 93, 48, 52, 54, 53, 62, 55, 55, 379, 49, 48, 11, 9, 7, 8, 15, 11, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x173
            private static Player Sham_Spike = new Player(115, 95, 56, 54, 51, 53, 53, 53, 54, 374, 59, 59, 15, 14, 13, 17, 15, 17, 14, 59, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x174
            private static Player Rainier_Welkin = new Player(107, 124, 48, 56, 60, 65, 53, 56, 51, 389, 55, 61, 8, 9, 14, 17, 10, 10, 11, 61, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x175
            private static Player Evan_Yielding = new Player(118, 103, 51, 47, 50, 56, 65, 59, 58, 386, 54, 57, 11, 12, 6, 10, 18, 15, 14, 57, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x176
            private static Player Phil_Anthropic = new Player(124, 89, 66, 66, 66, 66, 60, 45, 65, 434, 52, 54, 14, 12, 12, 12, 12, 8, 12, 54, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x177
            private static Player Fane_Club = new Player(93, 123, 47, 50, 46, 61, 48, 45, 49, 346, 51, 52, 10, 7, 10, 10, 9, 9, 9, 52, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x178
            private static Player Slim_Lanky = new Player(131, 96, 46, 41, 41, 54, 59, 53, 57, 351, 55, 54, 7, 7, 6, 10, 15, 11, 9, 54, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x179
            private static Player Pearson_Gaze = new Player(120, 102, 46, 41, 38, 53, 62, 57, 54, 351, 56, 47, 8, 8, 7, 9, 17, 13, 7, 47, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x17A
            private static Player Edward_Albion = new Player(124, 92, 56, 56, 61, 53, 60, 57, 56, 399, 54, 55, 14, 14, 19, 13, 17, 11, 10, 55, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0x17B
            private static Player Stu_Dent = new Player(99, 119, 60, 40, 46, 37, 63, 57, 53, 356, 52, 46, 15, 7, 8, 4, 19, 8, 9, 46, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x17C
            private static Player Barry_Straw = new Player(118, 99, 42, 63, 48, 42, 63, 44, 48, 350, 52, 54, 7, 19, 9, 7, 16, 10, 10, 54, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x17D
            private static Player Bobby_Peel = new Player(120, 97, 56, 57, 53, 53, 55, 51, 57, 382, 59, 54, 12, 13, 13, 12, 10, 14, 13, 54, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x17E
            private static Player Dan_Castella = new Player(117, 95, 56, 55, 53, 51, 57, 53, 52, 377, 56, 59, 10, 11, 11, 13, 12, 11, 13, 59, 5, 2, 2, 2, 2, 5, 2, 2, 1); // 0x17F
            private static Player Bill_Moony = new Player(122, 100, 67, 51, 53, 56, 58, 56, 51, 392, 48, 53, 8, 11, 11, 8, 12, 12, 11, 53, 5, 5, 1, 1, 1, 2, 5, 1, 1); // 0x180
            private static Player Buddy_Goodman = new Player(122, 94, 48, 65, 48, 48, 45, 47, 65, 366, 53, 53, 9, 7, 8, 11, 8, 7, 10, 53, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x181
            private static Player Dex_Territy = new Player(119, 101, 56, 51, 54, 51, 55, 53, 53, 373, 62, 59, 14, 14, 15, 16, 14, 15, 14, 59, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x182
            private static Player Vinny_O_Gaines = new Player(116, 92, 47, 56, 58, 51, 51, 51, 53, 367, 50, 51, 10, 13, 13, 9, 9, 11, 8, 51, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x183
            private static Player Ray_Deo = new Player(138, 102, 56, 51, 51, 52, 51, 56, 53, 370, 52, 48, 13, 9, 11, 17, 10, 11, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x184
            private static Player Archie_Meades = new Player(122, 87, 54, 52, 44, 62, 49, 57, 51, 369, 49, 47, 17, 13, 8, 10, 9, 7, 9, 47, 5, 1, 1, 1, 5, 1, 1, 1, 2); // 0x185
            private static Player Dave_Chaucer = new Player(122, 102, 62, 55, 53, 51, 54, 62, 53, 390, 52, 54, 14, 10, 12, 15, 10, 11, 11, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x186
            private static Player Billy_Blanc = new Player(133, 118, 56, 54, 48, 47, 48, 51, 67, 371, 50, 46, 17, 12, 10, 8, 8, 10, 10, 46, 5, 1, 1, 1, 1, 5, 1, 1, 1); // 0x187
            private static Player Creed_Craving = new Player(133, 100, 56, 56, 57, 56, 51, 54, 51, 381, 49, 54, 10, 7, 9, 14, 8, 12, 7, 54, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x188
            private static Player Phil_Rosey = new Player(120, 108, 52, 58, 53, 61, 54, 52, 56, 386, 51, 52, 11, 7, 8, 16, 7, 11, 7, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x189
            private static Player Harry_Redcastle = new Player(120, 110, 57, 56, 51, 61, 51, 53, 56, 385, 53, 60, 9, 10, 11, 17, 9, 12, 9, 60, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x18A
            private static Player Sonny_Welkin = new Player(119, 97, 60, 57, 52, 56, 41, 60, 52, 378, 52, 51, 9, 11, 10, 10, 11, 12, 11, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x18B
            private static Player Teddy_Kodiak = new Player(115, 98, 54, 54, 56, 52, 53, 56, 51, 376, 56, 59, 12, 13, 12, 12, 14, 13, 12, 59, 2, 2, 5, 2, 2, 4, 2, 2, 3); // 0x18C
            private static Player Lloyd_Tabb = new Player(131, 91, 44, 51, 57, 53, 57, 55, 57, 374, 47, 49, 10, 8, 10, 8, 17, 10, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x18D
            private static Player Francis_Paine = new Player(99, 129, 48, 56, 51, 53, 56, 53, 57, 374, 45, 52, 11, 10, 11, 7, 15, 14, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x18E
            private static Player Griff_Strummer = new Player(117, 107, 56, 51, 56, 56, 53, 54, 54, 380, 59, 54, 10, 14, 11, 12, 10, 10, 12, 54, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x18F
            private static Player Bryce_Bergman = new Player(120, 95, 47, 56, 55, 56, 58, 61, 56, 389, 67, 51, 10, 19, 11, 10, 12, 17, 7, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x190
            private static Player Fingus_Inky = new Player(122, 93, 54, 62, 48, 58, 53, 57, 51, 383, 45, 57, 11, 9, 11, 15, 11, 13, 11, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x191
            private static Player Walter_Geyser = new Player(126, 92, 57, 60, 45, 56, 54, 56, 51, 379, 49, 53, 9, 9, 10, 16, 11, 15, 11, 53, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x192
            private static Player Les_Knightley = new Player(134, 116, 53, 58, 56, 59, 53, 51, 51, 381, 56, 48, 10, 11, 7, 16, 10, 11, 11, 48, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x193
            private static Player Conor_Abley = new Player(91, 122, 58, 54, 57, 60, 42, 66, 57, 394, 52, 49, 11, 10, 9, 11, 7, 9, 9, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x194
            private static Player Ainsley_Burns = new Player(122, 97, 47, 54, 60, 50, 56, 57, 57, 381, 52, 52, 9, 11, 16, 9, 11, 11, 7, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x195
            private static Player Pete_Grimes = new Player(117, 109, 46, 51, 56, 44, 51, 57, 51, 356, 54, 62, 9, 11, 13, 8, 8, 9, 8, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x196
            private static Player Manny_Steele = new Player(129, 95, 53, 56, 45, 56, 56, 66, 53, 385, 69, 59, 9, 10, 12, 15, 13, 16, 10, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x197
            private static Player Trey_Hugger = new Player(124, 96, 41, 63, 56, 63, 41, 36, 54, 354, 45, 52, 8, 17, 14, 17, 6, 6, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x198
            private static Player Jack_Mate = new Player(124, 100, 57, 60, 56, 61, 51, 56, 53, 394, 52, 49, 10, 11, 10, 16, 10, 11, 8, 49, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x199
            private static Player Mike_Chequer = new Player(111, 92, 57, 52, 52, 51, 53, 51, 53, 369, 57, 53, 11, 13, 13, 14, 10, 13, 12, 53, 4, 4, 4, 5, 4, 4, 4, 4, 2); // 0x19A
            private static Player Berty_Adman = new Player(134, 93, 48, 51, 53, 55, 62, 57, 53, 379, 45, 47, 11, 9, 7, 9, 17, 11, 9, 47, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x19B
            private static Player Troy_Carr = new Player(120, 111, 53, 53, 57, 57, 51, 56, 57, 384, 61, 59, 13, 17, 17, 13, 15, 17, 15, 59, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x19C
            private static Player Hollis_Ticure = new Player(126, 94, 54, 56, 51, 55, 51, 61, 51, 379, 63, 64, 16, 13, 15, 17, 15, 13, 15, 64, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x19D
            private static Player Guy_Dance = new Player(122, 97, 45, 54, 57, 57, 56, 60, 53, 382, 50, 52, 11, 8, 10, 11, 14, 11, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x19E
            private static Player Jack_Trumper = new Player(122, 109, 44, 54, 60, 46, 54, 54, 51, 363, 51, 63, 10, 10, 14, 11, 8, 10, 8, 63, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x19F
            private static Player John_Corder = new Player(104, 118, 53, 57, 57, 56, 57, 53, 51, 384, 55, 55, 12, 12, 10, 11, 10, 12, 11, 55, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0x1A0
            private static Player Nigel_Bramel = new Player(94, 137, 48, 53, 56, 51, 62, 57, 53, 380, 45, 52, 10, 8, 11, 11, 15, 12, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1A1
            private static Player Hank_O_Chief = new Player(124, 96, 54, 57, 48, 47, 47, 53, 54, 360, 50, 43, 17, 14, 7, 11, 10, 8, 9, 43, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x1A2
            private static Player Jess_Uplement = new Player(122, 120, 54, 56, 44, 45, 50, 51, 51, 351, 50, 42, 17, 13, 8, 9, 11, 7, 10, 42, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x1A3
            private static Player Alec_Smart = new Player(99, 126, 47, 48, 50, 44, 50, 48, 47, 334, 52, 49, 9, 8, 7, 11, 11, 8, 11, 49, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x1A4
            private static Player Rob_Anchor = new Player(121, 97, 56, 54, 64, 51, 56, 62, 53, 396, 48, 51, 16, 9, 10, 14, 8, 8, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x1A5
            private static Player Brent_Cross = new Player(122, 100, 57, 51, 44, 49, 49, 54, 54, 358, 56, 47, 15, 12, 9, 9, 9, 11, 7, 47, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x1A6
            private static Player Albert_Wister = new Player(118, 98, 50, 56, 56, 51, 58, 58, 53, 382, 46, 51, 8, 10, 9, 9, 10, 10, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1A7
            private static Player Nev_Erin = new Player(120, 109, 56, 62, 62, 56, 65, 60, 62, 423, 50, 56, 14, 10, 14, 13, 19, 17, 14, 56, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1A8
            private static Player Caz_Yewell = new Player(126, 94, 62, 51, 53, 57, 60, 60, 56, 399, 56, 56, 14, 12, 10, 13, 13, 13, 14, 56, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x1A9
            private static Player Conor_Trail = new Player(122, 93, 56, 56, 49, 62, 53, 65, 55, 396, 44, 55, 10, 8, 14, 17, 14, 16, 8, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x1AA
            private static Player Manuel_Gere = new Player(117, 93, 45, 57, 62, 50, 51, 54, 55, 374, 49, 52, 8, 13, 14, 9, 9, 11, 11, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1AB
            private static Player Per_Hockside = new Player(136, 99, 45, 53, 54, 52, 61, 60, 57, 382, 49, 48, 10, 9, 8, 10, 14, 14, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1AC
            private static Player Lee_Gleagle = new Player(121, 89, 49, 49, 46, 50, 47, 44, 46, 331, 52, 52, 9, 10, 10, 11, 9, 11, 9, 52, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x1AD
            private static Player Paul_Pitcher = new Player(106, 113, 47, 55, 60, 47, 53, 52, 56, 370, 51, 67, 9, 9, 19, 8, 10, 7, 10, 67, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1AE
            private static Player Turner_Fortune = new Player(121, 93, 37, 41, 50, 66, 44, 47, 45, 330, 49, 52, 8, 4, 9, 16, 9, 8, 8, 52, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x1AF
            private static Player Walter_Walken = new Player(131, 90, 46, 45, 48, 49, 50, 50, 63, 351, 56, 47, 9, 10, 8, 10, 8, 10, 7, 47, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x1B0
            private static Player Sal_Curie = new Player(115, 92, 48, 53, 57, 50, 51, 57, 53, 369, 49, 52, 8, 12, 16, 7, 7, 9, 7, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1B1
            private static Player Silver_Platt = new Player(119, 94, 53, 54, 55, 51, 51, 51, 57, 372, 60, 59, 12, 12, 12, 10, 10, 14, 14, 59, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x1B2
            private static Player Nick_Yergrub = new Player(126, 100, 57, 62, 48, 65, 51, 65, 57, 405, 45, 57, 10, 11, 14, 14, 12, 16, 7, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1B3
            private static Player Mal_Inger = new Player(119, 91, 50, 53, 57, 48, 55, 53, 56, 372, 54, 52, 10, 14, 15, 9, 10, 11, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1B4
            private static Player Jim_Cook = new Player(122, 95, 51, 56, 48, 45, 44, 53, 53, 350, 50, 47, 17, 14, 11, 9, 7, 9, 9, 47, 5, 5, 1, 1, 1, 1, 1, 1, 3); // 0x1B5
            private static Player Gus_Potter = new Player(94, 118, 47, 53, 54, 55, 60, 56, 56, 381, 49, 47, 9, 7, 8, 9, 12, 12, 11, 47, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1B6
            private static Player Handel_Turnon = new Player(118, 90, 53, 51, 46, 46, 50, 56, 56, 358, 49, 48, 15, 14, 10, 11, 8, 11, 9, 48, 5, 1, 1, 5, 1, 1, 1, 1, 3); // 0x1B7
            private static Player Peter_Malus = new Player(120, 92, 57, 57, 53, 51, 56, 56, 51, 381, 54, 47, 16, 11, 12, 17, 8, 10, 11, 47, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1B8
            private static Player Colin_Lection = new Player(116, 101, 53, 54, 51, 56, 51, 57, 51, 373, 64, 60, 16, 13, 16, 17, 14, 16, 15, 60, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x1B9
            private static Player Brock_Twigg = new Player(128, 115, 48, 48, 50, 66, 47, 49, 62, 370, 54, 54, 10, 7, 10, 8, 10, 7, 8, 54, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0x1BA
            private static Player Paddy_Rise = new Player(120, 109, 53, 61, 56, 59, 53, 56, 56, 394, 55, 49, 8, 7, 11, 17, 7, 14, 8, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1BB
            private static Player Dustin_Westend = new Player(102, 127, 48, 52, 56, 51, 60, 56, 52, 375, 49, 53, 8, 11, 8, 9, 12, 12, 9, 53, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1BC
            private static Player Alfonse_Way = new Player(134, 95, 50, 39, 39, 51, 56, 56, 56, 347, 55, 48, 11, 8, 8, 9, 15, 12, 10, 48, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x1BD
            private static Player Pippin_Flowers = new Player(121, 110, 57, 62, 51, 56, 56, 53, 56, 391, 52, 53, 7, 10, 10, 15, 9, 11, 10, 53, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x1BE
            private static Player Euan_Stamper = new Player(121, 108, 65, 44, 47, 50, 50, 46, 67, 369, 52, 53, 10, 8, 11, 11, 10, 10, 10, 53, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x1BF
            private static Player Paddy_Prunus = new Player(120, 86, 51, 56, 48, 51, 48, 56, 57, 367, 51, 43, 13, 10, 7, 8, 9, 10, 7, 43, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x1C0
            private static Player Brian_Presser = new Player(133, 106, 55, 60, 53, 59, 54, 53, 57, 391, 51, 48, 8, 7, 7, 15, 9, 11, 9, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1C1
            private static Player Pete_LeGume = new Player(125, 105, 57, 60, 57, 58, 60, 58, 56, 406, 65, 57, 14, 16, 14, 13, 15, 16, 13, 57, 4, 4, 4, 4, 4, 5, 4, 4, 3); // 0x1C2
            private static Player Shylock_Watson = new Player(120, 86, 45, 45, 44, 47, 44, 46, 49, 320, 53, 50, 11, 11, 8, 9, 11, 11, 10, 50, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x1C3
            private static Player Ed_Ripp = new Player(122, 91, 45, 51, 51, 56, 59, 62, 54, 378, 48, 50, 7, 8, 8, 9, 11, 14, 11, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1C4
            private static Player Hike_Basher = new Player(110, 100, 56, 56, 52, 53, 56, 52, 57, 382, 65, 60, 13, 17, 17, 14, 14, 16, 13, 60, 1, 1, 1, 1, 1, 5, 1, 1, 3); // 0x1C5
            private static Player Anthony_Phinder = new Player(124, 92, 52, 51, 53, 56, 56, 56, 53, 377, 62, 59, 15, 15, 13, 17, 14, 14, 16, 59, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x1C6
            private static Player Duncan_Jump = new Player(127, 87, 44, 48, 48, 44, 45, 65, 48, 342, 75, 49, 9, 8, 9, 11, 10, 20, 8, 49, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x1C7
            private static Player Lucky_Winn = new Player(126, 95, 51, 59, 48, 56, 56, 59, 53, 382, 47, 55, 7, 10, 10, 14, 11, 17, 11, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x1C8
            private static Player Gene_Bates = new Player(125, 101, 56, 57, 56, 56, 41, 58, 53, 377, 67, 52, 7, 11, 8, 14, 7, 20, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1C9
            private static Player Randolf_Finn = new Player(133, 99, 59, 57, 57, 53, 57, 60, 57, 400, 55, 51, 15, 8, 14, 17, 10, 11, 11, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1CA
            private static Player Ron_Away = new Player(118, 101, 49, 37, 39, 53, 60, 56, 56, 350, 52, 47, 11, 9, 7, 9, 14, 12, 10, 47, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1CB
            private static Player Rick_Hatter = new Player(126, 101, 56, 56, 58, 59, 58, 57, 58, 402, 64, 61, 15, 16, 13, 14, 17, 16, 17, 61, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x1CC
            private static Player Grant_Mardy = new Player(120, 91, 56, 53, 44, 45, 44, 53, 56, 351, 52, 43, 14, 13, 9, 10, 10, 9, 7, 43, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x1CD
            private static Player Shawn_Broker = new Player(127, 102, 44, 57, 53, 51, 51, 62, 57, 375, 69, 47, 8, 10, 11, 11, 14, 11, 9, 47, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1CE
            private static Player Anthony_Coyne = new Player(133, 108, 53, 56, 51, 56, 56, 51, 53, 376, 50, 53, 9, 11, 9, 14, 9, 13, 10, 53, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1CF
            private static Player Healey_Proctor = new Player(102, 112, 46, 53, 62, 44, 51, 51, 53, 360, 53, 61, 8, 9, 15, 8, 8, 11, 8, 61, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1D0
            private static Player Ade_Posting = new Player(124, 88, 38, 46, 48, 60, 56, 48, 45, 341, 50, 49, 8, 4, 6, 16, 16, 11, 6, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1D1
            private static Player Doug_Outon = new Player(120, 90, 38, 47, 56, 39, 46, 46, 48, 320, 48, 45, 8, 10, 14, 8, 8, 6, 7, 45, 5, 2, 5, 2, 2, 2, 2, 2, 3); // 0x1D2
            private static Player Ebenezer_Marner = new Player(120, 91, 45, 41, 38, 53, 60, 57, 53, 347, 54, 48, 7, 9, 8, 8, 17, 14, 11, 48, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1D3
            private static Player Davy_Johns = new Player(123, 86, 60, 50, 44, 56, 62, 53, 44, 369, 50, 45, 7, 7, 6, 9, 4, 5, 8, 45, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D4
            private static Player Bos_Horne = new Player(122, 97, 56, 56, 52, 53, 55, 60, 53, 385, 52, 50, 17, 11, 14, 15, 10, 8, 8, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D5
            private static Player Nick_Orner = new Player(115, 101, 44, 47, 44, 45, 51, 54, 53, 338, 52, 47, 11, 17, 15, 17, 7, 10, 9, 47, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1D6
            private static Player Nathin_Gaunt = new Player(101, 117, 44, 53, 51, 56, 65, 51, 56, 376, 46, 51, 12, 11, 10, 7, 20, 10, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1D7
            private static Player Quentin_Quartz = new Player(122, 101, 56, 51, 54, 60, 38, 57, 54, 370, 55, 54, 20, 11, 10, 14, 8, 7, 11, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1D8
            private static Player Andrew_Meikle = new Player(119, 106, 48, 53, 56, 48, 57, 51, 57, 370, 49, 61, 10, 9, 19, 11, 10, 9, 10, 61, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1D9
            private static Player Gary_Salmon = new Player(120, 97, 53, 51, 55, 56, 57, 56, 54, 382, 60, 56, 14, 14, 12, 11, 13, 12, 11, 56, 1, 5, 1, 1, 1, 1, 1, 1, 1); // 0x1DA
            private static Player Fontaine_Tapper = new Player(122, 91, 46, 53, 57, 52, 59, 56, 54, 377, 49, 54, 12, 8, 8, 11, 20, 10, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1DB
            private static Player Leon_Lawn = new Player(94, 112, 56, 53, 49, 47, 44, 61, 51, 361, 52, 43, 16, 12, 11, 7, 10, 8, 8, 43, 5, 1, 1, 1, 1, 1, 5, 1, 3); // 0x1DC
            private static Player Jim_Sweatman = new Player(102, 117, 44, 53, 60, 48, 53, 51, 51, 360, 54, 64, 7, 7, 17, 9, 11, 9, 7, 64, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x1DD
            private static Player Cole_Coaker = new Player(119, 92, 48, 51, 56, 51, 57, 55, 54, 372, 45, 53, 10, 9, 8, 10, 15, 13, 9, 53, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1DE
            private static Player Stu_Born = new Player(100, 130, 56, 53, 44, 48, 47, 53, 51, 352, 49, 47, 13, 14, 7, 7, 9, 10, 9, 47, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x1DF
            private static Player Romeo_Montague = new Player(124, 102, 54, 56, 57, 56, 53, 56, 53, 385, 65, 61, 14, 15, 16, 17, 13, 17, 17, 61, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x1E0
            private static Player Drew_Straitedge = new Player(131, 89, 49, 47, 46, 46, 47, 45, 48, 328, 55, 52, 9, 9, 10, 10, 11, 10, 11, 52, 2, 5, 2, 2, 2, 2, 2, 2, 3); // 0x1E1
            private static Player Dash_Dotter = new Player(92, 116, 50, 51, 56, 51, 59, 57, 54, 378, 44, 48, 7, 9, 7, 8, 14, 10, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x1E2
            private static Player Gill_O_Mend = new Player(118, 96, 53, 56, 53, 53, 54, 51, 54, 374, 56, 53, 11, 14, 10, 12, 12, 13, 14, 53, 4, 4, 4, 4, 4, 5, 4, 4, 1); // 0x1E3
            private static Player Pay_Chance = new Player(124, 95, 55, 53, 51, 55, 56, 53, 53, 376, 62, 60, 15, 15, 16, 16, 17, 15, 14, 60, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0x1E4
            private static Player Bill_Aegis = new Player(101, 125, 57, 57, 44, 56, 53, 60, 53, 380, 48, 58, 7, 11, 12, 13, 13, 15, 11, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1E5
            private static Player Tosh_Coach = new Player(124, 98, 40, 62, 43, 66, 42, 39, 39, 331, 50, 45, 8, 7, 6, 5, 8, 8, 7, 45, 2, 2, 2, 2, 2, 2, 2, 5, 3); // 0x1E6
            private static Player Carl_Gnu = new Player(118, 100, 45, 53, 51, 57, 62, 63, 52, 383, 44, 48, 10, 8, 7, 11, 14, 18, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1E7
            private static Player Paul_Sapp = new Player(130, 97, 57, 56, 46, 58, 53, 60, 53, 383, 50, 55, 8, 8, 14, 14, 13, 14, 9, 55, 1, 1, 5, 1, 5, 1, 2, 1, 1); // 0x1E8
            private static Player Macky_Valley = new Player(99, 118, 52, 55, 45, 46, 48, 51, 66, 363, 54, 48, 15, 12, 9, 8, 10, 10, 17, 48, 5, 1, 1, 1, 1, 1, 1, 5, 1); // 0x1E9
            private static Player Troy_Trucker = new Player(94, 116, 59, 51, 57, 54, 56, 67, 51, 395, 50, 50, 15, 11, 12, 16, 10, 11, 8, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x1EA
            private static Player Haden_Seek = new Player(123, 94, 44, 57, 52, 52, 62, 57, 57, 381, 47, 49, 14, 10, 10, 11, 17, 14, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1EB
            private static Player Kevin_Doors = new Player(124, 105, 62, 59, 60, 62, 57, 57, 57, 414, 60, 60, 14, 15, 17, 15, 15, 15, 13, 60, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x1EC
            private static Player Skip_Rooter = new Player(125, 94, 56, 53, 56, 56, 54, 60, 56, 391, 59, 50, 14, 11, 13, 15, 9, 10, 10, 50, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1ED
            private static Player Rip_Airman = new Player(91, 119, 48, 51, 52, 51, 59, 59, 55, 375, 45, 49, 10, 11, 11, 9, 13, 12, 10, 49, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1EE
            private static Player Stu_Shiner = new Player(119, 92, 55, 57, 56, 51, 56, 54, 54, 383, 65, 59, 16, 13, 16, 17, 17, 16, 13, 59, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x1EF
            private static Player Matt_Matickal = new Player(120, 92, 44, 41, 41, 56, 62, 53, 54, 351, 56, 52, 7, 10, 8, 8, 14, 13, 10, 52, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x1F0
            private static Player Philip_Flagg = new Player(126, 98, 44, 37, 39, 51, 56, 39, 56, 322, 62, 54, 9, 8, 5, 10, 19, 5, 9, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1F1
            private static Player Alf_Groundsman = new Player(119, 93, 56, 56, 53, 60, 53, 57, 53, 388, 62, 61, 15, 16, 16, 17, 14, 17, 15, 61, 5, 2, 2, 2, 5, 2, 2, 2, 1); // 0x1F2
            private static Player Ernie_Riddell = new Player(99, 135, 46, 54, 65, 46, 51, 51, 56, 369, 50, 51, 8, 12, 16, 8, 9, 11, 10, 51, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x1F3
            private static Player Len_Stint = new Player(115, 95, 51, 55, 56, 56, 54, 57, 53, 382, 59, 61, 16, 15, 16, 16, 16, 17, 15, 61, 2, 5, 2, 2, 2, 2, 2, 2, 3); // 0x1F4
            private static Player Holly_Cricket = new Player(120, 101, 56, 62, 48, 57, 57, 60, 53, 393, 49, 55, 11, 9, 12, 15, 14, 15, 10, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x1F5
            private static Player Dave_Altair = new Player(128, 93, 56, 57, 54, 54, 51, 61, 56, 389, 64, 49, 15, 9, 10, 15, 9, 11, 9, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x1F6
            private static Player Jim_Reed = new Player(120, 91, 47, 47, 45, 51, 52, 47, 48, 337, 50, 48, 6, 5, 7, 7, 12, 11, 8, 48, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x1F7
            private static Player Gwyn_Penn = new Player(119, 109, 49, 54, 62, 45, 54, 51, 56, 371, 52, 64, 9, 11, 15, 10, 11, 10, 10, 64, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1F8
            private static Player Spike_Needle = new Player(110, 91, 45, 39, 43, 56, 62, 55, 52, 352, 56, 52, 9, 8, 8, 10, 16, 12, 10, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1F9
            private static Player Ifan_Tassy = new Player(121, 93, 56, 50, 54, 53, 54, 57, 56, 380, 50, 45, 5, 8, 11, 6, 4, 6, 8, 45, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x1FA
            private static Player Eggbert_Heading = new Player(130, 95, 60, 51, 54, 62, 42, 65, 57, 391, 52, 51, 9, 9, 10, 12, 11, 9, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x1FB
            private static Player Pascal_Blaise = new Player(122, 96, 49, 53, 56, 56, 60, 47, 54, 375, 49, 48, 12, 9, 9, 7, 15, 4, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x1FC
            private static Player Will_Whist = new Player(93, 128, 56, 41, 38, 51, 57, 52, 51, 346, 53, 52, 11, 9, 7, 11, 16, 10, 11, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x1FD
            private static Player Ewan_Liner = new Player(121, 97, 50, 65, 57, 51, 59, 57, 53, 392, 45, 50, 11, 9, 9, 9, 13, 12, 8, 50, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x1FE
            private static Player Buster_Locke = new Player(90, 129, 53, 54, 49, 45, 49, 53, 54, 357, 64, 45, 15, 11, 10, 11, 9, 10, 9, 45, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x1FF
            private static Player Rex_Plorer = new Player(121, 95, 48, 51, 54, 57, 59, 56, 51, 376, 48, 54, 12, 9, 8, 8, 16, 12, 8, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x200
            private static Player Webber_Poster = new Player(120, 104, 53, 53, 47, 47, 44, 53, 53, 350, 50, 45, 14, 13, 10, 9, 10, 7, 7, 45, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x201
            private static Player Sid_Parting = new Player(133, 92, 60, 56, 57, 61, 48, 58, 51, 391, 52, 51, 10, 10, 7, 11, 9, 9, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x202
            private static Player Eaton_Rampage = new Player(121, 95, 50, 46, 48, 50, 63, 48, 42, 347, 54, 50, 9, 8, 7, 8, 8, 10, 6, 50, 4, 4, 4, 5, 4, 2, 4, 4, 3); // 0x203
            private static Player Parker_Leaper = new Player(119, 91, 52, 51, 57, 56, 54, 53, 53, 376, 56, 54, 14, 13, 11, 14, 12, 12, 12, 54, 4, 4, 5, 4, 4, 4, 4, 4, 1); // 0x204
            private static Player Hank_Halberd = new Player(127, 101, 57, 57, 55, 56, 42, 57, 53, 377, 64, 49, 9, 11, 10, 12, 11, 14, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x205
            private static Player Robin_Catching = new Player(118, 91, 48, 49, 50, 48, 66, 49, 48, 358, 52, 53, 8, 10, 7, 9, 18, 10, 11, 53, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x206
            private static Player Trey_Spotter = new Player(108, 113, 48, 52, 56, 50, 50, 46, 51, 353, 46, 58, 7, 6, 12, 8, 8, 6, 6, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x207
            private static Player Onslow_Ball = new Player(134, 97, 54, 61, 48, 62, 56, 57, 56, 394, 50, 58, 8, 7, 10, 13, 13, 14, 9, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x208
            private static Player Tex_Tingle = new Player(118, 88, 44, 50, 52, 47, 56, 46, 47, 342, 50, 46, 8, 6, 7, 4, 13, 10, 4, 46, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x209
            private static Player Sam_Gale = new Player(111, 91, 48, 51, 59, 46, 53, 56, 57, 370, 50, 48, 11, 12, 14, 7, 11, 8, 7, 48, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x20A
            private static Player Ryder_Waverly = new Player(120, 97, 49, 43, 39, 57, 56, 57, 53, 354, 55, 52, 10, 8, 6, 11, 15, 13, 9, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x20B
            private static Player Leaf_Scarlett = new Player(119, 97, 53, 54, 56, 53, 56, 51, 56, 379, 63, 60, 16, 13, 13, 14, 14, 16, 14, 60, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x20C
            private static Player Horace_Coop = new Player(110, 86, 52, 55, 46, 48, 50, 56, 51, 358, 54, 48, 13, 12, 10, 8, 9, 7, 10, 48, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x20D
            private static Player Ness_Lockley = new Player(118, 113, 46, 53, 56, 57, 60, 51, 57, 380, 45, 52, 13, 10, 9, 19, 17, 12, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x20E
            private static Player Olef_Tennant = new Player(91, 134, 57, 52, 60, 56, 51, 36, 54, 366, 48, 70, 12, 12, 14, 14, 14, 8, 14, 70, 4, 4, 4, 5, 4, 4, 4, 4, 3); // 0x20F
            private static Player Len_Scapp = new Player(121, 99, 44, 41, 39, 53, 64, 53, 57, 351, 52, 51, 9, 10, 5, 11, 16, 10, 9, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x210
            private static Player Monty_Hillary = new Player(118, 97, 45, 53, 55, 57, 59, 58, 51, 378, 48, 50, 11, 7, 8, 9, 13, 12, 9, 50, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x211
            private static Player Penfold_Pulper = new Player(126, 102, 44, 51, 55, 55, 62, 58, 57, 382, 44, 49, 7, 7, 9, 9, 11, 13, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x212
            private static Player Thomas_Cott = new Player(106, 118, 51, 55, 51, 53, 57, 55, 53, 375, 64, 60, 14, 17, 17, 13, 15, 14, 15, 60, 2, 5, 2, 2, 2, 2, 2, 2, 2); // 0x213
            private static Player Spike_Thorne = new Player(136, 91, 51, 58, 48, 56, 51, 57, 53, 374, 51, 57, 11, 8, 12, 13, 12, 15, 8, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x214
            private static Player Lincoln_Hawking = new Player(124, 101, 54, 51, 57, 63, 52, 57, 56, 390, 65, 60, 16, 16, 16, 14, 16, 16, 16, 60, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x215
            private static Player Ted_Larkin = new Player(91, 119, 56, 55, 57, 57, 57, 62, 54, 398, 51, 49, 16, 9, 12, 15, 11, 8, 9, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x216
            private static Player Madison_Cabinet = new Player(118, 108, 44, 51, 56, 45, 56, 57, 54, 363, 49, 59, 9, 9, 16, 9, 10, 9, 7, 59, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x217
            private static Player Odo_Cologne = new Player(122, 94, 44, 54, 51, 54, 56, 42, 56, 357, 65, 52, 10, 10, 11, 7, 13, 8, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x218
            private static Player Nester_Damus = new Player(99, 124, 57, 56, 57, 56, 51, 52, 53, 382, 55, 56, 12, 10, 13, 12, 12, 12, 13, 56, 1, 1, 1, 1, 1, 5, 1, 1, 3); // 0x219
            private static Player Herb_Ivore = new Player(116, 100, 53, 56, 56, 56, 55, 54, 56, 386, 55, 54, 12, 13, 12, 14, 12, 12, 10, 54, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x21A
            private static Player Homer_Pidgeon = new Player(128, 91, 56, 56, 53, 51, 56, 66, 53, 391, 52, 51, 16, 9, 14, 15, 8, 9, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x21B
            private static Player Rob_Ottley = new Player(122, 97, 45, 51, 53, 51, 60, 56, 53, 369, 45, 52, 12, 11, 11, 8, 16, 14, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x21C
            private static Player Scott_Springer = new Player(92, 126, 66, 55, 57, 51, 51, 56, 52, 388, 53, 51, 14, 10, 12, 14, 8, 11, 7, 51, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x21D
            private static Player Viv_Grey = new Player(122, 118, 53, 54, 45, 46, 48, 56, 53, 355, 52, 69, 17, 10, 9, 11, 10, 11, 10, 69, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x21E
            private static Player Don_Snow = new Player(121, 91, 56, 54, 56, 58, 41, 58, 56, 379, 54, 51, 10, 8, 9, 12, 9, 9, 11, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x21F
            private static Player Hal_Mullet = new Player(122, 92, 45, 65, 53, 56, 60, 60, 53, 392, 48, 48, 8, 9, 11, 10, 10, 18, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x220
            private static Player Isaiah_Shutt = new Player(94, 119, 58, 60, 52, 56, 51, 53, 51, 381, 56, 51, 17, 10, 12, 15, 11, 8, 11, 51, 1, 2, 1, 1, 2, 2, 2, 5, 1); // 0x221
            private static Player Ace_Irvin = new Player(111, 108, 45, 51, 59, 50, 53, 56, 57, 371, 50, 64, 9, 10, 17, 7, 8, 11, 11, 64, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x222
            private static Player Spike_Pitt = new Player(110, 92, 56, 51, 53, 54, 56, 52, 57, 379, 52, 49, 7, 7, 10, 8, 10, 11, 7, 49, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x223
            private static Player Innes_Caving = new Player(106, 118, 46, 45, 48, 54, 61, 54, 53, 361, 52, 51, 11, 8, 6, 10, 15, 12, 8, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x224
            private static Player Keanu_Dell = new Player(118, 96, 47, 53, 60, 50, 56, 51, 37, 354, 53, 49, 9, 11, 17, 8, 11, 9, 6, 49, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x225
            private static Player Casey_Novak = new Player(110, 95, 56, 58, 50, 61, 54, 57, 57, 393, 55, 59, 7, 11, 14, 15, 12, 17, 8, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x226
            private static Player Ed_Halley = new Player(93, 134, 46, 43, 37, 52, 67, 38, 53, 336, 50, 52, 11, 10, 8, 11, 20, 6, 7, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x227
            private static Player Burt_Mocking = new Player(133, 115, 56, 56, 50, 50, 47, 54, 54, 367, 52, 45, 17, 13, 8, 10, 11, 10, 9, 45, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x228
            private static Player Oscar_Petty = new Player(123, 101, 65, 62, 57, 62, 46, 66, 69, 427, 60, 55, 10, 11, 14, 17, 14, 12, 11, 55, 1, 2, 1, 1, 2, 5, 2, 5, 1); // 0x229
            private static Player Waite_Forrit = new Player(119, 95, 56, 53, 55, 54, 55, 60, 55, 388, 59, 47, 16, 9, 12, 16, 10, 14, 8, 47, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x22A
            private static Player Bennett_Byers = new Player(126, 93, 54, 57, 48, 60, 51, 56, 52, 378, 45, 55, 9, 11, 12, 13, 12, 15, 11, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x22B
            private static Player Mo_Eisner = new Player(136, 93, 48, 53, 56, 53, 59, 56, 57, 382, 48, 54, 11, 11, 10, 11, 17, 13, 8, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x22C
            private static Player Miles_Seaford = new Player(120, 99, 44, 41, 37, 56, 62, 51, 53, 344, 52, 49, 10, 10, 7, 10, 17, 13, 9, 49, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x22D
            private static Player Sayer_Lemon = new Player(118, 97, 51, 56, 52, 51, 57, 55, 51, 373, 60, 63, 14, 16, 13, 14, 15, 14, 15, 63, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x22E
            private static Player Carey_Ginu = new Player(123, 92, 44, 51, 56, 57, 66, 53, 56, 383, 50, 47, 14, 7, 7, 8, 16, 11, 11, 47, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x22F
            private static Player Cass_Crocker = new Player(120, 97, 60, 50, 58, 42, 46, 44, 46, 346, 47, 57, 7, 8, 10, 6, 7, 8, 7, 57, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x230
            private static Player Paul_Downs = new Player(124, 116, 48, 51, 62, 44, 51, 54, 57, 367, 54, 47, 9, 13, 17, 8, 11, 9, 10, 47, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x231
            private static Player Darrel_Jeeling = new Player(124, 99, 48, 56, 60, 47, 54, 55, 51, 371, 52, 52, 10, 14, 15, 11, 11, 9, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x232
            private static Player Nobby_Shinn = new Player(121, 116, 54, 53, 50, 44, 48, 54, 51, 354, 55, 45, 17, 12, 11, 11, 10, 10, 9, 45, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0x233
            private static Player Theo_Broma = new Player(121, 90, 51, 52, 49, 49, 44, 53, 51, 349, 49, 44, 17, 10, 10, 10, 8, 7, 7, 44, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0x234
            private static Player Ramsey_Faroe = new Player(130, 102, 42, 66, 39, 62, 38, 67, 40, 354, 50, 44, 5, 8, 7, 4, 7, 5, 7, 44, 1, 5, 4, 1, 4, 1, 4, 1, 1); // 0x235
            private static Player Buster_Chopps = new Player(120, 113, 55, 53, 54, 55, 54, 56, 67, 394, 60, 49, 12, 13, 13, 12, 12, 12, 14, 49, 1, 1, 1, 5, 1, 1, 1, 2, 1); // 0x236
            private static Player Vince_Bull = new Player(120, 92, 53, 53, 51, 56, 58, 58, 54, 383, 48, 47, 7, 7, 10, 10, 11, 11, 7, 47, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x237
            private static Player Pat_Maclean = new Player(120, 106, 57, 58, 57, 61, 56, 56, 60, 405, 60, 53, 11, 10, 13, 12, 14, 13, 12, 53, 4, 4, 4, 5, 4, 4, 4, 4, 2); // 0x238
            private static Player Walter_Card = new Player(101, 124, 39, 38, 67, 39, 43, 41, 41, 308, 45, 46, 5, 8, 6, 4, 7, 4, 5, 46, 4, 1, 1, 5, 1, 1, 1, 1, 1); // 0x239
            private static Player Derek_Terr = new Player(121, 94, 50, 39, 38, 56, 66, 54, 55, 358, 52, 48, 8, 11, 6, 10, 13, 14, 9, 48, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x23A
            private static Player Alton_Oldhat = new Player(120, 120, 56, 57, 48, 44, 48, 56, 57, 366, 49, 48, 14, 14, 9, 10, 9, 11, 11, 48, 5, 1, 1, 1, 1, 5, 1, 1, 3); // 0x23B
            private static Player Cal_Cooler = new Player(126, 100, 60, 53, 56, 56, 53, 61, 54, 393, 59, 59, 10, 13, 12, 11, 12, 10, 13, 59, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x23C
            private static Player Tom_Felix = new Player(99, 125, 52, 56, 62, 57, 62, 56, 55, 400, 59, 57, 11, 10, 18, 13, 18, 14, 10, 57, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x23D
            private static Player Terry_Orr = new Player(130, 90, 50, 45, 44, 46, 62, 67, 60, 374, 52, 50, 11, 8, 7, 11, 8, 9, 7, 50, 1, 1, 1, 5, 1, 1, 2, 1, 1); // 0x23E
            private static Player Rudolph_Rainder = new Player(118, 93, 48, 39, 42, 53, 60, 53, 54, 349, 52, 51, 8, 9, 7, 11, 17, 10, 8, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x23F
            private static Player Nick_Swagg = new Player(99, 126, 60, 61, 62, 58, 58, 58, 56, 413, 56, 59, 12, 13, 16, 17, 15, 15, 14, 59, 1, 2, 4, 4, 5, 4, 4, 4, 2); // 0x240
            private static Player Hal_Leeward = new Player(118, 94, 53, 62, 65, 53, 54, 57, 53, 397, 57, 55, 12, 13, 14, 14, 12, 14, 12, 55, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x241
            private static Player Arthur_Dox = new Player(122, 97, 56, 60, 44, 59, 56, 60, 53, 388, 50, 53, 11, 10, 13, 14, 12, 17, 9, 53, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x242
            private static Player Reese_Ickle = new Player(120, 96, 51, 56, 57, 54, 51, 56, 52, 377, 61, 62, 17, 13, 17, 16, 17, 14, 13, 62, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x243
            private static Player Finn_Attick = new Player(125, 110, 56, 56, 60, 61, 56, 62, 59, 410, 65, 64, 14, 16, 14, 16, 15, 16, 13, 64, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x244
            private static Player Col_Lector = new Player(120, 105, 53, 62, 55, 58, 54, 54, 53, 389, 55, 62, 7, 9, 10, 14, 7, 11, 7, 62, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x245
            private static Player Crispin_Shooter = new Player(135, 118, 39, 47, 63, 37, 50, 44, 50, 330, 50, 52, 6, 6, 17, 4, 8, 5, 6, 52, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x246
            private static Player Stu_Perstitious = new Player(106, 118, 44, 53, 61, 44, 57, 51, 51, 361, 49, 62, 10, 10, 17, 8, 9, 10, 8, 62, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x247
            private static Player Ashley_Fay = new Player(120, 99, 57, 53, 44, 50, 44, 54, 51, 353, 56, 49, 14, 11, 8, 7, 7, 11, 10, 49, 5, 1, 1, 1, 1, 5, 1, 1, 1); // 0x248
            private static Player Luke_Raffles = new Player(94, 116, 57, 55, 53, 51, 57, 60, 56, 389, 55, 49, 15, 8, 13, 16, 11, 10, 9, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x249
            private static Player Stu_Helmsley = new Player(111, 97, 53, 51, 57, 53, 57, 56, 54, 381, 59, 63, 14, 17, 15, 14, 17, 15, 14, 63, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x24A
            private static Player Terrence_Anthem = new Player(91, 133, 57, 53, 53, 56, 57, 58, 54, 388, 52, 53, 15, 8, 13, 14, 7, 10, 8, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x24B
            private static Player Gene_Bottle = new Player(121, 94, 57, 56, 44, 60, 51, 61, 51, 380, 45, 53, 7, 9, 14, 14, 13, 14, 11, 53, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x24C
            private static Player Sam_O_Reilly = new Player(131, 108, 57, 52, 46, 46, 44, 53, 53, 351, 50, 45, 17, 12, 10, 8, 9, 11, 8, 45, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x24D
            private static Player Ches_Nutcracker = new Player(118, 115, 62, 66, 61, 62, 66, 36, 62, 415, 44, 48, 14, 12, 12, 12, 12, 4, 14, 48, 1, 5, 2, 2, 2, 2, 1, 2, 1); // 0x24E
            private static Player Victor_Grand = new Player(91, 131, 59, 51, 56, 51, 55, 56, 51, 379, 53, 53, 14, 11, 13, 15, 10, 11, 11, 53, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x24F
            private static Player Ant_Hophila = new Player(91, 126, 49, 55, 53, 51, 62, 55, 55, 380, 49, 48, 13, 8, 11, 8, 15, 12, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x250
            private static Player Hunter_Glory = new Player(93, 124, 57, 62, 57, 62, 51, 53, 56, 398, 52, 68, 7, 9, 9, 15, 9, 11, 9, 68, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x251
            private static Player Joe_Rassock = new Player(113, 105, 46, 51, 59, 48, 56, 51, 56, 367, 56, 61, 10, 10, 16, 11, 11, 11, 9, 61, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x252
            private static Player Patch_Borgnine = new Player(91, 116, 39, 47, 50, 46, 51, 50, 46, 329, 50, 44, 9, 7, 8, 6, 12, 10, 6, 44, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x253
            private static Player Ted_Fast = new Player(135, 91, 51, 58, 45, 62, 51, 56, 55, 378, 49, 56, 10, 10, 14, 17, 14, 13, 7, 56, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x254
            private static Player Clay_Modlin = new Player(127, 101, 57, 56, 56, 57, 41, 59, 51, 377, 67, 52, 16, 10, 12, 13, 10, 8, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x255
            private static Player Alan_Mode = new Player(120, 87, 53, 54, 48, 44, 48, 57, 57, 361, 54, 42, 15, 12, 8, 9, 11, 9, 10, 42, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0x256
            private static Player Harry_Harper = new Player(122, 92, 45, 51, 56, 56, 56, 53, 51, 368, 45, 51, 10, 8, 8, 10, 17, 12, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x257
            private static Player Pascal_Richter = new Player(120, 94, 50, 56, 57, 47, 51, 56, 54, 371, 56, 51, 8, 10, 20, 8, 9, 8, 9, 51, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x258
            private static Player Beau_Fort = new Player(102, 116, 48, 48, 47, 56, 60, 51, 52, 362, 50, 49, 8, 11, 6, 10, 13, 12, 8, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x259
            private static Player Reid_Scarlet = new Player(91, 126, 56, 57, 50, 61, 52, 58, 54, 388, 44, 58, 7, 11, 10, 17, 11, 17, 11, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x25A
            private static Player Joe_Lamkin = new Player(118, 100, 51, 56, 53, 51, 57, 54, 53, 375, 62, 59, 15, 15, 16, 15, 17, 15, 14, 59, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x25B
            private static Player Dylan_Magpie = new Player(121, 101, 48, 51, 54, 55, 64, 59, 54, 385, 51, 54, 8, 11, 7, 8, 12, 14, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x25C
            private static Player Gil_Rivers = new Player(100, 117, 52, 56, 53, 57, 56, 55, 55, 384, 54, 52, 8, 8, 10, 13, 8, 10, 10, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x25D
            private static Player Des_Tiny = new Player(122, 101, 51, 51, 51, 55, 51, 57, 57, 373, 59, 63, 16, 16, 13, 14, 17, 13, 17, 63, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x25E
            private static Player Saul_Dowd = new Player(108, 116, 51, 53, 54, 52, 56, 51, 57, 374, 54, 54, 10, 13, 11, 14, 14, 12, 12, 54, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x25F
            private static Player Kit_Chapman = new Player(120, 100, 61, 55, 54, 52, 51, 57, 56, 386, 52, 52, 17, 11, 11, 17, 9, 9, 8, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x260
            private static Player Fry_Vollity = new Player(123, 99, 59, 51, 51, 52, 56, 59, 53, 381, 49, 52, 13, 9, 14, 16, 9, 7, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x261
            private static Player Clark_Roach = new Player(122, 97, 59, 52, 54, 56, 41, 57, 53, 372, 55, 48, 8, 11, 11, 12, 8, 9, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x262
            private static Player Samuel_Peeps = new Player(126, 94, 53, 60, 44, 60, 56, 57, 53, 383, 64, 52, 9, 11, 13, 15, 11, 14, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x263
            private static Player Dai_Hart = new Player(120, 110, 41, 43, 41, 41, 43, 41, 36, 286, 49, 46, 7, 8, 5, 8, 6, 4, 6, 46, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x264
            private static Player Horty_Courture = new Player(93, 123, 37, 48, 45, 48, 56, 48, 45, 327, 49, 42, 7, 8, 5, 7, 11, 10, 6, 42, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x265
            private static Player Bob_Baggum = new Player(109, 112, 49, 51, 59, 57, 53, 52, 57, 378, 52, 49, 9, 13, 14, 8, 8, 11, 9, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x266
            private static Player Ollie_Twister = new Player(117, 96, 55, 51, 56, 51, 51, 51, 56, 371, 56, 57, 14, 12, 14, 12, 14, 12, 13, 57, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x267
            private static Player Fred_Makepeace = new Player(123, 85, 44, 57, 37, 65, 45, 53, 44, 345, 46, 53, 6, 6, 9, 12, 7, 11, 8, 53, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x268
            private static Player Walker_Sleep = new Player(109, 116, 57, 56, 57, 53, 51, 51, 56, 381, 56, 55, 10, 12, 11, 13, 13, 10, 11, 55, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x269
            private static Player Sean_Trawler = new Player(124, 97, 54, 56, 57, 52, 51, 59, 52, 381, 60, 62, 15, 14, 13, 15, 13, 15, 17, 62, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x26A
            private static Player Ken_Sewer = new Player(99, 119, 47, 48, 46, 63, 46, 47, 48, 345, 51, 49, 8, 7, 9, 9, 9, 7, 7, 49, 5, 2, 2, 2, 5, 2, 2, 2, 2); // 0x26B
            private static Player Bamber_Shoot = new Player(120, 110, 45, 57, 59, 46, 51, 54, 54, 366, 54, 66, 10, 9, 15, 7, 9, 7, 8, 66, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x26C
            private static Player Sly_Winker = new Player(120, 101, 48, 40, 36, 57, 63, 51, 51, 346, 52, 54, 8, 9, 8, 9, 13, 11, 10, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x26D
            private static Player Teller_Scoap = new Player(127, 96, 49, 56, 53, 57, 62, 62, 51, 390, 64, 49, 11, 8, 10, 10, 12, 14, 11, 49, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x26E
            private static Player Sam_Firman = new Player(119, 97, 56, 52, 56, 54, 51, 60, 51, 380, 52, 48, 15, 9, 14, 13, 10, 8, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x26F
            private static Player Bear_Turnbull = new Player(118, 98, 50, 52, 56, 55, 57, 56, 51, 377, 48, 53, 11, 10, 9, 7, 18, 14, 8, 53, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x270
            private static Player Tabor_Drummond = new Player(99, 119, 44, 40, 37, 53, 56, 54, 54, 338, 55, 49, 9, 7, 7, 11, 17, 13, 11, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x271
            private static Player Brook_Atwater = new Player(110, 98, 54, 56, 52, 53, 51, 56, 55, 377, 60, 59, 15, 15, 14, 16, 13, 17, 13, 59, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x272
            private static Player Ike_Doerflinger = new Player(93, 122, 51, 56, 54, 56, 51, 53, 51, 372, 50, 48, 9, 11, 7, 13, 9, 12, 9, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x273
            private static Player Aessop_Fabel = new Player(94, 113, 58, 52, 51, 51, 56, 57, 56, 381, 52, 49, 16, 7, 10, 15, 11, 11, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x274
            private static Player Grant_Slammer = new Player(108, 130, 48, 54, 57, 45, 54, 52, 54, 364, 54, 52, 9, 12, 16, 10, 9, 7, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x275
            private static Player Robin_Cruise = new Player(122, 101, 58, 54, 53, 60, 39, 56, 53, 373, 56, 48, 7, 9, 11, 11, 10, 11, 10, 48, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x276
            private static Player Mark_Perfect = new Player(133, 95, 46, 56, 56, 56, 60, 59, 57, 390, 49, 52, 7, 8, 9, 11, 11, 12, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x277
            private static Player Rolly_Kerr = new Player(117, 93, 46, 57, 58, 47, 66, 51, 53, 378, 55, 49, 9, 13, 17, 9, 13, 11, 7, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x278
            private static Player Moses_Pumper = new Player(121, 94, 57, 60, 47, 62, 56, 60, 52, 394, 44, 56, 11, 7, 13, 16, 11, 15, 7, 56, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x279
            private static Player Knight_Reader = new Player(120, 99, 46, 48, 47, 63, 50, 49, 48, 351, 52, 51, 8, 10, 11, 10, 6, 11, 8, 51, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x27A
            private static Player Cash_Barganier = new Player(118, 101, 45, 41, 42, 51, 65, 42, 56, 342, 59, 53, 10, 10, 5, 11, 14, 8, 9, 53, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x27B
            private static Player Brendan_Branch = new Player(102, 119, 46, 54, 56, 56, 60, 53, 53, 378, 45, 48, 11, 11, 11, 10, 16, 10, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x27C
            private static Player Clark_Rain = new Player(115, 100, 46, 56, 61, 45, 55, 51, 51, 365, 51, 49, 9, 12, 17, 11, 8, 10, 10, 49, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x27D
            private static Player Luther_Rio = new Player(122, 96, 47, 53, 53, 51, 58, 61, 56, 379, 46, 54, 9, 10, 11, 10, 10, 11, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x27E
            private static Player Florian_Hutter = new Player(119, 117, 53, 52, 51, 53, 55, 57, 54, 375, 57, 68, 10, 13, 13, 12, 11, 11, 13, 68, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x27F
            private static Player Scamp_Shrimplin = new Player(115, 97, 48, 54, 60, 47, 51, 51, 56, 367, 49, 54, 8, 14, 15, 9, 11, 7, 11, 54, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x280
            private static Player Adam_Nesiac = new Player(117, 100, 60, 62, 53, 65, 51, 56, 53, 400, 55, 59, 13, 12, 11, 11, 14, 14, 11, 59, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0x281
            private static Player Rab_Acus = new Player(118, 117, 48, 57, 51, 51, 58, 54, 54, 373, 45, 49, 13, 8, 11, 9, 15, 12, 10, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x282
            private static Player Chris_Miles = new Player(134, 115, 54, 61, 56, 56, 51, 54, 53, 385, 55, 49, 9, 7, 10, 17, 10, 12, 7, 49, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x283
            private static Player Shemmy_Ramis = new Player(124, 91, 56, 56, 56, 56, 57, 57, 53, 391, 55, 51, 13, 9, 13, 14, 8, 16, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x284
            private static Player Lon_Grainger = new Player(128, 97, 56, 51, 53, 51, 57, 63, 56, 387, 62, 54, 15, 8, 10, 15, 10, 16, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x285
            private static Player Manny_Atom = new Player(128, 98, 60, 55, 52, 60, 58, 56, 52, 393, 66, 51, 8, 9, 9, 13, 14, 13, 8, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x286
            private static Player Bill_Tardy = new Player(94, 128, 57, 57, 53, 56, 51, 56, 55, 385, 50, 51, 14, 9, 13, 13, 9, 11, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x287
            private static Player Fox_Copier = new Player(106, 112, 56, 51, 53, 52, 51, 53, 56, 372, 61, 69, 13, 15, 13, 13, 16, 17, 17, 69, 2, 2, 2, 2, 2, 2, 5, 2, 1); // 0x288
            private static Player Cletus_Badden = new Player(124, 101, 54, 53, 52, 51, 53, 57, 53, 373, 62, 57, 14, 16, 16, 16, 16, 14, 15, 57, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x289
            private static Player Skip_Sofrenic = new Player(130, 97, 56, 59, 49, 56, 52, 67, 56, 395, 70, 57, 11, 7, 12, 13, 12, 21, 11, 57, 1, 1, 5, 1, 5, 1, 5, 1, 1); // 0x28A
            private static Player Mat_Char = new Player(132, 96, 44, 54, 51, 53, 62, 52, 57, 373, 47, 47, 12, 9, 7, 9, 15, 13, 10, 47, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x28B
            private static Player Trey_Cultivator = new Player(120, 106, 45, 53, 63, 50, 56, 57, 56, 380, 54, 62, 9, 8, 14, 11, 11, 10, 10, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x28C
            private static Player Vinny_Trioquist = new Player(120, 110, 56, 51, 47, 47, 44, 54, 52, 351, 52, 45, 15, 13, 10, 11, 9, 9, 11, 45, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x28D
            private static Player Ton_Nino = new Player(112, 99, 59, 56, 57, 53, 53, 62, 57, 397, 56, 45, 18, 15, 11, 14, 11, 12, 14, 45, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x28E
            private static Player Oscar_Esher = new Player(120, 109, 41, 38, 36, 41, 42, 39, 39, 276, 48, 42, 8, 8, 8, 6, 6, 8, 8, 42, 2, 2, 2, 2, 2, 2, 5, 2, 2); // 0x28F
            private static Player Saul_Searcher = new Player(131, 99, 47, 55, 54, 57, 59, 51, 52, 375, 48, 51, 14, 10, 7, 8, 15, 12, 11, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x290
            private static Player Gerry_Attrick = new Player(92, 124, 56, 59, 46, 62, 57, 56, 56, 392, 48, 54, 10, 11, 12, 16, 12, 15, 11, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x291
            private static Player Adam_Icklock = new Player(93, 132, 47, 46, 45, 48, 45, 45, 46, 322, 53, 49, 8, 9, 7, 8, 9, 7, 10, 49, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x292
            private static Player Sol_Stiss = new Player(124, 105, 48, 57, 58, 44, 56, 57, 51, 371, 55, 63, 9, 8, 13, 9, 7, 8, 9, 63, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x293
            private static Player Des_Ainer = new Player(118, 102, 62, 56, 56, 57, 40, 56, 55, 382, 64, 60, 15, 15, 13, 14, 5, 16, 14, 60, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x294
            private static Player Homer_Sockshell = new Player(107, 127, 56, 58, 53, 61, 51, 56, 57, 392, 50, 54, 11, 9, 8, 16, 9, 13, 11, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x295
            private static Player Harley_Trotter = new Player(120, 95, 62, 53, 53, 55, 56, 62, 52, 393, 53, 51, 15, 10, 11, 16, 10, 11, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x296
            private static Player Mark_Skidfree = new Player(93, 123, 56, 57, 55, 57, 48, 62, 54, 389, 51, 50, 11, 9, 8, 11, 10, 8, 8, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x297
            private static Player Del_Iverryboy = new Player(118, 93, 52, 53, 58, 47, 52, 52, 54, 368, 55, 54, 7, 14, 15, 8, 9, 11, 8, 54, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x298
            private static Player Scean_Spector = new Player(93, 124, 48, 38, 36, 53, 57, 53, 56, 341, 56, 48, 8, 11, 4, 10, 15, 11, 9, 48, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x299
            private static Player Nick_Knack = new Player(111, 92, 51, 52, 60, 48, 51, 54, 56, 372, 52, 51, 7, 12, 14, 8, 10, 7, 11, 51, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x29A
            private static Player Dusty_Rellicks = new Player(119, 93, 48, 56, 56, 53, 63, 56, 51, 383, 44, 51, 7, 9, 10, 9, 11, 10, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x29B
            private static Player Sandy_Insolls = new Player(123, 92, 46, 44, 47, 51, 59, 62, 54, 363, 67, 50, 9, 10, 5, 10, 13, 18, 11, 50, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x29C
            private static Player Gregory_Bones = new Player(121, 91, 49, 56, 51, 56, 60, 59, 57, 388, 49, 51, 7, 9, 10, 9, 13, 14, 11, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x29D
            private static Player Loughrey_Mose = new Player(99, 124, 66, 61, 57, 51, 51, 63, 56, 405, 54, 49, 15, 13, 11, 11, 14, 12, 14, 49, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x29E
            private static Player Willow_Withers = new Player(119, 100, 45, 53, 55, 53, 56, 57, 65, 384, 46, 52, 11, 7, 8, 10, 14, 10, 19, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x29F
            private static Player Winn_deBreeze = new Player(105, 128, 57, 51, 51, 56, 51, 51, 56, 373, 58, 55, 12, 11, 12, 14, 12, 12, 12, 55, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x2A0
            private static Player Buster_Clout = new Player(120, 101, 56, 57, 57, 61, 55, 53, 57, 396, 52, 49, 9, 16, 9, 13, 10, 11, 9, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2A1
            private static Player Errol_Lorre = new Player(115, 114, 56, 57, 51, 53, 51, 56, 54, 378, 49, 54, 9, 10, 8, 9, 11, 9, 9, 54, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x2A2
            private static Player Fred_Ferrell = new Player(130, 91, 56, 51, 55, 58, 39, 66, 53, 378, 52, 53, 9, 10, 11, 10, 10, 8, 9, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2A3
            private static Player Rod_Headstock = new Player(134, 97, 55, 55, 44, 46, 45, 55, 53, 353, 55, 45, 17, 14, 8, 8, 11, 10, 11, 45, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x2A4
            private static Player Tim_Piece = new Player(116, 97, 48, 56, 52, 56, 59, 56, 57, 384, 57, 49, 12, 8, 9, 8, 15, 11, 8, 49, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2A5
            private static Player Patrick_Edie = new Player(124, 95, 50, 54, 63, 44, 56, 53, 51, 371, 52, 53, 8, 11, 14, 10, 8, 10, 10, 53, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2A6
            private static Player Art_Teest = new Player(91, 124, 51, 58, 50, 62, 53, 58, 51, 383, 47, 58, 8, 11, 14, 13, 12, 17, 11, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2A7
            private static Player Bill_Mumm = new Player(121, 106, 53, 65, 60, 62, 48, 63, 60, 411, 57, 52, 17, 12, 14, 16, 14, 17, 12, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x2A8
            private static Player Luke_O_Cyte = new Player(91, 127, 56, 51, 52, 59, 41, 57, 54, 370, 52, 52, 8, 7, 9, 11, 8, 9, 7, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2A9
            private static Player Ernest_Byer = new Player(127, 110, 53, 54, 51, 54, 56, 66, 56, 390, 54, 57, 14, 13, 14, 10, 12, 14, 13, 57, 2, 4, 4, 4, 4, 5, 2, 4, 1); // 0x2AA
            private static Player Isaac_Goss = new Player(104, 118, 57, 51, 54, 51, 52, 54, 53, 372, 57, 57, 12, 10, 13, 11, 12, 13, 13, 57, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x2AB
            private static Player Walter_Poseur = new Player(119, 97, 46, 56, 57, 56, 60, 56, 53, 384, 45, 51, 11, 8, 9, 9, 13, 13, 7, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2AC
            private static Player Andy_Roff = new Player(122, 91, 51, 62, 47, 56, 56, 61, 52, 385, 47, 56, 10, 10, 12, 15, 14, 16, 10, 56, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2AD
            private static Player Ashley_Dale = new Player(126, 103, 52, 56, 66, 56, 62, 56, 60, 408, 57, 58, 11, 13, 17, 12, 12, 12, 12, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2AE
            private static Player Rich_Cave = new Player(122, 101, 46, 57, 55, 53, 57, 62, 57, 387, 44, 50, 7, 9, 8, 10, 13, 10, 11, 50, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x2AF
            private static Player Taka_Tanaka = new Player(131, 97, 57, 54, 53, 57, 39, 60, 54, 374, 54, 49, 8, 11, 8, 17, 7, 9, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B0
            private static Player Manny_Carbs = new Player(111, 95, 50, 53, 60, 45, 51, 55, 52, 366, 54, 48, 7, 12, 16, 8, 10, 8, 8, 48, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2B1
            private static Player Al_Reddie = new Player(124, 109, 49, 51, 56, 50, 57, 57, 53, 373, 50, 60, 9, 13, 16, 7, 10, 9, 11, 60, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2B2
            private static Player Rush_Tooset = new Player(133, 93, 61, 51, 57, 57, 52, 59, 51, 388, 52, 52, 16, 11, 12, 17, 9, 8, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2B3
            private static Player Rod_Opsin = new Player(124, 97, 56, 51, 54, 51, 53, 62, 56, 383, 62, 52, 14, 8, 12, 13, 10, 11, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B4
            private static Player Peyton_Pope = new Player(94, 112, 56, 57, 51, 54, 51, 57, 56, 382, 56, 47, 17, 7, 12, 15, 11, 8, 8, 47, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2B5
            private static Player Drew_Straws = new Player(118, 92, 56, 51, 53, 53, 57, 54, 51, 375, 64, 59, 13, 13, 16, 13, 16, 13, 14, 59, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0x2B6
            private static Player Trey_Dalbum = new Player(120, 90, 51, 52, 44, 49, 47, 57, 56, 356, 53, 46, 15, 11, 9, 8, 9, 8, 7, 46, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x2B7
            private static Player Harly_Profett = new Player(122, 100, 56, 56, 56, 58, 39, 57, 55, 377, 54, 49, 11, 11, 8, 13, 8, 15, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x2B8
            private static Player Hank_O_Buff = new Player(120, 94, 47, 56, 56, 57, 59, 60, 51, 386, 45, 52, 7, 10, 10, 10, 12, 12, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2B9
            private static Player Ash_Cloud = new Player(91, 118, 44, 55, 56, 57, 56, 62, 51, 381, 44, 52, 7, 8, 8, 11, 11, 13, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2BA
            private static Player Stan_Dupp = new Player(126, 93, 54, 59, 48, 60, 51, 61, 52, 385, 54, 52, 9, 9, 14, 15, 13, 15, 7, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2BB
            private static Player Max_Bright = new Player(106, 126, 50, 46, 44, 53, 60, 51, 54, 358, 49, 51, 9, 7, 5, 7, 13, 12, 7, 51, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x2BC
            private static Player Bill_Phee = new Player(126, 91, 62, 51, 51, 56, 56, 61, 56, 393, 50, 54, 17, 10, 11, 14, 9, 11, 7, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2BD
            private static Player Lee_Figreene = new Player(110, 101, 45, 51, 58, 46, 57, 53, 53, 363, 55, 48, 10, 11, 16, 8, 9, 10, 10, 48, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x2BE
            private static Player Den_Taligene = new Player(124, 88, 63, 49, 50, 48, 50, 44, 62, 366, 52, 51, 11, 8, 9, 8, 9, 9, 7, 51, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x2BF
            private static Player Adam_Hesive = new Player(124, 99, 51, 62, 53, 56, 57, 56, 51, 386, 53, 51, 11, 21, 9, 21, 10, 14, 10, 51, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C0
            private static Player Mel_Lowe = new Player(91, 124, 60, 66, 55, 64, 56, 66, 59, 426, 48, 61, 10, 10, 14, 20, 16, 20, 11, 61, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C1
            private static Player Rip_Winkle = new Player(92, 123, 60, 58, 55, 58, 40, 62, 54, 387, 49, 52, 11, 14, 9, 13, 8, 7, 8, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2C2
            private static Player Ben_deLimms = new Player(94, 116, 47, 56, 54, 54, 57, 53, 51, 372, 51, 53, 13, 11, 9, 9, 13, 11, 8, 53, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2C3
            private static Player Pauly_Ontology = new Player(90, 130, 44, 38, 40, 52, 57, 57, 52, 340, 54, 49, 8, 10, 6, 9, 13, 11, 11, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2C4
            private static Player Walter_Mendip = new Player(99, 120, 56, 57, 44, 50, 45, 52, 55, 359, 52, 45, 15, 12, 10, 7, 7, 11, 7, 45, 5, 1, 1, 1, 1, 5, 1, 1, 2); // 0x2C5
            private static Player Bud_Hunter = new Player(133, 92, 48, 53, 55, 51, 57, 58, 53, 375, 46, 54, 11, 10, 10, 8, 10, 11, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2C6
            private static Player Sonny_Rentman = new Player(120, 110, 53, 62, 56, 61, 57, 57, 54, 400, 54, 47, 9, 10, 8, 16, 8, 13, 7, 47, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C7
            private static Player Cam_Vass = new Player(113, 98, 45, 56, 56, 47, 51, 56, 51, 362, 49, 52, 7, 12, 16, 10, 7, 9, 11, 52, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2C8
            private static Player Shay_Chez = new Player(133, 101, 53, 59, 55, 56, 57, 51, 57, 388, 55, 52, 8, 9, 9, 13, 9, 11, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2C9
            private static Player Cory_Andish = new Player(91, 117, 55, 62, 48, 61, 57, 57, 54, 394, 49, 57, 8, 8, 14, 17, 12, 16, 10, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CA
            private static Player Glen_Adeer = new Player(135, 101, 57, 56, 56, 60, 53, 53, 53, 388, 53, 48, 8, 8, 7, 15, 10, 14, 9, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CB
            private static Player Norry_Sheets = new Player(121, 97, 54, 60, 45, 62, 53, 56, 56, 386, 49, 58, 10, 11, 12, 14, 12, 16, 11, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2CC
            private static Player Lou_Paster = new Player(126, 117, 54, 57, 57, 53, 56, 62, 53, 392, 57, 55, 12, 12, 11, 12, 13, 11, 11, 55, 2, 4, 4, 4, 5, 4, 2, 4, 1); // 0x2CD
            private static Player Aran_Cheeks = new Player(114, 106, 50, 57, 58, 45, 54, 57, 57, 378, 52, 48, 10, 13, 17, 11, 8, 11, 9, 48, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2CE
            private static Player Abe_Seiler = new Player(118, 97, 62, 56, 56, 52, 52, 56, 51, 385, 55, 49, 14, 10, 14, 16, 9, 8, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2CF
            private static Player Al_Urgy = new Player(122, 91, 57, 60, 47, 56, 53, 60, 56, 389, 44, 57, 9, 11, 12, 15, 11, 16, 10, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2D0
            private static Player Conn_Pass = new Player(118, 101, 47, 56, 65, 44, 52, 53, 53, 370, 55, 63, 11, 9, 15, 11, 9, 8, 9, 63, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2D1
            private static Player Heath_Cover = new Player(102, 120, 52, 47, 50, 49, 48, 46, 51, 343, 51, 53, 10, 10, 10, 11, 9, 7, 9, 53, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x2D2
            private static Player Mack_Ramey = new Player(120, 112, 56, 51, 48, 46, 48, 56, 51, 356, 50, 48, 14, 13, 8, 10, 11, 9, 7, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x2D3
            private static Player Miles_Ryan = new Player(127, 114, 55, 48, 47, 61, 65, 58, 59, 393, 60, 59, 11, 13, 6, 11, 19, 14, 11, 59, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2D4
            private static Player Ike_Banner = new Player(120, 120, 55, 63, 50, 48, 47, 56, 54, 373, 49, 45, 15, 10, 8, 9, 10, 9, 10, 45, 5, 1, 1, 1, 1, 5, 1, 1, 2); // 0x2D5
            private static Player Frank_Meyer = new Player(120, 110, 52, 57, 51, 57, 57, 53, 56, 383, 49, 53, 11, 8, 9, 15, 9, 14, 9, 53, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2D6
            private static Player Phil_Fog = new Player(120, 95, 60, 56, 51, 53, 56, 60, 57, 393, 64, 48, 16, 8, 11, 16, 7, 9, 11, 48, 1, 2, 1, 5, 2, 5, 2, 1, 3); // 0x2D7
            private static Player Bob_Lioteck = new Player(110, 101, 54, 51, 54, 53, 57, 56, 51, 376, 55, 58, 13, 14, 12, 12, 13, 12, 12, 58, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x2D8
            private static Player Rory_Polisher = new Player(124, 96, 48, 55, 56, 45, 54, 56, 57, 371, 52, 50, 10, 11, 14, 10, 8, 9, 8, 50, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2D9
            private static Player Tex_Curvator = new Player(94, 126, 51, 62, 51, 60, 57, 51, 56, 388, 51, 48, 9, 10, 8, 16, 9, 10, 11, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DA
            private static Player Perry_Pincher = new Player(118, 95, 54, 53, 53, 51, 55, 57, 56, 379, 59, 52, 13, 11, 11, 14, 13, 13, 13, 52, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x2DB
            private static Player Al_Plates = new Player(122, 93, 46, 55, 58, 50, 57, 54, 56, 376, 54, 51, 9, 11, 14, 8, 11, 11, 8, 51, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x2DC
            private static Player Bane_Marie = new Player(120, 115, 51, 60, 54, 56, 53, 54, 54, 382, 52, 47, 8, 7, 8, 15, 11, 11, 10, 47, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DD
            private static Player Cam_Broadsheet = new Player(122, 96, 46, 56, 56, 53, 56, 62, 51, 380, 50, 48, 8, 10, 10, 9, 12, 12, 7, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x2DE
            private static Player Mo_Hawkes = new Player(121, 95, 56, 61, 48, 57, 56, 57, 56, 391, 49, 54, 8, 11, 11, 17, 12, 15, 10, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2DF
            private static Player Chris_Pecracker = new Player(118, 100, 51, 54, 59, 46, 52, 56, 57, 375, 52, 62, 10, 10, 14, 10, 9, 9, 8, 62, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2E0
            private static Player Andy_Crafter = new Player(99, 136, 53, 53, 51, 56, 54, 56, 55, 378, 59, 57, 14, 14, 12, 12, 11, 14, 14, 57, 4, 4, 4, 4, 5, 4, 4, 4, 3); // 0x2E1
            private static Player Boe_Tyer = new Player(111, 99, 49, 55, 59, 50, 51, 57, 57, 378, 55, 63, 8, 8, 15, 7, 8, 11, 11, 63, 1, 5, 2, 2, 5, 1, 4, 1, 1); // 0x2E2
            private static Player Dave_O_Resis = new Player(108, 119, 48, 51, 48, 46, 50, 53, 51, 347, 52, 51, 9, 9, 9, 9, 11, 7, 10, 51, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x2E3
            private static Player Victor_Mancey = new Player(120, 100, 53, 57, 56, 59, 53, 52, 51, 381, 53, 53, 8, 11, 9, 16, 9, 11, 11, 53, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2E4
            private static Player Ray_Dioset = new Player(137, 97, 59, 51, 51, 59, 50, 59, 55, 384, 56, 48, 10, 8, 11, 12, 9, 10, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2E5
            private static Player Preston_Gumbs = new Player(124, 121, 56, 57, 53, 47, 48, 57, 57, 375, 52, 44, 15, 12, 10, 8, 8, 10, 9, 44, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x2E6
            private static Player Tiny_Forester = new Player(118, 94, 53, 57, 62, 48, 56, 57, 56, 389, 49, 51, 11, 13, 15, 8, 7, 9, 9, 51, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2E7
            private static Player Cardin_Hands = new Player(122, 98, 56, 51, 51, 57, 50, 62, 52, 379, 54, 48, 10, 10, 9, 10, 8, 11, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x2E8
            private static Player Callan_Trens = new Player(120, 100, 57, 56, 54, 59, 53, 51, 54, 384, 53, 49, 10, 8, 9, 14, 9, 12, 9, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x2E9
            private static Player Tim_Mittus = new Player(121, 91, 60, 53, 57, 53, 51, 59, 56, 389, 50, 54, 17, 9, 11, 13, 11, 7, 11, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EA
            private static Player Keenan_Brainard = new Player(91, 127, 51, 60, 45, 56, 57, 57, 53, 379, 48, 54, 9, 9, 13, 17, 14, 14, 8, 54, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x2EB
            private static Player Orson_Douvre = new Player(120, 98, 62, 51, 51, 57, 51, 60, 51, 383, 50, 48, 14, 10, 14, 16, 9, 7, 10, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EC
            private static Player Sandy_Hope = new Player(138, 93, 60, 54, 51, 62, 39, 56, 57, 379, 52, 51, 9, 9, 10, 13, 8, 9, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2ED
            private static Player Ort_Omaton = new Player(119, 101, 57, 52, 56, 56, 63, 62, 51, 397, 54, 49, 10, 9, 8, 12, 18, 7, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x2EE
            private static Player Clerk_Welcome = new Player(120, 87, 62, 63, 50, 48, 50, 45, 50, 368, 50, 48, 9, 11, 9, 10, 7, 9, 9, 48, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x2EF
            private static Player Rob_Ottman = new Player(120, 99, 54, 51, 53, 48, 52, 52, 54, 364, 54, 46, 15, 13, 10, 9, 7, 11, 10, 46, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x2F0
            private static Player Cam_O_Miles = new Player(122, 92, 62, 51, 53, 57, 36, 57, 53, 369, 49, 49, 11, 9, 7, 13, 8, 9, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x2F1
            private static Player Jack_Pott = new Player(120, 99, 52, 56, 51, 52, 56, 57, 51, 375, 54, 57, 13, 12, 12, 12, 12, 10, 13, 57, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x2F2
            private static Player Florian_Selles = new Player(117, 99, 51, 56, 55, 57, 55, 51, 51, 376, 62, 63, 14, 16, 16, 15, 16, 17, 17, 63, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x2F3
            private static Player Finn_Sawyer = new Player(117, 93, 48, 55, 65, 47, 57, 55, 55, 382, 50, 47, 10, 10, 17, 8, 8, 9, 9, 47, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x2F4
            private static Player Bobby_Constable = new Player(120, 101, 56, 56, 57, 57, 51, 56, 52, 385, 61, 64, 15, 13, 15, 15, 15, 14, 15, 64, 2, 5, 2, 2, 2, 2, 2, 2, 2); // 0x2F5
            private static Player Ray_Menn = new Player(94, 119, 47, 57, 53, 56, 60, 57, 56, 386, 47, 52, 10, 7, 8, 10, 10, 12, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2F6
            private static Player Odo_Toilette = new Player(122, 96, 46, 56, 55, 54, 59, 57, 51, 378, 50, 54, 7, 7, 9, 10, 12, 11, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x2F7
            private static Player Tel_Egram = new Player(105, 122, 48, 56, 57, 45, 57, 57, 54, 374, 56, 47, 8, 11, 16, 9, 11, 10, 7, 47, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2F8
            private static Player Char_Shumaker = new Player(122, 92, 56, 56, 55, 54, 54, 55, 53, 383, 64, 60, 17, 17, 16, 16, 14, 14, 13, 60, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x2F9
            private static Player Sim_Pathy = new Player(109, 110, 65, 54, 58, 44, 54, 57, 53, 385, 53, 62, 9, 10, 16, 9, 9, 10, 11, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x2FA
            private static Player Jon_Driedon = new Player(126, 115, 39, 53, 56, 57, 54, 61, 65, 385, 56, 59, 7, 13, 12, 13, 10, 14, 11, 59, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x2FB
            private static Player Monty_Burrows = new Player(99, 127, 37, 39, 59, 42, 56, 54, 58, 345, 50, 54, 11, 10, 16, 9, 13, 14, 10, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x2FC
            private static Player Gaston_Berry = new Player(125, 109, 45, 42, 42, 39, 63, 62, 57, 350, 55, 49, 9, 6, 7, 5, 17, 11, 9, 49, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x2FD
            private static Player Cruz_Ligner = new Player(120, 100, 55, 51, 51, 56, 57, 55, 54, 379, 54, 52, 13, 12, 13, 13, 14, 10, 12, 52, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x2FE
            private static Player Irv_Washinton = new Player(133, 90, 46, 44, 50, 45, 46, 50, 47, 328, 53, 53, 9, 10, 10, 9, 9, 9, 11, 53, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x2FF
            private static Player Shem_Bassey = new Player(107, 116, 52, 51, 53, 56, 53, 56, 57, 378, 59, 58, 11, 11, 10, 10, 12, 13, 10, 58, 4, 4, 4, 4, 4, 4, 4, 5, 1); // 0x300
            private static Player Pres_Cripton = new Player(120, 101, 53, 58, 51, 56, 51, 51, 57, 377, 55, 48, 11, 11, 10, 15, 10, 11, 9, 48, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x301
            private static Player Winston_Windfall = new Player(122, 91, 50, 48, 44, 57, 60, 54, 51, 364, 50, 52, 9, 9, 4, 8, 16, 12, 9, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x302
            private static Player Rich_Eden = new Player(137, 99, 55, 62, 52, 58, 53, 51, 56, 387, 55, 51, 7, 7, 11, 17, 7, 14, 9, 51, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x303
            private static Player Teagen_Brewer = new Player(106, 123, 48, 45, 44, 56, 60, 54, 53, 360, 52, 49, 11, 8, 6, 11, 15, 12, 9, 49, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x304
            private static Player Ry_Sling = new Player(119, 115, 47, 53, 62, 46, 57, 53, 52, 370, 52, 58, 7, 9, 17, 7, 7, 11, 9, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x305
            private static Player Bard_Crooner = new Player(121, 86, 53, 48, 48, 56, 44, 52, 51, 352, 44, 45, 4, 7, 6, 10, 8, 7, 5, 45, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x306
            private static Player Armstrong_Peck = new Player(99, 113, 51, 48, 52, 54, 45, 52, 48, 350, 48, 43, 8, 8, 6, 9, 6, 8, 8, 43, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x307
            private static Player Carey_Vanpark = new Player(120, 120, 50, 46, 47, 53, 54, 57, 51, 358, 47, 43, 5, 4, 5, 4, 7, 9, 6, 43, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x308
            private static Player Garland_Gathers = new Player(131, 89, 53, 46, 51, 46, 51, 56, 47, 350, 47, 46, 12, 8, 10, 14, 7, 6, 5, 46, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x309
            private static Player David_Burnum = new Player(93, 117, 46, 50, 51, 47, 48, 47, 49, 338, 48, 45, 4, 9, 13, 7, 8, 7, 7, 45, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x30A
            private static Player Tad_Trinket = new Player(108, 118, 46, 48, 51, 45, 51, 51, 48, 340, 51, 55, 5, 7, 11, 8, 8, 7, 8, 55, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x30B
            private static Player Harvey_Lifter = new Player(134, 121, 51, 51, 50, 51, 51, 47, 51, 352, 50, 51, 11, 9, 9, 9, 7, 10, 8, 51, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x30C
            private static Player Kurt_Price = new Player(99, 133, 47, 48, 48, 50, 44, 45, 45, 327, 48, 43, 5, 6, 5, 6, 4, 7, 8, 43, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x30D
            private static Player Cameron_Hameha = new Player(121, 86, 46, 49, 54, 46, 47, 53, 50, 345, 45, 48, 4, 9, 14, 8, 6, 5, 6, 48, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x30E
            private static Player Will_Stonehead = new Player(120, 101, 62, 54, 54, 59, 50, 62, 55, 396, 49, 51, 10, 10, 9, 10, 10, 8, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x30F
            private static Player Hugh_Marble = new Player(92, 135, 56, 55, 47, 47, 47, 52, 56, 360, 52, 48, 17, 14, 9, 10, 9, 9, 8, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x310
            private static Player Urson_Brown = new Player(124, 112, 54, 56, 44, 48, 45, 55, 53, 355, 52, 47, 15, 10, 10, 9, 9, 11, 11, 47, 5, 1, 5, 1, 1, 1, 1, 1, 2); // 0x311
            private static Player Bo_Luger = new Player(117, 98, 66, 53, 52, 53, 52, 54, 56, 386, 59, 55, 18, 14, 12, 14, 14, 13, 10, 55, 4, 5, 4, 4, 4, 4, 4, 4, 1); // 0x312
            private static Player Kim_Ono = new Player(93, 123, 51, 56, 64, 56, 56, 53, 53, 389, 52, 52, 8, 11, 7, 17, 9, 11, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x313
            private static Player Bully_Thrower = new Player(122, 101, 46, 52, 61, 44, 56, 53, 54, 366, 52, 54, 10, 10, 16, 9, 10, 10, 11, 54, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x314
            private static Player Bill_Wordsworthy = new Player(99, 129, 47, 63, 44, 45, 45, 44, 47, 335, 54, 52, 9, 9, 10, 9, 9, 7, 9, 52, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x315
            private static Player Mo_Lusk = new Player(124, 117, 53, 56, 56, 62, 51, 57, 53, 388, 56, 48, 7, 8, 10, 17, 10, 14, 10, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x316
            private static Player Ben_Curd = new Player(122, 100, 62, 66, 54, 67, 60, 60, 59, 428, 51, 61, 13, 11, 13, 17, 16, 17, 10, 61, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x317
            private static Player Powers_Squatts = new Player(126, 101, 57, 57, 44, 62, 36, 56, 53, 365, 65, 55, 9, 10, 14, 13, 5, 13, 9, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x318
            private static Player Paisley_Onepiece = new Player(118, 99, 57, 56, 50, 56, 51, 56, 56, 382, 47, 57, 10, 11, 12, 17, 13, 15, 11, 57, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x319
            private static Player Gauge_Diven = new Player(122, 113, 52, 56, 55, 56, 54, 53, 53, 379, 55, 65, 11, 11, 11, 17, 8, 11, 7, 65, 2, 1, 5, 1, 5, 1, 1, 1, 1); // 0x31A
            private static Player Zane_Laughead = new Player(130, 99, 53, 57, 46, 62, 54, 60, 52, 384, 64, 52, 8, 9, 11, 17, 12, 13, 8, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x31B
            private static Player Daz_Tighthead = new Player(116, 107, 60, 65, 57, 61, 57, 62, 58, 420, 55, 57, 12, 12, 10, 18, 10, 15, 12, 57, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x31C
            private static Player Sandy_Beecher = new Player(119, 93, 56, 55, 51, 55, 54, 59, 57, 387, 52, 54, 16, 9, 12, 14, 9, 11, 11, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x31D
            private static Player Ty_Priter = new Player(127, 101, 62, 51, 56, 51, 57, 56, 52, 385, 55, 53, 17, 10, 10, 17, 9, 8, 11, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x31E
            private static Player Nick_Savers = new Player(91, 134, 62, 62, 60, 63, 44, 65, 59, 415, 59, 53, 13, 12, 13, 13, 12, 10, 11, 53, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x31F
            private static Player Percy_Wrench = new Player(120, 106, 57, 56, 48, 48, 44, 56, 55, 364, 52, 43, 15, 12, 9, 9, 10, 7, 8, 43, 5, 1, 1, 1, 5, 1, 1, 1, 3); // 0x320
            private static Player Max_Scara = new Player(133, 118, 57, 57, 44, 44, 44, 51, 51, 348, 52, 43, 15, 11, 9, 8, 9, 8, 11, 43, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x321
            private static Player Jonny_Strutt = new Player(136, 87, 44, 48, 51, 53, 54, 48, 47, 345, 48, 44, 11, 4, 8, 6, 13, 8, 7, 44, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x322
            private static Player Larry_Oldman = new Player(91, 118, 41, 49, 46, 44, 51, 52, 44, 327, 48, 44, 5, 8, 6, 7, 9, 10, 8, 44, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x323
            private static Player Dom_Anding = new Player(122, 99, 51, 56, 45, 57, 56, 61, 57, 383, 49, 59, 7, 10, 14, 16, 14, 13, 7, 59, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x324
            private static Player Pip_Goodweather = new Player(99, 119, 51, 55, 54, 55, 56, 56, 51, 378, 55, 57, 13, 10, 10, 11, 12, 14, 12, 57, 4, 4, 5, 4, 4, 4, 4, 4, 2); // 0x325
            private static Player Bamber_Mandrina = new Player(128, 101, 39, 62, 38, 66, 41, 67, 38, 351, 48, 45, 8, 5, 5, 5, 7, 8, 7, 45, 1, 1, 5, 1, 4, 1, 4, 1, 1); // 0x326
            private static Player Scrap_Salvadge = new Player(100, 134, 56, 54, 46, 46, 60, 54, 51, 367, 53, 45, 17, 11, 11, 10, 8, 7, 8, 45, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x327
            private static Player Michael_Angeloni = new Player(115, 102, 44, 56, 64, 47, 56, 53, 56, 376, 49, 54, 10, 13, 17, 11, 9, 9, 11, 54, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x328
            private static Player Ryder_Wheeling = new Player(120, 103, 56, 53, 49, 46, 48, 53, 49, 354, 47, 48, 12, 4, 11, 14, 6, 8, 6, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x329
            private static Player Stu_Venier = new Player(126, 99, 44, 55, 54, 51, 57, 60, 52, 373, 48, 53, 11, 8, 10, 8, 12, 12, 9, 53, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x32A
            private static Player Linden_Dray = new Player(111, 96, 44, 54, 58, 47, 54, 53, 56, 366, 52, 52, 11, 10, 17, 7, 11, 9, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x32B
            private static Player Patsy_Cornish = new Player(110, 102, 44, 53, 57, 45, 54, 57, 54, 364, 54, 54, 8, 11, 16, 8, 11, 7, 8, 54, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x32C
            private static Player Sharkey_Gobble = new Player(118, 97, 52, 57, 55, 56, 54, 54, 51, 379, 64, 58, 16, 17, 16, 15, 13, 14, 16, 58, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x32D
            private static Player Olly_Popman = new Player(121, 102, 60, 57, 56, 54, 51, 56, 57, 391, 54, 53, 15, 11, 13, 15, 8, 10, 11, 53, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x32E
            private static Player Tyche_Winham = new Player(122, 99, 56, 53, 55, 54, 57, 56, 51, 382, 51, 48, 17, 11, 12, 13, 9, 10, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x32F
            private static Player Page_Helper = new Player(122, 93, 49, 53, 54, 55, 66, 52, 51, 380, 51, 54, 13, 10, 10, 9, 16, 12, 11, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x330
            private static Player Barry_Lugh = new Player(92, 118, 45, 54, 55, 52, 58, 60, 57, 381, 50, 48, 8, 8, 10, 11, 14, 11, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x331
            private static Player Jen_Quibble = new Player(91, 126, 53, 60, 44, 62, 57, 60, 54, 390, 44, 58, 10, 9, 13, 15, 12, 13, 8, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x332
            private static Player Dan_Drobium = new Player(115, 99, 51, 56, 57, 51, 53, 57, 54, 379, 61, 61, 15, 15, 15, 13, 13, 14, 15, 61, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x333
            private static Player Lyle_O_Day = new Player(117, 97, 56, 56, 53, 51, 56, 56, 57, 385, 63, 62, 13, 15, 17, 16, 14, 14, 15, 62, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x334
            private static Player Crane_Clawson = new Player(103, 126, 56, 58, 56, 60, 53, 51, 56, 390, 50, 49, 11, 10, 11, 17, 10, 14, 7, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x335
            private static Player Raven_Crowe = new Player(122, 97, 62, 53, 51, 59, 42, 60, 56, 383, 49, 52, 9, 9, 11, 10, 10, 10, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x336
            private static Player Shirley_Ladyman = new Player(118, 99, 50, 38, 38, 51, 60, 56, 57, 350, 65, 49, 9, 7, 6, 8, 15, 14, 9, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x337
            private static Player Cody_Barani = new Player(122, 92, 48, 41, 39, 56, 60, 56, 51, 351, 50, 51, 10, 7, 8, 7, 15, 14, 10, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x338
            private static Player Bob_Shishker = new Player(121, 94, 46, 52, 51, 53, 57, 42, 54, 355, 60, 54, 8, 9, 9, 8, 12, 7, 11, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x339
            private static Player Pica_Vellosum = new Player(105, 126, 55, 53, 53, 53, 51, 56, 57, 378, 60, 55, 10, 12, 11, 14, 13, 10, 10, 55, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x33A
            private static Player Sascha_Powder = new Player(120, 102, 50, 41, 39, 56, 60, 53, 56, 355, 56, 53, 10, 10, 8, 11, 18, 11, 11, 53, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x33B
            private static Player Gore_Lyath = new Player(99, 119, 51, 52, 57, 51, 55, 53, 57, 376, 61, 61, 14, 16, 14, 15, 17, 14, 17, 61, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x33C
            private static Player Marty_Gras = new Player(118, 85, 54, 51, 44, 50, 48, 51, 54, 352, 54, 44, 15, 14, 9, 9, 9, 7, 7, 44, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x33D
            private static Player Bob_Dingnagian = new Player(94, 119, 47, 53, 55, 56, 56, 57, 55, 379, 47, 50, 10, 11, 10, 10, 13, 11, 10, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x33E
            private static Player Hugh_Dyer = new Player(118, 93, 48, 53, 56, 51, 62, 62, 56, 388, 45, 52, 10, 8, 11, 8, 18, 15, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x33F
            private static Player Carl_Penter = new Player(126, 95, 59, 51, 52, 51, 55, 63, 54, 385, 50, 51, 14, 11, 10, 17, 10, 8, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x340
            private static Player Jebb_Ettow = new Player(120, 92, 56, 56, 57, 53, 53, 54, 52, 381, 57, 57, 11, 11, 12, 13, 10, 12, 14, 57, 4, 4, 4, 5, 4, 4, 4, 4, 3); // 0x341
            private static Player Julian_Siezer = new Player(118, 98, 44, 39, 40, 54, 58, 56, 54, 345, 59, 51, 10, 9, 7, 9, 15, 17, 8, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x342
            private static Player Bill_Dozer = new Player(113, 93, 52, 54, 51, 53, 52, 51, 55, 368, 59, 61, 16, 15, 17, 17, 17, 17, 14, 61, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x343
            private static Player Benny_Factor = new Player(114, 110, 53, 56, 52, 53, 54, 57, 54, 379, 61, 58, 14, 14, 15, 17, 15, 15, 14, 58, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x344
            private static Player Roman_Candler = new Player(122, 116, 46, 51, 62, 47, 57, 51, 51, 365, 51, 63, 11, 8, 13, 10, 9, 10, 10, 63, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x345
            private static Player Ray_Whitehead = new Player(91, 128, 49, 55, 57, 56, 62, 57, 54, 390, 46, 49, 13, 9, 11, 9, 18, 12, 10, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x346
            private static Player Aston_Isher = new Player(130, 96, 59, 52, 51, 52, 56, 54, 54, 378, 69, 49, 15, 8, 13, 16, 9, 11, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x347
            private static Player Grover_Bearing = new Player(110, 94, 56, 52, 51, 54, 51, 54, 56, 374, 60, 57, 13, 12, 14, 10, 13, 14, 13, 57, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x348
            private static Player Andy_Sided = new Player(133, 102, 57, 59, 56, 60, 55, 55, 51, 393, 52, 49, 7, 9, 8, 15, 10, 12, 11, 49, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x349
            private static Player Phil_O_Biblist = new Player(118, 96, 59, 54, 56, 60, 38, 51, 56, 374, 61, 48, 11, 9, 11, 12, 11, 14, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x34A
            private static Player Roy_Plimsole = new Player(94, 132, 48, 51, 53, 53, 61, 54, 54, 374, 48, 48, 10, 11, 11, 9, 14, 10, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x34B
            private static Player Jem_Paste = new Player(135, 94, 47, 54, 57, 53, 56, 58, 53, 378, 50, 48, 8, 7, 7, 10, 11, 11, 8, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x34C
            private static Player Mike_Creasewell = new Player(94, 118, 54, 60, 54, 60, 52, 56, 57, 393, 54, 49, 7, 9, 8, 17, 10, 12, 11, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x34D
            private static Player Hale_Quinn = new Player(126, 96, 56, 61, 54, 60, 41, 65, 51, 388, 50, 47, 9, 11, 11, 14, 9, 9, 11, 47, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x34E
            private static Player Al_Askan = new Player(109, 118, 49, 57, 65, 61, 51, 53, 57, 393, 54, 47, 9, 13, 13, 9, 11, 7, 11, 47, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x34F
            private static Player Scot_Chopper = new Player(118, 97, 48, 36, 38, 57, 62, 55, 53, 349, 50, 47, 9, 9, 6, 9, 15, 10, 8, 47, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x350
            private static Player Nick_Templeton = new Player(110, 100, 47, 54, 60, 48, 53, 55, 51, 368, 49, 58, 10, 8, 17, 9, 9, 10, 10, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x351
            private static Player Butler_Chambers = new Player(120, 89, 62, 54, 44, 45, 48, 56, 53, 362, 55, 49, 14, 10, 10, 9, 10, 9, 11, 49, 5, 1, 1, 1, 5, 1, 1, 1, 2); // 0x352
            private static Player Pip_Skinner = new Player(118, 96, 44, 51, 59, 47, 53, 54, 51, 359, 54, 49, 10, 13, 15, 10, 8, 7, 11, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x353
            private static Player Dan_Vega = new Player(120, 101, 59, 58, 57, 56, 58, 57, 60, 405, 48, 45, 7, 8, 6, 6, 6, 7, 7, 45, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x354
            private static Player Manny_Kinsland = new Player(118, 98, 53, 57, 47, 60, 53, 56, 54, 380, 45, 58, 10, 9, 13, 15, 12, 17, 7, 58, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x355
            private static Player Chick_Adiddy = new Player(121, 100, 51, 57, 53, 61, 57, 53, 53, 385, 49, 68, 11, 10, 9, 15, 11, 11, 9, 68, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x356
            private static Player Jig_Charleston = new Player(122, 99, 56, 65, 56, 53, 53, 61, 56, 400, 54, 49, 15, 8, 12, 14, 11, 7, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x357
            private static Player Powers_Flawless = new Player(119, 114, 54, 59, 51, 56, 56, 54, 53, 383, 56, 54, 9, 8, 9, 16, 10, 14, 9, 54, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x358
            private static Player Alistair_Horizon = new Player(118, 109, 45, 57, 66, 44, 56, 56, 55, 379, 56, 59, 10, 10, 16, 8, 8, 8, 10, 59, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x359
            private static Player Tim_Bergoods = new Player(121, 93, 50, 51, 57, 51, 66, 43, 57, 375, 64, 51, 9, 8, 7, 8, 16, 6, 9, 51, 5, 1, 5, 1, 1, 2, 2, 1, 2); // 0x35A
            private static Player Lux_Sidebottom = new Player(120, 102, 44, 55, 51, 56, 57, 56, 52, 371, 44, 48, 7, 11, 10, 9, 12, 14, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x35B
            private static Player Nat_Picker = new Player(120, 93, 50, 39, 36, 53, 60, 51, 53, 342, 50, 48, 9, 11, 5, 11, 15, 11, 10, 48, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x35C
            private static Player Harold_Derry = new Player(94, 119, 42, 40, 40, 60, 56, 58, 60, 356, 44, 43, 6, 7, 6, 6, 14, 15, 5, 43, 5, 1, 1, 5, 2, 2, 5, 2, 1); // 0x35D
            private static Player Josh_Rogan = new Player(124, 86, 53, 56, 51, 48, 51, 51, 51, 361, 50, 45, 14, 13, 8, 7, 8, 7, 8, 45, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0x35E
            private static Player Ronny_O_Mania = new Player(103, 118, 57, 57, 53, 53, 52, 52, 56, 380, 60, 58, 12, 10, 12, 10, 13, 11, 13, 58, 4, 4, 4, 4, 5, 4, 4, 4, 2); // 0x35F
            private static Player Buck_Teachey = new Player(133, 105, 52, 56, 52, 56, 56, 51, 53, 376, 50, 51, 9, 11, 11, 14, 7, 11, 8, 51, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x360
            private static Player Rayburn_Lightly = new Player(119, 97, 53, 52, 53, 56, 54, 56, 54, 378, 61, 58, 16, 16, 14, 14, 14, 17, 17, 58, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x361
            private static Player Pat_Greene = new Player(120, 86, 51, 53, 46, 44, 47, 54, 57, 352, 50, 49, 16, 14, 7, 10, 10, 9, 10, 49, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x362
            private static Player Sylver_Stone = new Player(93, 129, 47, 54, 51, 53, 60, 59, 57, 381, 46, 48, 9, 9, 10, 10, 10, 13, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x363
            private static Player Equin_Knocks = new Player(120, 103, 56, 56, 54, 58, 56, 53, 52, 385, 54, 50, 10, 9, 8, 15, 10, 11, 7, 50, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x364
            private static Player Hans_Bigger = new Player(120, 92, 55, 56, 51, 56, 53, 51, 56, 378, 55, 58, 13, 14, 13, 13, 12, 13, 12, 58, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x365
            private static Player Creed_Wrighter = new Player(119, 111, 53, 53, 54, 51, 53, 56, 51, 371, 54, 68, 14, 14, 11, 11, 11, 12, 12, 68, 4, 4, 4, 4, 4, 5, 4, 4, 1); // 0x366
            private static Player Fran_Zimmer = new Player(100, 94, 56, 53, 51, 56, 53, 58, 53, 380, 52, 48, 17, 8, 13, 16, 10, 7, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x367
            private static Player Chaz_Anover = new Player(111, 102, 51, 57, 51, 56, 54, 53, 51, 373, 59, 60, 15, 17, 16, 14, 17, 13, 16, 60, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x368
            private static Player Kurt_O_Graphy = new Player(122, 100, 47, 53, 53, 51, 57, 60, 51, 372, 50, 52, 7, 9, 9, 9, 12, 13, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x369
            private static Player Pace_Storey = new Player(100, 90, 51, 48, 56, 53, 51, 54, 51, 364, 46, 44, 8, 11, 11, 5, 7, 6, 5, 44, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x36A
            private static Player Paddy_Streehan = new Player(122, 90, 54, 56, 48, 45, 44, 54, 53, 354, 55, 42, 17, 14, 7, 7, 11, 8, 9, 42, 5, 1, 1, 1, 1, 1, 1, 5, 2); // 0x36B
            private static Player Carson_Haynes = new Player(120, 104, 54, 56, 53, 54, 54, 56, 59, 386, 52, 50, 9, 9, 10, 15, 9, 10, 11, 50, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36C
            private static Player Earl_Grayson = new Player(120, 99, 58, 59, 56, 62, 60, 58, 56, 409, 56, 52, 11, 10, 10, 13, 10, 13, 14, 52, 4, 4, 4, 4, 5, 4, 4, 4, 2); // 0x36D
            private static Player Pip_Aminty = new Player(120, 101, 56, 60, 56, 62, 55, 53, 54, 396, 52, 52, 7, 11, 7, 17, 8, 13, 8, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36E
            private static Player Noel_Vacancies = new Player(93, 116, 54, 59, 55, 62, 51, 57, 52, 390, 55, 47, 9, 9, 9, 17, 7, 14, 9, 47, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x36F
            private static Player Jon_Quill = new Player(121, 99, 60, 57, 53, 51, 52, 57, 52, 382, 54, 49, 14, 7, 13, 16, 11, 11, 9, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x370
            private static Player Bill_Looney = new Player(100, 108, 51, 56, 63, 57, 56, 51, 51, 385, 55, 54, 7, 10, 7, 16, 7, 11, 8, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x371
            private static Player Dan_Nettles = new Player(126, 93, 57, 56, 54, 56, 56, 42, 51, 372, 65, 52, 16, 8, 10, 14, 9, 8, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x372
            private static Player Clark_Watcher = new Player(132, 96, 47, 53, 53, 57, 61, 56, 53, 380, 48, 50, 14, 8, 9, 8, 19, 14, 11, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x373
            private static Player Tim_Eisback = new Player(121, 93, 48, 54, 54, 54, 61, 56, 54, 381, 49, 51, 11, 11, 7, 8, 11, 10, 8, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x374
            private static Player Sam_Aritan = new Player(120, 105, 51, 56, 48, 48, 49, 54, 57, 363, 49, 49, 16, 13, 9, 11, 7, 11, 8, 49, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x375
            private static Player Cal_Emarry = new Player(94, 116, 45, 53, 51, 53, 60, 54, 56, 372, 46, 49, 12, 10, 8, 9, 16, 11, 7, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x376
            private static Player Bambis_Shakin = new Player(120, 93, 50, 54, 55, 54, 65, 53, 56, 387, 52, 50, 12, 7, 9, 9, 15, 14, 8, 50, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x377
            private static Player Zin_Giber = new Player(122, 97, 44, 55, 52, 54, 64, 55, 52, 376, 47, 54, 11, 9, 10, 9, 20, 12, 11, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x378
            private static Player Wes_Abbey = new Player(120, 102, 60, 58, 58, 56, 57, 59, 56, 404, 60, 55, 14, 14, 12, 12, 13, 11, 14, 55, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x379
            private static Player Alec_Dote = new Player(108, 124, 44, 53, 58, 44, 56, 54, 56, 365, 51, 65, 7, 7, 16, 8, 8, 7, 7, 65, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x37A
            private static Player Dougie_McFlea = new Player(122, 96, 51, 53, 57, 56, 54, 55, 55, 381, 60, 55, 12, 12, 11, 13, 13, 13, 11, 55, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x37B
            private static Player Jacky_Lantern = new Player(93, 126, 56, 47, 47, 60, 40, 52, 49, 351, 51, 49, 8, 4, 7, 9, 6, 8, 5, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x37C
            private static Player Matt_Tudor = new Player(119, 89, 37, 47, 46, 67, 53, 57, 50, 357, 44, 44, 5, 5, 6, 7, 11, 9, 6, 44, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x37D
            private static Player Gabriel_Shekinah = new Player(102, 128, 57, 54, 69, 56, 50, 58, 53, 397, 50, 53, 7, 7, 11, 13, 17, 11, 10, 53, 1, 2, 1, 2, 2, 5, 2, 1, 1); // 0x37E
            private static Player Biron_Pendexter = new Player(101, 126, 57, 60, 51, 62, 57, 56, 55, 398, 49, 53, 10, 9, 8, 13, 9, 12, 10, 53, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x37F
            private static Player Rod_Entwhistle = new Player(136, 93, 59, 54, 53, 60, 43, 67, 56, 392, 50, 48, 11, 9, 9, 11, 8, 9, 9, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x380
            private static Player Toby_Patient = new Player(126, 100, 46, 54, 53, 56, 62, 39, 54, 364, 64, 50, 14, 10, 8, 8, 17, 6, 9, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x381
            private static Player Glen_Garry = new Player(121, 90, 48, 50, 46, 46, 50, 48, 44, 332, 52, 51, 10, 8, 7, 10, 7, 10, 8, 51, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x382
            private static Player Bill_Yards = new Player(124, 92, 56, 53, 48, 47, 46, 54, 56, 360, 55, 43, 16, 11, 8, 8, 7, 9, 8, 43, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x383
            private static Player Kay_Acker = new Player(125, 97, 54, 62, 48, 56, 57, 64, 56, 397, 60, 52, 9, 9, 11, 17, 11, 17, 10, 52, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x384
            private static Player Django_Keyes = new Player(122, 118, 45, 65, 47, 65, 45, 42, 44, 353, 44, 43, 10, 5, 9, 6, 11, 5, 8, 43, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x385
            private static Player John_Demi = new Player(119, 98, 55, 57, 56, 62, 57, 56, 54, 397, 63, 61, 14, 17, 13, 13, 16, 17, 15, 61, 2, 5, 2, 2, 2, 2, 2, 2, 2); // 0x386
            private static Player Sage_Wisdom = new Player(131, 97, 49, 57, 56, 53, 58, 51, 55, 379, 44, 52, 12, 11, 11, 9, 19, 14, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x387
            private static Player Nick_Washing = new Player(126, 100, 52, 61, 48, 60, 51, 58, 56, 386, 61, 56, 10, 10, 11, 14, 11, 14, 8, 56, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x388
            private static Player Steve_Pinner = new Player(126, 91, 45, 51, 56, 57, 56, 51, 56, 372, 44, 48, 12, 9, 11, 11, 20, 12, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x389
            private static Player Vance_Bookings = new Player(92, 122, 49, 39, 43, 53, 59, 65, 53, 361, 50, 51, 8, 9, 4, 8, 16, 19, 8, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x38A
            private static Player Bud_Dahman = new Player(120, 108, 52, 53, 50, 48, 45, 55, 52, 355, 52, 47, 15, 11, 11, 9, 8, 9, 8, 47, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x38B
            private static Player Reagan_Boneman = new Player(117, 101, 52, 54, 52, 57, 54, 57, 56, 382, 60, 55, 11, 11, 10, 12, 10, 12, 14, 55, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x38C
            private static Player Erhard_Blower = new Player(124, 94, 52, 56, 57, 53, 52, 53, 51, 374, 54, 52, 10, 11, 12, 12, 13, 11, 11, 52, 3, 3, 3, 3, 3, 3, 3, 5, 2); // 0x38D
            private static Player Jack_Tradesman = new Player(103, 118, 55, 52, 56, 56, 53, 56, 56, 384, 59, 63, 17, 17, 15, 15, 17, 17, 14, 63, 2, 2, 2, 2, 2, 2, 5, 2, 1); // 0x38E
            private static Player Rufus_Judge = new Player(120, 93, 51, 54, 51, 56, 51, 51, 57, 371, 48, 45, 7, 5, 6, 7, 4, 6, 6, 45, 2, 2, 2, 2, 2, 2, 2, 5, 3); // 0x38F
            private static Player Ace_Fettick = new Player(120, 109, 45, 46, 49, 61, 45, 44, 56, 346, 54, 54, 13, 12, 11, 11, 12, 12, 14, 54, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x390
            private static Player Lance_Lotts = new Player(120, 96, 57, 53, 51, 55, 57, 56, 57, 386, 49, 53, 14, 11, 12, 16, 8, 15, 9, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x391
            private static Player Attley_Hightable = new Player(118, 105, 47, 57, 61, 48, 53, 55, 54, 375, 52, 67, 9, 8, 18, 8, 11, 7, 9, 67, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x392
            private static Player Jim_Nastick = new Player(121, 112, 56, 56, 53, 58, 53, 55, 55, 386, 54, 50, 8, 11, 9, 16, 11, 13, 8, 50, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x393
            private static Player Theo_Riser = new Player(122, 90, 45, 56, 56, 58, 45, 46, 48, 354, 54, 53, 12, 14, 10, 13, 12, 12, 12, 53, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0x394
            private static Player Weldon_Wrought = new Player(119, 107, 44, 53, 57, 45, 57, 53, 54, 363, 52, 57, 10, 7, 15, 11, 10, 9, 11, 57, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x395
            private static Player Seymour_Senary = new Player(121, 97, 47, 53, 51, 53, 62, 57, 55, 378, 50, 52, 8, 9, 9, 9, 10, 13, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x396
            private static Player Finn_Carper = new Player(124, 104, 57, 51, 49, 56, 45, 57, 54, 369, 49, 42, 13, 11, 10, 17, 9, 10, 9, 42, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x397
            private static Player Herc_Bigsby = new Player(120, 101, 53, 57, 53, 62, 52, 56, 53, 386, 51, 48, 8, 9, 7, 13, 7, 13, 11, 48, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x398
            private static Player Bramley_Cox = new Player(117, 102, 58, 57, 52, 62, 56, 51, 56, 392, 60, 55, 13, 14, 11, 11, 12, 14, 11, 55, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x399
            private static Player Mitch_Hett = new Player(118, 116, 52, 51, 63, 55, 54, 54, 53, 382, 60, 57, 14, 14, 14, 11, 12, 13, 12, 57, 2, 4, 4, 2, 5, 4, 4, 4, 3); // 0x39A
            private static Player Mo_Zarella = new Player(92, 110, 62, 56, 56, 59, 37, 57, 51, 378, 49, 48, 10, 11, 10, 12, 9, 9, 7, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x39B
            private static Player Scout_Messenger = new Player(114, 101, 61, 56, 53, 54, 57, 53, 51, 385, 57, 52, 11, 13, 10, 14, 12, 14, 11, 52, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0x39C
            private static Player Paul_Chucker = new Player(120, 92, 56, 51, 50, 46, 45, 57, 54, 359, 53, 45, 16, 12, 8, 11, 8, 9, 11, 45, 5, 1, 1, 5, 1, 1, 1, 1, 3); // 0x39D
            private static Player Andy_Wallpole = new Player(122, 101, 56, 56, 57, 52, 53, 60, 53, 387, 49, 47, 17, 11, 14, 15, 9, 11, 11, 47, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x39E
            private static Player Solomon_Justice = new Player(102, 119, 57, 56, 51, 51, 55, 57, 53, 380, 64, 58, 15, 16, 13, 16, 14, 17, 13, 58, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0x39F
            private static Player Mark_Tinney = new Player(108, 117, 56, 54, 53, 51, 51, 51, 56, 372, 59, 60, 16, 17, 13, 17, 14, 15, 14, 60, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x3A0
            private static Player Archy_Medez = new Player(111, 94, 51, 56, 57, 52, 57, 56, 54, 383, 59, 60, 16, 15, 15, 17, 17, 13, 15, 60, 2, 2, 2, 2, 2, 2, 5, 2, 2); // 0x3A1
            private static Player Jay_Pan = new Player(155, 85, 58, 67, 48, 51, 41, 51, 66, 382, 60, 62, 16, 16, 15, 16, 5, 16, 20, 62, 5, 1, 2, 2, 1, 5, 5, 2, 1); // 0x3A2
            private static Player Jonah_Troutman = new Player(111, 102, 48, 55, 60, 48, 53, 54, 54, 372, 50, 58, 8, 7, 14, 11, 8, 7, 10, 58, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3A3
            private static Player Carl_Nivor = new Player(122, 101, 48, 51, 54, 51, 60, 58, 53, 375, 48, 49, 8, 8, 11, 10, 13, 14, 7, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3A4
            private static Player Phil_Occifer = new Player(117, 109, 50, 53, 59, 46, 56, 56, 57, 377, 54, 58, 11, 9, 14, 7, 11, 9, 8, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3A5
            private static Player Noah_Gerkin = new Player(120, 89, 65, 49, 48, 49, 46, 44, 45, 346, 50, 53, 7, 8, 11, 9, 7, 7, 9, 53, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x3A6
            private static Player Colin_Eager = new Player(120, 85, 51, 56, 47, 49, 48, 51, 53, 355, 54, 46, 16, 12, 9, 8, 11, 7, 11, 46, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0x3A7
            private static Player Nick_Crew = new Player(108, 126, 47, 54, 56, 45, 56, 55, 56, 369, 50, 58, 11, 8, 14, 11, 11, 9, 10, 58, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3A9
            private static Player Ivor_Parrot = new Player(90, 127, 57, 51, 48, 50, 44, 57, 53, 360, 56, 42, 13, 11, 10, 11, 8, 9, 8, 42, 5, 1, 5, 1, 1, 1, 1, 1, 2); // 0x3AA
            private static Player Matthew_Pencil = new Player(94, 132, 40, 44, 45, 50, 51, 50, 46, 326, 45, 42, 8, 7, 4, 4, 10, 9, 8, 42, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3AB
            private static Player Ropert_Chapp = new Player(91, 123, 56, 58, 50, 57, 53, 57, 57, 388, 44, 57, 10, 7, 12, 14, 12, 13, 9, 57, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3AC
            private static Player Hal_LeButt = new Player(116, 116, 44, 51, 60, 46, 55, 57, 56, 369, 52, 57, 9, 8, 13, 7, 9, 11, 9, 57, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3AD
            private static Player Al_Chemmy = new Player(93, 129, 61, 60, 56, 59, 58, 57, 56, 407, 56, 42, 7, 7, 6, 7, 8, 6, 6, 42, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x3AE
            private static Player Rob_Zervatory = new Player(124, 101, 60, 51, 54, 54, 57, 57, 51, 384, 67, 47, 13, 7, 14, 14, 10, 20, 8, 47, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3AF
            private static Player Joe_Stick = new Player(103, 116, 48, 57, 56, 45, 52, 57, 54, 369, 53, 62, 10, 9, 15, 8, 8, 8, 11, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3B0
            private static Player Nick_Turine = new Player(137, 95, 62, 57, 55, 57, 46, 58, 51, 386, 51, 48, 11, 8, 8, 14, 7, 9, 9, 48, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3B1
            private static Player Marc_O_Lepsy = new Player(122, 93, 60, 56, 54, 56, 54, 57, 54, 391, 50, 48, 16, 9, 13, 13, 9, 9, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x3B2
            private static Player Jim_Makegood = new Player(94, 120, 45, 51, 57, 54, 58, 62, 56, 383, 50, 49, 9, 10, 9, 8, 15, 13, 7, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3B3
            private static Player Vin_Spinner = new Player(137, 118, 47, 37, 43, 55, 60, 56, 56, 354, 64, 73, 11, 9, 7, 15, 15, 15, 17, 73, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3B4
            private static Player Grew_Driver = new Player(120, 108, 60, 58, 58, 58, 60, 58, 58, 410, 44, 48, 5, 5, 5, 4, 6, 8, 8, 48, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x3B5
            private static Player Ed_Dupee = new Player(99, 128, 44, 36, 42, 51, 60, 56, 56, 345, 53, 53, 7, 11, 5, 11, 14, 14, 9, 53, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3B6
            private static Player Hank_Shortman = new Player(119, 100, 48, 51, 64, 45, 51, 56, 51, 366, 50, 54, 9, 12, 14, 8, 10, 11, 8, 54, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3B7
            private static Player Aaron_Peacy = new Player(118, 101, 45, 52, 53, 55, 62, 51, 51, 369, 48, 48, 11, 11, 11, 9, 15, 12, 10, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3B8
            private static Player Harvey_Sweats = new Player(126, 91, 59, 56, 56, 60, 41, 56, 52, 380, 52, 52, 7, 8, 8, 11, 10, 9, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3B9
            private static Player Harry_Overton = new Player(118, 91, 51, 60, 46, 60, 57, 56, 53, 383, 50, 56, 7, 8, 12, 14, 13, 14, 11, 56, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3BA
            private static Player Archie_Tate = new Player(90, 134, 44, 36, 38, 51, 62, 51, 56, 338, 50, 54, 8, 11, 4, 8, 16, 11, 8, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3BB
            private static Player Neville_List = new Player(118, 110, 44, 54, 53, 51, 64, 62, 51, 379, 49, 49, 9, 11, 7, 9, 16, 18, 8, 49, 5, 1, 1, 5, 1, 2, 2, 1, 3); // 0x3BC
            private static Player Lee_Dorr = new Player(100, 119, 48, 46, 45, 45, 46, 48, 48, 326, 54, 51, 11, 7, 7, 7, 10, 9, 11, 51, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0x3BD
            private static Player Sam_Which = new Player(91, 128, 61, 57, 56, 57, 53, 56, 53, 393, 55, 47, 17, 9, 10, 15, 8, 9, 7, 47, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x3BE
            private static Player Dwight_Self = new Player(94, 116, 59, 51, 52, 51, 53, 62, 53, 381, 50, 47, 14, 10, 14, 14, 8, 9, 10, 47, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x3BF
            private static Player Shep_Shank = new Player(136, 97, 48, 53, 56, 51, 57, 53, 56, 374, 44, 52, 14, 7, 9, 7, 15, 10, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3C0
            private static Player Dylan_Swan = new Player(133, 90, 46, 44, 44, 45, 49, 44, 48, 320, 52, 54, 9, 9, 7, 7, 9, 10, 9, 54, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x3C1
            private static Player Theo_Bernoulli = new Player(122, 98, 56, 62, 50, 60, 53, 62, 53, 396, 51, 55, 7, 8, 11, 17, 14, 16, 10, 55, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3C2
            private static Player Sul_Tarner = new Player(120, 116, 56, 56, 54, 59, 51, 52, 52, 380, 52, 54, 7, 7, 11, 14, 8, 11, 11, 54, 2, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3C3
            private static Player Silas_Scrooge = new Player(125, 105, 62, 63, 60, 59, 58, 60, 56, 418, 68, 67, 17, 19, 18, 17, 19, 18, 17, 67, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3C4
            private static Player Mario_Nette = new Player(131, 92, 45, 47, 48, 48, 48, 46, 45, 327, 49, 48, 7, 11, 11, 10, 10, 7, 9, 48, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x3C5
            private static Player Telly_Fonbocks = new Player(113, 93, 57, 52, 56, 51, 55, 51, 51, 373, 60, 59, 15, 14, 17, 17, 13, 15, 15, 59, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x3C6
            private static Player Bones_Size = new Player(126, 96, 47, 53, 56, 55, 64, 56, 52, 383, 49, 50, 12, 9, 11, 10, 13, 11, 8, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3C7
            private static Player Frank_Koshar = new Player(126, 101, 52, 56, 44, 58, 54, 60, 53, 377, 48, 57, 9, 7, 13, 16, 11, 13, 10, 57, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3C8
            private static Player Keifer_Tiliser = new Player(119, 103, 57, 56, 57, 58, 57, 57, 51, 393, 52, 47, 9, 8, 11, 17, 11, 10, 8, 47, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3C9
            private static Player Jak_Hammerslam = new Player(118, 102, 45, 55, 51, 57, 59, 58, 56, 381, 44, 48, 8, 11, 10, 9, 13, 12, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3CA
            private static Player Rob_Freeby = new Player(127, 101, 59, 57, 53, 60, 36, 56, 53, 374, 67, 54, 9, 11, 10, 14, 10, 14, 11, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3CB
            private static Player Chris_Talise = new Player(99, 131, 44, 40, 39, 55, 60, 56, 54, 348, 54, 48, 9, 8, 8, 9, 17, 13, 8, 48, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3CC
            private static Player Derek_Longhand = new Player(121, 104, 57, 60, 51, 60, 57, 54, 56, 395, 53, 52, 9, 11, 8, 14, 11, 14, 11, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3CD
            private static Player Manny_Gerry = new Player(119, 93, 45, 54, 63, 47, 54, 56, 51, 370, 51, 48, 11, 12, 19, 10, 9, 10, 8, 48, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3CE
            private static Player Des_Count = new Player(101, 124, 57, 56, 57, 62, 57, 56, 52, 397, 54, 49, 7, 9, 9, 14, 8, 12, 8, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3CF
            private static Player Rocky_Rollans = new Player(120, 104, 57, 62, 56, 60, 57, 57, 53, 402, 52, 58, 8, 8, 11, 16, 10, 14, 11, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3D0
            private static Player Shaun_Staid = new Player(122, 101, 45, 56, 51, 56, 67, 66, 53, 394, 45, 54, 8, 7, 10, 10, 14, 13, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3D1
            private static Player Heath_Freke = new Player(122, 93, 58, 53, 57, 51, 53, 56, 56, 384, 50, 49, 15, 11, 12, 17, 10, 9, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3D2
            private static Player Olly_Gammy = new Player(126, 98, 50, 60, 50, 46, 48, 61, 59, 374, 54, 54, 9, 12, 11, 9, 8, 12, 11, 54, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x3D3
            private static Player Aidan_Model = new Player(122, 95, 58, 52, 44, 49, 46, 56, 56, 361, 52, 48, 18, 10, 11, 10, 9, 9, 10, 48, 5, 1, 1, 1, 1, 5, 1, 1, 3); // 0x3D4
            private static Player Mick_Thatcher = new Player(115, 118, 46, 55, 63, 46, 52, 51, 56, 369, 49, 49, 9, 12, 15, 10, 8, 10, 11, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D5
            private static Player Owen_Greenfield = new Player(126, 101, 56, 60, 63, 58, 57, 57, 56, 407, 59, 64, 17, 13, 15, 17, 14, 16, 14, 64, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x3D6
            private static Player Charlie_Krelborn = new Player(118, 102, 44, 55, 59, 44, 56, 53, 57, 368, 54, 64, 11, 7, 16, 11, 11, 8, 9, 64, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D7
            private static Player Rory_Circles = new Player(99, 135, 47, 42, 41, 53, 57, 57, 57, 354, 50, 52, 10, 9, 6, 7, 13, 12, 9, 52, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3D8
            private static Player Barry_Sterr = new Player(120, 94, 44, 57, 56, 48, 51, 57, 56, 369, 52, 48, 9, 11, 16, 9, 8, 8, 9, 48, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3D9
            private static Player John_Baird = new Player(99, 126, 53, 56, 52, 59, 54, 56, 56, 386, 50, 52, 9, 9, 7, 15, 9, 14, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3DA
            private static Player Tyson_Moodey = new Player(91, 124, 44, 52, 56, 53, 66, 56, 56, 383, 45, 54, 14, 9, 8, 9, 17, 12, 8, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3DB
            private static Player Al_Istatin = new Player(125, 95, 56, 54, 56, 55, 53, 59, 55, 388, 61, 51, 14, 10, 12, 13, 10, 14, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3DC
            private static Player Paddy_Popper = new Player(126, 91, 64, 56, 57, 51, 51, 53, 54, 386, 47, 47, 10, 10, 10, 11, 16, 12, 7, 47, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3DD
            private static Player Dwayne_Woo = new Player(120, 91, 57, 57, 52, 56, 53, 66, 57, 398, 57, 53, 13, 10, 14, 14, 7, 17, 8, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3DE
            private static Player Pete_Sadow = new Player(122, 97, 44, 57, 51, 56, 65, 63, 56, 392, 48, 54, 9, 10, 10, 7, 16, 11, 10, 54, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3DF
            private static Player Troy_Glodight = new Player(115, 99, 56, 56, 56, 67, 57, 53, 51, 396, 59, 54, 14, 12, 12, 17, 11, 10, 11, 54, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0x3E0
            private static Player Chris_Hypogee = new Player(119, 101, 47, 56, 57, 48, 53, 51, 55, 367, 50, 51, 10, 14, 14, 10, 10, 11, 10, 51, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3E1
            private static Player Connor_Bation = new Player(121, 89, 53, 55, 47, 44, 46, 53, 56, 354, 56, 48, 17, 14, 8, 8, 8, 8, 8, 48, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x3E2
            private static Player Rhys_Masher = new Player(121, 109, 54, 51, 49, 48, 47, 53, 56, 358, 51, 48, 17, 10, 10, 9, 7, 9, 11, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x3E3
            private static Player Charlie_Shearing = new Player(120, 102, 55, 56, 51, 53, 57, 56, 53, 381, 51, 48, 5, 6, 4, 6, 7, 5, 5, 48, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0x3E4
            private static Player Al_Mannack = new Player(122, 101, 44, 53, 57, 57, 57, 56, 53, 377, 47, 52, 12, 9, 11, 11, 16, 11, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x3E5
            private static Player Nathan_Weyton = new Player(120, 92, 47, 39, 39, 52, 58, 57, 56, 348, 50, 52, 9, 8, 5, 9, 17, 12, 11, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x3E6
            private static Player Simon_Stryker = new Player(111, 103, 47, 56, 56, 47, 53, 55, 56, 370, 52, 58, 9, 8, 17, 9, 11, 10, 9, 58, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x3E7
            private static Player Will_Bayeux = new Player(112, 93, 56, 54, 53, 57, 54, 53, 51, 378, 55, 58, 11, 10, 10, 13, 10, 12, 12, 58, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x3E8
            private static Player Thomas_Ediston = new Player(122, 99, 55, 65, 56, 60, 53, 51, 65, 405, 53, 52, 9, 7, 11, 14, 9, 12, 11, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3E9
            private static Player Aubry_Dient = new Player(94, 112, 57, 56, 53, 58, 41, 61, 56, 382, 54, 52, 9, 7, 9, 12, 10, 8, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x3EA
            private static Player Les_Tarrant = new Player(120, 86, 51, 57, 44, 46, 48, 51, 53, 350, 51, 45, 13, 14, 11, 7, 9, 9, 11, 45, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x3EB
            private static Player Sim_Cope = new Player(101, 116, 45, 53, 57, 53, 60, 56, 56, 380, 50, 51, 13, 9, 11, 11, 15, 14, 10, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x3EC
            private static Player Cal_O_Rees = new Player(94, 121, 49, 57, 53, 51, 60, 57, 51, 378, 50, 47, 14, 8, 7, 10, 16, 11, 9, 47, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3ED
            private static Player Ringo_Spinning = new Player(91, 129, 56, 57, 46, 59, 51, 57, 56, 382, 44, 55, 10, 8, 10, 14, 11, 14, 7, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x3EE
            private static Player Dec_O_Rator = new Player(91, 113, 53, 57, 50, 47, 49, 52, 55, 363, 55, 42, 15, 10, 11, 11, 11, 8, 7, 42, 5, 1, 1, 1, 1, 5, 1, 1, 1); // 0x3EF
            private static Player Pat_Shinko = new Player(121, 100, 45, 42, 36, 56, 65, 53, 55, 352, 52, 53, 11, 9, 4, 9, 15, 14, 10, 53, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x3F0
            private static Player Ryan_Ferry = new Player(99, 128, 54, 54, 50, 47, 46, 56, 56, 363, 56, 44, 13, 10, 7, 9, 10, 11, 8, 44, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x3F1
            private static Player Les_Belisha = new Player(120, 109, 55, 60, 52, 59, 51, 57, 53, 387, 55, 68, 9, 8, 9, 13, 7, 11, 9, 68, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3F2
            private static Player Tim_Crochett = new Player(120, 113, 51, 57, 54, 62, 57, 57, 51, 389, 56, 49, 8, 9, 9, 17, 9, 14, 9, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3F3
            private static Player Hiroshi_Dot = new Player(126, 101, 54, 62, 44, 60, 51, 60, 51, 382, 48, 54, 8, 9, 13, 16, 14, 6, 7, 54, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3F4
            private static Player Jack_Nimble = new Player(119, 96, 50, 53, 56, 45, 53, 53, 57, 367, 49, 50, 10, 10, 16, 8, 8, 9, 11, 50, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x3F5
            private static Player Patch_Upright = new Player(99, 126, 50, 57, 61, 46, 56, 51, 54, 375, 52, 63, 9, 9, 17, 8, 9, 11, 8, 63, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3F6
            private static Player Joe_Nalist = new Player(126, 96, 57, 51, 53, 60, 42, 60, 54, 377, 54, 52, 8, 8, 8, 13, 11, 9, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x3F7
            private static Player Esau_Fagus = new Player(122, 101, 47, 51, 47, 54, 44, 45, 44, 332, 48, 46, 6, 5, 6, 13, 6, 9, 8, 46, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3F8
            private static Player Braden_Bakewell = new Player(119, 89, 65, 39, 43, 48, 62, 44, 46, 347, 48, 42, 15, 7, 7, 6, 13, 10, 8, 42, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x3F9
            private static Player Virgil_Lantis = new Player(101, 123, 63, 54, 41, 57, 48, 53, 44, 360, 45, 48, 5, 8, 11, 13, 10, 13, 6, 48, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x3FA
            private static Player Norm_Drilling = new Player(116, 93, 54, 51, 52, 54, 56, 54, 52, 373, 65, 60, 14, 14, 15, 16, 16, 14, 15, 60, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x3FB
            private static Player Kurt_Tweedy = new Player(91, 118, 51, 57, 46, 59, 56, 62, 51, 382, 48, 55, 10, 11, 11, 13, 12, 15, 10, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x3FC
            private static Player Solomon_Osaka = new Player(99, 124, 48, 55, 60, 45, 52, 52, 53, 365, 50, 62, 7, 7, 13, 11, 10, 9, 7, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x3FD
            private static Player Pike_Tucker = new Player(91, 122, 46, 40, 36, 56, 58, 53, 53, 342, 54, 51, 11, 10, 7, 11, 14, 14, 7, 51, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x3FE
            private static Player Gary_Osoto = new Player(122, 96, 48, 56, 54, 53, 62, 56, 51, 380, 47, 52, 13, 8, 8, 11, 14, 13, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x3FF
            private static Player Dec_Orum = new Player(127, 95, 62, 53, 57, 53, 57, 64, 56, 402, 52, 49, 17, 8, 11, 15, 7, 10, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x400
            private static Player Alan_Carte = new Player(120, 85, 65, 51, 47, 44, 50, 53, 56, 366, 50, 42, 15, 13, 9, 9, 11, 9, 8, 42, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0x401
            private static Player Morgan_Iser = new Player(118, 95, 57, 51, 55, 51, 53, 56, 52, 375, 60, 53, 12, 14, 12, 12, 14, 13, 14, 53, 5, 1, 5, 1, 1, 1, 1, 1, 2); // 0x402
            private static Player Ken_Broad = new Player(126, 93, 47, 39, 38, 53, 57, 56, 51, 341, 60, 51, 9, 11, 5, 7, 16, 10, 10, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x403
            private static Player Scot_Enguard = new Player(127, 100, 59, 56, 58, 56, 56, 57, 58, 400, 50, 43, 17, 11, 7, 11, 9, 10, 9, 43, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x404
            private static Player Dick_Turbin = new Player(92, 126, 46, 38, 41, 52, 58, 53, 56, 344, 50, 51, 9, 10, 8, 9, 16, 11, 11, 51, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x405
            private static Player Benedict_Eggers = new Player(122, 98, 58, 56, 54, 62, 41, 59, 57, 387, 54, 49, 9, 10, 8, 11, 9, 7, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x406
            private static Player Beau_Painton = new Player(91, 116, 60, 51, 57, 51, 51, 56, 56, 382, 55, 49, 16, 11, 14, 17, 7, 8, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x407
            private static Player Butch_Pythons = new Player(121, 102, 57, 60, 56, 56, 56, 51, 52, 388, 51, 53, 8, 9, 11, 17, 8, 13, 7, 53, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x408
            private static Player Sam_Murray = new Player(94, 119, 60, 52, 51, 61, 41, 60, 55, 380, 52, 51, 11, 7, 11, 13, 10, 9, 9, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x409
            private static Player Eathan_Ringer = new Player(123, 101, 57, 56, 56, 57, 41, 59, 56, 382, 54, 49, 7, 7, 8, 12, 8, 7, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x40A
            private static Player Jack_Lumbar = new Player(126, 99, 54, 56, 50, 58, 51, 63, 53, 385, 45, 55, 11, 11, 14, 16, 12, 15, 7, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x40B
            private static Player Todd_Tempole = new Player(121, 105, 56, 62, 53, 59, 53, 52, 53, 388, 52, 54, 8, 9, 7, 14, 11, 13, 10, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x40C
            private static Player Jacob_Grimley = new Player(93, 116, 61, 54, 46, 50, 46, 57, 57, 371, 49, 44, 5, 11, 9, 10, 11, 9, 9, 44, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0x40D
            private static Player John_Coralli = new Player(118, 93, 65, 51, 51, 53, 51, 55, 56, 382, 54, 58, 12, 11, 13, 12, 14, 10, 12, 58, 4, 5, 4, 4, 4, 4, 4, 4, 3); // 0x40E
            private static Player Drew_Faxon = new Player(122, 99, 44, 51, 57, 53, 58, 52, 52, 367, 44, 51, 12, 9, 10, 9, 13, 14, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x40F
            private static Player Cole_Easteroll = new Player(120, 93, 44, 50, 48, 45, 47, 49, 44, 327, 50, 54, 9, 7, 10, 10, 9, 9, 8, 54, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x410
            private static Player Cam_Lensman = new Player(116, 109, 44, 53, 59, 47, 51, 53, 51, 358, 49, 57, 8, 10, 16, 11, 8, 11, 9, 57, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x411
            private static Player Tighe_Windsor = new Player(121, 101, 58, 56, 53, 56, 39, 63, 56, 381, 66, 51, 11, 8, 11, 12, 7, 19, 8, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x412
            private static Player Phil_Dippedes = new Player(126, 97, 46, 57, 56, 51, 62, 55, 56, 383, 49, 51, 10, 9, 10, 9, 13, 12, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x413
            private static Player Lenny_Lakeman = new Player(93, 123, 52, 56, 51, 47, 48, 51, 57, 362, 49, 46, 17, 14, 7, 8, 8, 11, 10, 46, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x414
            private static Player Vaughn_DeVille = new Player(120, 91, 53, 57, 53, 53, 56, 59, 55, 386, 50, 51, 8, 7, 8, 8, 12, 11, 10, 51, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x415
            private static Player Arthur_Myrddin = new Player(117, 95, 56, 54, 57, 56, 53, 56, 52, 384, 54, 57, 12, 14, 13, 14, 10, 14, 13, 57, 4, 4, 5, 4, 4, 4, 4, 4, 1); // 0x416
            private static Player Guy_Forker = new Player(121, 104, 50, 50, 46, 50, 48, 46, 47, 337, 51, 44, 5, 6, 8, 5, 7, 5, 5, 44, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x417
            private static Player Bob_Stretcher = new Player(121, 98, 46, 49, 52, 51, 47, 52, 49, 346, 51, 49, 10, 8, 11, 10, 7, 9, 8, 49, 4, 4, 4, 4, 5, 4, 4, 4, 2); // 0x418
            private static Player Spike_Clutcher = new Player(99, 126, 51, 51, 51, 52, 56, 53, 53, 367, 48, 52, 13, 8, 10, 7, 14, 13, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x419
            private static Player Austin_Tayssus = new Player(114, 108, 48, 53, 61, 48, 54, 57, 54, 375, 49, 50, 7, 12, 16, 8, 8, 10, 8, 50, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x41A
            private static Player Tom_Stevenson = new Player(90, 128, 51, 53, 56, 56, 59, 55, 51, 381, 48, 52, 12, 11, 11, 9, 15, 10, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x41B
            private static Player Ricky_Charmers = new Player(99, 124, 52, 51, 51, 57, 56, 56, 57, 380, 45, 51, 11, 10, 10, 10, 15, 14, 9, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x41C
            private static Player Max_Hurt = new Player(135, 92, 47, 55, 51, 56, 61, 59, 57, 386, 47, 51, 10, 9, 10, 8, 12, 14, 11, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x41D
            private static Player Dexter_Raleigh = new Player(131, 97, 47, 40, 41, 55, 61, 53, 56, 353, 51, 51, 8, 9, 4, 10, 19, 11, 10, 51, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x41E
            private static Player Pete_Pang = new Player(124, 94, 56, 62, 53, 61, 56, 54, 51, 393, 59, 60, 14, 16, 13, 15, 17, 16, 15, 60, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x41F
            private static Player Sam_Fitspire = new Player(123, 93, 57, 57, 45, 56, 53, 58, 56, 382, 47, 59, 7, 9, 13, 16, 13, 16, 9, 59, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x420
            private static Player Carter_Nightly = new Player(125, 105, 60, 59, 57, 56, 60, 56, 57, 405, 64, 61, 17, 17, 17, 13, 17, 15, 17, 61, 4, 4, 4, 4, 4, 5, 4, 4, 1); // 0x421
            private static Player Daley_Switcher = new Player(135, 109, 56, 59, 57, 57, 55, 56, 53, 393, 56, 51, 8, 9, 7, 15, 8, 11, 8, 51, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x422
            private static Player Dexter_Ambie = new Player(122, 97, 60, 55, 54, 52, 56, 56, 51, 384, 56, 49, 17, 9, 12, 14, 11, 11, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x423
            private static Player Gill_Able = new Player(127, 95, 60, 51, 56, 56, 55, 65, 56, 399, 54, 49, 15, 8, 12, 16, 8, 9, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x424
            private static Player Drew_Reiner = new Player(120, 106, 59, 62, 62, 59, 57, 60, 57, 416, 54, 55, 12, 12, 10, 11, 11, 10, 14, 55, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0x425
            private static Player Kevin_Boardman = new Player(103, 118, 44, 56, 65, 45, 53, 56, 57, 376, 49, 51, 9, 12, 15, 11, 11, 9, 9, 51, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x426
            private static Player Andy_Craft = new Player(133, 98, 44, 44, 48, 46, 48, 44, 44, 318, 49, 54, 8, 7, 10, 10, 7, 11, 9, 54, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x427
            private static Player Julius_Vernon = new Player(121, 113, 66, 47, 46, 65, 43, 50, 48, 365, 55, 49, 11, 9, 10, 7, 4, 8, 9, 49, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x428
            private static Player Robin_Sherwood = new Player(120, 94, 49, 67, 44, 62, 44, 49, 44, 359, 50, 52, 10, 7, 11, 11, 10, 8, 7, 52, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x429
            private static Player Ei_King = new Player(122, 98, 62, 53, 53, 53, 56, 60, 62, 399, 54, 53, 17, 9, 11, 17, 11, 7, 14, 53, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x42A
            private static Player Travis_McClean = new Player(94, 129, 62, 51, 52, 58, 43, 59, 54, 379, 54, 49, 9, 11, 9, 13, 9, 10, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x42B
            private static Player Rusty_Spoakes = new Player(93, 122, 44, 41, 39, 56, 60, 57, 52, 349, 52, 52, 11, 9, 6, 8, 20, 14, 11, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x42C
            private static Player Clint_Wester = new Player(122, 101, 60, 60, 60, 60, 58, 60, 56, 414, 50, 45, 4, 6, 5, 8, 7, 6, 8, 45, 4, 4, 5, 4, 4, 4, 4, 4, 3); // 0x42D
            private static Player Pete_Nokeyo = new Player(131, 97, 45, 52, 51, 53, 63, 52, 55, 371, 49, 52, 14, 9, 9, 9, 15, 10, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x42E
            private static Player Will_Racer = new Player(124, 102, 53, 56, 53, 56, 56, 52, 56, 382, 59, 52, 10, 14, 11, 13, 12, 12, 12, 52, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x42F
            private static Player Ollie_Seeker = new Player(120, 92, 62, 56, 51, 54, 51, 57, 57, 388, 54, 49, 17, 7, 14, 17, 8, 8, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x430
            private static Player Graham_Hush = new Player(137, 113, 53, 59, 56, 57, 54, 54, 52, 385, 49, 54, 7, 11, 9, 15, 9, 12, 10, 54, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x431
            private static Player Ronny_Knowles = new Player(122, 94, 56, 57, 44, 56, 56, 57, 51, 377, 51, 54, 10, 10, 12, 14, 13, 17, 10, 54, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x432
            private static Player Les_Abel = new Player(119, 101, 47, 54, 54, 51, 58, 53, 51, 368, 45, 54, 13, 10, 8, 9, 15, 12, 9, 54, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x433
            private static Player Reg_Thrift = new Player(91, 125, 47, 53, 52, 57, 66, 51, 56, 382, 47, 50, 10, 11, 9, 9, 14, 10, 8, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x434
            private static Player Jools_Iceberg = new Player(117, 92, 48, 51, 59, 48, 53, 54, 52, 365, 50, 52, 9, 12, 16, 11, 9, 9, 7, 52, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x435
            private static Player Mark_Brent = new Player(91, 126, 44, 52, 51, 56, 58, 57, 56, 374, 48, 51, 14, 10, 8, 9, 15, 11, 7, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x436
            private static Player Vern_Ironfist = new Player(127, 93, 46, 57, 56, 53, 60, 62, 51, 385, 45, 52, 10, 9, 9, 8, 10, 12, 9, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x437
            private static Player Rob_Burnsides = new Player(123, 99, 47, 53, 56, 57, 61, 57, 52, 383, 64, 52, 7, 7, 9, 9, 16, 16, 7, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x438
            private static Player Ace_Bragg = new Player(126, 100, 60, 60, 59, 60, 59, 60, 56, 414, 65, 64, 15, 15, 15, 16, 15, 14, 17, 64, 4, 4, 4, 4, 5, 4, 4, 4, 1); // 0x439
            private static Player Claude_Snap = new Player(121, 101, 59, 57, 56, 58, 60, 60, 60, 410, 64, 57, 15, 14, 15, 13, 13, 14, 17, 57, 4, 4, 4, 5, 4, 4, 4, 4, 3); // 0x43A
            private static Player Paul_Rush = new Player(125, 101, 56, 62, 56, 60, 67, 57, 60, 418, 57, 58, 14, 12, 11, 13, 20, 14, 14, 58, 1, 1, 1, 1, 1, 5, 1, 1, 3); // 0x43B
            private static Player Guile_Crocket = new Player(117, 108, 57, 48, 46, 56, 63, 62, 59, 391, 59, 57, 10, 12, 4, 14, 20, 15, 10, 57, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x43C
            private static Player Carey_Bean = new Player(118, 109, 56, 49, 44, 61, 60, 56, 56, 382, 59, 56, 11, 14, 4, 12, 19, 14, 10, 56, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x43D
            private static Player John_Maggie = new Player(120, 99, 65, 67, 56, 63, 38, 67, 63, 419, 49, 49, 19, 16, 14, 19, 7, 16, 17, 49, 5, 2, 2, 5, 2, 5, 2, 2, 2); // 0x43E
            private static Player Chops_Denton = new Player(126, 92, 67, 65, 47, 62, 53, 65, 51, 410, 70, 52, 20, 16, 7, 17, 9, 18, 16, 52, 5, 2, 2, 5, 2, 5, 2, 2, 1); // 0x43F

            private static Player Bobby_Yellow = new Player(121, 106, 48, 46, 47, 51, 48, 49, 46, 335, 60, 55, 11, 12, 14, 10, 13, 12, 11, 55, 2, 2, 2, 2, 2, 2, 2, 5, 3); // 0x440
            private static Player Ace_Breaker = new Player(101, 126, 54, 56, 60, 62, 62, 60, 62, 416, 55, 57, 13, 12, 14, 12, 20, 16, 11, 57, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x441
            private static Player Percy_Verence = new Player(122, 108, 51, 57, 58, 60, 60, 63, 56, 405, 45, 57, 10, 10, 12, 11, 17, 15, 14, 57, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x442
            private static Player Erik_Eagle = new Player(127, 113, 70, 60, 75, 54, 63, 53, 61, 436, 77, 66, 13, 16, 23, 14, 20, 17, 19, 66, 2, 2, 2, 2, 5, 1, 4, 4, 1); // 0x443
            private static Player Bobby_Shearer = new Player(128, 109, 56, 61, 52, 76, 60, 72, 52, 429, 77, 76, 12, 10, 13, 19, 14, 11, 12, 76, 1, 2, 2, 5, 2, 2, 2, 2, 3); // 0x444
            private static Player Paul_Peabody = new Player(126, 130, 45, 52, 62, 70, 64, 73, 74, 440, 41, 24, 10, 11, 6, 12, 13, 11, 9, 24, 2, 5, 5, 5, 5, 5, 2, 2, 1); // 0x445
            private static Player Chester_Horse_Jr = new Player(125, 111, 55, 72, 71, 58, 63, 59, 59, 437, 32, 36, 8, 7, 5, 10, 7, 6, 4, 36, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0x446
            private static Player Chester_Horse_Jr_2 = new Player(125, 111, 55, 72, 71, 58, 63, 59, 59, 437, 32, 36, 8, 7, 5, 10, 7, 6, 4, 36, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0x447
            private static Player Sagaminator = new Player(136, 114, 77, 71, 51, 50, 52, 61, 67, 429, 90, 93, 17, 20, 16, 20, 20, 18, 18, 93, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x448
            private static Player Jude_Sharp = new Player(123, 126, 63, 59, 79, 52, 68, 56, 68, 445, 70, 75, 28, 29, 25, 27, 23, 25, 23, 75, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x449
            private static Player Shadow_Cimmerian = new Player(104, 118, 60, 74, 68, 68, 63, 52, 56, 441, 42, 57, 23, 21, 26, 22, 24, 20, 19, 57, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0x44A
            private static Player Grant_Cook_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4); // 0x821
            private static Player Bonnie_Sparks_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2); // 0x822
            private static Player Claire_Lesnow_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5); // 0x823
            private static Player Albert_Denver_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2); // 0x824
            private static Player Ben_Blowton_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2); // 0x825
            private static Player Ethan_Whitering_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2); // 0x826
            private static Player Dawson_Foxx_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5); // 0x827
            private static Player Ving_Rice_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3); // 0x828
            private static Player Bryce_Whitingale_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4); // 0x829
            private static Player Claude_Beacons_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4); // 0x82A
            private static Player Nigel_August_Chaos = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4); // 0x82B
            private static Player Gordon_Star = new Player(108, 138, 55, 68, 56, 67, 53, 51, 59, 409, 48, 70, 22, 16, 16, 19, 21, 17, 16, 70, 5, 5, 5, 5, 5, 1, 4, 5, 5); // 0x835
            private static Player Connor_Shuttle = new Player(106, 113, 53, 54, 69, 63, 68, 56, 56, 419, 57, 69, 14, 17, 15, 17, 21, 18, 13, 69, 5, 3, 5, 3, 3, 2, 3, 3, 2); // 0x836
            private static Player Jim_Landing = new Player(118, 116, 55, 58, 61, 67, 70, 56, 55, 422, 66, 80, 15, 14, 12, 20, 22, 17, 17, 80, 5, 1, 1, 1, 5, 1, 1, 1, 2); // 0x837
            private static Player Grant_Icewater = new Player(112, 108, 64, 68, 58, 53, 59, 55, 56, 413, 57, 78, 15, 15, 20, 22, 20, 18, 16, 78, 5, 2, 2, 2, 5, 2, 2, 2, 1); // 0x838
            private static Player Charles_Riverboat = new Player(104, 120, 56, 55, 57, 70, 61, 52, 70, 421, 42, 69, 13, 20, 17, 20, 19, 16, 15, 69, 5, 1, 1, 1, 1, 5, 1, 1, 1); // 0x839
            private static Player Pat_Box = new Player(105, 129, 58, 59, 67, 54, 58, 56, 54, 406, 44, 73, 17, 15, 16, 16, 23, 15, 17, 73, 5, 2, 2, 2, 5, 2, 2, 2, 3); // 0x83A
            private static Player Gregory_Saturn = new Player(110, 115, 53, 66, 52, 64, 57, 61, 65, 418, 64, 70, 13, 18, 11, 19, 23, 14, 14, 70, 5, 1, 1, 1, 1, 1, 5, 1, 2); // 0x83B
            private static Player Izzy_Jupiter = new Player(113, 108, 52, 55, 62, 63, 70, 54, 63, 419, 56, 74, 17, 15, 18, 19, 21, 15, 17, 74, 5, 3, 3, 3, 5, 3, 3, 3, 1); // 0x83C
            private static Player Rhona_Countdown = new Player(112, 124, 60, 54, 58, 49, 62, 63, 57, 403, 57, 76, 15, 19, 16, 18, 20, 12, 18, 76, 5, 2, 2, 4, 5, 2, 4, 2, 2); // 0x83D
            private static Player Janus = new Player(108, 104, 63, 55, 73, 52, 71, 51, 60, 425, 55, 72, 16, 19, 19, 16, 19, 17, 17, 72, 5, 2, 2, 5, 4, 2, 4, 2, 4); // 0x83E
            private static Player Dylan_Bluemoon = new Player(119, 115, 73, 59, 59, 50, 52, 54, 52, 399, 63, 70, 20, 18, 19, 18, 21, 16, 15, 70, 5, 3, 2, 5, 3, 3, 3, 3, 5); // 0x83F
            private static Player Dvalin = new Player(124, 128, 70, 70, 57, 60, 60, 51, 50, 418, 54, 88, 21, 19, 16, 17, 22, 17, 20, 88, 5, 1, 1, 1, 1, 5, 1, 1, 5); // 0x849
            private static Player Craven_Kenville = new Player(107, 115, 59, 53, 64, 52, 64, 60, 60, 412, 68, 80, 20, 16, 18, 18, 22, 18, 18, 80, 5, 2, 2, 2, 5, 2, 2, 2, 2); // 0x84A
            private static Player Anna_Mole = new Player(121, 134, 58, 57, 63, 54, 66, 54, 54, 406, 55, 70, 18, 16, 18, 16, 22, 16, 18, 70, 5, 2, 5, 2, 2, 2, 2, 2, 1); // 0x84B
            private static Player Kayson_Wattever = new Player(103, 112, 62, 65, 58, 60, 59, 56, 55, 415, 57, 70, 18, 19, 18, 18, 23, 19, 18, 70, 5, 4, 5, 4, 4, 4, 4, 4, 2); // 0x84C
            private static Player Mike_Tytan = new Player(118, 104, 70, 64, 54, 52, 57, 61, 64, 422, 82, 76, 19, 19, 19, 17, 21, 20, 17, 76, 5, 2, 2, 2, 2, 5, 2, 2, 1); // 0x84D
            private static Player Mads_Hatter = new Player(116, 118, 63, 56, 63, 52, 60, 57, 60, 411, 56, 78, 17, 12, 17, 12, 23, 18, 20, 78, 5, 1, 1, 1, 1, 1, 1, 5, 3); // 0x84E
            private static Player Karen_Ripton = new Player(107, 129, 59, 62, 58, 56, 65, 53, 56, 409, 58, 80, 13, 17, 20, 17, 23, 17, 18, 80, 5, 2, 2, 4, 2, 4, 5, 4, 2); // 0x84F
            private static Player Yakker_Plantsworm = new Player(119, 117, 53, 68, 70, 63, 59, 61, 52, 426, 56, 68, 20, 16, 20, 15, 20, 19, 19, 68, 5, 2, 2, 5, 4, 2, 4, 2, 1); // 0x850
            private static Player Carrie_McCuring = new Player(112, 132, 67, 53, 61, 52, 64, 53, 53, 403, 70, 77, 16, 17, 17, 17, 22, 20, 14, 77, 5, 3, 3, 3, 5, 3, 3, 3, 4); // 0x851
            private static Player Ronny_Metcalf = new Player(114, 116, 63, 60, 71, 54, 67, 55, 59, 429, 66, 80, 18, 17, 20, 18, 21, 17, 19, 80, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0x852
            private static Player Zeke_Valanche = new Player(125, 128, 58, 57, 52, 75, 63, 68, 60, 433, 80, 74, 17, 20, 18, 15, 20, 20, 19, 74, 5, 2, 2, 5, 2, 2, 2, 2, 5); // 0x853
            private static Player Dvalin_2 = new Player(126, 120, 79, 73, 54, 53, 64, 53, 54, 430, 54, 82, 21, 19, 16, 17, 22, 17, 20, 82, 5, 1, 1, 5, 1, 1, 1, 1, 5); // 0x854
            private static Player Nelson_Rockwell = new Player(104, 113, 59, 60, 57, 73, 72, 56, 58, 435, 55, 76, 17, 20, 18, 18, 21, 16, 16, 76, 5, 1, 1, 1, 1, 5, 1, 1, 4); // 0x85D
            private static Player Gail_Baker = new Player(117, 118, 57, 53, 60, 55, 79, 60, 56, 420, 74, 93, 18, 20, 20, 16, 23, 19, 17, 93, 5, 2, 2, 2, 2, 2, 5, 2, 2); // 0x85E
            private static Player Kim_Powell = new Player(120, 136, 56, 63, 77, 54, 62, 57, 58, 427, 60, 81, 16, 18, 18, 17, 22, 17, 20, 81, 5, 2, 2, 5, 2, 2, 2, 2, 2); // 0x85F
            private static Player Zack_Cummings = new Player(115, 118, 68, 76, 53, 70, 53, 56, 56, 432, 70, 73, 19, 14, 17, 15, 23, 19, 20, 73, 5, 4, 4, 4, 5, 4, 4, 4, 2); // 0x860
            private static Player Hunt_Mercer = new Player(119, 120, 60, 61, 60, 61, 53, 63, 61, 419, 82, 70, 16, 16, 17, 14, 23, 18, 20, 70, 5, 5, 2, 2, 2, 2, 2, 2, 2); // 0x861
            private static Player Connor_Murray = new Player(125, 121, 57, 61, 72, 58, 62, 52, 57, 419, 61, 74, 20, 14, 18, 13, 21, 19, 17, 74, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0x862
            private static Player Katie_Brown = new Player(115, 135, 58, 58, 68, 57, 60, 59, 61, 421, 70, 74, 18, 18, 16, 17, 19, 20, 20, 74, 5, 4, 4, 5, 4, 4, 4, 4, 5); // 0x863
            private static Player Ashton_Malone = new Player(118, 119, 57, 56, 72, 65, 66, 58, 64, 438, 72, 68, 16, 13, 16, 15, 19, 19, 20, 68, 5, 4, 4, 4, 4, 5, 4, 4, 3); // 0x864
            private static Player Wilbur_Watkins = new Player(117, 123, 78, 67, 62, 53, 48, 46, 67, 421, 69, 100, 22, 20, 18, 16, 19, 17, 16, 100, 5, 3, 3, 3, 3, 3, 3, 5, 4); // 0x865
            private static Player Isabelle_Trick = new Player(112, 130, 64, 60, 69, 55, 62, 55, 60, 425, 68, 89, 17, 17, 17, 15, 21, 15, 17, 89, 5, 1, 1, 1, 1, 5, 1, 1, 4); // 0x866
            private static Player Xene = new Player(125, 128, 71, 71, 63, 64, 61, 62, 61, 453, 82, 68, 18, 18, 18, 19, 20, 18, 20, 68, 5, 2, 2, 5, 2, 2, 2, 2, 5); // 0x867
            private static Player Dvalin_3 = new Player(130, 128, 78, 65, 57, 55, 64, 57, 54, 430, 94, 81, 21, 19, 16, 17, 22, 17, 20, 81, 5, 1, 1, 1, 5, 1, 1, 1, 5); // 0x871
            private static Player Craven_Kenville_2 = new Player(110, 117, 54, 58, 60, 61, 65, 61, 53, 412, 84, 80, 16, 17, 16, 18, 20, 17, 20, 80, 5, 5, 2, 2, 2, 2, 2, 2, 2); // 0x872
            private static Player Anna_Mole_2 = new Player(122, 136, 56, 59, 61, 55, 68, 55, 55, 409, 75, 76, 18, 13, 18, 18, 22, 16, 17, 76, 5, 2, 5, 2, 2, 2, 2, 2, 1); // 0x873
            private static Player Kayson_Wattever_2 = new Player(106, 115, 60, 61, 57, 65, 60, 60, 52, 415, 89, 69, 20, 18, 16, 18, 22, 18, 17, 69, 5, 5, 4, 4, 4, 4, 4, 4, 2); // 0x874
            private static Player Mike_Tytan_2 = new Player(120, 105, 68, 68, 58, 50, 56, 64, 60, 424, 87, 73, 18, 16, 19, 20, 21, 20, 20, 73, 5, 2, 2, 5, 2, 2, 2, 2, 1); // 0x875
            private static Player Mads_Hatter_2 = new Player(117, 120, 65, 57, 68, 51, 60, 57, 57, 415, 65, 73, 18, 10, 19, 12, 23, 20, 17, 73, 5, 1, 1, 1, 1, 5, 1, 1, 3); // 0x876
            private static Player Karen_Ripton_2 = new Player(107, 131, 60, 63, 62, 52, 65, 57, 53, 412, 62, 81, 16, 15, 16, 15, 21, 17, 18, 81, 5, 4, 4, 4, 4, 4, 4, 5, 2); // 0x877
            private static Player Yakker_Plantsworm_2 = new Player(120, 118, 55, 65, 72, 68, 56, 62, 50, 428, 87, 73, 17, 16, 19, 15, 23, 18, 16, 73, 5, 4, 4, 4, 4, 5, 4, 4, 1); // 0x878
            private static Player Carrie_McCuring_2 = new Player(113, 137, 69, 54, 59, 48, 66, 57, 51, 404, 90, 68, 16, 15, 18, 19, 23, 20, 13, 68, 5, 3, 3, 3, 5, 3, 3, 3, 4); // 0x879
            private static Player Ronny_Metcalf_2 = new Player(115, 116, 70, 62, 67, 50, 68, 57, 55, 429, 86, 72, 20, 17, 18, 18, 20, 19, 17, 72, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0x87A
            private static Player Zeke_Valanche_2 = new Player(127, 128, 61, 57, 50, 76, 62, 54, 62, 422, 96, 76, 20, 17, 19, 14, 22, 20, 19, 76, 5, 2, 2, 2, 2, 2, 2, 5, 5); // 0x87B
            private static Player Cam_Mando = new Player(117, 141, 59, 61, 53, 70, 59, 63, 61, 426, 67, 99, 18, 20, 20, 21, 20, 17, 18, 99, 1, 5, 1, 1, 2, 1, 2, 3, 1); // 0x885
            private static Player Harry_Boufante = new Player(99, 125, 54, 57, 61, 59, 62, 58, 55, 406, 82, 85, 16, 18, 17, 21, 18, 17, 16, 85, 1, 5, 2, 2, 4, 1, 1, 1, 1); // 0x886
            private static Player Todd_Stuhl = new Player(108, 121, 57, 60, 52, 57, 58, 62, 54, 400, 66, 89, 20, 18, 17, 20, 20, 18, 19, 89, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x887
            private static Player Aspen_Blewit = new Player(102, 127, 53, 53, 56, 60, 60, 54, 47, 383, 68, 82, 17, 20, 17, 21, 18, 20, 16, 82, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x888
            private static Player Marismus_Oregon = new Player(105, 117, 62, 58, 51, 55, 61, 67, 51, 405, 79, 90, 20, 19, 18, 21, 20, 19, 18, 90, 1, 2, 5, 1, 2, 1, 2, 3, 1); // 0x889
            private static Player Garjan_Cypress = new Player(97, 119, 56, 51, 55, 49, 66, 53, 42, 372, 82, 88, 18, 23, 17, 18, 21, 20, 19, 88, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x88A
            private static Player Judas_Deathcap = new Player(98, 124, 46, 57, 49, 48, 68, 60, 53, 381, 72, 80, 17, 21, 19, 18, 23, 18, 16, 80, 1, 2, 1, 1, 2, 5, 2, 3, 1); // 0x88B
            private static Player Chase_Faithfull = new Player(106, 122, 58, 62, 52, 56, 57, 57, 58, 400, 75, 81, 19, 20, 19, 17, 19, 18, 19, 81, 1, 2, 1, 5, 2, 1, 2, 3, 1); // 0x88C
            private static Player Chris_Ticker = new Player(104, 131, 54, 52, 60, 50, 63, 56, 52, 387, 69, 86, 18, 18, 21, 16, 22, 19, 16, 86, 1, 2, 5, 1, 2, 1, 2, 3, 1); // 0x88D
            private static Player Roy_Daring = new Player(100, 128, 59, 55, 57, 46, 64, 58, 51, 390, 74, 107, 21, 18, 18, 17, 20, 16, 20, 107, 1, 2, 1, 1, 2, 5, 2, 3, 1); // 0x88E
            private static Player Scaber_Enoki = new Player(113, 121, 63, 60, 48, 43, 59, 57, 54, 384, 68, 101, 23, 18, 18, 16, 16, 18, 19, 101, 1, 2, 1, 5, 2, 1, 2, 3, 1); // 0x88F
            private static Player Robot_S = new Player(118, 124, 57, 60, 50, 67, 52, 72, 64, 422, 98, 60, 14, 14, 11, 14, 10, 20, 16, 60, 1, 2, 1, 1, 2, 5, 2, 3, 1); // 0x899
            private static Player Robot_P = new Player(121, 106, 56, 52, 52, 62, 52, 70, 66, 410, 93, 80, 12, 14, 10, 17, 10, 19, 16, 80, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x89A
            private static Player Robot_T = new Player(124, 107, 60, 50, 57, 64, 54, 66, 64, 415, 95, 68, 12, 12, 11, 16, 12, 17, 15, 68, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x89B
            private static Player Robot_V = new Player(119, 109, 54, 53, 55, 67, 57, 74, 57, 417, 95, 80, 14, 14, 13, 15, 12, 18, 16, 80, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x89C
            private static Player Robot_C = new Player(122, 104, 55, 59, 59, 60, 54, 75, 58, 420, 99, 72, 13, 13, 12, 16, 12, 19, 15, 72, 1, 2, 1, 1, 2, 5, 2, 3, 1); // 0x89D
            private static Player Robot_O = new Player(120, 106, 52, 60, 53, 56, 62, 69, 64, 416, 98, 78, 12, 13, 12, 12, 13, 20, 16, 78, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x89E
            private static Player Robot_B = new Player(118, 105, 61, 62, 60, 52, 57, 69, 61, 422, 99, 66, 13, 15, 11, 13, 11, 19, 14, 66, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x89F
            private static Player Robot_G = new Player(117, 118, 58, 54, 63, 60, 54, 70, 65, 424, 87, 72, 12, 12, 17, 12, 10, 17, 15, 72, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8A0
            private static Player Robot_K = new Player(113, 108, 57, 55, 64, 52, 52, 70, 71, 421, 93, 72, 12, 12, 17, 13, 10, 20, 15, 72, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x8A1
            private static Player Robot_F = new Player(121, 112, 63, 59, 55, 58, 62, 69, 62, 428, 98, 72, 14, 11, 10, 10, 16, 18, 15, 72, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8A2
            private static Player Robot_L = new Player(120, 109, 68, 53, 58, 55, 52, 70, 68, 424, 88, 72, 15, 10, 13, 11, 10, 16, 16, 72, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8A3
            private static Player Seymour_Hillman_Young = new Player(130, 140, 53, 70, 65, 77, 50, 57, 73, 445, 69, 93, 12, 12, 11, 10, 12, 13, 15, 93, 1, 2, 1, 1, 2, 5, 2, 3, 3); // 0x8AD
            private static Player Charles_Island_Young = new Player(126, 126, 69, 64, 63, 70, 62, 54, 56, 438, 68, 78, 13, 14, 16, 11, 11, 12, 11, 78, 2, 2, 2, 3, 2, 1, 1, 5, 2); // 0x8AE
            private static Player Garret_Hairtown_Young = new Player(117, 128, 53, 57, 65, 66, 65, 63, 54, 423, 63, 60, 12, 13, 16, 14, 16, 11, 11, 60, 1, 4, 2, 2, 5, 1, 1, 1, 3); // 0x8AF
            private static Player Arthur_Sweet_Young = new Player(132, 129, 52, 67, 65, 66, 67, 60, 63, 440, 68, 70, 15, 16, 11, 14, 13, 15, 11, 70, 4, 2, 3, 5, 2, 1, 2, 1, 1); // 0x8B0
            private static Player Peter_Mildred_Young = new Player(118, 128, 59, 59, 68, 68, 60, 68, 64, 446, 55, 64, 14, 13, 10, 13, 11, 11, 11, 64, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0x8B1
            private static Player Josh_Nathaniel_Young = new Player(119, 125, 62, 62, 66, 62, 62, 61, 62, 437, 62, 60, 14, 11, 15, 10, 14, 13, 12, 60, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8B2
            private static Player Edward_Gladstone_Young = new Player(130, 117, 62, 64, 67, 62, 61, 54, 71, 441, 62, 66, 14, 12, 12, 11, 13, 12, 12, 66, 1, 4, 2, 2, 5, 1, 1, 1, 1); // 0x8B3
            private static Player Tyler_Thomas_Young = new Player(134, 126, 67, 67, 64, 64, 69, 56, 52, 439, 54, 76, 11, 12, 10, 10, 11, 11, 12, 76, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x8B4
            private static Player Joseph_Yosemite_Young = new Player(135, 134, 55, 54, 70, 67, 65, 61, 68, 440, 64, 68, 18, 11, 15, 14, 14, 12, 13, 68, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8B5
            private static Player Ian_Suffolk_Young = new Player(127, 128, 66, 70, 55, 63, 59, 62, 64, 439, 62, 63, 14, 13, 12, 11, 13, 13, 14, 63, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x8B6
            private static Player Constant_Builder_Young = new Player(129, 128, 73, 63, 68, 43, 61, 70, 73, 451, 66, 64, 16, 20, 14, 14, 13, 15, 14, 64, 4, 2, 3, 5, 2, 1, 2, 1, 2); // 0x8B7
            private static Player Grant_Cook = new Player(108, 121, 68, 60, 52, 68, 52, 56, 48, 404, 50, 88, 11, 19, 19, 22, 21, 16, 15, 88, 5, 4, 2, 2, 5, 1, 1, 1, 4); // 0x8C1
            private static Player Bonnie_Sparks = new Player(115, 132, 62, 64, 62, 59, 61, 58, 51, 417, 50, 74, 13, 14, 15, 16, 23, 17, 20, 74, 5, 5, 2, 2, 4, 1, 1, 1, 2); // 0x8C2
            private static Player Val_Flamewood = new Player(120, 118, 66, 62, 57, 58, 57, 60, 62, 422, 48, 69, 10, 15, 17, 16, 23, 14, 20, 69, 5, 2, 2, 3, 2, 1, 1, 5, 1); // 0x8C3
            private static Player Sean_Ashford = new Player(124, 120, 64, 64, 63, 62, 56, 56, 61, 426, 48, 70, 10, 14, 15, 17, 19, 15, 20, 70, 5, 4, 2, 2, 5, 1, 1, 1, 1); // 0x8C4
            private static Player Ben_Blowton = new Player(135, 115, 55, 63, 52, 62, 58, 70, 65, 425, 46, 88, 17, 16, 18, 15, 21, 17, 17, 88, 5, 2, 1, 5, 2, 1, 2, 3, 3); // 0x8C5
            private static Player Ethan_Whitering = new Player(133, 128, 52, 79, 60, 60, 62, 71, 55, 439, 79, 88, 18, 18, 14, 14, 23, 16, 15, 88, 5, 2, 1, 1, 2, 5, 2, 3, 2); // 0x8C6
            private static Player Brenda_Firequest = new Player(117, 133, 65, 59, 58, 56, 61, 61, 52, 412, 63, 89, 16, 16, 17, 15, 23, 16, 15, 89, 5, 2, 1, 5, 2, 1, 2, 3, 1); // 0x8C7
            private static Player Sam_Bournes = new Player(121, 132, 63, 62, 67, 59, 63, 52, 51, 417, 45, 73, 17, 13, 17, 14, 20, 19, 17, 73, 5, 2, 5, 1, 2, 1, 2, 3, 2); // 0x8C8
            private static Player Jim_Flareson = new Player(125, 110, 52, 77, 59, 52, 62, 54, 69, 425, 79, 85, 16, 17, 14, 14, 21, 20, 19, 85, 5, 2, 5, 1, 2, 1, 2, 3, 2); // 0x8C9
            private static Player Claude_Beacons = new Player(120, 128, 74, 71, 64, 58, 66, 52, 60, 445, 67, 87, 21, 20, 17, 15, 23, 17, 18, 87, 5, 2, 1, 5, 2, 1, 2, 3, 4); // 0x8CA
            private static Player Nigel_August = new Player(123, 118, 63, 60, 61, 59, 61, 67, 60, 431, 79, 88, 18, 13, 15, 17, 19, 19, 18, 88, 5, 2, 1, 1, 2, 5, 2, 3, 2); // 0x8CB
            private static Player Ben_North = new Player(105, 124, 61, 60, 53, 71, 60, 52, 52, 409, 50, 87, 11, 17, 20, 19, 23, 16, 15, 87, 5, 2, 2, 3, 2, 1, 1, 5, 2); // 0x8D5
            private static Player Alan_Downhill = new Player(108, 112, 64, 67, 56, 64, 62, 52, 60, 425, 43, 93, 13, 19, 20, 19, 21, 14, 13, 93, 5, 4, 2, 2, 5, 1, 1, 1, 1); // 0x8D6
            private static Player Claire_Lesnow = new Player(115, 138, 52, 58, 60, 73, 50, 60, 56, 409, 58, 80, 12, 14, 16, 18, 21, 17, 17, 80, 5, 2, 2, 3, 2, 1, 1, 5, 5); // 0x8D7
            private static Player Albert_Denver = new Player(125, 110, 57, 70, 52, 70, 53, 66, 63, 431, 49, 90, 12, 19, 20, 18, 23, 14, 17, 90, 5, 2, 2, 3, 2, 1, 1, 5, 2); // 0x8D8
            private static Player Lucy_Hailstone = new Player(116, 132, 53, 55, 63, 68, 65, 52, 54, 410, 61, 82, 17, 16, 16, 16, 22, 18, 15, 82, 5, 2, 5, 1, 2, 1, 2, 3, 2); // 0x8D9
            private static Player Brad_Coldwater = new Player(110, 115, 58, 62, 62, 61, 64, 60, 61, 428, 57, 85, 18, 18, 16, 17, 19, 20, 14, 85, 5, 2, 1, 5, 2, 1, 2, 3, 3); // 0x8DA
            private static Player Dawson_Foxx = new Player(120, 115, 62, 59, 62, 64, 59, 62, 61, 429, 52, 88, 18, 14, 20, 16, 22, 20, 17, 88, 5, 2, 1, 1, 2, 5, 2, 3, 5); // 0x8DB
            private static Player Ving_Rice = new Player(112, 135, 63, 61, 54, 58, 60, 60, 60, 416, 46, 82, 16, 16, 17, 14, 20, 19, 16, 82, 5, 2, 1, 1, 2, 5, 2, 3, 3); // 0x8DC
            private static Player Bernie_White = new Player(106, 120, 66, 60, 56, 55, 68, 57, 52, 414, 54, 91, 13, 16, 15, 13, 20, 16, 17, 91, 5, 2, 1, 1, 2, 5, 2, 3, 2); // 0x8DD
            private static Player Bryce_Whitingale = new Player(110, 125, 62, 65, 65, 68, 66, 56, 60, 442, 81, 79, 22, 14, 22, 21, 21, 17, 20, 79, 5, 2, 1, 5, 2, 1, 2, 3, 4); // 0x8DE
            private static Player Denzel_Freezer = new Player(108, 122, 52, 68, 62, 56, 60, 68, 63, 429, 62, 89, 13, 15, 14, 14, 20, 17, 18, 89, 5, 2, 5, 1, 2, 1, 2, 3, 2); // 0x8DF
            private static Player Ken_Ironwall = new Player(118, 130, 59, 69, 51, 72, 52, 68, 56, 427, 44, 62, 18, 16, 14, 14, 14, 16, 13, 62, 3, 3, 3, 5, 3, 3, 3, 3, 4); // 0x8FD
            private static Player Timothy_Western = new Player(115, 119, 52, 60, 70, 61, 58, 53, 63, 417, 37, 48, 10, 14, 12, 13, 17, 13, 11, 48, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x8FE
            private static Player Wallace_Hammond = new Player(108, 107, 59, 57, 64, 56, 73, 49, 53, 411, 48, 55, 14, 11, 18, 11, 21, 12, 13, 55, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0x8FF
            private static Player Shirley_Stevens = new Player(124, 113, 64, 60, 56, 60, 54, 60, 54, 408, 54, 76, 17, 15, 12, 16, 12, 14, 12, 76, 2, 2, 2, 2, 2, 2, 5, 2, 2); // 0x900
            private static Player Ian_Smith = new Player(120, 118, 71, 63, 54, 58, 52, 60, 61, 419, 54, 62, 13, 17, 11, 11, 14, 20, 14, 62, 2, 2, 2, 2, 2, 2, 2, 5, 4); // 0x901
            private static Player Taylor_Firepool = new Player(103, 109, 57, 52, 62, 66, 57, 56, 57, 407, 40, 47, 10, 11, 13, 11, 13, 13, 13, 47, 3, 3, 3, 3, 3, 5, 3, 3, 4); // 0x902
            private static Player Marge_Fielding = new Player(129, 129, 60, 58, 64, 53, 69, 58, 60, 422, 33, 66, 14, 12, 13, 14, 17, 10, 14, 66, 3, 3, 3, 5, 3, 3, 3, 3, 2); // 0x903
            private static Player Marshall_Firsthand = new Player(101, 115, 51, 58, 55, 60, 68, 57, 62, 411, 33, 54, 12, 16, 11, 14, 12, 12, 11, 54, 2, 2, 2, 2, 2, 2, 2, 5, 4); // 0x904
            private static Player Holly_Mirror = new Player(97, 128, 57, 59, 66, 63, 60, 59, 57, 421, 50, 55, 19, 13, 15, 13, 14, 20, 19, 55, 2, 2, 2, 2, 2, 5, 2, 2, 4); // 0x905
            private static Player Victoria_Vanguard = new Player(108, 130, 61, 51, 62, 61, 52, 61, 52, 400, 68, 48, 15, 11, 16, 10, 19, 20, 18, 48, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x906
            private static Player Joe_Kenneddy = new Player(115, 104, 56, 68, 65, 64, 53, 57, 56, 419, 49, 66, 18, 12, 18, 13, 17, 18, 20, 66, 3, 3, 3, 3, 3, 3, 3, 5, 4); // 0x907
            private static Player Ian_Sights = new Player(104, 132, 52, 51, 69, 63, 60, 48, 57, 400, 36, 78, 17, 18, 17, 17, 11, 12, 11, 78, 2, 2, 2, 2, 2, 5, 2, 2, 4); // 0x908
            private static Player Greene_Beray = new Player(123, 104, 63, 67, 54, 51, 52, 68, 62, 417, 40, 85, 14, 13, 7, 10, 11, 8, 12, 85, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x909
            private static Player Ryan_Tappin = new Player(94, 128, 68, 48, 68, 52, 54, 58, 59, 407, 46, 48, 17, 15, 13, 16, 12, 13, 17, 48, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x90A
            private static Player Linda_Shadey = new Player(102, 134, 69, 56, 70, 46, 59, 57, 56, 413, 37, 35, 12, 11, 13, 10, 10, 10, 13, 35, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x90B
            private static Player Sid_Safehouse = new Player(126, 117, 62, 67, 53, 65, 53, 61, 58, 419, 63, 68, 9, 15, 17, 17, 10, 14, 14, 68, 2, 5, 2, 2, 2, 2, 2, 2, 2); // 0x90C
            private static Player Adam_Ropes = new Player(118, 129, 57, 56, 53, 69, 51, 67, 66, 419, 73, 76, 18, 17, 17, 15, 13, 14, 13, 76, 4, 4, 4, 5, 1, 4, 1, 4, 1); // 0x911
            private static Player Joaquine_Downtown = new Player(109, 133, 54, 54, 55, 63, 52, 56, 63, 397, 60, 55, 13, 13, 15, 15, 15, 12, 19, 55, 4, 4, 4, 4, 5, 4, 1, 4, 5); // 0x912
            private static Player Milton_Bindings = new Player(109, 110, 52, 62, 54, 55, 54, 60, 62, 399, 58, 48, 16, 15, 15, 19, 17, 16, 16, 48, 4, 4, 4, 5, 4, 4, 1, 4, 3); // 0x913
            private static Player Spike_Gleeson = new Player(104, 122, 57, 61, 65, 52, 52, 53, 69, 409, 58, 66, 19, 19, 20, 20, 20, 13, 13, 66, 4, 4, 4, 4, 4, 5, 1, 4, 3); // 0x914
            private static Player Sean_Snowfield = new Player(113, 115, 53, 65, 51, 72, 58, 62, 68, 429, 32, 51, 17, 14, 15, 12, 7, 11, 16, 51, 4, 4, 4, 4, 2, 5, 2, 4, 4); // 0x915
            private static Player Kerry_Bootgaiter = new Player(102, 136, 48, 59, 57, 54, 63, 57, 60, 398, 58, 64, 14, 13, 14, 15, 18, 13, 16, 64, 4, 4, 4, 4, 4, 4, 2, 5, 5); // 0x916
            private static Player Maddox_Rock = new Player(106, 124, 56, 60, 61, 54, 61, 53, 65, 410, 52, 60, 14, 15, 13, 18, 14, 12, 15, 60, 4, 4, 4, 4, 4, 4, 1, 5, 3); // 0x917
            private static Player Robert_Skipolson = new Player(117, 119, 56, 52, 62, 53, 68, 54, 55, 400, 42, 60, 13, 16, 18, 16, 15, 11, 14, 60, 4, 4, 4, 4, 4, 5, 1, 4, 5); // 0x918
            private static Player Shawn_Froste = new Player(108, 120, 59, 57, 68, 64, 70, 69, 50, 437, 56, 66, 16, 14, 16, 15, 18, 14, 14, 66, 2, 4, 2, 5, 2, 2, 1, 4, 2); // 0x919
            private static Player Roland_Climbstein = new Player(125, 127, 65, 62, 52, 59, 58, 58, 61, 415, 58, 36, 19, 16, 16, 18, 16, 14, 14, 36, 4, 1, 1, 4, 5, 4, 1, 4, 2); // 0x91A
            private static Player Quentin_Rackner = new Player(118, 117, 56, 57, 56, 58, 64, 65, 64, 420, 52, 59, 20, 13, 14, 18, 17, 15, 18, 59, 4, 4, 5, 4, 4, 4, 1, 4, 4); // 0x91B
            private static Player Trent_Peggs = new Player(113, 121, 47, 58, 59, 66, 57, 63, 71, 421, 56, 64, 17, 15, 16, 17, 10, 11, 16, 64, 4, 4, 5, 4, 4, 4, 1, 4, 3); // 0x91C
            private static Player Martin_Ursus = new Player(124, 104, 60, 69, 51, 68, 56, 58, 56, 418, 57, 51, 13, 19, 11, 12, 12, 18, 19, 51, 4, 4, 4, 4, 5, 4, 1, 4, 1); // 0x91D
            private static Player Pete_Bogg = new Player(111, 109, 60, 54, 69, 57, 60, 53, 58, 411, 43, 66, 18, 17, 11, 16, 17, 15, 16, 66, 4, 4, 4, 5, 4, 4, 1, 4, 3); // 0x91E
            private static Player Gem_Strata = new Player(107, 116, 56, 57, 52, 53, 60, 53, 60, 391, 44, 64, 17, 16, 14, 20, 16, 20, 13, 64, 4, 4, 4, 4, 4, 5, 1, 4, 3); // 0x91F
            private static Player Horace_Onlign = new Player(105, 118, 55, 63, 52, 52, 60, 58, 60, 400, 51, 35, 14, 14, 17, 16, 14, 17, 15, 35, 4, 4, 4, 4, 4, 4, 1, 5, 1); // 0x920
            private static Player Shawn_Froste_Aiden = new Player(120, 120, 68, 59, 64, 46, 77, 60, 50, 424, 56, 66, 20, 15, 14, 11, 18, 16, 13, 66, 2, 2, 2, 1, 5, 2, 1, 2, 2); // 0x921
            private static Player Shawn_Froste_Fusion = new Player(120, 120, 61, 59, 72, 59, 77, 62, 57, 447, 67, 76, 26, 24, 26, 24, 30, 27, 23, 76, 2, 2, 2, 5, 2, 2, 1, 2, 2); // 0x922
            private static Player Crane_Kik = new Player(116, 138, 58, 71, 53, 62, 58, 57, 69, 428, 36, 68, 19, 14, 17, 16, 15, 14, 17, 68, 2, 2, 2, 2, 2, 5, 2, 2, 4); // 0x925
            private static Player Parry_Waxon = new Player(115, 110, 60, 60, 68, 60, 62, 54, 56, 420, 52, 76, 14, 19, 17, 17, 17, 16, 14, 76, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0x926
            private static Player Bri_Spark = new Player(106, 107, 56, 53, 59, 52, 57, 63, 48, 388, 45, 70, 17, 19, 17, 17, 17, 15, 17, 70, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x927
            private static Player Max_Fortune = new Player(127, 106, 58, 62, 55, 54, 57, 60, 70, 416, 45, 74, 17, 15, 17, 14, 18, 15, 15, 74, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x928
            private static Player Brendan_Water = new Player(107, 113, 53, 58, 67, 56, 62, 59, 53, 408, 56, 55, 15, 18, 13, 17, 16, 20, 17, 55, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0x929
            private static Player Junior_Fardream = new Player(113, 117, 58, 53, 70, 62, 54, 61, 59, 417, 55, 80, 13, 17, 16, 15, 13, 16, 14, 80, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0x92A
            private static Player Ian_Telektual = new Player(102, 119, 54, 57, 62, 52, 53, 57, 56, 391, 55, 64, 19, 16, 15, 18, 17, 17, 16, 64, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x92B
            private static Player Lee_Dinglite = new Player(114, 121, 57, 52, 70, 61, 56, 56, 64, 416, 48, 48, 20, 15, 18, 13, 16, 16, 16, 48, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x92C
            private static Player Marshall_Artz = new Player(126, 116, 59, 56, 68, 60, 62, 64, 71, 440, 62, 93, 14, 11, 16, 18, 16, 15, 18, 93, 3, 3, 3, 5, 3, 3, 3, 3, 4); // 0x92D
            private static Player Tyke_Wando = new Player(119, 120, 60, 56, 57, 53, 68, 58, 55, 407, 58, 66, 17, 15, 14, 14, 18, 17, 20, 66, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0x92E
            private static Player Dirk_Artz = new Player(126, 118, 75, 55, 59, 57, 72, 52, 71, 441, 49, 66, 18, 11, 13, 19, 17, 17, 16, 66, 3, 3, 5, 3, 3, 3, 3, 3, 4); // 0x92F
            private static Player Scott_Banyan = new Player(126, 114, 44, 58, 57, 63, 65, 72, 50, 409, 70, 50, 22, 25, 25, 28, 27, 27, 24, 50, 4, 4, 5, 4, 4, 4, 4, 4, 3); // 0x930
            private static Player Earnest_Bookworm = new Player(108, 118, 53, 54, 60, 56, 55, 55, 65, 398, 44, 54, 13, 17, 13, 17, 11, 14, 13, 54, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x931
            private static Player Ollie_Gami = new Player(106, 120, 58, 57, 59, 58, 57, 60, 58, 407, 52, 59, 12, 17, 11, 15, 16, 17, 14, 59, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x932
            private static Player Roman_Kandel = new Player(117, 103, 60, 61, 54, 52, 57, 58, 57, 399, 40, 76, 18, 19, 17, 13, 16, 17, 12, 76, 2, 2, 2, 2, 2, 2, 5, 2, 2); // 0x933
            private static Player Don_Ation = new Player(110, 107, 63, 60, 54, 57, 52, 56, 57, 399, 37, 64, 11, 15, 16, 12, 10, 16, 18, 64, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0x934
            private static Player Scott_Banyan_FW = new Player(128, 110, 57, 58, 55, 53, 64, 72, 42, 401, 54, 80, 12, 15, 15, 18, 17, 17, 14, 80, 4, 4, 2, 2, 5, 4, 4, 2, 3); // 0x935
            private static Player Joseph_King_Redux = new Player(130, 120, 58, 56, 61, 72, 57, 62, 53, 419, 55, 96, 15, 11, 13, 16, 13, 14, 14, 96, 3, 1, 2, 1, 3, 1, 1, 5, 1); // 0x939
            private static Player Rowan_Beltzer = new Player(116, 112, 56, 62, 63, 60, 62, 63, 58, 424, 61, 78, 17, 17, 11, 15, 18, 13, 17, 78, 2, 1, 1, 1, 5, 1, 1, 1, 1); // 0x93A
            private static Player Blade_Healen = new Player(112, 106, 53, 56, 62, 64, 62, 67, 62, 426, 62, 93, 14, 13, 11, 14, 20, 16, 17, 93, 2, 1, 5, 1, 2, 1, 1, 1, 2); // 0x93B
            private static Player Argie_Bargie = new Player(150, 103, 56, 66, 62, 64, 64, 55, 60, 427, 75, 92, 16, 17, 15, 18, 10, 14, 17, 92, 2, 1, 1, 1, 2, 1, 1, 5, 1); // 0x93C
            private static Player Lee_Bamboo = new Player(108, 112, 58, 56, 63, 59, 64, 59, 55, 414, 63, 78, 17, 14, 10, 16, 18, 17, 12, 78, 2, 1, 1, 1, 2, 1, 5, 1, 1); // 0x93D
            private static Player Eton_Messer = new Player(109, 117, 52, 63, 70, 52, 57, 51, 58, 403, 57, 88, 11, 16, 18, 17, 17, 15, 17, 88, 2, 1, 1, 1, 1, 5, 1, 1, 1); // 0x93E
            private static Player Jonah_Spark = new Player(126, 110, 56, 64, 58, 57, 66, 63, 61, 425, 49, 76, 11, 11, 14, 12, 15, 13, 14, 76, 2, 1, 2, 5, 1, 2, 1, 1, 1); // 0x93F
            private static Player Sue_Sparrow = new Player(105, 138, 57, 63, 64, 54, 58, 59, 60, 415, 75, 88, 16, 12, 11, 11, 17, 10, 14, 88, 2, 1, 5, 3, 1, 2, 1, 1, 2); // 0x940
            private static Player Riley_Jamm = new Player(103, 126, 63, 60, 57, 54, 60, 69, 52, 415, 48, 99, 18, 19, 16, 20, 17, 13, 18, 99, 2, 1, 5, 1, 1, 1, 2, 1, 2); // 0x941
            private static Player Caleb_Stonewall_Redux = new Player(118, 127, 61, 78, 66, 54, 64, 50, 53, 426, 55, 99, 18, 16, 15, 10, 19, 18, 18, 99, 3, 1, 2, 5, 1, 1, 2, 2, 4); // 0x942
            private static Player David_Samford_Redux = new Player(129, 115, 75, 60, 57, 49, 58, 76, 58, 433, 62, 90, 16, 12, 17, 13, 17, 13, 16, 90, 3, 3, 2, 3, 1, 5, 2, 2, 3); // 0x943
            private static Player Jimbo_Cellar = new Player(110, 122, 52, 65, 56, 67, 54, 58, 55, 407, 76, 72, 13, 16, 14, 15, 14, 10, 12, 72, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x944
            private static Player Zenn_Wildhorse = new Player(106, 104, 57, 57, 61, 51, 60, 56, 62, 404, 48, 54, 16, 16, 17, 14, 17, 13, 14, 54, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x945
            private static Player Dawson_Little = new Player(115, 104, 60, 54, 61, 54, 65, 60, 58, 412, 60, 58, 10, 14, 17, 14, 14, 12, 13, 58, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x946
            private static Player Cosimo_Beck = new Player(117, 110, 59, 52, 63, 60, 61, 52, 68, 415, 62, 64, 20, 14, 20, 13, 12, 10, 11, 64, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x947
            private static Player Maston_Color = new Player(119, 118, 68, 56, 52, 64, 53, 66, 48, 407, 55, 60, 10, 18, 14, 10, 19, 13, 20, 60, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x948
            private static Player Darren_LaChance = new Player(113, 142, 59, 54, 66, 72, 56, 60, 64, 431, 52, 88, 24, 24, 29, 26, 25, 28, 29, 88, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0x94D
            private static Player Drancis_Fake = new Player(108, 116, 55, 56, 60, 55, 60, 60, 60, 406, 62, 54, 15, 20, 14, 16, 19, 16, 12, 54, 1, 1, 5, 1, 1, 1, 1, 1, 3); // 0x94E
            private static Player Mick_Mishap = new Player(116, 107, 60, 60, 53, 60, 59, 66, 60, 418, 58, 51, 18, 20, 13, 15, 13, 20, 17, 51, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x94F
            private static Player Louis_Leave = new Player(112, 105, 61, 63, 58, 68, 54, 64, 52, 420, 67, 51, 20, 14, 16, 16, 11, 20, 16, 51, 1, 1, 1, 5, 1, 1, 1, 1, 3); // 0x950
            private static Player Maurice_Badgame = new Player(117, 108, 60, 66, 52, 64, 52, 65, 58, 417, 49, 56, 14, 19, 20, 18, 17, 18, 20, 56, 1, 1, 1, 1, 1, 5, 1, 1, 3); // 0x951
            private static Player Cannon_Random = new Player(107, 117, 53, 62, 60, 53, 68, 63, 55, 414, 54, 51, 17, 14, 13, 11, 20, 17, 19, 51, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0x952
            private static Player Ulric_Richmen = new Player(118, 113, 62, 61, 59, 55, 57, 61, 58, 413, 54, 66, 18, 17, 20, 17, 17, 20, 20, 66, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x953
            private static Player Dave_Fate = new Player(106, 104, 54, 64, 54, 51, 63, 62, 61, 409, 60, 39, 14, 17, 17, 13, 16, 11, 19, 39, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x954
            private static Player Spencer_Duskplay = new Player(111, 109, 73, 52, 62, 57, 52, 64, 53, 413, 64, 56, 16, 17, 19, 16, 15, 18, 16, 56, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x955
            private static Player Jonathan_Luckyman = new Player(117, 121, 65, 62, 57, 56, 65, 61, 64, 430, 68, 49, 18, 17, 20, 13, 20, 16, 17, 49, 1, 1, 1, 1, 1, 1, 1, 5, 4); // 0x956
            private static Player Joe_Poker = new Player(115, 113, 54, 62, 58, 48, 67, 55, 64, 408, 57, 63, 15, 13, 11, 11, 17, 18, 19, 63, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x957
            private static Player Wiley_Cracker = new Player(102, 127, 52, 64, 56, 66, 60, 56, 56, 410, 44, 51, 19, 18, 11, 19, 16, 10, 14, 51, 1, 1, 1, 1, 1, 1, 1, 5, 3); // 0x958
            private static Player Mark_Failing = new Player(113, 101, 61, 61, 56, 57, 54, 54, 55, 398, 38, 68, 16, 20, 17, 15, 12, 14, 14, 68, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x959
            private static Player Alton_Cotts = new Player(119, 108, 55, 64, 51, 71, 48, 68, 67, 424, 55, 48, 13, 18, 11, 19, 10, 12, 13, 48, 1, 1, 1, 1, 1, 1, 5, 1, 3); // 0x95A
            private static Player Mike_Passing = new Player(105, 118, 52, 52, 71, 47, 68, 57, 63, 410, 36, 37, 14, 12, 20, 12, 13, 14, 17, 37, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0x95B
            private static Player Knowle_Bathers = new Player(114, 123, 59, 64, 52, 58, 59, 57, 62, 411, 78, 45, 17, 16, 12, 15, 14, 18, 17, 45, 1, 1, 1, 1, 1, 5, 1, 1, 3); // 0x95C
            private static Player Rocky_Black = new Player(104, 125, 58, 68, 52, 76, 50, 59, 64, 427, 70, 60, 18, 20, 14, 18, 15, 20, 19, 60, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x961
            private static Player Chad_Taylor = new Player(124, 108, 61, 55, 60, 53, 58, 68, 57, 412, 70, 72, 15, 20, 16, 20, 16, 18, 17, 72, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x962
            private static Player Victor_Hills = new Player(112, 110, 59, 61, 59, 68, 52, 57, 63, 419, 57, 76, 17, 19, 14, 18, 17, 15, 18, 76, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x963
            private static Player Hurley_Kane = new Player(132, 117, 75, 70, 51, 61, 51, 71, 65, 444, 78, 72, 31, 30, 27, 27, 25, 27, 27, 72, 1, 1, 5, 1, 1, 1, 1, 1, 4); // 0x964
            private static Player Hector_Redding = new Player(105, 117, 62, 57, 63, 54, 56, 62, 56, 410, 55, 66, 12, 15, 16, 19, 16, 20, 18, 66, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x965
            private static Player Mackenzie_Fordline = new Player(117, 112, 60, 57, 53, 56, 61, 53, 60, 400, 55, 45, 13, 13, 20, 20, 17, 17, 20, 45, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x966
            private static Player Cadence_Soundtown = new Player(113, 121, 61, 56, 62, 62, 60, 63, 60, 424, 78, 76, 14, 20, 19, 18, 17, 13, 16, 76, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0x967
            private static Player Dora_Delight = new Player(103, 133, 59, 60, 53, 55, 52, 59, 60, 398, 60, 60, 15, 18, 17, 19, 17, 18, 18, 60, 1, 1, 1, 1, 1, 1, 5, 1, 3); // 0x968
            private static Player Tom_Contented = new Player(109, 113, 64, 60, 69, 52, 54, 59, 59, 417, 42, 56, 20, 18, 19, 18, 20, 19, 17, 56, 1, 1, 1, 1, 1, 1, 1, 5, 1); // 0x969
            private static Player Joston_Easton = new Player(107, 116, 58, 67, 55, 52, 68, 64, 50, 414, 55, 70, 20, 19, 18, 20, 18, 17, 18, 70, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x96A
            private static Player Spring_Millpond = new Player(118, 107, 62, 57, 56, 58, 71, 57, 55, 416, 55, 81, 20, 19, 20, 20, 17, 14, 15, 81, 1, 1, 1, 1, 1, 1, 1, 5, 4); // 0x96B
            private static Player Gaston_Cooley = new Player(104, 134, 54, 63, 52, 64, 59, 48, 57, 397, 57, 89, 10, 18, 19, 18, 15, 14, 16, 89, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x96C
            private static Player Bevan_Breakfast = new Player(114, 113, 52, 63, 66, 62, 58, 55, 62, 418, 54, 45, 13, 17, 18, 20, 16, 18, 18, 45, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0x96D
            private static Player Jack_Griddle = new Player(115, 117, 60, 53, 58, 56, 61, 62, 61, 411, 57, 41, 14, 10, 19, 17, 15, 15, 19, 41, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x96E
            private static Player Stan_Andagi = new Player(116, 106, 63, 52, 54, 61, 56, 68, 69, 423, 58, 72, 15, 14, 15, 19, 12, 18, 19, 72, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x96F
            private static Player Coral_Talent = new Player(92, 121, 58, 52, 57, 53, 55, 52, 53, 380, 57, 22, 10, 10, 20, 13, 17, 10, 11, 22, 1, 1, 1, 1, 1, 5, 1, 1, 5); // 0x970
            private static Player Thomas_Feldt2 = new Player(140, 135, 57, 70, 59, 80, 69, 55, 57, 447, 88, 110, 19, 19, 17, 23, 18, 17, 19, 110, 3, 3, 3, 3, 3, 3, 5, 5, 1); // 0x975
            private static Player Malcolm_Night2 = new Player(107, 125, 64, 70, 55, 66, 68, 58, 57, 438, 62, 79, 20, 20, 22, 22, 19, 18, 17, 79, 3, 3, 3, 3, 3, 3, 5, 3, 3); // 0x976
            private static Player Shadow_Cimmerian2 = new Player(106, 120, 64, 75, 69, 69, 64, 57, 61, 459, 66, 84, 22, 17, 22, 20, 20, 19, 19, 84, 3, 3, 3, 3, 3, 3, 5, 5, 3); // 0x977
            private static Player Jim_Wraith2 = new Player(116, 131, 59, 54, 76, 67, 54, 67, 65, 442, 65, 81, 18, 16, 25, 25, 15, 15, 17, 81, 3, 3, 3, 3, 3, 5, 5, 3, 3); // 0x978
            private static Player Tod_Ironside2 = new Player(116, 116, 55, 56, 54, 60, 60, 61, 70, 416, 57, 75, 14, 18, 25, 16, 16, 15, 25, 75, 3, 3, 3, 5, 3, 3, 5, 3, 1); // 0x979
            private static Player Steve_Grim2 = new Player(123, 123, 61, 64, 63, 61, 63, 69, 67, 448, 52, 67, 13, 7, 9, 11, 7, 9, 8, 67, 3, 3, 3, 5, 3, 3, 5, 3, 2); // 0x97A
            private static Player Tim_Saunders2 = new Player(135, 117, 64, 80, 62, 61, 56, 53, 63, 439, 61, 89, 19, 14, 25, 24, 16, 23, 17, 89, 3, 3, 3, 3, 5, 3, 5, 3, 1); // 0x97B
            private static Player Sam_Kincaid2 = new Player(128, 126, 66, 61, 57, 57, 59, 61, 81, 442, 50, 74, 20, 18, 16, 25, 16, 14, 24, 74, 3, 3, 3, 3, 3, 3, 5, 5, 2); // 0x97C
            private static Player Maxwell_Carson2 = new Player(128, 121, 52, 61, 73, 65, 61, 61, 62, 435, 59, 83, 16, 25, 23, 19, 22, 16, 18, 83, 3, 3, 3, 3, 3, 3, 5, 3, 1); // 0x97D
            private static Player Nathan_Swift2 = new Player(127, 125, 68, 59, 69, 58, 77, 63, 45, 439, 61, 81, 22, 16, 18, 17, 24, 24, 18, 81, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0x97E
            private static Player Kevin_Dragonfly2 = new Player(125, 109, 83, 61, 50, 54, 52, 69, 75, 444, 37, 97, 24, 17, 14, 18, 17, 18, 19, 97, 3, 3, 3, 3, 3, 3, 5, 3, 2); // 0x97F
            private static Player Daisy_Fields = new Player(95, 148, 48, 65, 59, 67, 50, 52, 71, 412, 67, 100, 16, 18, 14, 19, 13, 20, 20, 100, 1, 1, 1, 1, 1, 5, 1, 1, 4); // 0x989
            private static Player Alexia_Sand = new Player(108, 137, 61, 56, 61, 65, 60, 52, 52, 407, 48, 54, 17, 20, 19, 15, 17, 19, 19, 54, 1, 1, 1, 5, 1, 1, 1, 1, 5); // 0x98A
            private static Player Hellen_Hearth = new Player(104, 137, 58, 52, 56, 55, 54, 55, 57, 387, 48, 52, 17, 17, 18, 11, 11, 20, 14, 52, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x98B
            private static Player Rose_Pinkpetal = new Player(138, 133, 52, 60, 68, 60, 66, 52, 52, 410, 54, 55, 14, 18, 19, 19, 18, 14, 20, 55, 1, 1, 5, 1, 1, 1, 1, 1, 2); // 0x98C
            private static Player Esther_Greenland = new Player(119, 132, 56, 54, 58, 58, 56, 52, 63, 397, 58, 66, 17, 20, 19, 13, 14, 18, 18, 66, 1, 1, 5, 1, 1, 1, 1, 1, 2); // 0x98D
            private static Player Bela_Bluebells = new Player(125, 116, 56, 55, 64, 63, 54, 52, 59, 403, 55, 48, 14, 16, 18, 17, 16, 15, 14, 48, 1, 1, 5, 1, 1, 1, 1, 1, 1); // 0x98E
            private static Player Natalie_Sunrise = new Player(108, 129, 52, 58, 60, 53, 57, 60, 58, 398, 50, 64, 19, 17, 16, 17, 16, 15, 16, 64, 1, 5, 1, 1, 1, 1, 1, 1, 2); // 0x98F
            private static Player Hillary_Bush = new Player(115, 132, 63, 59, 59, 55, 53, 60, 54, 403, 68, 66, 16, 14, 14, 20, 16, 18, 17, 66, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0x990
            private static Player Mary_Moor = new Player(111, 129, 54, 61, 58, 53, 55, 54, 69, 404, 82, 64, 18, 15, 14, 17, 19, 15, 19, 64, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0x991
            private static Player Suzette_Hartland = new Player(107, 128, 65, 60, 59, 54, 60, 52, 64, 414, 61, 81, 20, 18, 16, 16, 18, 16, 18, 81, 1, 5, 1, 1, 1, 1, 1, 1, 2); // 0x992
            private static Player Lily_Willow = new Player(103, 132, 57, 52, 58, 63, 53, 56, 54, 393, 56, 72, 19, 13, 20, 15, 17, 18, 17, 72, 1, 1, 5, 1, 1, 1, 1, 1, 4); // 0x993
            private static Player Dell_Closeout = new Player(145, 133, 52, 60, 52, 60, 55, 58, 52, 389, 50, 63, 10, 19, 15, 16, 14, 16, 19, 63, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0x994
            private static Player Amy_Spires = new Player(121, 112, 54, 55, 56, 55, 52, 60, 52, 384, 44, 49, 17, 20, 18, 16, 11, 16, 17, 49, 1, 1, 5, 1, 1, 1, 1, 1, 3); // 0x995
            private static Player Peony_Cash = new Player(114, 128, 52, 58, 55, 57, 58, 51, 62, 393, 55, 80, 18, 15, 17, 11, 14, 19, 19, 80, 1, 1, 1, 5, 1, 1, 1, 1, 3); // 0x996
            private static Player Gayle_Revel = new Player(124, 127, 64, 59, 53, 51, 57, 63, 64, 411, 48, 58, 16, 16, 13, 18, 17, 14, 16, 58, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x997
            private static Player Janine_Brook = new Player(108, 142, 54, 60, 54, 62, 55, 57, 63, 405, 54, 33, 15, 16, 14, 11, 11, 17, 15, 33, 1, 1, 1, 5, 1, 1, 1, 1, 2); // 0x998
            private static Player Colin_Binder = new Player(121, 104, 58, 61, 70, 52, 55, 59, 70, 425, 68, 76, 14, 5, 16, 5, 13, 15, 5, 76, 2, 5, 5, 2, 5, 5, 5, 5, 2); // 0x99D
            private static Player Larry_Pogue = new Player(123, 107, 79, 67, 58, 68, 52, 56, 57, 437, 101, 86, 21, 10, 4, 14, 7, 11, 10, 86, 2, 2, 5, 5, 5, 5, 2, 2, 3); // 0x99E
            private static Player Rob_Cardson = new Player(133, 99, 54, 68, 49, 79, 62, 62, 60, 434, 35, 39, 12, 15, 17, 22, 8, 6, 8, 39, 5, 5, 2, 2, 2, 5, 5, 5, 1); // 0x99F
            private static Player Ken_Mayfield = new Player(128, 120, 69, 62, 50, 59, 63, 63, 56, 422, 73, 62, 15, 13, 13, 17, 14, 15, 15, 62, 3, 3, 5, 3, 3, 3, 3, 3, 4); // 0x9A0
            private static Player Casey_Leather = new Player(140, 95, 56, 62, 69, 66, 52, 65, 60, 430, 56, 47, 13, 11, 23, 14, 12, 14, 14, 47, 1, 1, 1, 2, 1, 1, 5, 1, 2); // 0x9A1
            private static Player Ethan_Swallow = new Player(127, 103, 57, 53, 60, 60, 69, 64, 71, 434, 60, 36, 6, 7, 8, 5, 21, 23, 22, 36, 5, 5, 5, 5, 5, 2, 2, 2, 1); // 0x9A2
            private static Player Bob_Daruma = new Player(121, 129, 52, 52, 50, 52, 68, 79, 79, 432, 66, 21, 8, 6, 5, 6, 21, 17, 15, 21, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0x9A3
            private static Player Mitch_Blackston = new Player(121, 106, 77, 59, 61, 56, 54, 57, 58, 422, 39, 25, 22, 8, 6, 4, 5, 8, 6, 25, 1, 2, 1, 5, 1, 1, 1, 1, 2); // 0x9A4
            private static Player Aurelia_Dingle = new Player(108, 142, 64, 62, 72, 63, 54, 47, 42, 404, 41, 24, 5, 7, 8, 8, 6, 5, 5, 24, 5, 5, 5, 5, 5, 5, 5, 5, 5); // 0x9A5
            private static Player Canon_Evans = new Player(132, 115, 60, 59, 64, 69, 60, 62, 67, 441, 43, 84, 12, 17, 14, 17, 9, 15, 20, 84, 1, 1, 1, 1, 5, 1, 1, 1, 6); // 0x9A6
            private static Player Syon_Blaze = new Player(127, 110, 70, 60, 76, 67, 62, 54, 58, 447, 62, 56, 20, 14, 12, 14, 15, 13, 12, 56, 1, 1, 1, 1, 1, 5, 1, 1, 2); // 0x9A7
            private static Player Thor_Stoutberg = new Player(124, 137, 56, 80, 53, 62, 50, 71, 68, 440, 77, 75, 29, 29, 24, 30, 24, 23, 23, 75, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0x9A8
            private static Player Nelly_Raimon = new Player(118, 131, 68, 64, 65, 52, 44, 49, 62, 404, 46, 21, 8, 5, 5, 4, 6, 4, 7, 21, 2, 4, 4, 4, 4, 5, 4, 4, 1); // 0x9A9
            private static Player Celia_Hills = new Player(128, 128, 48, 54, 69, 60, 69, 51, 58, 409, 33, 29, 5, 6, 8, 7, 6, 6, 7, 29, 4, 4, 4, 4, 5, 2, 4, 4, 1); // 0x9AA
            private static Player Silvia_Woods = new Player(104, 145, 44, 58, 52, 74, 51, 64, 68, 411, 33, 27, 8, 6, 6, 6, 5, 5, 5, 27, 4, 4, 4, 4, 2, 5, 4, 4, 1); // 0x9AB
            private static Player Hidetoshi_Nakata = new Player(144, 120, 85, 70, 70, 60, 64, 68, 62, 479, 78, 96, 19, 19, 18, 20, 20, 18, 20, 96, 2, 2, 2, 2, 5, 1, 1, 2, 1); // 0x9AC
            private static Player Curtis_Croon = new Player(127, 114, 60, 53, 51, 58, 38, 60, 36, 356, 54, 54, 11, 9, 8, 11, 9, 10, 9, 54, 1, 2, 5, 1, 2, 5, 2, 1, 1); // 0x9C5
            private static Player Georgio_Plumber = new Player(105, 125, 60, 60, 54, 53, 54, 61, 58, 400, 54, 46, 19, 13, 14, 10, 10, 10, 11, 46, 5, 1, 1, 5, 1, 1, 1, 1, 1); // 0x9C6
            private static Player Vince_Firewall = new Player(120, 93, 60, 53, 54, 56, 50, 62, 53, 388, 52, 52, 8, 9, 10, 13, 10, 7, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9C7
            private static Player Roy_Diggins = new Player(124, 95, 51, 56, 51, 54, 56, 51, 55, 374, 48, 54, 13, 8, 10, 11, 14, 14, 10, 54, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x9C8
            private static Player Quill_Inker = new Player(114, 112, 56, 55, 51, 56, 54, 56, 53, 381, 54, 52, 11, 10, 12, 13, 11, 13, 13, 52, 2, 5, 2, 2, 2, 2, 2, 2, 1); // 0x9C9
            private static Player Bertram_Manning = new Player(124, 100, 54, 59, 56, 56, 65, 65, 60, 415, 49, 57, 14, 11, 10, 12, 15, 17, 10, 57, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0x9CA
            private static Player Laura_Quilter = new Player(118, 123, 51, 58, 67, 53, 56, 59, 59, 403, 56, 54, 11, 14, 20, 12, 13, 12, 11, 54, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9CB
            private static Player Des_Igner = new Player(120, 114, 46, 49, 47, 51, 50, 53, 52, 348, 53, 51, 10, 9, 10, 8, 9, 11, 11, 51, 2, 2, 2, 2, 2, 2, 5, 2, 3); // 0x9CC
            private static Player Jarmon_Fisk = new Player(137, 92, 51, 56, 50, 59, 56, 56, 56, 384, 51, 52, 8, 7, 13, 16, 10, 17, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x9CD
            private static Player Hugh_Tinter = new Player(120, 101, 65, 59, 59, 62, 45, 66, 62, 418, 55, 58, 12, 14, 12, 14, 10, 14, 11, 58, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0x9CE
            private static Player Tim_Pression = new Player(120, 95, 44, 39, 37, 61, 58, 51, 54, 344, 49, 54, 9, 11, 4, 10, 17, 12, 10, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0x9CF
            private static Player Claire_Taker = new Player(89, 137, 48, 50, 48, 51, 51, 48, 51, 347, 52, 49, 10, 9, 9, 9, 8, 9, 9, 49, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0x9D0
            private static Player Heath_Planner = new Player(121, 97, 44, 52, 54, 51, 62, 60, 51, 374, 45, 51, 10, 11, 7, 9, 14, 13, 11, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9D1
            private static Player Pace_Keeping = new Player(118, 94, 51, 53, 54, 51, 56, 56, 51, 372, 61, 59, 15, 15, 16, 16, 16, 16, 13, 59, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0x9D2
            private static Player Arthur_Easley = new Player(120, 96, 55, 53, 61, 52, 54, 53, 66, 394, 52, 54, 11, 8, 8, 10, 8, 9, 8, 54, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x9D3
            private static Player Carl_Rhodes = new Player(120, 89, 53, 56, 49, 57, 46, 57, 46, 364, 49, 48, 8, 6, 11, 13, 9, 12, 6, 48, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x9D4
            private static Player Eugene_Conwell = new Player(102, 134, 53, 57, 53, 51, 56, 48, 51, 369, 65, 64, 16, 14, 13, 17, 14, 10, 15, 64, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0x9D5
            private static Player Arnan_Wheelie = new Player(118, 101, 52, 52, 53, 57, 54, 54, 53, 375, 59, 62, 17, 17, 16, 16, 14, 15, 13, 62, 4, 4, 4, 5, 4, 4, 4, 4, 3); // 0x9D6
            private static Player Stu_Boilin = new Player(104, 120, 53, 57, 57, 56, 51, 51, 57, 382, 60, 58, 14, 10, 14, 11, 10, 11, 14, 58, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0x9D7
            private static Player Marvin_Reading = new Player(99, 127, 62, 51, 51, 41, 53, 53, 67, 378, 54, 53, 10, 11, 10, 6, 11, 14, 14, 53, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0x9D8
            private static Player Callie_Graffy = new Player(91, 130, 53, 57, 48, 62, 56, 57, 54, 387, 48, 52, 10, 10, 13, 14, 12, 17, 7, 52, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0x9D9
            private static Player Ant_Anomy = new Player(91, 124, 60, 56, 59, 59, 62, 57, 56, 409, 56, 45, 4, 4, 8, 5, 4, 5, 6, 45, 1, 1, 5, 1, 1, 1, 1, 1, 2); // 0x9DA
            private static Player Laurie_Nowlin = new Player(89, 138, 49, 51, 51, 46, 51, 53, 48, 349, 57, 52, 14, 14, 12, 12, 12, 13, 14, 52, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0x9DB
            private static Player Lucille_Strummon = new Player(82, 127, 59, 56, 57, 58, 36, 58, 53, 377, 53, 52, 11, 10, 11, 13, 9, 8, 7, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9DC
            private static Player Leon_Hotair = new Player(119, 93, 53, 54, 57, 57, 51, 51, 51, 374, 61, 61, 15, 14, 14, 14, 15, 17, 14, 61, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x9DD
            private static Player John_Bleach = new Player(121, 95, 46, 51, 57, 53, 59, 52, 51, 369, 48, 51, 13, 9, 11, 9, 15, 10, 10, 51, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9DE
            private static Player Carey_Filling = new Player(118, 86, 44, 48, 48, 45, 45, 48, 48, 326, 53, 48, 8, 8, 10, 7, 10, 11, 9, 48, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0x9DF
            private static Player Conn_Fuchus = new Player(123, 101, 65, 60, 61, 67, 47, 63, 58, 421, 57, 57, 14, 13, 14, 13, 13, 13, 11, 57, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9E0
            private static Player Iain_Igma = new Player(115, 92, 57, 56, 56, 56, 51, 56, 56, 388, 61, 58, 15, 15, 15, 15, 16, 14, 14, 58, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0x9E1
            private static Player Carrie_O_Kea = new Player(93, 127, 52, 51, 51, 48, 46, 51, 51, 350, 57, 55, 12, 14, 12, 13, 12, 11, 14, 55, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0x9E2
            private static Player Ebirina = new Player(108, 92, 47, 53, 59, 49, 51, 53, 51, 363, 54, 54, 9, 12, 17, 9, 9, 7, 11, 54, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0x9E3
            private static Player Stuart_Leafe = new Player(133, 92, 53, 51, 53, 53, 57, 56, 52, 375, 49, 54, 11, 10, 7, 8, 16, 11, 10, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9E4
            private static Player Cole_Stoaker = new Player(99, 124, 49, 40, 40, 51, 67, 51, 51, 349, 50, 45, 8, 8, 5, 7, 6, 6, 4, 45, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0x9E5
            private static Player Justin_Primm = new Player(133, 98, 50, 51, 52, 51, 57, 60, 52, 373, 48, 52, 9, 7, 10, 9, 12, 14, 7, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9E6
            private static Player Mark_Smudge = new Player(137, 95, 53, 62, 47, 60, 56, 58, 51, 387, 46, 56, 8, 7, 10, 14, 12, 16, 7, 56, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9E7
            private static Player Travis_Borer = new Player(119, 107, 57, 57, 60, 60, 62, 56, 37, 389, 54, 49, 14, 14, 9, 7, 8, 7, 5, 49, 5, 1, 1, 1, 1, 5, 1, 1, 1); // 0x9E8
            private static Player Anton_Donce = new Player(99, 123, 51, 53, 45, 63, 45, 54, 56, 367, 52, 48, 13, 12, 8, 9, 9, 10, 7, 48, 5, 1, 1, 1, 5, 1, 1, 1, 2); // 0x9E9
            private static Player Chase_Spoor = new Player(121, 95, 58, 54, 57, 56, 51, 58, 51, 385, 52, 51, 16, 7, 14, 14, 10, 9, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9EA
            private static Player George_Barros = new Player(99, 126, 57, 65, 58, 65, 59, 59, 60, 423, 59, 52, 13, 12, 14, 18, 14, 15, 12, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9EB
            private static Player Olivia_Baker = new Player(107, 133, 55, 56, 66, 55, 56, 60, 59, 407, 59, 53, 10, 15, 17, 13, 14, 12, 12, 53, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x9EC
            private static Player Gem_Shorn = new Player(120, 103, 63, 63, 65, 67, 53, 63, 62, 436, 55, 61, 17, 16, 20, 21, 18, 19, 20, 61, 1, 2, 4, 4, 4, 5, 4, 4, 3); // 0x9ED
            private static Player Lou_Daguerre = new Player(92, 130, 51, 53, 50, 47, 46, 56, 51, 354, 50, 42, 15, 14, 9, 9, 10, 9, 11, 42, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0x9EE
            private static Player Ollie_Tuckney = new Player(124, 100, 51, 56, 65, 53, 62, 56, 60, 403, 58, 56, 14, 15, 17, 12, 14, 14, 11, 56, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0x9EF
            private static Player Manuel_Kinart = new Player(92, 124, 50, 57, 51, 57, 66, 57, 54, 392, 48, 48, 12, 11, 9, 10, 17, 12, 11, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9F0
            private static Player Skip_Vinall = new Player(120, 100, 62, 59, 58, 65, 50, 67, 56, 417, 57, 58, 11, 13, 11, 15, 14, 12, 10, 58, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0x9F1
            private static Player Junior_Gambit = new Player(132, 102, 49, 56, 54, 53, 67, 54, 55, 388, 45, 47, 7, 5, 6, 7, 6, 8, 8, 47, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0x9F2
            private static Player Florian_Fauna = new Player(130, 100, 57, 67, 56, 52, 56, 66, 55, 409, 60, 64, 14, 16, 15, 13, 14, 16, 16, 64, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0x9F3
            private static Player Clark_Tappen = new Player(134, 102, 44, 53, 57, 56, 57, 58, 53, 378, 44, 45, 6, 4, 6, 5, 6, 7, 8, 45, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9F4
            private static Player Ryan_O_Laugh = new Player(118, 97, 52, 54, 53, 53, 54, 54, 56, 376, 59, 62, 17, 13, 14, 13, 15, 14, 14, 62, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0x9F5
            private static Player Rod_Sweeper = new Player(133, 100, 57, 56, 57, 60, 51, 56, 53, 390, 51, 49, 11, 7, 8, 15, 8, 12, 9, 49, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9F6
            private static Player Reg_Strimmer = new Player(138, 101, 56, 54, 54, 56, 57, 60, 54, 391, 52, 53, 14, 8, 10, 16, 8, 9, 8, 53, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0x9F7
            private static Player Will_Ramin = new Player(94, 100, 44, 56, 51, 54, 62, 57, 53, 377, 49, 49, 14, 8, 7, 9, 15, 12, 8, 49, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0x9F8
            private static Player Andy_Fudge = new Player(105, 127, 60, 66, 65, 59, 46, 63, 57, 416, 59, 47, 15, 11, 13, 17, 15, 19, 13, 47, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0x9F9
            private static Player Tate_Immy = new Player(119, 98, 60, 47, 60, 44, 57, 60, 48, 376, 62, 47, 11, 10, 17, 8, 11, 17, 10, 47, 1, 1, 5, 2, 5, 1, 4, 5, 2); // 0x9FA
            private static Player Gerald_Pourer = new Player(127, 95, 57, 56, 41, 56, 41, 67, 54, 372, 69, 48, 7, 8, 11, 14, 10, 20, 8, 48, 1, 2, 1, 5, 2, 1, 2, 1, 1); // 0x9FB
            private static Player Nate_Checker = new Player(119, 105, 57, 57, 56, 60, 65, 56, 56, 407, 55, 52, 17, 14, 10, 12, 19, 14, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0x9FC
            private static Player Bomber_Pikes = new Player(108, 144, 49, 56, 58, 51, 53, 57, 56, 380, 51, 47, 10, 13, 17, 13, 7, 8, 9, 47, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9FD
            private static Player Gary_Burdine = new Player(126, 94, 62, 62, 61, 63, 65, 41, 63, 417, 48, 48, 12, 11, 11, 14, 14, 8, 11, 48, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0x9FE
            private static Player Chloe_Glazier = new Player(96, 88, 48, 57, 56, 55, 55, 54, 51, 376, 43, 47, 7, 12, 15, 18, 8, 7, 10, 47, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0x9FF
            private static Player Reed_Harpen = new Player(90, 132, 58, 53, 53, 59, 48, 60, 51, 382, 49, 54, 7, 11, 10, 11, 9, 10, 10, 54, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA00
            private static Player Beat_Scatton = new Player(124, 91, 51, 50, 48, 56, 59, 56, 56, 376, 52, 49, 9, 7, 6, 11, 15, 10, 10, 49, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA01
            private static Player Al_Itchen = new Player(124, 100, 53, 52, 55, 51, 58, 60, 57, 386, 44, 54, 8, 8, 7, 11, 11, 11, 7, 54, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA02
            private static Player Rock_Poulon = new Player(93, 132, 51, 60, 50, 57, 51, 58, 57, 384, 49, 58, 11, 8, 13, 14, 10, 17, 8, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA03
            private static Player Beau_Hammock = new Player(105, 126, 56, 56, 55, 56, 53, 57, 52, 385, 60, 58, 10, 12, 13, 12, 13, 11, 14, 58, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0xA04
            private static Player Clef_Bassett = new Player(120, 94, 46, 53, 57, 54, 60, 56, 56, 382, 48, 48, 12, 7, 10, 7, 15, 11, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA05
            private static Player Ovie_Whisker = new Player(119, 105, 63, 54, 59, 44, 53, 51, 54, 378, 52, 58, 11, 10, 15, 9, 8, 8, 9, 58, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA06
            private static Player Bill_Clanger = new Player(111, 93, 63, 56, 56, 57, 52, 53, 53, 390, 65, 60, 15, 13, 15, 14, 15, 14, 15, 60, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0xA07
            private static Player Mary_Cramer = new Player(75, 132, 37, 48, 47, 50, 56, 49, 44, 331, 45, 46, 10, 4, 8, 5, 12, 11, 7, 46, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA08
            private static Player Ralph_Vance = new Player(126, 105, 56, 61, 64, 52, 59, 59, 57, 408, 57, 54, 10, 14, 16, 13, 11, 13, 13, 54, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA09
            private static Player Ray_Bowing = new Player(121, 109, 56, 61, 59, 62, 56, 59, 59, 412, 57, 55, 10, 13, 13, 11, 12, 14, 13, 55, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xA0A
            private static Player Vick_Pointer = new Player(111, 91, 60, 56, 51, 54, 56, 56, 57, 390, 59, 43, 20, 17, 10, 13, 12, 11, 14, 43, 5, 1, 1, 1, 1, 5, 1, 1, 2); // 0xA0B
            private static Player Skip_Docker = new Player(119, 101, 65, 62, 62, 62, 50, 60, 57, 418, 55, 49, 8, 7, 6, 8, 7, 5, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA0C
            private static Player Becky_Shuffle = new Player(98, 122, 60, 63, 62, 60, 48, 60, 61, 414, 58, 45, 17, 13, 15, 17, 16, 20, 10, 45, 5, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA0D
            private static Player Esther_Egerer = new Player(98, 127, 65, 51, 54, 57, 51, 56, 60, 394, 60, 45, 18, 16, 11, 12, 11, 10, 14, 45, 5, 1, 1, 1, 5, 1, 1, 1, 3); // 0xA0E
            private static Player Mia_Pitchford = new Player(75, 134, 57, 60, 48, 60, 53, 56, 52, 386, 48, 59, 11, 8, 11, 16, 12, 14, 9, 59, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA0F
            private static Player Philippa_Konik = new Player(75, 138, 59, 59, 57, 59, 60, 37, 59, 390, 45, 42, 14, 14, 11, 10, 14, 4, 13, 42, 2, 2, 2, 2, 2, 2, 2, 5, 3); // 0xA10
            private static Player Amy_Stinger = new Player(107, 134, 46, 56, 57, 48, 57, 54, 51, 369, 56, 60, 7, 9, 17, 9, 10, 10, 10, 60, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA11
            private static Player Nancy_Polearm = new Player(112, 116, 56, 61, 57, 60, 61, 62, 58, 415, 61, 58, 15, 17, 16, 15, 15, 15, 15, 58, 4, 4, 4, 4, 4, 4, 4, 5, 1); // 0xA12
            private static Player Sally_Tare = new Player(89, 122, 54, 53, 49, 47, 46, 56, 56, 361, 52, 45, 14, 14, 10, 7, 7, 9, 7, 45, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0xA13
            private static Player Anna_Bugeisha = new Player(100, 118, 56, 45, 44, 56, 64, 58, 60, 383, 60, 56, 12, 13, 5, 11, 18, 14, 11, 56, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA14
            private static Player Stu_Hoofer = new Player(126, 100, 53, 58, 65, 51, 57, 57, 60, 401, 60, 55, 11, 15, 18, 13, 14, 13, 11, 55, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA15
            private static Player Coe_Dachy = new Player(99, 130, 57, 55, 56, 59, 48, 58, 57, 390, 49, 49, 9, 10, 10, 14, 11, 10, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA16
            private static Player Flip_Sliden = new Player(108, 124, 53, 60, 58, 58, 64, 61, 59, 413, 52, 55, 17, 10, 11, 14, 18, 17, 12, 55, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA17
            private static Player Jesse_Spiller = new Player(117, 91, 60, 59, 53, 56, 53, 60, 62, 403, 54, 47, 19, 17, 10, 12, 12, 12, 10, 47, 5, 1, 1, 1, 5, 1, 1, 1, 4); // 0xA18
            private static Player Kate_Later = new Player(103, 132, 50, 56, 62, 45, 56, 57, 54, 380, 55, 54, 7, 11, 16, 8, 8, 10, 7, 54, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA19
            private static Player Clara_Tompkins = new Player(92, 124, 60, 41, 44, 39, 44, 56, 54, 338, 49, 46, 13, 7, 8, 6, 9, 9, 9, 46, 5, 1, 1, 1, 1, 5, 1, 1, 2); // 0xA1A
            private static Player Betty_Backer = new Player(96, 90, 51, 63, 50, 51, 48, 57, 53, 373, 50, 59, 16, 12, 15, 15, 13, 20, 12, 59, 5, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA1B
            private static Player Thomas_Worth = new Player(121, 107, 61, 56, 61, 60, 59, 61, 60, 418, 55, 56, 14, 15, 14, 16, 14, 16, 17, 56, 1, 2, 4, 4, 4, 4, 4, 5, 3); // 0xA1C
            private static Player Brenda_Brandish = new Player(75, 148, 60, 56, 56, 58, 38, 58, 53, 379, 50, 50, 11, 10, 9, 12, 5, 7, 8, 50, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA1D
            private static Player Isla_Pullens = new Player(108, 125, 67, 59, 56, 67, 49, 60, 60, 418, 60, 56, 12, 13, 13, 17, 12, 12, 14, 56, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA1E
            private static Player Bob_Jammen = new Player(92, 137, 67, 60, 62, 63, 37, 67, 60, 416, 48, 45, 7, 5, 5, 5, 7, 8, 7, 45, 1, 5, 1, 1, 2, 5, 2, 1, 2); // 0xA1F
            private static Player Hank_Cranker = new Player(100, 95, 54, 60, 46, 61, 51, 56, 53, 381, 47, 59, 11, 9, 10, 17, 12, 16, 7, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA20
            private static Player Prunella_Keep = new Player(104, 122, 54, 51, 53, 55, 51, 56, 54, 374, 59, 54, 12, 14, 11, 12, 11, 12, 12, 54, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0xA21
            private static Player Jimmy_Brim = new Player(120, 91, 45, 46, 57, 50, 47, 50, 51, 346, 44, 49, 8, 8, 11, 8, 7, 5, 8, 49, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA22
            private static Player Verity_Soliz = new Player(99, 132, 46, 56, 56, 50, 56, 57, 54, 375, 52, 62, 8, 9, 14, 10, 11, 9, 10, 62, 2, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA23
            private static Player Yve_Dunbar = new Player(114, 134, 53, 62, 59, 65, 56, 67, 67, 429, 60, 55, 13, 12, 11, 23, 12, 11, 23, 55, 5, 5, 1, 2, 2, 1, 2, 2, 4); // 0xA24
            private static Player Cat_Selima = new Player(98, 128, 57, 60, 54, 56, 54, 62, 51, 394, 49, 55, 13, 12, 10, 17, 12, 19, 13, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA25
            private static Player Aurie_Garmer = new Player(89, 132, 53, 59, 46, 62, 51, 59, 53, 383, 48, 52, 9, 9, 12, 17, 11, 16, 8, 52, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA26
            private static Player Lana_Service = new Player(101, 122, 57, 66, 59, 64, 59, 57, 62, 424, 55, 58, 10, 14, 12, 17, 11, 16, 14, 58, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA27
            private static Player Claire_Voyant = new Player(103, 127, 58, 61, 59, 60, 59, 56, 56, 409, 57, 55, 12, 12, 11, 18, 13, 14, 12, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA28
            private static Player Algy_Kelp = new Player(91, 124, 57, 60, 48, 59, 56, 57, 53, 390, 44, 45, 6, 8, 7, 4, 5, 5, 6, 45, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA29
            private static Player Ann_Taisie = new Player(117, 129, 62, 58, 60, 60, 59, 57, 62, 418, 61, 61, 16, 16, 17, 13, 16, 14, 16, 61, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0xA2A
            private static Player Kelly_Scrivens = new Player(99, 125, 56, 53, 51, 51, 52, 56, 51, 370, 53, 42, 14, 11, 8, 7, 8, 7, 11, 42, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0xA2B
            private static Player Fern_Mycota = new Player(85, 130, 54, 53, 51, 54, 49, 54, 48, 363, 50, 45, 5, 5, 4, 10, 5, 6, 5, 45, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA2C
            private static Player Lara_Creamer = new Player(107, 132, 50, 55, 56, 44, 54, 53, 53, 365, 54, 49, 11, 12, 14, 9, 8, 7, 10, 49, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA2D
            private static Player Kim_Knotted = new Player(75, 138, 47, 55, 53, 57, 60, 54, 56, 382, 47, 47, 14, 8, 11, 11, 15, 12, 8, 47, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA2E
            private static Player Nina_Trowel = new Player(94, 130, 56, 51, 47, 47, 44, 53, 52, 350, 55, 49, 17, 12, 8, 11, 8, 8, 10, 49, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0xA2F
            private static Player Harriet_Reaching = new Player(113, 124, 56, 59, 60, 58, 57, 57, 59, 406, 64, 63, 16, 14, 16, 15, 13, 17, 14, 63, 4, 4, 4, 4, 4, 5, 4, 4, 3); // 0xA30
            private static Player Sadey_Stewer = new Player(80, 139, 56, 54, 57, 52, 56, 57, 53, 385, 52, 54, 17, 9, 13, 13, 7, 10, 7, 54, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA31
            private static Player June_Stagner = new Player(84, 138, 53, 53, 56, 55, 56, 59, 56, 388, 48, 54, 8, 10, 9, 9, 13, 10, 11, 54, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA32
            private static Player Lacey_Threader = new Player(108, 128, 51, 48, 49, 58, 62, 62, 58, 388, 60, 52, 14, 14, 7, 10, 17, 15, 13, 52, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA33
            private static Player Marcy_Laise = new Player(88, 133, 57, 53, 56, 52, 56, 60, 56, 390, 52, 52, 15, 11, 12, 17, 8, 10, 8, 52, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA34
            private static Player Bella_Shaded = new Player(85, 124, 63, 62, 58, 60, 52, 64, 62, 421, 59, 53, 10, 13, 14, 15, 14, 14, 14, 53, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA35
            private static Player Walter_Trope = new Player(91, 128, 61, 62, 56, 66, 60, 65, 56, 426, 49, 58, 14, 11, 13, 18, 14, 20, 10, 58, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA36
            private static Player Flora_Summars = new Player(94, 129, 57, 59, 57, 62, 51, 51, 54, 391, 52, 49, 11, 10, 11, 15, 11, 11, 9, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA37
            private static Player Lucia_Ander = new Player(100, 130, 53, 54, 56, 56, 53, 51, 57, 380, 59, 63, 16, 14, 17, 13, 13, 13, 15, 63, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xA38
            private static Player Rosy_Roker = new Player(75, 138, 47, 52, 57, 53, 61, 61, 57, 388, 50, 48, 8, 11, 7, 10, 11, 11, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA39
            private static Player Pam_Vision = new Player(109, 117, 56, 62, 56, 62, 62, 62, 60, 420, 57, 55, 14, 14, 11, 19, 10, 17, 12, 55, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA3A
            private static Player Ruth_Karnes = new Player(129, 98, 56, 57, 51, 57, 56, 63, 56, 396, 64, 50, 13, 9, 11, 16, 10, 19, 11, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA3B
            private static Player Rose_Bedd = new Player(83, 135, 62, 55, 51, 62, 47, 56, 51, 384, 54, 48, 9, 10, 10, 10, 9, 7, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA3C
            private static Player Bailey_Sitter = new Player(95, 132, 57, 58, 51, 53, 53, 61, 57, 390, 57, 45, 20, 15, 12, 12, 11, 13, 10, 45, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0xA3D
            private static Player Adel_Tactor = new Player(99, 91, 56, 56, 57, 58, 39, 58, 54, 378, 46, 52, 10, 11, 11, 12, 10, 7, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA3E
            private static Player Emma_Barres = new Player(89, 130, 47, 50, 48, 53, 47, 51, 52, 348, 54, 49, 7, 11, 11, 11, 9, 9, 9, 49, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0xA3F
            private static Player Orpah_Talkington = new Player(97, 126, 51, 46, 45, 62, 61, 60, 58, 383, 59, 56, 13, 13, 6, 12, 18, 13, 12, 56, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA40
            private static Player Sable_Tatter = new Player(98, 126, 56, 58, 58, 58, 62, 60, 61, 413, 56, 54, 16, 12, 11, 11, 17, 14, 14, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA41
            private static Player Shu_Maimai = new Player(106, 124, 62, 51, 56, 60, 39, 58, 67, 393, 50, 54, 8, 9, 10, 12, 8, 6, 10, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA42
            private static Player Sym_Copate = new Player(120, 100, 62, 65, 57, 65, 62, 63, 60, 434, 48, 58, 12, 10, 14, 18, 15, 19, 10, 58, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA43
            private static Player Jerry_Bateman = new Player(122, 91, 51, 50, 50, 51, 62, 51, 53, 368, 55, 47, 8, 9, 8, 11, 15, 12, 7, 47, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA44
            private static Player Fonda_Katz = new Player(101, 123, 57, 51, 56, 57, 54, 55, 55, 385, 57, 52, 12, 14, 12, 12, 11, 12, 11, 52, 4, 4, 4, 4, 4, 5, 4, 4, 2); // 0xA45
            private static Player Beck_Hand = new Player(93, 136, 53, 56, 62, 60, 63, 63, 62, 419, 49, 53, 12, 10, 11, 12, 15, 16, 13, 53, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA46
            private static Player Sandra_Mudd = new Player(95, 133, 48, 57, 62, 46, 53, 56, 56, 378, 49, 51, 11, 10, 13, 8, 7, 9, 7, 51, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA47
            private static Player Alexis_Watchorn = new Player(91, 134, 47, 48, 44, 55, 59, 55, 52, 360, 49, 52, 8, 8, 8, 7, 16, 12, 9, 52, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA48
            private static Player Pete_Manter = new Player(112, 94, 57, 57, 63, 53, 52, 53, 51, 386, 57, 52, 12, 12, 12, 12, 10, 14, 13, 52, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xA49
            private static Player Chris_Country = new Player(116, 105, 51, 47, 46, 60, 60, 56, 62, 382, 55, 58, 10, 13, 4, 10, 20, 14, 12, 58, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA4A
            private static Player Paul_Steed = new Player(91, 132, 62, 65, 63, 58, 48, 60, 60, 416, 50, 58, 16, 14, 14, 14, 13, 18, 13, 58, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA4B
            private static Player Ben_Whistler = new Player(122, 92, 51, 45, 45, 56, 62, 56, 52, 367, 50, 54, 9, 8, 7, 11, 16, 13, 9, 54, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA4C
            private static Player Roman_Blac = new Player(105, 122, 56, 65, 56, 60, 60, 58, 57, 412, 57, 55, 13, 10, 11, 17, 12, 14, 12, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA4D
            private static Player Lewis_Brownie = new Player(94, 145, 56, 61, 57, 67, 58, 63, 58, 420, 48, 60, 12, 10, 17, 19, 16, 17, 11, 60, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA4E
            private static Player Connor_Seuer = new Player(126, 102, 57, 56, 62, 59, 56, 56, 56, 402, 59, 63, 15, 17, 15, 15, 15, 16, 16, 63, 4, 4, 4, 5, 4, 4, 4, 4, 2); // 0xA4F
            private static Player Kaya_Haskell = new Player(75, 132, 61, 56, 51, 59, 43, 58, 51, 379, 52, 49, 8, 7, 10, 11, 9, 11, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA50
            private static Player Minnie_Stratio = new Player(96, 128, 44, 53, 59, 50, 51, 54, 53, 364, 50, 64, 11, 10, 16, 9, 7, 11, 10, 64, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xA51
            private static Player Elegance_Stuckon = new Player(85, 126, 52, 60, 46, 60, 53, 60, 53, 384, 46, 55, 9, 10, 12, 15, 14, 14, 9, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA52
            private static Player Odette_Musetta = new Player(90, 127, 58, 53, 56, 56, 46, 57, 51, 377, 54, 52, 8, 10, 7, 14, 9, 11, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA53
            private static Player Gertrude_Choker = new Player(102, 128, 51, 55, 52, 51, 56, 54, 52, 371, 61, 58, 14, 14, 17, 17, 14, 16, 16, 58, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0xA54
            private static Player Polly_Targest = new Player(96, 129, 53, 59, 55, 62, 51, 51, 53, 384, 55, 51, 7, 8, 8, 15, 11, 12, 11, 51, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA55
            private static Player Odessa_Ryder = new Player(96, 122, 51, 54, 54, 53, 51, 56, 53, 372, 60, 53, 12, 12, 13, 14, 11, 10, 11, 53, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xA56
            private static Player Robyn_Weaver = new Player(87, 129, 51, 48, 49, 49, 51, 51, 48, 347, 55, 49, 8, 9, 9, 7, 10, 11, 9, 49, 4, 4, 4, 4, 4, 4, 4, 5, 5); // 0xA57
            private static Player Tess_Masters = new Player(85, 127, 60, 53, 52, 56, 44, 57, 56, 378, 56, 51, 10, 10, 11, 12, 9, 8, 11, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA58
            private static Player Cale_Sticklin = new Player(104, 120, 55, 56, 56, 60, 53, 56, 54, 390, 52, 52, 8, 9, 9, 13, 11, 14, 8, 52, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA59
            private static Player Farris_Stickman = new Player(120, 100, 53, 59, 56, 56, 53, 56, 53, 386, 54, 48, 9, 9, 10, 15, 8, 13, 8, 48, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA5A
            private static Player Tim_Personator = new Player(120, 97, 59, 53, 53, 60, 48, 62, 56, 391, 49, 48, 7, 9, 8, 11, 8, 10, 9, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA5B
            private static Player Sherlock_Sagers = new Player(119, 101, 60, 52, 51, 61, 36, 60, 56, 376, 50, 54, 8, 7, 9, 12, 7, 8, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA5C
            private static Player Ryan_Haywood = new Player(114, 108, 52, 51, 51, 53, 53, 51, 51, 362, 56, 56, 11, 10, 12, 10, 13, 13, 11, 56, 1, 1, 1, 5, 1, 1, 1, 1, 3); // 0xA5D
            private static Player Osier_Twining = new Player(102, 126, 48, 46, 48, 51, 57, 55, 57, 362, 52, 51, 11, 10, 7, 8, 13, 12, 9, 51, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA5E
            private static Player Rock_Scowlon = new Player(93, 123, 48, 48, 44, 56, 58, 53, 54, 361, 56, 49, 9, 8, 7, 10, 16, 11, 8, 49, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA5F
            private static Player Al_Stringer = new Player(109, 118, 51, 52, 51, 54, 51, 56, 51, 366, 59, 53, 10, 14, 12, 11, 11, 13, 12, 53, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0xA60
            private static Player Bill_Fierce = new Player(122, 92, 58, 56, 51, 56, 51, 57, 53, 382, 60, 49, 15, 7, 14, 15, 8, 15, 10, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA61
            private static Player Rob_Otts = new Player(122, 105, 45, 47, 47, 46, 46, 44, 45, 320, 54, 47, 5, 7, 5, 8, 6, 5, 7, 47, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xA62
            private static Player Chad_Jowell = new Player(119, 98, 63, 57, 57, 56, 56, 56, 53, 398, 53, 49, 15, 11, 12, 17, 11, 10, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA63
            private static Player Egon_Omercer = new Player(124, 102, 56, 60, 51, 65, 51, 58, 62, 403, 57, 58, 10, 15, 11, 12, 12, 14, 12, 58, 1, 2, 1, 1, 1, 5, 1, 1, 3); // 0xA64
            private static Player Luis_Springs = new Player(125, 95, 53, 51, 53, 51, 54, 57, 67, 386, 60, 53, 12, 11, 10, 10, 11, 11, 14, 53, 1, 1, 1, 1, 1, 1, 1, 5, 3); // 0xA65
            private static Player Bruce_Barkley = new Player(130, 88, 66, 66, 53, 60, 62, 65, 66, 438, 56, 54, 20, 14, 11, 11, 10, 11, 23, 54, 5, 2, 1, 5, 5, 1, 2, 2, 4); // 0xA66
            private static Player Chip_Spacek = new Player(120, 100, 62, 61, 61, 66, 48, 63, 57, 418, 59, 55, 10, 14, 13, 15, 14, 14, 11, 55, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA67
            private static Player Mason_Tirell = new Player(119, 92, 52, 56, 53, 56, 57, 57, 57, 388, 48, 52, 11, 11, 11, 10, 12, 12, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA68
            private static Player Dale_Riverhead = new Player(94, 129, 62, 58, 56, 58, 59, 62, 57, 412, 57, 59, 12, 14, 13, 15, 16, 15, 15, 59, 1, 2, 4, 4, 5, 4, 4, 4, 3); // 0xA69
            private static Player Adelpha_Lovelace = new Player(92, 134, 62, 60, 59, 63, 60, 56, 60, 420, 60, 57, 11, 13, 12, 19, 13, 17, 12, 57, 1, 1, 5, 1, 5, 1, 1, 1, 5); // 0xA6A
            private static Player Egon_Timing = new Player(94, 114, 50, 52, 48, 51, 45, 50, 45, 341, 51, 48, 7, 7, 8, 13, 6, 8, 7, 48, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA6B
            private static Player Tony_Frogge = new Player(93, 125, 52, 56, 47, 47, 51, 53, 53, 359, 49, 45, 17, 14, 9, 9, 10, 9, 8, 45, 5, 1, 1, 1, 1, 1, 1, 5, 2); // 0xA6C
            private static Player Fred_Punch = new Player(104, 119, 50, 60, 64, 60, 56, 54, 51, 395, 52, 64, 7, 8, 15, 11, 8, 9, 8, 64, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA6D
            private static Player Hannibal_Whipp = new Player(118, 93, 44, 57, 58, 44, 53, 54, 57, 367, 51, 48, 8, 15, 13, 7, 7, 8, 9, 48, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA6E
            private static Player Luke_Severin = new Player(118, 97, 53, 57, 53, 51, 54, 57, 57, 382, 54, 57, 11, 12, 14, 11, 12, 13, 12, 57, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0xA6F
            private static Player Harry_Keenan = new Player(117, 111, 60, 60, 60, 67, 62, 62, 57, 428, 59, 54, 11, 13, 13, 16, 13, 15, 10, 54, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA70
            private static Player Nick_Uman = new Player(133, 91, 62, 56, 53, 56, 53, 56, 51, 387, 49, 53, 16, 10, 11, 16, 9, 9, 8, 53, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xA71
            private static Player Mac_Robat = new Player(94, 116, 56, 65, 54, 62, 62, 66, 59, 424, 46, 57, 12, 14, 14, 19, 15, 19, 13, 57, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA72
            private static Player Ace_Slider = new Player(120, 101, 63, 60, 58, 63, 48, 60, 60, 412, 56, 57, 13, 12, 14, 15, 10, 14, 11, 57, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA73
            private static Player Olivia_Twist = new Player(106, 125, 62, 56, 53, 53, 53, 58, 60, 395, 59, 45, 17, 16, 10, 11, 13, 13, 13, 45, 5, 1, 5, 1, 1, 1, 1, 1, 3); // 0xA74
            private static Player Wiley_Blinks = new Player(113, 97, 52, 58, 41, 56, 39, 53, 56, 355, 64, 60, 17, 13, 8, 17, 5, 14, 17, 60, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0xA75
            private static Player Shona_Shopbell = new Player(88, 100, 65, 58, 57, 56, 57, 58, 56, 407, 54, 54, 13, 15, 16, 16, 16, 17, 13, 54, 1, 2, 4, 5, 4, 4, 4, 4, 4); // 0xA76
            private static Player Crystal_Clears = new Player(98, 123, 52, 56, 57, 53, 62, 55, 52, 387, 61, 60, 13, 17, 16, 14, 14, 13, 14, 60, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0xA77
            private static Player Beata_Pummel = new Player(119, 105, 37, 58, 57, 56, 60, 62, 62, 392, 60, 47, 6, 15, 16, 17, 15, 15, 13, 47, 1, 4, 1, 1, 1, 1, 5, 1, 1); // 0xA78
            private static Player Aya_Strand = new Player(94, 93, 46, 50, 58, 57, 58, 55, 53, 377, 48, 58, 16, 12, 12, 13, 12, 11, 10, 58, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xA79
            private static Player Tara_Gaudier = new Player(90, 129, 58, 63, 57, 60, 56, 63, 57, 414, 46, 57, 12, 10, 17, 18, 14, 18, 13, 57, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA7A
            private static Player James_Hearson = new Player(120, 103, 46, 49, 46, 44, 47, 50, 44, 326, 68, 66, 19, 16, 16, 20, 16, 18, 17, 66, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xA7B
            private static Player Anne_Somnia = new Player(99, 130, 46, 51, 51, 56, 60, 56, 51, 371, 43, 43, 10, 10, 7, 9, 10, 12, 11, 43, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xA7C
            private static Player Pearl_Wann = new Player(79, 132, 49, 55, 54, 57, 66, 53, 54, 388, 44, 47, 12, 9, 9, 9, 18, 13, 8, 47, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA7D
            private static Player Hugh_Dunnit = new Player(120, 107, 65, 60, 60, 66, 46, 63, 59, 419, 56, 56, 14, 13, 14, 16, 14, 13, 11, 56, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA7E
            private static Player Steve_Squander = new Player(126, 100, 66, 57, 41, 60, 36, 58, 65, 383, 61, 64, 17, 17, 7, 13, 5, 15, 17, 64, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xA7F
            private static Player Lehman_Rind = new Player(124, 91, 44, 52, 60, 47, 54, 55, 54, 366, 49, 52, 10, 12, 17, 7, 8, 10, 10, 52, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA80
            private static Player Ian_Fantile = new Player(120, 98, 50, 41, 38, 51, 65, 56, 51, 352, 54, 53, 11, 8, 8, 9, 17, 10, 8, 53, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xA81
            private static Player Zach_Putter = new Player(118, 92, 55, 51, 52, 53, 52, 51, 54, 368, 61, 63, 13, 15, 16, 17, 17, 14, 17, 63, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0xA82
            private static Player Juan_Word = new Player(120, 104, 56, 53, 47, 48, 51, 51, 54, 360, 49, 46, 15, 13, 9, 8, 10, 9, 10, 46, 5, 1, 1, 1, 1, 1, 1, 5, 3); // 0xA83
            private static Player Alex_Copple = new Player(120, 100, 63, 62, 60, 61, 60, 58, 60, 424, 54, 53, 13, 15, 16, 15, 14, 16, 15, 53, 1, 2, 4, 5, 4, 4, 4, 4, 2); // 0xA84
            private static Player Jan_Jared = new Player(89, 128, 55, 52, 51, 55, 47, 51, 50, 361, 49, 42, 5, 7, 6, 8, 5, 5, 5, 42, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA85
            private static Player Bigsby_Pigford = new Player(116, 100, 53, 51, 50, 58, 60, 56, 60, 388, 56, 54, 14, 13, 4, 11, 16, 14, 12, 54, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xA86
            private static Player Erica_Hogland = new Player(98, 122, 46, 55, 59, 51, 51, 51, 54, 367, 50, 50, 9, 13, 16, 9, 10, 8, 10, 50, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xA87
            private static Player Ramona_Wriston = new Player(97, 91, 56, 53, 53, 56, 48, 49, 57, 372, 48, 51, 7, 9, 9, 12, 8, 7, 10, 51, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xA88
            private static Player Mark_Izushy = new Player(120, 105, 67, 58, 56, 66, 50, 61, 62, 420, 60, 56, 12, 12, 13, 15, 11, 11, 13, 56, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA89
            private static Player Vince_Tinct = new Player(132, 100, 65, 62, 56, 53, 56, 61, 60, 413, 60, 56, 13, 15, 14, 14, 13, 10, 11, 56, 1, 2, 1, 1, 5, 1, 1, 1, 3); // 0xA8A
            private static Player Daryl_Floor = new Player(90, 132, 62, 56, 56, 51, 57, 62, 51, 395, 50, 47, 13, 9, 13, 15, 9, 7, 10, 47, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xA8B
            private static Player Becca_Pilgreen = new Player(103, 129, 58, 65, 56, 64, 60, 59, 62, 424, 55, 55, 10, 13, 12, 18, 12, 17, 10, 55, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA8C
            private static Player Langley_Span = new Player(124, 95, 53, 58, 52, 61, 54, 56, 57, 391, 45, 52, 9, 11, 10, 13, 11, 17, 8, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA8D
            private static Player Swithin_Sainte = new Player(118, 94, 51, 57, 51, 56, 54, 57, 53, 379, 60, 57, 11, 13, 14, 10, 10, 14, 10, 57, 4, 4, 4, 4, 4, 5, 4, 4, 3); // 0xA8E
            private static Player Dan_Cawarry = new Player(114, 101, 61, 51, 51, 57, 53, 57, 62, 392, 60, 58, 12, 13, 12, 14, 11, 13, 12, 58, 2, 2, 2, 2, 5, 2, 2, 2, 1); // 0xA8F
            private static Player Hans_Freesing = new Player(124, 105, 60, 62, 65, 59, 46, 63, 59, 414, 44, 60, 13, 13, 16, 14, 15, 16, 11, 60, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xA90
            private static Player Peter_Fakhoury = new Player(94, 136, 50, 51, 54, 57, 67, 56, 57, 392, 48, 53, 10, 9, 10, 8, 14, 12, 8, 53, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xA91
            private static Player Steve_Sancey = new Player(91, 116, 60, 61, 63, 62, 63, 39, 66, 414, 49, 46, 13, 13, 10, 11, 11, 4, 12, 46, 1, 2, 2, 2, 5, 2, 1, 2, 2); // 0xA92
            private static Player Michael_Gibe = new Player(117, 93, 53, 57, 57, 51, 63, 51, 57, 389, 65, 59, 15, 16, 15, 17, 16, 17, 15, 59, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xA93
            private static Player Skeet_Blaston = new Player(113, 118, 54, 51, 53, 57, 53, 53, 56, 377, 63, 60, 17, 13, 15, 16, 17, 17, 15, 60, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0xA94
            private static Player Achilles_Chinner = new Player(125, 101, 56, 57, 56, 62, 60, 61, 60, 412, 62, 62, 13, 13, 13, 17, 16, 15, 16, 62, 1, 1, 1, 1, 5, 1, 1, 1, 2); // 0xA95
            private static Player Scott_Tickle = new Player(119, 91, 53, 62, 46, 58, 53, 56, 51, 379, 50, 55, 8, 8, 11, 16, 11, 16, 8, 55, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xA96
            private static Player Junior_Cage = new Player(94, 122, 45, 55, 54, 56, 67, 53, 57, 387, 45, 51, 12, 9, 8, 8, 10, 11, 10, 51, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA97
            private static Player Terry_Namby = new Player(120, 110, 49, 44, 45, 48, 44, 47, 47, 324, 50, 60, 14, 8, 9, 11, 7, 9, 9, 60, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0xA98
            private static Player Joe_Chugger = new Player(117, 111, 58, 66, 59, 63, 59, 59, 57, 421, 55, 58, 14, 11, 10, 19, 13, 16, 14, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA99
            private static Player Sonny_Cinders = new Player(118, 86, 63, 53, 47, 48, 47, 53, 52, 363, 50, 49, 16, 12, 11, 10, 10, 8, 8, 49, 5, 5, 1, 1, 1, 1, 1, 1, 1); // 0xA9A
            private static Player Cash_Winfall = new Player(106, 116, 47, 53, 60, 50, 53, 51, 51, 365, 52, 52, 9, 14, 14, 10, 10, 11, 9, 52, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xA9B
            private static Player Lou_Fauntleroy = new Player(93, 123, 54, 60, 60, 56, 63, 60, 62, 415, 53, 55, 13, 13, 12, 13, 18, 15, 13, 55, 5, 1, 1, 1, 1, 2, 5, 1, 4); // 0xA9C
            private static Player Carol_Chanter = new Player(83, 133, 47, 56, 52, 52, 58, 56, 51, 372, 50, 54, 9, 8, 9, 9, 13, 14, 7, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xA9D
            private static Player Guy_Kogan = new Player(120, 99, 56, 65, 64, 56, 47, 61, 56, 405, 44, 58, 16, 10, 15, 13, 13, 16, 12, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xA9E
            private static Player Max_Motto = new Player(110, 119, 57, 53, 54, 53, 52, 53, 53, 375, 61, 61, 16, 13, 16, 14, 15, 14, 17, 61, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0xA9F
            private static Player Perry_Postiche = new Player(130, 94, 62, 55, 53, 56, 53, 53, 54, 386, 55, 51, 17, 8, 12, 15, 9, 9, 11, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA0
            private static Player Nelson_Levene = new Player(99, 122, 56, 55, 51, 58, 50, 57, 53, 380, 55, 48, 8, 9, 11, 11, 11, 11, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAA1
            private static Player Kurt_Sermons = new Player(124, 105, 66, 60, 56, 64, 51, 61, 58, 416, 57, 55, 12, 14, 13, 15, 12, 13, 12, 55, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA2
            private static Player Ed_Hartsell = new Player(119, 95, 56, 56, 54, 57, 51, 58, 54, 386, 49, 54, 13, 10, 13, 14, 11, 9, 8, 54, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAA3
            private static Player Chester_Takes = new Player(120, 109, 56, 60, 57, 60, 55, 51, 53, 392, 50, 66, 8, 11, 10, 14, 8, 14, 11, 66, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAA4
            private static Player Curtis_Rebell = new Player(120, 100, 53, 56, 64, 57, 56, 57, 60, 403, 60, 57, 11, 15, 17, 13, 10, 13, 11, 57, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xAA5
            private static Player Cody_Fink = new Player(99, 128, 54, 60, 57, 59, 62, 66, 59, 417, 44, 59, 12, 13, 12, 14, 15, 14, 11, 59, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAA6
            private static Player Siria_Chattsley = new Player(107, 127, 58, 63, 56, 61, 60, 56, 60, 414, 57, 55, 11, 12, 10, 19, 11, 15, 13, 55, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xAA7
            private static Player Darren_Catt = new Player(118, 93, 60, 54, 51, 56, 44, 60, 56, 381, 52, 48, 10, 11, 11, 12, 8, 9, 8, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAA8
            private static Player Garry_Planer = new Player(122, 97, 51, 52, 57, 52, 57, 52, 56, 377, 53, 53, 8, 14, 15, 8, 7, 8, 8, 53, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xAA9
            private static Player Glenn_Broth = new Player(120, 100, 53, 56, 51, 56, 56, 51, 53, 376, 59, 64, 14, 13, 16, 16, 17, 16, 15, 64, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0xAAA
            private static Player Harry_Angue = new Player(133, 94, 51, 60, 51, 56, 54, 61, 55, 388, 47, 58, 10, 9, 12, 15, 14, 16, 9, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAAB
            private static Player Benny_Terra = new Player(94, 137, 41, 39, 37, 46, 53, 44, 63, 323, 44, 49, 7, 4, 4, 8, 13, 9, 7, 49, 5, 1, 1, 5, 1, 2, 5, 2, 1); // 0xAAC
            private static Player Jasmine_Veile = new Player(98, 124, 63, 56, 62, 63, 51, 63, 59, 417, 56, 52, 12, 11, 14, 15, 10, 11, 12, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAAD
            private static Player Belle_Allure = new Player(96, 127, 57, 53, 46, 57, 63, 59, 61, 396, 58, 55, 12, 11, 7, 11, 17, 15, 11, 55, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xAAE
            private static Player Doug_Lapp = new Player(120, 108, 59, 65, 57, 65, 60, 58, 62, 426, 57, 58, 13, 11, 12, 20, 14, 14, 14, 58, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xAAF
            private static Player Eric_Motter = new Player(109, 119, 49, 51, 56, 67, 51, 52, 55, 381, 54, 49, 9, 12, 13, 7, 7, 7, 7, 49, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xAB0
            private static Player Gyll_Netters = new Player(120, 101, 44, 42, 41, 56, 56, 56, 65, 360, 55, 54, 8, 9, 5, 10, 15, 12, 8, 54, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xAB1
            private static Player Farrah_Fairway = new Player(95, 133, 52, 57, 51, 55, 57, 51, 56, 379, 56, 52, 12, 14, 11, 13, 12, 13, 12, 52, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0xAB2
            private static Player Jess_Winkles = new Player(119, 106, 56, 61, 62, 61, 60, 59, 62, 421, 59, 63, 17, 14, 13, 15, 16, 17, 16, 63, 4, 4, 4, 4, 5, 4, 4, 4, 3); // 0xAB3
            private static Player Barbara_Clector = new Player(75, 140, 46, 54, 55, 51, 62, 51, 57, 376, 50, 54, 12, 9, 9, 7, 17, 13, 11, 54, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xAB4
            private static Player Marilyn_Henshaw = new Player(93, 126, 60, 59, 62, 64, 49, 65, 56, 415, 56, 59, 13, 12, 12, 14, 12, 10, 14, 59, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAB5
            private static Player Nancy_Pickney = new Player(83, 134, 53, 56, 50, 44, 49, 52, 57, 361, 50, 49, 13, 14, 10, 8, 8, 10, 7, 49, 5, 1, 1, 1, 1, 1, 1, 5, 3); // 0xAB6
            private static Player Clay_Turnor = new Player(127, 100, 65, 60, 56, 62, 46, 66, 59, 414, 69, 58, 12, 13, 12, 15, 14, 13, 12, 58, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAB7
            private static Player Horace_Shlock = new Player(114, 105, 51, 57, 56, 51, 54, 51, 51, 371, 59, 57, 11, 11, 12, 11, 13, 11, 12, 57, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0xAB8
            private static Player Sabrina_Passman = new Player(89, 138, 66, 62, 60, 62, 51, 61, 62, 424, 54, 55, 12, 12, 14, 17, 12, 11, 11, 55, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAB9
            private static Player Harpo_Thermier = new Player(106, 124, 53, 51, 55, 62, 51, 57, 55, 384, 59, 61, 16, 16, 15, 17, 16, 15, 13, 61, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xABA
            private static Player August_Dyers = new Player(124, 103, 62, 56, 57, 59, 62, 57, 56, 409, 63, 57, 13, 17, 17, 17, 14, 14, 17, 57, 4, 4, 4, 4, 4, 4, 4, 5, 2); // 0xABB
            private static Player Nev_Puffer = new Player(125, 102, 54, 60, 62, 51, 62, 59, 58, 406, 60, 57, 12, 16, 20, 10, 10, 12, 11, 57, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xABC
            private static Player Elata_Mighty = new Player(104, 134, 57, 65, 58, 67, 60, 61, 59, 427, 54, 52, 10, 13, 13, 18, 13, 15, 13, 52, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0xABD
            private static Player Ben_Danna = new Player(122, 107, 56, 63, 54, 65, 61, 62, 57, 418, 50, 59, 13, 14, 14, 19, 16, 20, 13, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xABE
            private static Player Elsa_Roamer = new Player(90, 124, 36, 48, 51, 42, 44, 44, 48, 313, 48, 45, 7, 9, 12, 7, 4, 6, 6, 45, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xABF
            private static Player Archy_Seago = new Player(124, 118, 59, 58, 67, 54, 53, 56, 58, 405, 60, 45, 20, 17, 7, 10, 12, 13, 14, 45, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0xAC0
            private static Player Erhardt_Knead = new Player(130, 96, 48, 39, 42, 51, 67, 42, 52, 341, 74, 49, 10, 9, 5, 9, 21, 5, 7, 49, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAC1
            private static Player Lynne_Mandel = new Player(91, 92, 50, 47, 55, 55, 55, 57, 52, 371, 57, 64, 14, 16, 15, 15, 15, 15, 15, 64, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0xAC2
            private static Player Craig_Placid = new Player(110, 93, 56, 57, 54, 57, 54, 54, 67, 399, 60, 57, 13, 10, 12, 12, 11, 14, 12, 57, 1, 1, 1, 1, 5, 1, 1, 2, 1); // 0xAC3

            private static Player Leon_Morcey = new Player(91, 122, 57, 63, 54, 62, 59, 65, 59, 419, 49, 63, 12, 14, 15, 20, 13, 18, 11, 63, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAC4
            private static Player Dom_Edarry = new Player(99, 126, 54, 52, 53, 51, 55, 51, 56, 372, 54, 53, 10, 10, 11, 12, 14, 12, 12, 53, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xAC5
            private static Player Jay_Asher = new Player(112, 115, 61, 62, 63, 57, 49, 61, 56, 409, 55, 58, 17, 11, 17, 13, 17, 18, 14, 58, 1, 1, 5, 1, 5, 1, 1, 1, 5); // 0xAC6
            private static Player Toby_Cohill = new Player(118, 108, 56, 51, 51, 52, 54, 55, 65, 384, 57, 59, 14, 12, 13, 13, 13, 14, 11, 59, 2, 2, 2, 2, 2, 5, 2, 2, 3); // 0xAC7
            private static Player Nolene_Ider = new Player(80, 136, 51, 53, 52, 56, 57, 60, 53, 382, 48, 52, 11, 11, 11, 7, 12, 13, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xAC8
            private static Player Hoots_Knightly = new Player(121, 108, 61, 65, 51, 62, 59, 64, 57, 419, 49, 58, 11, 11, 15, 19, 14, 19, 13, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAC9
            private static Player Bash_Beaton = new Player(118, 113, 56, 66, 62, 60, 60, 60, 60, 424, 56, 52, 10, 13, 13, 19, 13, 14, 10, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xACA
            private static Player Terry_Toolan = new Player(120, 102, 53, 57, 52, 56, 53, 56, 66, 393, 61, 63, 17, 15, 14, 14, 15, 16, 16, 63, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0xACB
            private static Player Callum_Biddy = new Player(122, 107, 45, 46, 59, 46, 59, 50, 51, 356, 49, 50, 10, 8, 14, 10, 17, 10, 7, 50, 5, 1, 5, 2, 5, 2, 5, 1, 3); // 0xACC
            private static Player Alan_Sumner = new Player(129, 108, 46, 60, 65, 67, 66, 60, 63, 427, 63, 64, 12, 15, 17, 20, 14, 16, 16, 64, 5, 5, 2, 5, 2, 5, 5, 5, 4); // 0xACD
            private static Player Trixy_Wonder = new Player(109, 119, 57, 56, 57, 53, 57, 55, 55, 390, 55, 57, 13, 12, 12, 12, 13, 11, 10, 57, 2, 2, 2, 2, 5, 2, 2, 2, 4); // 0xACE
            private static Player Colet_First = new Player(122, 91, 56, 51, 53, 56, 56, 54, 51, 377, 63, 42, 4, 5, 6, 8, 6, 7, 6, 42, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0xACF
            private static Player Mac_Gabbon = new Player(104, 113, 67, 51, 56, 51, 52, 57, 54, 388, 57, 59, 18, 13, 14, 12, 10, 11, 10, 59, 4, 5, 4, 4, 4, 4, 4, 4, 3); // 0xAD0
            private static Player Tip_Bolster = new Player(111, 93, 46, 56, 62, 47, 54, 53, 51, 369, 51, 48, 8, 12, 13, 7, 7, 10, 11, 48, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xAD1
            private static Player Draco_Scallon = new Player(124, 94, 53, 51, 54, 51, 56, 53, 53, 371, 60, 55, 13, 10, 14, 13, 11, 12, 12, 55, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0xAD2
            private static Player Sofia_Brashier = new Player(138, 94, 56, 60, 56, 66, 62, 58, 60, 418, 56, 58, 11, 12, 12, 19, 14, 13, 10, 58, 1, 1, 5, 1, 5, 1, 1, 1, 4); // 0xAD3
            private static Player Tam_Boyish = new Player(91, 135, 57, 60, 62, 56, 62, 56, 57, 410, 53, 59, 17, 12, 14, 14, 19, 16, 13, 59, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xAD4
            private static Player Mat_Halled = new Player(116, 110, 58, 65, 56, 63, 59, 57, 60, 418, 57, 52, 11, 12, 13, 16, 11, 16, 11, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAD5
            private static Player James_Strang = new Player(130, 95, 49, 51, 56, 56, 56, 66, 53, 387, 66, 50, 13, 7, 10, 9, 17, 16, 9, 50, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAD6
            private static Player Ian_Watchen = new Player(120, 99, 53, 62, 56, 60, 63, 63, 56, 413, 44, 55, 14, 10, 12, 11, 14, 15, 10, 55, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAD7
            private static Player Rose_Snelgrove = new Player(91, 129, 53, 54, 50, 46, 50, 55, 52, 360, 49, 48, 14, 14, 9, 9, 10, 9, 9, 48, 5, 1, 1, 5, 1, 1, 1, 1, 3); // 0xAD8
            private static Player Bert_Emmerson = new Player(113, 95, 44, 57, 63, 47, 53, 53, 51, 368, 53, 48, 10, 13, 15, 9, 7, 11, 11, 48, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xAD9
            private static Player Irving_Gusher = new Player(122, 100, 65, 59, 57, 56, 62, 56, 62, 417, 49, 42, 17, 6, 7, 5, 8, 8, 4, 42, 5, 1, 1, 1, 1, 5, 1, 1, 2); // 0xADA
            private static Player Lionel_Silent = new Player(120, 103, 65, 62, 54, 53, 56, 57, 56, 403, 59, 54, 10, 13, 12, 14, 11, 10, 13, 54, 1, 2, 1, 1, 1, 1, 1, 5, 2); // 0xADB
            private static Player Owen_Rage = new Player(120, 98, 47, 58, 50, 48, 46, 50, 45, 344, 54, 52, 9, 9, 11, 10, 10, 9, 8, 52, 2, 2, 2, 2, 2, 2, 5, 2, 3); // 0xADC
            private static Player Alice_Nutty = new Player(81, 126, 60, 52, 51, 51, 52, 58, 51, 375, 52, 48, 16, 10, 11, 14, 9, 8, 7, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xADD
            private static Player Conrad_Jacket = new Player(120, 102, 54, 65, 61, 62, 66, 53, 51, 412, 52, 48, 11, 11, 8, 7, 11, 9, 10, 48, 2, 2, 3, 3, 3, 5, 2, 2, 1); // 0xADE
            private static Player Hilda_Bronski = new Player(94, 128, 59, 56, 56, 58, 47, 57, 53, 386, 52, 51, 10, 8, 8, 11, 11, 11, 8, 51, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xADF
            private static Player Clint_Peacock = new Player(120, 97, 57, 51, 57, 53, 53, 53, 54, 378, 59, 60, 14, 13, 15, 15, 17, 17, 15, 60, 2, 2, 2, 5, 2, 2, 2, 2, 2); // 0xAE0
            private static Player Pace_Maker = new Player(120, 100, 58, 53, 56, 62, 40, 56, 56, 381, 52, 54, 10, 10, 9, 13, 7, 10, 10, 54, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAE1
            private static Player Vanity_Percy = new Player(85, 123, 57, 51, 57, 62, 45, 59, 56, 387, 52, 48, 11, 8, 9, 14, 10, 7, 11, 48, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAE2
            private static Player Phil_Pagoda = new Player(110, 108, 60, 57, 58, 62, 47, 60, 56, 400, 60, 59, 14, 13, 12, 17, 11, 12, 13, 59, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xAE3
            private static Player Niki_Colbeck = new Player(89, 127, 53, 58, 50, 60, 55, 59, 55, 390, 48, 54, 10, 7, 12, 13, 11, 13, 7, 54, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAE4
            private static Player Guy_Pinnay = new Player(125, 102, 56, 53, 52, 57, 54, 62, 56, 390, 49, 54, 15, 8, 10, 17, 11, 11, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAE5
            private static Player Wayne_Fluke = new Player(116, 118, 53, 51, 57, 54, 56, 53, 51, 375, 60, 69, 12, 11, 10, 13, 12, 11, 10, 69, 4, 4, 4, 4, 5, 4, 4, 4, 4); // 0xAE6
            private static Player Red_Dayers = new Player(99, 126, 56, 57, 54, 56, 51, 56, 54, 384, 52, 52, 9, 9, 9, 16, 10, 10, 9, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xAE7
            private static Player Shay_Diebold = new Player(120, 92, 60, 58, 54, 51, 57, 56, 60, 396, 59, 48, 19, 16, 11, 12, 13, 11, 10, 48, 5, 5, 1, 1, 1, 1, 1, 1, 2); // 0xAE8
            private static Player Tigh_Gerwhite = new Player(130, 110, 67, 65, 46, 67, 62, 44, 60, 411, 64, 65, 17, 15, 9, 19, 17, 5, 16, 65, 5, 2, 5, 5, 5, 5, 2, 5, 2); // 0xAE9
            private static Player Cerise_Crane = new Player(117, 130, 48, 66, 62, 65, 63, 65, 63, 432, 63, 63, 14, 15, 14, 18, 13, 16, 14, 63, 5, 5, 2, 5, 2, 5, 5, 5, 4); // 0xAEA
            private static Player Drack_Gorn = new Player(130, 115, 62, 42, 67, 63, 64, 62, 62, 422, 60, 58, 15, 10, 17, 15, 16, 14, 15, 58, 5, 5, 2, 2, 5, 5, 5, 5, 2); // 0xAEB
            private static Player Terry_Pinn = new Player(120, 107, 45, 65, 63, 62, 67, 60, 66, 428, 55, 63, 14, 17, 17, 14, 17, 20, 16, 63, 5, 5, 5, 5, 5, 2, 2, 5, 2); // 0xAEC
            private static Player Justin_Cush = new Player(105, 123, 62, 62, 61, 65, 51, 66, 62, 429, 55, 55, 12, 10, 13, 16, 10, 12, 12, 55, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xAED
            private static Player Bert_McClure = new Player(106, 121, 46, 50, 50, 51, 57, 57, 52, 363, 52, 48, 10, 8, 7, 8, 13, 14, 10, 48, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAEE
            private static Player Richard_Trogg = new Player(114, 102, 52, 51, 48, 62, 63, 58, 59, 393, 59, 58, 10, 13, 8, 11, 18, 14, 14, 58, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xAEF
            private static Player Shirly_Quirk = new Player(80, 141, 46, 48, 46, 51, 56, 51, 53, 351, 46, 45, 8, 6, 6, 7, 12, 8, 7, 45, 5, 1, 1, 5, 1, 2, 5, 1, 3); // 0xAF0
            private static Player Elias_Lens = new Player(123, 95, 56, 60, 48, 61, 53, 56, 51, 385, 49, 59, 10, 10, 11, 15, 13, 15, 8, 59, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAF1
            private static Player Terry_Dryden = new Player(120, 96, 47, 48, 44, 48, 50, 50, 50, 337, 52, 49, 8, 8, 9, 10, 8, 7, 11, 49, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0xAF2
            private static Player Ardel_Kernel = new Player(122, 91, 44, 51, 55, 53, 61, 56, 52, 372, 48, 52, 9, 8, 10, 9, 12, 12, 10, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xAF3
            private static Player Carl_Belcher = new Player(120, 93, 51, 54, 55, 56, 53, 53, 57, 379, 56, 57, 14, 12, 11, 12, 12, 11, 13, 57, 1, 1, 1, 1, 1, 5, 1, 1, 1); // 0xAF4
            private static Player Mal_Maroon = new Player(118, 96, 47, 51, 53, 52, 60, 56, 53, 372, 44, 49, 10, 8, 8, 7, 11, 12, 9, 49, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xAF5
            private static Player Ralph_Fary = new Player(120, 97, 60, 60, 56, 54, 56, 56, 58, 400, 59, 42, 19, 17, 14, 11, 11, 13, 13, 42, 5, 1, 1, 1, 1, 1, 1, 5, 2); // 0xAF6
            private static Player Floyd_Spades = new Player(120, 92, 58, 51, 57, 54, 53, 58, 57, 388, 55, 49, 17, 7, 14, 13, 7, 9, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xAF7
            private static Player Remy_Diggun = new Player(119, 91, 54, 56, 52, 53, 57, 55, 52, 379, 63, 59, 15, 13, 17, 13, 13, 17, 16, 59, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0xAF8
            private static Player Bern_Macmahon = new Player(122, 91, 53, 53, 54, 51, 56, 54, 56, 377, 63, 61, 17, 16, 16, 14, 15, 15, 13, 61, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0xAF9
            private static Player Wally_Cooper = new Player(124, 97, 62, 59, 48, 56, 57, 62, 51, 395, 57, 55, 8, 9, 12, 14, 10, 17, 11, 55, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xAFA
            private static Player Griff_Hardcasel = new Player(120, 98, 56, 57, 62, 57, 57, 56, 59, 404, 55, 45, 17, 15, 16, 14, 17, 13, 17, 45, 5, 1, 4, 4, 4, 4, 4, 5, 2); // 0xAFB
            private static Player Pat_Lubow = new Player(120, 92, 50, 48, 49, 44, 49, 46, 47, 333, 75, 74, 21, 20, 23, 21, 22, 21, 22, 74, 5, 5, 5, 5, 5, 5, 5, 5, 2); // 0xAFC
            private static Player Wilma_Morgan = new Player(104, 137, 58, 56, 51, 68, 53, 61, 56, 403, 60, 45, 19, 14, 13, 14, 14, 12, 11, 45, 5, 1, 1, 1, 2, 1, 1, 5, 2); // 0xAFD
            private static Player Carys_Chaparon = new Player(96, 123, 66, 53, 57, 69, 66, 53, 53, 417, 56, 54, 11, 12, 13, 11, 13, 13, 12, 54, 4, 4, 4, 4, 5, 4, 4, 4, 3); // 0xAFE
            private static Player Claire_Hostess = new Player(109, 117, 61, 56, 56, 53, 55, 56, 56, 393, 56, 48, 19, 15, 11, 12, 14, 14, 14, 48, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0xAFF
            private static Player Katy_Punter = new Player(102, 122, 49, 51, 59, 50, 54, 54, 57, 374, 54, 60, 9, 10, 14, 7, 8, 7, 9, 60, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xB00
            private static Player Pete_Pimento = new Player(125, 93, 60, 51, 57, 51, 51, 56, 56, 382, 55, 49, 15, 11, 12, 17, 9, 11, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB01
            private static Player Mary_Hugland = new Player(85, 131, 64, 63, 65, 45, 48, 49, 47, 381, 55, 49, 11, 9, 9, 9, 10, 8, 11, 49, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xB02
            private static Player Lee_Screener = new Player(119, 113, 48, 56, 66, 46, 53, 51, 56, 376, 52, 60, 7, 7, 14, 10, 10, 7, 9, 60, 2, 5, 5, 2, 5, 5, 5, 5, 1); // 0xB03
            private static Player Camilla_Textor = new Player(93, 124, 46, 51, 57, 51, 62, 51, 53, 371, 50, 47, 12, 11, 11, 11, 15, 12, 7, 47, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB04
            private static Player Bish_Beaton = new Player(117, 91, 60, 65, 62, 57, 49, 63, 57, 413, 59, 43, 13, 13, 16, 17, 15, 16, 12, 43, 5, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB05
            private static Player Simeon_Squareyes = new Player(107, 118, 60, 60, 53, 52, 57, 61, 58, 401, 54, 43, 19, 15, 13, 14, 14, 10, 11, 43, 5, 1, 1, 1, 1, 1, 1, 5, 3); // 0xB06
            private static Player Stu_Borneman = new Player(111, 96, 54, 57, 53, 54, 54, 55, 64, 391, 56, 55, 12, 12, 13, 12, 12, 10, 14, 55, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0xB07
            private static Player Herbie_Garnet = new Player(135, 89, 50, 48, 56, 45, 46, 46, 51, 342, 44, 48, 5, 11, 12, 7, 8, 4, 8, 48, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB08
            private static Player Arvin_Inkwell = new Player(110, 99, 52, 53, 54, 56, 53, 52, 51, 371, 46, 45, 4, 8, 7, 6, 6, 4, 5, 45, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0xB09
            private static Player Rayce_Sprinton = new Player(119, 118, 48, 53, 58, 49, 57, 56, 53, 374, 49, 62, 9, 9, 16, 7, 11, 9, 10, 62, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xB0A
            private static Player Dreama_Bartle = new Player(87, 136, 60, 55, 56, 51, 57, 59, 54, 392, 55, 49, 17, 10, 12, 14, 9, 9, 11, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB0B
            private static Player Jane_Ledbelly = new Player(87, 135, 46, 50, 51, 51, 48, 51, 51, 348, 54, 51, 10, 9, 8, 8, 8, 10, 11, 51, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xB0C
            private static Player Dory_O_Bonn = new Player(89, 128, 45, 44, 50, 44, 45, 44, 50, 322, 54, 50, 10, 11, 11, 10, 11, 9, 9, 50, 2, 2, 2, 2, 2, 5, 2, 2, 1); // 0xB0D
            private static Player Selma_Heaver = new Player(107, 128, 45, 51, 57, 45, 56, 56, 57, 367, 54, 62, 8, 7, 16, 7, 8, 7, 10, 62, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB0E
            private static Player Kath_Leaflin = new Player(107, 126, 51, 51, 56, 53, 53, 54, 53, 371, 65, 61, 15, 14, 17, 17, 13, 15, 16, 61, 2, 2, 2, 2, 2, 2, 2, 5, 2); // 0xB0F
            private static Player Marg_Shuttle = new Player(88, 132, 58, 54, 53, 53, 56, 60, 56, 390, 52, 52, 17, 9, 12, 13, 8, 9, 9, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB10
            private static Player Duke_Scrubine = new Player(120, 101, 53, 62, 56, 56, 53, 53, 56, 389, 50, 49, 8, 11, 10, 17, 8, 10, 10, 49, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB11
            private static Player Waylon_Tripp = new Player(120, 93, 56, 54, 53, 57, 56, 52, 53, 381, 59, 54, 10, 12, 14, 13, 11, 14, 12, 54, 4, 4, 4, 4, 4, 4, 4, 5, 3); // 0xB12
            private static Player Jim_Bunner = new Player(120, 91, 51, 56, 57, 54, 62, 57, 55, 392, 45, 52, 10, 8, 7, 9, 14, 14, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB13
            private static Player Jon_Izumo = new Player(124, 100, 57, 60, 53, 63, 60, 65, 59, 417, 44, 57, 12, 13, 15, 17, 13, 17, 10, 57, 1, 1, 5, 1, 5, 1, 1, 1, 4); // 0xB14
            private static Player Del_Brighton = new Player(121, 92, 56, 56, 48, 60, 53, 56, 54, 383, 44, 56, 9, 11, 10, 15, 10, 15, 8, 56, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB15
            private static Player Haden_Safe = new Player(118, 94, 56, 56, 51, 57, 51, 57, 61, 389, 57, 47, 18, 15, 11, 11, 11, 12, 13, 47, 5, 1, 5, 1, 1, 1, 1, 1, 1); // 0xB16
            private static Player Lisle_Plotter = new Player(107, 119, 60, 57, 54, 51, 56, 58, 58, 394, 60, 42, 17, 15, 12, 13, 13, 14, 12, 42, 5, 1, 1, 5, 1, 1, 1, 1, 3); // 0xB17
            private static Player Fen_Skates = new Player(80, 138, 51, 62, 46, 59, 54, 59, 51, 382, 48, 57, 11, 8, 13, 17, 11, 15, 8, 57, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB18
            private static Player Rhoda_Dough = new Player(75, 136, 59, 54, 52, 56, 48, 59, 57, 385, 50, 49, 9, 7, 11, 12, 11, 9, 7, 49, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB19
            private static Player Neil_Seating = new Player(120, 116, 55, 51, 65, 44, 48, 56, 51, 370, 50, 48, 13, 12, 8, 10, 9, 11, 9, 48, 2, 1, 1, 1, 1, 5, 1, 1, 3); // 0xB1A
            private static Player Flo_Nighting = new Player(75, 139, 48, 52, 48, 53, 47, 48, 50, 346, 48, 45, 6, 8, 7, 13, 6, 11, 6, 45, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xB1B
            private static Player Elinor_Maven = new Player(120, 108, 66, 53, 47, 59, 56, 57, 56, 394, 54, 59, 11, 14, 6, 12, 19, 13, 11, 59, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xB1C
            private static Player Kay_Gateley = new Player(86, 132, 57, 60, 57, 60, 53, 56, 62, 405, 55, 51, 7, 9, 10, 17, 11, 14, 11, 51, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB1D
            private static Player Dexter_Caise = new Player(121, 100, 60, 54, 53, 57, 40, 57, 55, 376, 55, 52, 9, 9, 10, 13, 9, 8, 10, 52, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB1E
            private static Player Serena_Besse = new Player(118, 127, 58, 62, 62, 62, 61, 56, 59, 420, 49, 48, 10, 11, 17, 10, 9, 10, 10, 48, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xB1F
            private static Player Adrian_Heartly = new Player(120, 105, 62, 58, 62, 57, 59, 56, 57, 411, 55, 43, 5, 8, 4, 6, 8, 8, 6, 43, 5, 5, 5, 5, 5, 5, 5, 5, 3); // 0xB20
            private static Player Cary_Fearless = new Player(94, 117, 59, 56, 56, 54, 56, 62, 60, 403, 50, 54, 13, 9, 12, 16, 10, 9, 9, 54, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB21
            private static Player Wally_Waymire = new Player(109, 113, 51, 53, 56, 53, 51, 57, 51, 372, 55, 52, 13, 11, 12, 11, 13, 12, 14, 52, 4, 4, 4, 4, 5, 4, 4, 4, 3); // 0xB22
            private static Player Ted_Autumn = new Player(130, 108, 66, 61, 47, 70, 60, 46, 64, 414, 68, 68, 16, 16, 9, 20, 13, 8, 13, 68, 5, 2, 5, 5, 5, 5, 2, 5, 4); // 0xB23
            private static Player Boomer_Smolen = new Player(120, 93, 56, 59, 47, 58, 52, 62, 54, 388, 47, 54, 7, 7, 14, 13, 13, 15, 11, 54, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB24
            private static Player Hank_Ershef = new Player(120, 95, 47, 53, 53, 56, 61, 57, 57, 384, 45, 48, 14, 8, 11, 7, 17, 14, 9, 48, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB25
            private static Player Tim_Opener = new Player(133, 112, 47, 43, 40, 64, 66, 53, 55, 368, 50, 69, 11, 8, 6, 17, 15, 14, 10, 69, 5, 1, 1, 5, 2, 2, 5, 1, 1); // 0xB26
            private static Player Hide_King = new Player(122, 91, 49, 56, 53, 61, 59, 57, 53, 388, 44, 49, 8, 7, 10, 10, 10, 14, 9, 49, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB27
            private static Player Beth_Doodle = new Player(83, 132, 50, 53, 57, 57, 62, 62, 54, 395, 44, 52, 9, 10, 8, 8, 10, 10, 11, 52, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xB28
            private static Player Lamar_Bonesteel = new Player(120, 95, 47, 36, 36, 51, 59, 53, 51, 333, 54, 53, 8, 8, 4, 9, 14, 13, 8, 53, 5, 1, 1, 5, 1, 2, 5, 1, 1); // 0xB29
            private static Player Dom_Round = new Player(133, 86, 46, 47, 48, 49, 46, 48, 53, 337, 49, 52, 10, 11, 9, 11, 8, 8, 10, 52, 2, 2, 2, 5, 2, 2, 2, 2, 3); // 0xB2A
            private static Player Chip_Stocks = new Player(112, 109, 59, 63, 60, 66, 57, 59, 58, 422, 60, 53, 14, 11, 11, 17, 10, 15, 11, 53, 1, 1, 5, 1, 5, 1, 1, 1, 3); // 0xB2B
            private static Player Blake_Nailor = new Player(120, 97, 48, 61, 65, 66, 39, 56, 52, 387, 52, 42, 9, 13, 16, 16, 8, 9, 7, 42, 1, 5, 2, 2, 2, 1, 4, 1, 2); // 0xB2C
            private static Player Dotty_Hickman = new Player(82, 133, 51, 60, 56, 56, 65, 63, 59, 410, 48, 53, 11, 14, 10, 10, 13, 14, 12, 53, 5, 1, 1, 1, 1, 2, 5, 1, 1); // 0xB2D
            private static Player Wright_Tandem = new Player(118, 91, 53, 56, 56, 57, 51, 53, 54, 380, 60, 61, 13, 15, 15, 13, 17, 14, 17, 61, 2, 2, 5, 2, 2, 2, 2, 2, 1); // 0xB2E
            private static Player Shaun_Bonnie = new Player(90, 134, 47, 47, 47, 48, 47, 45, 46, 327, 48, 47, 6, 4, 8, 8, 7, 4, 4, 47, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xB2F
            private static Player Andrew_Hooper = new Player(126, 91, 57, 58, 57, 57, 53, 63, 57, 402, 64, 45, 16, 14, 14, 14, 11, 16, 11, 45, 5, 1, 1, 1, 1, 1, 1, 5, 1); // 0xB30
            private static Player Toya_Boyde = new Player(90, 126, 49, 51, 46, 48, 52, 50, 48, 344, 54, 48, 9, 11, 11, 8, 8, 7, 8, 48, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0xB31
            private static Player Taryn_Shyder = new Player(104, 138, 57, 60, 60, 62, 62, 57, 59, 417, 60, 42, 19, 13, 17, 16, 15, 17, 16, 42, 5, 1, 4, 4, 4, 5, 4, 4, 4); // 0xB32
            private static Player Jasmin_Trier = new Player(80, 133, 45, 47, 60, 51, 50, 46, 63, 362, 49, 64, 7, 11, 17, 16, 11, 11, 10, 64, 3, 4, 4, 5, 2, 4, 4, 4, 1); // 0xB33
            private static Player Dave_Lung = new Player(105, 126, 59, 65, 62, 64, 62, 59, 61, 432, 54, 59, 14, 11, 13, 17, 12, 17, 11, 59, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB34
            private static Player Teal_Redsky = new Player(110, 108, 66, 52, 56, 57, 53, 56, 67, 407, 52, 54, 15, 9, 9, 10, 11, 8, 15, 54, 1, 2, 1, 1, 5, 1, 1, 2, 4); // 0xB35
            private static Player Truman_Verdy = new Player(125, 100, 52, 51, 53, 67, 56, 56, 67, 402, 49, 53, 7, 10, 7, 17, 7, 10, 16, 53, 1, 1, 1, 1, 5, 1, 1, 2, 2); // 0xB36
            private static Player Chance_Cerulean = new Player(117, 101, 54, 66, 56, 55, 53, 51, 67, 402, 52, 52, 11, 16, 9, 9, 10, 8, 14, 52, 1, 1, 2, 5, 1, 1, 1, 2, 2); // 0xB37
            private static Player Amy_Peach = new Player(104, 133, 57, 54, 65, 51, 56, 54, 67, 404, 52, 50, 9, 8, 15, 10, 10, 11, 15, 50, 1, 1, 1, 2, 1, 5, 1, 2, 2); // 0xB38
            private static Player Virgil_Amber = new Player(105, 123, 56, 53, 56, 65, 53, 56, 65, 404, 52, 52, 8, 7, 7, 16, 10, 8, 14, 52, 1, 1, 1, 1, 2, 5, 1, 2, 3); // 0xB39
            private static Player Grant_Stodgell = new Player(115, 101, 67, 51, 53, 51, 53, 54, 46, 375, 44, 51, 12, 5, 5, 7, 4, 6, 6, 51, 2, 2, 1, 1, 1, 1, 1, 5, 4); // 0xB3A
            private static Player Payne_Outler = new Player(108, 124, 56, 56, 54, 66, 53, 51, 45, 381, 57, 47, 6, 11, 7, 12, 6, 6, 7, 47, 1, 1, 2, 1, 2, 1, 5, 1, 3); // 0xB3B
            private static Player Malcolm_Shirker = new Player(120, 93, 57, 67, 51, 51, 60, 62, 46, 394, 48, 43, 6, 14, 5, 7, 9, 11, 7, 43, 1, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB3C
            private static Player Hanna_Slack = new Player(115, 115, 53, 51, 67, 51, 54, 53, 49, 378, 48, 52, 7, 5, 10, 4, 5, 6, 5, 52, 2, 1, 1, 2, 5, 1, 1, 1, 2); // 0xB3D
            private static Player Dom_Poppy = new Player(120, 96, 57, 59, 56, 67, 53, 54, 49, 395, 45, 45, 5, 9, 5, 13, 7, 7, 7, 45, 1, 5, 2, 1, 2, 1, 1, 1, 3); // 0xB3E
            private static Player Portia_Maricle = new Player(82, 138, 53, 57, 55, 53, 59, 62, 54, 393, 44, 52, 11, 10, 8, 8, 14, 13, 8, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB3F
            private static Player Susan_Doiley = new Player(84, 124, 60, 51, 55, 52, 57, 62, 52, 389, 55, 50, 14, 10, 12, 13, 10, 11, 7, 50, 1, 2, 1, 1, 2, 5, 2, 1, 1); // 0xB40
            private static Player Hannah_Breer = new Player(93, 128, 44, 46, 50, 49, 46, 47, 47, 329, 55, 49, 9, 9, 8, 9, 11, 8, 10, 49, 2, 2, 2, 2, 2, 5, 2, 2, 2); // 0xB41
            private static Player Phil_Seebold = new Player(99, 135, 56, 53, 56, 53, 57, 52, 54, 381, 56, 55, 10, 12, 11, 10, 13, 14, 13, 55, 4, 4, 4, 5, 4, 4, 4, 4, 1); // 0xB42
            private static Player Bobbie_Tomey = new Player(96, 131, 56, 63, 53, 53, 51, 56, 59, 391, 60, 45, 18, 14, 13, 10, 14, 12, 11, 45, 5, 1, 1, 1, 5, 1, 1, 1, 3); // 0xB43
            private static Player Randolph_Lords = new Player(120, 105, 53, 62, 53, 57, 53, 56, 56, 390, 52, 49, 8, 8, 9, 13, 9, 12, 11, 49, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB44
            private static Player Robin_Traylor = new Player(91, 129, 56, 62, 56, 60, 66, 62, 56, 418, 50, 54, 13, 13, 14, 12, 16, 16, 13, 54, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB45
            private static Player Fawn_Blossom = new Player(85, 133, 47, 53, 53, 44, 47, 51, 51, 346, 47, 55, 6, 8, 13, 5, 7, 8, 7, 55, 1, 1, 2, 2, 5, 1, 4, 1, 2); // 0xB46
            private static Player Isabell_Mish = new Player(100, 133, 60, 62, 60, 67, 60, 60, 56, 425, 56, 52, 11, 12, 14, 18, 12, 16, 12, 52, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB47
            private static Player Rudy_Stemper = new Player(120, 91, 58, 59, 41, 52, 60, 51, 61, 382, 51, 51, 9, 9, 7, 11, 14, 13, 10, 51, 5, 1, 1, 5, 1, 2, 5, 1, 2); // 0xB48
            private static Player Betty_Evenson = new Player(98, 128, 50, 54, 60, 53, 52, 53, 51, 373, 56, 58, 7, 11, 17, 9, 11, 9, 9, 58, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB49
            private static Player Harpo_Kendrick = new Player(91, 137, 57, 59, 62, 56, 66, 63, 57, 420, 48, 58, 14, 13, 14, 12, 16, 16, 14, 58, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB4A
            private static Player Colin_Glower = new Player(120, 108, 48, 53, 65, 48, 56, 53, 53, 376, 55, 63, 9, 8, 14, 8, 9, 11, 7, 63, 1, 1, 2, 2, 5, 1, 4, 1, 1); // 0xB4B
            private static Player Tailor_Wilden = new Player(111, 90, 54, 53, 47, 51, 51, 56, 54, 366, 52, 48, 14, 12, 9, 7, 10, 9, 10, 48, 5, 1, 1, 1, 5, 1, 1, 1, 1); // 0xB4C
            private static Player Sim_Cebus = new Player(112, 105, 67, 59, 58, 67, 50, 62, 56, 419, 56, 55, 10, 14, 13, 14, 14, 10, 12, 55, 1, 2, 1, 1, 2, 5, 2, 1, 4); // 0xB4D
            private static Player Sam_Banks = new Player(92, 127, 52, 53, 54, 66, 36, 67, 60, 388, 44, 54, 14, 13, 11, 13, 7, 21, 14, 54, 1, 1, 1, 1, 1, 1, 5, 1, 1); // 0xB4E
            private static Player Frank_Homey = new Player(119, 93, 44, 51, 56, 51, 58, 60, 56, 376, 47, 49, 11, 10, 7, 9, 14, 10, 8, 49, 5, 1, 1, 1, 1, 2, 5, 1, 2); // 0xB4F
            private static Player Gregg_Deremer = new Player(115, 99, 65, 53, 60, 47, 57, 57, 36, 375, 49, 59, 7, 10, 14, 11, 9, 9, 7, 59, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB50
            private static Player Verne_Spring = new Player(122, 114, 62, 46, 66, 63, 67, 63, 66, 433, 62, 60, 14, 13, 16, 15, 17, 14, 17, 60, 5, 5, 2, 2, 5, 5, 5, 5, 4); // 0xB51
            private static Player Bryan_Klamm = new Player(133, 92, 50, 53, 53, 53, 59, 55, 51, 374, 49, 48, 14, 9, 10, 7, 13, 11, 8, 48, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB52
            private static Player Colt_Youngstein = new Player(124, 110, 61, 63, 67, 57, 50, 62, 57, 417, 58, 52, 15, 13, 15, 15, 15, 18, 14, 52, 1, 1, 5, 1, 5, 1, 1, 1, 2); // 0xB53
            private static Player Will_Kilmon = new Player(99, 130, 50, 49, 51, 48, 46, 51, 53, 348, 55, 51, 10, 7, 10, 7, 9, 11, 9, 51, 2, 2, 5, 2, 2, 2, 2, 2, 3); // 0xB54
            private static Player Milly_Vacey = new Player(97, 130, 60, 62, 53, 55, 53, 62, 58, 403, 55, 45, 18, 16, 14, 11, 12, 12, 10, 45, 5, 1, 1, 1, 5, 1, 1, 1, 4); // 0xB55
            private static Player Dany_Destiny = new Player(121, 99, 52, 56, 57, 52, 56, 60, 57, 390, 65, 48, 16, 16, 12, 15, 12, 20, 10, 48, 1, 2, 1, 1, 2, 5, 2, 1, 2); // 0xB56
            private static Player Gary_Primo = new Player(107, 126, 67, 54, 51, 53, 52, 56, 44, 377, 49, 52, 12, 6, 7, 6, 5, 6, 8, 52, 2, 2, 1, 5, 1, 1, 1, 1, 4); // 0xB57
            private static Player Bobby_Duo = new Player(112, 96, 57, 56, 53, 67, 56, 51, 50, 390, 59, 42, 4, 8, 5, 13, 5, 5, 5, 42, 1, 1, 2, 1, 2, 5, 1, 1, 2); // 0xB58
            private static Player Stan_Treece = new Player(99, 137, 53, 67, 55, 54, 59, 59, 50, 397, 46, 49, 4, 11, 5, 6, 8, 8, 6, 49, 1, 1, 1, 1, 1, 2, 1, 5, 2); // 0xB59
            private static Player Lillie_Quattro = new Player(103, 122, 51, 56, 67, 54, 51, 52, 48, 379, 51, 49, 4, 6, 10, 6, 8, 6, 8, 49, 2, 1, 1, 2, 1, 1, 5, 1, 2); // 0xB5A
            private static Player Eddy_Pentaris = new Player(115, 97, 53, 62, 56, 66, 53, 53, 44, 387, 50, 45, 8, 10, 6, 12, 8, 5, 8, 45, 1, 1, 2, 1, 2, 1, 1, 5, 3); // 0xB5B
            private static Player Candice_Mell = new Player(75, 132, 61, 51, 56, 51, 56, 56, 53, 384, 49, 52, 7, 11, 11, 9, 14, 13, 7, 52, 5, 1, 1, 1, 1, 2, 5, 1, 3); // 0xB5C
            private static Player Alex_Dauger = new Player(120, 112, 62, 65, 60, 63, 58, 57, 57, 422, 57, 58, 12, 14, 12, 20, 10, 13, 14, 58, 1, 1, 5, 1, 5, 1, 1, 1, 1); // 0xB5D
            private static Player Joe_Divide = new Player(107, 120, 56, 57, 51, 53, 55, 57, 57, 386, 59, 48, 19, 15, 10, 12, 12, 11, 13, 48, 5, 1, 1, 1, 5, 1, 1, 1, 3); // 0xB5E
            private static Player Sam_Willing = new Player(120, 93, 53, 57, 53, 51, 53, 56, 57, 380, 54, 52, 12, 10, 14, 10, 13, 12, 10, 52, 2, 2, 2, 5, 2, 2, 2, 2, 1); // 0xB5F
            private static Player Mary_Antoine = new Player(90, 129, 65, 66, 67, 60, 65, 46, 48, 417, 48, 73, 10, 13, 22, 10, 21, 7, 4, 73, 2, 2, 2, 2, 2, 5, 2, 2, 5); // 0xB60
            private static Player Edward_Baron = new Player(107, 123, 67, 65, 64, 66, 46, 48, 51, 407, 51, 61, 23, 18, 18, 19, 6, 4, 7, 61, 2, 2, 2, 2, 2, 2, 2, 5, 5); // 0xB61
            private static Player Tim_Platton = new Player(103, 116, 51, 56, 56, 51, 57, 56, 51, 378, 57, 55, 12, 10, 12, 11, 12, 12, 11, 55, 4, 4, 4, 4, 4, 4, 4, 5, 2); // 0xB62
            private static Player Argento_Salvage = new Player(126, 108, 56, 59, 56, 59, 62, 60, 61, 413, 62, 58, 17, 17, 17, 14, 17, 13, 17, 58, 4, 4, 4, 5, 4, 4, 4, 4, 2); // 0xB63
            private static Player Finn_Geld = new Player(130, 108, 67, 60, 66, 67, 45, 67, 47, 419, 70, 59, 23, 19, 18, 19, 7, 20, 7, 59, 2, 2, 5, 2, 2, 2, 2, 2, 5); // 0xB64
            private static Player Ian_Moray = new Player(119, 95, 57, 56, 51, 53, 51, 56, 52, 376, 62, 61, 16, 15, 16, 14, 15, 14, 17, 61, 2, 2, 2, 2, 5, 2, 2, 2, 2); // 0xB65
            private static Player Gil_Holden = new Player(109, 113, 46, 56, 59, 50, 54, 56, 56, 377, 54, 64, 7, 8, 13, 11, 10, 9, 10, 64, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB66
            private static Player Doyle_Palmer = new Player(118, 92, 55, 53, 54, 54, 57, 51, 53, 377, 61, 57, 15, 15, 15, 15, 16, 15, 15, 57, 2, 2, 5, 2, 2, 2, 2, 2, 2); // 0xB67
            private static Player Audry_Orange = new Player(91, 136, 51, 51, 48, 48, 48, 53, 46, 345, 48, 43, 10, 5, 8, 14, 6, 7, 6, 43, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB68
            private static Player May_Apple = new Player(88, 128, 44, 46, 51, 48, 47, 46, 49, 331, 51, 52, 6, 7, 11, 8, 8, 4, 4, 52, 1, 1, 2, 2, 5, 1, 4, 1, 3); // 0xB69
            private static Player Ginny_White = new Player(80, 130, 50, 51, 48, 44, 46, 51, 48, 338, 48, 42, 12, 9, 7, 6, 6, 7, 4, 42, 5, 1, 1, 5, 1, 1, 1, 1, 2); // 0xB6A
            private static Player Angus_Hogg = new Player(92, 117, 46, 46, 44, 46, 45, 47, 52, 326, 48, 46, 12, 11, 7, 7, 7, 8, 8, 46, 5, 1, 1, 1, 1, 5, 1, 1, 3); // 0xB6B
            private static Player In_Chikita = new Player(99, 125, 59, 59, 55, 57, 56, 56, 60, 402, 58, 45, 17, 15, 10, 14, 13, 14, 13, 45, 5, 1, 1, 1, 1, 1, 1, 5, 2); // 0xB6C
            private static Player Sabrina_Carow = new Player(106, 126, 60, 57, 56, 56, 51, 60, 61, 401, 54, 47, 18, 15, 13, 13, 12, 12, 14, 47, 5, 1, 1, 1, 1, 1, 5, 1, 2); // 0xB6D
            private static Player Bob_Beelzy = new Player(122, 105, 60, 61, 58, 63, 51, 66, 60, 419, 56, 54, 13, 10, 10, 15, 12, 13, 10, 54, 1, 2, 1, 1, 2, 5, 2, 1, 4); // 0xB6E
            private static Player Patt_Howell = new Player(108, 126, 56, 56, 56, 51, 56, 53, 57, 385, 65, 59, 17, 14, 15, 17, 14, 16, 15, 59, 2, 2, 2, 2, 5, 2, 2, 2, 3); // 0xB6F
            private static Player Ol_Factory = new Player(121, 92, 61, 53, 54, 58, 41, 57, 57, 381, 54, 49, 9, 10, 9, 12, 9, 7, 8, 49, 1, 2, 1, 1, 2, 5, 2, 1, 3); // 0xB70
            private static Player Tom_Skipper = new Player(130, 95, 65, 63, 67, 58, 53, 51, 67, 424, 69, 72, 23, 21, 19, 12, 13, 5, 14, 72, 5, 5, 5, 5, 5, 5, 5, 5, 4); // 0xB71
            private static Player Austin_Hobbes = new Player(120, 130, 72, 56, 60, 55, 60, 56, 57, 416, 91, 77, 27, 21, 21, 24, 27, 28, 26, 77, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0xBB9
            private static Player Archer_Hawkins = new Player(125, 124, 78, 54, 52, 58, 52, 48, 74, 416, 88, 54, 29, 26, 17, 26, 21, 22, 22, 54, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0xBBA
            private static Player Isaac_Glass = new Player(104, 142, 57, 64, 72, 36, 52, 37, 39, 357, 75, 97, 28, 23, 26, 17, 20, 21, 15, 97, 5, 5, 5, 5, 5, 5, 5, 5, 1); // 0xBBB
            private static Player Xavier_Foster = new Player(111, 129, 71, 63, 67, 58, 69, 51, 60, 439, 92, 69, 28, 28, 28, 29, 30, 28, 30, 69, 5, 2, 2, 5, 2, 2, 2, 2, 5); // 0xBBC
            private static Player Caleb_Stonewall = new Player(126, 130, 59, 78, 66, 58, 65, 53, 64, 443, 66, 57, 30, 30, 29, 26, 30, 28, 29, 57, 3, 1, 2, 1, 1, 5, 2, 2, 4); // 0xBBD
            private static Player Jordan_Greenway = new Player(125, 124, 63, 59, 79, 56, 71, 55, 62, 445, 65, 84, 30, 30, 28, 28, 28, 30, 29, 84, 5, 2, 2, 5, 4, 2, 4, 2, 4); // 0xBBE
            private static Player Dave_Quagmire = new Player(124, 128, 75, 68, 61, 63, 59, 57, 48, 431, 68, 91, 21, 19, 18, 20, 21, 19, 18, 91, 5, 1, 1, 1, 5, 1, 1, 1, 5); // 0xBBF
            private static Player Camellia_Travis = new Player(109, 137, 40, 50, 60, 72, 58, 48, 58, 386, 40, 40, 5, 6, 20, 6, 5, 5, 5, 40, 1, 5, 2, 1, 4, 1, 3, 3, 1); // 0xBC0
            private static Player Andy = new Player(126, 120, 54, 52, 48, 48, 58, 52, 60, 372, 50, 15, 10, 10, 10, 10, 10, 10, 10, 15, 4, 3, 4, 1, 4, 5, 3, 4, 3); // 0xBC1
            private static Player Hector_Helio_Little = new Player(102, 132, 58, 50, 57, 85, 55, 69, 73, 447, 38, 20, 8, 7, 5, 6, 8, 9, 12, 20, 3, 4, 3, 2, 4, 2, 2, 5, 2); // 0xBC2
            private static Player Riku_Matsushita = new Player(99, 140, 48, 58, 48, 64, 55, 48, 60, 381, 38, 40, 12, 18, 12, 10, 17, 18, 25, 40, 5, 3, 3, 5, 2, 3, 2, 3, 2); // 0xBC3
            private static Player Yuta_Kitajima = new Player(150, 130, 58, 52, 68, 48, 62, 52, 68, 408, 50, 30, 12, 12, 8, 8, 8, 5, 8, 30, 4, 1, 2, 4, 5, 2, 3, 1, 2); // 0xBC4
            private static Player Natsuki_Yoshida = new Player(110, 160, 48, 54, 52, 64, 50, 40, 60, 368, 50, 40, 8, 8, 5, 8, 7, 5, 5, 40, 4, 1, 1, 1, 5, 5, 2, 3, 1); // 0xBC5
            private static Player Riku_Ryu = new Player(160, 150, 52, 62, 62, 52, 68, 68, 55, 419, 40, 30, 8, 7, 8, 8, 5, 5, 5, 30, 1, 1, 2, 5, 1, 3, 1, 4, 1); // 0xBC6
            private static Player Hector_Helio_Little2 = new Player(102, 132, 58, 50, 57, 85, 55, 69, 73, 447, 38, 20, 8, 7, 5, 6, 8, 9, 12, 20, 3, 4, 3, 2, 4, 2, 2, 5, 2); // 0xBC7
            private static Player Gene_Whalon = new Player(126, 138, 58, 69, 49, 76, 57, 48, 73, 430, 53, 96, 18, 24, 22, 24, 25, 19, 25, 96, 5, 1, 1, 5, 3, 5, 5, 3, 4); // 0xBCD
            private static Player David_Waterman = new Player(127, 108, 60, 56, 48, 60, 59, 50, 71, 404, 66, 89, 20, 19, 21, 22, 22, 18, 21, 89, 5, 4, 2, 1, 2, 2, 2, 5, 2); // 0xBCE
            private static Player Sonny_Shore = new Player(122, 115, 53, 68, 57, 58, 64, 51, 64, 415, 58, 97, 19, 20, 18, 18, 20, 18, 20, 97, 4, 4, 4, 1, 5, 2, 2, 5, 3); // 0xBCF
            private static Player Kjell_Snapper = new Player(126, 107, 69, 52, 52, 72, 56, 54, 64, 419, 67, 84, 20, 24, 19, 24, 22, 21, 20, 84, 4, 2, 5, 4, 2, 5, 2, 4, 4); // 0xBD0
            private static Player Ken_Crackham = new Player(119, 118, 52, 61, 62, 68, 52, 48, 62, 405, 62, 91, 18, 20, 23, 21, 18, 18, 23, 91, 1, 5, 2, 4, 3, 4, 4, 2, 1); // 0xBD1
            private static Player Shawn_Princeton = new Player(122, 94, 48, 70, 63, 56, 67, 53, 62, 419, 70, 77, 20, 18, 18, 19, 22, 18, 20, 77, 1, 2, 3, 1, 1, 5, 3, 4, 2); // 0xBD2
            private static Player Matt_Fischer = new Player(117, 105, 60, 62, 60, 56, 61, 50, 68, 417, 54, 92, 24, 26, 19, 19, 18, 20, 20, 92, 1, 3, 3, 4, 2, 2, 1, 5, 2); // 0xBD3
            private static Player Hank_Tennyson = new Player(123, 110, 49, 59, 69, 52, 71, 49, 59, 408, 63, 89, 22, 26, 18, 20, 27, 19, 19, 89, 1, 5, 5, 5, 4, 2, 3, 3, 1); // 0xBD4
            private static Player Dolph_Hensen = new Player(119, 126, 63, 92, 71, 57, 57, 49, 67, 456, 78, 100, 19, 22, 25, 22, 22, 19, 23, 100, 3, 5, 3, 3, 2, 2, 3, 3, 1); // 0xBD5
            private static Player Hamilton_Reith = new Player(127, 117, 76, 61, 61, 57, 57, 55, 63, 430, 69, 87, 19, 18, 18, 18, 20, 20, 18, 87, 3, 4, 5, 2, 2, 3, 3, 1, 3); // 0xBD6
            private static Player Joe_Dawes = new Player(122, 112, 83, 56, 46, 40, 42, 44, 70, 381, 71, 96, 27, 24, 18, 19, 21, 26, 18, 96, 5, 4, 3, 3, 3, 4, 1, 5, 2); // 0xBD7
            private static Player Quincy_Horace = new Player(121, 130, 53, 60, 62, 64, 69, 53, 53, 414, 57, 92, 24, 24, 19, 40, 26, 18, 26, 92, 3, 1, 4, 4, 5, 4, 3, 1, 2); // 0xBD8
            private static Player Holly_Summers = new Player(136, 118, 52, 59, 61, 60, 70, 52, 67, 421, 56, 103, 18, 19, 19, 18, 18, 18, 20, 103, 1, 3, 2, 5, 5, 2, 1, 2, 3); // 0xBD9
            private static Player Derek_Rabson = new Player(120, 109, 58, 72, 49, 63, 42, 53, 62, 399, 62, 88, 18, 28, 18, 29, 20, 19, 18, 88, 4, 5, 1, 2, 2, 2, 4, 1, 2); // 0xBDA
            private static Player Barack_Daniels = new Player(119, 109, 60, 62, 51, 66, 55, 50, 55, 399, 55, 85, 18, 23, 19, 29, 24, 20, 20, 85, 3, 2, 3, 3, 4, 3, 5, 4, 2); // 0xBDB
            private static Player Bruce_Marlin = new Player(122, 112, 70, 56, 50, 48, 62, 54, 59, 399, 59, 85, 20, 24, 20, 18, 25, 20, 18, 85, 3, 1, 4, 1, 5, 2, 5, 3, 4); // 0xBDC
            private static Player Nasir_Mustafa = new Player(136, 138, 56, 55, 46, 72, 49, 76, 51, 405, 105, 112, 18, 24, 16, 30, 18, 26, 22, 112, 2, 1, 3, 4, 1, 3, 5, 2, 2); // 0xBE1
            private static Player Faraz_Farooq = new Player(144, 96, 54, 60, 52, 56, 48, 82, 62, 414, 109, 76, 20, 21, 18, 21, 16, 27, 26, 76, 3, 1, 4, 1, 5, 1, 4, 4, 1); // 0xBE2
            private static Player Bilal_Kalil = new Player(124, 116, 51, 62, 65, 72, 58, 75, 61, 444, 92, 98, 20, 21, 26, 26, 25, 29, 24, 98, 4, 5, 5, 3, 5, 3, 5, 1, 1); // 0xBE3
            private static Player Jamila_Wali = new Player(130, 109, 48, 53, 57, 66, 78, 70, 57, 429, 97, 91, 18, 20, 25, 19, 29, 26, 25, 91, 2, 4, 2, 4, 5, 4, 1, 1, 2); // 0xBE4
            private static Player Musa_Sylla = new Player(138, 105, 57, 64, 53, 68, 49, 73, 55, 419, 102, 89, 18, 24, 19, 23, 20, 25, 22, 89, 5, 3, 5, 1, 4, 3, 5, 1, 2); // 0xBE5
            private static Player Yusuf_Massoud = new Player(131, 110, 62, 67, 63, 57, 48, 80, 60, 437, 98, 82, 19, 26, 20, 23, 22, 26, 21, 82, 4, 2, 3, 3, 4, 5, 5, 4, 3); // 0xBE6
            private static Player Sulayk_Sulaiman = new Player(128, 114, 58, 52, 53, 56, 62, 76, 52, 409, 89, 87, 19, 17, 22, 18, 26, 24, 23, 87, 1, 2, 5, 4, 5, 2, 1, 2, 1); // 0xBE7
            private static Player Sayid_Armand = new Player(133, 108, 56, 62, 51, 64, 51, 99, 48, 431, 101, 84, 17, 18, 20, 19, 18, 24, 23, 84, 3, 3, 3, 2, 3, 3, 2, 5, 2); // 0xBE8
            private static Player Mansur_Jasim = new Player(130, 112, 57, 54, 58, 62, 48, 86, 52, 417, 99, 93, 18, 20, 18, 20, 20, 24, 23, 93, 3, 5, 2, 4, 1, 2, 3, 4, 1); // 0xBE9
            private static Player Zack_Abdulla = new Player(135, 107, 96, 49, 50, 46, 61, 75, 52, 429, 105, 88, 27, 18, 18, 16, 21, 24, 23, 88, 2, 3, 2, 3, 2, 1, 4, 5, 4); // 0xBEA
            private static Player Majdi_Ismail = new Player(137, 119, 61, 60, 62, 54, 71, 80, 54, 442, 104, 102, 28, 22, 25, 20, 24, 25, 23, 102, 5, 4, 4, 1, 3, 4, 3, 5, 3); // 0xBEB
            private static Player Talal_Hamad = new Player(140, 130, 48, 65, 50, 79, 55, 73, 64, 434, 108, 93, 20, 18, 19, 38, 23, 24, 22, 93, 2, 3, 3, 5, 1, 4, 2, 4, 1); // 0xBEC
            private static Player Hasan_Ahmed = new Player(139, 103, 54, 58, 56, 62, 53, 80, 51, 414, 106, 83, 19, 23, 18, 20, 21, 25, 22, 83, 1, 5, 4, 1, 3, 5, 2, 3, 4); // 0xBED
            private static Player Khalfan_Jibril = new Player(128, 124, 47, 63, 63, 61, 49, 73, 69, 425, 94, 92, 18, 23, 20, 24, 23, 25, 25, 92, 5, 1, 4, 1, 1, 3, 3, 5, 3); // 0xBEE
            private static Player Rajab_Ismail = new Player(123, 115, 50, 56, 54, 72, 56, 79, 59, 426, 86, 81, 25, 20, 22, 22, 21, 24, 21, 81, 1, 5, 3, 3, 1, 3, 4, 4, 3); // 0xBEF
            private static Player Adel_Siddique = new Player(134, 107, 55, 59, 55, 58, 67, 72, 49, 415, 106, 84, 22, 18, 18, 18, 21, 25, 22, 84, 4, 5, 3, 3, 1, 1, 1, 4, 2); // 0xBF0
            private static Player Jeongsu_Cho = new Player(125, 132, 54, 56, 52, 72, 48, 54, 103, 439, 85, 99, 18, 23, 18, 24, 23, 21, 29, 99, 5, 5, 4, 5, 4, 4, 3, 4, 4); // 0xBF5
            private static Player Umi_Hwang_ = new Player(133, 110, 52, 54, 65, 70, 66, 55, 64, 426, 78, 90, 19, 18, 26, 24, 24, 20, 19, 90, 4, 1, 1, 2, 3, 2, 5, 3, 4); // 0xBF6
            private static Player Dooyoon_Hong = new Player(129, 128, 53, 57, 56, 59, 63, 50, 60, 398, 81, 104, 19, 21, 23, 23, 23, 18, 18, 104, 2, 1, 2, 2, 5, 5, 2, 3, 4); // 0xBF7
            private static Player Minho_Cho = new Player(124, 134, 65, 52, 50, 69, 48, 63, 60, 407, 83, 89, 23, 20, 18, 20, 18, 23, 23, 89, 5, 2, 4, 2, 4, 3, 4, 5, 2); // 0xBF8
            private static Player Songhwan_Ko = new Player(119, 127, 48, 54, 51, 70, 49, 50, 61, 383, 79, 100, 24, 25, 25, 24, 26, 19, 25, 100, 2, 2, 2, 1, 5, 3, 3, 3, 1); // 0xBF9
            private static Player Paekyeong_Park = new Player(122, 129, 48, 76, 53, 79, 43, 54, 48, 401, 81, 85, 26, 28, 19, 27, 17, 18, 18, 85, 1, 5, 2, 5, 4, 2, 1, 4, 1); // 0xBFA
            private static Player Byron_Love_FD = new Player(130, 130, 63, 60, 77, 59, 61, 59, 58, 437, 88, 100, 16, 22, 21, 17, 17, 14, 13, 100, 2, 2, 2, 3, 2, 1, 1, 5, 1); // 0xBFB
            private static Player Eunyeong_Kim = new Player(108, 117, 48, 76, 48, 77, 46, 40, 45, 380, 77, 92, 26, 29, 18, 29, 15, 18, 20, 92, 1, 3, 5, 3, 2, 2, 1, 2, 2); // 0xBFC
            private static Player Claude_Beacons_FD = new Player(133, 108, 75, 71, 55, 58, 58, 61, 67, 445, 75, 79, 21, 20, 17, 15, 23, 17, 18, 79, 5, 2, 1, 5, 2, 1, 2, 3, 4); // 0xBFD
            private static Player Changsu_Choi = new Player(102, 109, 52, 65, 85, 60, 54, 50, 63, 429, 80, 88, 21, 23, 24, 21, 24, 22, 21, 88, 2, 4, 3, 2, 3, 5, 1, 4, 3); // 0xBFE
            private static Player Bryce_Whitingale_FD = new Player(129, 118, 65, 65, 65, 68, 66, 57, 60, 446, 76, 79, 22, 14, 22, 21, 21, 17, 20, 79, 5, 2, 1, 1, 2, 5, 2, 3, 4); // 0xBFF
            private static Player Chi_Won_Ho = new Player(115, 128, 51, 48, 52, 65, 48, 48, 68, 380, 78, 111, 18, 26, 25, 35, 18, 19, 26, 111, 3, 1, 3, 2, 1, 2, 5, 1, 4); // 0xC00
            private static Player Dong_Hyun_Seul = new Player(130, 106, 65, 64, 53, 52, 54, 48, 68, 404, 82, 84, 25, 24, 20, 20, 18, 18, 20, 84, 1, 5, 4, 1, 1, 3, 2, 3, 4); // 0xC01
            private static Player Jung_Hoon_Yi = new Player(127, 123, 49, 67, 68, 66, 51, 51, 69, 421, 79, 85, 19, 18, 18, 20, 25, 18, 24, 85, 1, 1, 5, 5, 2, 4, 4, 4, 4); // 0xC02
            private static Player Sung_Jin_Noh = new Player(127, 124, 75, 48, 49, 57, 54, 48, 64, 395, 79, 100, 27, 19, 20, 18, 18, 18, 18, 100, 1, 1, 2, 3, 5, 3, 2, 4, 1); // 0xC03
            private static Player Joon_Ho_Ja = new Player(128, 120, 53, 50, 60, 56, 62, 60, 74, 415, 78, 88, 18, 20, 21, 19, 21, 22, 22, 88, 2, 2, 5, 3, 3, 2, 2, 1, 2); // 0xC04
            private static Player Freddy_McQueen = new Player(120, 140, 50, 67, 48, 82, 51, 46, 64, 408, 106, 88, 20, 26, 19, 30, 18, 25, 24, 88, 1, 1, 2, 2, 1, 5, 1, 1, 1); // 0xC09
            private static Player Jonny_Gascoigne = new Player(128, 127, 52, 62, 67, 68, 62, 62, 54, 427, 76, 115, 19, 18, 23, 24, 28, 20, 18, 115, 5, 1, 3, 1, 4, 2, 5, 4, 4); // 0xC0A
            private static Player David_Buckingham = new Player(127, 108, 54, 60, 78, 66, 53, 55, 50, 416, 81, 97, 24, 29, 25, 27, 28, 18, 24, 97, 1, 3, 5, 2, 4, 3, 3, 3, 4); // 0xC0B
            private static Player Lance_Rawton = new Player(126, 120, 65, 71, 56, 58, 54, 54, 77, 435, 80, 102, 24, 24, 21, 18, 18, 21, 19, 102, 1, 1, 1, 1, 3, 4, 2, 5, 4); // 0xC0C
            private static Player Edge_Ripper = new Player(123, 117, 54, 54, 53, 71, 69, 58, 62, 421, 67, 99, 24, 20, 25, 21, 29, 15, 26, 99, 1, 5, 5, 4, 4, 5, 1, 1, 2); // 0xC0D
            private static Player Peter_Cole = new Player(133, 103, 51, 66, 60, 53, 56, 71, 57, 414, 96, 84, 22, 19, 21, 16, 24, 27, 22, 84, 4, 2, 1, 5, 4, 3, 1, 1, 3); // 0xC0E
            private static Player Gary_Mane = new Player(124, 116, 54, 84, 72, 59, 52, 47, 54, 422, 63, 78, 20, 27, 29, 23, 20, 16, 18, 78, 3, 4, 3, 5, 3, 5, 2, 4, 4); // 0xC0F
            private static Player Paul_Appleton = new Player(125, 109, 55, 58, 60, 54, 59, 60, 57, 403, 91, 91, 21, 23, 23, 23, 25, 20, 21, 91, 3, 3, 2, 2, 3, 3, 2, 5, 2); // 0xC10
            private static Player Eric_Purpleton = new Player(127, 116, 65, 63, 52, 55, 64, 51, 55, 405, 60, 82, 24, 25, 20, 18, 26, 15, 18, 82, 4, 2, 3, 1, 5, 2, 5, 2, 3); // 0xC11
            private static Player Edgar_Partinus = new Player(126, 119, 96, 71, 58, 47, 57, 48, 57, 434, 93, 103, 30, 26, 21, 18, 26, 21, 16, 103, 4, 5, 3, 4, 4, 3, 1, 1, 1); // 0xC12
            private static Player Phillip_Owen = new Player(122, 121, 90, 44, 52, 50, 68, 60, 63, 427, 84, 100, 27, 23, 27, 22, 30, 22, 27, 100, 5, 5, 2, 4, 3, 5, 3, 3, 2); // 0xC13
            private static Player Servilius_Jeeves = new Player(134, 136, 43, 57, 68, 69, 62, 56, 48, 403, 64, 100, 20, 28, 26, 26, 24, 17, 24, 100, 5, 5, 2, 1, 5, 5, 1, 3, 2); // 0xC14
            private static Player Martin_Squall = new Player(105, 109, 51, 48, 69, 56, 62, 34, 62, 382, 51, 84, 20, 26, 18, 20, 26, 14, 22, 84, 1, 2, 4, 4, 5, 3, 5, 1, 2); // 0xC15
            private static Player Nick_Woodgate = new Player(125, 114, 67, 59, 51, 54, 51, 62, 56, 400, 82, 103, 18, 21, 18, 21, 26, 19, 23, 103, 2, 3, 4, 3, 3, 1, 5, 3, 1); // 0xC16
            private static Player Mikey_Richards = new Player(130, 122, 55, 53, 69, 51, 71, 60, 51, 410, 85, 97, 19, 20, 26, 18, 23, 22, 18, 97, 4, 4, 4, 5, 2, 2, 1, 3, 2); // 0xC17
            private static Player Sirius_Pounding = new Player(137, 107, 65, 62, 44, 43, 56, 64, 66, 400, 105, 74, 27, 26, 17, 17, 16, 24, 25, 74, 4, 4, 1, 1, 4, 2, 2, 5, 3); // 0xC18
            private static Player Indigo_Lazuli = new Player(114, 134, 52, 50, 51, 76, 36, 42, 68, 375, 63, 100, 21, 20, 27, 29, 22, 16, 22, 100, 1, 2, 1, 4, 2, 5, 3, 2, 2); // 0xC1D
            private static Player Roseo_Diamante = new Player(115, 126, 40, 44, 40, 69, 52, 45, 70, 360, 90, 99, 23, 23, 21, 21, 22, 21, 23, 99, 4, 2, 4, 1, 2, 3, 5, 5, 2); // 0xC1E
            private static Player Azubel_Turchese = new Player(113, 116, 53, 53, 52, 71, 44, 54, 65, 392, 79, 76, 19, 24, 18, 25, 16, 19, 16, 76, 5, 3, 5, 5, 4, 3, 3, 1, 3); // 0xC1F
            private static Player Nello_Agata = new Player(109, 122, 41, 62, 46, 54, 67, 33, 56, 359, 87, 76, 16, 16, 15, 28, 27, 22, 27, 76, 3, 2, 3, 3, 3, 3, 3, 5, 4); // 0xC20
            private static Player Azzurro_Zaffiro = new Player(107, 128, 44, 64, 64, 63, 40, 45, 52, 372, 61, 68, 15, 24, 24, 24, 17, 16, 16, 68, 1, 1, 4, 4, 5, 3, 4, 5, 2); // 0xC21
            private static Player Beldio_Smeraldo = new Player(115, 117, 37, 57, 68, 52, 51, 45, 73, 383, 75, 94, 14, 26, 23, 18, 28, 17, 21, 94, 2, 1, 4, 2, 2, 4, 5, 4, 2); // 0xC22
            private static Player Rosso_Granato = new Player(108, 107, 71, 57, 52, 62, 53, 48, 46, 389, 79, 83, 26, 20, 18, 25, 24, 25, 20, 83, 5, 5, 1, 2, 5, 2, 2, 2, 1); // 0xC23
            private static Player Giallo_Topazio = new Player(118, 103, 63, 51, 48, 50, 68, 41, 64, 385, 64, 90, 27, 22, 18, 18, 26, 15, 26, 90, 1, 3, 3, 3, 5, 2, 3, 5, 1); // 0xC24
            private static Player Bianco_Perla = new Player(109, 99, 74, 56, 56, 42, 47, 40, 59, 374, 85, 76, 29, 26, 22, 19, 23, 22, 25, 76, 3, 2, 5, 4, 3, 3, 1, 1, 1); // 0xC25
            private static Player Giulio_Acuto = new Player(118, 114, 76, 69, 76, 48, 72, 53, 52, 446, 76, 92, 20, 18, 19, 20, 15, 18, 16, 92, 2, 5, 3, 1, 5, 2, 4, 2, 1); // 0xC26
            private static Player Violetto_Ametista = new Player(116, 116, 52, 53, 60, 51, 57, 48, 52, 373, 73, 102, 27, 27, 27, 28, 27, 27, 29, 102, 5, 3, 4, 4, 5, 2, 5, 5, 4); // 0xC27
            private static Player Grigio_Quarzo = new Player(114, 94, 42, 64, 48, 67, 32, 63, 38, 354, 69, 70, 15, 24, 19, 24, 12, 17, 26, 70, 4, 3, 4, 4, 5, 1, 5, 5, 1); // 0xC28
            private static Player Pardo_Berillo = new Player(107, 120, 40, 64, 50, 52, 44, 52, 55, 357, 80, 91, 28, 20, 28, 20, 27, 20, 18, 91, 3, 3, 5, 2, 5, 4, 4, 2, 3); // 0xC29
            private static Player Marrone_Corniola = new Player(107, 117, 56, 59, 52, 53, 49, 57, 51, 377, 94, 84, 20, 18, 19, 24, 24, 25, 25, 84, 3, 3, 3, 2, 2, 1, 3, 5, 2); // 0xC2A
            private static Player Amaranto_Rubino = new Player(106, 120, 58, 63, 40, 62, 46, 41, 72, 382, 68, 73, 25, 24, 15, 25, 17, 15, 15, 73, 1, 3, 5, 5, 3, 4, 3, 2, 2); // 0xC2B
            private static Player Avorio_Opale = new Player(110, 109, 71, 44, 45, 44, 74, 61, 41, 380, 94, 76, 27, 15, 17, 15, 29, 28, 15, 76, 5, 3, 5, 3, 4, 3, 3, 2, 3); // 0xC2C
            private static Player Jorge_Ortega = new Player(125, 128, 56, 54, 49, 80, 60, 60, 59, 418, 88, 110, 21, 22, 18, 21, 20, 22, 23, 110, 5, 2, 3, 2, 4, 5, 2, 3, 4); // 0xC31
            private static Player Thiago_Torres = new Player(134, 129, 52, 62, 60, 82, 59, 51, 70, 436, 79, 118, 28, 27, 20, 19, 27, 20, 19, 118, 3, 5, 1, 3, 5, 1, 4, 2, 4); // 0xC32
            private static Player Julio_Acosta = new Player(134, 118, 67, 70, 48, 74, 62, 51, 36, 408, 94, 91, 26, 24, 19, 24, 18, 23, 13, 91, 5, 3, 4, 4, 5, 5, 3, 1, 3); // 0xC33
            private static Player Grande_Diaz = new Player(126, 102, 49, 58, 60, 73, 52, 42, 77, 411, 72, 85, 18, 28, 27, 29, 18, 18, 29, 85, 2, 3, 5, 3, 1, 5, 2, 3, 2); // 0xC34
            private static Player Ramon_Martinez = new Player(122, 126, 53, 59, 51, 69, 56, 54, 78, 420, 105, 87, 26, 24, 22, 20, 24, 26, 24, 87, 2, 3, 2, 2, 4, 1, 5, 3, 4); // 0xC35
            private static Player Esteban_Carlos = new Player(127, 103, 58, 59, 58, 64, 59, 58, 69, 425, 88, 73, 19, 24, 22, 15, 29, 22, 21, 73, 3, 4, 4, 4, 5, 1, 3, 1, 2); // 0xC36
            private static Player Sergio_Perez = new Player(126, 105, 47, 60, 52, 70, 65, 55, 64, 413, 75, 82, 15, 25, 25, 19, 24, 18, 20, 82, 5, 5, 1, 2, 5, 3, 1, 2, 1); // 0xC37
            private static Player Roberto_Torres = new Player(122, 108, 68, 60, 54, 65, 79, 62, 58, 446, 87, 95, 27, 24, 18, 18, 27, 21, 18, 95, 5, 3, 5, 2, 4, 1, 5, 5, 4); // 0xC38
            private static Player Pablo_Castillo = new Player(128, 99, 68, 71, 48, 60, 60, 52, 60, 419, 75, 80, 24, 25, 19, 18, 21, 18, 23, 80, 2, 1, 4, 1, 4, 5, 2, 5, 2); // 0xC39
            private static Player Leone_Badigo = new Player(130, 120, 68, 58, 44, 68, 76, 41, 52, 407, 112, 99, 29, 18, 15, 18, 27, 16, 15, 99, 1, 4, 5, 3, 5, 3, 4, 3, 1); // 0xC3A
            private static Player Diego_Oro = new Player(125, 117, 61, 59, 66, 60, 56, 60, 71, 433, 97, 87, 25, 24, 25, 21, 25, 24, 25, 87, 4, 4, 3, 2, 5, 4, 3, 3, 4); // 0xC3B
            private static Player Lionel_Cruz = new Player(133, 128, 52, 60, 49, 56, 57, 60, 56, 390, 86, 97, 22, 23, 23, 23, 23, 21, 21, 97, 1, 5, 5, 2, 1, 3, 2, 2, 1); // 0xC3C
            private static Player Mario_Saviola = new Player(136, 103, 50, 61, 52, 57, 58, 50, 52, 380, 76, 89, 25, 22, 19, 15, 29, 18, 19, 89, 5, 1, 5, 1, 3, 1, 3, 1, 3); // 0xC3D
            private static Player Hernan_Tevez = new Player(128, 99, 52, 60, 60, 75, 60, 52, 76, 435, 80, 89, 18, 19, 22, 22, 22, 20, 20, 89, 3, 1, 2, 2, 4, 4, 3, 5, 4); // 0xC3E
            private static Player Herman_Samuel = new Player(124, 115, 53, 77, 40, 60, 52, 45, 40, 367, 62, 100, 25, 15, 25, 17, 26, 15, 29, 100, 4, 5, 1, 2, 4, 3, 5, 5, 1); // 0xC3F
            private static Player Ricardo_Aguero = new Player(128, 106, 43, 40, 40, 56, 41, 67, 40, 327, 106, 90, 21, 23, 23, 23, 26, 24, 15, 90, 2, 3, 1, 1, 4, 5, 2, 4, 3); // 0xC40
            private static Player Billy_Dash = new Player(100, 129, 72, 40, 44, 75, 75, 37, 67, 410, 50, 104, 27, 16, 15, 29, 27, 26, 29, 104, 5, 5, 4, 5, 2, 4, 5, 3, 4); // 0xC45
            private static Player Ted_Bryant = new Player(121, 144, 47, 40, 45, 55, 68, 48, 62, 365, 111, 122, 16, 15, 15, 27, 28, 27, 17, 122, 3, 4, 2, 3, 3, 3, 3, 5, 3); // 0xC46
            private static Player Tony_Strider = new Player(140, 115, 52, 68, 53, 74, 52, 54, 49, 402, 73, 95, 20, 26, 24, 24, 24, 18, 20, 95, 2, 2, 5, 5, 1, 4, 3, 3, 1); // 0xC47
            private static Player Drake_Dynamo = new Player(128, 86, 76, 73, 34, 80, 37, 32, 73, 405, 56, 78, 28, 29, 13, 27, 18, 13, 24, 78, 2, 1, 3, 4, 5, 2, 2, 1, 1); // 0xC48
            private static Player Bobby_Shearer_2 = new Player(129, 125, 56, 61, 62, 76, 60, 65, 61, 441, 67, 88, 12, 10, 13, 19, 14, 11, 12, 88, 1, 2, 2, 5, 2, 2, 2, 2, 3); // 0xC49
            private static Player Steve_Woodmark = new Player(132, 107, 52, 68, 52, 54, 49, 64, 70, 409, 80, 90, 18, 24, 25, 24, 24, 18, 26, 90, 5, 2, 3, 1, 5, 4, 5, 1, 1); // 0xC4A
            private static Player Erik_Eagle_2 = new Player(130, 128, 79, 60, 72, 64, 63, 53, 71, 462, 67, 96, 13, 16, 23, 14, 20, 17, 19, 96, 2, 2, 2, 2, 5, 1, 4, 4, 1); // 0xC4B
            private static Player Shane_Pierce = new Player(118, 135, 49, 58, 72, 43, 40, 40, 44, 346, 68, 122, 19, 23, 27, 22, 22, 16, 17, 122, 2, 1, 5, 5, 5, 1, 4, 4, 3); // 0xC4C
            private static Player Mark_Krueger = new Player(131, 130, 68, 88, 64, 57, 58, 57, 54, 446, 91, 119, 21, 23, 29, 23, 24, 21, 27, 119, 4, 5, 2, 2, 1, 5, 4, 5, 4); // 0xC4D
            private static Player Dylan_Keats = new Player(125, 110, 95, 52, 60, 47, 51, 60, 62, 427, 92, 92, 28, 24, 24, 21, 28, 22, 22, 92, 4, 2, 5, 1, 5, 5, 4, 1, 4); // 0xC4E
            private static Player Gabriel_Jax = new Player(125, 124, 62, 66, 69, 55, 50, 60, 53, 415, 88, 108, 26, 27, 29, 27, 21, 23, 21, 108, 3, 1, 1, 4, 3, 5, 2, 3, 1); // 0xC4F
            private static Player Alex_Hawke = new Player(105, 114, 92, 76, 39, 47, 35, 32, 89, 410, 50, 76, 28, 29, 13, 21, 19, 12, 27, 76, 1, 5, 5, 3, 5, 4, 2, 3, 3); // 0xC50
            private static Player Corey_Washington = new Player(118, 112, 63, 51, 52, 50, 62, 56, 56, 390, 88, 95, 22, 18, 18, 19, 22, 23, 21, 95, 2, 3, 3, 1, 5, 4, 3, 3, 1); // 0xC51
            private static Player Bob_Bobbins = new Player(127, 122, 69, 54, 55, 51, 52, 49, 54, 384, 72, 96, 27, 20, 18, 18, 19, 20, 18, 96, 2, 1, 5, 1, 4, 2, 4, 1, 1); // 0xC52
            private static Player Petie_Pooma = new Player(132, 98, 32, 37, 36, 36, 75, 76, 78, 370, 114, 65, 12, 13, 14, 14, 28, 29, 27, 65, 3, 5, 4, 4, 3, 3, 1, 4, 1); // 0xC53
            private static Player Norbert_Poindexter = new Player(128, 102, 59, 57, 63, 56, 56, 58, 52, 401, 86, 90, 24, 21, 21, 23, 21, 21, 18, 90, 5, 3, 2, 5, 4, 2, 2, 1, 4); // 0xC54
            private static Player Gigi_Blasi = new Player(107, 124, 63, 50, 72, 86, 32, 36, 83, 422, 92, 98, 27, 24, 27, 29, 23, 21, 27, 98, 1, 1, 5, 4, 5, 5, 2, 5, 4); // 0xC59
            private static Player Vento_Galliano = new Player(126, 122, 42, 52, 56, 77, 80, 56, 56, 419, 100, 108, 15, 19, 27, 23, 29, 26, 19, 108, 4, 2, 1, 5, 1, 3, 4, 2, 1); // 0xC5A
            private static Player Ottorino_Nobili = new Player(140, 126, 60, 66, 61, 72, 53, 56, 61, 429, 92, 100, 25, 27, 18, 27, 18, 21, 25, 100, 3, 4, 5, 2, 3, 3, 4, 2, 1); // 0xC5B
            private static Player Anton_Graziuso = new Player(135, 115, 58, 52, 62, 76, 51, 47, 86, 432, 92, 102, 23, 23, 19, 21, 23, 21, 29, 102, 3, 4, 4, 1, 4, 3, 5, 4, 2); // 0xC5C
            private static Player Marco_Maserati = new Player(132, 122, 56, 61, 65, 66, 62, 68, 56, 434, 105, 90, 22, 24, 24, 24, 25, 25, 19, 90, 1, 2, 2, 2, 3, 2, 3, 5, 1); // 0xC5D
            private static Player Angelo_Gabrini = new Player(115, 133, 50, 53, 64, 68, 72, 48, 58, 413, 79, 123, 18, 19, 27, 18, 28, 18, 20, 123, 1, 5, 2, 5, 1, 1, 3, 5, 4); // 0xC5E
            private static Player Gianluca_Zanardi = new Player(122, 123, 56, 65, 64, 57, 64, 52, 56, 414, 97, 111, 20, 25, 25, 23, 26, 26, 20, 111, 3, 5, 2, 2, 2, 2, 2, 3, 2); // 0xC5F
            private static Player Giorgio_Giannini = new Player(132, 126, 56, 74, 61, 59, 59, 54, 61, 424, 91, 102, 27, 28, 18, 23, 22, 24, 23, 102, 1, 3, 1, 2, 3, 5, 3, 1, 1); // 0xC60
            private static Player Dante_Diavolo = new Player(140, 124, 83, 70, 52, 51, 51, 42, 76, 425, 98, 102, 29, 25, 19, 29, 21, 26, 24, 102, 1, 1, 4, 5, 1, 1, 5, 4, 3); // 0xC61
            private static Player Paolo_Bianchi = new Player(115, 130, 62, 78, 79, 46, 66, 58, 66, 455, 94, 115, 25, 26, 26, 22, 24, 22, 24, 115, 4, 5, 2, 3, 1, 5, 4, 2, 2); // 0xC62
            private static Player Raffaele_Generani = new Player(120, 118, 70, 60, 52, 63, 71, 48, 60, 424, 102, 100, 27, 27, 18, 27, 25, 28, 27, 100, 4, 5, 1, 5, 3, 1, 4, 5, 4); // 0xC63
            private static Player Daniele_Sanctis = new Player(136, 136, 48, 68, 53, 75, 66, 37, 61, 408, 69, 125, 18, 22, 18, 21, 25, 15, 26, 125, 5, 3, 4, 2, 3, 2, 5, 3, 3); // 0xC64
            private static Player Enrico_Oliviero = new Player(128, 126, 65, 77, 52, 53, 52, 54, 56, 409, 98, 111, 25, 25, 24, 25, 26, 26, 26, 111, 1, 1, 4, 2, 5, 1, 3, 1, 4); // 0xC65
            private static Player Alessandro_Rossa = new Player(100, 148, 61, 62, 62, 57, 63, 58, 56, 419, 84, 100, 21, 22, 22, 21, 22, 22, 23, 100, 1, 2, 1, 3, 5, 1, 4, 2, 2); // 0xC66
            private static Player Giuseppe_Cannavaro = new Player(140, 122, 49, 48, 55, 77, 52, 48, 64, 393, 81, 80, 24, 24, 26, 18, 19, 19, 19, 80, 3, 1, 4, 4, 2, 5, 1, 3, 1); // 0xC67
            private static Player Dino_Zolletta = new Player(132, 108, 75, 76, 49, 55, 68, 40, 69, 432, 104, 80, 25, 26, 20, 19, 20, 25, 24, 80, 4, 3, 1, 1, 5, 2, 1, 1, 1); // 0xC68
            private static Player Falcao_Da_Silva = new Player(120, 136, 49, 61, 52, 72, 59, 62, 56, 411, 108, 120, 28, 25, 18, 24, 29, 29, 29, 120, 4, 1, 1, 2, 5, 3, 3, 2, 2); // 0xC6D
            private static Player Carlos_Lagarto = new Player(124, 117, 50, 51, 50, 68, 69, 64, 68, 420, 100, 89, 24, 19, 20, 22, 24, 24, 26, 89, 4, 5, 2, 4, 4, 2, 4, 5, 2); // 0xC6E
            private static Player Antonio_Bagre = new Player(122, 116, 47, 59, 58, 66, 48, 60, 61, 399, 105, 85, 22, 23, 21, 28, 21, 18, 18, 85, 3, 1, 4, 1, 3, 3, 1, 5, 3); // 0xC6F
            private static Player Monstro_Ximenes = new Player(128, 115, 96, 64, 40, 58, 51, 48, 67, 424, 104, 99, 21, 26, 24, 24, 25, 25, 27, 99, 3, 2, 5, 2, 3, 1, 2, 4, 1); // 0xC70
            private static Player Formiga_Clemens = new Player(123, 121, 51, 56, 62, 70, 60, 56, 57, 412, 108, 95, 23, 23, 21, 23, 29, 23, 24, 95, 4, 2, 4, 2, 1, 2, 5, 2, 3); // 0xC71
            private static Player Presa_Passos = new Player(115, 129, 52, 58, 74, 48, 75, 50, 77, 434, 98, 114, 27, 28, 27, 17, 24, 18, 29, 114, 4, 1, 4, 3, 4, 1, 4, 5, 1); // 0xC72
            private static Player Borboleta_Barboza = new Player(118, 110, 67, 60, 69, 62, 65, 64, 48, 435, 104, 100, 24, 24, 25, 18, 25, 24, 19, 100, 2, 5, 2, 2, 5, 2, 2, 3, 1); // 0xC73
            private static Player Coruja_Cerezo = new Player(127, 122, 52, 64, 55, 75, 70, 69, 64, 449, 101, 104, 21, 22, 18, 23, 28, 21, 26, 104, 2, 4, 5, 1, 1, 2, 4, 1, 3); // 0xC74
            private static Player Leonardo_Almeida = new Player(130, 125, 68, 100, 51, 68, 45, 39, 60, 431, 102, 102, 24, 27, 28, 24, 25, 18, 19, 102, 2, 4, 4, 1, 4, 5, 2, 1, 2); // 0xC75
            private static Player Mac_Robingo = new Player(130, 114, 85, 60, 70, 60, 60, 63, 54, 452, 108, 97, 28, 21, 27, 22, 29, 24, 24, 97, 3, 4, 4, 2, 5, 4, 3, 3, 2); // 0xC76
            private static Player Gato_Carvalho = new Player(130, 121, 76, 68, 57, 68, 63, 55, 60, 447, 97, 105, 29, 29, 21, 28, 21, 19, 23, 105, 3, 4, 3, 2, 5, 3, 1, 1, 1); // 0xC77
            private static Player Xavier_Ribeiro = new Player(121, 137, 76, 56, 63, 76, 40, 47, 75, 433, 95, 114, 18, 22, 21, 29, 16, 15, 17, 114, 2, 3, 4, 4, 4, 2, 5, 1, 1); // 0xC78
            private static Player Ulisses_Nogueira = new Player(130, 122, 50, 58, 56, 66, 53, 51, 51, 385, 91, 97, 21, 24, 25, 26, 22, 23, 21, 97, 2, 2, 3, 4, 1, 5, 3, 4, 4); // 0xC79
            private static Player Gervasio_Oliveira = new Player(110, 132, 68, 60, 68, 64, 44, 44, 71, 419, 90, 119, 24, 23, 24, 21, 17, 17, 26, 119, 3, 5, 1, 4, 4, 5, 2, 5, 3); // 0xC7A
            private static Player Tigre_Mendes = new Player(127, 118, 52, 74, 58, 50, 69, 60, 51, 414, 99, 107, 26, 25, 21, 19, 24, 25, 20, 107, 5, 3, 3, 1, 2, 2, 5, 4, 3); // 0xC7B
            private static Player Grillo_Santos = new Player(133, 125, 63, 58, 57, 55, 58, 49, 62, 402, 102, 69, 20, 23, 27, 23, 29, 18, 27, 69, 3, 3, 4, 2, 1, 1, 1, 5, 1); // 0xC7C
            private static Player Cyril_Fox = new Player(127, 139, 57, 50, 60, 70, 65, 49, 52, 403, 90, 106, 23, 20, 21, 18, 24, 22, 21, 106, 4, 1, 3, 5, 1, 1, 3, 1, 1); // 0xC81
            private static Player Jacques_Allemand = new Player(120, 132, 62, 49, 52, 68, 55, 55, 52, 393, 88, 97, 28, 21, 22, 21, 24, 22, 22, 97, 4, 2, 2, 5, 1, 1, 3, 3, 4); // 0xC82
            private static Player Phil_A__Minion = new Player(128, 135, 52, 68, 77, 69, 52, 54, 64, 436, 93, 123, 18, 27, 28, 22, 25, 23, 24, 123, 5, 5, 2, 1, 5, 5, 2, 2, 3); // 0xC83
            private static Player Buddy_Plains = new Player(114, 128, 60, 56, 52, 60, 53, 52, 58, 391, 78, 102, 21, 19, 20, 22, 25, 19, 21, 102, 3, 4, 3, 1, 5, 5, 3, 1, 1); // 0xC84
            private static Player Dean_Goddard = new Player(116, 136, 50, 60, 61, 57, 61, 60, 52, 401, 91, 111, 18, 20, 22, 19, 25, 23, 18, 111, 2, 1, 2, 1, 2, 3, 3, 5, 4); // 0xC85
            private static Player Cecil_Crowley = new Player(139, 127, 54, 59, 54, 61, 49, 56, 54, 387, 88, 100, 21, 25, 24, 25, 22, 22, 18, 100, 4, 5, 5, 2, 1, 1, 3, 2, 4); // 0xC86
            private static Player Seth_Hedges = new Player(133, 129, 49, 57, 52, 57, 58, 66, 60, 399, 106, 88, 19, 19, 20, 18, 23, 24, 24, 88, 2, 1, 5, 2, 2, 3, 2, 1, 1); // 0xC87
            private static Player Niccolo_Mantegna = new Player(132, 130, 60, 70, 49, 48, 60, 52, 57, 396, 76, 88, 21, 22, 20, 18, 24, 19, 18, 88, 2, 1, 2, 5, 1, 1, 1, 1, 4); // 0xC88
            private static Player Damien_Crawford = new Player(122, 130, 53, 64, 51, 53, 72, 48, 64, 405, 72, 91, 29, 28, 18, 27, 18, 18, 19, 91, 2, 1, 1, 5, 2, 3, 2, 2, 2); // 0xC89
            private static Player Avinash_Chowdhury = new Player(124, 129, 59, 56, 51, 50, 60, 52, 72, 400, 72, 81, 28, 29, 18, 20, 29, 18, 23, 81, 2, 2, 1, 1, 5, 4, 3, 3, 3); // 0xC8A
            private static Player Sedgley_Scofield = new Player(122, 137, 69, 79, 51, 53, 50, 53, 48, 403, 79, 95, 21, 21, 22, 22, 21, 20, 18, 95, 5, 3, 2, 3, 5, 3, 3, 1, 1); // 0xC8B
            private static Player Grizzler_Bruin = new Player(133, 138, 67, 64, 52, 59, 54, 49, 48, 393, 73, 88, 18, 24, 24, 28, 25, 19, 24, 88, 2, 4, 5, 3, 2, 4, 1, 5, 2); // 0xC8C
            private static Player Ian_C__Wincy = new Player(138, 136, 52, 69, 55, 73, 48, 68, 54, 419, 78, 88, 19, 18, 20, 20, 20, 18, 18, 88, 2, 2, 1, 1, 2, 3, 2, 5, 2); // 0xC8D
            private static Player Bandy_Horsman = new Player(130, 129, 62, 76, 48, 53, 52, 70, 55, 416, 99, 118, 18, 24, 18, 19, 18, 26, 19, 118, 4, 1, 3, 3, 2, 2, 2, 5, 2); // 0xC8E
            private static Player Ali_Caiman = new Player(137, 128, 70, 62, 56, 57, 56, 52, 56, 409, 73, 85, 18, 19, 19, 25, 19, 19, 20, 85, 2, 1, 3, 3, 4, 5, 5, 5, 1); // 0xC8F
            private static Player Chris_Ellis = new Player(136, 136, 53, 50, 77, 51, 74, 52, 59, 416, 76, 93, 18, 19, 24, 20, 29, 20, 20, 93, 4, 5, 2, 5, 2, 5, 1, 3, 4); // 0xC90
            private static Player Hector_Helio = new Player(110, 132, 58, 50, 57, 85, 55, 69, 73, 447, 98, 110, 28, 28, 24, 80, 26, 24, 28, 110, 3, 4, 3, 2, 4, 2, 2, 5, 2); // 0xC95
            private static Player Zephyr_Vitesse = new Player(115, 104, 68, 57, 69, 60, 78, 50, 45, 427, 105, 90, 47, 40, 25, 54, 65, 45, 35, 90, 4, 5, 3, 4, 3, 3, 1, 3, 2); // 0xC96
            private static Player Walter_Mountain = new Player(130, 120, 63, 65, 60, 71, 45, 48, 49, 401, 115, 103, 40, 50, 50, 60, 30, 40, 40, 103, 2, 5, 4, 4, 5, 1, 1, 4, 3); // 0xC97
            private static Player Jimi_Gaines = new Player(123, 115, 56, 52, 68, 67, 52, 62, 61, 418, 104, 95, 30, 40, 58, 56, 20, 21, 23, 95, 2, 2, 1, 5, 5, 3, 5, 3, 3); // 0xC98
            private static Player Ian_Ferrum = new Player(124, 127, 48, 48, 52, 56, 60, 62, 66, 392, 97, 111, 38, 35, 18, 22, 21, 22, 26, 111, 5, 1, 2, 2, 1, 5, 2, 1, 1); // 0xC99
            private static Player Quint_Hampton = new Player(120, 100, 62, 62, 62, 62, 62, 65, 62, 437, 86, 90, 55, 55, 55, 55, 55, 60, 55, 90, 4, 1, 4, 1, 3, 5, 4, 4, 2); // 0xC9A
            private static Player Yasir_Haddad = new Player(128, 108, 59, 76, 62, 58, 48, 48, 61, 412, 84, 107, 50, 49, 21, 21, 18, 19, 22, 107, 3, 3, 4, 2, 5, 5, 1, 4, 1); // 0xC9B
            private static Player Keith_Ryan = new Player(128, 114, 64, 60, 61, 60, 49, 61, 76, 431, 91, 82, 50, 48, 21, 23, 19, 21, 28, 82, 1, 1, 3, 4, 5, 5, 4, 4, 2); // 0xC9C
            private static Player Maximino_Cruz = new Player(127, 120, 60, 62, 79, 68, 56, 58, 62, 445, 90, 102, 22, 23, 29, 26, 23, 21, 21, 102, 4, 4, 1, 5, 4, 5, 4, 3, 1); // 0xC9D
            private static Player Gareth_Flare = new Player(133, 124, 79, 66, 58, 62, 66, 64, 56, 451, 108, 111, 60, 50, 40, 51, 43, 25, 23, 111, 4, 2, 4, 2, 1, 5, 1, 3, 2); // 0xC9E
            private static Player Drago_Hill = new Player(124, 117, 85, 56, 62, 50, 30, 71, 67, 421, 105, 107, 75, 40, 22, 30, 21, 26, 24, 107, 1, 1, 5, 5, 5, 1, 4, 3, 2); // 0xC9F
            private static Player Keenan_DiFortune = new Player(114, 130, 55, 52, 55, 52, 68, 52, 52, 386, 102, 96, 22, 22, 19, 26, 22, 18, 22, 96, 3, 1, 4, 2, 3, 5, 2, 2, 2); // 0xCA0
            private static Player Jarell_Mangrove = new Player(123, 122, 52, 52, 69, 55, 55, 56, 50, 389, 74, 99, 24, 17, 25, 16, 21, 20, 18, 99, 3, 1, 3, 3, 3, 5, 1, 3, 3); // 0xCA1
            private static Player Vic_Vitrum = new Player(122, 128, 58, 61, 62, 60, 59, 62, 60, 422, 88, 104, 21, 21, 21, 22, 21, 21, 22, 104, 2, 2, 1, 3, 3, 2, 5, 4, 3); // 0xCA2
            private static Player Li_Leung = new Player(136, 125, 73, 63, 50, 52, 60, 60, 55, 413, 78, 115, 21, 17, 19, 22, 21, 21, 24, 115, 3, 2, 2, 3, 1, 5, 2, 4, 4); // 0xCA3
            private static Player Jazzy_Hedgeer = new Player(119, 132, 43, 70, 57, 71, 53, 55, 70, 419, 105, 100, 20, 20, 20, 15, 26, 19, 24, 100, 2, 3, 2, 4, 1, 5, 3, 4, 2); // 0xCA4
            private static Player Roger_Pialat = new Player(116, 143, 48, 66, 63, 72, 58, 56, 54, 417, 81, 103, 21, 18, 23, 26, 25, 19, 25, 103, 2, 2, 1, 5, 3, 2, 4, 5, 4); // 0xCA9
            private static Player Kevin_Pinot = new Player(120, 121, 50, 67, 67, 56, 61, 60, 53, 414, 85, 99, 19, 21, 26, 22, 24, 23, 25, 99, 5, 3, 1, 3, 3, 4, 5, 1, 3); // 0xCAA
            private static Player Michael_Aron = new Player(113, 119, 50, 62, 62, 72, 47, 44, 53, 390, 68, 103, 24, 24, 20, 23, 19, 16, 19, 103, 1, 1, 4, 4, 3, 4, 5, 1, 3); // 0xCAB
            private static Player Francis_Poujol = new Player(122, 120, 53, 59, 63, 60, 48, 49, 52, 384, 98, 118, 26, 27, 20, 28, 24, 24, 25, 118, 1, 4, 1, 5, 5, 5, 2, 3, 2); // 0xCAC
            private static Player Pierre_Godin = new Player(116, 127, 53, 55, 74, 55, 56, 51, 63, 407, 78, 114, 26, 26, 25, 25, 25, 18, 24, 114, 2, 1, 2, 2, 4, 5, 1, 3, 1); // 0xCAD
            private static Player Roland_Perec = new Player(112, 131, 55, 52, 70, 59, 65, 48, 52, 401, 80, 112, 22, 23, 22, 21, 26, 19, 21, 112, 4, 4, 3, 2, 3, 2, 5, 3, 3); // 0xCAE
            private static Player Julien_Rousseau = new Player(129, 124, 56, 62, 79, 61, 57, 52, 68, 435, 66, 99, 27, 20, 25, 22, 25, 18, 25, 99, 5, 2, 5, 5, 4, 2, 4, 3, 1); // 0xCAF
            private static Player Stephane_Hinault = new Player(115, 120, 51, 54, 64, 56, 52, 49, 53, 379, 88, 95, 18, 25, 24, 20, 25, 18, 23, 95, 3, 4, 5, 5, 1, 5, 4, 5, 4); // 0xCB0
            private static Player Romuald_Huysmans = new Player(127, 117, 57, 55, 66, 52, 60, 48, 55, 393, 75, 102, 18, 23, 22, 20, 28, 18, 18, 102, 4, 4, 1, 5, 5, 4, 4, 3, 2); // 0xCB1
            private static Player Jerome_Hervaud = new Player(133, 118, 60, 66, 70, 51, 57, 64, 52, 420, 104, 101, 28, 20, 19, 18, 29, 25, 18, 101, 2, 4, 3, 5, 5, 4, 4, 5, 4); // 0xCB2
            private static Player Alain_Favreau = new Player(117, 113, 62, 61, 72, 47, 58, 60, 52, 412, 91, 102, 19, 27, 20, 18, 25, 22, 19, 102, 3, 1, 3, 4, 3, 5, 3, 2, 2); // 0xCB3
            private static Player Emile_Lazare = new Player(127, 136, 50, 69, 60, 67, 55, 54, 66, 421, 73, 112, 20, 27, 20, 28, 18, 20, 25, 112, 5, 2, 2, 5, 5, 2, 3, 2, 2); // 0xCB4
            private static Player Andre_Pinson = new Player(110, 118, 52, 67, 68, 58, 58, 56, 59, 418, 92, 85, 18, 18, 20, 20, 23, 22, 22, 85, 2, 2, 3, 5, 1, 2, 1, 4, 3); // 0xCB5
            private static Player Jean_Gutain = new Player(109, 121, 52, 51, 64, 60, 54, 42, 55, 378, 60, 111, 26, 24, 26, 25, 23, 17, 18, 111, 3, 5, 3, 5, 5, 4, 3, 1, 3); // 0xCB6
            private static Player Claude_Moreau = new Player(125, 115, 58, 70, 71, 57, 50, 48, 56, 410, 85, 104, 23, 25, 21, 22, 21, 23, 23, 104, 3, 5, 5, 5, 4, 2, 5, 2, 4); // 0xCB7
            private static Player Michel_Morland = new Player(119, 124, 63, 61, 68, 50, 63, 50, 50, 405, 72, 84, 26, 26, 19, 18, 26, 20, 18, 84, 4, 2, 1, 2, 5, 2, 2, 5, 4); // 0xCB8
            private static Player Fermin_Sanchez = new Player(129, 134, 45, 45, 47, 97, 40, 66, 70, 410, 90, 118, 16, 17, 17, 29, 16, 24, 24, 118, 3, 4, 1, 3, 3, 1, 1, 5, 2); // 0xCBD
            private static Player Jose_Costa = new Player(118, 110, 43, 45, 61, 73, 52, 56, 55, 385, 74, 92, 12, 12, 15, 25, 25, 23, 25, 92, 1, 4, 5, 4, 5, 2, 4, 3, 1); // 0xCBE
            private static Player Rafael_Lopez = new Player(122, 120, 45, 59, 55, 76, 48, 74, 62, 419, 73, 108, 17, 16, 19, 24, 18, 28, 28, 108, 2, 4, 1, 5, 4, 2, 3, 1, 2); // 0xCBF
            private static Player Antonio_Gallego = new Player(130, 103, 54, 62, 48, 65, 52, 40, 79, 400, 82, 86, 23, 23, 19, 22, 20, 16, 21, 86, 2, 3, 1, 1, 3, 2, 5, 4, 3); // 0xCC0
            private static Player Queraldo_Naval = new Player(134, 101, 68, 61, 45, 63, 66, 67, 51, 421, 75, 87, 23, 16, 16, 29, 27, 18, 27, 87, 5, 1, 3, 3, 5, 3, 2, 3, 2); // 0xCC1
            private static Player Juan_Nadal = new Player(125, 121, 40, 75, 70, 44, 64, 70, 44, 407, 73, 102, 16, 26, 17, 16, 26, 26, 15, 102, 5, 1, 1, 3, 4, 5, 4, 1, 4); // 0xCC2
            private static Player Igor_Ferreira = new Player(130, 119, 52, 68, 78, 55, 60, 67, 44, 424, 106, 92, 19, 21, 12, 19, 26, 25, 13, 92, 1, 4, 4, 4, 2, 4, 1, 5, 3); // 0xCC3
            private static Player Pedro_Moreno = new Player(124, 102, 69, 58, 60, 33, 76, 54, 49, 399, 99, 77, 26, 24, 12, 14, 26, 29, 18, 77, 1, 5, 3, 4, 5, 3, 5, 3, 3); // 0xCC4
            private static Player Miguel_Pereira = new Player(126, 114, 68, 57, 73, 51, 78, 49, 47, 423, 76, 85, 18, 20, 14, 20, 27, 18, 20, 85, 2, 3, 4, 4, 2, 2, 5, 1, 2); // 0xCC5
            private static Player Samuel_Mayo = new Player(120, 109, 66, 74, 59, 43, 71, 44, 64, 421, 50, 97, 28, 20, 14, 15, 23, 14, 27, 97, 5, 1, 5, 4, 3, 5, 3, 2, 3); // 0xCC6
            private static Player Davi_Peroque = new Player(117, 103, 70, 66, 55, 40, 56, 52, 63, 402, 74, 93, 22, 25, 15, 16, 23, 20, 23, 93, 3, 1, 5, 5, 2, 1, 5, 2, 2); // 0xCC7
            private static Player Juan_Espindola = new Player(133, 125, 58, 51, 40, 76, 67, 39, 52, 383, 48, 112, 19, 20, 16, 27, 25, 13, 20, 112, 5, 4, 2, 2, 4, 2, 3, 5, 3); // 0xCC8
            private static Player Isaac_Cesar = new Player(125, 114, 67, 76, 56, 49, 82, 42, 52, 424, 68, 91, 27, 20, 17, 18, 28, 15, 18, 91, 1, 2, 1, 3, 1, 5, 4, 2, 4); // 0xCC9
            private static Player Laudelino_Castor = new Player(123, 108, 57, 66, 40, 64, 63, 54, 59, 403, 74, 94, 23, 21, 15, 22, 21, 20, 22, 94, 4, 1, 3, 4, 5, 4, 3, 3, 3); // 0xCCA
            private static Player Carlos_Arroyo = new Player(128, 115, 51, 73, 56, 56, 51, 79, 47, 413, 115, 104, 18, 26, 20, 20, 24, 27, 15, 104, 3, 1, 1, 2, 5, 3, 3, 3, 4); // 0xCCB
            private static Player Federico_Rubiera = new Player(134, 100, 47, 81, 68, 35, 59, 61, 60, 411, 106, 90, 21, 22, 13, 12, 22, 25, 23, 90, 5, 5, 3, 1, 3, 3, 3, 2, 1); // 0xCCC
            private static Player Thorsten_Welger = new Player(120, 132, 64, 63, 62, 73, 52, 57, 56, 427, 97, 111, 18, 23, 20, 21, 25, 24, 26, 111, 2, 2, 1, 1, 4, 5, 2, 3, 4); // 0xCD1
            private static Player Alexander_Hausen = new Player(125, 116, 62, 63, 61, 65, 57, 59, 58, 425, 75, 87, 25, 26, 20, 20, 26, 23, 21, 87, 3, 1, 4, 3, 1, 5, 3, 3, 2); // 0xCD2
            private static Player Heinrich_Farber = new Player(125, 109, 63, 73, 65, 64, 58, 56, 61, 440, 74, 93, 19, 21, 18, 21, 24, 19, 18, 93, 4, 5, 5, 1, 5, 1, 4, 2, 3); // 0xCD3
            private static Player Kurt_Zawel = new Player(126, 104, 57, 73, 62, 54, 57, 51, 57, 411, 104, 90, 21, 21, 19, 21, 21, 25, 24, 90, 5, 1, 1, 1, 5, 2, 3, 5, 3); // 0xCD4
            private static Player Lukas_Schmidt = new Player(118, 120, 64, 80, 65, 63, 60, 50, 50, 432, 93, 85, 24, 19, 18, 20, 23, 23, 18, 85, 2, 3, 3, 5, 4, 2, 3, 3, 1); // 0xCD5
            private static Player Theodor_Ulrich = new Player(130, 108, 65, 77, 58, 56, 68, 51, 44, 419, 76, 92, 24, 24, 23, 19, 18, 20, 20, 92, 2, 5, 5, 5, 2, 5, 5, 2, 2); // 0xCD6
            private static Player Jan_Oster = new Player(129, 117, 56, 64, 66, 55, 62, 42, 54, 399, 78, 101, 20, 22, 26, 22, 18, 18, 18, 101, 2, 2, 4, 3, 2, 4, 2, 5, 1); // 0xCD7
            private static Player Niklas_Kuster = new Player(131, 112, 68, 71, 58, 57, 65, 46, 57, 422, 82, 96, 18, 25, 19, 20, 23, 20, 18, 96, 5, 2, 4, 3, 3, 5, 3, 5, 2); // 0xCD8
            private static Player Jonas_Polk = new Player(124, 123, 66, 64, 65, 56, 65, 64, 59, 439, 72, 85, 20, 19, 26, 19, 18, 18, 19, 85, 3, 1, 5, 4, 2, 4, 1, 1, 1); // 0xCD9
            private static Player Maximilian_Muller = new Player(117, 109, 67, 63, 58, 56, 63, 56, 65, 428, 81, 87, 21, 20, 18, 19, 20, 18, 23, 87, 4, 4, 1, 4, 3, 3, 5, 2, 2); // 0xCDA
            private static Player Peter_Naumann = new Player(116, 110, 67, 62, 55, 55, 64, 47, 63, 413, 90, 96, 21, 18, 18, 20, 18, 24, 20, 96, 1, 5, 1, 1, 3, 5, 2, 4, 1); // 0xCDB
            private static Player Gerhard_Enders = new Player(118, 129, 61, 64, 55, 79, 62, 58, 46, 425, 98, 107, 21, 25, 18, 24, 20, 21, 22, 107, 5, 5, 4, 2, 5, 4, 5, 5, 4); // 0xCDC
            private static Player Erwin_Volz = new Player(120, 113, 65, 65, 66, 55, 66, 46, 65, 428, 74, 93, 18, 20, 20, 19, 19, 19, 18, 93, 5, 2, 5, 5, 3, 4, 1, 3, 2); // 0xCDD
            private static Player Jens_Hoffman = new Player(127, 106, 61, 73, 67, 57, 60, 63, 49, 430, 74, 92, 18, 20, 18, 20, 20, 19, 19, 92, 4, 2, 5, 4, 4, 4, 5, 2, 4); // 0xCDE
            private static Player Ernst_Fliedner = new Player(125, 105, 57, 77, 62, 58, 56, 49, 53, 412, 74, 82, 19, 26, 21, 20, 18, 18, 18, 82, 5, 5, 4, 5, 4, 5, 1, 2, 1); // 0xCDF
            private static Player Emmanuel_Ewerz = new Player(119, 118, 69, 73, 61, 66, 59, 45, 50, 423, 72, 82, 18, 18, 18, 19, 18, 18, 20, 82, 5, 4, 2, 5, 1, 2, 2, 3, 3); // 0xCE0
            private static Player Zolani_Baloi = new Player(153, 108, 71, 64, 52, 63, 63, 56, 67, 436, 93, 84, 24, 12, 14, 23, 22, 22, 22, 84, 4, 1, 4, 1, 3, 5, 1, 4, 1); // 0xCE5
            private static Player Dakarai_Furman = new Player(148, 89, 62, 76, 45, 54, 66, 62, 67, 432, 93, 74, 24, 22, 18, 23, 25, 22, 18, 74, 1, 3, 2, 5, 4, 5, 3, 3, 1); // 0xCE6
            private static Player Jake_Fana = new Player(154, 75, 63, 66, 45, 50, 58, 60, 75, 417, 90, 57, 18, 21, 14, 26, 25, 22, 28, 57, 4, 4, 4, 2, 4, 2, 5, 2, 3); // 0xCE7
            private static Player Masego_Molelo = new Player(153, 88, 66, 63, 48, 56, 75, 60, 64, 432, 91, 78, 18, 19, 21, 20, 26, 19, 24, 78, 1, 3, 5, 3, 5, 5, 3, 2, 4); // 0xCE8
            private static Player Cassius_Tobler = new Player(152, 89, 61, 68, 49, 49, 59, 71, 78, 435, 75, 54, 17, 20, 19, 19, 25, 18, 18, 54, 3, 1, 3, 3, 1, 4, 5, 2, 2); // 0xCE9
            private static Player Anton_Nortje = new Player(149, 91, 59, 70, 49, 51, 57, 68, 79, 433, 73, 55, 23, 21, 20, 17, 21, 18, 20, 55, 2, 5, 1, 5, 5, 2, 2, 2, 1); // 0xCEA
            private static Player Adam_Marunga = new Player(147, 97, 68, 79, 53, 58, 72, 50, 60, 440, 87, 84, 18, 26, 19, 26, 25, 21, 19, 84, 1, 2, 3, 5, 2, 1, 4, 5, 2); // 0xCEB
            private static Player Reggie_Ines = new Player(139, 95, 75, 64, 58, 57, 66, 55, 65, 440, 82, 80, 19, 18, 22, 18, 24, 20, 19, 80, 4, 5, 1, 2, 4, 2, 2, 1, 3); // 0xCEC
            private static Player Siyabonga_Mahlangu = new Player(146, 93, 60, 61, 54, 53, 51, 56, 63, 398, 85, 72, 20, 23, 22, 23, 22, 21, 18, 72, 5, 4, 5, 5, 4, 3, 2, 3, 1); // 0xCED
            private static Player Nathan_Tswane = new Player(144, 94, 66, 83, 57, 48, 65, 59, 65, 443, 85, 71, 23, 24, 26, 20, 21, 21, 22, 71, 3, 4, 2, 1, 2, 5, 2, 4, 3); // 0xCEE
            private static Player Melisizwe_Zamani = new Player(145, 100, 75, 66, 40, 40, 73, 60, 60, 414, 88, 89, 27, 17, 17, 15, 28, 22, 16, 89, 4, 3, 4, 1, 1, 2, 3, 5, 2); // 0xCEF
            private static Player Herschel_De_Villiers = new Player(138, 94, 81, 74, 40, 45, 75, 35, 64, 414, 54, 80, 27, 28, 18, 20, 25, 13, 21, 80, 3, 1, 5, 3, 1, 2, 5, 5, 1); // 0xCF0
            private static Player Moeneeb_Booysen = new Player(147, 98, 60, 61, 50, 55, 61, 64, 63, 414, 102, 87, 19, 18, 20, 20, 19, 25, 19, 87, 3, 4, 4, 4, 2, 5, 1, 1, 3); // 0xCF1
            private static Player Kennedy_McCarthy = new Player(143, 82, 63, 60, 51, 51, 65, 60, 61, 411, 76, 55, 18, 18, 18, 20, 19, 18, 20, 55, 4, 4, 1, 5, 2, 3, 2, 1, 4); // 0xCF2
            private static Player Hugh_Makebe = new Player(144, 105, 72, 67, 50, 58, 60, 56, 64, 427, 93, 54, 20, 19, 18, 18, 18, 23, 18, 54, 3, 2, 3, 2, 2, 2, 2, 5, 4); // 0xCF3
            private static Player Themba_Sepeng = new Player(158, 97, 68, 63, 54, 52, 55, 56, 68, 416, 49, 63, 12, 13, 12, 14, 13, 12, 14, 63, 2, 1, 5, 3, 5, 3, 5, 2, 1); // 0xCF4
            private static Player Decker_Pile = new Player(128, 118, 66, 64, 69, 64, 60, 61, 64, 448, 85, 80, 18, 23, 23, 21, 21, 20, 18, 80, 4, 2, 3, 5, 1, 5, 5, 1, 1); // 0xCF9
            private static Player Chucky_Cardaway = new Player(126, 115, 82, 54, 66, 48, 56, 41, 76, 423, 77, 80, 24, 19, 20, 18, 20, 18, 19, 80, 1, 5, 3, 2, 3, 2, 2, 2, 2); // 0xCFA
            private static Player Bernie_Ellement = new Player(125, 105, 76, 78, 42, 47, 72, 40, 69, 424, 89, 93, 25, 19, 20, 18, 20, 20, 18, 93, 2, 3, 3, 1, 5, 2, 3, 1, 2); // 0xCFB
            private static Player Woody_Ellement = new Player(136, 104, 43, 58, 79, 57, 71, 51, 60, 419, 83, 80, 19, 18, 18, 19, 19, 19, 20, 80, 2, 2, 5, 5, 2, 3, 2, 3, 3); // 0xCFC
            private static Player Gail_Ellement = new Player(127, 120, 40, 44, 81, 43, 97, 41, 56, 402, 86, 82, 20, 20, 23, 20, 22, 20, 20, 82, 3, 4, 4, 3, 3, 5, 4, 2, 3); // 0xCFD
            private static Player Clay_Ellement = new Player(123, 106, 50, 67, 64, 65, 65, 64, 57, 432, 94, 74, 22, 21, 23, 21, 23, 23, 23, 74, 1, 4, 5, 1, 1, 1, 2, 1, 2); // 0xCFE
            private static Player Neville_Goodenough = new Player(126, 106, 62, 62, 63, 62, 68, 58, 75, 450, 70, 85, 16, 16, 15, 15, 15, 15, 16, 85, 5, 3, 3, 3, 3, 1, 3, 5, 1); // 0xCFF
            private static Player Lucien_Rarey = new Player(126, 120, 41, 64, 46, 69, 66, 44, 43, 373, 68, 55, 13, 13, 14, 12, 14, 14, 12, 55, 4, 2, 1, 1, 5, 3, 2, 2, 3); // 0xD00
            private static Player Stackem_Skyhigh = new Player(116, 132, 72, 59, 48, 45, 52, 33, 88, 397, 84, 93, 23, 18, 20, 20, 18, 20, 22, 93, 3, 4, 1, 3, 4, 2, 5, 4, 1); // 0xD01
            private static Player Anfaira_D_vantage = new Player(125, 100, 47, 64, 65, 69, 60, 57, 65, 427, 84, 82, 18, 19, 20, 19, 20, 19, 20, 82, 2, 5, 5, 3, 3, 5, 1, 1, 1); // 0xD02
            private static Player Walken_Ruhlbuch = new Player(126, 115, 40, 42, 63, 78, 52, 55, 48, 378, 101, 102, 21, 21, 21, 23, 21, 21, 22, 102, 5, 4, 1, 4, 2, 4, 3, 5, 3); // 0xD04
            private static Player Saki_Shimizu = new Player(129, 108, 53, 50, 54, 76, 52, 52, 54, 391, 60, 62, 13, 15, 14, 17, 12, 12, 13, 62, 5, 2, 1, 1, 1, 1, 1, 5, 4); // 0xD05
            private static Player Momoko_Tsugunaga = new Player(108, 130, 40, 40, 42, 73, 72, 41, 46, 354, 67, 55, 15, 15, 12, 13, 13, 13, 14, 55, 4, 2, 4, 4, 1, 5, 3, 1, 2); // 0xD06
            private static Player Chinami_Tokunaga = new Player(110, 125, 41, 43, 46, 75, 46, 46, 77, 374, 67, 62, 13, 14, 13, 14, 14, 14, 13, 62, 5, 3, 1, 5, 4, 4, 2, 5, 1); // 0xD07
            private static Player Maasa_Sudou = new Player(125, 114, 45, 78, 40, 43, 42, 40, 43, 331, 67, 70, 12, 12, 14, 12, 12, 12, 17, 70, 5, 4, 1, 5, 1, 5, 5, 1, 1); // 0xD08
            private static Player Risako_Sugaya = new Player(110, 125, 44, 78, 43, 42, 43, 44, 78, 372, 68, 66, 12, 13, 14, 13, 12, 13, 12, 66, 5, 3, 4, 3, 3, 5, 2, 5, 1); // 0xD09
            private static Player Yurina_Kumai = new Player(121, 122, 75, 40, 40, 43, 75, 40, 42, 355, 65, 68, 15, 14, 12, 14, 13, 12, 14, 68, 2, 4, 2, 5, 5, 4, 5, 3, 4); // 0xD0A
            private static Player Miyabi_Natsuyaki = new Player(103, 134, 74, 41, 45, 46, 47, 40, 40, 333, 63, 65, 17, 13, 12, 14, 14, 13, 17, 65, 3, 5, 3, 3, 1, 5, 5, 5, 3); // 0xD0B
            private static Player Karl_Kappa = new Player(121, 122, 74, 49, 48, 64, 71, 70, 57, 433, 104, 98, 14, 19, 20, 12, 12, 25, 20, 98, 3, 3, 2, 3, 4, 3, 5, 2, 1); // 0xD0C
            private static Player Lars_Luceafar = new Player(160, 180, 50, 50, 50, 99, 58, 60, 63, 430, 120, 120, 21, 23, 22, 95, 24, 21, 24, 120, 4, 4, 2, 5, 1, 4, 2, 1, 4); // 0xD21
            private static Player Lump_Trungus = new Player(127, 142, 48, 71, 49, 76, 62, 50, 60, 416, 99, 110, 19, 21, 18, 70, 27, 18, 25, 110, 2, 4, 5, 1, 2, 3, 2, 5, 2); // 0xD22
            private static Player Bump_Trungus = new Player(127, 154, 49, 73, 48, 81, 63, 49, 59, 422, 107, 104, 19, 21, 19, 75, 27, 18, 25, 104, 4, 2, 5, 5, 5, 5, 2, 3, 2); // 0xD23
            private static Player Oni_Triumvir = new Player(126, 149, 50, 80, 71, 53, 58, 64, 65, 441, 99, 110, 18, 27, 26, 21, 25, 25, 29, 110, 2, 1, 3, 5, 5, 2, 5, 1, 4); // 0xD24
            private static Player Drachen_Gunther = new Player(135, 153, 51, 75, 53, 50, 60, 68, 71, 428, 100, 102, 18, 27, 26, 21, 26, 26, 27, 102, 3, 1, 1, 4, 2, 2, 5, 4, 3); // 0xD25
            private static Player Mystral_Callous = new Player(130, 158, 73, 53, 51, 54, 76, 59, 58, 424, 90, 108, 27, 25, 28, 23, 27, 21, 24, 108, 3, 4, 2, 2, 5, 3, 4, 1, 2); // 0xD26
            private static Player Radd_Ischer = new Player(124, 156, 52, 74, 50, 78, 55, 70, 57, 436, 99, 120, 23, 21, 22, 27, 24, 25, 25, 120, 5, 4, 2, 2, 4, 5, 1, 4, 1); // 0xD27
            private static Player Escavan_Malice = new Player(126, 150, 78, 48, 54, 48, 72, 60, 63, 423, 92, 98, 27, 25, 29, 21, 27, 23, 25, 98, 3, 1, 2, 3, 5, 2, 3, 3, 2); // 0xD28
            private static Player Bash_Lancer = new Player(127, 152, 81, 51, 52, 52, 72, 72, 65, 445, 98, 110, 75, 27, 28, 25, 28, 28, 28, 110, 2, 1, 2, 1, 3, 5, 4, 2, 1); // 0xD29
            private static Player Ichabod_Stark = new Player(128, 140, 51, 72, 74, 49, 54, 68, 59, 427, 99, 100, 28, 25, 23, 22, 24, 24, 24, 100, 5, 5, 3, 3, 5, 3, 4, 2, 1); // 0xD2A
            private static Player Jynx_Jenkins = new Player(131, 145, 49, 73, 46, 76, 54, 68, 64, 430, 90, 90, 21, 23, 21, 28, 26, 24, 26, 90, 2, 5, 2, 4, 4, 1, 4, 2, 4); // 0xD2B
            private static Player Anorel = new Player(112, 146, 58, 53, 60, 73, 67, 51, 56, 418, 90, 110, 21, 21, 21, 26, 21, 21, 23, 110, 5, 4, 2, 3, 2, 5, 2, 5, 1); // 0xD49
            private static Player Nenel = new Player(127, 124, 64, 58, 64, 80, 67, 52, 56, 441, 93, 100, 21, 22, 22, 25, 22, 22, 21, 100, 3, 5, 4, 5, 4, 5, 3, 1, 4); // 0xD4A
            private static Player Genel = new Player(124, 118, 60, 55, 69, 75, 72, 53, 60, 444, 88, 102, 23, 23, 22, 24, 21, 21, 22, 102, 1, 4, 4, 5, 1, 2, 2, 3, 2); // 0xD4B
            private static Player Ekadel = new Player(120, 119, 63, 67, 69, 78, 71, 48, 56, 452, 90, 98, 23, 23, 23, 24, 23, 22, 23, 98, 5, 1, 2, 4, 5, 2, 2, 3, 3); // 0xD4C
            private static Player Lephiel = new Player(125, 127, 58, 67, 62, 65, 80, 48, 59, 439, 94, 101, 23, 25, 23, 23, 21, 21, 21, 101, 2, 5, 1, 2, 5, 3, 1, 1, 2); // 0xD4D
            private static Player Sachinel = new Player(121, 120, 59, 61, 63, 64, 72, 52, 56, 427, 85, 98, 21, 24, 21, 21, 21, 22, 21, 98, 3, 4, 5, 2, 2, 3, 3, 4, 4); // 0xD4E
            private static Player Wenel = new Player(113, 121, 64, 72, 67, 61, 71, 52, 60, 447, 88, 108, 21, 24, 22, 21, 23, 22, 21, 108, 4, 1, 5, 1, 1, 4, 2, 2, 3); // 0xD4F
            private static Player Ientel = new Player(107, 136, 61, 63, 74, 69, 67, 49, 60, 443, 84, 119, 25, 21, 21, 22, 21, 22, 23, 119, 5, 3, 1, 5, 2, 4, 4, 2, 2); // 0xD50
            private static Player Nuel = new Player(115, 115, 60, 61, 68, 61, 69, 51, 58, 428, 94, 103, 26, 21, 23, 23, 22, 23, 21, 103, 1, 3, 5, 3, 5, 2, 1, 1, 3); // 0xD51
            private static Player Gaiel = new Player(109, 139, 65, 61, 62, 64, 88, 50, 59, 449, 94, 121, 25, 21, 22, 23, 21, 22, 21, 121, 5, 1, 2, 2, 1, 5, 3, 1, 4); // 0xD52
            private static Player Sanctus = new Player(125, 114, 71, 64, 76, 62, 69, 51, 60, 453, 94, 99, 25, 22, 22, 21, 21, 23, 21, 99, 4, 1, 4, 2, 1, 2, 5, 1, 2); // 0xD53
            private static Player Astaroth = new Player(123, 134, 65, 56, 48, 66, 57, 54, 71, 417, 94, 118, 23, 22, 22, 24, 22, 23, 21, 118, 2, 5, 4, 4, 5, 3, 3, 4, 4); // 0xD5D
            private static Player Bael = new Player(135, 119, 65, 69, 47, 71, 56, 50, 77, 435, 93, 100, 21, 22, 22, 24, 21, 21, 21, 100, 2, 2, 5, 1, 2, 1, 3, 2, 3); // 0xD5E
            private static Player Abigor = new Player(125, 117, 69, 56, 52, 67, 60, 52, 73, 429, 86, 98, 23, 23, 23, 24, 22, 23, 21, 98, 4, 1, 2, 3, 5, 5, 5, 3, 1); // 0xD5F
            private static Player Behemoth = new Player(126, 108, 66, 72, 48, 66, 61, 54, 78, 445, 85, 97, 23, 21, 23, 24, 22, 23, 23, 97, 3, 5, 1, 4, 1, 2, 2, 1, 2); // 0xD60
            private static Player Belial = new Player(130, 107, 69, 68, 50, 50, 66, 52, 74, 429, 91, 97, 21, 26, 22, 21, 22, 23, 23, 97, 2, 2, 2, 2, 5, 4, 2, 2, 3); // 0xD61
            private static Player Malphas = new Player(127, 116, 67, 68, 46, 52, 58, 52, 74, 417, 84, 101, 21, 25, 23, 23, 23, 23, 21, 101, 3, 4, 2, 1, 1, 2, 2, 5, 1); // 0xD62
            private static Player Glasya = new Player(131, 110, 80, 77, 50, 50, 54, 51, 71, 433, 90, 99, 22, 25, 21, 23, 21, 22, 22, 99, 4, 4, 4, 3, 3, 5, 1, 1, 4); // 0xD63
            private static Player Jezebeth = new Player(112, 130, 71, 68, 61, 56, 55, 54, 77, 442, 91, 110, 23, 26, 21, 21, 22, 22, 21, 110, 4, 5, 3, 5, 2, 3, 5, 4, 2); // 0xD64
            private static Player Arachne = new Player(114, 132, 68, 74, 51, 46, 61, 53, 72, 425, 90, 96, 25, 21, 23, 22, 22, 23, 21, 96, 3, 3, 4, 1, 3, 5, 2, 2, 1); // 0xD65
            private static Player Thanatos = new Player(134, 104, 73, 75, 46, 46, 70, 49, 71, 430, 92, 90, 24, 22, 23, 23, 22, 22, 22, 90, 5, 2, 2, 4, 1, 4, 5, 5, 1); // 0xD66
            private static Player Destra = new Player(137, 121, 80, 73, 55, 49, 58, 55, 78, 448, 87, 97, 26, 23, 21, 23, 21, 23, 22, 97, 4, 1, 2, 2, 5, 4, 1, 4, 2); // 0xD67
            private static Player Percy_Verens = new Player(133, 90, 62, 45, 44, 47, 65, 48, 48, 359, 67, 69, 20, 12, 14, 12, 13, 13, 12, 69, 5, 3, 2, 3, 1, 2, 5, 2, 2); // 0xE11
            private static Player Bishop_Carver = new Player(122, 115, 53, 51, 44, 61, 50, 45, 50, 354, 66, 74, 18, 18, 20, 21, 20, 19, 18, 74, 4, 2, 1, 1, 1, 2, 5, 2, 3); // 0xE12
            private static Player Skyler_Styler = new Player(97, 131, 47, 58, 49, 48, 58, 48, 52, 360, 69, 66, 18, 23, 18, 18, 22, 19, 18, 66, 5, 1, 5, 3, 5, 4, 3, 5, 3); // 0xE13
            private static Player Balen_Straw = new Player(94, 126, 53, 54, 54, 57, 53, 39, 55, 365, 57, 59, 14, 13, 13, 12, 13, 13, 12, 59, 4, 5, 4, 2, 5, 2, 1, 5, 3); // 0xE14
            private static Player Malachi_Way = new Player(126, 90, 44, 44, 51, 62, 50, 60, 50, 361, 73, 60, 17, 15, 16, 23, 15, 23, 15, 60, 3, 5, 2, 1, 3, 1, 1, 2, 2); // 0xE15
            private static Player Paul_Kerface = new Player(106, 116, 53, 51, 51, 65, 51, 51, 51, 373, 57, 56, 14, 13, 12, 13, 12, 14, 14, 56, 2, 2, 5, 1, 5, 3, 2, 3, 4); // 0xE16
            private static Player Chip_Tatum = new Player(133, 91, 53, 65, 51, 58, 53, 51, 51, 382, 57, 59, 13, 12, 12, 13, 13, 12, 14, 59, 3, 2, 5, 5, 4, 5, 4, 3, 4); // 0xE17
            private static Player Rebus_Stumper = new Player(126, 116, 41, 65, 41, 63, 40, 39, 40, 329, 59, 56, 14, 14, 14, 12, 12, 13, 14, 56, 4, 3, 3, 1, 5, 3, 1, 2, 3); // 0xE18
            private static Player Cutter_Shorten = new Player(91, 117, 65, 65, 43, 63, 39, 39, 41, 355, 60, 55, 13, 14, 14, 13, 12, 12, 13, 55, 2, 5, 5, 5, 3, 4, 4, 5, 4); // 0xE19
            private static Player Manny_Pickles = new Player(113, 112, 44, 47, 54, 45, 54, 57, 63, 364, 68, 65, 17, 17, 18, 16, 20, 18, 18, 65, 4, 2, 2, 3, 3, 5, 1, 4, 3); // 0xE1A
            private static Player Campen_Allerjee = new Player(122, 116, 64, 50, 48, 50, 51, 43, 48, 354, 71, 73, 21, 21, 21, 23, 22, 21, 23, 73, 4, 5, 4, 3, 4, 5, 4, 5, 2); // 0xE1B
            private static Player Climie_Hills = new Player(94, 124, 47, 46, 48, 65, 52, 40, 66, 364, 72, 73, 21, 23, 21, 21, 21, 22, 21, 73, 4, 4, 4, 2, 5, 5, 2, 3, 2); // 0xE1C
            private static Player Earl_Bird = new Player(99, 124, 45, 46, 51, 62, 50, 44, 62, 360, 72, 73, 21, 21, 23, 23, 21, 22, 22, 73, 4, 4, 5, 4, 1, 2, 3, 1, 4); // 0xE1D
            private static Player Walt_Whittler = new Player(119, 85, 61, 59, 47, 59, 46, 44, 44, 360, 67, 69, 18, 20, 20, 18, 18, 20, 19, 69, 5, 4, 4, 5, 4, 3, 1, 5, 3); // 0xE1E
            private static Player Merry_Piper = new Player(118, 99, 59, 61, 48, 60, 48, 49, 51, 376, 67, 56, 22, 21, 14, 22, 14, 15, 15, 56, 1, 5, 5, 5, 2, 2, 3, 3, 4); // 0xE1F
            private static Player Traylor_Beadle = new Player(87, 132, 61, 60, 41, 40, 41, 51, 58, 352, 66, 66, 18, 19, 20, 19, 20, 18, 20, 66, 3, 1, 5, 1, 5, 3, 3, 1, 3); // 0xE20
            private static Player Doug_Boateng = new Player(119, 98, 53, 56, 56, 56, 53, 53, 56, 383, 70, 58, 23, 22, 14, 21, 12, 16, 15, 58, 4, 1, 3, 1, 2, 2, 5, 2, 4); // 0xE21
            private static Player Fanny_Oakley = new Player(124, 111, 54, 57, 45, 46, 49, 63, 49, 363, 76, 75, 19, 18, 13, 12, 12, 25, 14, 75, 3, 1, 3, 5, 4, 3, 3, 2, 1); // 0xE25
            private static Player Bucky_Colt = new Player(119, 102, 63, 57, 56, 57, 53, 55, 56, 397, 69, 67, 13, 15, 17, 15, 19, 19, 19, 67, 4, 2, 4, 5, 3, 3, 2, 1, 1); // 0xE26
            private static Player Chuckie_Roper = new Player(114, 106, 58, 61, 53, 54, 56, 54, 53, 389, 66, 58, 21, 23, 17, 17, 15, 18, 19, 58, 3, 1, 5, 3, 4, 1, 1, 5, 3); // 0xE27
            private static Player Lucien_Brightside = new Player(114, 102, 55, 54, 45, 45, 51, 54, 51, 355, 70, 67, 19, 18, 18, 18, 19, 19, 18, 67, 4, 1, 4, 4, 5, 4, 3, 2, 4); // 0xE28
            private static Player Caffrey_Punt = new Player(120, 97, 53, 55, 54, 56, 57, 54, 53, 382, 70, 65, 20, 19, 20, 18, 20, 18, 20, 65, 1, 2, 3, 2, 3, 2, 3, 5, 4); // 0xE29
            private static Player Debra_Lee = new Player(109, 125, 48, 44, 53, 48, 57, 56, 53, 359, 60, 55, 18, 19, 14, 19, 19, 12, 20, 55, 2, 3, 2, 3, 2, 2, 1, 5, 4); // 0xE2A
            private static Player Goodie_Touchouse = new Player(123, 92, 50, 59, 52, 60, 53, 39, 51, 364, 78, 67, 18, 24, 19, 24, 18, 19, 20, 67, 4, 5, 5, 5, 5, 2, 3, 3, 3); // 0xE2B
            private static Player Ray_Pier = new Player(104, 111, 88, 62, 36, 57, 47, 57, 53, 400, 66, 70, 22, 18, 18, 18, 19, 20, 18, 70, 1, 3, 3, 5, 5, 2, 2, 3, 1); // 0xE2C
            private static Player Jen_Erris = new Player(101, 101, 57, 53, 56, 67, 46, 41, 80, 400, 68, 67, 20, 18, 18, 22, 21, 19, 18, 67, 3, 5, 3, 3, 5, 3, 1, 2, 2); // 0xE2D
            private static Player Jude_Ellery = new Player(106, 112, 51, 82, 53, 51, 53, 56, 54, 400, 70, 73, 21, 20, 18, 19, 19, 20, 18, 73, 2, 1, 2, 5, 2, 1, 1, 1, 3); // 0xE2E
            private static Player Seamus_Rock = new Player(101, 97, 48, 45, 54, 84, 56, 56, 57, 400, 70, 68, 21, 22, 19, 19, 20, 18, 18, 68, 2, 4, 2, 1, 3, 4, 4, 5, 4); // 0xE2F
            private static Player Tim_Roubadour = new Player(99, 128, 60, 46, 60, 48, 63, 51, 41, 369, 57, 55, 18, 13, 18, 12, 12, 12, 13, 55, 4, 4, 3, 1, 1, 3, 5, 3, 2); // 0xE30
            private static Player Matt_Skerade = new Player(123, 104, 42, 66, 59, 60, 60, 60, 58, 405, 57, 58, 13, 22, 12, 21, 12, 12, 13, 58, 1, 3, 2, 1, 4, 2, 5, 1, 1); // 0xE31
            private static Player Florence_Tripps = new Player(118, 113, 47, 57, 54, 55, 57, 44, 55, 369, 60, 74, 19, 12, 12, 13, 14, 12, 12, 74, 2, 5, 4, 5, 5, 5, 1, 3, 1); // 0xE32
            private static Player Inke_Marks = new Player(119, 120, 60, 61, 62, 59, 62, 59, 60, 423, 58, 57, 21, 13, 14, 23, 12, 12, 14, 57, 5, 4, 5, 2, 5, 1, 3, 1, 1); // 0xE33
            private static Player Gary_Baldi = new Player(138, 85, 65, 47, 45, 45, 44, 65, 66, 377, 67, 69, 14, 18, 19, 18, 19, 12, 12, 69, 1, 4, 5, 1, 1, 4, 1, 3, 4); // 0xE34
            private static Player Bobby_Peeler = new Player(133, 89, 41, 56, 56, 55, 57, 39, 52, 356, 66, 66, 18, 16, 15, 15, 15, 18, 18, 66, 2, 4, 2, 1, 5, 2, 3, 1, 4); // 0xE35
            private static Player Mark_Brand = new Player(133, 93, 48, 49, 51, 50, 59, 44, 57, 358, 57, 55, 14, 13, 14, 12, 12, 14, 14, 55, 5, 4, 1, 3, 5, 3, 5, 3, 1); // 0xE36
            private static Player Hedwig_Hodge = new Player(100, 93, 51, 51, 53, 55, 65, 47, 48, 370, 59, 59, 14, 14, 14, 12, 13, 12, 12, 59, 4, 3, 4, 4, 1, 2, 5, 4, 4); // 0xE37
            private static Player Bill_Mallard = new Player(119, 90, 50, 49, 52, 53, 60, 47, 51, 362, 57, 57, 13, 14, 14, 13, 14, 12, 12, 57, 2, 4, 3, 5, 5, 5, 4, 4, 1); // 0xE38
            private static Player Roo_Hopper = new Player(81, 122, 51, 50, 50, 53, 59, 45, 50, 358, 57, 58, 14, 14, 12, 14, 13, 12, 12, 58, 4, 3, 4, 5, 5, 4, 5, 5, 1); // 0xE39
            private static Player Cole_Bear = new Player(120, 92, 49, 51, 51, 54, 62, 46, 53, 366, 60, 58, 12, 13, 14, 12, 12, 13, 13, 58, 1, 3, 5, 1, 4, 4, 4, 2, 2); // 0xE3A
            private static Player Al_Opino = new Player(116, 98, 54, 54, 53, 56, 57, 56, 53, 383, 59, 58, 12, 21, 20, 18, 18, 19, 21, 58, 3, 3, 3, 3, 1, 5, 5, 2, 4); // 0xE3B
            private static Player Oz_Tier = new Player(121, 90, 47, 60, 44, 58, 54, 50, 56, 369, 67, 68, 19, 25, 19, 24, 18, 18, 18, 68, 1, 2, 5, 1, 4, 2, 5, 1, 2); // 0xE3C
            private static Player Shelley_Wordsworth = new Player(134, 109, 63, 46, 44, 46, 44, 48, 48, 339, 70, 78, 25, 16, 17, 17, 15, 16, 15, 78, 1, 1, 5, 1, 4, 5, 3, 3, 2); // 0xE3D
            private static Player Stu_Potter = new Player(92, 134, 57, 56, 45, 53, 44, 51, 50, 356, 57, 57, 14, 12, 12, 14, 12, 14, 14, 57, 2, 2, 5, 5, 1, 5, 4, 4, 3); // 0xE3E
            private static Player Bern_Ballast = new Player(93, 123, 50, 49, 61, 58, 59, 53, 50, 380, 58, 58, 13, 14, 13, 12, 12, 13, 13, 58, 1, 2, 1, 3, 1, 5, 2, 1, 2); // 0xE3F
            private static Player Heidi_Rood = new Player(83, 134, 45, 48, 62, 44, 59, 45, 44, 347, 56, 56, 14, 14, 13, 13, 14, 12, 12, 56, 5, 2, 2, 5, 1, 5, 1, 5, 3); // 0xE40
            private static Player Elvis_Schumacher = new Player(120, 120, 45, 62, 45, 48, 48, 46, 62, 356, 57, 57, 14, 12, 12, 12, 12, 14, 13, 57, 5, 5, 3, 5, 3, 3, 3, 1, 4); // 0xE41
            private static Player Snezhana_White = new Player(80, 137, 45, 47, 44, 45, 44, 45, 47, 317, 56, 57, 13, 14, 13, 12, 13, 12, 14, 57, 1, 4, 1, 4, 1, 3, 5, 2, 3); // 0xE42
            private static Player Abel_Forager = new Player(124, 86, 45, 44, 45, 56, 47, 49, 47, 333, 57, 59, 14, 14, 12, 13, 12, 13, 12, 59, 1, 5, 2, 5, 3, 4, 4, 5, 2); // 0xE43
            private static Player Will_Wary = new Player(125, 95, 53, 53, 52, 56, 48, 58, 51, 371, 74, 69, 19, 18, 13, 20, 14, 23, 14, 69, 1, 3, 4, 1, 1, 5, 4, 2, 1); // 0xE44
            private static Player Rocco_Shale = new Player(99, 127, 48, 60, 51, 59, 51, 50, 47, 366, 58, 59, 14, 21, 14, 22, 12, 12, 12, 59, 2, 2, 1, 1, 2, 2, 5, 1, 2); // 0xE45
            private static Player Bob_Jobbe = new Player(125, 93, 48, 57, 51, 57, 52, 59, 46, 370, 72, 58, 12, 14, 12, 12, 12, 21, 12, 58, 5, 2, 1, 5, 2, 5, 1, 1, 2); // 0xE46
            private static Player Lee_Bei = new Player(94, 118, 65, 53, 57, 63, 54, 39, 53, 384, 58, 59, 12, 12, 12, 21, 19, 14, 14, 59, 3, 3, 1, 5, 2, 5, 1, 1, 1); // 0xE47
            private static Player Quincy_Wang = new Player(99, 127, 62, 58, 60, 60, 47, 48, 59, 394, 60, 56, 13, 22, 12, 12, 12, 18, 12, 56, 2, 5, 5, 4, 1, 1, 3, 2, 2); // 0xE48
            private static Player Dan_Fei = new Player(120, 86, 60, 63, 44, 63, 44, 44, 46, 364, 57, 55, 17, 14, 12, 12, 20, 18, 18, 55, 1, 4, 3, 2, 5, 5, 3, 3, 1); // 0xE49
            private static Player Liddy_Gan = new Player(102, 125, 58, 45, 53, 59, 47, 44, 44, 350, 59, 73, 17, 12, 12, 15, 12, 12, 12, 73, 2, 4, 4, 4, 5, 2, 3, 1, 2); // 0xE4A
            private static Player Tom_Bulldown = new Player(94, 114, 53, 54, 54, 55, 54, 43, 53, 366, 56, 56, 12, 12, 12, 14, 14, 14, 13, 56, 5, 2, 5, 3, 2, 1, 2, 1, 4); // 0xE4B
            private static Player Ria_Vivalist = new Player(128, 132, 48, 51, 48, 51, 56, 39, 48, 341, 68, 67, 16, 16, 17, 15, 22, 18, 16, 67, 2, 2, 5, 1, 3, 1, 3, 4, 3); // 0xE4C
            private static Player Sunniffa_Scentgood = new Player(78, 138, 57, 48, 51, 48, 48, 41, 53, 346, 60, 64, 21, 15, 16, 15, 16, 20, 15, 64, 2, 1, 5, 2, 3, 2, 1, 4, 2); // 0xE4D
            private static Player Julia_Mason = new Player(77, 142, 50, 48, 51, 54, 51, 41, 67, 362, 60, 61, 16, 16, 16, 22, 15, 20, 15, 61, 3, 5, 3, 5, 4, 4, 1, 2, 2); // 0xE4E
            private static Player Ria_Carnival = new Player(108, 115, 57, 54, 56, 53, 66, 57, 57, 400, 70, 57, 19, 18, 20, 18, 14, 18, 19, 57, 4, 5, 5, 3, 2, 1, 4, 1, 2); // 0xE4F
            private static Player Gracey_Grapples = new Player(106, 114, 56, 55, 56, 66, 61, 57, 54, 405, 70, 58, 19, 19, 19, 12, 13, 20, 18, 58, 2, 2, 5, 3, 1, 3, 2, 2, 2); // 0xE50
            private static Player Shep_Woolacombe = new Player(119, 118, 45, 46, 44, 46, 59, 47, 48, 335, 57, 55, 14, 13, 13, 13, 12, 14, 12, 55, 2, 4, 3, 1, 1, 3, 4, 5, 2); // 0xE51
            private static Player Sue_Accharin = new Player(75, 133, 40, 39, 41, 67, 62, 39, 46, 334, 60, 73, 21, 21, 23, 21, 21, 22, 21, 73, 4, 5, 2, 2, 5, 4, 3, 4, 1); // 0xE52
            private static Player Venus_Demila = new Player(103, 120, 53, 55, 56, 57, 54, 57, 56, 388, 69, 68, 19, 19, 20, 19, 19, 19, 20, 68, 5, 3, 4, 4, 2, 3, 2, 5, 3); // 0xE53
            private static Player Steven_Nevets = new Player(122, 110, 56, 57, 61, 60, 58, 45, 54, 391, 70, 67, 19, 20, 18, 18, 18, 18, 19, 67, 2, 1, 5, 5, 1, 2, 2, 3, 2); // 0xE54
            private static Player Gerald_Gerund = new Player(119, 111, 53, 48, 51, 55, 53, 42, 49, 351, 70, 60, 16, 17, 15, 21, 16, 18, 17, 60, 5, 4, 3, 2, 3, 1, 2, 5, 4); // 0xE55
            private static Player Tracy_Tracker = new Player(106, 129, 56, 53, 53, 57, 53, 54, 54, 380, 59, 58, 14, 14, 14, 14, 12, 12, 12, 58, 5, 3, 5, 2, 5, 5, 3, 1, 3); // 0xE56
            private static Player Bernadette_Stoker = new Player(114, 129, 81, 62, 42, 39, 65, 65, 46, 400, 66, 65, 15, 19, 15, 15, 17, 20, 17, 65, 4, 3, 3, 3, 5, 3, 1, 4, 2); // 0xE57
            private static Player Keshia_Readingplace = new Player(87, 133, 52, 50, 57, 50, 56, 46, 53, 364, 64, 61, 17, 15, 15, 17, 17, 15, 16, 61, 2, 2, 5, 3, 4, 4, 4, 5, 3); // 0xE58
            private static Player Sahara_Kalahari = new Player(109, 122, 55, 56, 57, 54, 53, 41, 54, 370, 57, 58, 12, 13, 14, 14, 12, 14, 13, 58, 5, 2, 1, 3, 5, 3, 1, 3, 4); // 0xE59
            private static Player Fala_Polaris = new Player(127, 99, 42, 41, 53, 56, 53, 63, 54, 362, 70, 66, 18, 19, 22, 22, 21, 19, 22, 66, 3, 5, 2, 3, 3, 4, 1, 1, 2); // 0xE5A
            private static Player Ian_Flappable = new Player(100, 138, 58, 62, 66, 62, 61, 41, 51, 401, 65, 68, 19, 19, 20, 18, 16, 15, 16, 68, 5, 1, 5, 3, 2, 1, 3, 1, 4); // 0xE5B
            private static Player Penny_Linguine = new Player(103, 124, 55, 53, 54, 60, 53, 53, 42, 370, 59, 56, 14, 13, 13, 12, 12, 12, 13, 56, 4, 2, 1, 2, 2, 5, 5, 1, 3); // 0xE5C
            private static Player Poppy_Playhard = new Player(106, 113, 51, 39, 66, 75, 56, 56, 51, 394, 70, 78, 16, 16, 20, 45, 12, 12, 13, 78, 2, 1, 1, 5, 5, 5, 2, 1, 2); // 0xE5D
            private static Player Connie_Fuchsia = new Player(83, 133, 62, 62, 60, 59, 44, 46, 60, 393, 59, 55, 22, 17, 17, 15, 12, 12, 16, 55, 5, 3, 1, 2, 2, 1, 5, 3, 1); // 0xE5E
            private static Player Baron_Blackgold = new Player(135, 96, 53, 57, 54, 56, 53, 51, 53, 377, 60, 68, 16, 15, 20, 16, 15, 15, 17, 68, 4, 4, 5, 5, 4, 2, 4, 1, 1); // 0xE5F
            private static Player Marty_Oshker = new Player(114, 117, 55, 53, 53, 53, 51, 59, 50, 374, 64, 64, 16, 15, 15, 15, 16, 16, 17, 64, 3, 2, 4, 3, 3, 5, 1, 1, 4); // 0xE60
            private static Player Nat_Meg = new Player(92, 124, 58, 51, 53, 51, 60, 49, 51, 373, 69, 73, 15, 15, 18, 15, 18, 20, 20, 73, 4, 5, 2, 5, 3, 5, 5, 3, 4); // 0xE61
            private static Player Eddy_Steady = new Player(130, 98, 80, 81, 43, 53, 56, 66, 66, 445, 70, 61, 20, 19, 17, 16, 15, 20, 18, 61, 4, 1, 5, 3, 4, 1, 4, 1, 1); // 0xE62
            private static Player Severin_Volei = new Player(103, 114, 63, 77, 53, 45, 54, 57, 50, 399, 58, 55, 12, 20, 18, 20, 18, 19, 12, 55, 3, 2, 4, 5, 1, 5, 1, 2, 4); // 0xE63
            private static Player Brava_Hardy = new Player(106, 96, 73, 53, 53, 42, 56, 54, 63, 394, 67, 67, 38, 20, 18, 19, 19, 19, 19, 67, 4, 5, 5, 4, 5, 5, 3, 3, 3); // 0xE64
            private static Player Helmut_Hoarder = new Player(118, 95, 67, 45, 44, 44, 56, 56, 62, 374, 69, 68, 14, 19, 18, 20, 13, 18, 13, 68, 5, 1, 3, 5, 4, 4, 2, 5, 2); // 0xE65
            private static Player Strama_daKoto = new Player(94, 129, 58, 52, 48, 50, 50, 52, 54, 364, 62, 76, 24, 25, 24, 24, 24, 24, 24, 76, 4, 3, 3, 3, 1, 1, 5, 4, 2); // 0xE66
            private static Player Olaf_Nobeard = new Player(116, 98, 53, 56, 56, 57, 48, 53, 55, 378, 68, 69, 19, 18, 18, 19, 19, 20, 20, 69, 1, 5, 1, 3, 5, 4, 4, 3, 4); // 0xE67
            private static Player Gudrun_Lodestone = new Player(82, 132, 53, 53, 57, 56, 48, 51, 49, 367, 68, 69, 18, 19, 20, 20, 18, 23, 23, 69, 1, 3, 3, 2, 5, 1, 1, 3, 2); // 0xE68
            private static Player Carol_Fairfoot = new Player(107, 122, 59, 60, 55, 56, 57, 46, 49, 382, 70, 70, 18, 20, 12, 13, 12, 13, 12, 70, 3, 1, 1, 2, 3, 3, 5, 2, 3); // 0xE69
            private static Player Michael_Shako = new Player(90, 138, 44, 45, 45, 63, 48, 44, 44, 333, 60, 77, 13, 14, 12, 24, 12, 14, 14, 77, 1, 3, 1, 2, 2, 5, 1, 2, 1); // 0xE6A
            private static Player Direm_Ederi = new Player(115, 103, 56, 53, 57, 53, 57, 56, 55, 387, 70, 58, 19, 20, 18, 18, 18, 20, 20, 58, 3, 2, 5, 2, 1, 3, 3, 2, 2); // 0xE6B
            private static Player Marina_Coaster = new Player(81, 130, 58, 60, 44, 47, 56, 44, 45, 354, 60, 70, 21, 21, 13, 13, 21, 12, 12, 70, 4, 5, 4, 5, 1, 3, 5, 5, 3); // 0xE6C
            private static Player Wowzer_Bigtop = new Player(121, 93, 51, 66, 49, 66, 52, 53, 66, 403, 57, 59, 12, 24, 13, 24, 13, 17, 12, 59, 2, 2, 1, 4, 5, 5, 4, 3, 3); // 0xE6D
            private static Player Derry_Farmer = new Player(118, 97, 51, 48, 52, 50, 67, 52, 49, 369, 59, 55, 14, 12, 12, 12, 24, 13, 14, 55, 4, 1, 2, 5, 4, 1, 1, 3, 4); // 0xE6E
            private static Player Devlin_Ogor = new Player(145, 73, 76, 82, 45, 57, 55, 39, 56, 410, 56, 58, 21, 22, 21, 21, 21, 14, 21, 58, 1, 2, 1, 5, 2, 5, 4, 4, 3); // 0xE6F
            private static Player Fez_Monkton = new Player(119, 105, 53, 57, 53, 53, 57, 41, 57, 371, 60, 58, 22, 22, 22, 23, 22, 14, 21, 58, 1, 5, 1, 2, 5, 5, 1, 5, 2); // 0xE70
            private static Player Berthel_Stagg = new Player(93, 124, 48, 49, 51, 54, 67, 50, 51, 370, 63, 60, 17, 15, 15, 16, 16, 17, 17, 60, 4, 3, 3, 5, 3, 1, 5, 5, 3); // 0xE71
            private static Player Damon_Sumner = new Player(81, 144, 65, 52, 54, 51, 43, 54, 67, 386, 58, 100, 18, 12, 14, 12, 19, 20, 18, 100, 4, 1, 2, 4, 1, 3, 5, 2, 4); // 0xE72
            private static Player Anders_Thettock = new Player(133, 90, 57, 57, 50, 51, 48, 51, 50, 364, 60, 59, 22, 22, 14, 14, 12, 12, 13, 59, 3, 1, 1, 5, 5, 5, 1, 1, 3); // 0xE73
            private static Player Laititia_Cheeseman = new Player(99, 94, 57, 53, 52, 56, 48, 51, 50, 367, 58, 56, 23, 23, 13, 21, 12, 13, 13, 56, 1, 5, 4, 4, 4, 3, 4, 5, 1); // 0xE74
            private static Player Isodoura_Bouquet = new Player(93, 129, 48, 52, 48, 51, 53, 50, 51, 353, 59, 71, 13, 12, 14, 12, 14, 13, 12, 71, 5, 1, 5, 1, 1, 1, 2, 1, 1); // 0xE75
            private static Player May_Jarrett = new Player(102, 126, 49, 56, 57, 56, 55, 55, 56, 384, 64, 57, 20, 18, 20, 18, 18, 18, 20, 57, 5, 5, 3, 2, 5, 3, 5, 3, 2); // 0xE76
            private static Player Des_Einer = new Player(103, 120, 63, 53, 54, 57, 57, 49, 54, 387, 65, 56, 12, 16, 16, 15, 16, 16, 21, 56, 5, 2, 2, 5, 2, 1, 5, 3, 2); // 0xE77
            private static Player Kev_Fiyah = new Player(123, 93, 51, 56, 53, 54, 51, 67, 52, 384, 77, 64, 14, 13, 17, 13, 15, 25, 15, 64, 4, 4, 1, 2, 2, 5, 2, 2, 4); // 0xE78
            private static Player Shadi_Mesmer = new Player(129, 92, 53, 51, 51, 60, 51, 65, 51, 382, 80, 61, 13, 15, 17, 14, 17, 26, 16, 61, 4, 4, 2, 2, 4, 5, 5, 5, 1); // 0xE79
            private static Player Preston_Digitator = new Player(130, 103, 51, 49, 50, 51, 50, 63, 49, 363, 78, 56, 17, 15, 16, 15, 16, 24, 15, 56, 5, 4, 4, 3, 3, 4, 4, 5, 1); // 0xE7A
            private static Player Roman_Fawkes = new Player(129, 93, 53, 52, 51, 59, 48, 64, 51, 378, 77, 61, 16, 16, 16, 12, 16, 24, 16, 61, 4, 3, 2, 4, 2, 2, 5, 2, 4); // 0xE7B
            private static Player Morty_Portland = new Player(118, 93, 49, 63, 51, 51, 51, 51, 49, 365, 60, 56, 14, 24, 12, 13, 13, 14, 14, 56, 2, 2, 2, 5, 5, 4, 1, 5, 2); // 0xE7C
            private static Player Fabrice_Pesci = new Player(121, 94, 48, 53, 60, 51, 59, 63, 50, 384, 76, 63, 16, 16, 14, 17, 13, 24, 17, 63, 4, 1, 3, 3, 5, 3, 1, 3, 1); // 0xE7D
            private static Player Boo_Spector = new Player(121, 88, 53, 48, 51, 62, 58, 65, 51, 388, 76, 64, 15, 16, 16, 14, 14, 25, 15, 64, 5, 1, 4, 3, 3, 2, 2, 5, 1); // 0xE7E
            private static Player Cole_Tivator = new Player(129, 93, 51, 51, 48, 53, 55, 64, 51, 373, 79, 55, 14, 12, 14, 13, 16, 25, 12, 55, 1, 5, 5, 1, 3, 1, 5, 1, 4); // 0xE7F
            private static Player Blagun_White = new Player(129, 93, 56, 48, 50, 48, 51, 64, 51, 368, 77, 58, 17, 12, 12, 14, 12, 24, 13, 58, 4, 1, 1, 2, 2, 5, 2, 3, 2); // 0xE80
            private static Player Jeanie_Tanner = new Player(75, 136, 42, 39, 41, 42, 39, 42, 39, 284, 60, 74, 21, 22, 21, 22, 22, 23, 23, 74, 1, 1, 2, 2, 4, 5, 4, 1, 2); // 0xE81
            private static Player Monty_Tasker = new Player(121, 90, 51, 48, 51, 54, 49, 65, 48, 366, 77, 59, 12, 12, 12, 16, 12, 26, 12, 59, 3, 3, 5, 3, 2, 4, 5, 5, 2); // 0xE82
            private static Player Artie_Xan = new Player(121, 87, 48, 51, 54, 50, 51, 67, 50, 371, 79, 56, 13, 12, 16, 12, 13, 25, 13, 56, 5, 4, 2, 3, 5, 4, 1, 1, 2); // 0xE83
            private static Player Genghis_Cohen = new Player(122, 98, 56, 56, 57, 53, 66, 57, 64, 409, 62, 62, 17, 16, 15, 15, 13, 16, 12, 62, 4, 2, 1, 2, 5, 4, 2, 3, 1); // 0xE84
            private static Player Adam_Venturus = new Player(121, 109, 51, 48, 51, 52, 49, 63, 60, 374, 79, 57, 15, 17, 15, 15, 17, 25, 13, 57, 3, 4, 2, 1, 1, 1, 5, 1, 2); // 0xE85
            private static Player Zahida_Zahid = new Player(124, 129, 56, 55, 54, 56, 60, 53, 54, 388, 60, 56, 18, 19, 20, 19, 23, 20, 20, 56, 4, 3, 2, 4, 5, 3, 4, 1, 2); // 0xE86
            private static Player Zowie_Trope = new Player(130, 92, 50, 53, 50, 51, 51, 65, 53, 373, 80, 64, 15, 16, 16, 16, 17, 26, 12, 64, 1, 4, 3, 2, 4, 3, 1, 5, 4); // 0xE87
            private static Player Roland_Lex = new Player(100, 110, 60, 61, 57, 48, 54, 44, 54, 378, 67, 65, 22, 18, 19, 13, 20, 13, 19, 65, 1, 5, 4, 4, 1, 3, 3, 1, 1); // 0xE88
            private static Player Holly_Marx = new Player(94, 131, 60, 51, 48, 51, 51, 51, 52, 364, 66, 69, 14, 18, 19, 19, 18, 20, 18, 69, 1, 1, 4, 2, 4, 1, 5, 1, 4); // 0xE89
            private static Player Springer_Boreham = new Player(120, 93, 52, 53, 50, 56, 58, 45, 50, 364, 64, 63, 17, 16, 17, 19, 19, 15, 16, 63, 5, 5, 5, 5, 3, 4, 2, 5, 3); // 0xE8A
            private static Player Kandhul_Lai = new Player(106, 118, 59, 49, 51, 52, 51, 49, 48, 359, 61, 66, 18, 17, 16, 15, 15, 15, 17, 66, 4, 4, 2, 5, 3, 1, 2, 1, 1); // 0xE8B
            private static Player Kit_Fischer = new Player(126, 103, 60, 60, 60, 61, 67, 60, 60, 428, 58, 56, 12, 12, 12, 12, 15, 14, 14, 56, 1, 2, 3, 1, 5, 4, 5, 4, 2); // 0xE8C
            private static Player Becks_Binder = new Player(119, 121, 60, 60, 58, 60, 60, 62, 60, 420, 59, 62, 13, 14, 14, 13, 14, 12, 13, 62, 3, 2, 2, 5, 4, 1, 3, 2, 2); // 0xE8D
            private static Player Ralph_Chasing = new Player(89, 130, 58, 60, 58, 62, 58, 60, 60, 416, 58, 59, 14, 12, 12, 12, 14, 12, 13, 59, 3, 4, 3, 2, 5, 5, 5, 4, 1); // 0xE8E
            private static Player Phil_Debonair = new Player(135, 94, 50, 56, 48, 54, 63, 53, 50, 374, 64, 60, 15, 17, 15, 16, 18, 17, 15, 60, 1, 2, 2, 4, 1, 5, 1, 2, 4); // 0xE8F
            private static Player Si_Sosman = new Player(135, 90, 48, 48, 48, 84, 48, 53, 66, 395, 70, 56, 18, 12, 18, 34, 20, 18, 13, 56, 1, 5, 3, 3, 3, 5, 2, 4, 2); // 0xE90
            private static Player Aaron_Gossamer = new Player(125, 105, 61, 62, 58, 62, 59, 58, 60, 420, 67, 61, 12, 13, 19, 13, 23, 23, 23, 61, 3, 5, 2, 1, 5, 5, 2, 4, 4); // 0xE91
            private static Player Pomponius_Fanfair = new Player(115, 101, 55, 60, 57, 53, 59, 54, 53, 391, 59, 59, 20, 20, 19, 20, 18, 18, 20, 59, 4, 4, 4, 5, 3, 2, 1, 2, 1); // 0xE92
            private static Player Fanella_Waftgood = new Player(140, 144, 41, 65, 39, 62, 32, 39, 66, 344, 80, 87, 13, 13, 14, 32, 12, 13, 20, 87, 1, 5, 2, 1, 1, 3, 4, 3, 3); // 0xE93
            private static Player Irina_Swift = new Player(102, 127, 57, 53, 53, 57, 55, 42, 56, 373, 71, 73, 22, 22, 21, 22, 23, 21, 21, 73, 1, 4, 4, 5, 5, 3, 4, 1, 1); // 0xE94
            private static Player Rick_Shaw = new Player(135, 97, 55, 56, 55, 54, 56, 39, 55, 370, 59, 63, 16, 16, 15, 15, 24, 19, 19, 63, 3, 3, 5, 2, 3, 3, 1, 3, 1); // 0xE95
            private static Player Montaine_Skalin = new Player(125, 99, 65, 60, 57, 42, 61, 55, 62, 402, 68, 56, 16, 17, 16, 13, 17, 17, 16, 56, 2, 5, 5, 5, 5, 3, 2, 4, 2); // 0xE96
            private static Player Meowlinda_Purrsival = new Player(78, 153, 48, 48, 48, 60, 42, 39, 50, 335, 57, 108, 13, 14, 12, 13, 14, 14, 12, 108, 2, 4, 5, 5, 1, 2, 2, 2, 1); // 0xE97
            private static Player Rune_Sigilsson = new Player(88, 138, 64, 58, 56, 57, 44, 47, 54, 380, 57, 103, 14, 12, 12, 12, 14, 12, 12, 103, 2, 5, 1, 2, 5, 1, 2, 4, 4); // 0xE98
            private static Player Onslow_Mastick = new Player(122, 97, 56, 54, 44, 54, 45, 44, 45, 342, 60, 76, 26, 24, 14, 24, 12, 12, 14, 76, 2, 1, 1, 3, 3, 2, 5, 4, 1); // 0xE99
            private static Player Blowie_Armstraw = new Player(124, 96, 47, 46, 54, 57, 55, 44, 56, 359, 57, 58, 12, 12, 24, 26, 24, 13, 26, 58, 2, 1, 3, 1, 1, 2, 2, 5, 3); // 0xE9A
            private static Player Paddy_Filler = new Player(119, 99, 46, 46, 44, 44, 57, 47, 54, 338, 77, 76, 14, 12, 13, 14, 26, 12, 26, 76, 2, 4, 5, 4, 3, 5, 4, 4, 1); // 0xE9B
            private static Player Avid_Peddler = new Player(135, 109, 54, 51, 51, 53, 62, 52, 49, 372, 58, 69, 25, 12, 14, 13, 12, 12, 13, 69, 5, 5, 4, 2, 3, 2, 2, 4, 3); // 0xE9C
            private static Player Woody_Prince = new Player(107, 118, 47, 56, 49, 59, 48, 52, 48, 359, 57, 55, 14, 14, 12, 12, 13, 13, 14, 55, 3, 5, 4, 1, 5, 4, 4, 2, 3); // 0xE9D
            private static Player Demerara_Kane = new Player(122, 103, 63, 63, 56, 67, 55, 42, 42, 388, 60, 58, 23, 21, 18, 22, 19, 12, 14, 58, 3, 1, 5, 5, 1, 2, 2, 1, 1); // 0xE9E
            private static Player Tiny_Jetson = new Player(126, 91, 63, 63, 56, 54, 53, 43, 54, 386, 56, 55, 23, 18, 20, 20, 19, 13, 12, 55, 3, 2, 5, 3, 1, 4, 1, 4, 4); // 0xE9F
            private static Player Joe_Java = new Player(122, 94, 56, 64, 54, 63, 56, 51, 56, 400, 66, 71, 19, 14, 19, 13, 20, 20, 18, 71, 1, 3, 2, 3, 5, 5, 2, 2, 1); // 0xEA0
            private static Player Wulf_Blackbean = new Player(94, 124, 60, 58, 59, 62, 60, 43, 48, 390, 57, 67, 18, 20, 20, 20, 19, 13, 19, 67, 1, 3, 4, 2, 3, 2, 1, 5, 3); // 0xEA1
            private static Player Neville_Boyle = new Player(122, 100, 62, 59, 56, 53, 54, 53, 55, 392, 57, 58, 23, 18, 14, 13, 14, 13, 12, 58, 5, 2, 4, 3, 2, 5, 4, 4, 3); // 0xEA2
            private static Player Ameen_Abel = new Player(127, 93, 51, 50, 48, 53, 50, 60, 48, 360, 69, 67, 22, 22, 23, 21, 20, 19, 20, 67, 3, 1, 5, 4, 5, 5, 2, 2, 2); // 0xEA3
            private static Player Bombasta_Flamboyanzi = new Player(101, 120, 56, 56, 57, 54, 66, 57, 56, 402, 70, 59, 19, 18, 20, 19, 12, 12, 12, 59, 5, 1, 5, 2, 4, 5, 2, 4, 1); // 0xEA4
            private static Player Fada_Prendi = new Player(98, 118, 49, 51, 48, 51, 53, 52, 63, 367, 66, 67, 18, 20, 19, 18, 18, 19, 20, 67, 3, 2, 2, 2, 2, 2, 3, 5, 1); // 0xEA5
            private static Player Bella_Baker = new Player(98, 119, 66, 51, 50, 52, 51, 48, 50, 368, 59, 59, 14, 18, 19, 18, 19, 19, 19, 59, 1, 5, 1, 5, 4, 4, 1, 4, 1); // 0xEA6
            private static Player Olivia_Palme = new Player(106, 123, 57, 65, 57, 57, 54, 54, 57, 401, 70, 59, 12, 13, 19, 13, 20, 12, 12, 59, 5, 4, 2, 3, 1, 5, 3, 5, 2); // 0xEA7
            private static Player Gustav_Weathervane = new Player(92, 132, 56, 54, 60, 65, 80, 40, 57, 412, 59, 70, 20, 18, 23, 18, 23, 20, 19, 70, 4, 5, 1, 1, 2, 1, 3, 1, 2); // 0xEA8
            private static Player Grover_Noggin = new Player(102, 122, 49, 71, 53, 51, 65, 57, 54, 400, 68, 73, 13, 18, 20, 13, 18, 20, 18, 73, 3, 1, 5, 4, 2, 4, 3, 3, 4); // 0xEA9
            private static Player Blazer_Firefoot = new Player(110, 118, 63, 57, 56, 78, 57, 39, 65, 415, 60, 68, 22, 18, 18, 21, 18, 18, 21, 68, 4, 5, 3, 1, 3, 4, 5, 3, 2); // 0xEAA
            private static Player Adam_Montayne = new Player(125, 104, 65, 80, 39, 40, 66, 42, 56, 388, 57, 67, 23, 23, 13, 12, 21, 13, 19, 67, 3, 5, 4, 4, 2, 3, 5, 2, 4); // 0xEAB
            private static Player Chauncey_Slinka = new Player(88, 140, 58, 63, 58, 58, 58, 60, 60, 415, 49, 74, 18, 20, 18, 18, 20, 20, 20, 74, 1, 4, 5, 5, 3, 3, 1, 3, 3); // 0xEAC
            private static Player Leighton_Bolt = new Player(110, 129, 60, 59, 60, 65, 59, 60, 58, 421, 68, 69, 21, 18, 18, 20, 20, 18, 20, 69, 4, 2, 1, 1, 3, 3, 5, 1, 3); // 0xEAD
            private static Player Lucien_Thrope = new Player(126, 102, 48, 51, 40, 57, 63, 60, 51, 370, 65, 61, 16, 17, 17, 17, 16, 15, 15, 61, 2, 5, 3, 3, 1, 3, 4, 1, 4); // 0xEAE
            private static Player Lenton_Gouger = new Player(103, 142, 52, 49, 51, 53, 52, 51, 53, 361, 60, 58, 13, 14, 12, 13, 12, 14, 13, 58, 3, 3, 1, 5, 2, 1, 2, 1, 1); // 0xEAF
            private static Player Titania_Khamun = new Player(128, 93, 48, 54, 50, 50, 40, 67, 39, 348, 58, 57, 14, 14, 13, 12, 13, 14, 12, 57, 4, 1, 2, 3, 3, 5, 4, 2, 3); // 0xEB0
            private static Player Eveline_Veitch = new Player(92, 122, 50, 51, 52, 51, 48, 51, 63, 366, 66, 55, 18, 19, 18, 20, 18, 20, 12, 55, 4, 4, 4, 2, 4, 3, 5, 1, 4); // 0xEB1
            private static Player Eldritch_Priest = new Player(84, 140, 61, 61, 58, 59, 41, 61, 58, 399, 57, 105, 18, 19, 15, 19, 17, 12, 16, 105, 4, 2, 4, 5, 5, 3, 5, 5, 3); // 0xEB2
            private static Player Gene_Bulge = new Player(122, 93, 63, 48, 50, 48, 50, 52, 45, 356, 68, 66, 20, 19, 20, 20, 19, 20, 20, 66, 3, 2, 3, 5, 1, 1, 2, 3, 1); // 0xEB3
            private static Player Candy_Reviva = new Player(92, 129, 53, 55, 53, 57, 55, 48, 51, 372, 66, 66, 18, 18, 20, 18, 19, 20, 20, 66, 2, 1, 4, 5, 4, 3, 3, 1, 3); // 0xEB4
            private static Player Pacey_Mack = new Player(88, 127, 50, 48, 50, 48, 46, 46, 56, 344, 65, 64, 15, 17, 15, 16, 15, 15, 17, 64, 2, 1, 5, 3, 2, 3, 5, 5, 4); // 0xEB5
            private static Player Anil_Latikal = new Player(121, 101, 47, 44, 44, 44, 48, 48, 47, 322, 57, 55, 13, 13, 14, 13, 14, 13, 12, 55, 3, 3, 1, 3, 5, 3, 4, 5, 4); // 0xEB6
            private static Player Indy_Ferrante = new Player(92, 132, 51, 56, 51, 48, 50, 46, 62, 364, 56, 59, 14, 14, 14, 14, 14, 12, 14, 59, 1, 4, 3, 5, 1, 5, 5, 2, 1); // 0xEB7
            private static Player Stan_Tistischen = new Player(106, 119, 54, 52, 50, 52, 48, 45, 58, 359, 60, 57, 12, 12, 12, 14, 14, 12, 12, 57, 1, 2, 5, 5, 1, 5, 1, 5, 3); // 0xEB8
            private static Player Simon_Borg = new Player(133, 103, 49, 53, 53, 53, 51, 48, 58, 365, 56, 57, 14, 12, 13, 12, 14, 12, 13, 57, 4, 2, 1, 4, 4, 3, 4, 5, 1); // 0xEB9
            private static Player Clark_Phylen = new Player(116, 98, 57, 56, 56, 53, 56, 45, 56, 379, 73, 72, 23, 23, 23, 22, 21, 21, 21, 72, 2, 2, 2, 4, 5, 4, 5, 1, 1); // 0xEBA
            private static Player Gram_Vineela = new Player(133, 102, 54, 62, 57, 55, 55, 50, 62, 395, 68, 66, 20, 21, 18, 19, 19, 21, 22, 66, 3, 2, 3, 1, 2, 3, 5, 3, 3); // 0xEBB
            private static Player Yasser_Rightaway = new Player(93, 124, 54, 51, 57, 67, 57, 53, 49, 388, 66, 67, 18, 20, 20, 14, 19, 12, 12, 67, 3, 5, 2, 4, 2, 3, 3, 4, 4); // 0xEBC
            private static Player Adora_Shivers = new Player(84, 129, 46, 44, 52, 48, 60, 51, 51, 352, 67, 65, 18, 19, 19, 20, 13, 19, 18, 65, 5, 3, 1, 5, 5, 4, 2, 1, 4); // 0xEBD
            private static Player Roland_Allardyce = new Player(120, 99, 59, 50, 48, 49, 45, 47, 48, 346, 58, 56, 19, 15, 16, 17, 12, 12, 13, 56, 4, 1, 3, 3, 4, 4, 5, 4, 2); // 0xEBE
            private static Player Lacy_Cagney = new Player(103, 120, 53, 53, 56, 56, 55, 53, 53, 379, 71, 73, 21, 23, 21, 21, 23, 23, 21, 73, 2, 3, 1, 2, 2, 5, 4, 4, 4); // 0xEBF
            private static Player Justice_Gavel = new Player(84, 126, 49, 51, 51, 51, 51, 44, 48, 345, 59, 75, 13, 13, 12, 12, 14, 14, 14, 75, 4, 1, 5, 4, 2, 5, 3, 2, 1); // 0xEC0
            private static Player Raleigh_Greenstreet = new Player(120, 112, 64, 51, 48, 51, 64, 46, 56, 380, 57, 73, 13, 12, 14, 14, 12, 13, 19, 73, 2, 4, 2, 2, 1, 5, 2, 2, 2); // 0xEC1
            private static Player Melody_Toontune = new Player(118, 123, 49, 51, 48, 48, 50, 58, 57, 361, 79, 57, 13, 14, 13, 12, 13, 12, 14, 57, 2, 3, 5, 3, 3, 5, 5, 2, 1); // 0xEC2
            private static Player Zip_Windrush = new Player(108, 97, 39, 77, 77, 77, 62, 41, 66, 439, 63, 60, 15, 16, 19, 18, 20, 15, 15, 60, 2, 2, 1, 1, 3, 5, 2, 4, 2); // 0xEC3
            private static Player Buster_Lungs = new Player(133, 109, 62, 56, 56, 49, 57, 48, 62, 390, 68, 67, 18, 20, 19, 18, 20, 13, 19, 67, 1, 1, 1, 2, 3, 3, 3, 5, 2); // 0xEC4
            private static Player Stanza_Verse = new Player(94, 132, 53, 58, 50, 48, 50, 51, 53, 363, 70, 58, 18, 12, 19, 18, 18, 18, 20, 58, 4, 4, 5, 5, 1, 4, 3, 3, 1); // 0xEC5
            private static Player Dextra_Gleeson = new Player(98, 123, 48, 57, 50, 51, 56, 50, 51, 363, 57, 72, 13, 14, 14, 14, 12, 13, 12, 72, 4, 2, 3, 3, 2, 4, 5, 3, 4); // 0xEC6
            private static Player Aidull_Wanabi = new Player(124, 95, 60, 53, 56, 56, 57, 53, 55, 390, 66, 69, 19, 23, 22, 23, 21, 20, 22, 69, 5, 2, 1, 2, 2, 1, 5, 2, 1); // 0xEC7
            private static Player Earle_Humble = new Player(120, 97, 57, 58, 59, 62, 59, 53, 60, 408, 68, 67, 20, 13, 14, 14, 12, 12, 13, 67, 4, 3, 1, 3, 2, 5, 4, 2, 4); // 0xEC8
            private static Player Rich_Fowler = new Player(120, 97, 51, 51, 56, 48, 53, 56, 53, 368, 72, 71, 13, 13, 23, 12, 23, 21, 23, 71, 1, 2, 5, 5, 4, 2, 4, 1, 4); // 0xEC9
            private static Player Rio_Shoring = new Player(131, 98, 62, 62, 44, 62, 45, 46, 45, 366, 60, 56, 21, 23, 12, 21, 12, 14, 12, 56, 3, 3, 1, 3, 5, 4, 1, 5, 3); // 0xECA
            private static Player Joy_Seeker = new Player(100, 135, 48, 44, 53, 44, 53, 56, 55, 353, 58, 69, 13, 13, 18, 14, 20, 20, 19, 69, 2, 3, 2, 4, 4, 4, 5, 3, 2); // 0xECB
            private static Player Haydn_Woe = new Player(100, 105, 44, 60, 48, 44, 44, 47, 47, 334, 69, 68, 20, 19, 19, 20, 19, 18, 19, 68, 1, 4, 3, 5, 3, 3, 2, 4, 1); // 0xECC
            private static Player Levi_Atherton = new Player(117, 99, 62, 61, 60, 62, 61, 53, 57, 416, 69, 65, 13, 14, 14, 14, 12, 19, 20, 65, 1, 5, 2, 3, 5, 5, 2, 2, 2); // 0xECD
            private static Player Flick_Screening = new Player(82, 124, 45, 47, 45, 48, 46, 45, 47, 323, 59, 59, 13, 13, 13, 13, 12, 14, 12, 59, 3, 3, 3, 4, 1, 1, 5, 2, 3); // 0xECE
            private static Player Buff_Bagenal = new Player(93, 128, 51, 53, 65, 65, 50, 51, 51, 386, 65, 73, 15, 17, 12, 14, 16, 15, 16, 73, 3, 3, 2, 3, 4, 5, 2, 1, 1); // 0xECF
            private static Player Mariah_Knowles = new Player(90, 124, 50, 50, 50, 51, 50, 50, 48, 349, 67, 69, 18, 19, 18, 20, 18, 19, 20, 69, 4, 1, 1, 2, 3, 2, 5, 4, 1); // 0xED0
            private static Player Phil_Harmonic = new Player(124, 120, 44, 44, 45, 44, 47, 46, 45, 315, 58, 55, 12, 13, 13, 12, 12, 12, 12, 55, 3, 1, 4, 5, 3, 3, 4, 2, 4); // 0xED1
            private static Player Ghoulian_Haunter = new Player(118, 91, 52, 52, 49, 50, 65, 53, 50, 371, 69, 69, 19, 18, 20, 18, 19, 19, 18, 69, 2, 4, 1, 1, 5, 4, 1, 2, 3); // 0xED2
            private static Player Jacko_Lenton = new Player(93, 116, 48, 48, 49, 51, 49, 48, 51, 344, 70, 67, 18, 18, 18, 19, 20, 18, 18, 67, 3, 3, 1, 1, 3, 5, 3, 5, 2); // 0xED3
            private static Player Dee_Tarrant = new Player(92, 90, 60, 60, 60, 64, 41, 41, 59, 385, 71, 56, 12, 12, 13, 12, 21, 22, 14, 56, 5, 5, 4, 1, 4, 3, 3, 4, 2); // 0xED4
            private static Player Lee_Bartarian = new Player(99, 128, 58, 62, 43, 61, 48, 51, 50, 373, 68, 66, 18, 18, 18, 20, 19, 18, 20, 66, 2, 5, 1, 1, 2, 2, 2, 2, 3); // 0xED5
            private static Player Amir_Rika = new Player(126, 109, 39, 39, 60, 40, 59, 59, 61, 357, 57, 58, 21, 21, 13, 21, 12, 12, 14, 58, 1, 3, 1, 4, 3, 3, 2, 5, 4); // 0xED6
            private static Player Ewan_Envoi = new Player(124, 95, 40, 40, 54, 42, 63, 56, 54, 349, 75, 74, 20, 18, 21, 20, 21, 21, 23, 74, 2, 3, 5, 5, 4, 5, 3, 4, 2); // 0xED7
            private static Player Jen_DeRites = new Player(109, 123, 40, 39, 56, 39, 54, 56, 55, 339, 75, 70, 20, 19, 23, 19, 22, 21, 23, 70, 2, 4, 4, 2, 4, 5, 4, 1, 3); // 0xED8
            private static Player Judge_Jury = new Player(94, 132, 62, 66, 60, 59, 41, 43, 61, 392, 74, 58, 14, 12, 13, 12, 23, 21, 13, 58, 3, 5, 1, 1, 4, 1, 3, 3, 1); // 0xED9
            private static Player Leo_Maine = new Player(118, 99, 63, 65, 56, 53, 56, 56, 57, 406, 69, 65, 13, 13, 19, 18, 18, 20, 20, 65, 2, 1, 3, 3, 5, 2, 1, 5, 4); // 0xEDA
            private static Player Scorpia_Venin = new Player(106, 128, 56, 56, 56, 63, 53, 54, 54, 392, 66, 58, 18, 19, 18, 19, 19, 19, 20, 58, 4, 4, 3, 3, 4, 2, 4, 5, 3); // 0xEDB
            private static Player Noel_Taurius = new Player(124, 96, 66, 65, 57, 57, 53, 65, 56, 419, 57, 65, 14, 13, 19, 18, 20, 13, 18, 65, 3, 2, 5, 1, 4, 4, 1, 5, 1); // 0xEDC
            private static Player Pan_Kidd = new Player(123, 97, 55, 57, 56, 57, 63, 57, 65, 410, 69, 68, 18, 18, 18, 19, 12, 18, 12, 68, 5, 2, 1, 3, 4, 2, 5, 4, 3); // 0xEDD
            private static Player Cuba_Lieber = new Player(110, 110, 56, 65, 64, 57, 54, 57, 54, 407, 67, 69, 18, 13, 13, 20, 20, 20, 18, 69, 2, 3, 5, 4, 5, 1, 3, 2, 2); // 0xEDE
            private static Player Arthur_Crabbe = new Player(118, 101, 57, 65, 53, 64, 53, 57, 56, 405, 67, 68, 19, 14, 18, 14, 18, 18, 19, 68, 4, 3, 3, 2, 4, 3, 2, 5, 3); // 0xEDF
            private static Player Regina_Raffles = new Player(138, 120, 44, 77, 58, 53, 56, 68, 64, 420, 57, 78, 12, 45, 20, 18, 22, 13, 19, 78, 3, 5, 1, 2, 5, 2, 2, 4, 1); // 0xEE0
            private static Player Ian_Fountry = new Player(145, 103, 41, 88, 46, 49, 67, 71, 60, 422, 67, 67, 20, 42, 18, 19, 18, 19, 19, 67, 5, 3, 2, 5, 4, 1, 2, 4, 4); // 0xEE1
            private static Player Mark_Osman = new Player(144, 118, 42, 81, 49, 54, 65, 71, 62, 424, 67, 69, 18, 43, 18, 18, 18, 20, 18, 69, 2, 2, 3, 5, 3, 1, 2, 3, 3); // 0xEE2
            private static Player Colin_Mando = new Player(149, 98, 46, 85, 43, 65, 58, 70, 60, 427, 66, 69, 20, 44, 18, 18, 18, 20, 20, 69, 4, 1, 4, 5, 2, 2, 5, 2, 1); // 0xEE3
            private static Player Pete_Parrish = new Player(144, 102, 43, 87, 46, 56, 53, 71, 76, 432, 66, 66, 19, 47, 18, 19, 19, 18, 19, 66, 4, 4, 5, 2, 3, 2, 1, 2, 4); // 0xEE4
            private static Player Serge_Major = new Player(147, 107, 45, 81, 42, 66, 53, 71, 66, 424, 67, 69, 19, 41, 19, 18, 18, 19, 18, 69, 1, 2, 2, 3, 4, 4, 4, 5, 3); // 0xEE5
            private static Player Susan_Taylor = new Player(82, 128, 44, 47, 56, 57, 56, 47, 46, 353, 59, 55, 12, 13, 23, 21, 22, 12, 14, 55, 4, 1, 3, 4, 1, 3, 3, 5, 1); // 0xEE6
            private static Player Keenan_Guru = new Player(120, 102, 46, 45, 46, 45, 56, 47, 44, 329, 57, 57, 14, 12, 12, 12, 13, 13, 14, 57, 1, 5, 1, 1, 3, 3, 4, 3, 4); // 0xEE7
            private static Player Lovell_Ribner = new Player(131, 101, 57, 57, 45, 46, 56, 48, 46, 355, 57, 72, 22, 21, 13, 14, 14, 14, 13, 72, 4, 2, 3, 4, 4, 2, 5, 2, 3); // 0xEE8
            private static Player Curtis_Carson = new Player(88, 138, 44, 55, 54, 65, 40, 56, 57, 371, 69, 107, 19, 20, 20, 18, 20, 18, 20, 107, 3, 5, 4, 1, 4, 1, 3, 3, 3); // 0xEE9
            private static Player Falah_Hazbin = new Player(94, 120, 62, 62, 43, 39, 42, 39, 42, 329, 58, 59, 14, 13, 14, 14, 14, 13, 14, 59, 1, 3, 1, 1, 1, 2, 4, 5, 4); // 0xEEA
            private static Player Marthin_Bannister = new Player(94, 116, 40, 62, 60, 61, 42, 41, 39, 345, 58, 59, 14, 13, 12, 12, 14, 14, 13, 59, 4, 1, 5, 5, 1, 2, 2, 4, 2); // 0xEEB
            private static Player Orion_Tearing = new Player(93, 116, 48, 51, 53, 49, 65, 50, 48, 364, 72, 56, 19, 21, 21, 22, 12, 21, 23, 56, 2, 4, 5, 3, 1, 3, 1, 2, 4); // 0xEEC
            private static Player Reese_Fryer = new Player(114, 109, 49, 50, 53, 51, 54, 53, 57, 367, 75, 72, 22, 21, 21, 21, 22, 23, 21, 72, 1, 1, 5, 1, 1, 2, 1, 1, 2); // 0xEED
            private static Player Ben_Feuer = new Player(91, 127, 54, 56, 41, 54, 41, 42, 40, 328, 57, 57, 13, 12, 15, 12, 17, 16, 17, 57, 1, 2, 1, 1, 1, 5, 5, 4, 2); // 0xEEE
            private static Player Edison_Ford = new Player(114, 105, 54, 56, 53, 54, 53, 57, 56, 383, 60, 70, 21, 21, 13, 21, 14, 12, 14, 70, 3, 5, 5, 5, 2, 4, 3, 3, 2); // 0xEEF
            private static Player Eva_Chatton = new Player(75, 140, 51, 50, 65, 51, 64, 41, 41, 363, 60, 58, 13, 12, 17, 13, 17, 15, 16, 58, 2, 4, 2, 5, 3, 3, 3, 5, 2); // 0xEF0
            private static Player Pezi_Miste = new Player(109, 114, 53, 57, 54, 53, 56, 50, 56, 379, 60, 72, 21, 21, 14, 22, 13, 13, 13, 72, 1, 4, 3, 1, 2, 5, 2, 1, 4); // 0xEF1
            private static Player Preston_Creasefree = new Player(118, 99, 54, 53, 55, 57, 57, 56, 57, 389, 68, 68, 19, 18, 19, 18, 19, 19, 18, 68, 1, 2, 5, 4, 3, 4, 1, 3, 4); // 0xEF2
            private static Player Anna_Mite = new Player(95, 132, 55, 56, 57, 55, 57, 51, 54, 385, 75, 71, 23, 21, 21, 22, 21, 21, 21, 71, 5, 1, 1, 1, 5, 1, 3, 1, 1); // 0xEF3
            private static Player Bear_Zurka = new Player(118, 102, 65, 66, 56, 54, 57, 56, 56, 410, 69, 67, 13, 14, 18, 20, 18, 18, 19, 67, 1, 2, 5, 5, 2, 1, 2, 2, 3); // 0xEF4
            private static Player Pasha_Lomo = new Player(120, 102, 65, 55, 56, 54, 57, 54, 53, 394, 68, 59, 23, 18, 20, 20, 20, 18, 18, 59, 5, 4, 3, 5, 2, 1, 3, 2, 4); // 0xEF5
            private static Player Lennon_Trousers = new Player(107, 128, 48, 50, 51, 50, 59, 51, 61, 370, 75, 70, 22, 21, 21, 23, 23, 23, 22, 70, 3, 3, 5, 2, 5, 3, 3, 2, 3); // 0xEF6
            private static Player Drysden_Waller = new Player(119, 101, 63, 67, 57, 41, 56, 39, 57, 380, 71, 66, 16, 15, 18, 20, 18, 21, 18, 66, 4, 2, 3, 1, 1, 4, 5, 1, 4); // 0xEF7
            private static Player Zipp_Fastener = new Player(118, 105, 60, 48, 52, 48, 50, 48, 50, 356, 64, 64, 16, 16, 16, 15, 15, 15, 16, 64, 4, 4, 2, 4, 5, 3, 2, 3, 4); // 0xEF8
            private static Player Brook_Dredger = new Player(126, 98, 51, 50, 49, 48, 63, 41, 50, 352, 69, 63, 15, 16, 16, 16, 24, 19, 17, 63, 5, 2, 2, 3, 5, 1, 1, 2, 1); // 0xEF9
            private static Player Luke_Nohans = new Player(91, 117, 49, 52, 51, 53, 66, 42, 52, 365, 67, 63, 15, 15, 15, 17, 26, 19, 15, 63, 5, 2, 2, 5, 3, 4, 2, 4, 2); // 0xEFA
            private static Player BA_Branssen = new Player(126, 91, 51, 56, 50, 50, 63, 41, 50, 361, 69, 64, 15, 17, 16, 17, 26, 20, 15, 64, 5, 3, 3, 3, 5, 1, 5, 1, 3); // 0xEFB
            private static Player Fabrice_Soffner = new Player(122, 92, 53, 48, 50, 53, 65, 43, 57, 369, 66, 60, 17, 15, 15, 15, 26, 20, 15, 60, 2, 5, 5, 5, 2, 2, 1, 4, 2); // 0xEFC
            private static Player Virgil_Milliner = new Player(123, 110, 58, 60, 40, 41, 41, 40, 40, 320, 62, 59, 13, 12, 15, 16, 17, 15, 17, 59, 4, 5, 3, 4, 4, 5, 2, 4, 1); // 0xEFD
            private static Player Xenophon_Bick = new Player(93, 124, 62, 53, 51, 53, 60, 53, 50, 382, 68, 68, 18, 20, 19, 19, 20, 20, 18, 68, 1, 2, 1, 5, 1, 1, 1, 4, 2); // 0xEFE
            private static Player Chandler_Spillane = new Player(106, 112, 50, 58, 60, 58, 51, 50, 51, 378, 66, 68, 19, 19, 20, 20, 19, 19, 18, 68, 4, 3, 2, 5, 1, 4, 3, 4, 2); // 0xEFF
            private static Player Monarch_Rome = new Player(114, 109, 43, 62, 82, 58, 62, 61, 39, 407, 58, 71, 12, 13, 54, 12, 23, 12, 14, 71, 1, 1, 5, 1, 4, 1, 4, 1, 1); // 0xF00
            private static Player Sonny_Wukong = new Player(122, 97, 60, 57, 54, 57, 54, 39, 57, 378, 73, 64, 21, 17, 18, 13, 20, 21, 19, 64, 2, 2, 4, 3, 5, 5, 5, 2, 4); // 0xF01
            private static Player Joe_Bajie = new Player(119, 97, 54, 60, 57, 54, 56, 42, 53, 376, 75, 62, 17, 22, 13, 15, 12, 23, 12, 62, 1, 5, 1, 1, 2, 2, 5, 3, 3); // 0xF02
            private static Player Sean_Wujing = new Player(118, 101, 55, 53, 53, 62, 54, 43, 53, 373, 72, 64, 15, 16, 15, 21, 15, 21, 15, 64, 1, 4, 4, 5, 5, 4, 1, 3, 2); // 0xF03
            private static Player Tony_Sanzang = new Player(75, 142, 53, 57, 54, 60, 53, 42, 53, 372, 64, 74, 15, 17, 19, 12, 18, 21, 18, 74, 4, 3, 2, 1, 3, 1, 1, 5, 1); // 0xF04
            private static Player Helmut_Hardy = new Player(129, 90, 51, 51, 68, 50, 76, 43, 63, 402, 59, 66, 20, 19, 18, 18, 14, 14, 13, 66, 1, 5, 3, 5, 4, 5, 4, 4, 2); // 0xF05
            private static Player Harley_Hogg = new Player(94, 115, 51, 54, 67, 54, 73, 42, 51, 392, 68, 65, 18, 18, 19, 18, 25, 18, 20, 65, 3, 1, 4, 2, 5, 5, 3, 5, 2); // 0xF06
            private static Player Ezio_Ryder = new Player(98, 120, 53, 56, 70, 53, 73, 49, 51, 405, 68, 67, 18, 18, 18, 19, 25, 18, 20, 67, 2, 1, 1, 3, 1, 4, 5, 3, 4); // 0xF07
            private static Player Tori_Torrence = new Player(109, 118, 55, 48, 69, 50, 72, 47, 57, 398, 74, 65, 19, 15, 15, 16, 16, 20, 15, 65, 1, 3, 2, 4, 3, 1, 2, 5, 1); // 0xF08
            private static Player Placido_Cannes = new Player(100, 130, 55, 53, 57, 63, 55, 53, 65, 401, 64, 68, 16, 17, 15, 13, 17, 17, 12, 68, 1, 5, 1, 1, 2, 4, 3, 1, 1); // 0xF09
            private static Player Noyss_Kensler = new Player(98, 133, 51, 49, 49, 48, 42, 39, 51, 329, 61, 61, 16, 15, 16, 16, 16, 16, 16, 61, 1, 4, 3, 2, 3, 5, 2, 1, 2); // 0xF0A
            private static Player Hedwig_Setter = new Player(94, 132, 51, 51, 48, 50, 41, 39, 51, 331, 64, 61, 15, 17, 15, 15, 15, 16, 17, 61, 3, 3, 5, 5, 3, 2, 4, 2, 1); // 0xF0B
            private static Player Phineas_Hudd = new Player(96, 134, 48, 51, 53, 51, 65, 41, 51, 360, 65, 60, 15, 17, 16, 15, 17, 17, 16, 60, 3, 5, 2, 2, 1, 3, 1, 2, 4); // 0xF0C
            private static Player Viking_Beagle = new Player(104, 119, 53, 53, 56, 54, 48, 48, 51, 363, 61, 62, 16, 15, 15, 15, 16, 15, 15, 62, 4, 3, 4, 5, 3, 5, 1, 2, 4); // 0xF0D
            private static Player Seth_Paynter = new Player(120, 101, 45, 44, 47, 44, 56, 45, 46, 327, 56, 56, 12, 14, 13, 14, 13, 13, 13, 56, 2, 4, 4, 2, 5, 4, 1, 1, 3); // 0xF0E
            private static Player Indira_Patil = new Player(119, 118, 48, 49, 53, 48, 53, 62, 51, 364, 58, 56, 13, 13, 14, 12, 14, 13, 12, 56, 5, 1, 1, 5, 3, 2, 1, 3, 4); // 0xF0F
            private static Player T_T__Mann = new Player(81, 108, 66, 56, 57, 57, 57, 87, 53, 433, 44, 62, 13, 15, 17, 15, 20, 40, 15, 62, 5, 3, 4, 4, 2, 3, 1, 5, 4); // 0xF10
            private static Player Concordia_Choral = new Player(85, 130, 47, 54, 44, 45, 54, 44, 45, 333, 60, 58, 12, 12, 14, 13, 13, 13, 14, 58, 5, 2, 5, 3, 5, 2, 3, 5, 2); // 0xF11
            private static Player Assumpta_Meakin = new Player(127, 120, 45, 48, 47, 47, 44, 65, 44, 340, 57, 57, 14, 17, 15, 17, 17, 15, 17, 57, 4, 1, 3, 4, 4, 2, 5, 1, 3); // 0xF12
            private static Player Laurie_Driver = new Player(117, 97, 53, 54, 56, 58, 56, 54, 57, 388, 67, 66, 18, 18, 19, 26, 18, 18, 19, 66, 3, 1, 5, 1, 2, 1, 3, 2, 1); // 0xF13
            private static Player Raine_Walker = new Player(128, 140, 51, 52, 51, 50, 58, 48, 51, 361, 58, 55, 12, 13, 14, 13, 14, 14, 12, 55, 3, 4, 5, 4, 4, 2, 2, 5, 2); // 0xF14
            private static Player Martha_Hubbard = new Player(94, 133, 50, 53, 50, 48, 50, 53, 51, 355, 60, 59, 12, 12, 14, 12, 14, 13, 12, 59, 1, 3, 2, 3, 3, 3, 2, 5, 1); // 0xF15
            private static Player Bernina_Nightoil = new Player(87, 134, 48, 50, 51, 50, 50, 46, 48, 343, 58, 57, 12, 13, 14, 12, 13, 13, 12, 57, 5, 3, 4, 2, 5, 1, 2, 3, 2); // 0xF16
            private static Player Erik_Strongarm = new Player(108, 118, 55, 55, 56, 63, 53, 51, 51, 384, 66, 74, 20, 19, 18, 21, 19, 16, 15, 74, 4, 2, 5, 1, 3, 2, 1, 3, 1); // 0xF17
            private static Player Gunnar_Boatwright = new Player(109, 114, 56, 63, 66, 53, 55, 48, 51, 392, 72, 70, 14, 12, 12, 14, 12, 23, 21, 70, 3, 5, 4, 4, 2, 3, 4, 5, 4); // 0xF18
            private static Player Sigmund_Wayfinder = new Player(121, 95, 65, 53, 53, 64, 57, 51, 50, 393, 61, 60, 13, 16, 18, 14, 18, 21, 21, 60, 3, 2, 3, 1, 1, 3, 1, 5, 2); // 0xF19
            private static Player Grim_Jinxweaver = new Player(122, 120, 55, 57, 53, 53, 54, 55, 54, 381, 62, 73, 15, 15, 12, 17, 13, 13, 12, 73, 3, 3, 3, 4, 1, 5, 1, 5, 4); // 0xF1A
            private static Player Tia_Cruz = new Player(91, 135, 54, 57, 57, 53, 56, 48, 57, 382, 59, 55, 13, 12, 14, 12, 12, 14, 12, 55, 2, 3, 2, 4, 4, 5, 4, 5, 2); // 0xF1B
            private static Player Thomas_Oquendo = new Player(114, 100, 54, 62, 55, 62, 57, 57, 59, 406, 65, 63, 21, 17, 23, 17, 22, 22, 20, 63, 2, 1, 4, 4, 2, 1, 3, 5, 3); // 0xF1C
            private static Player Reyes_Cabedo = new Player(120, 92, 61, 48, 51, 54, 58, 48, 51, 371, 59, 59, 14, 12, 12, 14, 12, 13, 12, 59, 2, 5, 2, 2, 2, 1, 4, 3, 2); // 0xF1D
            private static Player Newt_Perfect = new Player(93, 126, 57, 56, 51, 54, 60, 53, 51, 382, 72, 76, 23, 22, 21, 21, 22, 22, 23, 76, 5, 4, 2, 1, 2, 3, 1, 5, 4); // 0xF1E
            private static Player Carmen_Aria = new Player(75, 137, 39, 41, 40, 41, 41, 39, 39, 280, 60, 70, 23, 23, 21, 21, 23, 23, 21, 70, 2, 1, 1, 3, 2, 5, 1, 3, 2); // 0xF1F
            private static Player Dorian_Lucenzo = new Player(140, 99, 56, 76, 67, 73, 57, 42, 55, 426, 57, 55, 22, 21, 23, 23, 21, 14, 21, 55, 1, 4, 5, 4, 4, 4, 5, 3, 1); // 0xF20
            private static Player Wesley_Provolone = new Player(132, 109, 63, 66, 60, 75, 48, 52, 68, 432, 57, 59, 24, 14, 13, 26, 14, 12, 13, 59, 1, 3, 3, 2, 2, 2, 5, 3, 4); // 0xF21
            private static Player Joachim_Zooner = new Player(128, 105, 70, 66, 70, 65, 61, 48, 48, 428, 76, 56, 13, 24, 13, 25, 14, 13, 12, 56, 2, 4, 5, 1, 5, 3, 3, 2, 4); // 0xF22
            private static Player Bjorn_Villen = new Player(130, 111, 66, 65, 51, 67, 60, 64, 61, 434, 79, 77, 13, 12, 12, 13, 13, 25, 13, 77, 5, 3, 1, 2, 5, 1, 2, 1, 2); // 0xF23
            private static Player Theron_Starr = new Player(108, 107, 38, 44, 86, 57, 89, 57, 53, 424, 58, 74, 15, 15, 16, 15, 23, 13, 14, 74, 4, 5, 1, 5, 4, 3, 5, 3, 4); // 0xF24
            private static Player Niall_Kuhn = new Player(106, 104, 43, 37, 83, 53, 90, 57, 56, 419, 64, 71, 17, 17, 15, 15, 23, 17, 16, 71, 2, 5, 3, 5, 2, 1, 4, 2, 4); // 0xF25
            private static Player Graplen_Hawk = new Player(107, 95, 28, 50, 84, 54, 89, 53, 57, 415, 62, 73, 14, 14, 12, 13, 21, 17, 15, 73, 5, 5, 3, 5, 5, 4, 2, 2, 4); // 0xF26
            private static Player Tribulus_Galtrop = new Player(102, 87, 36, 33, 86, 56, 97, 57, 55, 420, 60, 59, 15, 15, 16, 15, 26, 12, 15, 59, 1, 3, 3, 5, 1, 4, 2, 3, 4); // 0xF27
            private static Player Sunil_Rahman = new Player(88, 200, 29, 30, 28, 40, 32, 21, 31, 211, 59, 150, 14, 26, 12, 14, 18, 12, 12, 150, 1, 2, 4, 3, 5, 1, 1, 3, 2); // 0xF28
            private static Player Suphis_Cheops = new Player(150, 31, 100, 72, 80, 39, 64, 43, 48, 446, 100, 21, 26, 25, 23, 22, 24, 23, 18, 21, 5, 2, 2, 1, 5, 5, 4, 4, 1); // 0xF29
            private static Player Khefren_Chepren = new Player(148, 32, 79, 90, 43, 78, 65, 41, 51, 447, 105, 22, 26, 21, 21, 25, 24, 23, 18, 22, 2, 2, 2, 3, 5, 2, 5, 5, 1); // 0xF2A
            private static Player Mykerinos_Menkh = new Player(144, 32, 88, 80, 39, 82, 65, 41, 51, 446, 102, 21, 26, 26, 22, 22, 26, 22, 18, 21, 5, 4, 2, 2, 4, 3, 1, 5, 1); // 0xF2B
            private static Player Narcissa_Plane = new Player(90, 113, 51, 48, 65, 62, 49, 50, 66, 391, 72, 86, 22, 44, 55, 40, 40, 40, 62, 86, 3, 4, 2, 2, 2, 5, 2, 5, 2); // 0xF2C
            private static Player Pauletta_Porter = new Player(96, 117, 51, 59, 63, 50, 51, 50, 63, 387, 73, 88, 21, 55, 43, 41, 41, 45, 58, 88, 3, 2, 5, 4, 5, 3, 3, 4, 2); // 0xF2D
            private static Player Hattie_Couture = new Player(99, 118, 51, 60, 66, 51, 51, 48, 66, 393, 72, 90, 23, 48, 43, 47, 44, 38, 42, 90, 5, 2, 4, 3, 5, 1, 2, 2, 2); // 0xF2E
            private static Player Urbana_Street = new Player(93, 111, 62, 53, 65, 49, 51, 50, 63, 393, 73, 98, 23, 23, 47, 32, 41, 44, 58, 98, 1, 4, 4, 5, 1, 1, 2, 1, 2); // 0xF2F
            private static Player Lovell_Lyons = new Player(122, 97, 53, 56, 57, 56, 57, 42, 53, 374, 57, 56, 12, 14, 13, 12, 13, 14, 12, 56, 5, 3, 1, 2, 4, 2, 5, 5, 3); // 0xF30
            private static Player Pease_Marrowfat = new Player(119, 102, 64, 58, 56, 56, 57, 41, 53, 385, 57, 59, 25, 24, 21, 26, 20, 14, 26, 59, 2, 1, 1, 3, 5, 4, 3, 4, 1); // 0xF31
            private static Player Ram_Horner = new Player(127, 97, 64, 54, 56, 54, 53, 65, 54, 400, 60, 65, 13, 19, 18, 18, 19, 14, 18, 65, 1, 4, 2, 4, 4, 4, 2, 5, 2); // 0xF32
            private static Player Pius_Fisher = new Player(108, 105, 56, 57, 54, 67, 63, 56, 56, 409, 67, 67, 18, 19, 19, 14, 12, 19, 19, 67, 2, 2, 3, 5, 3, 5, 4, 4, 1); // 0xF33
            private static Player Archie_Rider = new Player(107, 119, 66, 57, 56, 53, 54, 57, 57, 400, 66, 69, 14, 18, 19, 18, 19, 19, 20, 69, 3, 2, 5, 4, 2, 5, 4, 3, 4); // 0xF34
            private static Player Virginia_Goldstein = new Player(101, 127, 57, 65, 57, 53, 53, 56, 53, 394, 70, 56, 18, 12, 20, 18, 18, 19, 18, 56, 3, 3, 1, 5, 5, 3, 3, 3, 2); // 0xF35
            private static Player Norton_Waters = new Player(107, 100, 55, 54, 66, 53, 65, 65, 53, 411, 66, 65, 20, 18, 13, 18, 12, 12, 20, 65, 5, 2, 1, 3, 1, 5, 2, 2, 3); // 0xF36
            private static Player Jen_Miniver = new Player(109, 117, 54, 53, 54, 54, 56, 56, 56, 383, 69, 55, 18, 20, 19, 19, 20, 20, 18, 55, 2, 5, 1, 1, 2, 3, 2, 3, 3); // 0xF37
            private static Player Ernest_Goodman = new Player(120, 120, 33, 88, 56, 54, 63, 54, 66, 414, 66, 68, 22, 22, 18, 18, 21, 19, 18, 68, 3, 1, 1, 5, 2, 5, 5, 2, 1); // 0xF38
            private static Player Galahad_Chevalier = new Player(106, 106, 82, 65, 56, 36, 52, 53, 66, 410, 66, 69, 23, 21, 18, 20, 21, 18, 23, 69, 5, 2, 2, 2, 3, 3, 5, 2, 2); // 0xF39
            private static Player Wanda_Spelling = new Player(74, 155, 56, 58, 53, 58, 56, 50, 56, 387, 34, 85, 15, 17, 17, 15, 18, 18, 19, 85, 1, 1, 5, 4, 1, 4, 2, 1, 3); // 0xF3A
            private static Player Nick_Pincher = new Player(98, 99, 57, 38, 86, 50, 66, 50, 65, 412, 74, 74, 21, 21, 23, 21, 21, 21, 22, 74, 2, 3, 4, 4, 3, 5, 3, 5, 4); // 0xF3B
            private static Player Marshall_Artison = new Player(121, 97, 63, 57, 51, 87, 31, 59, 64, 412, 57, 59, 13, 13, 13, 13, 12, 12, 13, 59, 5, 2, 2, 5, 2, 2, 5, 3, 1); // 0xF3C
            private static Player Mary_Curey = new Player(73, 128, 50, 51, 55, 83, 56, 40, 28, 363, 60, 79, 16, 16, 16, 17, 15, 16, 15, 79, 3, 5, 3, 1, 5, 3, 4, 3, 1); // 0xF3D
            private static Player Ian_Bick = new Player(103, 117, 49, 52, 51, 49, 62, 53, 51, 367, 65, 62, 15, 15, 15, 17, 15, 17, 16, 62, 3, 1, 1, 5, 1, 2, 4, 4, 3); // 0xF3E
            private static Player Jib_Spinaker = new Player(109, 109, 57, 54, 53, 49, 48, 50, 57, 368, 61, 63, 16, 17, 15, 15, 17, 17, 16, 63, 3, 4, 2, 3, 2, 5, 5, 4, 3); // 0xF3F
            private static Player Odo_Riffeck = new Player(108, 119, 56, 53, 51, 54, 48, 51, 51, 364, 65, 63, 17, 17, 16, 15, 17, 16, 15, 63, 2, 3, 3, 4, 4, 1, 2, 5, 4); // 0xF40
            private static Player Fox_Wiley = new Player(124, 94, 53, 49, 50, 50, 52, 49, 59, 362, 63, 61, 16, 17, 15, 15, 16, 15, 15, 61, 1, 2, 2, 5, 3, 3, 1, 2, 1); // 0xF41
            private static Player Gladius_Swinger = new Player(120, 102, 52, 58, 48, 52, 53, 50, 53, 366, 59, 56, 15, 25, 16, 15, 12, 12, 13, 56, 4, 5, 2, 1, 3, 1, 2, 3, 4); // 0xF42
            private static Player Asif_Ecks = new Player(120, 98, 53, 65, 50, 48, 56, 50, 54, 376, 59, 57, 16, 25, 15, 17, 14, 13, 14, 57, 4, 5, 5, 5, 5, 2, 2, 3, 4); // 0xF43
            private static Player Roy_Ellway = new Player(115, 107, 42, 40, 56, 39, 56, 54, 53, 340, 71, 73, 23, 23, 22, 23, 22, 21, 22, 73, 2, 2, 2, 2, 2, 2, 5, 3, 1); // 0xF44
            private static Player Scott_Amundsen = new Player(133, 101, 51, 57, 51, 56, 48, 51, 49, 363, 60, 58, 12, 14, 13, 14, 14, 12, 14, 58, 3, 4, 5, 5, 4, 5, 1, 4, 3); // 0xF45
            private static Player Mike_Roscopy = new Player(110, 90, 51, 49, 49, 50, 59, 51, 53, 362, 60, 57, 13, 13, 13, 12, 14, 13, 14, 57, 1, 3, 4, 4, 1, 5, 4, 3, 3); // 0xF46
            private static Player Gruff_Dorman = new Player(94, 132, 63, 66, 49, 64, 51, 39, 48, 380, 60, 59, 12, 13, 13, 12, 14, 13, 12, 59, 1, 3, 1, 1, 4, 2, 2, 5, 2); // 0xF47
            private static Player Snowy_Bergman = new Player(124, 97, 66, 57, 57, 56, 53, 51, 54, 394, 57, 66, 25, 18, 16, 18, 17, 12, 16, 66, 2, 4, 5, 3, 2, 5, 3, 3, 1); // 0xF48
            private static Player Tiger_Bleriot = new Player(121, 101, 56, 56, 54, 63, 55, 53, 56, 393, 56, 65, 20, 18, 15, 24, 15, 12, 16, 65, 3, 4, 4, 5, 3, 3, 4, 4, 2); // 0xF49
            private static Player Ugg_LeMugg = new Player(144, 72, 83, 77, 44, 34, 58, 59, 56, 411, 58, 58, 26, 25, 22, 24, 20, 12, 26, 58, 5, 3, 3, 1, 2, 3, 5, 3, 1); // 0xF4A
            private static Player Hans_Popov = new Player(140, 75, 86, 70, 31, 44, 56, 57, 56, 400, 56, 58, 25, 24, 23, 24, 19, 13, 24, 58, 2, 3, 4, 4, 3, 4, 5, 1, 1); // 0xF4B
            private static Player Norman_Zeus = new Player(142, 74, 82, 72, 34, 42, 53, 61, 53, 397, 59, 58, 25, 24, 21, 24, 18, 14, 24, 58, 3, 3, 4, 3, 1, 2, 4, 5, 2); // 0xF4C
            private static Player Tommo_Marrow = new Player(143, 74, 83, 74, 44, 42, 56, 52, 57, 408, 59, 55, 24, 26, 23, 25, 18, 13, 25, 55, 2, 2, 2, 5, 1, 4, 4, 3, 4); // 0xF4D
            private static Player Lyle_Covet = new Player(144, 73, 80, 77, 42, 38, 58, 50, 57, 402, 59, 57, 25, 24, 21, 26, 20, 12, 26, 57, 3, 2, 4, 1, 5, 3, 1, 2, 2); // 0xF4E
            private static Player Graham_Dupree = new Player(124, 78, 50, 49, 43, 50, 85, 80, 46, 403, 80, 67, 13, 17, 15, 22, 24, 26, 16, 67, 3, 4, 3, 4, 5, 4, 1, 4, 1); // 0xF4F
            private static Player Dirk_Byker = new Player(122, 78, 44, 46, 44, 49, 85, 80, 43, 391, 77, 66, 12, 16, 15, 21, 24, 24, 16, 66, 5, 5, 3, 4, 2, 3, 5, 5, 4); // 0xF50
            private static Player Charles_LeMans = new Player(121, 74, 49, 48, 43, 49, 85, 78, 50, 402, 79, 60, 12, 22, 16, 17, 25, 24, 17, 60, 4, 1, 1, 2, 4, 4, 4, 5, 3); // 0xF51
            private static Player Walter_Carr = new Player(130, 74, 46, 51, 43, 47, 86, 80, 47, 400, 77, 60, 14, 22, 17, 16, 24, 24, 15, 60, 3, 2, 5, 2, 2, 1, 5, 4, 4); // 0xF52
            private static Player Buzz_Scrambler = new Player(124, 75, 52, 46, 46, 45, 86, 80, 46, 401, 80, 60, 21, 15, 15, 16, 26, 24, 17, 60, 5, 3, 3, 1, 1, 5, 5, 2, 4); // 0xF53
            private static Player Nifty_Throttler = new Player(123, 95, 46, 53, 40, 45, 93, 81, 46, 404, 76, 57, 16, 16, 19, 14, 24, 26, 13, 57, 3, 5, 3, 5, 2, 5, 4, 2, 4); // 0xF54
            private static Player Kay_Emcee = new Player(107, 128, 56, 49, 65, 42, 57, 49, 56, 374, 60, 76, 19, 19, 27, 18, 12, 13, 13, 76, 4, 3, 1, 3, 5, 3, 3, 1, 2); // 0xF55
            private static Player Mark_Evans2 = new Player(155, 185, 53, 80, 49, 100, 80, 80, 80, 522, 47, 94, 13, 40, 25, 40, 50, 26, 30, 94, 1, 5, 2, 5, 2, 5, 5, 5, 6); // 0xF5B
            private static Player Nathan_Swift_2 = new Player(154, 172, 64, 70, 68, 70, 99, 90, 80, 541, 64, 59, 23, 22, 22, 21, 50, 22, 40, 59, 4, 4, 4, 4, 5, 2, 4, 4, 2); // 0xF5C
            private static Player Jack_Wallside2 = new Player(143, 166, 40, 53, 62, 99, 60, 75, 54, 443, 59, 48, 18, 21, 18, 70, 30, 21, 21, 48, 1, 2, 1, 1, 2, 5, 2, 4, 3); // 0xF5D
            private static Player Hurley_Kane2 = new Player(162, 167, 110, 80, 51, 80, 70, 71, 65, 527, 78, 72, 75, 30, 27, 27, 25, 27, 27, 72, 1, 1, 5, 1, 1, 1, 1, 1, 4); // 0xF5E
            private static Player Scott_Banyan2 = new Player(156, 164, 44, 58, 80, 80, 70, 72, 50, 454, 70, 50, 22, 25, 50, 50, 27, 27, 24, 50, 4, 4, 5, 4, 4, 4, 4, 4, 3); // 0xF5F
            private static Player Thor_Stoutberg2 = new Player(154, 187, 56, 80, 53, 80, 60, 71, 68, 468, 77, 75, 29, 40, 24, 40, 24, 23, 23, 75, 1, 1, 1, 1, 1, 1, 1, 5, 2); // 0xF60
            private static Player Xavier_Foster2 = new Player(141, 179, 80, 63, 67, 58, 90, 80, 60, 498, 92, 69, 40, 28, 28, 29, 50, 28, 30, 69, 5, 2, 2, 5, 2, 2, 2, 2, 5); // 0xF61
            private static Player Caleb_Stonewall2 = new Player(156, 180, 59, 90, 99, 90, 65, 53, 64, 520, 66, 57, 30, 30, 50, 26, 30, 28, 29, 57, 3, 1, 2, 1, 1, 5, 2, 2, 4); // 0xF62
            private static Player Jude_Sharp2 = new Player(153, 176, 63, 59, 79, 52, 90, 56, 68, 467, 70, 75, 28, 29, 25, 27, 23, 25, 23, 75, 2, 2, 2, 2, 2, 2, 2, 5, 1); // 0xF63
            private static Player Axel_Blaze2 = new Player(163, 173, 120, 99, 62, 70, 70, 80, 60, 561, 69, 82, 80, 50, 23, 24, 50, 40, 22, 82, 2, 2, 2, 1, 5, 1, 1, 1, 2); // 0xF64
            private static Player Shawn_Froste2 = new Player(150, 170, 88, 59, 72, 59, 77, 80, 57, 492, 67, 76, 44, 24, 26, 24, 30, 27, 23, 76, 2, 2, 2, 5, 2, 2, 1, 2, 2); // 0xF65
            private static Player Darren_LaChance2 = new Player(143, 192, 59, 54, 66, 99, 56, 60, 80, 474, 52, 88, 24, 24, 29, 80, 25, 28, 29, 88, 1, 1, 1, 1, 5, 1, 1, 1, 3); // 0xF66
            private static Player Kevin_Dragonfly_2 = new Player(152, 174, 130, 70, 49, 53, 51, 100, 100, 553, 61, 88, 80, 25, 20, 22, 19, 24, 50, 88, 4, 2, 1, 4, 4, 5, 1, 2, 2); // 0xF67
            private static Player Austin_Hobbes2 = new Player(150, 180, 100, 56, 90, 55, 70, 80, 57, 508, 91, 77, 80, 21, 50, 24, 27, 28, 26, 77, 1, 1, 1, 1, 5, 1, 1, 1, 1); // 0xF68
            private static Player Archer_Hawkins2 = new Player(155, 174, 100, 54, 52, 80, 52, 75, 74, 487, 88, 54, 80, 26, 17, 26, 21, 22, 22, 54, 1, 1, 1, 5, 1, 1, 1, 1, 1); // 0xF69
            private static Player David_Samford2 = new Player(154, 176, 90, 100, 61, 53, 80, 70, 67, 521, 72, 100, 26, 22, 27, 23, 27, 23, 26, 100, 3, 3, 5, 3, 1, 1, 2, 2, 3); // 0xF6A

            public IDictionary<int, Player> IE3Player = new Dictionary<int, Player>
            {
                { 0x01, Mark_Evans },
{ 0x02, Nathan_Swift },
{ 0x03, Jack_Wallside },
{ 0x04, Jim_Wraith },
{ 0x05, Tod_Ironside },
{ 0x06, Steve_Grim },
{ 0x07, Tim_Saunders },
{ 0x08, Sam_Kincaid },
{ 0x09, Maxwell_Carson },
{ 0x0A, Axel_Blaze },
{ 0x0B, Kevin_Dragonfly },
{ 0x0C, William_Glass },
{ 0x15, Joseph_King },
{ 0x16, Peter_Drent },
{ 0x17, Ben_Simmons },
{ 0x18, Alan_Master },
{ 0x19, Gus_Martin },
{ 0x1A, Herman_Waldon },
{ 0x1B, John_Bloom },
{ 0x1C, Derek_Swing },
{ 0x1D, Daniel_Hatch },
{ 0x1E, Jude_Sharp_RA },
{ 0x1F, David_Samford_RA },
{ 0x20, Bob_Carlton },
{ 0x21, Cliff_Tomlinson },
{ 0x22, Jim_Lawrenson },
{ 0x23, Barry_Potts },
{ 0x24, Steve_Ingham },
{ 0x29, Nathan_Jones },
{ 0x2A, Russell_Walk },
{ 0x2B, Jason_Jones },
{ 0x2C, Ken_Furan },
{ 0x2D, Jerry_Fulton },
{ 0x2E, Ray_Mannings },
{ 0x2F, Robert_Mayer },
{ 0x30, Alexander_Brave },
{ 0x31, Johan_Tassman },
{ 0x32, Troy_Moon },
{ 0x33, Burt_Wolf },
{ 0x34, Rob_Crombie },
{ 0x35, Chuck_Dollman },
{ 0x36, Uxley_Allen },
{ 0x37, Phil_Noir },
{ 0x38, Mick_Askley },
{ 0x3D, Charlie_Boardfield },
{ 0x3E, Hugo_Tallgeese },
{ 0x3F, Wilson_Fishman },
{ 0x40, Peter_Johnson_ },
{ 0x41, Leonard_O_Shea },
{ 0x42, Cham_Lion },
{ 0x43, Steve_Eagle },
{ 0x44, Bruce_Monkey },
{ 0x45, Gary_Lancaster },
{ 0x46, Harry_Snake },
{ 0x47, Adrian_Speed },
{ 0x48, Alan_Coe },
{ 0x49, Philip_Anders },
{ 0x4A, Rocky_Rackham },
{ 0x4B, Matt_Mouseman },
{ 0x4C, Chad_Bullford },
{ 0x51, Thomas_Feldt },
{ 0x52, Harry_Leading },
{ 0x53, Terry_Stronger },
{ 0x54, Philip_Marvel },
{ 0x55, Noel_Good },
{ 0x56, Tyron_Rock },
{ 0x57, Francis_Tell },
{ 0x58, Samuel_Buster },
{ 0x59, Jonathan_Seller },
{ 0x5A, Victor_Kind },
{ 0x5B, Neil_Turner },
{ 0x5C, Reg_Underwood },
{ 0x5D, Patrick_Stiller },
{ 0x5E, Charles_Oughtry },
{ 0x5F, Clive_Mooney },
{ 0x60, Neil_Waters },
{ 0x65, Sam_Idol },
{ 0x66, Marcus_Train },
{ 0x67, Light_Nobel },
{ 0x68, Walter_Valiant },
{ 0x69, Spencer_Gates },
{ 0x6A, Josh_Spear },
{ 0x6B, Gaby_Farmer },
{ 0x6C, A__Woodbridge },
{ 0x6D, Gus_Gamer },
{ 0x6E, Mark_Gambling },
{ 0x6F, Theodore_Master },
{ 0x70, Ham_Signalman },
{ 0x71, Bill_Formby },
{ 0x72, Grant_Eldorado },
{ 0x73, Mike_Vox },
{ 0x74, Ollie_Webb },
{ 0x79, Morgan_Sanders },
{ 0x7A, Newton_Flust },
{ 0x7B, Jim_Hillfort },
{ 0x7C, Galen_Thunderbird },
{ 0x7D, Finn_Stoned },
{ 0x7E, Phil_Wingate },
{ 0x7F, Jez_Shell },
{ 0x80, Jupiter_Jumper },
{ 0x81, Sam_Samurai },
{ 0x82, Hank_Sullivan },
{ 0x83, Sail_Bluesea },
{ 0x84, John_Reynolds },
{ 0x85, Dan_Hopper },
{ 0x86, Cal_Trops },
{ 0x87, Winston_Falls },
{ 0x88, Kevin_Castle },
{ 0x8D, Albert_Green },
{ 0x8E, Seward_Hayseed },
{ 0x8F, Kent_Work },
{ 0x90, Mark_Hillvalley_ },
{ 0x91, Herb_Sherman },
{ 0x92, Joe_Small },
{ 0x93, Ike_Steiner },
{ 0x94, Orville_Newman },
{ 0x95, Tom_Walters },
{ 0x96, Daniel_Dawson },
{ 0x97, Stuart_Racoonfur },
{ 0x98, Lorne_Mower },
{ 0x99, Homer_Grower },
{ 0x9A, Rolf_Howells },
{ 0x9B, Luke_Lively },
{ 0x9C, Ben_Nevis },
{ 0xA1, John_Neville },
{ 0xA2, Malcolm_Night },
{ 0xA3, Alfred_Meenan },
{ 0xA4, Dan_Mirthful },
{ 0xA5, Ricky_Clover },
{ 0xA6, Toby_Damian },
{ 0xA7, York_Nashmith },
{ 0xA8, Zachary_Moore },
{ 0xA9, Marvin_Murdock },
{ 0xAA, Thomas_Murdock },
{ 0xAB, Tyler_Murdock },
{ 0xAC, Simon_Calier },
{ 0xAD, Brody_Gloom },
{ 0xAE, Victor_Talis },
{ 0xAF, Eren_Middleton },
{ 0xB0, Peter_Wells },
{ 0xB5, Paul_Siddon },
{ 0xB6, Apollo_Light },
{ 0xB7, Jeff_Iron },
{ 0xB8, Lane_War },
{ 0xB9, Danny_Wood },
{ 0xBA, Artie_Mishman },
{ 0xBB, Arion_Matlock },
{ 0xBC, Wesley_Knox },
{ 0xBD, Jonas_Demetrius },
{ 0xBE, Byron_Love },
{ 0xBF, Henry_House },
{ 0xC0, Iggy_Russ },
{ 0xC1, Gus_Heeley },
{ 0xC2, Harry_Closs },
{ 0xC3, Andy_Chronic },
{ 0xC4, Ned_Yousef },
{ 0xC9, Herman_Muller },
{ 0xCA, Keth_Claus },
{ 0xCB, Robert_Silver },
{ 0xCC, Izzy_Island },
{ 0xCD, Sothern_Newman },
{ 0xCE, Irwin_Hall },
{ 0xCF, Taylor_Higgins },
{ 0xD0, Jamie_Cool },
{ 0xD1, Hans_Randall },
{ 0xD2, Michael_Riverside },
{ 0xD3, Millie_Moonlight },
{ 0xD4, Karl_Blue },
{ 0xD5, Theakston_Plank },
{ 0xD6, Ken_Cake },
{ 0xD7, Mitch_Grumble },
{ 0xD8, Bart_Grantham },
{ 0xDD, Joe_Ingram },
{ 0xDE, Kendall_Sefton },
{ 0xDF, Jason_Strike },
{ 0xE0, Norman_Porter },
{ 0xE1, Maxwell_Claus },
{ 0xE2, Bruce_Chaney },
{ 0xE3, Leroy_Rhymes },
{ 0xE4, Mildford_Scott },
{ 0xE5, Lou_Edmonds },
{ 0xE6, Cameron_Morefield },
{ 0xE7, Greg_Bernard },
{ 0xE8, Peter_Banker },
{ 0xE9, Saul_Tunk },
{ 0xEA, Alan_Most },
{ 0xEB, Paul_Caperock },
{ 0xEC, Julius_Molehill },
{ 0xF1, Suzanne_Yuma },
{ 0xF2, Tammy_Fielding },
{ 0xF3, Alex_Lovely },
{ 0xF4, Louis_Hillside },
{ 0xF5, Ness_Sheldon },
{ 0xF6, Lizzy_Squirrel },
{ 0xF7, Kippy_Jones },
{ 0xF8, Fayette_Riversong },
{ 0xF9, Samantha_Moonlight },
{ 0xFA, Mitch_Sandstone },
{ 0xFB, Eddie_Prentice },
{ 0xFC, Alf_Holmes },
{ 0xFD, Ian_Stager },
{ 0xFE, Fred_Crumb },
{ 0xFF, Doug_Baughan },
{ 0x100, Pip_Daltry },
{ 0x105, Seymour_Hillman },
{ 0x106, Charles_Island },
{ 0x107, Garret_Hairtown },
{ 0x108, Arthur_Sweet },
{ 0x109, Peter_Mildred },
{ 0x10A, Josh_Nathaniel },
{ 0x10B, Edward_Gladstone },
{ 0x10C, Tyler_Thomas },
{ 0x10D, Joseph_Yosemite },
{ 0x10E, Ian_Suffolk },
{ 0x10F, Constant_Builder },
{ 0x110, Ted_Poe },
{ 0x111, Marshall_Heart },
{ 0x112, Dom_Foreman },
{ 0x113, Slot_MacHines },
{ 0x114, Bill_Steakspear },
{ 0x12D, Jimmy_Mach },
{ 0x12E, Tony_Hacker },
{ 0x12F, Dan_Rhino },
{ 0x130, Vin_Fleetwood },
{ 0x131, George_Winters },
{ 0x132, Den_Hidden },
{ 0x133, Shaun_Imago },
{ 0x134, Joe_Straiter },
{ 0x135, Rupert_Spiers },
{ 0x136, Mark_Sudor },
{ 0x137, Ringo_Stagg },
{ 0x138, Jody_MacGough },
{ 0x139, Jeeves_Dropper },
{ 0x13A, Dan_Dandy },
{ 0x13B, Rory_Boomer },
{ 0x13C, Tim_Toppel },
{ 0x13D, Ames_Shivers },
{ 0x13E, Chris_Glover },
{ 0x13F, Thor_Toise },
{ 0x140, Colin_Salts },
{ 0x141, Christian_Dear },
{ 0x142, Iggy_Loyaller },
{ 0x143, Conan_Fox },
{ 0x144, Spike_Coiffs },
{ 0x145, Roger_Rocket },
{ 0x146, Bill_Teller },
{ 0x147, Billy_Nomates },
{ 0x148, Harry_Caine },
{ 0x149, Martin_Sheller },
{ 0x14A, Alfie_Fine },
{ 0x14B, Cameron_Mann },
{ 0x14C, Don_Keys },
{ 0x14D, Sonny_East },
{ 0x14E, Dan_Carpenter },
{ 0x14F, Doug_Walker },
{ 0x150, Frank_Drake },
{ 0x151, Chris_Massey },
{ 0x152, Carl_Sacks },
{ 0x153, Biff_Beeston },
{ 0x154, Lou_Beigh },
{ 0x155, Marv_Errick },
{ 0x156, Bob_Whittle },
{ 0x157, Bert_Neptune },
{ 0x158, Sol_Crater },
{ 0x159, Percy_Coldstair },
{ 0x15A, Dusky_Sunfield },
{ 0x15B, Rocky_Shears },
{ 0x15C, Percy_Stent },
{ 0x15D, Art_Pendragon },
{ 0x15E, Dom_Ittory },
{ 0x15F, Chaz_Biggins },
{ 0x160, Sly_O_Hands },
{ 0x161, Sean_Lavender },
{ 0x162, Ace_Server },
{ 0x163, Horace_Nelson },
{ 0x164, Rex_George },
{ 0x165, Philip_Prince },
{ 0x166, Heath_Rower },
{ 0x167, Kim_Arite },
{ 0x168, Jay_Archer },
{ 0x169, Bo_Ling },
{ 0x16A, Chuck_Hardy },
{ 0x16B, Ben_Evolent },
{ 0x16C, Will_Noble },
{ 0x16D, Jack_Frosty },
{ 0x16E, Larry_Helps },
{ 0x16F, Monty_Patten },
{ 0x170, Chunk_Gorman },
{ 0x171, Balt_Decker },
{ 0x172, Drew_Crenshaw },
{ 0x173, Stan_Trum },
{ 0x174, Sham_Spike },
{ 0x175, Rainier_Welkin },
{ 0x176, Evan_Yielding },
{ 0x177, Phil_Anthropic },
{ 0x178, Fane_Club },
{ 0x179, Slim_Lanky },
{ 0x17A, Pearson_Gaze },
{ 0x17B, Edward_Albion },
{ 0x17C, Stu_Dent },
{ 0x17D, Barry_Straw },
{ 0x17E, Bobby_Peel },
{ 0x17F, Dan_Castella },
{ 0x180, Bill_Moony },
{ 0x181, Buddy_Goodman },
{ 0x182, Dex_Territy },
{ 0x183, Vinny_O_Gaines },
{ 0x184, Ray_Deo },
{ 0x185, Archie_Meades },
{ 0x186, Dave_Chaucer },
{ 0x187, Billy_Blanc },
{ 0x188, Creed_Craving },
{ 0x189, Phil_Rosey },
{ 0x18A, Harry_Redcastle },
{ 0x18B, Sonny_Welkin },
{ 0x18C, Teddy_Kodiak },
{ 0x18D, Lloyd_Tabb },
{ 0x18E, Francis_Paine },
{ 0x18F, Griff_Strummer },
{ 0x190, Bryce_Bergman },
{ 0x191, Fingus_Inky },
{ 0x192, Walter_Geyser },
{ 0x193, Les_Knightley },
{ 0x194, Conor_Abley },
{ 0x195, Ainsley_Burns },
{ 0x196, Pete_Grimes },
{ 0x197, Manny_Steele },
{ 0x198, Trey_Hugger },
{ 0x199, Jack_Mate },
{ 0x19A, Mike_Chequer },
{ 0x19B, Berty_Adman },
{ 0x19C, Troy_Carr },
{ 0x19D, Hollis_Ticure },
{ 0x19E, Guy_Dance },
{ 0x19F, Jack_Trumper },
{ 0x1A0, John_Corder },
{ 0x1A1, Nigel_Bramel },
{ 0x1A2, Hank_O_Chief },
{ 0x1A3, Jess_Uplement },
{ 0x1A4, Alec_Smart },
{ 0x1A5, Rob_Anchor },
{ 0x1A6, Brent_Cross },
{ 0x1A7, Albert_Wister },
{ 0x1A8, Nev_Erin },
{ 0x1A9, Caz_Yewell },
{ 0x1AA, Conor_Trail },
{ 0x1AB, Manuel_Gere },
{ 0x1AC, Per_Hockside },
{ 0x1AD, Lee_Gleagle },
{ 0x1AE, Paul_Pitcher },
{ 0x1AF, Turner_Fortune },
{ 0x1B0, Walter_Walken },
{ 0x1B1, Sal_Curie },
{ 0x1B2, Silver_Platt },
{ 0x1B3, Nick_Yergrub },
{ 0x1B4, Mal_Inger },
{ 0x1B5, Jim_Cook },
{ 0x1B6, Gus_Potter },
{ 0x1B7, Handel_Turnon },
{ 0x1B8, Peter_Malus },
{ 0x1B9, Colin_Lection },
{ 0x1BA, Brock_Twigg },
{ 0x1BB, Paddy_Rise },
{ 0x1BC, Dustin_Westend },
{ 0x1BD, Alfonse_Way },
{ 0x1BE, Pippin_Flowers },
{ 0x1BF, Euan_Stamper },
{ 0x1C0, Paddy_Prunus },
{ 0x1C1, Brian_Presser },
{ 0x1C2, Pete_LeGume },
{ 0x1C3, Shylock_Watson },
{ 0x1C4, Ed_Ripp },
{ 0x1C5, Hike_Basher },
{ 0x1C6, Anthony_Phinder },
{ 0x1C7, Duncan_Jump },
{ 0x1C8, Lucky_Winn },
{ 0x1C9, Gene_Bates },
{ 0x1CA, Randolf_Finn },
{ 0x1CB, Ron_Away },
{ 0x1CC, Rick_Hatter },
{ 0x1CD, Grant_Mardy },
{ 0x1CE, Shawn_Broker },
{ 0x1CF, Anthony_Coyne },
{ 0x1D0, Healey_Proctor },
{ 0x1D1, Ade_Posting },
{ 0x1D2, Doug_Outon },
{ 0x1D3, Ebenezer_Marner },
{ 0x1D4, Davy_Johns },
{ 0x1D5, Bos_Horne },
{ 0x1D6, Nick_Orner },
{ 0x1D7, Nathin_Gaunt },
{ 0x1D8, Quentin_Quartz },
{ 0x1D9, Andrew_Meikle },
{ 0x1DA, Gary_Salmon },
{ 0x1DB, Fontaine_Tapper },
{ 0x1DC, Leon_Lawn },
{ 0x1DD, Jim_Sweatman },
{ 0x1DE, Cole_Coaker },
{ 0x1DF, Stu_Born },
{ 0x1E0, Romeo_Montague },
{ 0x1E1, Drew_Straitedge },
{ 0x1E2, Dash_Dotter },
{ 0x1E3, Gill_O_Mend },
{ 0x1E4, Pay_Chance },
{ 0x1E5, Bill_Aegis },
{ 0x1E6, Tosh_Coach },
{ 0x1E7, Carl_Gnu },
{ 0x1E8, Paul_Sapp },
{ 0x1E9, Macky_Valley },
{ 0x1EA, Troy_Trucker },
{ 0x1EB, Haden_Seek },
{ 0x1EC, Kevin_Doors },
{ 0x1ED, Skip_Rooter },
{ 0x1EE, Rip_Airman },
{ 0x1EF, Stu_Shiner },
{ 0x1F0, Matt_Matickal },
{ 0x1F1, Philip_Flagg },
{ 0x1F2, Alf_Groundsman },
{ 0x1F3, Ernie_Riddell },
{ 0x1F4, Len_Stint },
{ 0x1F5, Holly_Cricket },
{ 0x1F6, Dave_Altair },
{ 0x1F7, Jim_Reed },
{ 0x1F8, Gwyn_Penn },
{ 0x1F9, Spike_Needle },
{ 0x1FA, Ifan_Tassy },
{ 0x1FB, Eggbert_Heading },
{ 0x1FC, Pascal_Blaise },
{ 0x1FD, Will_Whist },
{ 0x1FE, Ewan_Liner },
{ 0x1FF, Buster_Locke },
{ 0x200, Rex_Plorer },
{ 0x201, Webber_Poster },
{ 0x202, Sid_Parting },
{ 0x203, Eaton_Rampage },
{ 0x204, Parker_Leaper },
{ 0x205, Hank_Halberd },
{ 0x206, Robin_Catching },
{ 0x207, Trey_Spotter },
{ 0x208, Onslow_Ball },
{ 0x209, Tex_Tingle },
{ 0x20A, Sam_Gale },
{ 0x20B, Ryder_Waverly },
{ 0x20C, Leaf_Scarlett },
{ 0x20D, Horace_Coop },
{ 0x20E, Ness_Lockley },
{ 0x20F, Olef_Tennant },
{ 0x210, Len_Scapp },
{ 0x211, Monty_Hillary },
{ 0x212, Penfold_Pulper },
{ 0x213, Thomas_Cott },
{ 0x214, Spike_Thorne },
{ 0x215, Lincoln_Hawking },
{ 0x216, Ted_Larkin },
{ 0x217, Madison_Cabinet },
{ 0x218, Odo_Cologne },
{ 0x219, Nester_Damus },
{ 0x21A, Herb_Ivore },
{ 0x21B, Homer_Pidgeon },
{ 0x21C, Rob_Ottley },
{ 0x21D, Scott_Springer },
{ 0x21E, Viv_Grey },
{ 0x21F, Don_Snow },
{ 0x220, Hal_Mullet },
{ 0x221, Isaiah_Shutt },
{ 0x222, Ace_Irvin },
{ 0x223, Spike_Pitt },
{ 0x224, Innes_Caving },
{ 0x225, Keanu_Dell },
{ 0x226, Casey_Novak },
{ 0x227, Ed_Halley },
{ 0x228, Burt_Mocking },
{ 0x229, Oscar_Petty },
{ 0x22A, Waite_Forrit },
{ 0x22B, Bennett_Byers },
{ 0x22C, Mo_Eisner },
{ 0x22D, Miles_Seaford },
{ 0x22E, Sayer_Lemon },
{ 0x22F, Carey_Ginu },
{ 0x230, Cass_Crocker },
{ 0x231, Paul_Downs },
{ 0x232, Darrel_Jeeling },
{ 0x233, Nobby_Shinn },
{ 0x234, Theo_Broma },
{ 0x235, Ramsey_Faroe },
{ 0x236, Buster_Chopps },
{ 0x237, Vince_Bull },
{ 0x238, Pat_Maclean },
{ 0x239, Walter_Card },
{ 0x23A, Derek_Terr },
{ 0x23B, Alton_Oldhat },
{ 0x23C, Cal_Cooler },
{ 0x23D, Tom_Felix },
{ 0x23E, Terry_Orr },
{ 0x23F, Rudolph_Rainder },
{ 0x240, Nick_Swagg },
{ 0x241, Hal_Leeward },
{ 0x242, Arthur_Dox },
{ 0x243, Reese_Ickle },
{ 0x244, Finn_Attick },
{ 0x245, Col_Lector },
{ 0x246, Crispin_Shooter },
{ 0x247, Stu_Perstitious },
{ 0x248, Ashley_Fay },
{ 0x249, Luke_Raffles },
{ 0x24A, Stu_Helmsley },
{ 0x24B, Terrence_Anthem },
{ 0x24C, Gene_Bottle },
{ 0x24D, Sam_O_Reilly },
{ 0x24E, Ches_Nutcracker },
{ 0x24F, Victor_Grand },
{ 0x250, Ant_Hophila },
{ 0x251, Hunter_Glory },
{ 0x252, Joe_Rassock },
{ 0x253, Patch_Borgnine },
{ 0x254, Ted_Fast },
{ 0x255, Clay_Modlin },
{ 0x256, Alan_Mode },
{ 0x257, Harry_Harper },
{ 0x258, Pascal_Richter },
{ 0x259, Beau_Fort },
{ 0x25A, Reid_Scarlet },
{ 0x25B, Joe_Lamkin },
{ 0x25C, Dylan_Magpie },
{ 0x25D, Gil_Rivers },
{ 0x25E, Des_Tiny },
{ 0x25F, Saul_Dowd },
{ 0x260, Kit_Chapman },
{ 0x261, Fry_Vollity },
{ 0x262, Clark_Roach },
{ 0x263, Samuel_Peeps },
{ 0x264, Dai_Hart },
{ 0x265, Horty_Courture },
{ 0x266, Bob_Baggum },
{ 0x267, Ollie_Twister },
{ 0x268, Fred_Makepeace },
{ 0x269, Walker_Sleep },
{ 0x26A, Sean_Trawler },
{ 0x26B, Ken_Sewer },
{ 0x26C, Bamber_Shoot },
{ 0x26D, Sly_Winker },
{ 0x26E, Teller_Scoap },
{ 0x26F, Sam_Firman },
{ 0x270, Bear_Turnbull },
{ 0x271, Tabor_Drummond },
{ 0x272, Brook_Atwater },
{ 0x273, Ike_Doerflinger },
{ 0x274, Aessop_Fabel },
{ 0x275, Grant_Slammer },
{ 0x276, Robin_Cruise },
{ 0x277, Mark_Perfect },
{ 0x278, Rolly_Kerr },
{ 0x279, Moses_Pumper },
{ 0x27A, Knight_Reader },
{ 0x27B, Cash_Barganier },
{ 0x27C, Brendan_Branch },
{ 0x27D, Clark_Rain },
{ 0x27E, Luther_Rio },
{ 0x27F, Florian_Hutter },
{ 0x280, Scamp_Shrimplin },
{ 0x281, Adam_Nesiac },
{ 0x282, Rab_Acus },
{ 0x283, Chris_Miles },
{ 0x284, Shemmy_Ramis },
{ 0x285, Lon_Grainger },
{ 0x286, Manny_Atom },
{ 0x287, Bill_Tardy },
{ 0x288, Fox_Copier },
{ 0x289, Cletus_Badden },
{ 0x28A, Skip_Sofrenic },
{ 0x28B, Mat_Char },
{ 0x28C, Trey_Cultivator },
{ 0x28D, Vinny_Trioquist },
{ 0x28E, Ton_Nino },
{ 0x28F, Oscar_Esher },
{ 0x290, Saul_Searcher },
{ 0x291, Gerry_Attrick },
{ 0x292, Adam_Icklock },
{ 0x293, Sol_Stiss },
{ 0x294, Des_Ainer },
{ 0x295, Homer_Sockshell },
{ 0x296, Harley_Trotter },
{ 0x297, Mark_Skidfree },
{ 0x298, Del_Iverryboy },
{ 0x299, Scean_Spector },
{ 0x29A, Nick_Knack },
{ 0x29B, Dusty_Rellicks },
{ 0x29C, Sandy_Insolls },
{ 0x29D, Gregory_Bones },
{ 0x29E, Loughrey_Mose },
{ 0x29F, Willow_Withers },
{ 0x2A0, Winn_deBreeze },
{ 0x2A1, Buster_Clout },
{ 0x2A2, Errol_Lorre },
{ 0x2A3, Fred_Ferrell },
{ 0x2A4, Rod_Headstock },
{ 0x2A5, Tim_Piece },
{ 0x2A6, Patrick_Edie },
{ 0x2A7, Art_Teest },
{ 0x2A8, Bill_Mumm },
{ 0x2A9, Luke_O_Cyte },
{ 0x2AA, Ernest_Byer },
{ 0x2AB, Isaac_Goss },
{ 0x2AC, Walter_Poseur },
{ 0x2AD, Andy_Roff },
{ 0x2AE, Ashley_Dale },
{ 0x2AF, Rich_Cave },
{ 0x2B0, Taka_Tanaka },
{ 0x2B1, Manny_Carbs },
{ 0x2B2, Al_Reddie },
{ 0x2B3, Rush_Tooset },
{ 0x2B4, Rod_Opsin },
{ 0x2B5, Peyton_Pope },
{ 0x2B6, Drew_Straws },
{ 0x2B7, Trey_Dalbum },
{ 0x2B8, Harly_Profett },
{ 0x2B9, Hank_O_Buff },
{ 0x2BA, Ash_Cloud },
{ 0x2BB, Stan_Dupp },
{ 0x2BC, Max_Bright },
{ 0x2BD, Bill_Phee },
{ 0x2BE, Lee_Figreene },
{ 0x2BF, Den_Taligene },
{ 0x2C0, Adam_Hesive },
{ 0x2C1, Mel_Lowe },
{ 0x2C2, Rip_Winkle },
{ 0x2C3, Ben_deLimms },
{ 0x2C4, Pauly_Ontology },
{ 0x2C5, Walter_Mendip },
{ 0x2C6, Bud_Hunter },
{ 0x2C7, Sonny_Rentman },
{ 0x2C8, Cam_Vass },
{ 0x2C9, Shay_Chez },
{ 0x2CA, Cory_Andish },
{ 0x2CB, Glen_Adeer },
{ 0x2CC, Norry_Sheets },
{ 0x2CD, Lou_Paster },
{ 0x2CE, Aran_Cheeks },
{ 0x2CF, Abe_Seiler },
{ 0x2D0, Al_Urgy },
{ 0x2D1, Conn_Pass },
{ 0x2D2, Heath_Cover },
{ 0x2D3, Mack_Ramey },
{ 0x2D4, Miles_Ryan },
{ 0x2D5, Ike_Banner },
{ 0x2D6, Frank_Meyer },
{ 0x2D7, Phil_Fog },
{ 0x2D8, Bob_Lioteck },
{ 0x2D9, Rory_Polisher },
{ 0x2DA, Tex_Curvator },
{ 0x2DB, Perry_Pincher },
{ 0x2DC, Al_Plates },
{ 0x2DD, Bane_Marie },
{ 0x2DE, Cam_Broadsheet },
{ 0x2DF, Mo_Hawkes },
{ 0x2E0, Chris_Pecracker },
{ 0x2E1, Andy_Crafter },
{ 0x2E2, Boe_Tyer },
{ 0x2E3, Dave_O_Resis },
{ 0x2E4, Victor_Mancey },
{ 0x2E5, Ray_Dioset },
{ 0x2E6, Preston_Gumbs },
{ 0x2E7, Tiny_Forester },
{ 0x2E8, Cardin_Hands },
{ 0x2E9, Callan_Trens },
{ 0x2EA, Tim_Mittus },
{ 0x2EB, Keenan_Brainard },
{ 0x2EC, Orson_Douvre },
{ 0x2ED, Sandy_Hope },
{ 0x2EE, Ort_Omaton },
{ 0x2EF, Clerk_Welcome },
{ 0x2F0, Rob_Ottman },
{ 0x2F1, Cam_O_Miles },
{ 0x2F2, Jack_Pott },
{ 0x2F3, Florian_Selles },
{ 0x2F4, Finn_Sawyer },
{ 0x2F5, Bobby_Constable },
{ 0x2F6, Ray_Menn },
{ 0x2F7, Odo_Toilette },
{ 0x2F8, Tel_Egram },
{ 0x2F9, Char_Shumaker },
{ 0x2FA, Sim_Pathy },
{ 0x2FB, Jon_Driedon },
{ 0x2FC, Monty_Burrows },
{ 0x2FD, Gaston_Berry },
{ 0x2FE, Cruz_Ligner },
{ 0x2FF, Irv_Washinton },
{ 0x300, Shem_Bassey },
{ 0x301, Pres_Cripton },
{ 0x302, Winston_Windfall },
{ 0x303, Rich_Eden },
{ 0x304, Teagen_Brewer },
{ 0x305, Ry_Sling },
{ 0x306, Bard_Crooner },
{ 0x307, Armstrong_Peck },
{ 0x308, Carey_Vanpark },
{ 0x309, Garland_Gathers },
{ 0x30A, David_Burnum },
{ 0x30B, Tad_Trinket },
{ 0x30C, Harvey_Lifter },
{ 0x30D, Kurt_Price },
{ 0x30E, Cameron_Hameha },
{ 0x30F, Will_Stonehead },
{ 0x310, Hugh_Marble },
{ 0x311, Urson_Brown },
{ 0x312, Bo_Luger },
{ 0x313, Kim_Ono },
{ 0x314, Bully_Thrower },
{ 0x315, Bill_Wordsworthy },
{ 0x316, Mo_Lusk },
{ 0x317, Ben_Curd },
{ 0x318, Powers_Squatts },
{ 0x319, Paisley_Onepiece },
{ 0x31A, Gauge_Diven },
{ 0x31B, Zane_Laughead },
{ 0x31C, Daz_Tighthead },
{ 0x31D, Sandy_Beecher },
{ 0x31E, Ty_Priter },
{ 0x31F, Nick_Savers },
{ 0x320, Percy_Wrench },
{ 0x321, Max_Scara },
{ 0x322, Jonny_Strutt },
{ 0x323, Larry_Oldman },
{ 0x324, Dom_Anding },
{ 0x325, Pip_Goodweather },
{ 0x326, Bamber_Mandrina },
{ 0x327, Scrap_Salvadge },
{ 0x328, Michael_Angeloni },
{ 0x329, Ryder_Wheeling },
{ 0x32A, Stu_Venier },
{ 0x32B, Linden_Dray },
{ 0x32C, Patsy_Cornish },
{ 0x32D, Sharkey_Gobble },
{ 0x32E, Olly_Popman },
{ 0x32F, Tyche_Winham },
{ 0x330, Page_Helper },
{ 0x331, Barry_Lugh },
{ 0x332, Jen_Quibble },
{ 0x333, Dan_Drobium },
{ 0x334, Lyle_O_Day },
{ 0x335, Crane_Clawson },
{ 0x336, Raven_Crowe },
{ 0x337, Shirley_Ladyman },
{ 0x338, Cody_Barani },
{ 0x339, Bob_Shishker },
{ 0x33A, Pica_Vellosum },
{ 0x33B, Sascha_Powder },
{ 0x33C, Gore_Lyath },
{ 0x33D, Marty_Gras },
{ 0x33E, Bob_Dingnagian },
{ 0x33F, Hugh_Dyer },
{ 0x340, Carl_Penter },
{ 0x341, Jebb_Ettow },
{ 0x342, Julian_Siezer },
{ 0x343, Bill_Dozer },
{ 0x344, Benny_Factor },
{ 0x345, Roman_Candler },
{ 0x346, Ray_Whitehead },
{ 0x347, Aston_Isher },
{ 0x348, Grover_Bearing },
{ 0x349, Andy_Sided },
{ 0x34A, Phil_O_Biblist },
{ 0x34B, Roy_Plimsole },
{ 0x34C, Jem_Paste },
{ 0x34D, Mike_Creasewell },
{ 0x34E, Hale_Quinn },
{ 0x34F, Al_Askan },
{ 0x350, Scot_Chopper },
{ 0x351, Nick_Templeton },
{ 0x352, Butler_Chambers },
{ 0x353, Pip_Skinner },
{ 0x354, Dan_Vega },
{ 0x355, Manny_Kinsland },
{ 0x356, Chick_Adiddy },
{ 0x357, Jig_Charleston },
{ 0x358, Powers_Flawless },
{ 0x359, Alistair_Horizon },
{ 0x35A, Tim_Bergoods },
{ 0x35B, Lux_Sidebottom },
{ 0x35C, Nat_Picker },
{ 0x35D, Harold_Derry },
{ 0x35E, Josh_Rogan },
{ 0x35F, Ronny_O_Mania },
{ 0x360, Buck_Teachey },
{ 0x361, Rayburn_Lightly },
{ 0x362, Pat_Greene },
{ 0x363, Sylver_Stone },
{ 0x364, Equin_Knocks },
{ 0x365, Hans_Bigger },
{ 0x366, Creed_Wrighter },
{ 0x367, Fran_Zimmer },
{ 0x368, Chaz_Anover },
{ 0x369, Kurt_O_Graphy },
{ 0x36A, Pace_Storey },
{ 0x36B, Paddy_Streehan },
{ 0x36C, Carson_Haynes },
{ 0x36D, Earl_Grayson },
{ 0x36E, Pip_Aminty },
{ 0x36F, Noel_Vacancies },
{ 0x370, Jon_Quill },
{ 0x371, Bill_Looney },
{ 0x372, Dan_Nettles },
{ 0x373, Clark_Watcher },
{ 0x374, Tim_Eisback },
{ 0x375, Sam_Aritan },
{ 0x376, Cal_Emarry },
{ 0x377, Bambis_Shakin },
{ 0x378, Zin_Giber },
{ 0x379, Wes_Abbey },
{ 0x37A, Alec_Dote },
{ 0x37B, Dougie_McFlea },
{ 0x37C, Jacky_Lantern },
{ 0x37D, Matt_Tudor },
{ 0x37E, Gabriel_Shekinah },
{ 0x37F, Biron_Pendexter },
{ 0x380, Rod_Entwhistle },
{ 0x381, Toby_Patient },
{ 0x382, Glen_Garry },
{ 0x383, Bill_Yards },
{ 0x384, Kay_Acker },
{ 0x385, Django_Keyes },
{ 0x386, John_Demi },
{ 0x387, Sage_Wisdom },
{ 0x388, Nick_Washing },
{ 0x389, Steve_Pinner },
{ 0x38A, Vance_Bookings },
{ 0x38B, Bud_Dahman },
{ 0x38C, Reagan_Boneman },
{ 0x38D, Erhard_Blower },
{ 0x38E, Jack_Tradesman },
{ 0x38F, Rufus_Judge },
{ 0x390, Ace_Fettick },
{ 0x391, Lance_Lotts },
{ 0x392, Attley_Hightable },
{ 0x393, Jim_Nastick },
{ 0x394, Theo_Riser },
{ 0x395, Weldon_Wrought },
{ 0x396, Seymour_Senary },
{ 0x397, Finn_Carper },
{ 0x398, Herc_Bigsby },
{ 0x399, Bramley_Cox },
{ 0x39A, Mitch_Hett },
{ 0x39B, Mo_Zarella },
{ 0x39C, Scout_Messenger },
{ 0x39D, Paul_Chucker },
{ 0x39E, Andy_Wallpole },
{ 0x39F, Solomon_Justice },
{ 0x3A0, Mark_Tinney },
{ 0x3A1, Archy_Medez },
{ 0x3A2, Jay_Pan },
{ 0x3A3, Jonah_Troutman },
{ 0x3A4, Carl_Nivor },
{ 0x3A5, Phil_Occifer },
{ 0x3A6, Noah_Gerkin },
{ 0x3A7, Colin_Eager },
{ 0x3A9, Nick_Crew },
{ 0x3AA, Ivor_Parrot },
{ 0x3AB, Matthew_Pencil },
{ 0x3AC, Ropert_Chapp },
{ 0x3AD, Hal_LeButt },
{ 0x3AE, Al_Chemmy },
{ 0x3AF, Rob_Zervatory },
{ 0x3B0, Joe_Stick },
{ 0x3B1, Nick_Turine },
{ 0x3B2, Marc_O_Lepsy },
{ 0x3B3, Jim_Makegood },
{ 0x3B4, Vin_Spinner },
{ 0x3B5, Grew_Driver },
{ 0x3B6, Ed_Dupee },
{ 0x3B7, Hank_Shortman },
{ 0x3B8, Aaron_Peacy },
{ 0x3B9, Harvey_Sweats },
{ 0x3BA, Harry_Overton },
{ 0x3BB, Archie_Tate },
{ 0x3BC, Neville_List },
{ 0x3BD, Lee_Dorr },
{ 0x3BE, Sam_Which },
{ 0x3BF, Dwight_Self },
{ 0x3C0, Shep_Shank },
{ 0x3C1, Dylan_Swan },
{ 0x3C2, Theo_Bernoulli },
{ 0x3C3, Sul_Tarner },
{ 0x3C4, Silas_Scrooge },
{ 0x3C5, Mario_Nette },
{ 0x3C6, Telly_Fonbocks },
{ 0x3C7, Bones_Size },
{ 0x3C8, Frank_Koshar },
{ 0x3C9, Keifer_Tiliser },
{ 0x3CA, Jak_Hammerslam },
{ 0x3CB, Rob_Freeby },
{ 0x3CC, Chris_Talise },
{ 0x3CD, Derek_Longhand },
{ 0x3CE, Manny_Gerry },
{ 0x3CF, Des_Count },
{ 0x3D0, Rocky_Rollans },
{ 0x3D1, Shaun_Staid },
{ 0x3D2, Heath_Freke },
{ 0x3D3, Olly_Gammy },
{ 0x3D4, Aidan_Model },
{ 0x3D5, Mick_Thatcher },
{ 0x3D6, Owen_Greenfield },
{ 0x3D7, Charlie_Krelborn },
{ 0x3D8, Rory_Circles },
{ 0x3D9, Barry_Sterr },
{ 0x3DA, John_Baird },
{ 0x3DB, Tyson_Moodey },
{ 0x3DC, Al_Istatin },
{ 0x3DD, Paddy_Popper },
{ 0x3DE, Dwayne_Woo },
{ 0x3DF, Pete_Sadow },
{ 0x3E0, Troy_Glodight },
{ 0x3E1, Chris_Hypogee },
{ 0x3E2, Connor_Bation },
{ 0x3E3, Rhys_Masher },
{ 0x3E4, Charlie_Shearing },
{ 0x3E5, Al_Mannack },
{ 0x3E6, Nathan_Weyton },
{ 0x3E7, Simon_Stryker },
{ 0x3E8, Will_Bayeux },
{ 0x3E9, Thomas_Ediston },
{ 0x3EA, Aubry_Dient },
{ 0x3EB, Les_Tarrant },
{ 0x3EC, Sim_Cope },
{ 0x3ED, Cal_O_Rees },
{ 0x3EE, Ringo_Spinning },
{ 0x3EF, Dec_O_Rator },
{ 0x3F0, Pat_Shinko },
{ 0x3F1, Ryan_Ferry },
{ 0x3F2, Les_Belisha },
{ 0x3F3, Tim_Crochett },
{ 0x3F4, Hiroshi_Dot },
{ 0x3F5, Jack_Nimble },
{ 0x3F6, Patch_Upright },
{ 0x3F7, Joe_Nalist },
{ 0x3F8, Esau_Fagus },
{ 0x3F9, Braden_Bakewell },
{ 0x3FA, Virgil_Lantis },
{ 0x3FB, Norm_Drilling },
{ 0x3FC, Kurt_Tweedy },
{ 0x3FD, Solomon_Osaka },
{ 0x3FE, Pike_Tucker },
{ 0x3FF, Gary_Osoto },
{ 0x400, Dec_Orum },
{ 0x401, Alan_Carte },
{ 0x402, Morgan_Iser },
{ 0x403, Ken_Broad },
{ 0x404, Scot_Enguard },
{ 0x405, Dick_Turbin },
{ 0x406, Benedict_Eggers },
{ 0x407, Beau_Painton },
{ 0x408, Butch_Pythons },
{ 0x409, Sam_Murray },
{ 0x40A, Eathan_Ringer },
{ 0x40B, Jack_Lumbar },
{ 0x40C, Todd_Tempole },
{ 0x40D, Jacob_Grimley },
{ 0x40E, John_Coralli },
{ 0x40F, Drew_Faxon },
{ 0x410, Cole_Easteroll },
{ 0x411, Cam_Lensman },
{ 0x412, Tighe_Windsor },
{ 0x413, Phil_Dippedes },
{ 0x414, Lenny_Lakeman },
{ 0x415, Vaughn_DeVille },
{ 0x416, Arthur_Myrddin },
{ 0x417, Guy_Forker },
{ 0x418, Bob_Stretcher },
{ 0x419, Spike_Clutcher },
{ 0x41A, Austin_Tayssus },
{ 0x41B, Tom_Stevenson },
{ 0x41C, Ricky_Charmers },
{ 0x41D, Max_Hurt },
{ 0x41E, Dexter_Raleigh },
{ 0x41F, Pete_Pang },
{ 0x420, Sam_Fitspire },
{ 0x421, Carter_Nightly },
{ 0x422, Daley_Switcher },
{ 0x423, Dexter_Ambie },
{ 0x424, Gill_Able },
{ 0x425, Drew_Reiner },
{ 0x426, Kevin_Boardman },
{ 0x427, Andy_Craft },
{ 0x428, Julius_Vernon },
{ 0x429, Robin_Sherwood },
{ 0x42A, Ei_King },
{ 0x42B, Travis_McClean },
{ 0x42C, Rusty_Spoakes },
{ 0x42D, Clint_Wester },
{ 0x42E, Pete_Nokeyo },
{ 0x42F, Will_Racer },
{ 0x430, Ollie_Seeker },
{ 0x431, Graham_Hush },
{ 0x432, Ronny_Knowles },
{ 0x433, Les_Abel },
{ 0x434, Reg_Thrift },
{ 0x435, Jools_Iceberg },
{ 0x436, Mark_Brent },
{ 0x437, Vern_Ironfist },
{ 0x438, Rob_Burnsides },
{ 0x439, Ace_Bragg },
{ 0x43A, Claude_Snap },
{ 0x43B, Paul_Rush },
{ 0x43C, Guile_Crocket },
{ 0x43D, Carey_Bean },
{ 0x43E, John_Maggie },
{ 0x43F, Chops_Denton },
{ 0x440, Bobby_Yellow },
{ 0x441, Ace_Breaker },
{ 0x442, Percy_Verence },
{ 0x443, Erik_Eagle },
{ 0x444, Bobby_Shearer },
{ 0x445, Paul_Peabody },
{ 0x446, Chester_Horse_Jr },
{ 0x447, Chester_Horse_Jr_2 },
{ 0x448, Sagaminator },
{ 0x449, Jude_Sharp },
{ 0x44A, Shadow_Cimmerian },
{ 0x821, Grant_Cook_Chaos },
{ 0x822, Bonnie_Sparks_Chaos },
{ 0x823, Claire_Lesnow_Chaos },
{ 0x824, Albert_Denver_Chaos },
{ 0x825, Ben_Blowton_Chaos },
{ 0x826, Ethan_Whitering_Chaos },
{ 0x827, Dawson_Foxx_Chaos },
{ 0x828, Ving_Rice_Chaos },
{ 0x829, Bryce_Whitingale_Chaos },
{ 0x82A, Claude_Beacons_Chaos },
{ 0x82B, Nigel_August_Chaos },
{ 0x835, Gordon_Star },
{ 0x836, Connor_Shuttle },
{ 0x837, Jim_Landing },
{ 0x838, Grant_Icewater },
{ 0x839, Charles_Riverboat },
{ 0x83A, Pat_Box },
{ 0x83B, Gregory_Saturn },
{ 0x83C, Izzy_Jupiter },
{ 0x83D, Rhona_Countdown },
{ 0x83E, Janus },
{ 0x83F, Dylan_Bluemoon },
{ 0x849, Dvalin },
{ 0x84A, Craven_Kenville },
{ 0x84B, Anna_Mole },
{ 0x84C, Kayson_Wattever },
{ 0x84D, Mike_Tytan },
{ 0x84E, Mads_Hatter },
{ 0x84F, Karen_Ripton },
{ 0x850, Yakker_Plantsworm },
{ 0x851, Carrie_McCuring },
{ 0x852, Ronny_Metcalf },
{ 0x853, Zeke_Valanche },
{ 0x854, Dvalin_2 },
{ 0x85D, Nelson_Rockwell },
{ 0x85E, Gail_Baker },
{ 0x85F, Kim_Powell },
{ 0x860, Zack_Cummings },
{ 0x861, Hunt_Mercer },
{ 0x862, Connor_Murray },
{ 0x863, Katie_Brown },
{ 0x864, Ashton_Malone },
{ 0x865, Wilbur_Watkins },
{ 0x866, Isabelle_Trick },
{ 0x867, Xene },
{ 0x871, Dvalin_3 },
{ 0x872, Craven_Kenville_2 },
{ 0x873, Anna_Mole_2 },
{ 0x874, Kayson_Wattever_2 },
{ 0x875, Mike_Tytan_2 },
{ 0x876, Mads_Hatter_2 },
{ 0x877, Karen_Ripton_2 },
{ 0x878, Yakker_Plantsworm_2 },
{ 0x879, Carrie_McCuring_2 },
{ 0x87A, Ronny_Metcalf_2 },
{ 0x87B, Zeke_Valanche_2 },
{ 0x885, Cam_Mando },
{ 0x886, Harry_Boufante },
{ 0x887, Todd_Stuhl },
{ 0x888, Aspen_Blewit },
{ 0x889, Marismus_Oregon },
{ 0x88A, Garjan_Cypress },
{ 0x88B, Judas_Deathcap },
{ 0x88C, Chase_Faithfull },
{ 0x88D, Chris_Ticker },
{ 0x88E, Roy_Daring },
{ 0x88F, Scaber_Enoki },
{ 0x899, Robot_S },
{ 0x89A, Robot_P },
{ 0x89B, Robot_T },
{ 0x89C, Robot_V },
{ 0x89D, Robot_C },
{ 0x89E, Robot_O },
{ 0x89F, Robot_B },
{ 0x8A0, Robot_G },
{ 0x8A1, Robot_K },
{ 0x8A2, Robot_F },
{ 0x8A3, Robot_L },
{ 0x8AD, Seymour_Hillman_Young },
{ 0x8AE, Charles_Island_Young },
{ 0x8AF, Garret_Hairtown_Young },
{ 0x8B0, Arthur_Sweet_Young },
{ 0x8B1, Peter_Mildred_Young },
{ 0x8B2, Josh_Nathaniel_Young },
{ 0x8B3, Edward_Gladstone_Young },
{ 0x8B4, Tyler_Thomas_Young },
{ 0x8B5, Joseph_Yosemite_Young },
{ 0x8B6, Ian_Suffolk_Young },
{ 0x8B7, Constant_Builder_Young },
{ 0x8C1, Grant_Cook },
{ 0x8C2, Bonnie_Sparks },
{ 0x8C3, Val_Flamewood },
{ 0x8C4, Sean_Ashford },
{ 0x8C5, Ben_Blowton },
{ 0x8C6, Ethan_Whitering },
{ 0x8C7, Brenda_Firequest },
{ 0x8C8, Sam_Bournes },
{ 0x8C9, Jim_Flareson },
{ 0x8CA, Claude_Beacons },
{ 0x8CB, Nigel_August },
{ 0x8D5, Ben_North },
{ 0x8D6, Alan_Downhill },
{ 0x8D7, Claire_Lesnow },
{ 0x8D8, Albert_Denver },
{ 0x8D9, Lucy_Hailstone },
{ 0x8DA, Brad_Coldwater },
{ 0x8DB, Dawson_Foxx },
{ 0x8DC, Ving_Rice },
{ 0x8DD, Bernie_White },
{ 0x8DE, Bryce_Whitingale },
{ 0x8DF, Denzel_Freezer },
{ 0x8FD, Ken_Ironwall },
{ 0x8FE, Timothy_Western },
{ 0x8FF, Wallace_Hammond },
{ 0x900, Shirley_Stevens },
{ 0x901, Ian_Smith },
{ 0x902, Taylor_Firepool },
{ 0x903, Marge_Fielding },
{ 0x904, Marshall_Firsthand },
{ 0x905, Holly_Mirror },
{ 0x906, Victoria_Vanguard },
{ 0x907, Joe_Kenneddy },
{ 0x908, Ian_Sights },
{ 0x909, Greene_Beray },
{ 0x90A, Ryan_Tappin },
{ 0x90B, Linda_Shadey },
{ 0x90C, Sid_Safehouse },
{ 0x911, Adam_Ropes },
{ 0x912, Joaquine_Downtown },
{ 0x913, Milton_Bindings },
{ 0x914, Spike_Gleeson },
{ 0x915, Sean_Snowfield },
{ 0x916, Kerry_Bootgaiter },
{ 0x917, Maddox_Rock },
{ 0x918, Robert_Skipolson },
{ 0x919, Shawn_Froste },
{ 0x91A, Roland_Climbstein },
{ 0x91B, Quentin_Rackner },
{ 0x91C, Trent_Peggs },
{ 0x91D, Martin_Ursus },
{ 0x91E, Pete_Bogg },
{ 0x91F, Gem_Strata },
{ 0x920, Horace_Onlign },
{ 0x921, Shawn_Froste_Aiden },
{ 0x922, Shawn_Froste_Fusion },
{ 0x925, Crane_Kik },
{ 0x926, Parry_Waxon },
{ 0x927, Bri_Spark },
{ 0x928, Max_Fortune },
{ 0x929, Brendan_Water },
{ 0x92A, Junior_Fardream },
{ 0x92B, Ian_Telektual },
{ 0x92C, Lee_Dinglite },
{ 0x92D, Marshall_Artz },
{ 0x92E, Tyke_Wando },
{ 0x92F, Dirk_Artz },
{ 0x930, Scott_Banyan },
{ 0x931, Earnest_Bookworm },
{ 0x932, Ollie_Gami },
{ 0x933, Roman_Kandel },
{ 0x934, Don_Ation },
{ 0x935, Scott_Banyan_FW },
{ 0x939, Joseph_King_Redux },
{ 0x93A, Rowan_Beltzer },
{ 0x93B, Blade_Healen },
{ 0x93C, Argie_Bargie },
{ 0x93D, Lee_Bamboo },
{ 0x93E, Eton_Messer },
{ 0x93F, Jonah_Spark },
{ 0x940, Sue_Sparrow },
{ 0x941, Riley_Jamm },
{ 0x942, Caleb_Stonewall_Redux },
{ 0x943, David_Samford_Redux },
{ 0x944, Jimbo_Cellar },
{ 0x945, Zenn_Wildhorse },
{ 0x946, Dawson_Little },
{ 0x947, Cosimo_Beck },
{ 0x948, Maston_Color },
{ 0x94D, Darren_LaChance },
{ 0x94E, Drancis_Fake },
{ 0x94F, Mick_Mishap },
{ 0x950, Louis_Leave },
{ 0x951, Maurice_Badgame },
{ 0x952, Cannon_Random },
{ 0x953, Ulric_Richmen },
{ 0x954, Dave_Fate },
{ 0x955, Spencer_Duskplay },
{ 0x956, Jonathan_Luckyman },
{ 0x957, Joe_Poker },
{ 0x958, Wiley_Cracker },
{ 0x959, Mark_Failing },
{ 0x95A, Alton_Cotts },
{ 0x95B, Mike_Passing },
{ 0x95C, Knowle_Bathers },
{ 0x961, Rocky_Black },
{ 0x962, Chad_Taylor },
{ 0x963, Victor_Hills },
{ 0x964, Hurley_Kane },
{ 0x965, Hector_Redding },
{ 0x966, Mackenzie_Fordline },
{ 0x967, Cadence_Soundtown },
{ 0x968, Dora_Delight },
{ 0x969, Tom_Contented },
{ 0x96A, Joston_Easton },
{ 0x96B, Spring_Millpond },
{ 0x96C, Gaston_Cooley },
{ 0x96D, Bevan_Breakfast },
{ 0x96E, Jack_Griddle },
{ 0x96F, Stan_Andagi },
{ 0x970, Coral_Talent },
{ 0x975, Thomas_Feldt2 },
{ 0x976, Malcolm_Night2 },
{ 0x977, Shadow_Cimmerian2 },
{ 0x978, Jim_Wraith2 },
{ 0x979, Tod_Ironside2 },
{ 0x97A, Steve_Grim2 },
{ 0x97B, Tim_Saunders2 },
{ 0x97C, Sam_Kincaid2 },
{ 0x97D, Maxwell_Carson2 },
{ 0x97E, Nathan_Swift2 },
{ 0x97F, Kevin_Dragonfly2 },
{ 0x989, Daisy_Fields },
{ 0x98A, Alexia_Sand },
{ 0x98B, Hellen_Hearth },
{ 0x98C, Rose_Pinkpetal },
{ 0x98D, Esther_Greenland },
{ 0x98E, Bela_Bluebells },
{ 0x98F, Natalie_Sunrise },
{ 0x990, Hillary_Bush },
{ 0x991, Mary_Moor },
{ 0x992, Suzette_Hartland },
{ 0x993, Lily_Willow },
{ 0x994, Dell_Closeout },
{ 0x995, Amy_Spires },
{ 0x996, Peony_Cash },
{ 0x997, Gayle_Revel },
{ 0x998, Janine_Brook },
{ 0x99D, Colin_Binder },
{ 0x99E, Larry_Pogue },
{ 0x99F, Rob_Cardson },
{ 0x9A0, Ken_Mayfield },
{ 0x9A1, Casey_Leather },
{ 0x9A2, Ethan_Swallow },
{ 0x9A3, Bob_Daruma },
{ 0x9A4, Mitch_Blackston },
{ 0x9A5, Aurelia_Dingle },
{ 0x9A6, Canon_Evans },
{ 0x9A7, Syon_Blaze },
{ 0x9A8, Thor_Stoutberg },
{ 0x9A9, Nelly_Raimon },
{ 0x9AA, Celia_Hills },
{ 0x9AB, Silvia_Woods },
{ 0x9AC, Hidetoshi_Nakata },
{ 0x9C5, Curtis_Croon },
{ 0x9C6, Georgio_Plumber },
{ 0x9C7, Vince_Firewall },
{ 0x9C8, Roy_Diggins },
{ 0x9C9, Quill_Inker },
{ 0x9CA, Bertram_Manning },
{ 0x9CB, Laura_Quilter },
{ 0x9CC, Des_Igner },
{ 0x9CD, Jarmon_Fisk },
{ 0x9CE, Hugh_Tinter },
{ 0x9CF, Tim_Pression },
{ 0x9D0, Claire_Taker },
{ 0x9D1, Heath_Planner },
{ 0x9D2, Pace_Keeping },
{ 0x9D3, Arthur_Easley },
{ 0x9D4, Carl_Rhodes },
{ 0x9D5, Eugene_Conwell },
{ 0x9D6, Arnan_Wheelie },
{ 0x9D7, Stu_Boilin },
{ 0x9D8, Marvin_Reading },
{ 0x9D9, Callie_Graffy },
{ 0x9DA, Ant_Anomy },
{ 0x9DB, Laurie_Nowlin },
{ 0x9DC, Lucille_Strummon },
{ 0x9DD, Leon_Hotair },
{ 0x9DE, John_Bleach },
{ 0x9DF, Carey_Filling },
{ 0x9E0, Conn_Fuchus },
{ 0x9E1, Iain_Igma },
{ 0x9E2, Carrie_O_Kea },
{ 0x9E3, Ebirina },
{ 0x9E4, Stuart_Leafe },
{ 0x9E5, Cole_Stoaker },
{ 0x9E6, Justin_Primm },
{ 0x9E7, Mark_Smudge },
{ 0x9E8, Travis_Borer },
{ 0x9E9, Anton_Donce },
{ 0x9EA, Chase_Spoor },
{ 0x9EB, George_Barros },
{ 0x9EC, Olivia_Baker },
{ 0x9ED, Gem_Shorn },
{ 0x9EE, Lou_Daguerre },
{ 0x9EF, Ollie_Tuckney },
{ 0x9F0, Manuel_Kinart },
{ 0x9F1, Skip_Vinall },
{ 0x9F2, Junior_Gambit },
{ 0x9F3, Florian_Fauna },
{ 0x9F4, Clark_Tappen },
{ 0x9F5, Ryan_O_Laugh },
{ 0x9F6, Rod_Sweeper },
{ 0x9F7, Reg_Strimmer },
{ 0x9F8, Will_Ramin },
{ 0x9F9, Andy_Fudge },
{ 0x9FA, Tate_Immy },
{ 0x9FB, Gerald_Pourer },
{ 0x9FC, Nate_Checker },
{ 0x9FD, Bomber_Pikes },
{ 0x9FE, Gary_Burdine },
{ 0x9FF, Chloe_Glazier },
{ 0xA00, Reed_Harpen },
{ 0xA01, Beat_Scatton },
{ 0xA02, Al_Itchen },
{ 0xA03, Rock_Poulon },
{ 0xA04, Beau_Hammock },
{ 0xA05, Clef_Bassett },
{ 0xA06, Ovie_Whisker },
{ 0xA07, Bill_Clanger },
{ 0xA08, Mary_Cramer },
{ 0xA09, Ralph_Vance },
{ 0xA0A, Ray_Bowing },
{ 0xA0B, Vick_Pointer },
{ 0xA0C, Skip_Docker },
{ 0xA0D, Becky_Shuffle },
{ 0xA0E, Esther_Egerer },
{ 0xA0F, Mia_Pitchford },
{ 0xA10, Philippa_Konik },
{ 0xA11, Amy_Stinger },
{ 0xA12, Nancy_Polearm },
{ 0xA13, Sally_Tare },
{ 0xA14, Anna_Bugeisha },
{ 0xA15, Stu_Hoofer },
{ 0xA16, Coe_Dachy },
{ 0xA17, Flip_Sliden },
{ 0xA18, Jesse_Spiller },
{ 0xA19, Kate_Later },
{ 0xA1A, Clara_Tompkins },
{ 0xA1B, Betty_Backer },
{ 0xA1C, Thomas_Worth },
{ 0xA1D, Brenda_Brandish },
{ 0xA1E, Isla_Pullens },
{ 0xA1F, Bob_Jammen },
{ 0xA20, Hank_Cranker },
{ 0xA21, Prunella_Keep },
{ 0xA22, Jimmy_Brim },
{ 0xA23, Verity_Soliz },
{ 0xA24, Yve_Dunbar },
{ 0xA25, Cat_Selima },
{ 0xA26, Aurie_Garmer },
{ 0xA27, Lana_Service },
{ 0xA28, Claire_Voyant },
{ 0xA29, Algy_Kelp },
{ 0xA2A, Ann_Taisie },
{ 0xA2B, Kelly_Scrivens },
{ 0xA2C, Fern_Mycota },
{ 0xA2D, Lara_Creamer },
{ 0xA2E, Kim_Knotted },
{ 0xA2F, Nina_Trowel },
{ 0xA30, Harriet_Reaching },
{ 0xA31, Sadey_Stewer },
{ 0xA32, June_Stagner },
{ 0xA33, Lacey_Threader },
{ 0xA34, Marcy_Laise },
{ 0xA35, Bella_Shaded },
{ 0xA36, Walter_Trope },
{ 0xA37, Flora_Summars },
{ 0xA38, Lucia_Ander },
{ 0xA39, Rosy_Roker },
{ 0xA3A, Pam_Vision },
{ 0xA3B, Ruth_Karnes },
{ 0xA3C, Rose_Bedd },
{ 0xA3D, Bailey_Sitter },
{ 0xA3E, Adel_Tactor },
{ 0xA3F, Emma_Barres },
{ 0xA40, Orpah_Talkington },
{ 0xA41, Sable_Tatter },
{ 0xA42, Shu_Maimai },
{ 0xA43, Sym_Copate },
{ 0xA44, Jerry_Bateman },
{ 0xA45, Fonda_Katz },
{ 0xA46, Beck_Hand },
{ 0xA47, Sandra_Mudd },
{ 0xA48, Alexis_Watchorn },
{ 0xA49, Pete_Manter },
{ 0xA4A, Chris_Country },
{ 0xA4B, Paul_Steed },
{ 0xA4C, Ben_Whistler },
{ 0xA4D, Roman_Blac },
{ 0xA4E, Lewis_Brownie },
{ 0xA4F, Connor_Seuer },
{ 0xA50, Kaya_Haskell },
{ 0xA51, Minnie_Stratio },
{ 0xA52, Elegance_Stuckon },
{ 0xA53, Odette_Musetta },
{ 0xA54, Gertrude_Choker },
{ 0xA55, Polly_Targest },
{ 0xA56, Odessa_Ryder },
{ 0xA57, Robyn_Weaver },
{ 0xA58, Tess_Masters },
{ 0xA59, Cale_Sticklin },
{ 0xA5A, Farris_Stickman },
{ 0xA5B, Tim_Personator },
{ 0xA5C, Sherlock_Sagers },
{ 0xA5D, Ryan_Haywood },
{ 0xA5E, Osier_Twining },
{ 0xA5F, Rock_Scowlon },
{ 0xA60, Al_Stringer },
{ 0xA61, Bill_Fierce },
{ 0xA62, Rob_Otts },
{ 0xA63, Chad_Jowell },
{ 0xA64, Egon_Omercer },
{ 0xA65, Luis_Springs },
{ 0xA66, Bruce_Barkley },
{ 0xA67, Chip_Spacek },
{ 0xA68, Mason_Tirell },
{ 0xA69, Dale_Riverhead },
{ 0xA6A, Adelpha_Lovelace },
{ 0xA6B, Egon_Timing },
{ 0xA6C, Tony_Frogge },
{ 0xA6D, Fred_Punch },
{ 0xA6E, Hannibal_Whipp },
{ 0xA6F, Luke_Severin },
{ 0xA70, Harry_Keenan },
{ 0xA71, Nick_Uman },
{ 0xA72, Mac_Robat },
{ 0xA73, Ace_Slider },
{ 0xA74, Olivia_Twist },
{ 0xA75, Wiley_Blinks },
{ 0xA76, Shona_Shopbell },
{ 0xA77, Crystal_Clears },
{ 0xA78, Beata_Pummel },
{ 0xA79, Aya_Strand },
{ 0xA7A, Tara_Gaudier },
{ 0xA7B, James_Hearson },
{ 0xA7C, Anne_Somnia },
{ 0xA7D, Pearl_Wann },
{ 0xA7E, Hugh_Dunnit },
{ 0xA7F, Steve_Squander },
{ 0xA80, Lehman_Rind },
{ 0xA81, Ian_Fantile },
{ 0xA82, Zach_Putter },
{ 0xA83, Juan_Word },
{ 0xA84, Alex_Copple },
{ 0xA85, Jan_Jared },
{ 0xA86, Bigsby_Pigford },
{ 0xA87, Erica_Hogland },
{ 0xA88, Ramona_Wriston },
{ 0xA89, Mark_Izushy },
{ 0xA8A, Vince_Tinct },
{ 0xA8B, Daryl_Floor },
{ 0xA8C, Becca_Pilgreen },
{ 0xA8D, Langley_Span },
{ 0xA8E, Swithin_Sainte },
{ 0xA8F, Dan_Cawarry },
{ 0xA90, Hans_Freesing },
{ 0xA91, Peter_Fakhoury },
{ 0xA92, Steve_Sancey },
{ 0xA93, Michael_Gibe },
{ 0xA94, Skeet_Blaston },
{ 0xA95, Achilles_Chinner },
{ 0xA96, Scott_Tickle },
{ 0xA97, Junior_Cage },
{ 0xA98, Terry_Namby },
{ 0xA99, Joe_Chugger },
{ 0xA9A, Sonny_Cinders },
{ 0xA9B, Cash_Winfall },
{ 0xA9C, Lou_Fauntleroy },
{ 0xA9D, Carol_Chanter },
{ 0xA9E, Guy_Kogan },
{ 0xA9F, Max_Motto },
{ 0xAA0, Perry_Postiche },
{ 0xAA1, Nelson_Levene },
{ 0xAA2, Kurt_Sermons },
{ 0xAA3, Ed_Hartsell },
{ 0xAA4, Chester_Takes },
{ 0xAA5, Curtis_Rebell },
{ 0xAA6, Cody_Fink },
{ 0xAA7, Siria_Chattsley },
{ 0xAA8, Darren_Catt },
{ 0xAA9, Garry_Planer },
{ 0xAAA, Glenn_Broth },
{ 0xAAB, Harry_Angue },
{ 0xAAC, Benny_Terra },
{ 0xAAD, Jasmine_Veile },
{ 0xAAE, Belle_Allure },
{ 0xAAF, Doug_Lapp },
{ 0xAB0, Eric_Motter },
{ 0xAB1, Gyll_Netters },
{ 0xAB2, Farrah_Fairway },
{ 0xAB3, Jess_Winkles },
{ 0xAB4, Barbara_Clector },
{ 0xAB5, Marilyn_Henshaw },
{ 0xAB6, Nancy_Pickney },
{ 0xAB7, Clay_Turnor },
{ 0xAB8, Horace_Shlock },
{ 0xAB9, Sabrina_Passman },
{ 0xABA, Harpo_Thermier },
{ 0xABB, August_Dyers },
{ 0xABC, Nev_Puffer },
{ 0xABD, Elata_Mighty },
{ 0xABE, Ben_Danna },
{ 0xABF, Elsa_Roamer },
{ 0xAC0, Archy_Seago },
{ 0xAC1, Erhardt_Knead },
{ 0xAC2, Lynne_Mandel },
{ 0xAC3, Craig_Placid },
{ 0xAC4, Leon_Morcey },
{ 0xAC5, Dom_Edarry },
{ 0xAC6, Jay_Asher },
{ 0xAC7, Toby_Cohill },
{ 0xAC8, Nolene_Ider },
{ 0xAC9, Hoots_Knightly },
{ 0xACA, Bash_Beaton },
{ 0xACB, Terry_Toolan },
{ 0xACC, Callum_Biddy },
{ 0xACD, Alan_Sumner },
{ 0xACE, Trixy_Wonder },
{ 0xACF, Colet_First },
{ 0xAD0, Mac_Gabbon },
{ 0xAD1, Tip_Bolster },
{ 0xAD2, Draco_Scallon },
{ 0xAD3, Sofia_Brashier },
{ 0xAD4, Tam_Boyish },
{ 0xAD5, Mat_Halled },
{ 0xAD6, James_Strang },
{ 0xAD7, Ian_Watchen },
{ 0xAD8, Rose_Snelgrove },
{ 0xAD9, Bert_Emmerson },
{ 0xADA, Irving_Gusher },
{ 0xADB, Lionel_Silent },
{ 0xADC, Owen_Rage },
{ 0xADD, Alice_Nutty },
{ 0xADE, Conrad_Jacket },
{ 0xADF, Hilda_Bronski },
{ 0xAE0, Clint_Peacock },
{ 0xAE1, Pace_Maker },
{ 0xAE2, Vanity_Percy },
{ 0xAE3, Phil_Pagoda },
{ 0xAE4, Niki_Colbeck },
{ 0xAE5, Guy_Pinnay },
{ 0xAE6, Wayne_Fluke },
{ 0xAE7, Red_Dayers },
{ 0xAE8, Shay_Diebold },
{ 0xAE9, Tigh_Gerwhite },
{ 0xAEA, Cerise_Crane },
{ 0xAEB, Drack_Gorn },
{ 0xAEC, Terry_Pinn },
{ 0xAED, Justin_Cush },
{ 0xAEE, Bert_McClure },
{ 0xAEF, Richard_Trogg },
{ 0xAF0, Shirly_Quirk },
{ 0xAF1, Elias_Lens },
{ 0xAF2, Terry_Dryden },
{ 0xAF3, Ardel_Kernel },
{ 0xAF4, Carl_Belcher },
{ 0xAF5, Mal_Maroon },
{ 0xAF6, Ralph_Fary },
{ 0xAF7, Floyd_Spades },
{ 0xAF8, Remy_Diggun },
{ 0xAF9, Bern_Macmahon },
{ 0xAFA, Wally_Cooper },
{ 0xAFB, Griff_Hardcasel },
{ 0xAFC, Pat_Lubow },
{ 0xAFD, Wilma_Morgan },
{ 0xAFE, Carys_Chaparon },
{ 0xAFF, Claire_Hostess },
{ 0xB00, Katy_Punter },
{ 0xB01, Pete_Pimento },
{ 0xB02, Mary_Hugland },
{ 0xB03, Lee_Screener },
{ 0xB04, Camilla_Textor },
{ 0xB05, Bish_Beaton },
{ 0xB06, Simeon_Squareyes },
{ 0xB07, Stu_Borneman },
{ 0xB08, Herbie_Garnet },
{ 0xB09, Arvin_Inkwell },
{ 0xB0A, Rayce_Sprinton },
{ 0xB0B, Dreama_Bartle },
{ 0xB0C, Jane_Ledbelly },
{ 0xB0D, Dory_O_Bonn },
{ 0xB0E, Selma_Heaver },
{ 0xB0F, Kath_Leaflin },
{ 0xB10, Marg_Shuttle },
{ 0xB11, Duke_Scrubine },
{ 0xB12, Waylon_Tripp },
{ 0xB13, Jim_Bunner },
{ 0xB14, Jon_Izumo },
{ 0xB15, Del_Brighton },
{ 0xB16, Haden_Safe },
{ 0xB17, Lisle_Plotter },
{ 0xB18, Fen_Skates },
{ 0xB19, Rhoda_Dough },
{ 0xB1A, Neil_Seating },
{ 0xB1B, Flo_Nighting },
{ 0xB1C, Elinor_Maven },
{ 0xB1D, Kay_Gateley },
{ 0xB1E, Dexter_Caise },
{ 0xB1F, Serena_Besse },
{ 0xB20, Adrian_Heartly },
{ 0xB21, Cary_Fearless },
{ 0xB22, Wally_Waymire },
{ 0xB23, Ted_Autumn },
{ 0xB24, Boomer_Smolen },
{ 0xB25, Hank_Ershef },
{ 0xB26, Tim_Opener },
{ 0xB27, Hide_King },
{ 0xB28, Beth_Doodle },
{ 0xB29, Lamar_Bonesteel },
{ 0xB2A, Dom_Round },
{ 0xB2B, Chip_Stocks },
{ 0xB2C, Blake_Nailor },
{ 0xB2D, Dotty_Hickman },
{ 0xB2E, Wright_Tandem },
{ 0xB2F, Shaun_Bonnie },
{ 0xB30, Andrew_Hooper },
{ 0xB31, Toya_Boyde },
{ 0xB32, Taryn_Shyder },
{ 0xB33, Jasmin_Trier },
{ 0xB34, Dave_Lung },
{ 0xB35, Teal_Redsky },
{ 0xB36, Truman_Verdy },
{ 0xB37, Chance_Cerulean },
{ 0xB38, Amy_Peach },
{ 0xB39, Virgil_Amber },
{ 0xB3A, Grant_Stodgell },
{ 0xB3B, Payne_Outler },
{ 0xB3C, Malcolm_Shirker },
{ 0xB3D, Hanna_Slack },
{ 0xB3E, Dom_Poppy },
{ 0xB3F, Portia_Maricle },
{ 0xB40, Susan_Doiley },
{ 0xB41, Hannah_Breer },
{ 0xB42, Phil_Seebold },
{ 0xB43, Bobbie_Tomey },
{ 0xB44, Randolph_Lords },
{ 0xB45, Robin_Traylor },
{ 0xB46, Fawn_Blossom },
{ 0xB47, Isabell_Mish },
{ 0xB48, Rudy_Stemper },
{ 0xB49, Betty_Evenson },
{ 0xB4A, Harpo_Kendrick },
{ 0xB4B, Colin_Glower },
{ 0xB4C, Tailor_Wilden },
{ 0xB4D, Sim_Cebus },
{ 0xB4E, Sam_Banks },
{ 0xB4F, Frank_Homey },
{ 0xB50, Gregg_Deremer },
{ 0xB51, Verne_Spring },
{ 0xB52, Bryan_Klamm },
{ 0xB53, Colt_Youngstein },
{ 0xB54, Will_Kilmon },
{ 0xB55, Milly_Vacey },
{ 0xB56, Dany_Destiny },
{ 0xB57, Gary_Primo },
{ 0xB58, Bobby_Duo },
{ 0xB59, Stan_Treece },
{ 0xB5A, Lillie_Quattro },
{ 0xB5B, Eddy_Pentaris },
{ 0xB5C, Candice_Mell },
{ 0xB5D, Alex_Dauger },
{ 0xB5E, Joe_Divide },
{ 0xB5F, Sam_Willing },
{ 0xB60, Mary_Antoine },
{ 0xB61, Edward_Baron },
{ 0xB62, Tim_Platton },
{ 0xB63, Argento_Salvage },
{ 0xB64, Finn_Geld },
{ 0xB65, Ian_Moray },
{ 0xB66, Gil_Holden },
{ 0xB67, Doyle_Palmer },
{ 0xB68, Audry_Orange },
{ 0xB69, May_Apple },
{ 0xB6A, Ginny_White },
{ 0xB6B, Angus_Hogg },
{ 0xB6C, In_Chikita },
{ 0xB6D, Sabrina_Carow },
{ 0xB6E, Bob_Beelzy },
{ 0xB6F, Patt_Howell },
{ 0xB70, Ol_Factory },
{ 0xB71, Tom_Skipper },
{ 0xBB9, Austin_Hobbes },
{ 0xBBA, Archer_Hawkins },
{ 0xBBB, Isaac_Glass },
{ 0xBBC, Xavier_Foster },
{ 0xBBD, Caleb_Stonewall },
{ 0xBBE, Jordan_Greenway },
{ 0xBBF, Dave_Quagmire },
{ 0xBC0, Camellia_Travis },
{ 0xBC1, Andy },
{ 0xBC2, Hector_Helio_Little },
{ 0xBC3, Riku_Matsushita },
{ 0xBC4, Yuta_Kitajima },
{ 0xBC5, Natsuki_Yoshida },
{ 0xBC6, Riku_Ryu },
{ 0xBC7, Hector_Helio_Little2 },
{ 0xBCD, Gene_Whalon },
{ 0xBCE, David_Waterman },
{ 0xBCF, Sonny_Shore },
{ 0xBD0, Kjell_Snapper },
{ 0xBD1, Ken_Crackham },
{ 0xBD2, Shawn_Princeton },
{ 0xBD3, Matt_Fischer },
{ 0xBD4, Hank_Tennyson },
{ 0xBD5, Dolph_Hensen },
{ 0xBD6, Hamilton_Reith },
{ 0xBD7, Joe_Dawes },
{ 0xBD8, Quincy_Horace },
{ 0xBD9, Holly_Summers },
{ 0xBDA, Derek_Rabson },
{ 0xBDB, Barack_Daniels },
{ 0xBDC, Bruce_Marlin },
{ 0xBE1, Nasir_Mustafa },
{ 0xBE2, Faraz_Farooq },
{ 0xBE3, Bilal_Kalil },
{ 0xBE4, Jamila_Wali },
{ 0xBE5, Musa_Sylla },
{ 0xBE6, Yusuf_Massoud },
{ 0xBE7, Sulayk_Sulaiman },
{ 0xBE8, Sayid_Armand },
{ 0xBE9, Mansur_Jasim },
{ 0xBEA, Zack_Abdulla },
{ 0xBEB, Majdi_Ismail },
{ 0xBEC, Talal_Hamad },
{ 0xBED, Hasan_Ahmed },
{ 0xBEE, Khalfan_Jibril },
{ 0xBEF, Rajab_Ismail },
{ 0xBF0, Adel_Siddique },
{ 0xBF5, Jeongsu_Cho },
{ 0xBF6, Umi_Hwang_ },
{ 0xBF7, Dooyoon_Hong },
{ 0xBF8, Minho_Cho },
{ 0xBF9, Songhwan_Ko },
{ 0xBFA, Paekyeong_Park },
{ 0xBFB, Byron_Love },
{ 0xBFC, Eunyeong_Kim },
{ 0xBFD, Claude_Beacons },
{ 0xBFE, Changsu_Choi },
{ 0xBFF, Bryce_Whitingale },
{ 0xC00, Chi_Won_Ho },
{ 0xC01, Dong_Hyun_Seul },
{ 0xC02, Jung_Hoon_Yi },
{ 0xC03, Sung_Jin_Noh },
{ 0xC04, Joon_Ho_Ja },
{ 0xC09, Freddy_McQueen },
{ 0xC0A, Jonny_Gascoigne },
{ 0xC0B, David_Buckingham },
{ 0xC0C, Lance_Rawton },
{ 0xC0D, Edge_Ripper },
{ 0xC0E, Peter_Cole },
{ 0xC0F, Gary_Mane },
{ 0xC10, Paul_Appleton },
{ 0xC11, Eric_Purpleton },
{ 0xC12, Edgar_Partinus },
{ 0xC13, Phillip_Owen },
{ 0xC14, Servilius_Jeeves },
{ 0xC15, Martin_Squall },
{ 0xC16, Nick_Woodgate },
{ 0xC17, Mikey_Richards },
{ 0xC18, Sirius_Pounding },
{ 0xC1D, Indigo_Lazuli },
{ 0xC1E, Roseo_Diamante },
{ 0xC1F, Azubel_Turchese },
{ 0xC20, Nello_Agata },
{ 0xC21, Azzurro_Zaffiro },
{ 0xC22, Beldio_Smeraldo },
{ 0xC23, Rosso_Granato },
{ 0xC24, Giallo_Topazio },
{ 0xC25, Bianco_Perla },
{ 0xC26, Giulio_Acuto },
{ 0xC27, Violetto_Ametista },
{ 0xC28, Grigio_Quarzo },
{ 0xC29, Pardo_Berillo },
{ 0xC2A, Marrone_Corniola },
{ 0xC2B, Amaranto_Rubino },
{ 0xC2C, Avorio_Opale },
{ 0xC31, Jorge_Ortega },
{ 0xC32, Thiago_Torres },
{ 0xC33, Julio_Acosta },
{ 0xC34, Grande_Diaz },
{ 0xC35, Ramon_Martinez },
{ 0xC36, Esteban_Carlos },
{ 0xC37, Sergio_Perez },
{ 0xC38, Roberto_Torres },
{ 0xC39, Pablo_Castillo },
{ 0xC3A, Leone_Badigo },
{ 0xC3B, Diego_Oro },
{ 0xC3C, Lionel_Cruz },
{ 0xC3D, Mario_Saviola },
{ 0xC3E, Hernan_Tevez },
{ 0xC3F, Herman_Samuel },
{ 0xC40, Ricardo_Aguero },
{ 0xC45, Billy_Dash },
{ 0xC46, Ted_Bryant },
{ 0xC47, Tony_Strider },
{ 0xC48, Drake_Dynamo },
{ 0xC49, Bobby_Shearer_2 },
{ 0xC4A, Steve_Woodmark },
{ 0xC4B, Erik_Eagle_2 },
{ 0xC4C, Shane_Pierce },
{ 0xC4D, Mark_Krueger },
{ 0xC4E, Dylan_Keats },
{ 0xC4F, Gabriel_Jax },
{ 0xC50, Alex_Hawke },
{ 0xC51, Corey_Washington },
{ 0xC52, Bob_Bobbins },
{ 0xC53, Petie_Pooma },
{ 0xC54, Norbert_Poindexter },
{ 0xC59, Gigi_Blasi },
{ 0xC5A, Vento_Galliano },
{ 0xC5B, Ottorino_Nobili },
{ 0xC5C, Anton_Graziuso },
{ 0xC5D, Marco_Maserati },
{ 0xC5E, Angelo_Gabrini },
{ 0xC5F, Gianluca_Zanardi },
{ 0xC60, Giorgio_Giannini },
{ 0xC61, Dante_Diavolo },
{ 0xC62, Paolo_Bianchi },
{ 0xC63, Raffaele_Generani },
{ 0xC64, Daniele_Sanctis },
{ 0xC65, Enrico_Oliviero },
{ 0xC66, Alessandro_Rossa },
{ 0xC67, Giuseppe_Cannavaro },
{ 0xC68, Dino_Zolletta },
{ 0xC6D, Falcao_Da_Silva },
{ 0xC6E, Carlos_Lagarto },
{ 0xC6F, Antonio_Bagre },
{ 0xC70, Monstro_Ximenes },
{ 0xC71, Formiga_Clemens },
{ 0xC72, Presa_Passos },
{ 0xC73, Borboleta_Barboza },
{ 0xC74, Coruja_Cerezo },
{ 0xC75, Leonardo_Almeida },
{ 0xC76, Mac_Robingo },
{ 0xC77, Gato_Carvalho },
{ 0xC78, Xavier_Ribeiro },
{ 0xC79, Ulisses_Nogueira },
{ 0xC7A, Gervasio_Oliveira },
{ 0xC7B, Tigre_Mendes },
{ 0xC7C, Grillo_Santos },
{ 0xC81, Cyril_Fox },
{ 0xC82, Jacques_Allemand },
{ 0xC83, Phil_A__Minion },
{ 0xC84, Buddy_Plains },
{ 0xC85, Dean_Goddard },
{ 0xC86, Cecil_Crowley },
{ 0xC87, Seth_Hedges },
{ 0xC88, Niccolo_Mantegna },
{ 0xC89, Damien_Crawford },
{ 0xC8A, Avinash_Chowdhury },
{ 0xC8B, Sedgley_Scofield },
{ 0xC8C, Grizzler_Bruin },
{ 0xC8D, Ian_C__Wincy },
{ 0xC8E, Bandy_Horsman },
{ 0xC8F, Ali_Caiman },
{ 0xC90, Chris_Ellis },
{ 0xC95, Hector_Helio },
{ 0xC96, Zephyr_Vitesse },
{ 0xC97, Walter_Mountain },
{ 0xC98, Jimi_Gaines },
{ 0xC99, Ian_Ferrum },
{ 0xC9A, Quint_Hampton },
{ 0xC9B, Yasir_Haddad },
{ 0xC9C, Keith_Ryan },
{ 0xC9D, Maximino_Cruz },
{ 0xC9E, Gareth_Flare },
{ 0xC9F, Drago_Hill },
{ 0xCA0, Keenan_DiFortune },
{ 0xCA1, Jarell_Mangrove },
{ 0xCA2, Vic_Vitrum },
{ 0xCA3, Li_Leung },
{ 0xCA4, Jazzy_Hedgeer },
{ 0xCA9, Roger_Pialat },
{ 0xCAA, Kevin_Pinot },
{ 0xCAB, Michael_Aron },
{ 0xCAC, Francis_Poujol },
{ 0xCAD, Pierre_Godin },
{ 0xCAE, Roland_Perec },
{ 0xCAF, Julien_Rousseau },
{ 0xCB0, Stephane_Hinault },
{ 0xCB1, Romuald_Huysmans },
{ 0xCB2, Jerome_Hervaud },
{ 0xCB3, Alain_Favreau },
{ 0xCB4, Emile_Lazare },
{ 0xCB5, Andre_Pinson },
{ 0xCB6, Jean_Gutain },
{ 0xCB7, Claude_Moreau },
{ 0xCB8, Michel_Morland },
{ 0xCBD, Fermin_Sanchez },
{ 0xCBE, Jose_Costa },
{ 0xCBF, Rafael_Lopez },
{ 0xCC0, Antonio_Gallego },
{ 0xCC1, Queraldo_Naval },
{ 0xCC2, Juan_Nadal },
{ 0xCC3, Igor_Ferreira },
{ 0xCC4, Pedro_Moreno },
{ 0xCC5, Miguel_Pereira },
{ 0xCC6, Samuel_Mayo },
{ 0xCC7, Davi_Peroque },
{ 0xCC8, Juan_Espindola },
{ 0xCC9, Isaac_Cesar },
{ 0xCCA, Laudelino_Castor },
{ 0xCCB, Carlos_Arroyo },
{ 0xCCC, Federico_Rubiera },
{ 0xCD1, Thorsten_Welger },
{ 0xCD2, Alexander_Hausen },
{ 0xCD3, Heinrich_Farber },
{ 0xCD4, Kurt_Zawel },
{ 0xCD5, Lukas_Schmidt },
{ 0xCD6, Theodor_Ulrich },
{ 0xCD7, Jan_Oster },
{ 0xCD8, Niklas_Kuster },
{ 0xCD9, Jonas_Polk },
{ 0xCDA, Maximilian_Muller },
{ 0xCDB, Peter_Naumann },
{ 0xCDC, Gerhard_Enders },
{ 0xCDD, Erwin_Volz },
{ 0xCDE, Jens_Hoffman },
{ 0xCDF, Ernst_Fliedner },
{ 0xCE0, Emmanuel_Ewerz },
{ 0xCE5, Zolani_Baloi },
{ 0xCE6, Dakarai_Furman },
{ 0xCE7, Jake_Fana },
{ 0xCE8, Masego_Molelo },
{ 0xCE9, Cassius_Tobler },
{ 0xCEA, Anton_Nortje },
{ 0xCEB, Adam_Marunga },
{ 0xCEC, Reggie_Ines },
{ 0xCED, Siyabonga_Mahlangu },
{ 0xCEE, Nathan_Tswane },
{ 0xCEF, Melisizwe_Zamani },
{ 0xCF0, Herschel_De_Villiers },
{ 0xCF1, Moeneeb_Booysen },
{ 0xCF2, Kennedy_McCarthy },
{ 0xCF3, Hugh_Makebe },
{ 0xCF4, Themba_Sepeng },
{ 0xCF9, Decker_Pile },
{ 0xCFA, Chucky_Cardaway },
{ 0xCFB, Bernie_Ellement },
{ 0xCFC, Woody_Ellement },
{ 0xCFD, Gail_Ellement },
{ 0xCFE, Clay_Ellement },
{ 0xCFF, Neville_Goodenough },
{ 0xD00, Lucien_Rarey },
{ 0xD01, Stackem_Skyhigh },
{ 0xD02, Anfaira_D_vantage },
{ 0xD04, Walken_Ruhlbuch },
{ 0xD05, Saki_Shimizu },
{ 0xD06, Momoko_Tsugunaga },
{ 0xD07, Chinami_Tokunaga },
{ 0xD08, Maasa_Sudou },
{ 0xD09, Risako_Sugaya },
{ 0xD0A, Yurina_Kumai },
{ 0xD0B, Miyabi_Natsuyaki },
{ 0xD0C, Karl_Kappa },
{ 0xD21, Lars_Luceafar },
{ 0xD22, Lump_Trungus },
{ 0xD23, Bump_Trungus },
{ 0xD24, Oni_Triumvir },
{ 0xD25, Drachen_Gunther },
{ 0xD26, Mystral_Callous },
{ 0xD27, Radd_Ischer },
{ 0xD28, Escavan_Malice },
{ 0xD29, Bash_Lancer },
{ 0xD2A, Ichabod_Stark },
{ 0xD2B, Jynx_Jenkins },
{ 0xD49, Anorel },
{ 0xD4A, Nenel },
{ 0xD4B, Genel },
{ 0xD4C, Ekadel },
{ 0xD4D, Lephiel },
{ 0xD4E, Sachinel },
{ 0xD4F, Wenel },
{ 0xD50, Ientel },
{ 0xD51, Nuel },
{ 0xD52, Gaiel },
{ 0xD53, Sanctus },
{ 0xD5D, Astaroth },
{ 0xD5E, Bael },
{ 0xD5F, Abigor },
{ 0xD60, Behemoth },
{ 0xD61, Belial },
{ 0xD62, Malphas },
{ 0xD63, Glasya },
{ 0xD64, Jezebeth },
{ 0xD65, Arachne },
{ 0xD66, Thanatos },
{ 0xD67, Destra },
{ 0xD71, Astaroth },
{ 0xD72, Behemoth },
{ 0xD73, Bael },
{ 0xD74, Nenel },
{ 0xD75, Lephiel },
{ 0xD76, Malphas },
{ 0xD77, Thanatos },
{ 0xD78, Gaiel },
{ 0xD79, Wenel },
{ 0xD7A, Destra },
{ 0xD7B, Sanctus },
{ 0xE11, Percy_Verens },
{ 0xE12, Bishop_Carver },
{ 0xE13, Skyler_Styler },
{ 0xE14, Balen_Straw },
{ 0xE15, Malachi_Way },
{ 0xE16, Paul_Kerface },
{ 0xE17, Chip_Tatum },
{ 0xE18, Rebus_Stumper },
{ 0xE19, Cutter_Shorten },
{ 0xE1A, Manny_Pickles },
{ 0xE1B, Campen_Allerjee },
{ 0xE1C, Climie_Hills },
{ 0xE1D, Earl_Bird },
{ 0xE1E, Walt_Whittler },
{ 0xE1F, Merry_Piper },
{ 0xE20, Traylor_Beadle },
{ 0xE21, Doug_Boateng },
{ 0xE25, Fanny_Oakley },
{ 0xE26, Bucky_Colt },
{ 0xE27, Chuckie_Roper },
{ 0xE28, Lucien_Brightside },
{ 0xE29, Caffrey_Punt },
{ 0xE2A, Debra_Lee },
{ 0xE2B, Goodie_Touchouse },
{ 0xE2C, Ray_Pier },
{ 0xE2D, Jen_Erris },
{ 0xE2E, Jude_Ellery },
{ 0xE2F, Seamus_Rock },
{ 0xE30, Tim_Roubadour },
{ 0xE31, Matt_Skerade },
{ 0xE32, Florence_Tripps },
{ 0xE33, Inke_Marks },
{ 0xE34, Gary_Baldi },
{ 0xE35, Bobby_Peeler },
{ 0xE36, Mark_Brand },
{ 0xE37, Hedwig_Hodge },
{ 0xE38, Bill_Mallard },
{ 0xE39, Roo_Hopper },
{ 0xE3A, Cole_Bear },
{ 0xE3B, Al_Opino },
{ 0xE3C, Oz_Tier },
{ 0xE3D, Shelley_Wordsworth },
{ 0xE3E, Stu_Potter },
{ 0xE3F, Bern_Ballast },
{ 0xE40, Heidi_Rood },
{ 0xE41, Elvis_Schumacher },
{ 0xE42, Snezhana_White },
{ 0xE43, Abel_Forager },
{ 0xE44, Will_Wary },
{ 0xE45, Rocco_Shale },
{ 0xE46, Bob_Jobbe },
{ 0xE47, Lee_Bei },
{ 0xE48, Quincy_Wang },
{ 0xE49, Dan_Fei },
{ 0xE4A, Liddy_Gan },
{ 0xE4B, Tom_Bulldown },
{ 0xE4C, Ria_Vivalist },
{ 0xE4D, Sunniffa_Scentgood },
{ 0xE4E, Julia_Mason },
{ 0xE4F, Ria_Carnival },
{ 0xE50, Gracey_Grapples },
{ 0xE51, Shep_Woolacombe },
{ 0xE52, Sue_Accharin },
{ 0xE53, Venus_Demila },
{ 0xE54, Steven_Nevets },
{ 0xE55, Gerald_Gerund },
{ 0xE56, Tracy_Tracker },
{ 0xE57, Bernadette_Stoker },
{ 0xE58, Keshia_Readingplace },
{ 0xE59, Sahara_Kalahari },
{ 0xE5A, Fala_Polaris },
{ 0xE5B, Ian_Flappable },
{ 0xE5C, Penny_Linguine },
{ 0xE5D, Poppy_Playhard },
{ 0xE5E, Connie_Fuchsia },
{ 0xE5F, Baron_Blackgold },
{ 0xE60, Marty_Oshker },
{ 0xE61, Nat_Meg },
{ 0xE62, Eddy_Steady },
{ 0xE63, Severin_Volei },
{ 0xE64, Brava_Hardy },
{ 0xE65, Helmut_Hoarder },
{ 0xE66, Strama_daKoto },
{ 0xE67, Olaf_Nobeard },
{ 0xE68, Gudrun_Lodestone },
{ 0xE69, Carol_Fairfoot },
{ 0xE6A, Michael_Shako },
{ 0xE6B, Direm_Ederi },
{ 0xE6C, Marina_Coaster },
{ 0xE6D, Wowzer_Bigtop },
{ 0xE6E, Derry_Farmer },
{ 0xE6F, Devlin_Ogor },
{ 0xE70, Fez_Monkton },
{ 0xE71, Berthel_Stagg },
{ 0xE72, Damon_Sumner },
{ 0xE73, Anders_Thettock },
{ 0xE74, Laititia_Cheeseman },
{ 0xE75, Isodoura_Bouquet },
{ 0xE76, May_Jarrett },
{ 0xE77, Des_Einer },
{ 0xE78, Kev_Fiyah },
{ 0xE79, Shadi_Mesmer },
{ 0xE7A, Preston_Digitator },
{ 0xE7B, Roman_Fawkes },
{ 0xE7C, Morty_Portland },
{ 0xE7D, Fabrice_Pesci },
{ 0xE7E, Boo_Spector },
{ 0xE7F, Cole_Tivator },
{ 0xE80, Blagun_White },
{ 0xE81, Jeanie_Tanner },
{ 0xE82, Monty_Tasker },
{ 0xE83, Artie_Xan },
{ 0xE84, Genghis_Cohen },
{ 0xE85, Adam_Venturus },
{ 0xE86, Zahida_Zahid },
{ 0xE87, Zowie_Trope },
{ 0xE88, Roland_Lex },
{ 0xE89, Holly_Marx },
{ 0xE8A, Springer_Boreham },
{ 0xE8B, Kandhul_Lai },
{ 0xE8C, Kit_Fischer },
{ 0xE8D, Becks_Binder },
{ 0xE8E, Ralph_Chasing },
{ 0xE8F, Phil_Debonair },
{ 0xE90, Si_Sosman },
{ 0xE91, Aaron_Gossamer },
{ 0xE92, Pomponius_Fanfair },
{ 0xE93, Fanella_Waftgood },
{ 0xE94, Irina_Swift },
{ 0xE95, Rick_Shaw },
{ 0xE96, Montaine_Skalin },
{ 0xE97, Meowlinda_Purrsival },
{ 0xE98, Rune_Sigilsson },
{ 0xE99, Onslow_Mastick },
{ 0xE9A, Blowie_Armstraw },
{ 0xE9B, Paddy_Filler },
{ 0xE9C, Avid_Peddler },
{ 0xE9D, Woody_Prince },
{ 0xE9E, Demerara_Kane },
{ 0xE9F, Tiny_Jetson },
{ 0xEA0, Joe_Java },
{ 0xEA1, Wulf_Blackbean },
{ 0xEA2, Neville_Boyle },
{ 0xEA3, Ameen_Abel },
{ 0xEA4, Bombasta_Flamboyanzi },
{ 0xEA5, Fada_Prendi },
{ 0xEA6, Bella_Baker },
{ 0xEA7, Olivia_Palme },
{ 0xEA8, Gustav_Weathervane },
{ 0xEA9, Grover_Noggin },
{ 0xEAA, Blazer_Firefoot },
{ 0xEAB, Adam_Montayne },
{ 0xEAC, Chauncey_Slinka },
{ 0xEAD, Leighton_Bolt },
{ 0xEAE, Lucien_Thrope },
{ 0xEAF, Lenton_Gouger },
{ 0xEB0, Titania_Khamun },
{ 0xEB1, Eveline_Veitch },
{ 0xEB2, Eldritch_Priest },
{ 0xEB3, Gene_Bulge },
{ 0xEB4, Candy_Reviva },
{ 0xEB5, Pacey_Mack },
{ 0xEB6, Anil_Latikal },
{ 0xEB7, Indy_Ferrante },
{ 0xEB8, Stan_Tistischen },
{ 0xEB9, Simon_Borg },
{ 0xEBA, Clark_Phylen },
{ 0xEBB, Gram_Vineela },
{ 0xEBC, Yasser_Rightaway },
{ 0xEBD, Adora_Shivers },
{ 0xEBE, Roland_Allardyce },
{ 0xEBF, Lacy_Cagney },
{ 0xEC0, Justice_Gavel },
{ 0xEC1, Raleigh_Greenstreet },
{ 0xEC2, Melody_Toontune },
{ 0xEC3, Zip_Windrush },
{ 0xEC4, Buster_Lungs },
{ 0xEC5, Stanza_Verse },
{ 0xEC6, Dextra_Gleeson },
{ 0xEC7, Aidull_Wanabi },
{ 0xEC8, Earle_Humble },
{ 0xEC9, Rich_Fowler },
{ 0xECA, Rio_Shoring },
{ 0xECB, Joy_Seeker },
{ 0xECC, Haydn_Woe },
{ 0xECD, Levi_Atherton },
{ 0xECE, Flick_Screening },
{ 0xECF, Buff_Bagenal },
{ 0xED0, Mariah_Knowles },
{ 0xED1, Phil_Harmonic },
{ 0xED2, Ghoulian_Haunter },
{ 0xED3, Jacko_Lenton },
{ 0xED4, Dee_Tarrant },
{ 0xED5, Lee_Bartarian },
{ 0xED6, Amir_Rika },
{ 0xED7, Ewan_Envoi },
{ 0xED8, Jen_DeRites },
{ 0xED9, Judge_Jury },
{ 0xEDA, Leo_Maine },
{ 0xEDB, Scorpia_Venin },
{ 0xEDC, Noel_Taurius },
{ 0xEDD, Pan_Kidd },
{ 0xEDE, Cuba_Lieber },
{ 0xEDF, Arthur_Crabbe },
{ 0xEE0, Regina_Raffles },
{ 0xEE1, Ian_Fountry },
{ 0xEE2, Mark_Osman },
{ 0xEE3, Colin_Mando },
{ 0xEE4, Pete_Parrish },
{ 0xEE5, Serge_Major },
{ 0xEE6, Susan_Taylor },
{ 0xEE7, Keenan_Guru },
{ 0xEE8, Lovell_Ribner },
{ 0xEE9, Curtis_Carson },
{ 0xEEA, Falah_Hazbin },
{ 0xEEB, Marthin_Bannister },
{ 0xEEC, Orion_Tearing },
{ 0xEED, Reese_Fryer },
{ 0xEEE, Ben_Feuer },
{ 0xEEF, Edison_Ford },
{ 0xEF0, Eva_Chatton },
{ 0xEF1, Pezi_Miste },
{ 0xEF2, Preston_Creasefree },
{ 0xEF3, Anna_Mite },
{ 0xEF4, Bear_Zurka },
{ 0xEF5, Pasha_Lomo },
{ 0xEF6, Lennon_Trousers },
{ 0xEF7, Drysden_Waller },
{ 0xEF8, Zipp_Fastener },
{ 0xEF9, Brook_Dredger },
{ 0xEFA, Luke_Nohans },
{ 0xEFB, BA_Branssen },
{ 0xEFC, Fabrice_Soffner },
{ 0xEFD, Virgil_Milliner },
{ 0xEFE, Xenophon_Bick },
{ 0xEFF, Chandler_Spillane },
{ 0xF00, Monarch_Rome },
{ 0xF01, Sonny_Wukong },
{ 0xF02, Joe_Bajie },
{ 0xF03, Sean_Wujing },
{ 0xF04, Tony_Sanzang },
{ 0xF05, Helmut_Hardy },
{ 0xF06, Harley_Hogg },
{ 0xF07, Ezio_Ryder },
{ 0xF08, Tori_Torrence },
{ 0xF09, Placido_Cannes },
{ 0xF0A, Noyss_Kensler },
{ 0xF0B, Hedwig_Setter },
{ 0xF0C, Phineas_Hudd },
{ 0xF0D, Viking_Beagle },
{ 0xF0E, Seth_Paynter },
{ 0xF0F, Indira_Patil },
{ 0xF10, T_T__Mann },
{ 0xF11, Concordia_Choral },
{ 0xF12, Assumpta_Meakin },
{ 0xF13, Laurie_Driver },
{ 0xF14, Raine_Walker },
{ 0xF15, Martha_Hubbard },
{ 0xF16, Bernina_Nightoil },
{ 0xF17, Erik_Strongarm },
{ 0xF18, Gunnar_Boatwright },
{ 0xF19, Sigmund_Wayfinder },
{ 0xF1A, Grim_Jinxweaver },
{ 0xF1B, Tia_Cruz },
{ 0xF1C, Thomas_Oquendo },
{ 0xF1D, Reyes_Cabedo },
{ 0xF1E, Newt_Perfect },
{ 0xF1F, Carmen_Aria },
{ 0xF20, Dorian_Lucenzo },
{ 0xF21, Wesley_Provolone },
{ 0xF22, Joachim_Zooner },
{ 0xF23, Bjorn_Villen },
{ 0xF24, Theron_Starr },
{ 0xF25, Niall_Kuhn },
{ 0xF26, Graplen_Hawk },
{ 0xF27, Tribulus_Galtrop },
{ 0xF28, Sunil_Rahman },
{ 0xF29, Suphis_Cheops },
{ 0xF2A, Khefren_Chepren },
{ 0xF2B, Mykerinos_Menkh },
{ 0xF2C, Narcissa_Plane },
{ 0xF2D, Pauletta_Porter },
{ 0xF2E, Hattie_Couture },
{ 0xF2F, Urbana_Street },
{ 0xF30, Lovell_Lyons },
{ 0xF31, Pease_Marrowfat },
{ 0xF32, Ram_Horner },
{ 0xF33, Pius_Fisher },
{ 0xF34, Archie_Rider },
{ 0xF35, Virginia_Goldstein },
{ 0xF36, Norton_Waters },
{ 0xF37, Jen_Miniver },
{ 0xF38, Ernest_Goodman },
{ 0xF39, Galahad_Chevalier },
{ 0xF3A, Wanda_Spelling },
{ 0xF3B, Nick_Pincher },
{ 0xF3C, Marshall_Artison },
{ 0xF3D, Mary_Curey },
{ 0xF3E, Ian_Bick },
{ 0xF3F, Jib_Spinaker },
{ 0xF40, Odo_Riffeck },
{ 0xF41, Fox_Wiley },
{ 0xF42, Gladius_Swinger },
{ 0xF43, Asif_Ecks },
{ 0xF44, Roy_Ellway },
{ 0xF45, Scott_Amundsen },
{ 0xF46, Mike_Roscopy },
{ 0xF47, Gruff_Dorman },
{ 0xF48, Snowy_Bergman },
{ 0xF49, Tiger_Bleriot },
{ 0xF4A, Ugg_LeMugg },
{ 0xF4B, Hans_Popov },
{ 0xF4C, Norman_Zeus },
{ 0xF4D, Tommo_Marrow },
{ 0xF4E, Lyle_Covet },
{ 0xF4F, Graham_Dupree },
{ 0xF50, Dirk_Byker },
{ 0xF51, Charles_LeMans },
{ 0xF52, Walter_Carr },
{ 0xF53, Buzz_Scrambler },
{ 0xF54, Nifty_Throttler },
{ 0xF55, Kay_Emcee },
{ 0xF5B, Mark_Evans2 },
{ 0xF5C, Nathan_Swift2 },
{ 0xF5D, Jack_Wallside2 },
{ 0xF5E, Hurley_Kane2 },
{ 0xF5F, Scott_Banyan2 },
{ 0xF60, Thor_Stoutberg2 },
{ 0xF61, Xavier_Foster2 },
{ 0xF62, Caleb_Stonewall2 },
{ 0xF63, Jude_Sharp2 },
{ 0xF64, Axel_Blaze2 },
{ 0xF65, Shawn_Froste2 },
{ 0xF66, Darren_LaChance2 },
{ 0xF67, Kevin_Dragonfly_2 },
{ 0xF68, Austin_Hobbes2 },
{ 0xF69, Archer_Hawkins2 },
{ 0xF6A, David_Samford2 },
        };
        }
    }


}