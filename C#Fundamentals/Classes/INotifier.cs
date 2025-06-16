using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal interface INotifier
    {
        public void Notify(string Email, string subject, string body);
    }
}
