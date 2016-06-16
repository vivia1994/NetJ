using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXP3_47_TryNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            double result;
            str = textBox1.Text.ToString();
            try
            {
                if(double.TryParse(str, out result))            //将字符串转换为数字！转换成功返回true和数值，否则为false
                    MessageBox.Show("真棒，您输入了一个数字！");
                else
                    MessageBox.Show("真遗憾，您输入的不是数字！");
            }
            catch(Exception)
            {
                MessageBox.Show("真程序有bug了，赶快叫雷薇来修！￣へ￣！");
            }

            
        }
    }
}
