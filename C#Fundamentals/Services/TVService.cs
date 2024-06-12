using C_Fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Services
{
    internal class TVService : IDevice, IRestartable
    {
        public void TurnOn()
        {
            Console.WriteLine($"TVService Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"TVService Turned Off");
        }

        public void Restart()
        {
            Console.WriteLine($"TVService Restarted");
        }

        void IDevice.Restart()
        {
            Console.WriteLine($"TVService Restarted Explicitly from [IDevice]");
        }

        void IRestartable.Restart()
        {
            Console.WriteLine($"TVService Restarted Explicitly from [IRestartable]");
        }
    }
}
