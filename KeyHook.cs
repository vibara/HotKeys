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
        public KeyHookOptions Options { get; }

        public event EventHandler<KeyEventStructure>? KeyDownEvent;

        public KeyHook()
        {
            IntPtr hInstance = GetModuleHandle("User32");

            hKeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookFunction, hInstance, 0);
            Options = new KeyHookOptions();
        }

        public void Dispose()
        {
            if (!disposedFlag)
            {
                UnhookWindowsHookEx(hKeyHook);
                disposedFlag = true;
            }
        }

        public static bool CheckFlagKeysPressed(KeyHookFlags mask)
        {
            KeyHookFlags result = 0;
            if ((mask & KeyHookFlags.Shift) != 0 && 
                CheckKeyDown(VK_SHIFT))
            {
                result |= KeyHookFlags.Shift;
            }
            if ((mask & KeyHookFlags.Ctrl) != 0 && 
                CheckKeyDown(VK_CONTROL))
            {
                result |= KeyHookFlags.Ctrl;
            }
            if ((mask & KeyHookFlags.Alt) != 0 && 
                CheckKeyDown(VK_MENU))
            {
                result |= KeyHookFlags.Alt;
            }
            if ((mask | KeyHookFlags.Win) != 0 && 
                (CheckKeyDown(VK_LWIN) || CheckKeyDown(VK_RWIN)))
            {
                result |= KeyHookFlags.Win;
            }
            return result == mask;
        }

        public static string GetFlagKeysStringPrefix(KeyHookFlags mask)
        {
            var result = string.Empty;
            if ((mask & KeyHookFlags.Shift) != 0) 
            {
                result += "Shift + ";
            }
            if ((mask & KeyHookFlags.Ctrl) != 0)
            {
                result += "Ctrl + ";
            }
            if ((mask & KeyHookFlags.Alt) != 0)
            {
                result += "Alt + ";
            }
            if ((mask & KeyHookFlags.Win) != 0)
            {
                result += "Win + ";
            }
            return result;
        }

        public static char CharByVkCode(uint vkCode)
        {
            return (char)('A' + (vkCode - (uint)Keys.A));
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;
        private const byte VK_SHIFT = 0x10;
        private const byte VK_CONTROL = 0x11;
        private const byte VK_MENU = 0x12;
        private const byte VK_LWIN = 0x5B;
        private const byte VK_RWIN = 0x5C;
        private const ushort PRESSED = 0x8000;

        private bool disposedFlag = false;
        private IntPtr hKeyHook;

        private static bool CheckKeyDown(int keyCode)
        {
            return (GetAsyncKeyState(keyCode) & PRESSED) != 0;
        }

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
    }
}
