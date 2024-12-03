using System;

namespace AutomationDemo
{
    internal class RevString
    {   
        public static void RevStr(string rev) 
        {
            char[] arr = rev.ToCharArray();
            int j = 0;
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[j] = rev[i];
                j += 1;
            }
            Console.WriteLine(arr);
        }
        public static void Main(string[] args)
        {
            RevStr("ABCDEFG");
        }
    }
}
