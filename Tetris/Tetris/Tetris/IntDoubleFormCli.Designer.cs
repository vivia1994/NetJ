namespace Tetris
{
    partial class IntDoubleFormCli
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tmr1 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.scoreBestName = new System.Windows.Forms.Label();
			this.scoreBest = new System.Windows.Forms.Label();
			this.chatbox = new System.Windows.Forms.TextBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.send = new System.Windows.Forms.Button();
			this.btn连接 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.游戏设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.难度ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.继续ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(508, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 498);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "当前系统时间为：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 498);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "您已经玩了：0时0分0秒";
			// 
			// tmr1
			// 
			this.tmr1.Interval = 500;
			this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(429, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 12);
			this.label5.TabIndex = 12;
			this.label5.Text = "当前的分数：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(531, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 12);
			this.label6.TabIndex = 13;
			this.label6.Text = "分";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(429, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 14;
			this.label7.Text = "最高纪录：";
			// 
			// scoreBestName
			// 
			this.scoreBestName.AutoSize = true;
			this.scoreBestName.Location = new System.Drawing.Point(501, 200);
			this.scoreBestName.Name = "scoreBestName";
			this.scoreBestName.Size = new System.Drawing.Size(41, 12);
			this.scoreBestName.TabIndex = 15;
			this.scoreBestName.Text = "label8";
			// 
			// scoreBest
			// 
			this.scoreBest.AutoSize = true;
			this.scoreBest.Location = new System.Drawing.Point(548, 200);
			this.scoreBest.Name = "scoreBest";
			this.scoreBest.Size = new System.Drawing.Size(41, 12);
			this.scoreBest.TabIndex = 16;
			this.scoreBest.Text = "label8";
			// 
			// chatbox
			// 
			this.chatbox.Location = new System.Drawing.Point(431, 290);
			this.chatbox.Multiline = true;
			this.chatbox.Name = "chatbox";
			this.chatbox.Size = new System.Drawing.Size(167, 158);
			this.chatbox.TabIndex = 17;
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(12, 463);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(401, 21);
			this.textBox.TabIndex = 18;
			// 
			// send
			// 
			this.send.Location = new System.Drawing.Point(434, 461);
			this.send.Name = "send";
			this.send.Size = new System.Drawing.Size(60, 23);
			this.send.TabIndex = 19;
			this.send.Text = "发送";
			this.send.UseVisualStyleBackColor = true;
			this.send.Click += new System.EventHandler(this.send_Click);
			// 
			// btn连接
			// 
			this.btn连接.Location = new System.Drawing.Point(546, 461);
			this.btn连接.Name = "btn连接";
			this.btn连接.Size = new System.Drawing.Size(52, 23);
			this.btn连接.TabIndex = 20;
			this.btn连接.Text = "连接";
			this.btn连接.UseVisualStyleBackColor = true;
			this.btn连接.Click += new System.EventHandler(this.btn连接_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(431, 263);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(167, 21);
			this.textBox1.TabIndex = 21;
			this.textBox1.Text = "127.0.0.1";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(427, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 12);
			this.label8.TabIndex = 22;
			this.label8.Text = "请输入服务器地址：";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏设置ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(610, 25);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 游戏设置ToolStripMenuItem
			// 
			this.游戏设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.难度ToolStripMenuItem,
            this.难度ToolStripMenuItem1,
            this.退出ToolStripMenuItem});
			this.游戏设置ToolStripMenuItem.Name = "游戏设置ToolStripMenuItem";
			this.游戏设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.游戏设置ToolStripMenuItem.Text = "游戏设置";
			// 
			// 控制ToolStripMenuItem
			// 
			this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新局ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.继续ToolStripMenuItem});
			this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
			this.控制ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.控制ToolStripMenuItem.Text = "控制";
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.操作说明ToolStripMenuItem});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// 难度ToolStripMenuItem
			// 
			this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
			this.难度ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.难度ToolStripMenuItem.Text = "难度↑";
			this.难度ToolStripMenuItem.Click += new System.EventHandler(this.难度ToolStripMenuItem_Click);
			// 
			// 难度ToolStripMenuItem1
			// 
			this.难度ToolStripMenuItem1.Name = "难度ToolStripMenuItem1";
			this.难度ToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
			this.难度ToolStripMenuItem1.Text = "难度↓";
			this.难度ToolStripMenuItem1.Click += new System.EventHandler(this.难度ToolStripMenuItem1_Click);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// 操作说明ToolStripMenuItem
			// 
			this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
			this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.操作说明ToolStripMenuItem.Text = "操作说明";
			this.操作说明ToolStripMenuItem.Click += new System.EventHandler(this.操作说明ToolStripMenuItem_Click);
			// 
			// 新局ToolStripMenuItem
			// 
			this.新局ToolStripMenuItem.Name = "新局ToolStripMenuItem";
			this.新局ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.新局ToolStripMenuItem.Text = "新局";
			this.新局ToolStripMenuItem.Click += new System.EventHandler(this.新局ToolStripMenuItem_Click);
			// 
			// 暂停ToolStripMenuItem
			// 
			this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
			this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.暂停ToolStripMenuItem.Text = "暂停";
			this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click_1);
			// 
			// 继续ToolStripMenuItem
			// 
			this.继续ToolStripMenuItem.Name = "继续ToolStripMenuItem";
			this.继续ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.继续ToolStripMenuItem.Text = "继续";
			this.继续ToolStripMenuItem.Click += new System.EventHandler(this.继续ToolStripMenuItem_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(431, 28);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(141, 140);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(12, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(401, 420);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// IntDoubleFormCli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 525);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn连接);
			this.Controls.Add(this.send);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.chatbox);
			this.Controls.Add(this.scoreBest);
			this.Controls.Add(this.scoreBestName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "IntDoubleFormCli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "俄罗斯方块_联机客户";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleForm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer tmr1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label scoreBestName;
		private System.Windows.Forms.Label scoreBest;
        private System.Windows.Forms.TextBox chatbox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button btn连接;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 游戏设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新局ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 继续ToolStripMenuItem;
    }
}

