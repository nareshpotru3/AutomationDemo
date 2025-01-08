using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V128.Runtime;

namespace AutomationDemo.Assignment
{
    internal class CountOccurenceofChar
    {
        public static void CountChar(string Str)
        {
            char[] arr = Str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            //= Str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int Count = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    for (int k = 0; k < sb.Length; k++)
                    {
                        if (arr[i] == sb[k])
                            break;
                        else
                        {
                            if (arr[i] == arr[j])
                            {
                                //char c = arr[i];
                                sb.Append(arr[i]);
                                Count = Count + 1;
                            }

                        }
                    }

                }

                Console.WriteLine(arr[i] + " - " + Count);

            }
        }

        public static void Main(string[] args)
        {
            CountChar("abac cdef");
        }
    }
}
