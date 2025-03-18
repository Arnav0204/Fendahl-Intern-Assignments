using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternWithInterface
{
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }

    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter vehicle type (Car/Bike):");
            string vehicleType = Console.ReadLine();

            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
                vehicle.StartEngine();
                vehicle.StopEngine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
