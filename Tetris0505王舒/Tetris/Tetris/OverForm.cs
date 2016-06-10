using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


//"Vivia@wolfogre.com", "123456ABCabc"

namespace Tetris
{
    public partial class OverForm : Form
    {
        public SingleForm parent;
        int score;
        public OverForm(int score = 0)
        {
            InitializeComponent();
            this.score = score;
            //textBox1.Text = string.Format("{0}",score);
        }
        //public OverForm(Form1 parent)           //构造函数
        // {
        //   InitializeComponent();
        //  this.parent = parent;
        // }

        private void button1_Click(object sender, EventArgs e)
        {
            /*验证邮箱格式是否正确*/
            Regex rightEmail = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            if (!rightEmail.IsMatch(textBox1.Text))
            {
                MessageBox.Show("请输入正确的邮箱");
            }
            else
            {
                sendEmail();
            }
            
        }

        private void OverForm_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        
        public void sendEmail()
        {

            MailAddress mailFrom = new MailAddress("Vivia@wolfogre.com", "俄罗斯游戏官方账号", Encoding.UTF8);//声明邮件发送者
            MailAddress mailTo = new MailAddress(textBox1.Text, "玩家", Encoding.UTF8);//声明邮件接受者

            MailMessage message = new MailMessage(mailFrom, mailTo);//创建邮件
            message.Subject = "俄罗斯方块游戏通知";                             //邮件主题
            message.SubjectEncoding = Encoding.UTF8;               //邮件主题使用的编码

            message.Body = "恭喜！\n 您获得了" + score + "分！";                   //获取或设置邮件的正文
            message.BodyEncoding = Encoding.UTF8;                   //邮件内容使用的编码
            message.IsBodyHtml = false;                             //是否是HTML格式

            SmtpClient client = new SmtpClient("smtp.wolfogre.com");//创建邮箱发送客户端
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("Vivia@wolfogre.com", "123456ABCabc");//vivia@wolfogre.com  设定用户凭证
            try
            {
                label2.Visible = true;
                client.Send(message);
                MessageBox.Show("发送成功");
                label2.Visible = false;
                button1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("发送失败");
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void OverForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if(key == Keys.Enter)
            {
                AcceptButton = button1;
                button1_Click(sender , e);

            }
        }
    }
}
