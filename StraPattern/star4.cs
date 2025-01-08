using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star4
    {
        public static void starfour(int n)
        {
            int count = 0;
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k <= count; k++)
                {
                    Console.Write("*");

                }
                count++;
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            starfour(5);
        }
    }
}
