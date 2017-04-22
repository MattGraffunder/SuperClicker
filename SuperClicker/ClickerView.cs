﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;
using SuperClicker.ClickStrategies;

//using System.Windows.Forms.Cursor;

namespace SuperClicker
{

    public partial class ClickerView : Form
    {
        Clicker _clicker;

        HotKey _hk;

        private const int DEFAULT_CLICKS_PER_SECOND = 50;
        private int _clicksPerSecond;

        public ClickerView()
        {
            InitializeComponent();
            
            _clicker = new Clicker(DEFAULT_CLICKS_PER_SECOND);
            _clicker.ClickStatusUpdated += clicker_ClickStatusUpdated;

            _clicksPerSecond = DEFAULT_CLICKS_PER_SECOND;
            numClicksPerSecond.Value = _clicksPerSecond;

            _hk = new HotKey(Keys.Space, this);
            _hk.Register();
        }

        private void clicker_ClickStatusUpdated(object sender, System.EventArgs e)
        {
            UpdateLabel();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _clicker.StopClicking();
        }

        private void UpdateLabel()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(UpdateLabel));
            }
            else
            {
                lblClicks.Text = _clicker.Clicks.ToString("0,0");
            }
        }

        private void HandleHotkey()
        {
            if (_clicker.Active)
            {
                _clicker.StopClicking();
            }
            else
            {
                StartClicking();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                HandleHotkey();
            }

            base.WndProc(ref m);
        }

        private void cbxPrevent_CheckedChanged(object sender, EventArgs e)
        {
            _clicker.PreventClicking = cbxPrevent.Checked;
        }

        private void StartClicking()
        {
            //Determine if right or left click
            ClickType type = cbxRightClick.Checked ? ClickType.Right : ClickType.Left;

            _clicker.StartClicking(type);
        }

        private void numClicksPerSecond_ValueChanged(object sender, System.EventArgs e)
        {
            int clicksPerSecond = (int)numClicksPerSecond.Value;

            if (clicksPerSecond < 1)
            {
                clicksPerSecond = 1;
                numClicksPerSecond.Value = 1;
            }

            if (clicksPerSecond > 100)
            {
                clicksPerSecond = 100;
                numClicksPerSecond.Value = 100;
            }

            _clicker.ClicksPerSecond = (int)numClicksPerSecond.Value;
        }
    }
}