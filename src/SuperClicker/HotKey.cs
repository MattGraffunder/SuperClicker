using System;
using System.Windows.Forms;
using WindowsInterface;

namespace SuperClicker
{
    internal class HotKey
    {        
        private int key;
        private IntPtr hWnd;
        private int id;

        public HotKey(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register()
        {
            return WindowsHotkey.Register(hWnd, id, key);
        }

        public bool Unregiser()
        {
            return WindowsHotkey.Unregister(hWnd, id);
        }
    }
}