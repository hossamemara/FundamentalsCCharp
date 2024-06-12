using C_Fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Services
{
    internal class Phone
    {

        public void TurnOn()
        {
            Console.WriteLine($"Phone Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Phone Turned Off");
        }
    }
}
