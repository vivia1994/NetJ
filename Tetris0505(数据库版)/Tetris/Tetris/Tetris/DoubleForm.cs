using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class DoubleForm : Form
    {
        bool m_isrun2;          //、指示窗口是否正在运行
        Canvas m_canvasL;        //画布模型←
        Graphics m_nextpicgraL;  //用于显示下一个砖块的画布←
        float m_itemxlengthL;    //、单个格子宽度
        float m_itemylengthL;    //、单个格子长度

        Canvas m_canvasR;        //画布模型→
        Graphics m_nextpicgraR;  //用于显示下一个砖块的画布→
        float m_itemxlengthR;    //、单个格子宽度
        float m_itemylengthR;    //、单个格子长度
        char firstDie = 'N';     //指示谁先死

        public DoubleForm()
        {
            InitializeComponent();
        }

        private void DoubleForm_Load(object sender, EventArgs e)
        {
            /*←*/
            pctrBxBigRght.Focus(); 
            m_canvasL = new Canvas();
            m_itemxlengthL = pctrBxBigLft.Width / m_canvasL.m_columns; // 、m_itemxlength：单个格子宽度= x方向上画布的宽/20列
            m_itemylengthL = pctrBxBigLft.Height / m_canvasL.m_rows;   //、m_rows=20  m_columns= 20; 横竖方向都是20个格子大小
            pctrbxLeft.Size = new Size((int)m_itemxlengthL * 5, (int)m_itemylengthL * 5);//、下一个方块出现的PB区域
            m_nextpicgraL = pctrbxLeft.CreateGraphics();
            /*→*/
            m_canvasR = new Canvas();
            m_itemxlengthR = pctrBxBigRght.Width / m_canvasR.m_columns; // 、m_itemxlength：单个格子宽度= x方向上画布的宽/20列
            m_itemylengthR = pctrBxBigRght.Height / m_canvasR.m_rows;   //、m_rows=20  m_columns= 20; 横竖方向都是20个格子大小
            pctrbxRight.Size = new Size((int)m_itemxlengthR * 5, (int)m_itemylengthR * 5);//、下一个方块出现的PB区域
            m_nextpicgraR = pctrbxRight.CreateGraphics();

            m_isrun2 = false;
        }

        /*新局*/
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            firstDie = 'N';       //无人死
            //点亮“暂停”键
            btnStop.Enabled = true;
            m_isrun2 = false;
            tmr2.Stop();
            m_canvasL = new Canvas();       //、两块画布
            m_canvasR = new Canvas();
            m_isrun2 = true;
            tmr2.Start();

        }
        /*暂停与继续合并成一个按钮*/
        private void btnStop_Click(object sender, EventArgs e)
        {
            if(btnStop.Text == "暂停")
            {
                m_isrun2 = false;
                tmr2.Stop();
                btnStop.Text = "继续";
            }
            else if(btnStop.Text == "继续")
            {
                m_isrun2 = true;
                tmr2.Start();
                btnStop.Text = "暂停";
            }
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*关闭线程*/
        private void DoubleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr2.Stop();
        }
        /// <summary>
        /// 时间控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr2_Tick(object sender, EventArgs e)
        {
            //为了解决一方结束后另一方画面停止的问题：
            //m_canvasL.Run  &&  m_canvasR.Run

            //、不停更新游戏画面
            
            bool lState = m_canvasL.Run();
            bool rState = m_canvasR.Run();
            if (lState)        //左边的在跑
            {
                DrawL();
                DrawNextL();
                lblLeft.Text = "甲的分数：" + m_canvasL.m_score.ToString() + "分";
            }
            else            //左边游戏结束
            {
                if (firstDie == 'N')//死了的不管
                {
                    firstDie = 'L';
                }
            }
                   
             if(rState)    //右边的在跑
            {
                DrawR();
                DrawNextR();
                lblRight.Text = "乙的分数：" + m_canvasR.m_score.ToString() + "分"; 
            }
            else
            {
                if (firstDie == 'N')
                    firstDie = 'R';

            }

            if (!lState && !rState) //左右都停止
            {
                tmr2.Stop();
                btnStop.Enabled = false;        //、停止按钮为灰
                if (m_canvasL.m_score > m_canvasR.m_score)
                {
                    MessageBox.Show("L","游戏结果");
                    //return;
                }
                if (m_canvasR.m_score > m_canvasL.m_score)
                {
                    MessageBox.Show("R", "游戏结果");
                }
                if (m_canvasL.m_score == m_canvasR.m_score)
                {
                    if(firstDie == 'L')
                        MessageBox.Show("R", "游戏结果");
                    if(firstDie == 'R')
                        MessageBox.Show("L", "游戏结果");
                }
            }
            
            
        }
        /*********************按键处理****************************/
        private void DoubleForm_KeyDown(object sender, KeyEventArgs e)
        {
            //form的KeyPress默认不对键盘事件响应，必须设置为true！！！！！！！！！！
            Keys key = e.KeyCode;
            if (m_isrun2 == true)
            {
                if (key == Keys.E)
                {
                    pctrBxBigLft.Refresh();
                    m_canvasL.BrickUp();
                    DrawL();
                }
                if (key == Keys.A)
                {
                    pctrBxBigLft.Refresh();
                    m_canvasL.BrickLeft();
                    DrawL();
                }
                if (key == Keys.D)
                {
                    pctrBxBigLft.Refresh();
                    m_canvasL.BrickRight();
                    DrawL();
                }
                if (key == Keys.S)
                {
                    pctrBxBigLft.Refresh();
                    m_canvasL.BrickDown();
                    DrawL();
                }

                if (key == Keys.Up)
                {
                    pctrBxBigRght.Refresh();
                    m_canvasR.BrickUp();
                    DrawR();
                }
                if (key == Keys.Left)
                {
                    pctrBxBigRght.Refresh();
                    m_canvasR.BrickLeft();
                    DrawR();
                }
                if (key == Keys.Right)
                {
                    pctrBxBigRght.Refresh();
                    m_canvasR.BrickRight();
                    DrawR();
                }
                if (key == Keys.Down)
                {
                    pctrBxBigRght.Refresh();
                    m_canvasR.BrickDown();
                    DrawR();
                }
                
            }
        }

        /************************************LLLLLLLL*************************************/

        /*********************************************************/
        /// <summary>
        /// 画单个方块
        /// </summary>
        /// <param name="gb"></param>
        /// <param name="row">行</param>
        /// <param name="column">列</param>
        private void DrawItemL(Graphics gb, int row, int column)
        {
            float xpos = column * m_itemxlengthL - 1;
            float ypos = row * m_itemylengthL - 1;
            gb.FillRectangle(Brushes.Blue, xpos, ypos, m_itemxlengthL - 2, m_itemylengthR - 2);
        }

        private void DrawNextL()
        {
            pctrbxLeft.Refresh();
            m_canvasL.DrawNewxBrick(m_nextpicgraL, m_itemxlengthL, m_itemylengthL);
        }
        /*****************************左边画布*******************************/
        private void DrawL()
        {
            //初始化画布
            Bitmap canvas = new Bitmap(pctrBxBigLft.Width, pctrBxBigLft.Height);
            Graphics gb = Graphics.FromImage(canvas);

            for (int i = 0; i < m_canvasL.m_rows; i++)
            {
                for (int j = 0; j < m_canvasL.m_columns; j++)
                {
                    if (m_canvasL.m_arr[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        DrawItemL(gb, i, j);
                    }
                }
            }
            pctrBxBigLft.BackgroundImage = canvas;
            pctrBxBigLft.Refresh();
        }

        /************************************RRRRRRRRR*************************************/
        private void DrawItemR(Graphics gb, int row, int column)
        {
            float xpos = column * m_itemxlengthR - 1;
            float ypos = row * m_itemylengthR - 1;
            gb.FillRectangle(Brushes.Blue, xpos, ypos, m_itemxlengthR - 2, m_itemylengthR - 2);
        }

        private void DrawNextR()
        {
            pctrbxRight.Refresh();
            m_canvasR.DrawNewxBrick(m_nextpicgraR, m_itemxlengthR, m_itemylengthR);
        }

        private void DrawR()
        {
            //初始化画布
            Bitmap canvas = new Bitmap(pctrBxBigRght.Width, pctrBxBigRght.Height);
            Graphics gb = Graphics.FromImage(canvas);

            for (int i = 0; i < m_canvasR.m_rows; i++)
            {
                for (int j = 0; j < m_canvasR.m_columns; j++)
                {
                    if (m_canvasR.m_arr[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        DrawItemR(gb, i, j);
                    }
                }
            }
            pctrBxBigRght.BackgroundImage = canvas;
            pctrBxBigRght.Refresh();
        }

        /********************************按键*******************************/
        //、覆盖默认的系统键处理方式，
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || 
                keyData == Keys.E|| keyData == Keys.S || keyData == Keys.A || keyData == Keys.F)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}


//√picturebox两个，√timer公用
//√两块画布，timer对两个画布同时作用
//√同时监听八个按钮


//待解决：只要一方结束，另一方也结束