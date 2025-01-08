using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class PossibleSubString
    {
        public static void SubStrings(string str)
        {
            
            for (int i = 0; i<= str.Length - 1;  i++)
            {
                //StringBuilder subString = new StringBuilder();
                string substring = string.Empty;
                for (int j = i; j <= str.Length - 1; j++)
                {
                    substring = substring + str[j];
                    //subString.Append(str[j]);
                    Console.WriteLine(substring +" ");
                }
            }
        }
        public static void Main(string[] args)
        {
            SubStrings("abcdd");
        }
    }
}
