using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star1
    {
        public static void star11(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(' ');
            }
        }
        public static void Main(string[] args)
        {
            star11(10);
        }
    }
}
