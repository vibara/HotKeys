using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys
{
    internal class KeyEventArgs
    {
        public KeyHookExt.KeyEventStructure KeyEventStructure; 
        public bool IsHandled { get; set; }

        public KeyEventArgs(KeyHookExt.KeyEventStructure KeyEventStructure)
        { 
            this.KeyEventStructure = KeyEventStructure;
            this.IsHandled = false;
        }
    }
}
