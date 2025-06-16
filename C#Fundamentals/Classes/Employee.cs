using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal abstract class Employee : Person
    {
        public  string Email { get; set; }
        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
        public abstract string GetName();
    }
}
