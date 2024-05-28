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
        public int Id { get;  }
        public string Name { get; init; }
        public int Age { get; set; }
        private long _Salary;

        public Student(int Age)
        {
            //Age = age; // This is Not The Class Property This is Constructor Parameters
            this.Age = Age; // this.Name For Class Property 
        }
        public long Salary
        {
            get { 
                return _Salary; 
            }
            set { 
                _Salary = value; 
            }
        }

       

    }
}
