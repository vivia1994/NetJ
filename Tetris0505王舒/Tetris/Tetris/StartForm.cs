using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class StartForm : Form
    {
        Bitmap bit;
        public StartForm()
        {
            InitializeComponent();
        }

        private void btn单人模式_Click(object sender, EventArgs e)
        {
            this.Visible = false;
			MessageForm message = new MessageForm(this);
			message.ShowDialog();
        }

        private void btn双人模式_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DoubleForm df = new DoubleForm();
            df.ShowDialog();
            this.Visible = true;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            bit = global::Tetris.Properties.Resources.Circle;
            bit.MakeTransparent(Color.Blue);
        }
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawImage((Image)bit, new Point(0, 0));//在窗体上绘制图片
		}
        
        private void pctrBtnClose_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
