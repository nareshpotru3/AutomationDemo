using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Collections
{ 

  
        public interface IService
        {
            void Print();
        }

        public class Service1 : IService
        {
            public void Print()
            {
                Console.WriteLine("Print Method 1");
            }
        }

        public class Service2 : IService
        {
            public void Print()
            {
                Console.WriteLine("Print Method 2");
            }
        }

        class ClassA
        {
            private IService _service;
            public ClassA(IService service)
            {
                this._service = service;
            }
            public void PrintMethod()
            {
                this._service.Print();
            }
        }

        class Program
        {
          
        }

    internal class DependancyInjection
    {
        static void Main(string[] args)
        {
            Service1 s1 = new Service1();
            //passing dependency
            ClassA c1 = new ClassA(s1);
            c1.PrintMethod();
            Service2 s2 = new Service2();
            //passing dependency
            c1 = new ClassA(s2);
            c1.PrintMethod();
            Console.ReadLine();
        }
    }
}
