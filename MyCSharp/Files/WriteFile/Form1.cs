using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "文本文件（*.txt）|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
            else
                textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("请选择文件！");
                return;
            }
            try
            {
                StreamWriter w = new StreamWriter(textBox1.Text);
                w.Write(textBox2.Text);
                w.Close();
                MessageBox.Show("追加写入文件成功!");

                /*FileStream FStream = File.OpenWrite(textBox1.Text);
                Byte[] info = Encoding.Default.GetBytes(textBox2.Text);
                FStream.Write(info, 0, info.Length);
                FStream.Close();
                MessageBox.Show("成功!");*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
