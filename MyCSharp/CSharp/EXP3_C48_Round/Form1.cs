using System;
using System.Windows.Forms;
namespace EXP3_C48_Round
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            if (double.TryParse(x1, out x) && double.TryParse(y1, out y))
            {
                textBox3.Text = Math.Round( x + y , comboBox1.SelectedIndex + 1).ToString();
                //Round：简单的舍去后面的数字，非标准的四舍五入方法
            }
            else
                MessageBox.Show("请输入数字！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox1.SelectedIndex = 0;     //设置下拉列表值
        }
    }
}
