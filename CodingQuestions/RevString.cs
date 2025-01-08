using System;

namespace AutomationDemo.CodingQuestions
{
    internal class RevString
    {
        public static void RevStr(string rev)
        {
            char[] arr = rev.ToCharArray();
            for (int i = 0, j = rev.Length - 1; i < j; i++, j--)
            {
                arr[j] = rev[i];
                arr[i] = rev[j];
            }
            Console.WriteLine(arr);
        }
        public static void Main(string[] args)
        {
            RevStr("ABCDEFG");
        }
    }
}
