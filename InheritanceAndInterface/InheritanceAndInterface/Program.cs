using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterface
{
    internal class Program
    {

        static void Main()
        {
            
            Console.WriteLine("\n------------------- TASK 1: Person and Student -------------------");
            Console.WriteLine("Creating a Student object and displaying its details.");
            Student student = new Student("XYZ", 20, "A");
            student.DisplayInfo();

            Console.WriteLine("\n------------------- TASK 2: Vehicle Hierarchy -------------------");
            Console.WriteLine("Demonstrating inheritance and method overriding in vehicles.");
            ElectricCar myTesla = new ElectricCar();
            myTesla.StartEngine();
            Console.WriteLine("An electric car has been created and started.");
            myTesla.Drive();
            Console.WriteLine("The car is now driving.");
            myTesla.ChargeBattery();
            Console.WriteLine("Battery charging initiated.");

            Console.WriteLine("\n------------------- TASK 3: Animal Sounds -------------------");
            Console.WriteLine("Creating Dog and Cat objects to demonstrate hierarchical inheritance.");
            Animal dog = new Dog();
            Animal cat = new Cat();
            Console.WriteLine("The dog speaks:");
            dog.Speak();
            Console.WriteLine("The cat speaks:");
            cat.Speak();

            Console.WriteLine("\n------------------- TASK 4: Duck Behavior -------------------");
            Console.WriteLine("Demonstrating interface-based composition to achieve multiple inheritance.");
            Duck duck = new Duck();
            Console.WriteLine("The duck demonstrates flying:");
            duck.Fly();
            Console.WriteLine("The duck demonstrates swimming:");
            duck.Swim();

            Console.WriteLine("\n------------------- TASK 5: Shape Area Calculation -------------------");
            Console.WriteLine("Calculating the area of different shapes using abstract class and inheritance.");
            Shape rect = new Rectangle(5, 10);
            Shape circle = new Circle(5);
            Console.WriteLine($"The area of the rectangle (5x10) is: {rect.CalculateArea()}");
            Console.WriteLine($"The area of the circle (radius 5) is: {circle.CalculateArea()}");

        }
    }
}
