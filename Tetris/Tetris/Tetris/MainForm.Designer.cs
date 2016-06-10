namespace Database
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAllScore = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblThisScore = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnHit = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "总得分：";
			// 
			// lblAllScore
			// 
			this.lblAllScore.AutoSize = true;
			this.lblAllScore.Location = new System.Drawing.Point(159, 69);
			this.lblAllScore.Name = "lblAllScore";
			this.lblAllScore.Size = new System.Drawing.Size(23, 12);
			this.lblAllScore.TabIndex = 3;
			this.lblAllScore.Text = "###";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(159, 43);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(23, 12);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "###";
			// 
			// lblThisScore
			// 
			this.lblThisScore.AutoSize = true;
			this.lblThisScore.Location = new System.Drawing.Point(171, 107);
			this.lblThisScore.Name = "lblThisScore";
			this.lblThisScore.Size = new System.Drawing.Size(11, 12);
			this.lblThisScore.TabIndex = 5;
			this.lblThisScore.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(100, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "此次得分：";
			// 
			// btnHit
			// 
			this.btnHit.Location = new System.Drawing.Point(102, 147);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(75, 23);
			this.btnHit.TabIndex = 6;
			this.btnHit.Text = "打打打！";
			this.btnHit.UseVisualStyleBackColor = true;
			this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnCommit
			// 
			this.btnCommit.Location = new System.Drawing.Point(102, 185);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(75, 23);
			this.btnCommit.TabIndex = 7;
			this.btnCommit.Text = "提交得分";
			this.btnCommit.UseVisualStyleBackColor = true;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.lblThisScore);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblAllScore);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户界面";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAllScore;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblThisScore;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnHit;
		private System.Windows.Forms.Button btnCommit;
	}
}