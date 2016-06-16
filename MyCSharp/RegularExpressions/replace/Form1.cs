using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = Regex.Replace(textBox1.Text,@"[A-Za-z]\*?", textBox2.Text);//小写字母与大写字母都替换为数字
            MessageBox.Show("替换后的字符串为：" + str);
        }
    }
}
