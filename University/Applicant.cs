using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Applicant : Person
    {
        protected int ZNOMathScore { set; get; }
        protected int ZNOUkrainianScore { set; get; }
        protected int ZNOOptionalScore { set; get; }
        protected double SchoolCertificateGrade { set; get; }
        protected string SchoolName { set; get; }

        public Applicant() : base()
        {
            ZNOMathScore = 0;
            ZNOUkrainianScore = 0;
            ZNOOptionalScore = 0;
            SchoolCertificateGrade = 0;
            SchoolName = "none";
        }

        public Applicant(string firstName, string lastName, DateTime dateOfBirth, int znoMathScore, 
            int znoUkrainianScore, int znoOptionalScore, double schoolCertificateGrade, string schoolName) 
            : base(firstName, lastName, dateOfBirth)
        {
            ZNOMathScore = znoMathScore;
            ZNOUkrainianScore = znoUkrainianScore;
            ZNOOptionalScore = znoOptionalScore;
            SchoolCertificateGrade = schoolCertificateGrade;
            SchoolName = schoolName;
        }

        public double GetCompetetiveScore(double mathCoefficient, double ukraineanCoefficient, 
            double optionalCoefficient, double schoolCertificateCoefficient)
        {
            return Math.Round(ZNOMathScore * mathCoefficient + ZNOUkrainianScore * ukraineanCoefficient + ZNOOptionalScore * optionalCoefficient + SchoolCertificateGrade * schoolCertificateCoefficient,2);
        }
    }
}
