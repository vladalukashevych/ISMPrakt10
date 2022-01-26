using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        protected string FirstName { set; get; }
        protected string LastName { set; get; }
        protected DateTime DateOfBirth { set; get; }

        public Person()
        {
            FirstName = "none";
            LastName = "none";
            DateOfBirth = new DateTime();
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            return (int)(age.TotalDays/365);
        }
    }
}
