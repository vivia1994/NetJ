using System;
using System.Windows.Forms;

namespace EXP3_C35_ToUpperOrLower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                if (radioButton1.Checked)
                    textBox2.Text = textBox1.Text.ToUpper();
                else
                    textBox2.Text = textBox1.Text.ToLower(); 
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "请输入字符串")
             textBox1.Text = string.Empty;
        }
    }
}
