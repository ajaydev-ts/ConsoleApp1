using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees whose age greater than 35");

            IEnumerable<Employee> queryResult = from employee in Employee.GetAllEmployees()
                                                where employee.Age > 35
                                                select employee;
            foreach (var row in queryResult.ToList())
            {
                Console.WriteLine("Id:" + row.Id.ToString());
                Console.WriteLine("Name:" + row.Name);
                Console.ReadLine();
            }

            Console.WriteLine("Names of Female Employees");
            IEnumerable<Employee> queryResult1 = from employee in Employee.GetAllEmployees()
                                                where employee.Gender == "F"
                                                select employee;
            foreach (var row in queryResult1.ToList())
            {
                Console.WriteLine("Id:" + row.Id.ToString());
                Console.WriteLine("Name:" + row.Name);
                Console.ReadLine();
            }
            Console.WriteLine("Name of employee whose age is either 21 or 33");
            IEnumerable<Employee> queryResult2 = from employee in Employee.GetAllEmployees()
                                                 where employee.Age == 21 || employee.Age == 33
                                                 select employee;
            foreach (var row in queryResult2.ToList())
            {
                Console.WriteLine("Id:" + row.Id.ToString());
                Console.WriteLine("Name:" + row.Name);
                Console.ReadLine();
            }

        }
    }

    
}
