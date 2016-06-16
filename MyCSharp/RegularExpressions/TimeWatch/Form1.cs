using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimeWatch
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopWatch.Start();
            label1.Text = "程序已经运行：" + string.Format("{0}分{1}秒", stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds);
        }
    }
}
