using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HotKeys
{
    internal class KeyHook : KeyHookExt, IDisposable
    {
        public const uint FLAG_CTRL = 0x80000000;
        public const uint FLAG_ALT = 0x40000000;
        public const uint FLAG_SHIFT = 0x00800000;

        public event EventHandler<KeyEventStructure> KeyDownEvent;

        public KeyHook()
        {
            IntPtr hInstance = GetModuleHandle("User32");
            hKeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookFunction, hInstance, 0);
        }

        public void Dispose()
        {
            if (!disposedFlag)
            {
                UnhookWindowsHookEx(hKeyHook);
                disposedFlag = true;
            }
            
        }

        public static bool CtrlKeyDown
        {
            get {
                return (GetAsyncKeyState(VK_CONTROL) & PRESSED) != 0; 
            }
        }

        public static bool ShiftKeyDown
        {
            
            get {
                return (GetAsyncKeyState(VK_SHIFT) & PRESSED) != 0; 
            }
        }

        public static bool AltKeyDown
        {
            get {
                return (GetAsyncKeyState(VK_MENU) & PRESSED) != 0;  
            }
        }


        private bool disposedFlag = false;


        private IntPtr KeyHookFunction(Int32 Code, IntPtr wParam, IntPtr lParam)
        {

            if (KeyDownEvent != null)
            {
                var args = Marshal.PtrToStructure<KeyEventStructure>(lParam);
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    KeyDownEvent(this, args);
                }
            }
            return CallNextHookEx(hKeyHook, Code, wParam, lParam);
        }

        private IntPtr hKeyHook;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;
        private const byte VK_SHIFT = 0x10;
        private const byte VK_CONTROL = 0x11;
        private const byte VK_MENU = 0x12;
        private const ushort PRESSED = 0x8000;
    }
}
