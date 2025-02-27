using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    internal class Payment
    {
        internal virtual void processPayment()
        {
            Console.WriteLine("Processing payment");
        }
        internal virtual double processPayment(double amount)
        {
            Console.WriteLine("0 processing fees : ");
            return 0;
        }
    }

    internal class PaypalPayment : Payment
    {
        internal override void processPayment()
        {
            base.processPayment();
        }
        internal override double processPayment(double amount)
        {
            return amount * 0.03;
        }
    }
    internal class CreditCardPayment : Payment
    {
        internal override void processPayment()
        {
            base.processPayment();
        }
        internal override double processPayment(double amount)
        {
            return amount * 0.05;
        }
    }

    internal class BankTransferPayment : Payment
    {
        internal override void processPayment()
        {
            base.processPayment();
        }
        internal override double processPayment(double amount)
        {
            return amount * 0.07;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 For PayPal");
            Console.WriteLine("Enter 2 For Credit Card");
            Console.WriteLine("Enter 3 For Bank Transfer");
            Console.Write("Enter Choice : ");
            int num = int.Parse(Console.ReadLine());
            Payment obj = new Payment();
            double amount = 0;
            double fees = 0;
            switch (num)
            {
                case 1:
                    obj = new PaypalPayment();
                    Console.Write("Enter Amount : ");
                    amount=double.Parse(Console.ReadLine());
                    obj.processPayment();
                    fees = obj.processPayment(amount);
                    break;
                case 2:
                    obj = new CreditCardPayment();
                    Console.Write("Enter Amount : ");
                    amount = double.Parse(Console.ReadLine());
                    obj.processPayment();
                    fees=obj.processPayment(amount);
                    break;
                case 3:
                    obj = new BankTransferPayment();
                    Console.Write("Enter Amount : ");
                    amount = double.Parse(Console.ReadLine());
                    obj.processPayment();
                    fees = obj.processPayment(amount);
                    break;

                default:
                    break;
            }
            Console.WriteLine($"Processing Fees is : {fees}");
        }
    }
}
