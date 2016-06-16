using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DisplayRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Thread P_th = new Thread(new ThreadStart(showRunT));
            P_th.IsBackground = true;
            P_th.Start();
        }

        public void showRunT()
        {
            DateTime G_DateTime = DateTime.Now;
            while(true)
            {
                TimeSpan P_timeSpan = DateTime.Now - G_DateTime;
                label1.Text = string.Format("系统已经运行：{0}天{1}时{2}分{3}秒", 
                    P_timeSpan.Days, P_timeSpan.Hours, 
                    P_timeSpan.Minutes, P_timeSpan.Seconds);
                Thread.Sleep(1000);

            }
            
        }
    }
}
