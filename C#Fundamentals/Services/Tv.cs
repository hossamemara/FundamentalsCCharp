﻿using C_Fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Services
{
    internal class Tv
    {

        public void TurnOn()
        {
            Console.WriteLine($"Tv Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Tv Turned Off");
        }
    }
}
