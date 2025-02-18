using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    internal class Employee
    {
        public Employee() { }
        private string name { get; set; }
        private int id { get; set; }
        private string designation {  get; set; }
        private double salary { get; set; }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getDesignation()
        {
            return this.designation;
        }
        public void setDesignation(string designation)
        {
            this.designation = designation;
        }
        public double getSalary()
        {
            return this.salary;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public void updateSalary(double salary)
        {
            if(salary < 0)
            {
                Console.WriteLine("invalid change");
                return;
            }
            this.setSalary(salary);
        }
        
    }
    internal class BankAccount
    {
        private string accountHolderName;
        private double balance;


        public BankAccount()
        {

        }

        public void withdrawMoney(double amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine("insufficient balance");
                return;
            }
            this.balance -= amount;
        }

        public double depositMoney(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("invalid deposit amount");
            }
            else
            {
                this.balance += amount;
            }
            return this.balance;
        }

        public double getBalance()
        {
            return this.balance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("----------------------------- TASK 1 -----------------------------");
                Console.WriteLine("BANK ACCOUNT MANAGEMENT");
            BankAccount account = new BankAccount();
            while (true)
                {
                    Console.WriteLine("Enter 1 to check balance ");
                    Console.WriteLine("Enter 2 to deposit ");
                    Console.WriteLine("Enter 3 to withdraw ");
                    Console.WriteLine("Enter 4 to exit ");
                    int num = int.Parse(Console.ReadLine());
                if (num == 4)
                {
                    break;
                }
                    switch(num)
                    {
                        case 1:
                            Console.WriteLine($"Available Balance : {account.getBalance()}");
                        break;
                        case 2:
                            Console.WriteLine("Enter Amount To be Deposited : ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Availabe Balance : {account.depositMoney(depositAmount)}");
                        break;
                        case 3:
                            Console.WriteLine("Enter Amount To Be Withdrawn : ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            account.withdrawMoney(withdrawAmount);
                        break;
                        default:
                        break;
                    }
                }

            Console.WriteLine("----------------------------- TASK 2 -----------------------------");
            Console.WriteLine("EMPLOYEE MANAGEMENT");
            Employee employee = new Employee();
            Console.Write("Enter Employee Name :");
            employee.setName(Console.ReadLine());
            Console.Write("Enter Employee Designation :");
            employee.setDesignation(Console.ReadLine());
            Console.Write("Enter Employee Id :");
            employee.setId(int.Parse(Console.ReadLine()));
            while (true)
            {
                Console.WriteLine("Enter 1 to update salary ");
                Console.WriteLine("Enter 2 to fetch employee details ");
                Console.WriteLine("Enter 3 to exit ");
                int num = int.Parse(Console.ReadLine());
                if (num == 3)
                {
                    break;
                }
                switch (num)
                {
                    case 1:
                        Console.Write("Enter Salary : ");
                        double amount = double.Parse(Console.ReadLine());
                        employee.updateSalary(amount);
                        break;
                    case 2:
                        Console.WriteLine($"Name : {employee.getName()}");
                        Console.WriteLine($"Designation : {employee.getDesignation()}");
                        Console.WriteLine($"Id : {employee.getId()}");
                        Console.WriteLine($"Salary : {employee.getSalary()}");
                        break;
                    default :
                        break;
                }
            }

        }
    }
}
