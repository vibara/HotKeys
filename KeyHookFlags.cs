using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys
{
    [Flags]
    internal enum KeyHookFlags
    {
        Shift = 1,
        Ctrl = 2,
        Alt = 4,
        Win = 8,
    }
}
