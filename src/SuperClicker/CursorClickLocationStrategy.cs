using SuperClicker.Core.Click_Location_Strategies;
using System.Drawing;
using System.Windows.Forms;

namespace SuperClicker
{
    internal class CursorClickLocationStrategy : IClickLocationStrategy
    {
        public Point GetClickLocation()
        {
            return new Point(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}