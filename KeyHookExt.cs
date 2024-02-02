using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys
{
    internal class KeyHookExt
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct KeyEventStructure
        {
            public uint vkCode;
            public uint scanCode;
            public uint flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        protected delegate IntPtr KeyProc(Int32 Code, IntPtr wParam, IntPtr lParam);


        [DllImport("User32.dll")]
        protected static extern IntPtr CallNextHookEx(
            IntPtr hHook, Int32 nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        protected static extern IntPtr UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("User32.dll")]
        protected static extern IntPtr SetWindowsHookEx(
            Int32 idHook, KeyProc lpfn, IntPtr hmod,
            Int32 dwThreadId);

        [DllImport("User32.dll")]
        protected static extern Int16 GetAsyncKeyState(Int32 vKey);

        [DllImport("User32.dll")]
        protected static extern Int16 GetKeyState(Int32 vKey);

        [DllImport("kernel32.dll")]
        protected static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
