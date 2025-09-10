// HW1b Grade

// Your Name: Luke Maxwell
// Did you seek help ? If yes, specify the helper or web link here: I just referred to the code I used on the HW1a assignment

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            int StudentID;
            string GradeH;
            string GradeP;
            string GradeQ;
            string GradeM; 
            string GradeF;
            string FinalGrade;

            double sumH;
            double sumP;
            double sumQ;
            double sumM;
            double sumF;

            double numH;
            double numP;
            double numQ;
            double numM;
            double numF;

            const double Hmult = 0.2;
            const double Pmult = 0.075;
            const double Qmult = 0.075;
            const double Mmult = 0.4;
            const double Fmult = 0.25;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            StudentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            GradeH = (Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations?");
            GradeP = (Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            GradeQ = (Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the midterms?");
            GradeM = (Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the Final?");
            GradeF = (Console.ReadLine());

            numH = Convert.ToDouble(GradeH);
            numP = Convert.ToDouble(GradeP);
            numQ = Convert.ToDouble(GradeQ);
            numM = Convert.ToDouble(GradeM);
            numF = Convert.ToDouble(GradeF);

            sumH = numH * Hmult;
            sumP = numP * Pmult;
            sumQ = numQ * Qmult;
            sumM = numM * Mmult;
            sumF = numF * Fmult;

            FinalGrade = (sumH + sumP + sumQ + sumM + sumF).ToString("N2");
            Console.WriteLine(FirstName + " " + LastName + " (" + StudentID + "), your final grade is " + FinalGrade + "%");






        }   
    }
}
