using System;
using University;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Victor", "Yaroshyn", new DateTime(1999, 1, 1));
            Console.WriteLine($"Age: {person.GetAge()}");
            Applicant applicant = new Applicant("Viktoria", "Zabudko", new DateTime(2005, 7, 18), 198, 168, 189, 
                11.2, "Zhytomyr City Lyceum №1");
            Console.WriteLine($"Competetive score: {applicant.GetCompetetiveScore(0.5, 0.3, 0.2, 0), 5}");
            Student student = new Student("Igor", "Lapatin", new DateTime(2004, 12, 9), 1, "IPZ-21-1", "ICT",
                "Zhytomyr Polytechnic State University");
            Console.WriteLine($"{student.GetStudentMainInfo()}");
            Professor professor = new Professor("Olga", "Markevych", new DateTime(1985, 5, 29), "lecturer",
                "ICT", "Zhytomyr Polytechnic State University");
            Console.WriteLine($"Department: {professor.GetDepartment()}");
            LibraryUser libraryUser = new LibraryUser("Anna", "Vaculovych", new DateTime(2002, 3, 8), 1, "CB-21-1", "ICT",
                "Zhytomyr Polytechnic State University", "223005", new DateTime(2020, 9, 1), 19.044);
            Console.WriteLine($"General contribution: {libraryUser.GetGeneralContribution()}");
        }
    }
}
