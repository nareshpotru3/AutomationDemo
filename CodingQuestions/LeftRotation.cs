using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationDemo.CodingQuestions
{
    internal class LeftRotation
    {
        public static void LeftRotaion1(int[] array)
        {
        int len = 0;

            int temp = array[0];
            for (int j = 1; j < array.Length; j++)
            {

                array[len] = array[j];   
                len++;
            }

            array[len] = temp;

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }   
        public static void Main(string[] args)
        {
            LeftRotaion1([1,2,3,4,5]);
        }
    }
}
