using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace IsURL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViviaUserControl.ViviaUserControlEvent ve = new ViviaUserControl.ViviaUserControlEvent(Fun);
            viviaUserControl1.onButtonClick += ve;

        }

        void Fun(TextBox tb1, TextBox tb2)
        {
            MessageBox.Show(tb1.Text + tb2.Text);
        }
    }
}
