using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class LibraryUser : Student
    {
        protected string LibraryCardNumber { set; get; }
        protected DateTime DateOfIssue { set; get; }
        protected double MonthlyContribution { set; get; }

        public LibraryUser(string firstName, string lastName, DateTime dateOfBirth, int grade, string group,
            string faculty, string educationalInstitution, string libraryCardNumber, DateTime dateOfIssue,
            double monthlyContribution) : base(firstName, lastName, dateOfBirth, grade, group, faculty,
                educationalInstitution)
        {
            LibraryCardNumber = libraryCardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyContribution = monthlyContribution;
        }

        public double GetGeneralContribution()
        {
            TimeSpan timeOfMembership = DateTime.Now - DateOfIssue;
            return ((int)(timeOfMembership.TotalDays / 30.416)) * MonthlyContribution;
        }
    }
}
