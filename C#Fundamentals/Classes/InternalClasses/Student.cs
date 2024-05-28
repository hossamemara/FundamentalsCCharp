using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes.InternalClasses
{
    internal class Student
    {
        public int Id { get; }
        public string Name { get; init; }
        public int Age { get; set; }
    }
}
