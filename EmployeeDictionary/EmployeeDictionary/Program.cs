using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee = new Dictionary<int,TheEmployee>();

            Employee.Add(101,
                new TheEmployee { Id = 101, FirstName = "Jesse", LastName = " Liberty" });
            Employee.Add(102,
                new TheEmployee { Id = 102, FirstName = "George", LastName = "Washington" });
            Employee.Add(103,
                new TheEmployee { Id = 103, FirstName = "Mark", LastName = " Smith" });
           
                
            Console.WriteLine(Employee[101]);
            Console.WriteLine(Employee[102]);
            Console.WriteLine(Employee[103]);
            Console.ReadLine();
        }
    }
}
