using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class Student
    {

        // Prpperties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long Salary { get; set; }

        public Student(string Name)
        {
            Name = Name; // This is Not The Class Property This is Constructor Parameters
            this.Name = Name; // this.Name For Class Property 
        }
    }
}
