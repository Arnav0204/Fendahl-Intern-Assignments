using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    abstract class Vehicle
    {
        public string registrationNumber;
        public string companyName; 
        public Vehicle(string registrationNumber, string companyName)
        {
            this.registrationNumber = registrationNumber;
            this.companyName = companyName;
        }

        public abstract void calculateRentalPrice(int hours);
        internal void displayVehicleDetails()
        {
            Console.WriteLine($"Registration Number:{this.registrationNumber}");
            Console.WriteLine($"Company Name:{this.companyName}");
        }
 
    }

    class Car : Vehicle
    {
        public Car(string registrationNumber, string companyName):base(registrationNumber,companyName)
        {
            
        }
        public override void calculateRentalPrice(int hours)
        {
            Console.WriteLine($"Price is : {hours*100}");
        }
    }
    class Bike : Vehicle
    {
        public Bike(string registrationNumber, string companyName) : base(registrationNumber, companyName)
        {

        }
        public override void calculateRentalPrice(int hours)
        {
            Console.WriteLine($"Price is : {hours * 50}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName, registrationNumber;
            Console.Write("Enter Company Name : ");
            companyName= Console.ReadLine();
            Console.Write("Enter Registration Name : ");
            registrationNumber = Console.ReadLine();
            Vehicle car = new Car(registrationNumber,companyName);
            car.displayVehicleDetails();
            car.calculateRentalPrice(10);
            Vehicle bike = new Bike(registrationNumber, companyName);
            bike.displayVehicleDetails();
            bike.calculateRentalPrice(10);

        }
    }
}
