using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace AutomationDemo.StraPattern
{
    public class Starnnnn
    {
        public static void GetValues(out int res1, out int res2,int a,int b)
        {
            res1 = a + b;
            res2 = a - b;
        }

        public static void Main()
        {
            int res1, res2;
            GetValues(out res1, out res2,20,10);
            Console.WriteLine(res1); // Output: 10
            Console.WriteLine(res2); // Output: 20

        }
    }
}