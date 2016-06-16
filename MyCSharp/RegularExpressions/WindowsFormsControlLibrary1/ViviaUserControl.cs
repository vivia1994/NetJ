using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class ViviaUserControl: UserControl
    {
        public event ViviaUserControlEvent onButtonClick;

        public delegate void ViviaUserControlEvent(TextBox tb1, TextBox tb2);
        
        public ViviaUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onButtonClick(textBox1, textBox2);
        }
    }
}
