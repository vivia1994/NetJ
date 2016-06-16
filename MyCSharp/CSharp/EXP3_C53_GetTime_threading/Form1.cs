using System;
using System.Threading;
using System.Windows.Forms;

namespace EXP3_C53_GetTime_threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = false;

        public void showTime()
        {
            while (true)
            {
                DateTime dateTime = DateTime.Now;
                textBox1.Text = "当前系统时间为：" + dateTime.ToString();
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            if (flag)
            {
                Thread P_thread = new Thread(new ThreadStart(showTime));
                P_thread.IsBackground = true;
                P_thread.Start();
            }
        }

    }
}

