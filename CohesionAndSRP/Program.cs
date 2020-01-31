using CohesionAndSRP.Enums;
using CohesionAndSRP.Models;
using System;
using System.Collections.Generic;

namespace CohesionAndSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var employers = new List<Employee>();

            var AccountingAssistant = new Employee() { Name = "Tedd", BaseSalary = 1600, jobRole = JobRole.AccountingAssistant };
            AccountingAssistant.CalculateDiscount(new CalculateEightPercent());
            employers.Add(AccountingAssistant);

            var AccountingAnalyst = new Employee() { Name = "Lisa", BaseSalary = 2500, jobRole = JobRole.AccountingAnalyst };
            AccountingAnalyst.CalculateDiscount(new CalculateNinePercent());
            employers.Add(AccountingAnalyst);

            var Counter = new Employee() { Name = "Jack", BaseSalary = 5300, jobRole = JobRole.Counter};
            Counter.CalculateDiscount(new CalculateElevenPercent());
            employers.Add(Counter);
            
            Console.WriteLine(" -- Employees -- ");
            Console.WriteLine();

            foreach (var employee in employers)
            {                
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Job Role: " + employee.jobRole.ToString());
                Console.WriteLine("Salary: " + employee.BaseSalary);                

                Console.WriteLine("Discounted salary: " + employee.SalaryDiscount );

                Console.WriteLine();
                Console.WriteLine( "------------------------------------" );
                Console.WriteLine();
            }

        }
    }
}
