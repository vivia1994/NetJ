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
	public partial class MainForm : Form
	{
		UserManager userManager;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.lblUsername.Text = PublicData.Username;
			userManager = new UserManager();
			string errorMessage;
			int allScore;
			if(!userManager.GetScore(PublicData.Username, out allScore, out errorMessage))
			{
				MessageBox.Show(errorMessage);
				this.Close();
			}
			this.lblAllScore.Text = allScore.ToString();
		}

		private void btnHit_Click(object sender, EventArgs e)
		{
			this.lblThisScore.Text = (int.Parse(lblThisScore.Text) + 1).ToString();
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			string errorMessage;
			if(!userManager.SetScore(PublicData.Username, int.Parse(lblThisScore.Text) + int.Parse(lblAllScore.Text), out errorMessage))
			{
				MessageBox.Show(errorMessage);
				this.Close();
			}
			this.lblAllScore.Text = (int.Parse(lblThisScore.Text) + int.Parse(lblAllScore.Text)).ToString();
			this.lblThisScore.Text = "0";
			MessageBox.Show("提交得分成功!");
		}
	}
}
