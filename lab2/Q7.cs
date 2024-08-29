using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q7
    {
        public static void q7()
        {
            bool[] attendance = new bool[5]; // 5-day attendance record

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Day {i + 1} attendance (P/A): ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "P")
                {
                    attendance[i] = true; // Present
                }
                else if (input.ToUpper() == "A")
                {
                    attendance[i] = false; // Absent
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter P or A.");
                    i--; // Repeat the day
                }
            }

            int totalDaysAttended = CalculateDaysAttended(attendance);
            bool hasPerfectAttendance = HasPerfectAttendance(attendance);

            Console.WriteLine($"Total days attended: {totalDaysAttended}");
            Console.WriteLine($"Perfect attendance: {(hasPerfectAttendance ? "Yes" : "No")}");
        }

        static int CalculateDaysAttended(bool[] attendance)
        {
            int count = 0;
            foreach (bool attended in attendance)
            {
                if (attended)
                {
                    count++;
                }
            }
            return count;
        }

        static bool HasPerfectAttendance(bool[] attendance)
        {
            return attendance.All(attended => attended);
        }
    }
}
