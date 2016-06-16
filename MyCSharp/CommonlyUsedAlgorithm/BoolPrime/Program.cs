using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolPrime
{
    class Program
    {
        public bool Prime(int a)
        {
            bool flag = true;
            if (a == 2 || a == 1)
                return true;//是素数
            else if(a>2)
            {
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                         flag= false; 
                }
                return flag;
              }
            else return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个整数：");
                int a = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                Console.WriteLine(p.Prime(a));
            }
            
        }
    }
}
