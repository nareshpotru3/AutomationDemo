using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star2
    {
        public static void starTwo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            starTwo(10);
        }
    }
}
