using WindowsInterface;

namespace SuperClicker.Core.ClickStrategies
{
    public class RightClickStrategy : ClickStrategy
    {
        public override void Click(int x, int y)
        {
            WindowsMouseClick.MouseClick(MouseButtonEvent.RightDown, x, y);
            WindowsMouseClick.MouseClick(MouseButtonEvent.RightUp, x, y);
        }
    }
}