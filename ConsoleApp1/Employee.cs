using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()

        {
            List<Employee> listEmployees = new List<Employee>();
            Employee employee1 = new Employee
            {
                Id = 1,
                Name = "Sam",
                Age = 23,
                EmailId = "sam@gmail.com",
                    Gender = "M",
                    Salary = 20000
            };
            listEmployees.Add(employee1);
            
            Employee employee2 = new Employee
            {
                Id = 2,
                Name = "John",
                Age = 25,
                EmailId = "john@gmail.com",
                Gender = "M",
                Salary = 10000
            };
            listEmployees.Add(employee2);
            
            Employee employee3 = new Employee
            {
                Id = 3,
                Name = "Kiran",
                Age = 30,
                EmailId = "kiran@gmail.com",
                Gender = "M",
                Salary = 25000
            };
            listEmployees.Add(employee3);
           
            Employee employee4 = new Employee
            {
                Id = 4,
                Name = "Ram",
                Age = 21,
                EmailId = "ram@gmail.com",
                Gender = "M",
                Salary = 35000
            };
            listEmployees.Add(employee4);
            
            Employee employee5 = new Employee
            {
                Id = 5,
                Name = "Sandeep",
                Age = 40,
                EmailId = "sandeep@gmail.com",
                Gender = "M",
                Salary = 21000
            };
            listEmployees.Add(employee5);
            
            Employee employee6 = new Employee
            {
                Id = 6,
                Name = "Jincy",
                Age = 33,
                EmailId = "jincy2@gmail.com",
                Gender = "F",
                Salary = 40000
            };
            listEmployees.Add(employee6);
            return listEmployees;

        }

    }

}
