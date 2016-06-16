using System;
using System.Drawing;
using System.Windows.Forms;

namespace UseDString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "薇薇爱老公~";
            Font font1 = new Font("楷体", 30);
            SolidBrush brush1 = new SolidBrush(Color.Black);
            Point p1 = new Point(50, 50);
            Graphics g = this.CreateGraphics();
            g.DrawString(str1, font1, brush1, p1);
       

        }
    }
}
