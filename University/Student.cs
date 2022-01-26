using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student : Person
    {
        protected int Grade { set; get; }
        protected string Group { set; get; }
        protected string Faculty { set; get; }
        protected string EducationalInstitution { set; get; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int grade, string group,
            string faculty, string educationalInstitution) : base(firstName, lastName, dateOfBirth)
        {
            Grade = grade;
            Group = group;
            Faculty = faculty;
            EducationalInstitution = educationalInstitution;
        }

        public string GetStudentMainInfo()
        {
            return LastName + " " + FirstName + " - " + Group;
        }
    }
}
