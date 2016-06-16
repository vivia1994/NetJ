using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Cachet
{
    public partial class Frm_Text : Form
    {
        public Frm_Text()
        {
            InitializeComponent();
        }
        Rectangle rect = new Rectangle(10, 10, 160, 160);
        Font Var_Font = new Font("Arial", 12, FontStyle.Bold);

        private void button1_Click(object sender, EventArgs e)
        {
            int tem_Line = 0;                                //圆的直径
            int circularity_W = 4;                          //圆画笔的粗细
            if (panel1.Width >= panel1.Height)
                tem_Line = panel1.Height;
            else
                tem_Line = panel1.Width;

            rect = new Rectangle(circularity_W, circularity_W, tem_Line - circularity_W * 2, tem_Line - circularity_W * 2);
            Font star_Font = new Font("Arial", 30, FontStyle.Regular);
            string star_Str = "☆";
            Graphics g = this.panel1.CreateGraphics();      //实例化Graphics类

            g.SmoothingMode = SmoothingMode.AntiAlias;      //消除绘制图形的锯齿,AntiAlias:消除锯齿

            g.Clear(Color.White);                           //以白色清空panel1的背景

            Pen myPen = new Pen(Color.Red, circularity_W);
            g.DrawEllipse(myPen, rect);

            SizeF Var_size = new SizeF(rect.Width, rect.Width);                    //SizeF存储有序浮点数对，通常为矩形的宽度和高度。
            Var_size = g.MeasureString(star_Str, star_Font);
            /*Graphics.MeasureString 方法 (String, Font) ，测量用指定的 Font 对象绘制的指定字符串，
            返回 SizeF 结构。返回的SizeF就是测量字符串的打印在屏幕上的宽度和高度，
            默认以像素为单位，与Form中控件Size的单位一致。*/

            g.DrawString(star_Str, star_Font, myPen.Brush,                       //在指定的位置绘制星号
                new PointF((rect.Width /2F)+circularity_W-Var_size.Width /2F,
                rect.Height/2F-Var_size.Width/2F));
            Var_size = g.MeasureString("专用章", Var_Font);
            g.DrawString("专用章", Var_Font, myPen.Brush, 
                new PointF((rect.Width / 2F) + circularity_W - Var_size.Width / 2F, 
                rect.Height / 2F + Var_size.Height * 2));
            string tempStr = "上海大学计算机工程学院";
            int len = tempStr.Length;                       //获取字符串长度
            float angle = 180 + (180 - len * 20) / 2;       //设置文字旋转角度
            for (int i = 0; i < len; i++)
            {
                //将指定的平移添加到g的变换矩阵前  
                g.TranslateTransform((tem_Line + circularity_W / 2) / 2, (tem_Line + circularity_W / 2) / 2);
                g.RotateTransform(angle);
                Brush myBrush = Brushes.Red;
                g.DrawString(tempStr.Substring(i, 1), Var_Font, myBrush, 60, 0);        //显示旋转文字
                g.ResetTransform();                 //将g的全局变换矩阵重置为单位矩阵
                angle += 20;                        //置下一个文字的角度
            }
        }
    }
}
