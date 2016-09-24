namespace SuperClicker.ClickStrategies
{
    interface IClickStrategyManager
    {
        ClickStrategy GetClickStrategy(ClickType type);
    }
}