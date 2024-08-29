using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q10
    {
        public static void q10()
        {
            Console.Write("Enter hourly wage: ");
            decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter number of hours worked in a week: ");
            decimal hoursWorkedPerWeek = Convert.ToDecimal(Console.ReadLine());

            decimal monthlySalary = CalculateMonthlySalary(hourlyWage, hoursWorkedPerWeek);

            Console.WriteLine($"Monthly salary: {monthlySalary:C}");
        }

        static decimal CalculateMonthlySalary(decimal hourlyWage, decimal hoursWorkedPerWeek)
        {
            decimal hoursWorkedPerMonth = hoursWorkedPerWeek * 4; // 4 weeks in a month
            decimal monthlySalary = hourlyWage * hoursWorkedPerMonth;
            return monthlySalary;
        }
    }
}
