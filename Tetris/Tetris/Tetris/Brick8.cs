using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    class Brick8 : Brick
    {
        public Brick8()
        {
            this.m_curTransforIndex = 0;         //当前变形次序
            this.m_needfulRows = 1;
            this.m_needfulColumns = 1;
            m_range = new int[1, 1] { { 1 } };       //变形范围
            this.m_center = new Point(0, 0);
            this.m_Pos = new Point();
        }
        /*override:要扩展或修改继承的方法、属性、索引器或事件的抽象实现或虚实现，必须使用 override 修饰符。*/

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
            //中心点出现在屏幕上
            if (m_Pos.Y == 0 || arr[m_Pos.X, m_Pos.Y - 1] == 1)
                return false;
            else
                return true;
        }

        public override bool CanRightMove(int[,] arr, int rows, int columns)
        {
            //中心点出现在屏幕上
            if (m_Pos.Y == columns - 1 || arr[m_Pos.X, m_Pos.Y + 1] == 1)
                return false;
            else
                return true;
        }

        public override bool CanDropMove(int[,] arr, int rows, int columns)
        {
            //是否见底，下方是否有1
            if (m_Pos.X < rows - 1 && arr[m_Pos.X + 1, m_Pos.Y] == 0)
                return true;
            return false;
        }

        // 获取砖块出现时中心点的Y轴坐标
        public override int Appear()
        {
            return 0;
        }
    }
}
