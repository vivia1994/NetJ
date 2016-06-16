using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseDRectangle
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen myPen = new Pen(Color.Blue, 3);
            graphics.DrawRectangle(myPen, 10, 10, 10, 10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(20, 20, 20, 20);
            Pen Pen1 = new Pen(Color.Black, 2);
            g.DrawRectangle(Pen1, rectangle);
        }
    }
}
