using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Teris_Mysql;
namespace Tetris
{
	public partial class UserLoginForm : Form
	{
		Bitmap bit;
		Teris teris = new Teris();
		public UserLoginForm()
		{
			InitializeComponent();
		}

		private void UserLoginForm_Load(object sender, EventArgs e)
		{

			bit = global::Tetris.Properties.Resources.Circle;
			bit.MakeTransparent(Color.Blue);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawImage((Image)bit, new Point(0, 0));//在窗体上绘制图片
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void login_Click(object sender, EventArgs e)
		{
			string score = teris.UserLogin(userMessage.Text.Trim(), password.Text.Trim());
			if (score.Equals("wrong"))
			{
				MessageBox.Show("密码错误！");
			}
			else
			{
				StartForm startForm = new StartForm(userMessage.Text.Trim(),Convert.ToInt32(score));
				startForm.Show();
			}
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
