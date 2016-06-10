using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    public abstract class Brick             //abstract:基类，标记为抽象或包含在抽象类中的成员必须通过从抽象类派生的类来实现。
    {
        protected int m_curTransforIndex;  //当前变形次序 
        public int m_needfulRows;       //必要的行数
        public int m_needfulColumns;    //必要的列数
        public int[,] m_range;     //变形范围
        public Point m_center;       //中心点(相对于必要区域)
        public Point m_Pos;      //中心点的位置(相对于画布)

        /// <summary>
        /// 能否变形（能变形的条件：在砖块的变形范围内不能有其他砖块）
        /// </summary>
        /// <param name="arr">画布模型</param>
        /// <param name="rows">画布行数</param>
        /// <param name="columns">画布列数</param>

        public abstract bool CanTransform(int[,] arr, int rows, int columns);       // 能否变形

        public abstract void Transform();       // 变形

        public abstract bool CanLeftMove(int[,] arr, int rows, int columns);        //能否左移

        public void LeftMove()          // 左移
        {
            m_Pos.Y -= 1;
        }

        public abstract bool CanRightMove(int[,] arr, int rows, int columns);       // 能否右移

        public void RightMove()          //右移
        {
            m_Pos.Y += 1;
        }

        public abstract bool CanDropMove(int[,] arr, int rows, int columns);        //能否下移

        public void DropMove()           // 下移
        {
            m_Pos.X += 1;
        }
        
        /// 随机生成一个可以通过变形得到的形状
        public void RandomShape()
        {
            Random random = new Random();
            this.m_curTransforIndex = random.Next(4);
            this.Transform();
        }

        //x:横向位置
        //y:纵向位置
        public void SetCenterPos(int x, int y)          // 设置中心点相对于画布的位置
        {
            this.m_Pos = new Point(x, y);
        }

        public abstract int Appear();                   // 获取砖块出现时中心点的Y轴坐标
    }
}
