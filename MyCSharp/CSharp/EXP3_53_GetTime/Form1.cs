using System;
using System.Windows.Forms;

namespace EXP3_53_GetTime
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                DateTime time = DateTime.Now;
                label1.Text = "当前系统时间为：" + time.ToString();
            }
        }
    }
}
