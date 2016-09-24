using System.Windows.Forms;
using WindowsInterface;

namespace SuperClicker.ClickStrategies
{
    public class RightClickStrategy : ClickStrategy
    {
        public override void Click()
        {
            WindowsMouseClick.MouseClick(MouseButtonEvent.RightDown, Cursor.Position.X, Cursor.Position.Y);
            WindowsMouseClick.MouseClick(MouseButtonEvent.RightUp, Cursor.Position.X, Cursor.Position.Y);
        }
    }
}