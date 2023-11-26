using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module9
{
    public class Developer : Employee
    {
        public int LinesOfCodePerDay { get; set; }

        public Developer(string name, int age, decimal salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
        }

        public override decimal CalculateAnnualSalary()
        {
            decimal additionalIncome = LinesOfCodePerDay * 365; // Допустим, что это фиксированная сумма за год
            return base.CalculateAnnualSalary() + additionalIncome;
        }
    }

}
