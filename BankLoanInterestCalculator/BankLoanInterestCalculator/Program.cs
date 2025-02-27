using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoanInterestCalculator
{
    using System;

    class BankLoan
    {
        
        public double CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"Personal Loan Interest: {interest}");
            return interest;
        }

        public double CalculateInterest(double principal, double rate, int time, double discountRate)
        {
            double actualRate = rate - discountRate;
            double interest = (principal * actualRate * time) / 100;
            Console.WriteLine($"Home Loan Interest (after discount): {interest}");
            return interest;
        }

        public double CalculateInterest(double principal, double rate, int time, int compoundingFrequency, bool isCompound)
        {
            double interest;
            if (isCompound)
            {
                
                double amount = principal * Math.Pow((1 + (rate / (100*compoundingFrequency))), (compoundingFrequency * time));
                interest = amount - principal;
            }
            else
            {
                interest = (principal * rate * time) / 100;
            }

            Console.WriteLine($" Custom Loan Interest: {interest}");
            return interest;
        }
    }

    class Program
    {
        static void Main()
        {
            BankLoan loanCalculator = new BankLoan();

            while (true)
            {
                Console.WriteLine("\n Bank Loan Interest Calculator");
                Console.WriteLine("1. Calculate Personal Loan Interest");
                Console.WriteLine("2. Calculate Home Loan Interest (with Discount)");
                Console.WriteLine("3. Calculate Custom Loan Interest");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Loan Amount: ");
                        double personalPrincipal = double.Parse(Console.ReadLine());
                        Console.Write("Enter Interest Rate (%): ");
                        double personalRate = double.Parse(Console.ReadLine());
                        Console.Write("Enter Loan Duration (years): ");
                        int personalTime = int.Parse(Console.ReadLine());

                        loanCalculator.CalculateInterest(personalPrincipal, personalRate, personalTime);
                        break;

                    case "2":
                        Console.Write("Enter Loan Amount: ");
                        double homePrincipal = double.Parse(Console.ReadLine());
                        Console.Write("Enter Interest Rate (%): ");
                        double homeRate = double.Parse(Console.ReadLine());
                        Console.Write("Enter Loan Duration (years): ");
                        int homeTime = int.Parse(Console.ReadLine());
                        Console.Write("Enter Special Discount Rate (%): ");
                        double discountRate = double.Parse(Console.ReadLine());

                        loanCalculator.CalculateInterest(homePrincipal, homeRate, homeTime, discountRate);
                        break;

                    case "3":
                        Console.Write("Enter Loan Amount: ");
                        double customPrincipal = double.Parse(Console.ReadLine());
                        Console.Write("Enter Interest Rate (%): ");
                        double customRate = double.Parse(Console.ReadLine());
                        Console.Write("Enter Loan Duration (years): ");
                        int customTime = int.Parse(Console.ReadLine());
                        Console.Write("Enter Compounding Frequency (1 for yearly, 4 for quarterly, etc.): ");
                        int compoundingFrequency = int.Parse(Console.ReadLine());
                        Console.Write("Is it a compound interest loan? (yes/no): ");
                        bool isCompound = Console.ReadLine().ToLower() == "yes";

                        loanCalculator.CalculateInterest(customPrincipal, customRate, customTime, compoundingFrequency, isCompound);
                        break;

                    case "4":
                        Console.WriteLine("Exiting Bank Loan Interest Calculator.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }

}
