using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //経過時間を表示
            TimeSpan ts = stopwatch.Elapsed;
            label1.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer.Stop();
                startButton.Text = "Start";
            }
            else
            {
                stopwatch.Start();
                timer.Start();
                startButton.Text = "Stop";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            label1.Text = "00:00:00";
            startButton.Text = "Start";
        }
    }
}
