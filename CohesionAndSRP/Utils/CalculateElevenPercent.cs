using CohesionAndSRP.Interfaces;
using CohesionAndSRP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionAndSRP
{
    public class CalculateElevenPercent : IInssDiscountCalculation
    {
        public double Calculate(Employee employee)
        {
            return employee.BaseSalary - (employee.BaseSalary * 0.11);
        }
    }
}
