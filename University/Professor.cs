using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Professor : Person
    {
        protected string Position { set; get; }
        protected string Department { set; get; }
        protected string EducationalInstitution { set; get; }

        public Professor(string firstName, string lastName, DateTime dateOfBirth, string position, 
            string department, string educationalInstitution): base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            EducationalInstitution = educationalInstitution;
        }

        public string GetDepartment()
        {
            return Department;
        }
    }
}
