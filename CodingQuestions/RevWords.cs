using System.Text;

namespace AutomationDemo.CodingQuestions
{
    internal class RevWords
    {
        public static void RevOfWords(string str)
        {
            StringBuilder sb = new StringBuilder();
            int end = str.Length - 1;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    int strt = i + 1;
                    while (strt <= end)
                    {
                        sb.Append(str[strt]);
                        strt++;
                    }
                    sb.Append(' ');
                    end = i;
                }
            }
            for (int i = 0; i < end; i++)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine(sb.ToString());
        }
        public static void Main(string[] args)
        {
            RevOfWords("Ab decd cdf");
        }
    }
}
