using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexRepeat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //“\w”除可以匹配[a-zA-Z0-9_]外，还可以匹配一些Unicode字符集，如汉字，全角数字等等。
        //通常情况下，正则表达式中所谓的“单词”，就是由“\w”所定义的字符所组成的子串。
        //“\b”匹配单词边界，不匹配任何字符。
        //“\b”匹配的只是一个位置，这个位置的一侧是构成单词的字符，
        //另一侧为非单词字符、字符串的开始或结束位置。“\b”是零宽度的。

        private void button1_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(textBox1.Text, 
                @"\b(?<x>\w+)\s+(\k<x>)\b",     //？可有可无
                RegexOptions.Compiled | RegexOptions.IgnoreCase);        //| RegexOptions.IgnoreCase  :忽略大小写
            if(matches.Count != 0)
            {
                foreach(Match match in matches) //数组遍历
                {
                    string word = match.Groups["x"].Value;
                    MessageBox.Show(word.ToString(), "英文单词");
                }

            }
            else
            {
                MessageBox.Show( "无重复单词");
            }
        }


    }
}
