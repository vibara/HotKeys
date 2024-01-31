using System.Security.Cryptography;

namespace HotKeys
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var keyHook = new KeyHook();

            keyHook.KeyDownEvent += KeyHook_KeyDownEvent;

            Application.Run(new Form1());
            // KeyHook::Dispose called autmatically
        }

        private static void KeyHook_KeyDownEvent(object? sender, KeyHookExt.KeyEventStructure e)
        {
            var keyCode = (System.Windows.Forms.Keys)e.vkCode;
            
            if (
                KeyHook.ShiftKeyDown &&
                KeyHook.CtrlKeyDown &&
                KeyHook.AltKeyDown &&
                keyCode >= Keys.A && keyCode <= Keys.Z)
            {
                MessageBox.Show($"Ctrl + Shift + Alt + {keyCode} pressed.");
            }
        }
    }
}