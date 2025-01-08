using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Collections
{
    internal class LinqEx
    {
        public static void LinqExer()
        {
            int[] nums = new int[] { 0, 1, 2 };
            var res = from a in nums where a < 3 orderby a select a;
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main()
        {
            LinqExer();
        }
    }
}
