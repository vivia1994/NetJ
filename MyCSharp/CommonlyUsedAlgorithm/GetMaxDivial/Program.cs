using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxDivial
{
    class Program
    {
        public float maxGongYueShu(int n1,int n2)
        {
            int temp = Math.Max(n1, n2);
            n2 = Math.Min(n1, n2);
            n1 = temp;
            while(n2!=0)
            {
                n1 = n1 > n2 ? n1 : n2;
                int m = n1 % n2;
                n1 = n2;
                n2 = m;
            }
            return n1;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("请输入n1：");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入n2：");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                Console.WriteLine(p.maxGongYueShu(n1, n2));
            }
            
        }
    }
}
