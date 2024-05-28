using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes.InternalClasses
{
    internal class NonStaticClass
    {
        public static string Name { get; set; } // Class Level Scope
        public NonStaticClass()  // No Access Modifiers Allowed , For Static Class We Must Have Static Construcor
        {
            var x = 7;
            Name = "Ahmed";
            Console.WriteLine("This is Non Static Class");
        }

        
        // We Can Use Static Methos In Non Static Class 
        public static string PrintHello()
        {
            for (int i = 0; i < 10; i++)
            {
                var y = 6;
            }
            // Console.WriteLine(y); // Block Level Scope , y Defined in for Can't be Reached
            //Console.WriteLine(x); // Method Level Scope , x Defined in Constructor Can't be Reached
            return "Hello";
        }
    }
}
