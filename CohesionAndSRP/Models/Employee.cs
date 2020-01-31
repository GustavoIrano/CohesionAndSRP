using CohesionAndSRP.Enums;
using CohesionAndSRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionAndSRP.Models
{
    public class Employee
    {
        private double _salaryDiscount;

        public string Name { get; set; }
        public JobRole jobRole { get; set; }
        public double BaseSalary { get; set; }
        public double SalaryDiscount { 
            get 
            { 
                return _salaryDiscount; 
            } 
            private set 
            {
                _salaryDiscount = value; 
            } 
        }

        public void CalculateDiscount(IInssDiscountCalculation inssDiscountCalculation)
        {
            SalaryDiscount = inssDiscountCalculation.Calculate(this);
        }
    }
}
