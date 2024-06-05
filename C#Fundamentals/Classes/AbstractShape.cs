using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal abstract class AbstractShape
    {
        public abstract double CalculateArea();
        public void PrintArea()
        {
            Console.WriteLine($"Area :: {CalculateArea()}");
        }
    }
}
