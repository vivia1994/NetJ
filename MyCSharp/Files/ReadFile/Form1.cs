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

namespace ReadFile
{
    public partial class Form1 : Form
    {
       // static Encoding enc8 = Encoding.UTF8;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
          //  string txt;
            try
            {
                openFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"; //文件(*.txt)|*.txt
                openFileDialog1.ShowDialog();
                textBox1.Text = openFileDialog1.FileName;
                FileStream fs = File.OpenRead(textBox1.Text);
                byte[] b = new byte[1024];  //每次读取1024个字节到缓存中
              //  txt = enc8.GetString(b);
                while(fs.Read(b,0,b.Length) > 0)
                {
                    textBox2.Text = Encoding.Default.GetString(b);
                }
                fs.Close();
            }
            catch
            {
                MessageBox.Show("请选择文件！");
            }
        }
    }
}
