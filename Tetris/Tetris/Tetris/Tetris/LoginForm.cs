using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
	public partial class LoginForm : Form
	{

		private UserManager userManager;

		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			userManager = new UserManager();
			cbUsername.Items.AddRange(userManager.GetResentUser());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(cbUsername.Text == string.Empty)
			{
				MessageBox.Show("请输入用户名!");
				cbUsername.Focus();
				return;
			}
			if (tbPassword.Text == string.Empty)
			{
				MessageBox.Show("请输入密码!");
				tbPassword.Focus();
				return;
			}
			string errorMessage;
			if (userManager.CheckUser(cbUsername.Text, tbPassword.Text, out errorMessage))
			{
				MessageBox.Show("登录成功!");
				this.DialogResult = DialogResult.OK;
				PublicData.Username = cbUsername.Text;
				this.Close();
			}
			else
				MessageBox.Show("登录失败:" + errorMessage);

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			(new RegisterForm()).ShowDialog();
			this.Visible = true;
		}

	}
}
