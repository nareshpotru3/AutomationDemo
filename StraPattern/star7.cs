using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.StraPattern
{
    internal class star7
    {
        public static void starprn(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write("*");
            }
        }
        public static void starspc(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write(" ");
            }
        }
        public static void starseven(int n)
        {

            for (int i = 0; i <= n; i++)
            {
                starprn(i);
                starspc(n - i - 1);
                starprn(n - i);
                starspc(i * 2);
                starprn(n - i);
                starspc(n - i);
                starprn(i + 1);
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {
            starseven(8);

        }

    }

}
