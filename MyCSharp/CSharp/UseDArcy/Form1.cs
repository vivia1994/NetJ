using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseDArcy
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.DarkRed, 3);
            Rectangle rectangle = new Rectangle(10, 10, 100, 100);
            Graphics g = this.CreateGraphics();         //创建Graphics对象
            g.DrawArc(myPen, rectangle, 0, 60);
        }
    }
}
