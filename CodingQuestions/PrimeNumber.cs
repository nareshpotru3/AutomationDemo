using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class PrimeNumber
    {
        public static void PrimeNumber1(int n)
        {
            if (n == 1)
                Console.WriteLine(n + "is a prime number");
            else if (n == 2)
                Console.WriteLine(n + "is not a prime number");
            else if (n >= 3)
            { 
                var sqrt = Math.Floor(Math.Sqrt(n));
                char flag = ' ';
                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (n % i == 0)
                    {
                        flag = 'X';
                        break;
                    }
                    else
                        flag = ' ';
                }
                if (flag == 'X')
                    Console.WriteLine(n + "is not a prime number");
                else
                    Console.WriteLine(n + "is a prime number");
            }
        }
        public static void Main(string[] args)
        {
            PrimeNumber1(3);
        }
    }
}
