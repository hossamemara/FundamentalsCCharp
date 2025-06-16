using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class PaySlipGenerator
    {
        private readonly INotifier _notifier;

        public PaySlipGenerator(INotifier notifier) 
        {
            this._notifier = notifier;
        }
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName}");
            message.AppendLine($"Please find payslip details ::");
            foreach (var payItem in payItems)
            {
                message.AppendLine($"{payItem.Name} \t \t {payItem.Value}");
            }
            Console.WriteLine(message);
            this._notifier.Notify(employee.Email, "payslip generated", message.ToString());
            Console.WriteLine(employee.GetName());
        }
    }
}
