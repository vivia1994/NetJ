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

namespace ReadUTF8File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "文本文件（*.txt）|*.txt";
                open.ShowDialog();
                textBox1.Text = open.FileName;
                StreamReader SReader = File.OpenText(textBox1.Text);
                textBox2.Text = SReader.ReadToEnd();
            }
            catch
            {
                //
            }
        }
    }
}
