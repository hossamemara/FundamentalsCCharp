using C_Fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Services
{
    internal class LampService : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine($"LampService Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"LampService Turned Off");
        }

        public void Restart()
        {
            throw new NotImplementedException();
        }
    }
}
