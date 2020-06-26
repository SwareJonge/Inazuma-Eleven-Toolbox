using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InazumaElevenStatsExtractor.Utils
{
    public class ImporterClass
    {
        /*public struct Team
        {*/
        public string TeamName;
        public struct Player
        {
            public string TeamName;
            public ushort HEXid;
            public string FullName;
            public string NickName;
            public byte Element;

            public struct PlayerStats
            {
                public ushort MinFP;
                public ushort MaxFP;
                public ushort FPGrowthRate;
                public ushort MinTP;
                public ushort MaxTP;
                public ushort TPGrowthRate;

                public byte MinKick;
                public byte MaxKick;
                public ushort KickGrowthRate;

                public byte MinBody;
                public byte MaxBody;
                public ushort BodyGrowthRate;

                public byte MinGuard;
                public byte MaxGuard;
                public ushort GuardGrowthRate;

                public byte MinControl;
                public byte MaxControl;
                public ushort ControlGrowthRate;

                public byte MinSpeed;
                public byte MaxSpeed;
                public ushort SpeedGrowthRate;

                public byte MinGuts;
                public byte MaxGuts;
                public ushort GutsGrowthRate;

                public byte MinStamina;
                public byte MaxStamina;
                public ushort StaminaGrowthRate;

                public struct Moves
                {
                    public ushort Move1;
                    public ushort Move1ObtainLevel;

                    public ushort Move2;
                    public ushort Move2ObtainLevel;

                    public ushort Move3;
                    public ushort Move3btainLevel;

                    public ushort Move4;
                    public ushort Move4ObtainLevel;
                }

                public Moves MovesStruct;

                public ushort Maxtotal;

                public ushort Freedom()
                {
                    return (ushort)(Maxtotal - (MaxKick + MaxBody + MaxGuard + MaxControl + MaxSpeed + MaxGuts + MaxStamina));
                }

                public ushort StatsTotal()
                {
                    return (ushort)(MaxKick + MaxBody + MaxGuard + MaxControl + MaxSpeed + MaxGuts + MaxStamina);
                }

            }
            public PlayerStats PlayerStatsStruct;

        }
        public Player PlayerStruct;
        //}

    }
}
