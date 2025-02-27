using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBonusCalculator
{
    internal class Employee
    {
        protected double bonus = 50000;
        protected double salary = 0;
        protected Employee()
        {
       
        }
        internal virtual double calculateBonus()
        {
            return bonus;
        }
    }

    internal class Developer : Employee
    {
        internal Developer(double salary)
        {
            this.salary = salary;
        }
        internal override double calculateBonus()
        {
            return Math.Max(base.calculateBonus(),0.2*this.salary);
        }
    }

    internal class Manager : Employee
    {
        internal Manager(double salary)
        {
            this.salary = salary;
        }
        internal override double calculateBonus()
        {
            return Math.Max(base.calculateBonus(), 0.25 * this.salary);
        }
    }

    internal class Admin : Employee
    {
        internal Admin(double salary)
        {
            this.salary = salary;
        }
        internal override double calculateBonus()
        {
            return base.calculateBonus();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Developer : ");
            Console.WriteLine("Enter 2 for Manager : ");
            Console.WriteLine("Enter 3 for Admin : ");
            Console.Write("Enter Choice : ");
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            double salary = 0;
            switch(num)
            {
                case 1:
                    Console.WriteLine("Enter Developer Salary : ");
                    salary = double.Parse(Console.ReadLine());
                    Employee emp1 = new Developer(salary);
                    bonus = emp1.calculateBonus();
                    break;

                case 2:
                    Console.WriteLine("Enter Manager Salary : ");
                    salary = double.Parse(Console.ReadLine());
                    Employee emp2 = new Manager(salary);
                    bonus = emp2.calculateBonus();
                    break;
                
                case 3:
                    Console.WriteLine("Enter Admin Salary : ");
                    salary = double.Parse(Console.ReadLine());
                    Employee emp3 = new Admin(salary);
                    bonus = emp3.calculateBonus();
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Employee Bonus is : {bonus}");
        }
    }
}
