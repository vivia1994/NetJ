using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseDPolygon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 3);
            Point myPoint1 = new Point(80,20);
            Point myPoint2 = new Point(40, 50);
            Point myPoint3 = new Point(80, 80);
            Point myPoint4 = new Point(160, 80);
            Point myPoint5 = new Point(200, 50);
            Point myPoint6 = new Point(160, 20);
            Point[] myPoint = { myPoint1, myPoint2 , myPoint3 , myPoint4 , myPoint5 , myPoint6 };
            g.DrawPolygon (myPen, myPoint);
        }
    }
}
