using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenFactiorial
{
    class Program
    {
        public double factiorial(int num)
        {
           switch (num)
            {
                case 1:
                    return 1;
                default:
                    return num * factiorial(num - 1);
            }
          
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("请输入一个整数：");
                int num = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                Console.WriteLine(num + "！=" + p.factiorial(num));
            }
           
        }
    }
}
