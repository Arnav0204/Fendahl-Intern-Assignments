using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Adder
    {
        public int add(int num1, int num2)
        {
            return num1+num2;
        }
        public double add(double num1, double num2,double num3)
        {
            return num1+num2+num3;
        } 
        public int add(int []arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }

    internal class AreaCalculator
    {
        public double area(double radius)
        {
            return 3.14 * radius * radius;
        }

        public double area(int length,int width)
        {
            return length * width;
        } 

        public double area(double bottom,double height)
        {
            return 0.5 * bottom * height;
        }
    }

    internal class Employee
    {
        private int id;
        private string name;

        public Employee()
        {
            this.name = "default name";
        }
        public Employee(string name)
        {
            this.name = name;
        } 
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine($"Employee Name: {name}, Employee ID: {(id == 0 ? "Not Assigned" : id.ToString())}");
        }
    }

    internal class Book
    {
        private string title;
        private string author;
        private double price;

        // Constructor that initializes only the title
        public Book(string title)
        {
            this.title = title;
            this.author = "Unknown";
            this.price = 0.0;
        }

        // Constructor that initializes the title and author
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.price = 0.0;
        }

        // Constructor that initializes the title, author, and price
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {(price == 0.0 ? "Not Set" : $"${price}")}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- TASK 1 ----------------------------");
            Adder adder = new Adder();

            // Using the first method (int, int)
            int result1 = adder.add(5, 10);
            Console.WriteLine($"Adding two integers (5 + 10): {result1}"); // Output: 15

            // Using the second method (double, double, double)
            double result2 = adder.add(1.5, 2.5, 3.0);
            Console.WriteLine($"Adding three doubles (1.5 + 2.5 + 3.0): {result2}"); // Output: 7.0

            // Using the third method (array of integers)
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result3 = adder.add(numbers);
            Console.WriteLine($"Adding an array of integers (1 + 2 + 3 + 4 + 5): {result3}");

            Console.WriteLine("---------------------------- TASK 2 ----------------------------");
            AreaCalculator areaCalculator = new AreaCalculator();

            // Using the first method (Circle)
            double circleArea = areaCalculator.area(5);
            Console.WriteLine($"Area of Circle (radius = 5): {circleArea}"); // Output: 78.5

            // Using the second method (Rectangle)
            double rectangleArea = areaCalculator.area(4, 6);
            Console.WriteLine($"Area of Rectangle (length = 4, width = 6): {rectangleArea}"); // Output: 24

            // Using the third method (Triangle)
            double triangleArea = areaCalculator.area(5, 8);
            Console.WriteLine($"Area of Triangle (bottom = 5, height = 8): {triangleArea}");

            Console.WriteLine("---------------------------- TASK 3 ----------------------------");
            // Using the default constructor
            Employee emp1 = new Employee();
            Console.Write("Default Constructor: ");
            emp1.Display(); // Output: Employee Name: default name, Employee ID: Not Assigned

            // Using the constructor with name only
            Employee emp2 = new Employee("John Doe");
            Console.Write("Constructor with Name: ");
            emp2.Display(); // Output: Employee Name: John Doe, Employee ID: Not Assigned

            // Using the constructor with name and id
            Employee emp3 = new Employee("Alice", 101);
            Console.Write("Constructor with Name & ID: ");
            emp3.Display(); // Output: Employee Name: Alice, Employee ID: 101

            Console.WriteLine("---------------------------- TASK 4 ----------------------------");
            Book book1 = new Book("The Alchemist");
            Console.Write("Constructor with Title: ");
            book1.Display(); // Output: Title: The Alchemist, Author: Unknown, Price: Not Set

            // Using the constructor with title and author
            Book book2 = new Book("1984", "George Orwell");
            Console.Write("Constructor with Title & Author: ");
            book2.Display(); // Output: Title: 1984, Author: George Orwell, Price: Not Set

            // Using the constructor with title, author, and price
            Book book3 = new Book("Clean Code", "Robert C. Martin", 29.99);
            Console.Write("Constructor with Title, Author & Price: ");
            book3.Display();


        }
    }
}
