using CohesionAndSRP.Interfaces;
using CohesionAndSRP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionAndSRP
{
    public class CalculateEightPercent : IInssDiscountCalculation
    {
        public double Calculate(Employee employee)
        {
            return employee.Salary - (employee.Salary * 0.08);
        }        
    }
}
