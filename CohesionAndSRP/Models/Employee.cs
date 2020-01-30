using CohesionAndSRP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CohesionAndSRP.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public JobRole jobRole { get; set; }
        public double Salary { get; set; }        
    }
}
