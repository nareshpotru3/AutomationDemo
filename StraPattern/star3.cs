using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star3
    {
        public static void starthree(int n)
        {
            int count = 0;
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k <= count * 2; k++)
                {
                    Console.Write("*");

                }
                count++;
                Console.WriteLine();
            }
            count = n;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");

                }
                count--;
                if (count != 0)
                {
                    for (int j = 1; j < count * 2; j++)
                    {
                        Console.Write('*');
                    }
                }

                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {
            starthree(4);
        }
    }
}
