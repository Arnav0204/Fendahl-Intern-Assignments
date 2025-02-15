using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator
{
    internal abstract class TaxInfo
    {
        protected double salary; 
        protected double tax;
        public TaxInfo(double salary) { 
            this.salary = salary;
        }

        public double CalculateTax()
        {
            double totalTax = 0;
           
            if(salary > 400000)
            {
                totalTax += Math.Min(400000, this.salary - 400000)*0.05;
            }
            if(salary > 800000)
            {
                totalTax += Math.Min(400000, this.salary - 800000) * 0.1;
            }
            if (salary > 1200000)
            {
                totalTax += Math.Min(400000, this.salary - 1200000) * 0.15;
            }
            if (salary > 1600000)
            {
                totalTax += Math.Min(400000, this.salary - 1600000) * 0.2;
            }
            if(salary > 2000000)
            {
                totalTax += Math.Min(400000, this.salary - 2000000) * 0.25;
            }
            if(salary > 2400000)
            {
                totalTax += Math.Min(double.MaxValue, this.salary - 2400000) * 0.3;
            }

            this.tax = totalTax;
            return totalTax;
        }
        public abstract double CalculateRebate();
    }

    internal class TaxRegime : TaxInfo
    {
        private double rebate;
        public TaxRegime(double salary) : base (salary)
        {
            
        }

        public override double CalculateRebate()
        {
            if (this.salary > 1200000)
            {
                return 0;
            }
            return this.tax;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int taxableAmount = 0;
            Console.WriteLine("Enter your taxable salary : ");
            taxableAmount = int.Parse(Console.ReadLine());
            TaxRegime taxCalculator = new TaxRegime(taxableAmount);
            Console.WriteLine($"Tax before rebate : {taxCalculator.CalculateTax()}");
            Console.WriteLine($"Total rebate : {taxCalculator.CalculateRebate()}");

            double taxApplied = taxCalculator.CalculateTax()-taxCalculator.CalculateRebate();
            Console.WriteLine($"Tax after rebate : {taxApplied}");
            Console.WriteLine($"Salary recieved : {taxableAmount-taxApplied}");
        }
    }
}
