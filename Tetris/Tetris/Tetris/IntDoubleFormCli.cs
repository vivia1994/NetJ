using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Teris_Mysql;
//游戏区域：401, 420
//Location：13, 12

namespace Tetris
{
    public partial class IntDoubleFormCli : Form
    {
		int oldScore = 0;
		Teris teris = new Teris();
		string username = null;
		int score = 0;
		string userScore = null;

        Stopwatch stopWatch;
        Thread PalyTime;

        Canvas m_canvas;        //画布模型
        Graphics m_nextpicgra;  //用于显示下一个砖块的画布
        float m_itemxlength;    //、单个格子宽度
        float m_itemylength;
        bool m_isrun;           //、指示SingleForm窗口是否正在运行

		Form startForm = null;
        public IntDoubleFormCli(string username,int score,Form startForm)
        {
			this.username = username;
			this.score = score;

			this.startForm = startForm;
            InitializeComponent();

        }
		public IntDoubleFormCli(Form startForm)
		{
			this.startForm = startForm;
			InitializeComponent();
		}

        public IntDoubleFormCli()
        {
            InitializeComponent();
            // TODO: Complete member initialization
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Focus();          //、好像并没有什么卵用的设置焦点
            m_canvas = new Canvas();
            m_itemxlength = pictureBox1.Width / m_canvas.m_columns; // 、m_itemxlength：单个格子宽度= x方向上画布的宽/20列
            m_itemylength = pictureBox1.Height / m_canvas.m_rows;   //、m_rows=20  m_columns= 20; 横竖方向都是20个格子大小

            pictureBox2.Size = new Size((int)m_itemxlength * 5, (int)m_itemylength * 5);//、下一个方块出现的PB区域
            m_nextpicgra = pictureBox2.CreateGraphics();

            m_isrun = false;

			teris.ShowScore(scoreBestName, scoreBest, label2, score);
			userScore = label2.Text.Trim();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        // pictureBox1的Refresh()函数会导致界面闪烁，所以需要采用双缓冲来进行绘图
      

        /* Form中添加了按钮后，方向键的KeyDown消息就不响应了。
         * 原因：方向键是作为系统键来处理的，默认方向键的作用是移动焦点，
         * 所以按方向键的效果是焦点不断地在按钮之间转换。
         * 也就是说，按方向键产生的消息被系统处理掉了，
         * 那么我们自己定义的消息响应函数就不会执行了。
         * 解决方案：覆盖默认的系统键处理方式，
         * 如果是方向键就直接返回。*/

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (m_isrun == true)
            {
                if (key == Keys.Up)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickUp();
                    Draw();
                }
                if (key == Keys.Left)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickLeft();
                    Draw();
                }
                if (key == Keys.Right)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickRight();
                    Draw();
                }
                if (key == Keys.Down)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickDown();
                    Draw();
                }
            }
        }

    
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            
        }


       
        /*时钟*/
        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (m_canvas.Run() == true)
            {
                //pictureBox1.Refresh();
                Draw();
                DrawNext();
				label2.Text =  (Convert.ToInt32(userScore) + m_canvas.m_score).ToString() ;
				if (m_canvas.m_score > oldScore)
				{
					getScoreToSend("我得一分啦！","[系统提示]恭喜您获得一分");
				}
				oldScore = m_canvas.m_score;
            }
            else
            {
                tmr1.Enabled = false;
                stopWatch.Stop();          //游戏结束，停止计时
				try
				{
					teris.UpdateScore(username, Convert.ToInt32(label2.Text.Trim()));
				}
				catch
				{
					MessageBox.Show("掉线啦！");
				}
                OverForm f2 = new OverForm(m_canvas.m_score);
                f2.ShowDialog();
            }
        }

        private void SingleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PalyTime != null && PalyTime.IsAlive)
            {
                PalyTime.Abort();
            }
            tmr1.Stop();
			startForm.Visible = true;
        }
        
        private void DrawNext()
        {
            pictureBox2.Refresh();
            m_canvas.DrawNewxBrick(m_nextpicgra, m_itemxlength, m_itemylength);
        }

        private void Draw()
        {
            //初始化画布
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gb = Graphics.FromImage(canvas);

            for (int i = 0; i < m_canvas.m_rows; i++)
            {
                for (int j = 0; j < m_canvas.m_columns; j++)
                {
                    if (m_canvas.m_arr[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        DrawItem(gb, i, j);
                    }
                }
            }
            pictureBox1.BackgroundImage = canvas;
            pictureBox1.Refresh();
        }

        private void DrawItem(Graphics gb, int row, int column)
        {
            float xpos = column * m_itemxlength - 1;
            float ypos = row * m_itemylength - 1;
            gb.FillRectangle(Brushes.Blue, xpos, ypos, m_itemxlength - 2, m_itemylength - 2);
        }

        /*显示系统时间与玩家游戏时间*/
        public void ShowPlayTime()
        {
            while (true)
            {
                DateTime SysTimeNow = DateTime.Now;
                this.Invoke(
                    (MethodInvoker)delegate ()  //、线程不能修改UI的控件，将线程要做的事情交给UI去做
                    {
                        label3.Text = "当前系统时间为：" + SysTimeNow.ToString();
                        label4.Text = "您已经玩了：" + string.Format("{0}时{1}分{2}秒", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds);
                    });
                Thread.Sleep(1000);
            }
        }

        Socket socketsend;
      
        void showmsg(string str)  //在文本框中添加内容
        {
            chatbox.AppendText(str+"\r\n");
        }

        void Recive()//接收
        {
            while (true)
            {
                try 
                {
                   
                    byte[] b = new byte[1024 * 1024 * 2];
                    //实际接收到的有效字节
                    int r = socketsend.Receive(b);
                    if (r == 0)
                    {
                        break;
                    }
                    if (b[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(b, 1, r-1);  //从第二个开始截取，因为第一个元素用来判断服务端发过来的指令。
                        showmsg(socketsend.RemoteEndPoint.ToString() + "说：" + str);
                    }
                }
                catch
                {

                }
            }
        }

     
        private void btn连接_Click(object sender, EventArgs e)
        {
            showmsg("开始连接");
            try
            {
                socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//设置一个socket

                IPAddress ip = IPAddress.Parse(textBox1.Text);//将文本框中的字符串转换成IP地址。
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32("8899"));//创建IPEndpoint对象实例。包含ip地址和端口号
                socketsend.Connect(point);//连接到IPendpoint所在的监听socket
                showmsg("连接成功");
                //开启新线程
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();
            }
            catch(Exception ee) 
			{
				MessageBox.Show(ee.Message);
			}
        }

		public void getScoreToSend(string toOther,string toYourself)
		{
			string str = toOther;//存下文本框中的内容

			byte[] b = System.Text.Encoding.UTF8.GetBytes(str);//将内容转换成二进制流（utf8编码）
			
			socketsend.Send(b);//发送给服务端
			showmsg(toYourself);//将我说的话放到文本框中
		}
        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox.Text.Trim();//存下文本框中的内容
                
                byte[] b = System.Text.Encoding.UTF8.GetBytes(str);//将内容转换成二进制流（utf8编码）
                socketsend.Send(b);//发送给服务端
                showmsg("我说 ：" + str);//将我说的话放到文本框中
				textBox.Text = "";
            }
            catch(Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
        }


		private void 难度ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!m_isrun)
			{
				MessageBox.Show("游戏还未开始！");
			}
			else if (this.tmr1.Interval == 200)
			{
				//btnDiffculity.Enabled = false;      //、速度不能再加快，按钮变灰
				MessageBox.Show("速度达到最快，不能再加速！");
			}
			else if (this.tmr1.Interval <= 2000 && this.tmr1.Interval > 200)             //难度最低设置到2S一次
			{
				tmr1.Interval -= 200;           //、变慢
				stopWatch.Start();
				m_isrun = true;
				tmr1.Start();
			}
		}

		private void 难度ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.tmr1.Interval == 2000)
			{
				MessageBox.Show("速度达到最慢，不能再慢！");      //、不能再变慢，按钮变灰
			}
			else if (this.tmr1.Interval < 2000 && this.tmr1.Interval >= 200)             //难度最低设置到2S一次
			{
				tmr1.Interval += 200;           //、变慢
				stopWatch.Start();
				m_isrun = true;
				tmr1.Start();
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string scoreMessage = label2.Text.Trim();
			if (m_isrun)
			{
				m_isrun = false;
			}
			//m_isrun = false;
			tmr1.Stop();
			//这里是想要退出不保存数据还是保存数据
			try
			{
				teris.UpdateScore(username, Convert.ToInt32(scoreMessage));
			}
			catch
			{
				MessageBox.Show("当前网络不稳定，请确保网络连接顺畅！");
			}
			startForm.Visible = true;
			this.Close();       ///关闭窗口
			//Application.Exit();      ///退出程序
		}

		private void 新局ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//点亮难度↑↓，暂停三个键
			

			tmr1.Interval = 800;
			/**********计时开始  ***************/
			stopWatch = new Stopwatch();
			stopWatch.Start();
			//控制线程
			if (PalyTime != null && PalyTime.IsAlive)
			{
				PalyTime.Abort();
			}
			/*显示系统时间*/
			PalyTime = new Thread(new ThreadStart(ShowPlayTime));
			PalyTime.IsBackground = true;
			PalyTime.Start();

			m_isrun = false;
			tmr1.Stop();

			m_canvas = new Canvas();
			m_isrun = true;
			tmr1.Start();
            
		}

		private void 暂停ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			
			stopWatch.Stop();        //、游戏计时暂停
			m_isrun = false;
			tmr1.Stop();
		
		}

		private void 继续ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			stopWatch.Start();
			m_isrun = true;
			tmr1.Start();
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.Show();
		}

		private void 操作说明ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OperateInsForm operate = new OperateInsForm();
			operate.Show();
		}

    }
}
