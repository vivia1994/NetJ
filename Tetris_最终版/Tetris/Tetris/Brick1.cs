using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    class Brick1:Brick
    {
        public Brick1()
        {
            this.m_curTransforIndex = 0;         //当前变形次序
            this.m_needfulRows = 2;
            this.m_needfulColumns = 2;
            m_range = new int[2,2]{{1,1},{1,1}};       //变形范围
            this.m_center = new Point(0, 0);
            this.m_Pos = new Point();
        }

        public override bool CanTransform(int[,] arr, int rows, int columns)
        {
            return false;
        }

        public override void Transform()
        {
            return;
        }

        public override bool CanLeftMove(int[,] arr, int rows, int columns)
        {
            //中心点还没出现在屏幕上
            if (m_Pos.X < 0)
            {
                if (m_Pos.Y == 0 || arr[m_Pos.X +1, m_Pos.Y - 1] == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //中心点出现在屏幕上
            if (m_Pos.Y == 0 || arr[m_Pos.X, m_Pos.Y-1] == 1 || arr[m_Pos.X + 1, m_Pos.Y - 1] == 1)
                return false;
            else
                return true;
        }

        public override bool CanRightMove(int[,] arr, int rows, int columns)
        {
            //中心点还没出现在屏幕上
            if (m_Pos.X < 0)
            {
                if (m_Pos.Y == columns-2 || arr[m_Pos.X + 1, m_Pos.Y + 2] == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //中心点出现在屏幕上
            if (m_Pos.Y == columns - 2 || arr[m_Pos.X, m_Pos.Y+2] == 1 || arr[m_Pos.X +1, m_Pos.Y + 2] == 1)
                return false;
            else
                return true;
        }

        public override bool CanDropMove(int[,] arr, int rows, int columns)
        {
            //是否见底，下方是否有1
            if (m_Pos.X < rows - 2 && arr[m_Pos.X + 2, m_Pos.Y] == 0 && arr[m_Pos.X + 2, m_Pos.Y + 1] == 0)
                return true;
            return false;
        }

        // 获取砖块出现时中心点的Y轴坐标
        public override int Appear()
        {
            return -1;
        }
    }
}
