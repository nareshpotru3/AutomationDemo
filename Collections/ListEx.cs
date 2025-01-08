using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Collections
{
    internal class ListEx
    {
        public static void ListExer()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Remove(5);
            list.Insert(3, 7);
            int[] l1 = { 6, 8, 9 };
            list.InsertRange(3, l1);
            list.Remove(8);
            list.RemoveAt(4);
            list.RemoveRange(1, 2);
            list.Reverse();
            list.Sort();

            List<int> list2 = [12, 10, 11];

            list.AddRange(list2);

            //list.Clear(); clear total data
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
            int[] arr = list.ToArray();
            foreach (int a in list)
                Console.WriteLine(a);
            foreach (int a in arr)
                Console.WriteLine(a);
            Console.WriteLine("Value at particularposition" + list[3]);
            if(list.Contains(16))
            {
                Console.WriteLine("value is there");
            }

            else
            {
                Console.WriteLine("No value for given");
            }
            
            //int a = list.BinarySearch(4);
            //Console.WriteLine(a);
        }
        public static void Main(string[] args)
        {
            ListExer();
        }
    }
}
