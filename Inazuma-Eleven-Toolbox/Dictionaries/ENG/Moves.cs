using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inazuma_Eleven_Toolbox.Dictionaries.ENG
{


    class Moves
    {




        public int GetMaxMoveLevel(string EvolveType)
        {
            if (EvolveType == "L (Fast)" || EvolveType == "L (Slow)" || EvolveType == "L (Medium)")
            {
                return 5;
            }
            else if (EvolveType == "Shin (Fast)" || EvolveType == "Shin (Slow)" || EvolveType == "Shin (Medium)")
            {
                return 2;
            }
            else if (EvolveType == "V (Fast)" || EvolveType == "V (Slow)" || EvolveType == "V (Medium)")
            {
                return 2;
            }
            else return 0;
        }

        public int GetMinMoveLevel(string EvolveType)
        {
            if (EvolveType == "L (Fast)" || EvolveType == "L (Slow)" || EvolveType == "L (Medium)")
            {
                return 1;
            }
            else if (EvolveType == "Shin (Fast)" || EvolveType == "Shin (Slow)" || EvolveType == "Shin (Medium)")
            {
                return 0;
            }
            else if (EvolveType == "V (Fast)" || EvolveType == "V (Slow)" || EvolveType == "V (Medium)")
            {
                return 0;
            }
            else return 0;
        }

        public int GetCurrentMoveLevel(byte TimesUsed, string EvolveType)
        {
            if (EvolveType == "Shin (Medium)" || EvolveType == "V (Medium)")
            {
                if (TimesUsed < 9)
                {
                    return 0;
                }
                else if (TimesUsed < 27)
                {
                    return 1;
                }
                else return 2;
            }
            else if (EvolveType == "Shin (Fast)" || EvolveType == "V (Fast)")
            {
                if (TimesUsed < 6)
                {
                    return 0;
                }
                else if (TimesUsed < 21)
                {
                    return 1;
                }
                else return 2;
            }
            else if (EvolveType == "Shin (Slow)" || EvolveType == "V (Slow)")
            {
                if (TimesUsed < 15)
                {
                    return 0;
                }
                else if (TimesUsed < 33)
                {
                    return 1;
                }
                else return 2;
            }
            else if (EvolveType == "L (Medium)")
            {
                if (TimesUsed < 20)
                {
                    return 1;
                }
                else if (TimesUsed < 40)
                {
                    return 2;
                }
                else if (TimesUsed < 60)
                {
                    return 3;
                }
                else if (TimesUsed < 90)
                {
                    return 4;
                }
                else return 5;
            }
            else if (EvolveType == "L (Fast)")
            {
                if (TimesUsed < 15)
                {
                    return 1;
                }
                else if (TimesUsed < 35)
                {
                    return 2;
                }
                else if (TimesUsed < 55)
                {
                    return 3;
                }
                else if (TimesUsed < 80)
                {
                    return 4;
                }
                else return 5;
            }
            else if (EvolveType == "L (Slow)")
            {
                if (TimesUsed < 20)
                {
                    return 1;
                }
                else if (TimesUsed < 45)
                {
                    return 2;
                }
                else if (TimesUsed < 70)
                {
                    return 3;
                }
                else if (TimesUsed < 100)
                {
                    return 4;
                }
                else return 5;
            }
            else return 0;
        }

        public byte SetNewLevel(decimal Level, string EvolveType)
        {
            if (EvolveType == "L (Slow)")
            {
                switch (Level)
                {
                    case 2:
                        return 20;
                    case 3:
                        return 45;
                    case 4:
                        return 70;
                    case 5:
                        return 100;
                    default:
                        return 0;
                }

            }
            else if (EvolveType == "L (Medium)")
            {
                switch (Level)
                {
                    case 2:
                        return 20;
                    case 3:
                        return 40;
                    case 4:
                        return 60;
                    case 5:
                        return 90;
                    default:
                        return 0;
                }
            }
            else if (EvolveType == "L (Fast)")
            {
                switch (Level)
                {
                    case 2:
                        return 15;
                    case 3:
                        return 35;
                    case 4:
                        return 55;
                    case 5:
                        return 80;
                    default:
                        return 0;
                }
            }
            else if (EvolveType == "Shin (Medium)" || EvolveType == "V (Medium)")
            {
                switch (Level)
                {
                    case 1:
                        return 9;
                    case 2:
                        return 27;
                    default:
                        return 0;
                }
            }
            else if (EvolveType == "Shin (Fast)" || EvolveType == "V (Fast)")
            {
                switch (Level)
                {
                    case 1:
                        return 6;
                    case 2:
                        return 21;
                    default:
                        return 0;
                }
            }
            else if (EvolveType == "Shin (Slow)" || EvolveType == "V (Slow)")
            {
                switch (Level)
                {
                    case 1:
                        return 15;
                    case 2:
                        return 33;
                    default:
                        return 0;
                }
            }
            else return 0;


        }


        public IDictionary<string, string> IE2MoveGrowth = new Dictionary<string, string>
        {
{ "The Earth", "L (Fast)" },
{ "Gaia Break", "Shin (Fast)" },
{ "Reflect Buster", "Shin (Medium)" },
{ "Eagle Buster", "Shin (Slow)" },
{ "Land Dragon", "Shin (Slow)" },
{ "Butterfly Trance", "Shin (Slow)" },
{ "Megaton Head", "L (Fast)" },
{ "Utter Gutsiness Club", "Shin (Fast)" },
{ "Spectacle Crash", "Shin (Slow)" },
{ "Kung Fu Fighting", "Shin (Medium)" },
{ "Leaping Thunder", "Shin (Medium)" },
{ "Rainbow Arc", "Shin (Medium)" },
{ "Gyro Head", "Shin (Medium)" },
{ "Dirt Ball", "Shin (Medium)" },
{ "Teleport Shot", "Shin (Medium)" },
{ "Tarzan Kick", "Shin (Medium)" },
{ "Snake Shot", "Shin (Fast)" },
{ "Neo Galaxy", "Shin (Medium)" },
{ "Fire Blizzard(Fire)", "Shin (Medium)" },
{ "Cross Fire(Wind)", "Shin (Medium)" },
{ "The Galaxy", "Shin (Slow)" },
{ "Fireball Storm", "L (Medium)" },
{ "Triple Boost", "Shin (Fast)" },
{ "Atomic Flare", "Shin (Fast)" },
{ "The Phoenix", "Shin (Slow)" },
{ "Twin Boost F", "Shin (Medium)" },
{ "Triangle Z", "Shin (Fast)" },
{ "Fire Rooster", "Shin (Medium)" },
{ "Meteor Blade", "Shin (Medium)" },
{ "Assault Shot", "Shin (Medium)" },
{ "Dragon Cannon", "Shin (Medium)" },
{ "Dragon Tornado", "Shin (Fast)" },
{ "Twin Boost", "Shin (Slow)" },
{ "Steeple Shot", "Shin (Slow)" },
{ "Utter Gutsiness Bat", "Shin (Slow)" },
{ "Shine Drive", "Shin (Medium)" },
{ "Dynamite Shot", "Shin (Medium)" },
{ "Double Grenade", "Shin (Medium)" },
{ "Patriot Shot", "Shin (Slow)" },
{ "Fire Tornado", "Shin (Fast)" },
{ "Meteor Attack", "Shin (Medium)" },
{ "Heel Kick", "Shin (Slow)" },
{ "Grenade Shot", "Shin (Medium)" },
{ "Cross Fire(Fire)", "Shin (Medium)" },
{ "Fire Blizzard(Wind)", "Shin (Medium)" },
{ "Space Penguin", "Shin (Fast)" },
{ "God Break", "L (Medium)" },
{ "Inazuma-1 Drop", "Shin (Fast)" },
{ "Legendary Wolf", "L (Medium)" },
{ "Northern Impact", "Shin (Fast)" },
{ "Wyvern Blizzard", "Shin (Slow)" },
{ "Tri-Pegasus", "Shin (Medium)" },
{ "God Knows", "Shin (Medium)" },
{ "Gungnir", "Shin (Medium)" },
{ "Divine Arrows", "Shin (Slow)" },
{ "Inazuma Break", "Shin (Fast)" },
{ "Revolution V", "Shin (Fast)" },
{ "Tsunami Boost", "Shin (Fast)" },
{ "Inazuma-1", "Shin (Medium)" },
{ "Eternal Blizzard", "Shin (Medium)" },
{ "Inazuma Drop", "Shin (Fast)" },
{ "Hawk Shot", "Shin (Medium)" },
{ "Back Tornado", "Shin (Medium)" },
{ "Baby Dragon", "Shin (Fast)" },
{ "Cross Drive", "Shin (Medium)" },
{ "Condor Dive", "Shin (Medium)" },
{ "Comet Shot", "Shin (Slow)" },
{ "Spiral Shot", "Shin (Medium)" },
{ "Spinning Shot", "Shin (Medium)" },
{ "Supernova", "Shin (Fast)" },
{ "Dark Phoenix", "Shin (Fast)" },
{ "Death Zone 2", "L (Fast)" },
{ "Emperor Penguin No. 1", "L (Slow)" },
{ "Double Tornado", "Shin (Medium)" },
{ "Death Zone", "Shin (Fast)" },
{ "Cosmic Blast", "Shin (Slow)" },
{ "Emperor Penguin No. 2", "Shin (Fast)" },
{ "Wyvern Crash", "Shin (Fast)" },
{ "Ganymede Ray", "Shin (Slow)" },
{ "Dual Strike", "Shin (Medium)" },
{ "Clone Shot", "Shin (Medium)" },
{ "Double Wrath Shot", "Shin (Fast)" },
{ "Astro Break", "Shin (Medium)" },
{ "Security Shot", "Shin (Medium)" },
{ "Acrobat Bomber", "Shin (Slow)" },
{ "Dark Tornado", "Shin (Medium)" },
{ "Kung Fu Header", "Shin (Medium)" },
{ "Bed Of Roses", "Shin (Fast)" },
{ "Freeze Shot", "Shin (Medium)" },
{ "Dragon Crash", "Shin (Fast)" },
{ "Run Ball Run", "Shin (Fast)" },
{ "Wrath Shot", "Shin (Medium)" },
{ "Phantom Shot", "Shin (Medium)" },
{ "Psycho Shot", "Shin (Medium)" },
{ "Rolling Kick", "Shin (Fast)" },
{ "Infinite Wall", "L (Medium)" },
{ "Gigant Wall", "Shin (Slow)" },
{ "Triple Defence", "Shin (Fast)" },
{ "Majin The Hand(Earth)", "Shin (Fast)" },
{ "Table-Turner", "Shin (Medium)" },
{ "Utter Gutsiness Catch", "Shin (Slow)" },
{ "Sliding Goal", "Shin (Slow)" },
{ "God Hand(Earth)", "Shin (Slow)" },
{ "Wild Claw", "Shin (Medium)" },
{ "Wood Chopper", "Shin (Medium)" },
{ "Toughness Block", "Shin (Medium)" },
{ "Beast Fang", "L (Slow)" },
{ "Triple God Hand", "L (Fast)" },
{ "Burnout", "Shin (Medium)" },
{ "Drill Smasher", "Shin (Fast)" },
{ "Double Rocket", "Shin (Medium)" },
{ "Counter Strike", "Shin (Medium)" },
{ "Flame Breath", "Shin (Medium)" },
{ "Blazing Knuckle", "Shin (Medium)" },
{ "Full Power Shield", "Shin (Medium)" },
{ "Fireball Head", "Shin (Medium)" },
{ "Rocket Kobushi", "Shin (Medium)" },
{ "Power Shield", "Shin (Fast)" },
{ "Pressure Punch", "Shin (Medium)" },
{ "Fireball Knuckle", "Shin (Fast)" },
{ "Fist of Justice", "L (Medium)" },
{ "Temporal Wall", "Shin (Slow)" },
{ "Procyon Net", "Shin (Medium)" },
{ "Ice Block", "Shin (Medium)" },
{ "Tsunami Wall", "Shin (Medium)" },
{ "Safety First", "Shin (Medium)" },
{ "Aurora Curtain", "Shin (Fast)" },
{ "Whirlwind", "Shin (Medium)" },
{ "Flower Power", "Shin (Slow)" },
{ "Mistral", "Shin (Medium)" },
{ "Tornado Catch", "Shin (Fast)" },
{ "Swan Dive", "Shin (Medium)" },
{ "Mugen The Hand", "L (Slow)" },
{ "Clone Block", "Shin (Medium)" },
{ "Dual Smash", "Shin (Medium)" },
{ "Majin The Hand(Wood)", "Shin (Fast)" },
{ "Wormhole", "Shin (Medium)" },
{ "Black Hole", "Shin (Fast)" },
{ "Claw Slash", "Shin (Slow)" },
{ "God Hand(Wood)", "Shin (Slow)" },
{ "Shot Pocket", "Shin (Fast)" },
{ "Warp Space", "Shin (Medium)" },
{ "Killer Blade", "Shin (Slow)" },
{ "Triple Dash", "Shin (Fast)" },
{ "Three-Legged Rush", "Shin (Medium)" },
{ "Rolling Hell", "Shin (Slow)" },
{ "Mole Shuffle", "Shin (Medium)" },
{ "Invisible Fake", "Shin (Medium)" },
{ "Prima Donna", "Shin (Slow)" },
{ "Mole Fake", "Shin (Medium)" },
{ "Bewildered", "Shin (Slow)" },
{ "Super Armadillo", "Shin (Medium)" },
{ "Monkey Turn", "Shin (Fast)" },
{ "Dash Accelerator", "Shin (Fast)" },
{ "Boost Glider", "Shin (Slow)" },
{ "Flame Veil", "Shin (Medium)" },
{ "Breakthrough 2", "Shin (Slow)" },
{ "Armadillo Circus", "Shin (Medium)" },
{ "Lightning Sprint", "Shin (Medium)" },
{ "Gale Dash", "Shin (Fast)" },
{ "Meteor Shower", "Shin (Medium)" },
{ "Breakthrough", "Shin (Slow)" },
{ "Heat Tackle", "Shin (Medium)" },
{ "Bubble Gum", "Shin (Medium)" },
{ "Double Touch", "Shin (Medium)" },
{ "Heaven’s Time", "Shin (Medium)" },
{ "Water Veil", "Shin (Medium)" },
{ "Dash Storm", "Shin (Medium)" },
{ "Aikido", "Shin (Fast)" },
{ "Big Fan", "Shin (Slow)" },
{ "Aurora Dribble", "Shin (Medium)" },
{ "Whirlwind Cut", "Shin (Medium)" },
{ "Ribbon Shower", "Shin (Medium)" },
{ "Zigzag Spark", "Shin (Medium)" },
{ "Moonsault", "Shin (Medium)" },
{ "Poison Fog", "Shin (Medium)" },
{ "Whirlwind Twister", "Shin (Medium)" },
{ "Flurry Dash", "Shin (Fast)" },
{ "Rodeo Clown", "Shin (Fast)" },
{ "Southern Cross", "Shin (Slow)" },
{ "Dual Pass", "Shin (Medium)" },
{ "Clone Faker", "Shin (Medium)" },
{ "Deceptor Dribble", "Shin (Fast)" },
{ "Dark Whirlwind", "Shin (Medium)" },
{ "Warp Drive", "Shin (Medium)" },
{ "Afterimage", "Shin (Medium)" },
{ "Illusion Ball", "Shin (Medium)" },
{ "Attack Scan", "Shin (Medium)" },
{ "Magic", "Shin (Fast)" },
{ "Black Magic", "Shin (Fast)" },
{ "Body Shield", "Shin (Medium)" },
{ "Bamboo Pattern", "Shin (Slow)" },
{ "No Escape", "Shin (Slow)" },
{ "Mega Wall", "Shin (Medium)" },
{ "Road Roller", "Shin (Slow)" },
{ "Circus Block", "Shin (Medium)" },
{ "Mega Quake", "Shin (Medium)" },
{ "Heavy Mettle", "Shin (Medium)" },
{ "Gravitation", "Shin (Medium)" },
{ "Earthquake", "Shin (Medium)" },
{ "The Wall", "Shin (Slow)" },
{ "About Face", "Shin (Slow)" },
{ "Horn Train", "Shin (Medium)" },
{ "Sumo Stomp", "Shin (Slow)" },
{ "Mad Express", "Shin (Fast)" },
{ "Ignite Steal", "Shin (Medium)" },
{ "Planet Shield", "Shin (Medium)" },
{ "Shooting Star", "Shin (Medium)" },
{ "Divine Stamp", "Shin (Medium)" },
{ "Volcano Cut", "Shin (Medium)" },
{ "Flame Dance", "Shin (Fast)" },
{ "Fake Bomber", "Shin (Medium)" },
{ "Super Sumo Stomp", "Shin (Fast)" },
{ "Photon Crash", "Shin (Medium)" },
{ "Supreme Spin", "Shin (Fast)" },
{ "Perfect Tower", "Shin (Medium)" },
{ "Hurricane Arrows", "Shin (Slow)" },
{ "Frozen Steal", "Shin (Medium)" },
{ "Whale Guard", "Shin (Slow)" },
{ "Whirlwind Force", "Shin (Medium)" },
{ "Double Cyclone", "Shin (Medium)" },
{ "The Tower", "Shin (Fast)" },
{ "Perimeter Zone", "Shin (Medium)" },
{ "Cyclone", "Shin (Medium)" },
{ "Spinning Cut", "Shin (Slow)" },
{ "Land Of Ice", "Shin (Fast)" },
{ "Blade Attack", "Shin (Medium)" },
{ "Coil Turn", "Shin (Fast)" },
{ "Sigma Zone", "Shin (Fast)" },
{ "Stone Wall", "Shin (Slow)" },
{ "Harvest", "Shin (Fast)" },
{ "Asteroid Belt", "Shin (Medium)" },
{ "Dual Storm", "Shin (Medium)" },
{ "Sleeping Dust", "Shin (Medium)" },
{ "Clone Defence", "Shin (Medium)" },
{ "Shadow Stitch", "Shin (Medium)" },
{ "Spider Web", "Shin (Medium)" },
{ "Fake Ball", "Shin (Medium)" },
{ "Defence Scan", "Shin (Medium)" },
{ "Ghost Pull", "Shin (Medium)" },
{ "Doppelganger", "Shin (Medium)" },
{ "Killer Slide", "Shin (Fast)" },
{ "Quick Draw", "Shin (Fast)" }
        };

        public IDictionary<string, string> IE3MoveGrowth = new Dictionary<string, string>
        {
            { "Jet Stream", "L (Medium)" },
{ "Doom Break", "L (Fast)" },
{ "Shadow Ray(Earth)", "V (Slow)" },
{ "The Earth", "L (Fast)" },
{ "Brave Shot", "Shin (Slow)" },
{ "Gaia Break", "Shin (Fast)" },
{ "Unicorn Boost", "Shin (Medium)" },
{ "Heavenly Drive", "Shin (Fast)" },
{ "Odin Sword", "Shin (Slow)" },
{ "Samba Strike", "V (Medium)" },
{ "Almighty Cannon", "V (Fast)" },
{ "Eagle Buster", "V (Slow)" },
{ "Gladius Arch", "Shin (Fast)" },
{ "Butterfly Trance", "V (Slow)" },
{ "Slingshot", "V (Medium)" },
{ "Land Dragon", "Shin (Slow)" },
{ "Utter Gutsiness Club", "Shin (Fast)" },
{ "Paladin Strike", "Shin (Medium)" },
{ "Eiffel Tower", "V (Medium)" },
{ "Reflect Buster", "V (Medium)" },
{ "Tiger Drive", "V (Fast)" },
{ "Spectacle Crash", "Shin (Slow)" },
{ "Kung Fu Fighting", "V (Medium)" },
{ "Leaping Thunder", "Shin (Medium)" },
{ "Rainbow Arc", "Shin (Medium)" },
{ "Megaton Head", "L (Fast)" },
{ "Gyro Head", "V (Medium)" },
{ "Dirt Ball", "V (Medium)" },
{ "Teleport Shot", "Shin (Medium)" },
{ "Tarzan Kick", "Shin (Medium)" },
{ "Snake Shot", "Shin (Fast)" },
{ "Big Bang", "L (Medium)" },
{ "Grand Fire", "L (Slow)" },
{ "Cross Fire(Fire)", "Shin (Medium)" },
{ "X-Blast", "V (Medium)" },
{ "The Galaxy", "V (Slow)" },
{ "Neo Galaxy", "V (Medium)" },
{ "Fire Blizzard(Fire)", "Shin (Medium)" },
{ "Emperor Penguin X", "V (Slow)" },
{ "Maximum Fire", "Shin (Slow)" },
{ "Double Jaw", "V (Medium)" },
{ "Tiger Storm", "V (Fast)" },
{ "The Phoenix", "V (Slow)" },
{ "Celestial Smash", "V (Slow)" },
{ "Twin Boost F", "Shin (Medium)" },
{ "Triangle Z", "Shin (Fast)" },
{ "Triple Boost", "Shin (Fast)" },
{ "Fire Rooster", "V (Medium)" },
{ "Doom Rain", "V (Medium)" },
{ "Fireball Screw", "Shin (Fast)" },
{ "Atomic Flare", "V (Fast)" },
{ "Meteor Blade", "V (Medium)" },
{ "Fireball Storm", "L (Medium)" },
{ "Dragon Cannon", "V (Medium)" },
{ "Dragon Tornado", "Shin (Fast)" },
{ "Hellfire", "Shin (Fast)" },
{ "Gunshot", "Shin (Fast)" },
{ "Remote Combustion", "Shin (Fast)" },
{ "Twin Boost", "Shin (Slow)" },
{ "Steeple Shot", "Shin (Slow)" },
{ "Assault Shot", "Shin (Medium)" },
{ "Utter Gutsiness Bat", "Shin (Slow)" },
{ "Shine Drive", "V (Medium)" },
{ "Dynamite Shot", "Shin (Medium)" },
{ "Double Grenade", "V (Medium)" },
{ "Patriot Shot", "Shin (Slow)" },
{ "Fire Tornado", "Shin (Fast)" },
{ "Meteor Attack", "V (Medium)" },
{ "Heel Kick", "Shin (Slow)" },
{ "Grenade Shot", "Shin (Medium)" },
{ "Cross Fire(Wind)", "Shin (Medium)" },
{ "God Break", "L (Medium)" },
{ "Prime Legend", "L (Slow)" },
{ "Fire Blizzard(Wind)", "Shin (Medium)" },
{ "Inazuma-1 Drop", "V (Fast)" },
{ "Space Penguin", "V (Fast)" },
{ "The Dawn", "V (Medium)" },
{ "The Hurricane", "V (Fast)" },
{ "Excalibur", "Shin (Slow)" },
{ "Wyvern Blizzard", "V (Slow)" },
{ "Tri-Pegasus", "Shin (Medium)" },
{ "Gungnir", "V (Medium)" },
{ "Legendary Wolf", "L (Medium)" },
{ "God Knows", "Shin (Medium)" },
{ "Inazuma Break", "V (Fast)" },
{ "Northern Impact", "V (Fast)" },
{ "Thunder Beast", "Shin (Slow)" },
{ "Whirlwind Drop", "V (Medium)" },
{ "Revolution V", "Shin (Fast)" },
{ "Divine Arrows", "Shin (Slow)" },
{ "The Typhoon", "V (Fast)" },
{ "Inazuma-1", "V (Medium)" },
{ "Megalodon", "Shin (Medium)" },
{ "Eternal Blizzard", "V (Medium)" },
{ "Inazuma Drop", "V (Fast)" },
{ "Hawk Shot", "Shin (Medium)" },
{ "Tsunami Boost", "V (Fast)" },
{ "Back Tornado", "Shin (Medium)" },
{ "Cross Drive", "Shin (Medium)" },
{ "Baby Dragon", "Shin (Fast)" },
{ "Condor Dive", "Shin (Medium)" },
{ "Comet Shot", "V (Slow)" },
{ "Spinning Shot", "Shin (Medium)" },
{ "Spiral Shot", "Shin (Medium)" },
{ "Chaos Break", "L (Fast)" },
{ "Shadow Ray(Wood)", "V (Slow)" },
{ "Emperor Penguin No. 3", "L (Medium)" },
{ "Grand Fenrir", "L (Fast)" },
{ "Death Zone 2", "L (Fast)" },
{ "Emperor Penguin No. 1", "L (Slow)" },
{ "Supernova", "V (Fast)" },
{ "Dark Phoenix", "Shin (Fast)" },
{ "Dark Matter", "Shin (Slow)" },
{ "Clone Death Zone", "Shin (Medium)" },
{ "Clone Penguin", "V (Medium)" },
{ "Dragon Slayer", "V (Slow)" },
{ "Double Tornado", "V (Medium)" },
{ "Cosmic Blast", "V (Slow)" },
{ "Death Zone", "Shin (Fast)" },
{ "Emperor Penguin No. 2", "V (Fast)" },
{ "Astro Gate", "V (Medium)" },
{ "Pegasus Shot", "Shin (Fast)" },
{ "Wyvern Crash", "V (Fast)" },
{ "Clone Shot", "V (Medium)" },
{ "Dual Strike", "V (Medium)" },
{ "Doom Spear", "V (Fast)" },
{ "Mirage Shot", "Shin (Slow)" },
{ "Double Wrath Shot", "V (Fast)" },
{ "Sweet Deal", "V (Fast)" },
{ "Ganymede Ray", "Shin (Slow)" },
{ "Astro Break", "V (Medium)" },
{ "Security Shot", "Shin (Medium)" },
{ "Acrobat Bomber", "Shin (Slow)" },
{ "Dark Tornado", "Shin (Medium)" },
{ "Kung Fu Header", "V (Medium)" },
{ "Bed Of Roses", "V (Fast)" },
{ "Dragon Crash", "Shin (Fast)" },
{ "Run Ball Run", "V (Fast)" },
{ "Freeze Shot", "Shin (Medium)" },
{ "Wrath Shot", "V (Medium)" },
{ "Phantom Shot", "V (Medium)" },
{ "Psycho Shot", "V (Medium)" },
{ "Rolling Kick", "Shin (Fast)" },
{ "Omega Hand", "L (Medium)" },
{ "God Catch", "L (Medium)" },
{ "Infinite Wall", "Shin (Medium)" },
{ "Gigant Wall", "Shin (Slow)" },
{ "Triple Defence", "V (Fast)" },
{ "Capoeira Grab", "V (Medium)" },
{ "Flash Upper", "V (Fast)" },
{ "Colosseum Guard", "Shin (Slow)" },
{ "Card Protector", "Shin (Slow)" },
{ "Hammer of Fury", "V (Medium)" },
{ "Table-Turner", "Shin (Medium)" },
{ "Utter Gutsiness Catch", "Shin (Slow)" },
{ "Sliding Goal", "Shin (Slow)" },
{ "Majin The Hand(Earth)", "Shin (Fast)" },
{ "Wild Claw", "V (Medium)" },
{ "God Hand(Earth)", "Shin (Slow)" },
{ "Wood Chopper", "Shin (Medium)" },
{ "Toughness Block", "V (Medium)" },
{ "Soul Hand", "L (Slow)" },
{ "Triple God Hand", "L (Fast)" },
{ "Beast Fang", "L (Slow)" },
{ "Million Hands", "V (Slow)" },
{ "Burnout", "V (Medium)" },
{ "Drill Smasher", "V (Fast)" },
{ "Double Rocket", "V (Medium)" },
{ "God Hand X", "Shin (Fast)" },
{ "Nitro Slap", "Shin (Medium)" },
{ "Counter Strike", "V (Medium)" },
{ "Shot Trap", "Shin (Medium)" },
{ "Flame Breath", "V (Medium)" },
{ "Blazing Knuckle", "Shin (Medium)" },
{ "Full Power Shield", "V (Medium)" },
{ "Fireball Head", "V (Medium)" },
{ "Rocket Kobushi", "V (Medium)" },
{ "Power Shield", "V (Fast)" },
{ "Pressure Punch", "Shin (Medium)" },
{ "Fireball Knuckle", "Shin (Fast)" },
{ "High Voltage", "L (Fast)" },
{ "Temporal Wall", "Shin (Slow)" },
{ "Celestial Zone", "V (Slow)" },
{ "Procyon Net", "V (Medium)" },
{ "Ice Block", "V (Medium)" },
{ "Electrap", "Shin (Fast)" },
{ "Needle Hammer", "Shin (Fast)" },
{ "Tsunami Wall", "V (Medium)" },
{ "Storm Rider", "V (Fast)" },
{ "Safety First", "Shin (Medium)" },
{ "Fist of Justice", "L (Medium)" },
{ "Galatyn", "Shin (Slow)" },
{ "Barrier Reef", "Shin (Fast)" },
{ "Aurora Curtain", "Shin (Fast)" },
{ "Whirlwind", "V (Medium)" },
{ "Flower Power", "Shin (Slow)" },
{ "Mistral", "V (Medium)" },
{ "Tornado Catch", "Shin (Fast)" },
{ "Swan Dive", "Shin (Medium)" },
{ "Fiend Hand", "L (Slow)" },
{ "The End", "V (Slow)" },
{ "Mugen The Hand", "L (Slow)" },
{ "Dimensional Hand", "Shin (Fast)" },
{ "Giant Spider", "V (Slow)" },
{ "Dual Smash", "V (Medium)" },
{ "Clone Block", "V (Medium)" },
{ "Wormhole", "V (Medium)" },
{ "The Stinger", "V (Fast)" },
{ "Black Hole", "V (Fast)" },
{ "Claw Slash", "Shin (Slow)" },
{ "Majin The Hand(Wood)", "Shin (Fast)" },
{ "Shot Pocket", "V (Fast)" },
{ "God Hand(Wood)", "Shin (Slow)" },
{ "Warp Space", "V (Medium)" },
{ "Killer Blade", "Shin (Slow)" },
{ "Triple Dash", "Shin (Fast)" },
{ "Super Elastico", "V (Fast)" },
{ "Three-Legged Rush", "V (Medium)" },
{ "Rolling Hell", "V (Slow)" },
{ "Sub-Terfuge", "V (Medium)" },
{ "Invisible Fake", "Shin (Medium)" },
{ "Mole Shuffle", "Shin (Medium)" },
{ "Prima Donna", "V (Slow)" },
{ "Bewilder Blast", "V (Slow)" },
{ "Mole Fake", "Shin (Medium)" },
{ "Kangaroo Kick", "Shin (Slow)" },
{ "Bewildered", "V (Slow)" },
{ "Super Armadillo", "Shin (Medium)" },
{ "Dash Accelerator", "Shin (Fast)" },
{ "Monkey Turn", "Shin (Fast)" },
{ "Boost Glider", "V (Slow)" },
{ "Breakthrough 3", "Shin (Slow)" },
{ "The Ikaros", "V (Fast)" },
{ "Breakthrough 2", "Shin (Slow)" },
{ "Flame Veil", "V (Medium)" },
{ "Armadillo Circus", "V (Medium)" },
{ "Lightning Sprint", "V (Medium)" },
{ "Liar Shot", "Shin (Fast)" },
{ "Gale Dash", "V (Fast)" },
{ "Meteor Shower", "V (Medium)" },
{ "Breakthrough", "Shin (Slow)" },
{ "Dog Run", "V (Fast)" },
{ "Abaddon Drop", "Shin (Fast)" },
{ "Heat Tackle", "Shin (Medium)" },
{ "Bubble Gum", "V (Medium)" },
{ "Double Touch", "V (Medium)" },
{ "Air Ride", "V (Medium)" },
{ "Angel Ball", "V (Medium)" },
{ "Wind God’s Dance", "Shin (Slow)" },
{ "Water Veil", "V (Medium)" },
{ "Heaven’s Time", "Shin (Medium)" },
{ "Dash Storm", "V (Medium)" },
{ "Aikido", "V (Fast)" },
{ "Card Slap", "Shin (Fast)" },
{ "Big Fan", "Shin (Slow)" },
{ "Aurora Dribble", "Shin (Medium)" },
{ "Whirlwind Cut", "Shin (Medium)" },
{ "Ribbon Shower", "V (Medium)" },
{ "Zigzag Spark", "V (Medium)" },
{ "Moonsault", "V (Medium)" },
{ "Poison Fog", "V (Medium)" },
{ "Whirlwind Twister", "V (Medium)" },
{ "Flurry Dash", "Shin (Fast)" },
{ "Rodeo Clown", "Shin (Fast)" },
{ "Field of Force", "V (Slow)" },
{ "Devil Ball", "V (Medium)" },
{ "Dual Pass", "V (Medium)" },
{ "Southern Cross", "Shin (Slow)" },
{ "Matador Feint", "Shin (Fast)" },
{ "Echo Ball", "V (Medium)" },
{ "Ultra Moon", "V (Fast)" },
{ "Clone Faker", "V (Medium)" },
{ "Deceptor Dribble", "Shin (Fast)" },
{ "Dark Whirlwind", "V (Medium)" },
{ "Warp Drive", "Shin (Medium)" },
{ "Afterimage", "V (Medium)" },
{ "Illusion Ball", "Shin (Medium)" },
{ "Attack Scan", "V (Medium)" },
{ "Magic", "V (Fast)" },
{ "Black Magic", "Shin (Fast)" },
{ "Bamboo Pattern", "V (Slow)" },
{ "Body Shield", "Shin (Medium)" },
{ "The Mountain", "V (Slow)" },
{ "Ground Quake", "Shin (Medium)" },
{ "No Escape", "V (Slow)" },
{ "Barbarian Shield", "V (Slow)" },
{ "Road Roller", "Shin (Slow)" },
{ "Mega Wall", "Shin (Medium)" },
{ "Circus Block", "Shin (Medium)" },
{ "Iron Wall", "Shin (Medium)" },
{ "Mega Quake", "V (Medium)" },
{ "Stone Prison", "Shin (Medium)" },
{ "Heavy Mettle", "Shin (Medium)" },
{ "Gravitation", "Shin (Medium)" },
{ "Power Charge", "Shin (Fast)" },
{ "Gravestone", "V (Slow)" },
{ "Earthquake", "Shin (Medium)" },
{ "The Wall", "Shin (Slow)" },
{ "About Face", "V (Slow)" },
{ "Horn Train", "V (Medium)" },
{ "Sumo Stomp", "V (Slow)" },
{ "Mad Express", "Shin (Fast)" },
{ "Ignite Steal", "Shin (Medium)" },
{ "Planet Shield", "Shin (Medium)" },
{ "Shooting Star", "Shin (Medium)" },
{ "Divine Stamp", "Shin (Medium)" },
{ "Rolling Slide", "Shin (Medium)" },
{ "Volcano Cut", "V (Medium)" },
{ "Flame Dance", "Shin (Fast)" },
{ "Zigzag Flame", "V (Medium)" },
{ "Racing Flame", "Shin (Medium)" },
{ "Fake Bomber", "Shin (Medium)" },
{ "Super Sumo Stomp", "V (Fast)" },
{ "Photon Crash", "Shin (Medium)" },
{ "Supreme Spin", "Shin (Fast)" },
{ "Hurricane Arrows", "Shin (Slow)" },
{ "Perfect Tower", "Shin (Medium)" },
{ "Heaven’s Ascent", "V (Fast)" },
{ "Frozen Steal", "Shin (Medium)" },
{ "Whale Guard", "V (Slow)" },
{ "Double Cyclone", "Shin (Medium)" },
{ "Snow Angel", "Shin (Fast)" },
{ "Vac Attack", "V (Slow)" },
{ "Whirlwind Force", "Shin (Medium)" },
{ "Perimeter Zone", "V (Medium)" },
{ "The Tower", "V (Fast)" },
{ "Cyclone", "Shin (Medium)" },
{ "Desert Blast", "Shin (Fast)" },
{ "Spinning Cut", "V (Slow)" },
{ "Land Of Ice", "Shin (Fast)" },
{ "Blade Attack", "Shin (Medium)" },
{ "Coil Turn", "Shin (Fast)" },
{ "Sigma Zone", "Shin (Fast)" },
{ "Hell’s Descent", "V (Fast)" },
{ "Diabolical Cut", "V (Slow)" },
{ "Stone Wall", "V (Slow)" },
{ "Harvest", "V (Fast)" },
{ "Dual Storm", "V (Medium)" },
{ "Asteroid Belt", "Shin (Medium)" },
{ "Am-Bush", "Shin (Medium)" },
{ "Clone Defence", "V (Medium)" },
{ "Shadow Stitch", "Shin (Medium)" },
{ "Sleeping Dust", "V (Medium)" },
{ "Yo-Yo Ball", "Shin (Medium)" },
{ "Spider Web", "V (Medium)" },
{ "Fake Ball", "Shin (Medium)" },
{ "Defence Scan", "V (Medium)" },
{ "Killer Slide", "Shin (Fast)" },
{ "Ghost Pull", "V (Medium)" },
{ "Doppelganger", "V (Medium)" },
{ "Quick Draw", "V (Fast)" },

        };

    }
}
