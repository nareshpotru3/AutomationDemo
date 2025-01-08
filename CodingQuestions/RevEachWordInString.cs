using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class RevEachWordInString
    {
        public static void RevEachWrosInString(string str)
        {
            StringBuilder sb = new StringBuilder();
            int strt = 0;
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {

                    for (int j = i - 1; j >= strt; j--)
                    {
                        sb.Append(str[j]);

                    }
                    sb.Append(' ');
                    strt = i;
                }

            }
            for (int k = str.Length - 1; k > strt; k--)
            {
                sb.Append(str[k]);
            }
            Console.WriteLine(sb.ToString());
        }
        public static void Main(string[] args)
        {
            RevEachWrosInString("abc def ghi");
        }
    }
}
