using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class SalariedEmployee : Employee
    {
        public decimal Salary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override string GetName()
        {
            return "SalariedEmployee";
        }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new [] {
                new PayItem("Basic Salary", Salary ),
                new PayItem("Transportation", Transportation),
                new PayItem("Housing", Housing)
            };
        }

        public override decimal GetSalary()
        {
            return Salary + Transportation +Housing;
        }
    }
}
