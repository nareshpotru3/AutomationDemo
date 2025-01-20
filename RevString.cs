using System;

namespace AutomationDemo
{
    internal class RevString : BaseForRevString
    {
        public new int VirMeth(int a, int b)
        {
            int res = a - b;
            return res;
        }
        public override int absmeth(int a, int b)
        {
            int res = a % b;
            return res;
        }
        public override int absmeth1(int a, int b)
        {
            return a % b;
        }

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
