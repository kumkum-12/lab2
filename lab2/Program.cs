using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = { 500, 800, 1200, 900, 1500 };
            decimal totalPrice = 0;
            foreach (decimal price in prices)
            {
                totalPrice += price;
            }
            if (totalPrice > 3000)
            {
                totalPrice *= 0.9m; 
            }

            //Console.WriteLine("Total price: Rs. " + totalPrice);
            //Q2.q2();
            //Q3.q3();
            //Q4.q4();
            //Q5.q5();
            //Q6.q6();
            //Q7.q7();
            Q10.q10();
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q2
    {
        public static void q2()
        {
            Console.Write("Enter temperature in Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = (celsius * 9 / 5) + 32;

            if (celsius < 0)
            {
                Console.WriteLine("Warning: Freezing temperatures!");
            }

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q3
    {
        static decimal balance = 1000;
        public static void q3()
        {
            Console.WriteLine("Simple ATM Simulator");

            while (true)
            {
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {balance:C}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance is {balance:C}");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance is {balance:C}");
            }
        }
    }
}
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q5
    {
        public static void q5()
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. Please ensure it meets the following criteria:");
                Console.WriteLine("  - At least 8 characters long");
                Console.WriteLine("  - Contains at least one uppercase letter");
                Console.WriteLine("  - Contains at least one lowercase letter");
                Console.WriteLine("  - Contains at least one number");
            }
        }

        static bool ValidatePassword(string password)
        {
            var hasUppercase = new Regex("[A-Z]").Match(password).Success;
            var hasLowercase = new Regex("[a-z]").Match(password).Success;
            var hasNumber = new Regex("[0-9]").Match(password).Success;
            var hasMinLength = password.Length >= 8;

            return hasUppercase && hasLowercase && hasNumber && hasMinLength;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q6
    {
        public static void q6()
        {
            Console.Write("Enter distance traveled (in kilometers): ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter ride time (in 24-hour format, e.g., 22:00): ");
            DateTime rideTime = DateTime.Parse(Console.ReadLine());

            decimal fare = CalculateFare(distance, rideTime);

            Console.WriteLine($"Fare: Rs. {fare:F2}");
        }

        static decimal CalculateFare(decimal distance, DateTime rideTime)
        {
            decimal baseFare = 20; 
            decimal perKmRate = 10; 
            decimal nightSurcharge = 0.1m; 

            decimal fare = baseFare;

            if (distance > 2)
            {
                fare += (distance - 2) * perKmRate;
            }

            if (rideTime.Hour >= 22 || rideTime.Hour < 6) 
            {
                fare *= (1 + nightSurcharge);
            }

            return fare;
        }
    }
}
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
            bool[] attendance = new bool[5]; /

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Day {i + 1} attendance (P/A): ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "P")
                {
                    attendance[i] = true; 
                }
                else if (input.ToUpper() == "A")
                {
                    attendance[i] = false; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter P or A.");
                    i--; /
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
            decimal[] monthlyExpenses = new decimal[12]; 

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q9
    {
        static List<Item> cart = new List<Item>();
        public static void q9()
        {
            while (true)
            {
                Console.WriteLine("Shopping Cart System");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        ViewCart();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Item item = new Item(name, price);
            cart.Add(item);
            Console.WriteLine("Item added to cart.");
        }

        static void RemoveItem()
        {
            Console.Write("Enter item name to remove: ");
            string name = Console.ReadLine();

            Item itemToRemove = cart.Find(i => i.Name == name);
            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine("Item removed from cart.");
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }

        static void ViewCart()
        {
            Console.WriteLine("Shopping Cart:");
            decimal totalPrice = 0;

            foreach (Item item in cart)
            {
                Console.WriteLine($"{item.Name}: {item.Price:C}");
                totalPrice += item.Price;
            }

            Console.WriteLine($"Total price: {totalPrice:C}");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
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
