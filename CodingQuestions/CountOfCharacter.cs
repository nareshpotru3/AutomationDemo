using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class CountOfCharacter
    {
        public static  void CharCountInString(string str)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    if (dic.ContainsKey(c))
                {
                    dic[c] =  dic[c] + 1;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
        }
            foreach (var c in dic)
            {
                Console.WriteLine(c.Key + " " + c.Value);
            }
        }
        public static void Main(string[] args)
        {
            CharCountInString("a bc da ebad ");
        } 
    }
}
