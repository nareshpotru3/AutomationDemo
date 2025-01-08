using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.CodingQuestions
{
    internal class SecondLargestNum
    {

        public static  void SecondLargeNum(int[] n1)
        {
            int max1 = 0;
            int max2 = 0;
            foreach(int n in n1)
            {
                if(n > max1)
                {
                    max2 = max1;
                    max1 = n;

                }
                else if(n>=max2 && n != max1)
                    {
                    max2 = n;
                }
                
            }
            Console.WriteLine("second large num is" + max2);
        }
        public static void Main(string[] args)
        {
            SecondLargeNum([1,4,3,5,6,1,7,7]);
        }
    }
}
