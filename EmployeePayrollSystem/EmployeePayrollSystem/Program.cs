using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
  
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }

    class FullTimeEmployee : Employee
    {
        private double MonthlySalary;

        public FullTimeEmployee(string name, double monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class ContractEmployee : Employee
    {
        public double HourlyRate { get; }
        public int HoursWorked { get; }

       
        
        public ContractEmployee(string name, double hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Employee fullTimeEmp = new FullTimeEmployee("Employee1", 5000);
            Employee contractEmp = new ContractEmployee("Employee2", 20, 160);

            Console.WriteLine("========= Employee Payroll Summary =========");
            Console.WriteLine($"Employee Name   : {fullTimeEmp.Name}");
            Console.WriteLine($"Employment Type : Full-Time");
            Console.WriteLine($"Monthly Salary  : Rs. {fullTimeEmp.CalculateSalary():N2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Employee Name   : {contractEmp.Name}");
            Console.WriteLine($"Employment Type : Contract-Based");
            Console.WriteLine($"Hourly Rate     : Rs. {((ContractEmployee)contractEmp).HourlyRate}");
            Console.WriteLine($"Hours Worked    : {((ContractEmployee)contractEmp).HoursWorked}");
            Console.WriteLine($"Total Salary    : Rs. {contractEmp.CalculateSalary()}");
            Console.WriteLine("============================================");

        }
    }

}
