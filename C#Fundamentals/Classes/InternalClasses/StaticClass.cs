using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes.InternalClasses
{
    internal static class StaticClass
    {
        public static string Name { get; set; }
        static StaticClass()  // No Access Modifiers Allowed , For Static Class We Must Have Static Construcor
        {
            Name = "Ahmed";
            Console.WriteLine("This is Static Class");
        }

        public static string PrintHello()
        {
            return "Hello";
        }
    }
}
