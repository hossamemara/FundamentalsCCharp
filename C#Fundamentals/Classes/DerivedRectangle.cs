﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class DerivedRectangle : AbstractShape
    {
        public double width { get; set; }
        public double height { get; set; }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
