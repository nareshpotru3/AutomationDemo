using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Collections
{
    internal class DictEx
    {
        public static void DictExer()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();

            dict.Add(1, "naresh");
            dict.Add(2, "naresh");
            dict.Add(3, "naresh");
            //dict.Add(1, "naresh");
            dict.Remove(2);

            Dictionary<int, string> dict1 = new Dictionary<int, string>
            {
                { 5, "NikkiNirvi" },
                { 6, "naresh" },
                { 7, "naresh" },
                { 8, "naresh" }
            };
            foreach(KeyValuePair<int,string> a in dict)
            {
                Console.WriteLine("Key : {0},value : {1}", a.Key, a.Value);
            }
            Console.WriteLine("Count of Dict is : {0} and Count of Dict1 is : {1}", dict.Count,dict1.Count);
            Console.WriteLine("Name of the 5th Key in dict1 is : {0}", dict1[5]);

            Dictionary<int,string>.KeyCollection ints = dict1.Keys;
            Dictionary<int, string>.ValueCollection strings = dict1.Values;
            Console.WriteLine("Keys");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Values");

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            dict[9] = "Ramya";
            Console.WriteLine("Name of the 9th Key in dict1 is : {0}", dict[9]);

            if(dict.ContainsKey(9))
            {
                Console.WriteLine("Value is there");
            }
            
            dict.Clear();
        }
        public static void Main(string[] args)
        {
            DictExer();
        }
    }
}
