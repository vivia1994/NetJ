namespace Tetris
{
    partial class DoubleForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pctrBxBigLft = new System.Windows.Forms.PictureBox();
            this.pctrBxBigRght = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.pctrbxLeft = new System.Windows.Forms.PictureBox();
            this.pctrbxRight = new System.Windows.Forms.PictureBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxBigLft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxBigRght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(501, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏说明：\r\n  通过方向键控制砖块。\r\n  向上键：变形   \r\n  向左键：左移\r\n  向下键：下移   \r\n  向右键：右移\r\n 先得到2分者胜利";
            // 
            // pctrBxBigLft
            // 
            this.pctrBxBigLft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxBigLft.Location = new System.Drawing.Point(12, 12);
            this.pctrBxBigLft.Name = "pctrBxBigLft";
            this.pctrBxBigLft.Size = new System.Drawing.Size(401, 420);
            this.pctrBxBigLft.TabIndex = 1;
            this.pctrBxBigLft.TabStop = false;
            // 
            // pctrBxBigRght
            // 
            this.pctrBxBigRght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxBigRght.Location = new System.Drawing.Point(727, 12);
            this.pctrBxBigRght.Name = "pctrBxBigRght";
            this.pctrBxBigRght.Size = new System.Drawing.Size(401, 420);
            this.pctrBxBigRght.TabIndex = 2;
            this.pctrBxBigRght.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(517, 361);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(517, 328);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(517, 295);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "新局";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.Location = new System.Drawing.Point(446, 413);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(102, 19);
            this.lblLeft.TabIndex = 8;
            this.lblLeft.Text = "甲的分数：0分";
            // 
            // pctrbxLeft
            // 
            this.pctrbxLeft.Location = new System.Drawing.Point(419, 14);
            this.pctrbxLeft.Name = "pctrbxLeft";
            this.pctrbxLeft.Size = new System.Drawing.Size(141, 140);
            this.pctrbxLeft.TabIndex = 13;
            this.pctrbxLeft.TabStop = false;
            // 
            // pctrbxRight
            // 
            this.pctrbxRight.Location = new System.Drawing.Point(577, 14);
            this.pctrbxRight.Name = "pctrbxRight";
            this.pctrbxRight.Size = new System.Drawing.Size(141, 140);
            this.pctrbxRight.TabIndex = 14;
            this.pctrbxRight.TabStop = false;
            // 
            // lblRight
            // 
            this.lblRight.Location = new System.Drawing.Point(575, 413);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(102, 19);
            this.lblRight.TabIndex = 15;
            this.lblRight.Text = "乙的分数：0分";
            // 
            // tmr2
            // 
            this.tmr2.Interval = 500;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // DoubleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 448);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.pctrbxRight);
            this.Controls.Add(this.pctrbxLeft);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.pctrBxBigRght);
            this.Controls.Add(this.pctrBxBigLft);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DoubleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块_双人模式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoubleForm_FormClosing);
            this.Load += new System.EventHandler(this.DoubleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoubleForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxBigLft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxBigRght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctrBxBigLft;
        private System.Windows.Forms.PictureBox pctrBxBigRght;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.PictureBox pctrbxLeft;
        private System.Windows.Forms.PictureBox pctrbxRight;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Timer tmr2;
    }
}