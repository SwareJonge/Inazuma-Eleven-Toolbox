using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Dictionaries.ENG
{
    public class IECommonDictionary
    {
        public IDictionary<int, string> ElementToStr = new Dictionary<int, string>()
                {
                {0,"NPC"},
                     {1,"Wind"},
                     {2,"Wood"},
                     {3,"Fire"},
                     {4,"Earth"}
                };

        public IDictionary<int, string> GenderToString = new Dictionary<int, string>()
                {
                {0,"NPC"},
                     {1,"Male"},
                     {2,"Female"}
                };
        public string SizeToString(byte size)
        {
            switch (size)
            {
                case 0:
                    return "Normal";
                case 1:
                    return "Large";
                case 2:
                    return "Small";
                default:
                    return "NPC";
            }
        }


        public IDictionary<int, string> MoveToStr = new Dictionary<int, string>()
                {
{0x0, "None"},
{0x33, "Keeper Plus"},
{0x34, "Speed Plus"},
{0x35, "Shoot Plus"},
{0x36, "Defence Plus"},
{0x37, "Offence Plus"},
{0x38, "Recovery"},
{0x39, "Trickery!"},
{0x3A, "Charm Up!"},
{0x3B, "Cool Up!"},
{0x3C, "Economy!"},
{0x3D, "Big Moves!"},
{0x3E, "Power Element"},
{0x3F, "Study"},
{0x40, "Slack Off"},
{0x41, "Critical!"},
{0x42, "No Element"},
{0x43, "Lucky!"},
{0x44, "Jinx"},
{0x45, "Speed Force"},
{0x46, "Shot Force"},
{0x47, "Defence Force"},
{0x48, "Offence Force"},
{0x49, "Never Give Up"},
{0x4A, "Move It!"},
{0x4B, "Everyone Move It!"},
{0x4C, "Comeback Kid"},
{0x4D, "Put Your Back Into It!"},
{0x65, "Clone Faker"},
{0x66, "Flurry Dash"},
{0x67, "Whirlwind Twister"},
{0x68, "Illusion Ball"},
{0x69, "Dash Accelerator"},
{0x6A, "Rolling Hell"},
{0x6B, "Heat Tackle"},
{0x6C, "Zigzag Spark"},
{0x6D, "Rodeo Clown"},
{0x6E, "Black Magic"},
{0x6F, "Super Armadillo"},
{0x70, "Poison Fog"},
{0x71, "Attack Scan"},
{0x72, "Bewildered"},
{0x73, "Boost Glider"},
{0x74, "Afterimage"},
{0x75, "Mole Fake"},
{0x76, "Whirlwind Cut"},
{0x77, "Monkey Turn"},
{0x78, "The Wall"},
{0x79, "Diabolical Cut"},
{0x7A, "Killer Slide"},
{0x7B, "Coil Turn"},
{0x7C, "Earthquake"},
{0x7D, "Quick Draw"},
{0x7E, "Spider Web"},
{0x7F, "Cyclone"},
{0x80, "Fake Ball"},
{0x81, "Shadow Stitch"},
{0x82, "Sumo Stomp"},
{0x83, "Horn Train"},
{0x84, "Hurricane Arrows"},
{0x85, "Spinning Cut"},
{0x86, "Defence Scan"},
{0x87, "Ghost Pull"},
{0x88, "Doppelganger"},
{0x89, "Bamboo Pattern"},
{0x8A, "Harvest"},
{0x8B, "Divine Stamp"},
{0x8C, "Inazuma Drop"},
{0x8D, "Dragon Crash"},
{0x8E, "Twin Boost"},
{0x8F, "Fire Tornado"},
{0x90, "Wrath Shot"},
{0x91, "Inazuma-1"},
{0x92, "Grenade Shot"},
{0x93, "Death Zone"},
{0x94, "Phantom Shot"},
{0x95, "Hawk Shot"},
{0x96, "Meteor Attack"},
{0x97, "Snake Shot"},
{0x98, "Spinning Shot"},
{0x99, "Comet Shot"},
{0x9A, "Rolling Kick"},
{0x9B, "Clone Shot"},
{0x9C, "Dynamite Shot"},
{0x9D, "Patriot Shot"},
{0x9E, "Spiral Shot"},
{0x9F, "Freeze Shot"},
{0xA0, "Tiger Drive"},
{0xA1, "Tornado Catch"},
{0xA2, "God Hand(Earth)"},
{0xA3, "Power Shield"},
{0xA4, "Fireball Knuckle"},
{0xA5, "Shot Pocket"},
{0xA6, "Warp Space"},
{0xA7, "Counter Strike"},
{0xA8, "Sliding Goal"},
{0xA9, "Triple Defence"},
{0xAA, "Pressure Punch"},
{0xAB, "Toughness Block"},
{0xAC, "Full Power Shield"},
{0xAD, "Wood Chopper"},
{0xAE, "Whirlwind"},
{0xAF, "Rocket Kobushi"},
{0xB0, "Wild Claw"},
{0xB1, "Gigant Wall"},
{0xB2, "Mistral"},
{0xB3, "Killer Blade"},
{0xB4, "Tsunami Wall"},
{0xB5, "Blazing Knuckle"},
{0xB6, "Majin The Hand(Earth)"},
{0xB7, "Infinite Wall"},
{0xB8, "Snow Angel"},
{0xB9, "Barbarian Shield"},
{0xBA, "Majin The Hand(Wood)"},
{0xBB, "God Hand(Wood)"},
{0xBC, "Ground Quake"},
{0xBD, "Desert Blast"},
{0xBE, "Cross Drive"},
{0xBF, "Teleport Shot"},
{0xC0, "Psycho Shot"},
{0xC1, "Condor Dive"},
{0xC2, "Run Ball Run"},
{0xC3, "Triangle Z"},
{0xC4, "Utter Gutsiness Bat"},
{0xC5, "Reflect Buster"},
{0xC6, "Kung Fu Header"},
{0xC7, "Shine Drive"},
{0xC8, "Divine Arrows"},
{0xC9, "Back Tornado"},
{0xCA, "Tarzan Kick"},
{0xCB, "God Knows"},
{0xCC, "Dragon Tornado"},
{0xCD, "Dirt Ball"},
{0xCE, "Fire Rooster"},
{0xCF, "Inazuma Break"},
{0xD0, "The Galaxy"},
{0xD1, "Emperor Penguin No. 2"},
{0xD2, "Heaven’s Time"},
{0xD3, "Breakthrough"},
{0xD4, "Dash Storm"},
{0xD5, "Moonsault"},
{0xD6, "Magic"},
{0xD7, "The Phoenix"},
{0xD8, "Baby Dragon"},
{0xD9, "Dark Tornado"},
{0xDC, "Am-Bush"},
{0xDD, "Gravestone"},
{0xDE, "Racing Flame"},
{0xDF, "Iron Wall"},
{0xE0, "Power Charge"},
{0xE1, "Vac Attack"},
{0xE2, "Yo-Yo Ball"},
{0xE3, "Rolling Slide"},
{0xE5, "Stone Prison"},
{0xE6, "Mega Quake"},
{0xE7, "Blade Attack"},
{0xE8, "About Face"},
{0xE9, "Excalibur"},
{0xEA, "Hellfire"},
{0xEB, "The Typhoon"},
{0xEC, "Whirlwind Drop"},
{0xED, "Thunder Beast"},
{0xEE, "Tiger Storm"},
{0xEF, "Dragon Slayer"},
{0xF0, "Gladius Arch"},
{0xF1, "Emperor Penguin No. 3"},
{0xF2, "Grand Fenrir"},
{0xF3, "Odin Sword"},
{0xF4, "Heavenly Drive"},
{0xF5, "Samba Strike"},
{0xF6, "The Dawn"},
{0xF7, "Big Bang"},
{0xF8, "The Hurricane"},
{0xF9, "Megalodon"},
{0xFA, "Paladin Strike"},
{0xFD, "Gunshot"},
{0xFE, "Fireball Screw"},
{0xFF, "Mirage Shot"},
{0x100, "Pegasus Shot"},
{0x101, "Unicorn Boost"},
{0x102, "Jet Stream"},
{0x103, "Grand Fire"},
{0x104, "Brave Shot"},
{0x105, "Eternal Blizzard"},
{0x106, "Fireball Storm"},
{0x107, "Tsunami Boost"},
{0x108, "Death Zone 2"},
{0x109, "The Earth"},
{0x10A, "Rainbow Arc"},
{0x10B, "Astro Break"},
{0x10C, "Acrobat Bomber"},
{0x10D, "Kung Fu Fighting"},
{0x10E, "Double Grenade"},
{0x10F, "Gyro Head"},
{0x110, "Revolution V"},
{0x111, "Heel Kick"},
{0x112, "Dragon Cannon"},
{0x113, "Dual Strike"},
{0x114, "Legendary Wolf"},
{0x115, "Emperor Penguin No. 1"},
{0x116, "Bed Of Roses"},
{0x117, "Utter Gutsiness Club"},
{0x118, "Double Wrath Shot"},
{0x119, "Land Dragon"},
{0x11A, "Tri-Pegasus"},
{0x11B, "Inazuma-1 Drop"},
{0x11C, "Ganymede Ray"},
{0x11D, "Leaping Thunder"},
{0x11E, "Eagle Buster"},
{0x11F, "Butterfly Trance"},
{0x120, "Cosmic Blast"},
{0x121, "Gaia Break"},
{0x122, "Spectacle Crash"},
{0x123, "Twin Boost F"},
{0x124, "Double Tornado"},
{0x125, "Security Shot"},
{0x126, "Supernova"},
{0x127, "Space Penguin"},
{0x128, "Wyvern Crash"},
{0x129, "Wyvern Blizzard"},
{0x12A, "Cross Fire(Fire)"},
{0x12B, "Dark Phoenix"},
{0x12C, "Triple Boost"},
{0x12D, "Neo Galaxy"},
{0x12E, "Assault Shot"},
{0x12F, "God Break"},
{0x130, "Megaton Head"},
{0x131, "Steeple Shot"},
{0x132, "Meteor Blade"},
{0x133, "Gungnir"},
{0x134, "Atomic Flare"},
{0x135, "Northern Impact"},
{0x136, "Fire Blizzard(Fire)"},
{0x137, "Cross Fire(Wind)"},
{0x138, "Fire Blizzard(Wind)"},
{0x139, "Meteor Blade"}, // Non alien form, unused
{0x13A, "Chaos Break"},
{0x13B, "Astro Gate"},
{0x13C, "Double Jaw"},
{0x13D, "Eiffel Tower"}, // Unused in the European version of IE3, however you can get a move manual for it with cheats or save file edits
{0x13E, "Slingshot"},
{0x13F, "Sweet Deal"},
{0x140, "Emperor Penguin X"},
{0x141, "Deceptor Dribble"},
{0x142, "Invisible Fake"},
{0x143, "Gale Dash"},
{0x144, "Three-Legged Rush"},
{0x145, "Aurora Dribble"},
{0x146, "Double Touch"},
{0x147, "Dual Pass"},
{0x148, "Bubble Gum"},
{0x149, "Prima Donna"},
{0x14A, "Armadillo Circus"},
{0x14B, "Breakthrough 2"},
{0x14C, "Triple Dash"},
{0x14D, "Lightning Sprint"},
{0x14E, "Aikido"},
{0x14F, "Mole Shuffle"},
{0x150, "Dark Whirlwind"},
{0x151, "Warp Drive"},
{0x152, "Meteor Shower"},
{0x153, "Southern Cross"},
{0x154, "Ribbon Shower"},
{0x155, "Big Fan"},
{0x156, "Flame Veil"},
{0x157, "Water Veil"},
{0x158, "Field of Force"},
{0x159, "Kangaroo Kick"},
{0x15A, "Abaddon Drop"},
{0x15B, "Bewilder Blast"},
{0x15C, "The Ikaros"},
{0x15D, "Nightmare Trap"},
{0x15E, "Wind God’s Dance"},
{0x15F, "Card Slap"},
{0x160, "Matador Feint"},
{0x161, "Super Elastico"},
{0x162, "Echo Ball"},
{0x163, "Liar Shot"},
{0x164, "Air Ride"},
{0x165, "Breakthrough 3"},
{0x166, "Dog Run"},
{0x167, "Sub-Terfuge"},
{0x168, "Ultra Moon"},
{0x169, "Shooting Star"},
{0x16A, "Land Of Ice"},
{0x16B, "Clone Defence"},
{0x16C, "Circus Block"},
{0x16D, "Heavy Mettle"},
{0x16E, "The Tower"},
{0x16F, "Photon Crash"},
{0x170, "Gravitation"},
{0x171, "Dual Storm"},
{0x172, "Supreme Spin"},
{0x173, "Fake Bomber"},
{0x174, "Volcano Cut"},
{0x175, "Super Sumo Stomp"},
{0x176, "Planet Shield"},
{0x177, "Sigma Zone"},
{0x178, "Double Cyclone"},
{0x179, "No Escape"},
{0x17A, "Flame Dance"},
{0x17B, "Asteroid Belt"},
{0x17C, "Body Shield"},
{0x17D, "Perimeter Zone"},
{0x17E, "Mega Wall"},
{0x17F, "Road Roller"},
{0x180, "Sleeping Dust"},
{0x181, "Ignite Steal"},
{0x182, "Whale Guard"},
{0x183, "Whirlwind Force"},
{0x184, "Mad Express"},
{0x185, "Frozen Steal"},
{0x186, "Stone Wall"},
{0x187, "Perfect Tower"},
{0x188, "The Mountain"},
{0x189, "Zigzag Flame"},
{0x18A, "Heaven’s Ascent"},
{0x18B, "Hell’s Descent"},
{0x191, "Mugen The Hand"},
{0x192, "Utter Gutsiness Catch"},
{0x193, "Fireball Head"},
{0x194, "Aurora Curtain"},
{0x195, "Table-Turner"},
{0x196, "Flame Breath"},
{0x197, "Beast Fang"},
{0x198, "Drill Smasher"},
{0x199, "Clone Block"},
{0x19A, "Dimensional Hand"},
{0x19B, "Claw Slash"},
{0x19C, "Dual Smash"},
{0x19D, "Double Rocket"},
{0x19E, "Flower Power"},
{0x19F, "Swan Dive"},
{0x1A0, "Triple God Hand"},
{0x1A1, "Black Hole"},
{0x1A2, "Safety First"},
{0x1A3, "Wormhole"},
{0x1A4, "Temporal Wall"},
{0x1A5, "Procyon Net"},
{0x1A6, "Fist of Justice"},
{0x1A7, "Burnout"},
{0x1A8, "Ice Block"},
{0x1A9, "Hammer of Fury"},
{0x1AA, "Soul Hand"},
{0x1AB, "God Hand X"},
{0x1AC, "Fiend Hand"},
{0x1AD, "God Catch"},
{0x1AE, "Storm Rider"},
{0x1AF, "Flash Upper"},
{0x1B0, "Nitro Slap"},
{0x1B1, "Barrier Reef"},
{0x1B2, "Giant Spider"},
{0x1B3, "Galatyn"},
{0x1B4, "Colosseum Guard"},
{0x1B5, "Million Hands"},
{0x1B6, "Capoeira Grab"},
{0x1B7, "The Stinger"},
{0x1B8, "Shot Trap"},
{0x1B9, "Card Protector"},
{0x1BA, "High Voltage"},
{0x1BB, "Omega Hand"},
{0x1BC, "Electrap"},
{0x1BD, "Celestial Zone"},
{0x1BE, "The End"},
{0x1BF, "Needle Hammer"},
{0x1C3, "Remote Combustion"},
{0x1C4, "X-Blast"},
{0x1C5, "Almighty Cannon"},
{0x1C6, "Dark Matter"},
{0x1C7, "Shadow Ray(Wood)"},
{0x1C8, "Maximum Fire"},
{0x1C9, "Prime Legend"},
{0x1CA, "Doom Rain"},
{0x1CB, "Doom Spear"},
{0x1CC, "Doom Break"},
{0x1CD, "Shadow Ray(Earth)"},
{0x1CE, "Celestial Smash"},
{0x1CF, "Clone Death Zone"},
{0x1D0, "Clone Penguin"},
{0x1D7, "Angel Ball"},
{0x1D8, "Devil Ball"}
                };

        public string PosByteToString(byte Pos)
        {
            if (Pos >= 0x80 && Pos <= 0x88)
            {
                return "FW";
            }
            else if (Pos >= 0x60 && Pos <= 0x68)
            {
                return "MF";
            }
            else if (Pos >= 0x40 && Pos <= 0x48)
            {
                return "DF";
            }
            else if (Pos >= 0x20 && Pos <= 0x28)
            {
                return "GK";
            }
            else
            {

                return "NPC";
            }
        }

        public ushort calcLevelDone(ushort GrowthRate)
        {
            ushort Rate = GrowthRate;
            if (GrowthRate == 1)
            {
                Rate = 3;
            }
            if (GrowthRate == 3)
            {
                Rate = 1;
            }
            return (ushort)(49 + (Rate * 10));
        }

        public byte IsAboveMaxLevel(byte curLevel, byte MaxStatLevel)
        {
            byte level = curLevel;
            if(curLevel > MaxStatLevel)
            {
                level = MaxStatLevel;
            }

            return (byte)(level - 1);
        }

        public string MoveObtainLevel(ushort ObtainLevel)
        {
            if (ObtainLevel == 100)
            {
                return "Event";
            }
            else return "Lv." + ObtainLevel.ToString();
        }
    }
}
