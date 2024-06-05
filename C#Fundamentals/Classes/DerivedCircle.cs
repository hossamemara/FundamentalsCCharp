using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class DerivedCircle : AbstractShape
    {
        public double raduis { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * raduis * raduis;
        }

        public override void PrintArea()
        {
            base.PrintArea();  // the virtial member
            Console.WriteLine($"Area of Circle :: {CalculateArea()}");
        }
    }
}
