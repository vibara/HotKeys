using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace HotKeys
{
    public partial class CtrlAltShiftControl : UserControl
    {
        public CtrlAltShiftControl()
        {
            InitializeComponent();
            var keyHook = new KeyHook();

            keyHook.KeyDownEvent += KeyHook_KeyDownEvent;
            // KeyHook::Dispose called autmatically
        }

        private void KeyHook_KeyDownEvent(object? sender, KeyHookExt.KeyEventStructure e)
        {
            var keyCode = (System.Windows.Forms.Keys)e.vkCode;

            if (
                KeyHook.ShiftKeyDown &&
                KeyHook.CtrlKeyDown &&
                KeyHook.AltKeyDown &&
                keyCode >= Keys.A && keyCode <= Keys.Z)
            {
                var myForm = FindForm();
                if (myForm != null)
                {
                    myForm.TopMost = true;
                }

                MessageBox.Show($"Ctrl + Shift + Alt + {keyCode} pressed.");
            }
        }
    }
}
