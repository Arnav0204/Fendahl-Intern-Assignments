using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    using System;
    using System.Collections.Generic;

    abstract class Order
    {
        public int orderId;
        internal string orderType;
        internal static int orderIdCounter = 0;
        internal List<string> items;
        internal int numberOfOrders;
        internal Order()
        {
            this.orderId = ++orderIdCounter;
            this.items = new List<string>();
        }
        public abstract void placeOrder();
        public abstract void displayOrderDetails();
    }

    internal class DineInOrder : Order
    {
        private int tableNumber;

        public override void placeOrder()
        {
            Console.Write("Enter Table Number : ");
            this.tableNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Items : ");
            this.numberOfOrders=int.Parse(Console.ReadLine());
            while (this.numberOfOrders-->0)
            {
                Console.Write("Enter item : ");
                
                this.items.Add(Console.ReadLine());
            }
        }
        public override void displayOrderDetails()
        {
            Console.WriteLine($"Order Id : {this.orderId}");
            Console.WriteLine($"Table Number :{this.tableNumber}");
            foreach (string item in this.items)
            {
                Console.Write($"{item} ,");
            }
        }
    }

    internal class TakeAwayOrder : Order
    {
        
        public override void placeOrder()
        {
            Console.Write("Enter Number of Items : ");
            this.numberOfOrders = int.Parse(Console.ReadLine());
            while (this.numberOfOrders-- > 0)
            {
                Console.Write("Enter item : ");
                this.items.Add(Console.ReadLine());
            }
        }
        public override void displayOrderDetails()
        {
            Console.WriteLine($"Order Id : {this.orderId}");
            foreach (string item in this.items)
            {
                Console.Write($"{item} ,");
            }
        }
    }

    internal class OnlineOrder : Order
    {
        private string deliveryAddress;
        public override void placeOrder()
        {
            Console.Write("Enter Delivery Address : ");
            this.deliveryAddress = Console.ReadLine();
            Console.Write("Enter Number of Items : ");
            this.numberOfOrders = int.Parse(Console.ReadLine());
            while (this.numberOfOrders-- > 0)
            {
                Console.Write("Enter item : ");
                this.items.Add(Console.ReadLine());
            }
        }
        public override void displayOrderDetails()
        {
            Console.WriteLine($"Order Id : {this.orderId}");
            Console.WriteLine($"Delivery Address :{this.deliveryAddress}");
            foreach (string item in this.items)
            {
                Console.Write($"{item} ,");
            }
        }
    }



    internal class Program
    {
        static void Main()
        {
            List<Order> orders = new List<Order>(); // Single List of Orders

            while (true)
            {
                Console.WriteLine("\nSelect Order Type:");
                Console.WriteLine("1. Dine-In Order");
                Console.WriteLine("2. Takeaway Order");
                Console.WriteLine("3. Online Order");
                Console.WriteLine("4. Display All Orders");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                Order newOrder = null;

                switch (choice)
                {
                    case 1:
                        newOrder = new DineInOrder();
                        break;
                    case 2:
                        newOrder = new TakeAwayOrder();
                        break;
                    case 3:
                        newOrder = new OnlineOrder();
                        break;
                    case 4:
                        DisplayAllOrders(orders);
                        continue;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        continue;
                }

                newOrder.placeOrder();
                orders.Add(newOrder);
            }
        }

        static void DisplayAllOrders(List<Order> orders)
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("\nNo orders have been placed yet.");
                return;
            }

            Console.WriteLine("\n------------------ All Orders Placed ------------------");
            foreach (var order in orders)
            {
                order.displayOrderDetails();
            }
        }
    }
}


