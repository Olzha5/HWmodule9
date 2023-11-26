using module9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получение данных для Manager
            Console.WriteLine("Enter Manager's details:");
            Console.Write("Name: ");
            string managerName = Console.ReadLine();
            Console.Write("Age: ");
            int managerAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            decimal managerSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bonus: ");
            decimal managerBonus = Convert.ToDecimal(Console.ReadLine());

            Manager manager = new Manager(managerName, managerAge, managerSalary, managerBonus);
            Console.WriteLine(manager.GetInfo());
            Console.WriteLine($"Annual Salary (including bonus): {manager.CalculateAnnualSalary()}");

            // Получение данных для Developer
            Console.WriteLine("\nEnter Developer's details:");
            Console.Write("Name: ");
            string developerName = Console.ReadLine();
            Console.Write("Age: ");
            int developerAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            decimal developerSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Lines of Code per Day: ");
            int linesOfCodePerDay = Convert.ToInt32(Console.ReadLine());

            Developer developer = new Developer(developerName, developerAge, developerSalary, linesOfCodePerDay);
            Console.WriteLine(developer.GetInfo());
            Console.WriteLine($"Annual Salary (including additional income for code): {developer.CalculateAnnualSalary()}");
    
}
    }
}
