using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q4
    {
        public static void q4()
        {
            Console.WriteLine("Enter marks for five subjects (out of 100):");

            decimal totalMarks = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Subject {i}: ");
                decimal marks = Convert.ToDecimal(Console.ReadLine());
                totalMarks += marks;
            }

            decimal average = totalMarks / 5;

            Console.WriteLine($"Average marks: {average:F2}");

            string grade = GetGrade(average);

            Console.WriteLine($"Grade: {grade}");
        }

        static string GetGrade(decimal average)
        {
            if (average >= 90) return "A";
            else if (average >= 80) return "B";
            else if (average >= 70) return "C";
            else if (average >= 60) return "D";
            else return "F";
        }
    }
}
