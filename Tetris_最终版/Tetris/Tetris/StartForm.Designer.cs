namespace Tetris
{
    partial class StartForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.btn单人模式 = new System.Windows.Forms.Button();
			this.btn双人模式 = new System.Windows.Forms.Button();
			this.btn新建 = new System.Windows.Forms.Button();
			this.btn加入 = new System.Windows.Forms.Button();
			this.pctrBtnClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pctrBtnClose)).BeginInit();
			this.SuspendLayout();
			// 
			// btn单人模式
			// 
			this.btn单人模式.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn单人模式.BackgroundImage")));
			this.btn单人模式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn单人模式.Location = new System.Drawing.Point(91, 62);
			this.btn单人模式.Name = "btn单人模式";
			this.btn单人模式.Size = new System.Drawing.Size(117, 40);
			this.btn单人模式.TabIndex = 0;
			this.btn单人模式.Text = "单人模式";
			this.btn单人模式.UseVisualStyleBackColor = true;
			this.btn单人模式.Click += new System.EventHandler(this.btn单人模式_Click);
			// 
			// btn双人模式
			// 
			this.btn双人模式.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn双人模式.BackgroundImage")));
			this.btn双人模式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
			this.btn双人模式.Location = new System.Drawing.Point(91, 109);
			this.btn双人模式.Name = "btn双人模式";
			this.btn双人模式.Size = new System.Drawing.Size(117, 40);
			this.btn双人模式.TabIndex = 1;
			this.btn双人模式.Text = "双人模式";
			this.btn双人模式.UseVisualStyleBackColor = true;
			this.btn双人模式.Click += new System.EventHandler(this.btn双人模式_Click);
			// 
			// btn新建
			// 
			this.btn新建.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn新建.BackgroundImage")));
			this.btn新建.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
			this.btn新建.Location = new System.Drawing.Point(91, 155);
			this.btn新建.Name = "btn新建";
			this.btn新建.Size = new System.Drawing.Size(117, 40);
			this.btn新建.TabIndex = 3;
			this.btn新建.Text = "联机新建";
			this.btn新建.UseVisualStyleBackColor = true;
			this.btn新建.Click += new System.EventHandler(this.btn新建_Click);
			// 
			// btn加入
			// 
			this.btn加入.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn加入.BackgroundImage")));
			this.btn加入.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
			this.btn加入.Location = new System.Drawing.Point(91, 201);
			this.btn加入.Name = "btn加入";
			this.btn加入.Size = new System.Drawing.Size(117, 40);
			this.btn加入.TabIndex = 4;
			this.btn加入.Text = "联机加入";
			this.btn加入.UseVisualStyleBackColor = true;
			this.btn加入.Click += new System.EventHandler(this.btn加入_Click);
			// 
			// pctrBtnClose
			// 
			this.pctrBtnClose.Image = global::Tetris.Properties.Resources.Exit;
			this.pctrBtnClose.Location = new System.Drawing.Point(221, 51);
			this.pctrBtnClose.Name = "pctrBtnClose";
			this.pctrBtnClose.Size = new System.Drawing.Size(25, 25);
			this.pctrBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctrBtnClose.TabIndex = 2;
			this.pctrBtnClose.TabStop = false;
			this.pctrBtnClose.Click += new System.EventHandler(this.pctrBtnClose_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.ControlBox = false;
			this.Controls.Add(this.btn加入);
			this.Controls.Add(this.btn新建);
			this.Controls.Add(this.pctrBtnClose);
			this.Controls.Add(this.btn双人模式);
			this.Controls.Add(this.btn单人模式);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "StartForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.StartForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctrBtnClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn单人模式;
        private System.Windows.Forms.Button btn双人模式;
        private System.Windows.Forms.PictureBox pctrBtnClose;
        private System.Windows.Forms.Button btn新建;
        private System.Windows.Forms.Button btn加入;
    }
}