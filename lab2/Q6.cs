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
            decimal baseFare = 20; // Flat rate for first 2 kilometers
            decimal perKmRate = 10; // Per-kilometer rate
            decimal nightSurcharge = 0.1m; // 10% night surcharge

            decimal fare = baseFare;

            if (distance > 2)
            {
                fare += (distance - 2) * perKmRate;
            }

            if (rideTime.Hour >= 22 || rideTime.Hour < 6) // Night surcharge after 10 PM or before 6 AM
            {
                fare *= (1 + nightSurcharge);
            }

            return fare;
        }
    }
}
