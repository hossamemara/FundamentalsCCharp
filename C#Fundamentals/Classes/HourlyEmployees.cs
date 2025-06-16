using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class HourlyEmployees:Employee
    {
        public decimal HourRate { get; set; }
        public int WorkingHours { get; set; }

        public override string GetName()
        {
            return "HourlyEmployees";
        }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total Hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            return HourRate + WorkingHours;
        }
    }
}
