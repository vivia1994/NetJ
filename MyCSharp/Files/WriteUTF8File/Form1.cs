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

namespace WriteUTF8File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1= new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
            }
          else
            {
                textBox1.Text = "";
            }

        }
        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim()))  //Trim:删除字符串前后的空格
            {
                MessageBox.Show("请设置文件路径！");
                return;
            }
            if(string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("文本内容为空！！");
                return;
            }
            if (!File.Exists(textBox1.Text))
            {
                /* StreamWriter sw = new StreamWriter(textBox1.Text);//使用默认编码
                 sw.WriteLine(textBox2.Text);
                 MessageBox.Show("文件创建成功", "提示", MessageBoxButtons.OK);
                 sw.Close();}*/
                using (StreamWriter sw = File.CreateText(textBox1.Text))     //使用UTF8编码，创建文件
                {
                    sw.WriteLine(textBox2.Text);
                    MessageBox.Show("文件创建成功", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("文件已经存在！");
            }
        }

    }
}
