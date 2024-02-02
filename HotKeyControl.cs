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
    public partial class HotKeyControl : UserControl
    {
        public HotKeyControl()
        {
            InitializeComponent();
            keyHook = new KeyHook();
            UpdateKeyHookOptions();

            keyHook.KeyDownEvent += KeyHook_KeyDownEvent;
            // KeyHook::Dispose called autmatically
        }

        private KeyHook keyHook;

        private void KeyHook_KeyDownEvent(object? sender, KeyEventArgs e)
        {
            if (KeyHook.CheckFlagKeysPressed(keyHook.Options.Flags) &&
                keyHook.Options.Letter == KeyHook.CharByVkCode(e.KeyEventStructure.vkCode))
            {
                var myForm = FindForm();
                MessageBox.Show($"{KeyHook.GetFlagKeysStringPrefix(keyHook.Options.Flags)}{keyHook.Options.Letter} pressed.");
                e.IsHandled = true;
            }
        }

        private void UpdateKeyHookOptions()
        {
            KeyHookFlags flags = 0;
            if (checkBoxShift.Checked)
            {
                flags |= KeyHookFlags.Shift;
            }
            if (checkBoxCtrl.Checked)
            {
                flags |= KeyHookFlags.Ctrl;
            }
            if (checkBoxAlt.Checked)
            {
                flags |= KeyHookFlags.Alt;
            }
            if (checkBoxWin.Checked)
            {
                flags |= KeyHookFlags.Win;
            }
            keyHook.Options.Flags = flags;
            keyHook.Options.Letter = comboBoxLetter.SelectedItem.ToString()[0];
        }

        private void checkBoxShift_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKeyHookOptions();
        }

        private void checkBoxCtrl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKeyHookOptions();
        }

        private void checkBoxAlt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKeyHookOptions();
        }

        private void checkBoxWin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKeyHookOptions();
        }

        private void comboBoxLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKeyHookOptions();
        }
    }
}
