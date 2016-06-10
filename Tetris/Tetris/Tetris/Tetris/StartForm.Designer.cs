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
			this.btn单人模式 = new System.Windows.Forms.Button();
			this.btn双人模式 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn单人模式
			// 
			this.btn单人模式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn单人模式.Location = new System.Drawing.Point(91, 101);
			this.btn单人模式.Name = "btn单人模式";
			this.btn单人模式.Size = new System.Drawing.Size(117, 40);
			this.btn单人模式.TabIndex = 0;
			this.btn单人模式.Text = "单人模式";
			this.btn单人模式.UseVisualStyleBackColor = true;
			this.btn单人模式.Click += new System.EventHandler(this.btn单人模式_Click);
			// 
			// btn双人模式
			// 
			this.btn双人模式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
			this.btn双人模式.Location = new System.Drawing.Point(89, 158);
			this.btn双人模式.Name = "btn双人模式";
			this.btn双人模式.Size = new System.Drawing.Size(117, 40);
			this.btn双人模式.TabIndex = 1;
			this.btn双人模式.Text = "双人模式";
			this.btn双人模式.UseVisualStyleBackColor = true;
			this.btn双人模式.Click += new System.EventHandler(this.btn双人模式_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Tetris.Properties.Resources.Exit;
			this.pictureBox1.Location = new System.Drawing.Point(221, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn双人模式);
			this.Controls.Add(this.btn单人模式);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "StartForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.StartForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn单人模式;
        private System.Windows.Forms.Button btn双人模式;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}