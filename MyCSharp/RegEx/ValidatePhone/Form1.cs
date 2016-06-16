using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidatePhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox1.Text , @"^(\d{3,4}-)?\d{6,8}$"))
            {
                MessageBox.Show("成功");
            }
            
        }
    }
}
