using System;
using System.Runtime.InteropServices;

namespace WindowsInterface
{
    public class WindowsHotkey
    {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static bool Register(IntPtr hWnd, int id, int key)
        {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public static bool Unregister(IntPtr hWnd, int id)
        {
            return UnregisterHotKey(hWnd, id);
        }
    }
}