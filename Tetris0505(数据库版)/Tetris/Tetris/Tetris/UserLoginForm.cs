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
            //this.Close();
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //login.Focus();
            if (userMessage.Text == "")
            {
                MessageBox.Show("请输入用户名！");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            //密码正确时：无此用户(先检查用户名)
            //待解决：线程失控
            //点击右键：关闭窗口，不能关闭程序
            string score = teris.UserLogin(userMessage.Text.Trim(), password.Text.Trim());
            if (score.Equals("wrong"))
            {
                MessageBox.Show("密码错误！");
            }
            else
            {
                StartForm startForm = new StartForm(userMessage.Text.Trim(), Convert.ToInt32(score));
                startForm.Show();
                this.Visible = false;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void UserLoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            
                if (key == Keys.Enter)
                {
                    AcceptButton = login;
                    login_Click(sender , e);
                }

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void UserLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

  

}
