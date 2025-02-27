using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem
{
  
    class Ticket
    {
        public string PassengerName { get; set; }
        public string Destination { get; set; }
        public string ClassType { get; set; }

        public Ticket(string passengerName, string destination, string classType)
        {
            PassengerName = passengerName;
            Destination = destination;
            ClassType = classType;
        }

    }

    class FlightBooking
    {
        private List<Ticket> bookedTickets = new List<Ticket>();

        
        public void BookTicket(string passengerName, string destination)
        {
            bookedTickets.Add(new Ticket(passengerName, destination, "Economy"));
            Console.WriteLine($" Ticket booked for {passengerName} to {destination} in Economy class.");
        }

        
        public void BookTicket(string passengerName, string destination, string classType)
        {
            bookedTickets.Add(new Ticket(passengerName, destination, classType));
            Console.WriteLine($"Ticket booked for {passengerName} to {destination} in {classType} class.");
        }

       
        public void BookTicket(string[] passengerNames, string destination, string classType = "Economy")
        {
            foreach (var name in passengerNames)
            {
                bookedTickets.Add(new Ticket(name, destination, classType));
            }
            Console.WriteLine($" Tickets booked for {string.Join(", ", passengerNames)} to {destination} in {classType} class.");
        }


    }

    class Program
    {
        static void Main()
        {
            FlightBooking booking = new FlightBooking();
            while (true)
            {
                Console.WriteLine("Flight Booking System");
                Console.WriteLine("1. Book a ticket for a single passenger");
                Console.WriteLine("2. Book a ticket with class type");
                Console.WriteLine("3. Book tickets for multiple passengers");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                if(choice==4)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter passenger name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter destination: ");
                        string destination = Console.ReadLine();
                        booking.BookTicket(name, destination);
                        break;

                    case 2:
                        Console.Write("Enter passenger name: ");
                        string nameWithClass = Console.ReadLine();
                        Console.Write("Enter destination: ");
                        string destinationWithClass = Console.ReadLine();
                        Console.Write("Enter class type (Economy/Business): ");
                        string classType = Console.ReadLine();
                        booking.BookTicket(nameWithClass, destinationWithClass, classType);
                        break;

                    case 3:
                        Console.Write("Enter number of passengers: ");
                        int numPassengers;
                        while (!int.TryParse(Console.ReadLine(), out numPassengers) || numPassengers <= 0)
                        {
                            Console.Write("Invalid input. Enter a valid number: ");
                        }

                        string[] passengers = new string[numPassengers];
                        for (int i = 0; i < numPassengers; i++)
                        {
                            Console.Write($"Enter name for passenger {i + 1}: ");
                            passengers[i] = Console.ReadLine();
                        }

                        Console.Write("Enter destination: ");
                        string multiDestination = Console.ReadLine();
                        Console.Write("Enter class type (Economy/Business): ");
                        string multiClassType = Console.ReadLine();
                        booking.BookTicket(passengers, multiDestination, multiClassType);
                        break;


                    default:
                        Console.WriteLine(" Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }

}
