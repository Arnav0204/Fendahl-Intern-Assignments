using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBillCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double unitsConsumed = 0;
            Console.WriteLine("Enter the number of units consumed : ");
            unitsConsumed = double.Parse(Console.ReadLine());
            double amount = 0;
            if(unitsConsumed >300 )
            {
                amount = 1200 + (unitsConsumed - 300) * 12;
            }
            else if(unitsConsumed > 200)
            {
                amount = 600 + (unitsConsumed - 200) * 6;
            }
            else if(unitsConsumed > 100)
            {
                amount = 200 + (unitsConsumed - 100) * 4;
            }
            else
            {
                amount = unitsConsumed * 2;
            }
            Console.WriteLine($"The amount to be paid : {amount}");
        }
    }
}
