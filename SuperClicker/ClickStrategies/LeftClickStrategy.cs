using System.Windows.Forms;
using WindowsInterface;

namespace SuperClicker.ClickStrategies
{
    class LeftClickStrategy : ClickStrategy
    {
        public override void Click()
        {
            WindowsMouseClick.MouseClick(MouseButtonEvent.LeftDown, Cursor.Position.X, Cursor.Position.Y);
            WindowsMouseClick.MouseClick(MouseButtonEvent.LeftUp, Cursor.Position.X, Cursor.Position.Y);
        }
    }
}