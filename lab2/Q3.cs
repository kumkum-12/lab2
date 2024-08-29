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
