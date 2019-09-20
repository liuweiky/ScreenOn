using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenOn
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(uint esFlags);
        const uint ES_SYSTEM_REQUIRED = 0x00000001;
        const uint ES_DISPLAY_REQUIRED = 0x00000002;
        const uint ES_CONTINUOUS = 0x80000000;

        Thread mDaemonThread;

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form_Resize;
            mStopButton.Enabled = false;

            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Text = "Screen On";
            notifyIcon.BalloonTipText = "Screen On";
            notifyIcon.ShowBalloonTip(1000);
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            notifyIcon.MouseClick += NotifyIcon_MouseClick;

            //mDaemonThread = new Thread(HandleAction);
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        
        private void HandleAction()
        {
            SetThreadExecutionState(ES_CONTINUOUS);

            if (mMonitorCheckBox.Checked && mAwakeCheckBox.Checked)
            {
                SetThreadExecutionState(ES_CONTINUOUS | ES_DISPLAY_REQUIRED | ES_SYSTEM_REQUIRED);
            }
            else if (mMonitorCheckBox.Checked)
            {
                SetThreadExecutionState(ES_CONTINUOUS | ES_DISPLAY_REQUIRED);
            }
            else if (mAwakeCheckBox.Checked)
            {
                SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED);
            }

            if (mTimeCounter.Value != 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds((double)mTimeCounter.Value * 60));
            }
            else
            {
                while (true)
                {
                    Thread.Sleep(10000000);
                }
            }

            SetThreadExecutionState(ES_CONTINUOUS);

            Action action = RefreshButton;
            Invoke(action);
        }

        private void RefreshButton()
        {
            mStopButton.Enabled = false;
            mStartButton.Enabled = true;
        }

        private void AbortThread()
        {
            if (mDaemonThread != null)
            {
                mDaemonThread.Abort();
                mDaemonThread.DisableComObjectEagerCleanup();
                mDaemonThread = null;
            }
        }

        private void MStartButton_Click(object sender, EventArgs e)
        {
            AbortThread();
            mDaemonThread = new Thread(HandleAction);
            mDaemonThread.Start();
            mStopButton.Enabled = true;
            mStartButton.Enabled = false;
        }

        private void MStopButton_Click(object sender, EventArgs e)
        {
            AbortThread();
            mStopButton.Enabled = false;
            mStartButton.Enabled = true;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            AbortThread();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}
