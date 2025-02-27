using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideFareCalculator
{
    using System;

    class RideBooking
    {
        private double BASE_RATE = 10;  
        private double PREMIUM_MULTIPLIER = 1.5;  


       
        public double CalculateFare(double distance)
        {
            double fare = BASE_RATE * distance;
            Console.WriteLine($" Regular Ride Fare: {fare}");
            return fare;
        }

     
        public double CalculateFare(double distance, double multiplier)
        {
            double fare = BASE_RATE * distance * multiplier;
            Console.WriteLine($" Premium Ride Fare (Multiplier {multiplier}): {fare}");
            return fare;
        }

        
        public double CalculateFare(double distance, int passengers)
        {
            if (passengers < 1)
            {
                Console.WriteLine(" Invalid passenger count. At least 1 passenger required.");
                return 0;
            }

            double totalFare = BASE_RATE * distance;
            double perPersonFare = totalFare / passengers; 

            Console.WriteLine($" Shared Ride Fare (for {passengers} passengers): {totalFare}");
            Console.WriteLine($" Each Passenger Pays: {perPersonFare}");
            return perPersonFare;
        }
    }

    class Program
    {
        static void Main()
        {
            RideBooking rideCalculator = new RideBooking();

            while (true)
            {
                Console.WriteLine("\n Ride Fare Calculator");
                Console.WriteLine("1. Calculate Regular Ride Fare");
                Console.WriteLine("2. Calculate Premium Ride Fare");
                Console.WriteLine("3. Calculate Shared Ride Fare");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter ride distance (km): ");
                        double regDistance = double.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(regDistance);
                        break;

                    case "2":
                        Console.Write("Enter ride distance (km): ");
                        double premDistance = double.Parse(Console.ReadLine());
                        Console.Write("Enter premium multiplier (e.g., 1.5 for peak hours): ");
                        double multiplier = double.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(premDistance, multiplier);
                        break;

                    case "3":
                        Console.Write("Enter ride distance (km): ");
                        double sharedDistance = double.Parse(Console.ReadLine());
                        Console.Write("Enter number of passengers: ");
                        int passengers = int.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(sharedDistance, passengers);
                        break;

                    case "4":
                        Console.WriteLine("Exiting Ride Fare Calculator.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }

}
