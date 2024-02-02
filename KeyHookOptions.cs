using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys
{
    internal class KeyHookOptions
    {
        public  KeyHookFlags Flags { get; set; }
        public char Letter { get; set; }
        public KeyHookOptions() 
        {
            Flags = KeyHookFlags.Ctrl | KeyHookFlags.Alt | KeyHookFlags.Shift;
            Letter = 'A';
        }
    }
}
