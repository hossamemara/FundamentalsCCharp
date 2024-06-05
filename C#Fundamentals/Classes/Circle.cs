using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class Circle
    {
        public double raduis { get; set; }

        public void PrintArea()
        {
            Console.WriteLine($"Area :: {CalculateArea()}");
        }
        double CalculateArea()
        {
            return Math.PI * raduis * raduis;
        }
    }
}
