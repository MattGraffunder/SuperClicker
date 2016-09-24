using System;

namespace SuperClicker.ClickStrategies
{
    public class ClickStrategyManager : IClickStrategyManager
    {
        public ClickStrategy GetClickStrategy(ClickType type)
        {
            switch (type)
            {
                case ClickType.Left:
                    return new LeftClickStrategy();
                case ClickType.Right:
                    return new RightClickStrategy();
                default:
                    throw new ArgumentException(string.Format("Click Type {0} is invalid", type));
            }
        }
    }
}