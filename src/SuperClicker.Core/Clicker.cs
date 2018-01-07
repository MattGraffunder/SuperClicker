using SuperClicker.Core.Click_Location_Strategies;
using SuperClicker.Core.ClickStrategies;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace SuperClicker.Core
{
    public class Clicker
    {
        public event EventHandler ClickStatusUpdated;
        
        Task t;
        int _clicks;
        int _millisecondsBetweenClicks;

        public bool Active { get; private set; }
        public bool PreventClicking { get; set; }

        private IClickStrategyManager _clickStrategyManager = new ClickStrategyManager();

        private ClickStrategy _clickStrategy = null;
        private IClickLocationStrategy _clickLocationStrategy = null;

        private int _clicksPerSecond;
        public int ClicksPerSecond
        {
            get { return _clicksPerSecond; }
            set
            {
                _clicksPerSecond = value;
                SetMillisecondsBetweenClicks();
            }
        }

        public int Clicks
        {
            get
            {
                return _clicks;
            }
            set
            {
                _clicks = value;

                if (_clicks % 10 == 0)
                {
                    OnClickStatusUpdated();
                }
            }
        }

        public Clicker(int clicksPerSecond)
        {
            t = new Task(SuperClick);
            _clicks = 0;
            _clicksPerSecond = clicksPerSecond;
            
            SetMillisecondsBetweenClicks();
        }

        public Clicker() : this(50) { }

        public void StartClicking(ClickType type, IClickLocationStrategy clickLocation)
        {
            if (Active || PreventClicking)
            {
                return;
            }

            _clickStrategy = _clickStrategyManager.GetClickStrategy(type);
            _clickLocationStrategy = clickLocation;

            Active = true;

            t = new Task(SuperClick);
            t.Start();
        }

        public void StopClicking()
        {
            Active = false;
            t = null;
        }

        private void SuperClick()
        {
            while (Active)
            {
                Point clickPoint = _clickLocationStrategy.GetClickLocation();
                _clickStrategy.Click(clickPoint.X, clickPoint.Y);

                Clicks++;

                Thread.Sleep(_millisecondsBetweenClicks);
            }
        }

        private void OnClickStatusUpdated()
        {
            if (ClickStatusUpdated != null)
            {
                ClickStatusUpdated(this, new EventArgs());
            }
        }

        private void SetMillisecondsBetweenClicks()
        {
            _millisecondsBetweenClicks = 1000 / _clicksPerSecond;
        }
    }
}