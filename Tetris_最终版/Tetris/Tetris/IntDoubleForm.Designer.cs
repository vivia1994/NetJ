namespace Tetris
{
    partial class IntDoubleForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scoreBestName = new System.Windows.Forms.Label();
            this.scoreBest = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.chatbox = new System.Windows.Forms.TextBox();
            this.btn监听 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.难度ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继续ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(431, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 140);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(506, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "当前系统时间为：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 495);
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
            this.label5.Location = new System.Drawing.Point(427, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "当前的分数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "最高纪录：";
            // 
            // scoreBestName
            // 
            this.scoreBestName.AutoSize = true;
            this.scoreBestName.Location = new System.Drawing.Point(499, 188);
            this.scoreBestName.Name = "scoreBestName";
            this.scoreBestName.Size = new System.Drawing.Size(41, 12);
            this.scoreBestName.TabIndex = 15;
            this.scoreBestName.Text = "label8";
            // 
            // scoreBest
            // 
            this.scoreBest.AutoSize = true;
            this.scoreBest.Location = new System.Drawing.Point(546, 188);
            this.scoreBest.Name = "scoreBest";
            this.scoreBest.Size = new System.Drawing.Size(41, 12);
            this.scoreBest.TabIndex = 16;
            this.scoreBest.Text = "label8";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 458);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(401, 21);
            this.textBox.TabIndex = 17;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(431, 458);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(54, 23);
            this.send.TabIndex = 18;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(431, 278);
            this.chatbox.Multiline = true;
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(156, 174);
            this.chatbox.TabIndex = 19;
            // 
            // btn监听
            // 
            this.btn监听.Location = new System.Drawing.Point(531, 458);
            this.btn监听.Name = "btn监听";
            this.btn监听.Size = new System.Drawing.Size(55, 23);
            this.btn监听.TabIndex = 20;
            this.btn监听.Text = "监听";
            this.btn监听.UseVisualStyleBackColor = true;
            this.btn监听.Click += new System.EventHandler(this.btn监听_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 20);
            this.comboBox1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "请选择客户端：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏设置ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 25);
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
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 继续ToolStripMenuItem
            // 
            this.继续ToolStripMenuItem.Name = "继续ToolStripMenuItem";
            this.继续ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.继续ToolStripMenuItem.Text = "继续";
            this.继续ToolStripMenuItem.Click += new System.EventHandler(this.继续ToolStripMenuItem_Click);
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
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.操作说明ToolStripMenuItem.Text = "操作说明";
            this.操作说明ToolStripMenuItem.Click += new System.EventHandler(this.操作说明ToolStripMenuItem_Click);
            // 
            // IntDoubleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn监听);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreBest);
            this.Controls.Add(this.scoreBestName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IntDoubleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块_联机服务";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IntDoubleForm_FormClosing);
            this.Load += new System.EventHandler(this.IntdoubleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox chatbox;
        private System.Windows.Forms.Button btn监听;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 游戏设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新局ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 继续ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
    }
}

