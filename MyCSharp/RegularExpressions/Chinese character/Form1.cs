using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinese_character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (isChanese(textBox1.Text))
            {
                textBox2.Text = "是汉字！";
            }
            else
            {
                textBox2.Text = "不是汉字！";
            }
        }
        public bool isChanese(string str)
        {
         
            return Regex.IsMatch(str, @"^[\u4e00-\u9fa5]{1,}$");
            //汉字字符编码：4e00-9fa5
            //\u nnnn 使用十六进制表示形式匹配一个 Unicode 字符（由 nnnn 表示的四位数）。

            //  .	通配符：与除 \n 之外的任何单个字符匹配。 
            //若要匹配原意句点字符（. 或 \u002E），您必须在该字符前面加上转义符(\.)。	a.e "have" 中的 "ave"， "mate" 中的 "ate"
        }
    }
}
