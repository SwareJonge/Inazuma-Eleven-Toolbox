# unitstat.dat layout
Length: 0x50, start of file: 0x50

| Offset | Name | DataType | Notes |
| --- | --- | --- | --- |
| 0x0 | TP | short[3] | Min, Max, GrowthRate |  
| 0x6 | unk | short | unknown |
| 0x8 | FP | short[3] | Min, Max, GrowthRate |
| 0xE | unk2 | short | unknown |
| 0x10 | Kick | byte[2] | Min, Max |
| 0x12 | KickGrowthRate | short | GrowthRate |
| 0x14 | Body | byte[2] | Min, Max |
| 0x16 | BodyGrowthRate | short | GrowthRate |
| 0x18 | Guard | byte[2] | Min, Max |
| 0x1A | GuardGrowthRate | short | GrowthRate |
| 0x1C | Control | byte[2] | Min, Max |
| 0x1E | ControlGrowthRate | short | GrowthRate |
| 0x20 | Speed | byte[2] | Min, Max |
| 0x22 | SpeedGrowthRate | short | GrowthRate |
| 0x24 | Guts | byte[2] | Min, Max |
| 0x26 | GutsGrowthRate | short | GrowthRate |
| 0x28 | Stamina | byte[2] | Min, Max |
| 0x2A | StaminaGrowthRate | short | GrowthRate |
| 0x2C | Move slot 1 | short[2] | MoveID, UnlockLevel |
| 0x30 | Move slot 2 | short[2] | MoveID, UnlockLevel |
| 0x34 | Move slot 3 | short[2] | MoveID, UnlockLevel |
| 0x38 | Move slot 4 | short[2] | MoveID, UnlockLevel |
| 0x3C | Max total | short | The amount a player can have in it's stats |
| 0x3E | unk3 | short[4] | unknown |
| 0x46 | unk4 | short[5] | 0s |
