using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star5
    {
        public static void starfive(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            starfive(5);
        }
    }
}
