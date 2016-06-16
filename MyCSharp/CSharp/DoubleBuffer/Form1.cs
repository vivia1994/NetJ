
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace DoubleBuffer
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
      
        /*自己开辟一个缓冲区（如一个不显示的Bitmap对象），在其中绘制完成后，再一次性显示*/
       /* private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap localBitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height); //1、在内存中建立一块“虚拟画布” ,创建位图对象
            Graphics bitmapGraphics = Graphics.FromImage(localBitmap);                      //2、获取这块内存画布的Graphics引用  ,创建的画布

            bitmapGraphics.Clear(BackColor);            //3、在这块内存画布上绘图  
            bitmapGraphics.SmoothingMode = SmoothingMode.AntiAlias;
          //  PaintImage(bitmapGraphics);                 //绘制多个图形
            bitmapGraphics.DrawEllipse(Pens.Red, 100, 100, 100, 100);
            bitmapGraphics.DrawRectangle(new Pen(new SolidBrush(Color.Orange), 3), new Rectangle(new Point(240, 260), new Size(90, 50)));
            bitmapGraphics.DrawArc(new Pen(new SolidBrush(Color.Blue), 5), new Rectangle(new Point(250, 170), new Size(60, 60)), 0, 360);
            bitmapGraphics.DrawBeziers(new Pen(new SolidBrush(Color.Green), 2), new Point[] { new Point(220, 100), new Point(250, 180), new Point(300, 70), new Point(350, 150) });
            bitmapGraphics.DrawString("明日科技欢迎您", new Font("宋体", 18, FontStyle.Bold), new SolidBrush(Color.Red), new PointF(110, 20));

            Graphics g = e.Graphics;                    ////4、将内存画布画到窗口中  
            //将内存中的多个图形一次性绘制
            g.DrawImage(localBitmap, 0, 0);

            //5.释放资源
            bitmapGraphics.Dispose();                   //销毁位图对象
            localBitmap.Dispose();                      //销毁画布对象
            g.Dispose();

                    
        }*/

        private void Form1_Paint(object sender, System.EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.DrawEllipse(new Pen(Color.Red,3), 100, 100, 100, 100);
            g1.DrawRectangle(new Pen(new SolidBrush(Color.Orange), 3), new Rectangle(new Point(240, 260), new Size(90, 50)));
            g1.DrawArc(new Pen(new SolidBrush(Color.Blue), 5), new Rectangle(new Point(250, 170), new Size(60, 60)), 0, 360);
            g1.DrawBeziers(new Pen(new SolidBrush(Color.Green), 2), new Point[] { new Point(220, 100), new Point(250, 180), new Point(300, 70), new Point(350, 150) });
            g1.DrawString("明日科技欢迎您", new Font("宋体", 18, FontStyle.Bold), new SolidBrush(Color.Red), new PointF(110, 20));
        }
    }
}
