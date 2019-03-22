using System;
using System.Collections.Generic;
using System.Text;

namespace NPCPerks
{
    [Flags]
        enum Perks
        {
            Stealth = 1,
            Combat = 2,
            Lockpick = 4,
            Luck = 8,
        }
    
}
