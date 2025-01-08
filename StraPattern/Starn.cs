using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V128.HeapProfiler;

namespace AutomationDemo.StraPattern
{
    internal class starn
    {
        public static void starss(string str)
        {

               List<Employee> employees = new List<Employee>() 
               { new Employee("Ramya", 1, 10000), 
                 new Employee("Naresh", 2, 20000),
                 new Employee("Nikki", 3, 30000),
                 new Employee("Kitti", 4, 100)
               };

           var employeeswithsal= employees.Where(x => x.Salary > 10000).Select(x=>new {x.Name, x.id});
          var output=  employees.Any(x => x.Name == "Ramya");
            employees.All(x => x.Name != null);
                
            
        }

        public static void Main(string[] args)
        {
            starss("naresh x hseran");
        }
    }


    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int id { get; set; }

        public Employee(string name, int salary, int id)
        {
            this.Name = name;
            this.Salary = salary;
            this.id = id;
        }
    }
}
