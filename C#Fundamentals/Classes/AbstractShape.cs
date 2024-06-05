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
        public virtual void PrintArea()
        {
            Console.WriteLine($"Area :: {CalculateArea()}");
        }

        public void PrintArea2()
        {
            Console.WriteLine($"Area2 from AbstractShape :: {CalculateArea()}");
        }
    }
}
