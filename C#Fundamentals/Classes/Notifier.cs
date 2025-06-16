using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class Notifier: INotifier
    {
        public Notifier(string smtpServer, int port, string senderAddress, string senderPassword) 
        {
            SmtpServer = smtpServer;
            Port = port;
            SenderAddress = senderAddress;
            SenderPassword = senderPassword;
        }

        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string SenderAddress { get; set; }
        public string SenderPassword { get; set; }

        public void Notify(string Email, string subject , string body) 
        {
            Console.WriteLine($"You have a new email from {SenderAddress} with subject {subject}");
            Console.WriteLine($"{body}");
            Console.WriteLine($"message send to {Email}");

        }

    }
}
