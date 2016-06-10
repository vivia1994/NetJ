namespace Tetris
{
    partial class SingleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_NewGame = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnDiffculity = new System.Windows.Forms.Button();
            this.btnSimple = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scoreBestName = new System.Windows.Forms.Label();
            this.scoreBest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(441, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 140);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(440, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 101);
            this.label1.TabIndex = 2;
            this.label1.Text = "游戏说明：\r\n  通过方向键控制砖块。\r\n  向上键：变形   \r\n  向左键：左移\r\n  向下键：下移   \r\n  向右键：右移";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(508, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // Btn_NewGame
            // 
            this.Btn_NewGame.Location = new System.Drawing.Point(429, 296);
            this.Btn_NewGame.Name = "Btn_NewGame";
            this.Btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.Btn_NewGame.TabIndex = 4;
            this.Btn_NewGame.Text = "新局";
            this.Btn_NewGame.UseVisualStyleBackColor = true;
            this.Btn_NewGame.Click += new System.EventHandler(this.Btn_NewGame_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Enabled = false;
            this.Btn_Stop.Location = new System.Drawing.Point(429, 337);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.Btn_Stop.TabIndex = 5;
            this.Btn_Stop.Text = "暂停";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(429, 379);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Quit.TabIndex = 7;
            this.Btn_Quit.Text = "退出";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "当前系统时间为：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 458);
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
            // btnDiffculity
            // 
            this.btnDiffculity.Enabled = false;
            this.btnDiffculity.Location = new System.Drawing.Point(510, 296);
            this.btnDiffculity.Name = "btnDiffculity";
            this.btnDiffculity.Size = new System.Drawing.Size(75, 23);
            this.btnDiffculity.TabIndex = 10;
            this.btnDiffculity.Text = "难度↑";
            this.btnDiffculity.UseVisualStyleBackColor = true;
            this.btnDiffculity.Click += new System.EventHandler(this.btnDiffculity_Click);
            // 
            // btnSimple
            // 
            this.btnSimple.Enabled = false;
            this.btnSimple.Location = new System.Drawing.Point(510, 337);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSimple.TabIndex = 11;
            this.btnSimple.Text = "难度↓";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "当前的分数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "最高纪录：";
            // 
            // scoreBestName
            // 
            this.scoreBestName.AutoSize = true;
            this.scoreBestName.Location = new System.Drawing.Point(501, 245);
            this.scoreBestName.Name = "scoreBestName";
            this.scoreBestName.Size = new System.Drawing.Size(41, 12);
            this.scoreBestName.TabIndex = 15;
            this.scoreBestName.Text = "label8";
            // 
            // scoreBest
            // 
            this.scoreBest.AutoSize = true;
            this.scoreBest.Location = new System.Drawing.Point(548, 245);
            this.scoreBest.Name = "scoreBest";
            this.scoreBest.Size = new System.Drawing.Size(41, 12);
            this.scoreBest.TabIndex = 16;
            this.scoreBest.Text = "label8";
            // 
            // SingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 479);
            this.Controls.Add(this.scoreBest);
            this.Controls.Add(this.scoreBestName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.btnDiffculity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_NewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SingleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块_单人模式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_NewGame;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnDiffculity;
        private System.Windows.Forms.Button btnSimple;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label scoreBestName;
		private System.Windows.Forms.Label scoreBest;
    }
}

