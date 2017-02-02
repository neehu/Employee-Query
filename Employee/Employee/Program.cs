using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeQuery
{
    public class Employee
    {
        private int salary;
        private int department;

        public Employee(int salary, int department)
        {
            this.salary = salary;
            this.department = department;
        }

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(5000, 1));
            employees.Add(new Employee(10000, 1));
            employees.Add(new Employee(500, 1));
            employees.Add(new Employee(5000, 2));
            employees.Add(new Employee(10000, 2));
            employees.Add(new Employee(20000, 2));
            employees.Add(new Employee(10000, 3));
            employees.Add(new Employee(5000, 3));
            employees.Add(new Employee(25000, 3));

            var result = from employee in employees
                         where employee.salary >= 10000
                         group employee by employee.department into dg
                         select dg.Count();
            Console.WriteLine("The number of employees with salary greater than 10000\n from department 1,2,3 are");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
