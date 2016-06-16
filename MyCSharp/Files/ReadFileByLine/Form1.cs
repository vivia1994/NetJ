using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace ReadFileByLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 按行读取文本文件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                open.Filter = "文本文件（*.txt）|*.txt";
                textBox1.Text = open.FileName;

                StreamReader reader = new StreamReader(textBox1.Text, Encoding.Default);
                //StreamReader:实现一个TextReader，使其以一种特定的编码从字节流中读取字符
                string str = string.Empty;
                
                while((str = reader.ReadLine()) != null)
                {
                    textBox2.Text += str + Environment.NewLine;
                    //字文本框中输出多行文本时，可用静态类的Environment的NewLine属性实现文本的换行显示
                }
            }
            catch { }
        }
    }
}
