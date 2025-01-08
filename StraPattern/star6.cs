using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star6
    {
        public static void starsix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write("*");
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            starsix(10);
        }
    }
}
