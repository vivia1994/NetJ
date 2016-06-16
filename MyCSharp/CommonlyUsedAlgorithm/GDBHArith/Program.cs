using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDBHArith
{
    class Program
    {
        /// <summary>
        /// 判断一个数是否是素数
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Prime(int a)
        {
            bool flag = true;
            if (a == 2 || a == 1)
                return true;//是素数
            else if (a > 2)
            {
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                        flag = false;
                }
                return flag;
            }
            else return true;
        }
        /// <summary>
        /// 哥德巴赫猜想
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string arith(int a)
        {
            string Expression = "";
            double k = a / 2;
                //Math.Sqrt(a);
            for(int i=1; i<Convert.ToInt32(k)+1;i++)
            {
                for(int j= Convert.ToInt32(k) - 1;j < a;j++)
                {
                    if (i + j == a && Prime(i) && Prime(j))
                        Expression += a+"="+i + "+" + j + ";" + "\n";
                }
            }
            return Expression.Remove(Expression.Length - 1);
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("请输入一个大于6的偶数：");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 6&&a%2==0)
                {
                    Program p = new Program();
                    Console.WriteLine(p.arith(a));
                    Console.WriteLine(a + "是素数");
                }
                           }
        }
    }
}
