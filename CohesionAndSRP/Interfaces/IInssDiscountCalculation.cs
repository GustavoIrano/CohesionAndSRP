using CohesionAndSRP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionAndSRP.Interfaces
{
    public interface IInssDiscountCalculation
    {
        double Calculate(Employee employee);
    }
}
