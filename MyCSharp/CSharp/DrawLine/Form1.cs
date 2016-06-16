using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine          //一般用来绘制坐标轴
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen BlackPen = new Pen(Color.Black, 1);     ///3：线的粗细
            Point Point1 = new Point(10, 50);
            Point Point2 = new Point(100, 50);
            Graphics g = this.CreateGraphics();
            g.DrawLine(BlackPen, Point1, Point2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 10);
            Graphics graphics = this.CreateGraphics();
            graphics.DrawLine(myPen, 150, 30, 150, 100);
        }
    }
}
