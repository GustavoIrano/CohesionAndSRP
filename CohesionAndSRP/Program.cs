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

            var AccountingAssistant = new Employee() { Name = "Tedd", Salary = 1600, jobRole = JobRole.AccountingAssistant };
            employers.Add(AccountingAssistant);

            var AccountingAnalyst = new Employee() { Name = "Lisa", Salary = 2500, jobRole = JobRole.AccountingAnalyst };
            employers.Add(AccountingAnalyst);

            var Counter = new Employee() { Name = "Jack", Salary = 5300, jobRole = JobRole.Counter};
            employers.Add(Counter);

            var eithPercent = new CalculateEightPercent();
            var ninePercent = new CalculateNinePercent();
            var elevenPercent = new CalculateElevenPercent();
            double calc = 0;

            Console.WriteLine(" -- Employee -- ");
            Console.WriteLine();

            foreach (var employee in employers)
            {                
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Job Role: " + employee.jobRole.ToString());
                Console.WriteLine("Salary: " + employee.Salary);

                switch (employee.jobRole) 
                {
                    case JobRole.AccountingAssistant:
                        calc = eithPercent.Calculate(employee);
                        break;
                    case JobRole.AccountingAnalyst:
                        calc = ninePercent.Calculate(employee);
                        break;
                    case JobRole.Counter:
                        calc = elevenPercent.Calculate(employee);
                        break;
                    default:
                        throw new ExecutionEngineException("Job Role not found");
                }

                Console.WriteLine("Discounted salary: " + calc);

                Console.WriteLine();
                Console.WriteLine( "------------------------------------" );
                Console.WriteLine();
            }

        }
    }
}
