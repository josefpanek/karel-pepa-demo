using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Employee
    {
        public Employee(decimal salary)
        {
            Salary = salary;
            Age = 1;
        }
        public string Name { get; set; }

        public int Age { get; init; }

        public decimal Salary { get; }

    }

    public class Manager : Employee
    {
        public Manager(decimal salary) : base(salary)
        {
            Age = 2;
        }
    }

    public struct Complex
    {

    }

    public record EmployeeRecord(string Name);
}
