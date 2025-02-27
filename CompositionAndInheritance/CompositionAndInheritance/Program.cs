using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Transportation Management System
            Console.WriteLine("--------------------TASK 1: Transportation Management System--------------------");
            Vehicle car = new Car { LicensePlate = "CAR123", MaxSpeed = 200, NumberOfDoors = 4 };
            Vehicle bike = new Motorbike { LicensePlate = "BIKE456", MaxSpeed = 150, HasSideCar = false };
            Vehicle bicycle = new Bicycle { LicensePlate = "CYCLE789", MaxSpeed = 30, IsElectric = true };

            car.StartEngine();
            car.DisplayDetails();
            bike.DisplayDetails();
            bicycle.DisplayDetails();
            Console.WriteLine();

            // 2. Student Record Management System
            Console.WriteLine("--------------------TASK 2: Student Record Management System--------------------");
            Address address = new Address
            {
                Street = "123 Main St",
                City = "Nagpur",
                State = "Maharashtra",
                PostalCode = "440001"
            };

            Student student = new Student
            {
                Name = "John Doe",
                RollNumber = 101,
                Address = address
            };

            student.DisplayInfo();
            Console.WriteLine();

            // 3. E-commerce Application
            Console.WriteLine("--------------------TASK 3: E-commerce Application--------------------");
            Supplier supplier = new Supplier { Name = "Tech World", ContactDetails = "123-456-7890" };

            Product laptop = new Electronics { Name = "Laptop", Price = 1000.50m, SKU = "ELEC001", WarrantyPeriod = 2, Supplier = supplier };
            Product shirt = new Clothing { Name = "Shirt", Price = 29.99m, SKU = "CLOT001", Size = "M", Supplier = supplier };
            Product apple = new Groceries { Name = "Apple", Price = 0.99m, SKU = "GROC001", ExpirationDate = DateTime.Now.AddDays(7), Supplier = supplier };

            laptop.DisplayProduct();
            shirt.DisplayProduct();
            apple.DisplayProduct();
            Console.WriteLine();

            // 4. Human Resource Management System
            Console.WriteLine("--------------------TASK 4: Human Resource Management System--------------------");
            Employee manager = new Manager { Name = "Alice", EmployeeID = 1, Salary = 90000 };
            Employee engineer = new Engineer { Name = "Bob", EmployeeID = 2, Salary = 80000 };
            Employee intern = new Intern { Name = "Charlie", EmployeeID = 3, Salary = 20000 };

            manager.DisplayRole();
            ((Manager)manager).ManageTeam();
            engineer.DisplayRole();
            intern.DisplayRole();
            Console.WriteLine();

            // 5. Library Management System
            Console.WriteLine("--------------------TASK 5: Library Management System--------------------");
            Library library = new Library { LibraryName = "City Library" };

            library.AddBook(new Book { Title = "C# Programming", Author = "John Smith", PublicationDate = new DateTime(2020, 1, 1) });
            library.AddBook(new Book { Title = "Mastering OOP", Author = "Jane Doe", PublicationDate = new DateTime(2021, 5, 15) });

            library.DisplayBooks();
            Console.WriteLine();

            // 6. Banking System
            Console.WriteLine("--------------------TASK 6: Banking System--------------------");
            Customer customer = new Customer { Name = "David", Address = "456 Park Avenue", PhoneNumber = "987-654-3210" };

            Account savings = new SavingsAccount { AccountNumber = "SAV123", Balance = 5000.75m, InterestRate = 4.5m, Customer = customer };
            Account current = new CurrentAccount { AccountNumber = "CUR456", Balance = 2000.00m, OverdraftLimit = 1000.00m, Customer = customer };

            savings.DisplayAccountDetails();
            current.DisplayAccountDetails();

            Console.WriteLine("\n--------------------END OF PROGRAM--------------------");
        }
    }
}
