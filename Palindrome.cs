using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo
{
    internal class Palindrome
    {
        public static void P1(string pal) 
        {
            bool succ = true;
            //var pal1 = pal.ToUpper();
            //pal = pal1;
            for (int i = 0, j = pal.Length - 1; i < pal.Length / 2; i++,j--)
            {
                if(pal[i] != pal[j])
                {
                    succ = false; 
                   break;
                }

            }
            if (succ)
                Console.WriteLine("Given string is Palindrome");
            else Console.WriteLine("Given string is not a palindrome");
        }
        public static void Main(string[] args)
        {
            P1("ABCDCBA");
        }
    }
}
