# unitbase.dat layout
Length: 0x60, start of file: 0x60

| Offset | Name | DataType | Notes |
| --- | --- | --- | --- |
| 0x0 | Full Name | string | Player's full name |
| 0x20 | Nickname | string | Player's nickname |
| 0x40 | FP | short[3] | Min, Max, GrowthRate |
| 0x52 | Gender | byte | 1 = Male, 2 = Female |
| 0x54 | Size | byte | Size of player 0 = Medium, 1 = large, 2 = small |
| 0x5A | Element | byte | 1 = Air, 2 = Wood, 3 = Fire, 4 = Earth |

Other IDs are unknown
