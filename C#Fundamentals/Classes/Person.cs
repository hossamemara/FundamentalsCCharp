using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Classes
{
    internal class Person
    {
        public int ID { get; set; }
        //public string FirstName { get; set; }  can accept any value and can be null
        //public string LastName { get; set; }  can accept any value and can be null


        // First Name and Last Name should be set
        public string FirstName { get; private set; }

        public string LastName { get; private set; }


        public void SetFullName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                throw new ArgumentException("firs name & last name should be provided");
            else
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
        }

        #region BirthDate validation

        //public DateOnly BirthDate { get; set; } // Can Accept Invalid date , No Validation
        public DateOnly BirthDate { get; private set; }

        // set BirthDate method
        public void SetBirthDate(DateOnly birthDate)
        {
            // customed validation or filter
            if (birthDate < new DateOnly(2002, 1, 1))
                throw new ArgumentException("Invalid birthDate");
            else
                this.BirthDate = birthDate;
        }

        #endregion


        public decimal BasicSalary { get; private set; }

        public void SetBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 5000)
                throw new ArgumentException("invalid basic salary , should be >= 5000");
            else
                this.BasicSalary = basicSalary;
        }


    
}
}
