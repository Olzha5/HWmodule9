using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module9
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
