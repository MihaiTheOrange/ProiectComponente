using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    [Flags]
    public enum FrontPanel
    {
        None,
        USB2 = 1 << 0,
        USB3 = 1 << 1,
        USB3_1= 1 << 2,
        USBC = 1 << 3,
        Thunderbolt = 1 << 4,
        Jack2_5 = 1 << 5,
        Jack3_5 = 1 << 6,
        Jack6_35 = 1 << 7
    }
}
