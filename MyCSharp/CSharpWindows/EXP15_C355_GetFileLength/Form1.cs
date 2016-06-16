using System;
using System.IO;
using System.Windows.Forms;

namespace EXP15_C355_GetFileLength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("文件长度：" + 
                    File.Open(file.FileName, FileMode.Open).
                    Length.ToString() + "字节");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file2 = new OpenFileDialog();
            if(file2.ShowDialog() == DialogResult.OK)
            {                           //获取或设置一个选定的文件名的字符串
                MessageBox.Show("文件扩展名为：  " + file2.FileName.Substring(
                    file2.FileName.LastIndexOf('.') + 1,            //StartIndex
                    file2.FileName.Length - file2.FileName.LastIndexOf('.')-1) //Length
                  );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text +=  "\n";
            foreach (char c in Path.GetInvalidFileNameChars())
                richTextBox1.Text += c + "\n";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1 treeView = (treeView1)sender;
            TreeNode selectedNode = treeView.SelectedNode;
        }
    }
}
