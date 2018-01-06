namespace SuperClicker.Core.ClickStrategies
{
    interface IClickStrategyManager
    {
        ClickStrategy GetClickStrategy(ClickType type);
    }
}