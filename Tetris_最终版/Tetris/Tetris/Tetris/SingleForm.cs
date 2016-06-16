using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Teris_Mysql;
//游戏区域：401, 420
//Location：13, 12

namespace Tetris
{
    public partial class SingleForm : Form
    {
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

        public SingleForm(string username,int score)
        {
			this.username = username;
			this.score = score;
            InitializeComponent();
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

        /*难度增加*/
        private void btnDiffculity_Click(object sender, EventArgs e)
        {
            //、待解决：暂停情况时点击也会弹出MessageBox
            if (!m_isrun)                //、暂停时，m_isrun = false，未解决
            {
                MessageBox.Show("游戏还未开始！");
            }
            else if (this.tmr1.Interval == 200)
            {
                btnDiffculity.Enabled = false;      //、速度不能再加快，按钮变灰
            }
            else if (this.tmr1.Interval <= 2000 && this.tmr1.Interval > 200)             //难度最低设置到2S一次
            {
                tmr1.Interval -= 200;           //、变慢
                stopWatch.Start();
                m_isrun = true;
                tmr1.Start();
                btnSimple.Enabled = true;         //、按难度↑之后，btnSimple
            }

        }

        /*难度降低*/
        private void btnSimple_Click(object sender, EventArgs e)
        {
            if (this.tmr1.Interval == 2000)
            {
                btnSimple.Enabled = false;      //、不能再变慢，按钮变灰
            }
            else if(this.tmr1.Interval < 2000 && this.tmr1.Interval >= 200)             //难度最低设置到2S一次
            {
                tmr1.Interval += 200;           //、变慢
                stopWatch.Start();
                m_isrun = true;
                tmr1.Start();
                btnDiffculity.Enabled = true;   //、按难度↓之后，无条件点亮btnDiffculity
            }
        }

        /*新局*/
        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            //点亮难度↑↓，暂停三个键
            btnDiffculity.Enabled = true;
            btnSimple.Enabled = true;
            Btn_Stop.Enabled = true;

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

        /*暂停*/
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if(Btn_Stop.Text == "暂停")
            {
                btnSimple.Enabled = false;
                btnDiffculity.Enabled = false;
                stopWatch.Stop();        //、游戏计时暂停
                m_isrun = false;
                tmr1.Stop();
                Btn_Stop.Text = "继续";


            }
           else if(Btn_Stop.Text == "继续")
            {
                btnSimple.Enabled = true;
                btnDiffculity.Enabled = true;
                stopWatch.Start();
                m_isrun = true;
                tmr1.Start();
                Btn_Stop.Text = "暂停";

            }
            

        }

        /*继续*/
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            
        }

        /*退出*/
        private void Btn_Quit_Click(object sender, EventArgs e)
        {
			string scoreMessage = label2.Text.Trim();
			teris.UpdateScore(username, Convert.ToInt32(scoreMessage));
            this.Close();       ///关闭窗口
            //Application.Exit();      ///退出程序
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
            }
            else
            {
                btnDiffculity.Enabled = false;
                btnSimple.Enabled = false;
                Btn_Stop.Enabled = false;
                tmr1.Enabled = false;
                stopWatch.Stop();          //游戏结束，停止计时
				teris.UpdateScore(username, Convert.ToInt32(label2.Text.Trim()));
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

        
    }
}
