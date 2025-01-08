using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationDemo.Assignment;

namespace AutomationDemo.CodingQuestions
{
    internal class RightRotation
    {          
        public static void RightRotation1(int[] array)
        {
            int len = array.Length - 1;
            int temp = array[array.Length - 1];
            for(int j = array.Length - 2; j>= 0; j--)
            {
                array[len] = array[j];
                len--;
            }
            array[0] = temp;
            foreach(int i in array)
            {
                Console.Write(i+" ");
            }
        }
        public static void Main(string[] args)
        {
            RightRotation1([2, 3, 4, 5, 1]);
        }
    }
}
