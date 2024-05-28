using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes.InternalClasses
{
    internal class Info
    {
        private const float Pi = 3.14f;
        //private const float Pi; // Must Assign Value at Same Line

        private readonly string _name1 = "Hell World!";
        private readonly string _name2; // We Can Change Only Inside Constructor 
        public Info()
        {
            //Pi = 3.19; Can't Change Const Value
            this._name2 = "Hello World";
        }
    }
}
