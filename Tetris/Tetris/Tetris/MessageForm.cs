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
	public partial class MessageForm : Form
	{
		bool flag = false;
		Form startForm = null;
		public MessageForm(Form startForm)
		{
			this.startForm = startForm;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			flag = true;
			UserLoginForm login = new UserLoginForm(startForm);
			login.Show();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			flag = true;
			SingleForm start = new SingleForm(startForm);
			start.Show();
			this.Close();
		}

		private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (flag == false)
			{
				startForm.Visible = true;
			}
			
		}

		private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			startForm.Visible = true;
		}
	}
}
