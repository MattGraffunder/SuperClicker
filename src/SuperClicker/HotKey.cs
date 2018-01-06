using System;
using System.Windows.Forms;
using WindowsInterface;

namespace SuperClicker
{
    internal class HotKey
    {        
        private Keys _key;
        private IntPtr _hWnd;
        private int _id;

        public HotKey(Keys key, Form form)
        {
            _key = key;
            _hWnd = form.Handle;
            _id = GetHashCode();
        }

        public Keys Key => _key;

        public override int GetHashCode()
        {
            return (int)_key ^ _hWnd.ToInt32();
        }

        public bool Activate()
        {
            return WindowsHotkey.Register(_hWnd, _id, (int)_key);
        }

        public bool Deactivate()
        {
            return WindowsHotkey.Unregister(_hWnd, _id);
        }

        public void HandleHotKeyMessages(Message m, Action messageHandler)
        {
            if (m.Msg == WindowsHotkey.WM_HOTKEY_MSG_ID)
            {
                messageHandler();
            }
        }
    }
}