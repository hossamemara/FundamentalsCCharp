using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class PayItem
    {
        public PayItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public decimal Value { get; }
    }
}
