using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsExample
{

    // Problem 1: Temperature Monitor
    class TemperatureSensor
    {
        public delegate void TemperatureExceededHandler(int temp);
        public event TemperatureExceededHandler TemperatureExceeded;

        public void CheckTemperature(int temp)
        {
            if (temp > 40)
            {
                TemperatureExceeded?.Invoke(temp);
            }
        }
    }

    // Problem 2: Simple Calculator with Delegates
    class Calculator
    {
        public delegate int CalculatorOperation(int a, int b);

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero");
    }

    // Problem 3: Event Notification System
    class BankAccount
    {
        public delegate void BalanceExceededHandler(int amount);
        public event BalanceExceededHandler OnBalanceExceeded;

        public int Balance { get; private set; }

        public BankAccount(int initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                OnBalanceExceeded?.Invoke(amount);
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {Balance}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Problem 1: Temperature Monitor
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += temp => Console.WriteLine($"Warning: Temperature exceeded! Current temperature: {temp}°C");
            sensor.CheckTemperature(42);

            // Problem 2: Simple Calculator with Delegates
            Calculator.CalculatorOperation operation;
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    operation = Calculator.Add;
                    break;
                case '-':
                    operation = Calculator.Subtract;
                    break;
                case '*':
                    operation = Calculator.Multiply;
                    break;
                case '/':
                    operation = Calculator.Divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;  // Exit the method if the operation is invalid
            }

            Console.WriteLine($"Result: {operation(num1, num2)}");


            // Problem 3: Event Notification System
            BankAccount account = new BankAccount(100);
            account.OnBalanceExceeded += amount => Console.WriteLine($"Error: Insufficient funds for withdrawal of {amount}.");

            account.Withdraw(50);
            account.Withdraw(200);
        }
    }

}
