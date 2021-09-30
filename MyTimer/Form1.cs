using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MyTimer
{
    public partial class Form1 : Form
    {
        int interval = 1000;
        int sleep = 0;
        int count = 0;

        //创建新线程,间隔interval后启动
        System.Timers.Timer timersTimer;
        //可指定延迟启动新线程,延迟为0时立即启动
        System.Threading.Timer threadingTimer;
        //由主线程执行,间隔interval后启动
        System.Windows.Forms.Timer formsTimer;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            StopTimers();
        }

        private void btnTimersTimer_Click(object sender, EventArgs e)
        {
            lblMainId.Text = Thread.CurrentThread.ManagedThreadId.ToString();

            timersTimer = new System.Timers.Timer();
            //timersTimer.AutoReset = false;
            timersTimer.Interval = this.interval;
            timersTimer.Elapsed += (x, y) =>
            {
                var dt = DateTime.Now;
                Thread.Sleep(sleep);
                //lblSonId.Text = Thread.CurrentThread.ManagedThreadId.ToString();
                //lblMessage.Text = DateTime.Now.ToString();
                ShowMessageThread(Thread.CurrentThread.ManagedThreadId, dt);
            };
            timersTimer.Start();
        }

        private void btnThreadingTimer_Click(object sender, EventArgs e)
        {
            lblMainId.Text = Thread.CurrentThread.ManagedThreadId.ToString();

            //跨线程访问
            threadingTimer = new System.Threading.Timer((x) =>
            {
                var dt = DateTime.Now;
                Thread.Sleep(sleep);
                ShowMessageThread(Thread.CurrentThread.ManagedThreadId, dt);
            }, null, 0, this.interval);

        }

        private void btnFormsTimer_Click(object sender, EventArgs e)
        {
            lblMainId.Text = Thread.CurrentThread.ManagedThreadId.ToString();

            formsTimer = new System.Windows.Forms.Timer();
            formsTimer.Interval = this.interval;
            formsTimer.Tick += (x, y) =>
            {
                var dt = DateTime.Now;
                Thread.Sleep(sleep);
                ShowMessage(Thread.CurrentThread.ManagedThreadId, dt);
            };
            formsTimer.Start();
        }


        private void ShowMessageThread(int threadId, DateTime dt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int, DateTime>(this.ShowMessage), threadId, dt);
            }
            else
            {
                ShowMessage(threadId, dt);
            }
        }

        private void ShowMessage(int threadId, DateTime dt)
        {
            //lock (locker)
            count++;


            lblSonId.Text = threadId.ToString();
            lblCount.Text = count.ToString();
            lblMessage.Text = dt.ToString("hh:mm:ss.fff");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            StopTimers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopTimers();
        }

        private void StopTimers()
        {
            count = 0;
            lblMainId.Text = lblSonId.Text = lblCount.Text = lblMessage.Text = "";

            if (timersTimer != null) timersTimer.Dispose();
            if (threadingTimer != null) threadingTimer.Dispose();
            if (formsTimer != null) formsTimer.Dispose();
        }
    }
}
