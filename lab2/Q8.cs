using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q8
    {
        public static void q8()
        {
            decimal[] monthlyExpenses = new decimal[12]; // 12 months

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter expenses for month {i + 1}: ");
                monthlyExpenses[i] = Convert.ToDecimal(Console.ReadLine());
            }

            decimal totalExpenses = CalculateTotalExpenses(monthlyExpenses);
            int highestMonth = GetHighestMonth(monthlyExpenses);
            int lowestMonth = GetLowestMonth(monthlyExpenses);

            Console.WriteLine($"Total expenses for the year: {totalExpenses:C}");
            Console.WriteLine($"Month with highest expenses: {GetMonthName(highestMonth)} ({monthlyExpenses[highestMonth - 1]:C})");
            Console.WriteLine($"Month with lowest expenses: {GetMonthName(lowestMonth)} ({monthlyExpenses[lowestMonth - 1]:C})");
        }

        static decimal CalculateTotalExpenses(decimal[] expenses)
        {
            decimal total = 0;
            foreach (decimal expense in expenses)
            {
                total += expense;
            }
            return total;
        }

        static int GetHighestMonth(decimal[] expenses)
        {
            int highestMonth = 1;
            decimal maxExpense = expenses[0];

            for (int i = 1; i < 12; i++)
            {
                if (expenses[i] > maxExpense)
                {
                    maxExpense = expenses[i];
                    highestMonth = i + 1;
                }
            }

            return highestMonth;
        }

        static int GetLowestMonth(decimal[] expenses)
        {
            int lowestMonth = 1;
            decimal minExpense = expenses[0];

            for (int i = 1; i < 12; i++)
            {
                if (expenses[i] < minExpense)
                {
                    minExpense = expenses[i];
                    lowestMonth = i + 1;
                }
            }

            return lowestMonth;
        }

        static string GetMonthName(int month)
        {
            string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return monthNames[month - 1]; decimal[] monthlyExpenses = new decimal[12]; // 12 months

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter expenses for month {i + 1}: ");
                monthlyExpenses[i] = Convert.ToDecimal(Console.ReadLine());
            }

            decimal totalExpenses = CalculateTotalExpenses(monthlyExpenses);
            int highestMonth = GetHighestMonth(monthlyExpenses);
            int lowestMonth = GetLowestMonth(monthlyExpenses);

            Console.WriteLine($"Total expenses for the year: {totalExpenses:C}");
            Console.WriteLine($"Month with highest expenses: {GetMonthName(highestMonth)} ({monthlyExpenses[highestMonth - 1]:C})");
            Console.WriteLine($"Month with lowest expenses: {GetMonthName(lowestMonth)} ({monthlyExpenses[lowestMonth - 1]:C})");
        }

        static decimal CalculateTotalExpenses(decimal[] expenses)
        {
            decimal total = 0;
            foreach (decimal expense in expenses)
            {
                total += expense;
            }
            return total;
        }

        static int GetHighestMonth(decimal[] expenses)
        {
            int highestMonth = 1;
            decimal maxExpense = expenses[0];

            for (int i = 1; i < 12; i++)
            {
                if (expenses[i] > maxExpense)
                {
                    maxExpense = expenses[i];
                    highestMonth = i + 1;
                }
            }

            return highestMonth;
        }

        static int GetLowestMonth(decimal[] expenses)
        {
            int lowestMonth = 1;
            decimal minExpense = expenses[0];

            for (int i = 1; i < 12; i++)
            {
                if (expenses[i] < minExpense)
                {
                    minExpense = expenses[i];
                    lowestMonth = i + 1;
                }
            }

            return lowestMonth;
        }

        static string GetMonthName(int month)
        {
            string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return monthNames[month - 1];
        }
    }
}
