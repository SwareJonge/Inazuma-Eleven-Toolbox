# unitbase.dat layout
Length: 0x60, start of file: 0x60

| Offset | Name | DataType | Notes |
| --- | --- | --- | --- |
| 0x0 | Full Name | string | Player's full name |
| 0x20 | Nickname | string | Player's nickname |
| 0x40 | EXP Growing Type | byte | more detailed view [here](https://github.com/SwareJonge/Inazuma-Eleven-Toolbox/blob/master/Inazuma-Eleven-Toolbox/Logic/EXP.cs) |
| 0x42 | Scout ID | short | HEX ID for the Scout ID, also defines texts in menus |
| 0x44 | Model Data | short | 2D portrait sprite, head model and model face |
| 0x46 | Sprite specs | short | Body sprite specifications |
| 0x48 | RPG Head | short | Overworld RPG head |
| 0x4A | RPG Palette | short | Overworld RPG palette |
| 0x4C | Model Specs | short | Neck length and other body model specifications |
| 0x4E | Skin tone | short | Skin tone |
| 0x52 | Gender | byte | 1 = Male, 2 = Female |
| 0x54 | Size | byte | Size of player 0 = Normal, 1 = Large, 2 = Small |
| 0x55 | Position | byte | Size of player 0 = Normal, 1 = Large, 2 = Small |
| 0x5A | Element | byte | 1 = Air, 2 = Wood, 3 = Fire, 4 = Earth |
| 0x5E | Player index | short | Index of the player, also defines text of profile description |

Thanks to Luvtir for these offsets:
-Head in menu bar, Special Moves and stats
-2D portrait sprite, head model and model face
-Body sprite specifications
-Overworld RPG head
-Overworld RPG palette
-Neck length and other body model specifications
-Skin tone
-Profile

Other IDs are unknown
