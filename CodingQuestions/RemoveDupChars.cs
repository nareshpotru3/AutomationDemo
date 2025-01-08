using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class RemoveDupChars
    {
        public static void RemovedupChars(string str)
        {
            string res = string.Empty;
           for(int i = 0; i < str.Length - 1; i++)
            {
                if(!res.Contains(str[i]))
                {
                    res = res+ str[i];
                }
            }
            Console.WriteLine(res);
        }
        public static void Main(string[] args)
        {
            RemovedupChars("abcaxxxbcbdd efeg");
        }
    }
}
