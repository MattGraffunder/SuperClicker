using SuperClicker.Core;
using SuperClicker.Core.ClickStrategies;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperClicker
{
    internal class ClickerViewPresenter
    {
        private const int DEFAULT_CLICKS_PER_SECOND = 50;

        Clicker _clicker;
        ClickerView _view;

        public ClickerViewPresenter(ClickerView view)
        {
            _clicker = new Clicker(DEFAULT_CLICKS_PER_SECOND, () => new Point(Cursor.Position.X, Cursor.Position.Y));

            _clicker.ClickStatusUpdated += clicker_ClickStatusUpdated;

            _view = view;
        }

        public int ClicksPerSecond => _clicker.ClicksPerSecond;
        public int TotalClicks => _clicker.Clicks;

        public bool RightClick { get; set; }
        
        #region Clicker Functionality

        public void StartClicking()
        {
            //Determine if right or left click
            ClickType type = RightClick ? ClickType.Right : ClickType.Left;

            _clicker.StartClicking(type);
        }

        public void StopClicking()
        {
            _clicker.StopClicking();
        }

        public void PreventClicking(bool prevent)
        {
            _clicker.PreventClicking = prevent;
        }

        public void SetClicksPerSecond(int clicksPerSecond)
        {
            _clicker.ClicksPerSecond = clicksPerSecond;
        }

        private void clicker_ClickStatusUpdated(object sender, EventArgs e)
        {
            UpdateView();
        }

        #endregion

        private void UpdateView()
        {
            _view.UpdateView();
        }

        public void HotkeyActivated()
        {
            if (_clicker.Active)
            {
                StopClicking();
            }
            else
            {
                StartClicking();
            }
        }
    }
}