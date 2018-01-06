using System.Runtime.InteropServices;

namespace WindowsInterface
{
    public class WindowsMouseClick
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public static void MouseClick(MouseButtonEvent clickType, int x, int y)
        {
            mouse_event((int)clickType, x, y, 0, 0);
        }
    }
}