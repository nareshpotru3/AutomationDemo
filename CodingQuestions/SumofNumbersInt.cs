using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class SumofNumbersInt
    {
        public static void SumOfNumbers(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum = sum+(n % 10);
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
        public static void Main(string[] args)
        {
            SumOfNumbers(1443);
        }
    }
}
