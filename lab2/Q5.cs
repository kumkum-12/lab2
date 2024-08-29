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
