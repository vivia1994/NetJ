using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UseDEllipse
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics ellipse = this.CreateGraphics();       //创建Graphics对象
            ellipse.SmoothingMode = SmoothingMode.AntiAlias;
            Pen myPen = new Pen(Color.Red, 4);
            Rectangle rectangle = new Rectangle(50, 50, 100, 100);
            ellipse.DrawEllipse(myPen, rectangle);

        }
    }
}
