using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strA;
        string strB;

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text != "1")
            {
                errorPassword.SetError(textBox2, "登录名错误");
            }
            else
            {
                errorPassword.SetError(textBox2, "");
                strB = textBox2.Text;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != "1")
            {
               // errorUser.SetError(textBox1, "登录名错误");
            }
            else
            {
                errorUser.SetError(textBox1, "");
                strA = textBox1.Text;
            }
        }
    }
}
