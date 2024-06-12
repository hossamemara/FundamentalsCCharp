using C_Fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Services
{
    internal class PhoneService : IDevice, IRestartable
    {
        public void TurnOn()
        {
            Console.WriteLine($"PhoneService Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"PhoneService Turned Off");
        }

       
        void IDevice.Restart()
        {
            Console.WriteLine($"PhoneService Restarted Explicitly from [IDevice]");
        }

        void IRestartable.Restart()
        {
            Console.WriteLine($"PhoneService Restarted Explicitly from [IRestartable]");
        }
    }
}
