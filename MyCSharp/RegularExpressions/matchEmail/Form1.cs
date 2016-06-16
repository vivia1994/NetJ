using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(IsEmail(textBox1.Text))
            {
                textBox2.Text = "邮箱格式正确！";
            }

           else if(IsIP(textBox1.Text))
            {
                textBox2.Text = "IP地址正确！";

            }
           else if(IsIP2(textBox3.Text))
            {
                textBox2.Text = "IP地址正确！";

            }
            else if (!IsIP2(textBox3.Text))
            {
                textBox2.Text = "IP地址错误！";
            }
            else if(!IsIP(textBox1.Text))
            {
                textBox2.Text = "IP地址错误！";
            }
           else if(!IsEmail(textBox1.Text))
            {
                textBox2.Text = "邮箱格式错误！";
            }
        }
        /// <summary>
        /// 用正则表达式方法验证是否是ip地址
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool IsIP(string ip)
        {
           string num = @"^25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d$";      //[1-9]?\d ： 包括个位数与十位数的情况
            return Regex.IsMatch(ip, ("^" + num + "\\." + num + "\\." + num + "\\." + num  + "$"));
        }
        /// <summary>
        /// 用split方法验证是否是ip地址
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool IsIP2(string ip)
        {
            int j;
            string[] str = Regex.Split(ip, @"\.");
            if(str.Length != 4)
            {
                return false;
            }
            foreach(string s in str)
            {
                if (!Int32.TryParse(s, out j) || j > 255 || j < 0)
                    return false;
            }
            return true;
            
        }


        public bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"^(\s*([A-Za-z0-9]+)@([0-9]{1,5}.\w{2,5}\s*))$");
            //^\\s * ([A - Za - z0 - 9_ -] + (\\.\\w +)*@(\\w +\\.)+\\w{ 2,5})\\s *$
            //*匹配上一个元素0次或多次
        }
    }
}
