using System.Drawing;

namespace SuperClicker.Core.Click_Location_Strategies
{
    public interface IClickLocationStrategy
    {
        Point GetClickLocation();
    }
}