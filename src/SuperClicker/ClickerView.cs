using System;
using System.Windows.Forms;

namespace SuperClicker
{
    internal partial class ClickerView : Form
    {
        ClickerViewPresenter _presenter;
        HotKey _hotkey;

        public ClickerView()
        {
            InitializeComponent();

            _presenter = new ClickerViewPresenter(this);
            
            numClicksPerSecond.Value = _presenter.ClicksPerSecond;

            _hotkey = new HotKey(Keys.Space, this);
            _hotkey.Activate();
        }

        #region Update View

        public void UpdateView()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(UpdateView));

                return;
            }

            lblClicks.Text = _presenter.TotalClicks.ToString("0,0");
        }

        #endregion

        #region Hotkey Functionality
        
        protected override void WndProc(ref Message m)
        {
            _hotkey?.HandleHotKeyMessages(m, _presenter.HotkeyActivated);

            base.WndProc(ref m);
        }

        #endregion
              
        #region Event Handlers
        
        private void numClicksPerSecond_ValueChanged(object sender, EventArgs e)
        {
            _presenter.SetClicksPerSecond((int)numClicksPerSecond.Value);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _presenter.StartClicking();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _presenter.StopClicking();
        }

        private void cbxPrevent_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.PreventClicking(cbxPrevent.Checked);
        }

        private void cbxRightClick_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.RightClick = cbxRightClick.Checked;
        }

        #endregion

        private void ClickerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hotkey.Deactivate();
        }
    }
}