using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class Student
    {

        public Student(int Age)
        {
            this.Age = Age;
        }
        // Prpperties
        public int Id { get;  }

        public string? Name { get; init; } // init only

        public int Age { get; set; }  // this.Name For Class Property 
        private long _Salary; // backing field

        private string? _gender; // backing field
        public string Gender {
            set
            {
                _gender = value;
            }
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
