using WindowsInterface;

namespace SuperClicker.Core.ClickStrategies
{
    class LeftClickStrategy : ClickStrategy
    {
        public override void Click(int x, int y)
        {
            WindowsMouseClick.MouseClick(MouseButtonEvent.LeftDown, x, y);
            WindowsMouseClick.MouseClick(MouseButtonEvent.LeftUp, x, y);
        }
    }
}