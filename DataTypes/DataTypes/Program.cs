using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {
            // Task 1
            Console.WriteLine("--------------------- TASK 1 -----------------------");
            Console.WriteLine("Declare and initialize variables using variuos data types & Print their values to the console.");
            int intVar = 10;
            float floatVar = 10.5f;
            double doubleVar = 20.99;
            decimal decimalVar = 30.99m;
            string stringVar = "Hello, World!";
            bool boolVar = true;

            Console.WriteLine($"Int: {intVar}\n, Float: {floatVar}\n, Double: {doubleVar}\n, Decimal: {decimalVar}\n, String: {stringVar}\n, Bool: {boolVar}\n");

            // Task 2
            Console.WriteLine("--------------------- TASK 2 -----------------------");
            Console.WriteLine("Print minimum, maximum and default values for various datatypes.");
            Console.WriteLine($"Int: Min = {int.MinValue}, Max = {int.MaxValue}, Default = {default(int)}");
            Console.WriteLine($"Float: Min = {float.MinValue}, Max = {float.MaxValue}, Default = {default(float)}");
            Console.WriteLine($"Double: Min = {double.MinValue}, Max = {double.MaxValue}, Default = {default(double)}");
            Console.WriteLine($"Decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}, Default = {default(decimal)}");
            Console.WriteLine($"String: Default = {(default(string) == null ? "null" : default(string))}");
            Console.WriteLine($"Bool: Default = {default(bool)}\n");

            // Task 3
            Console.WriteLine("--------------------- TASK 3 -----------------------");
            Console.WriteLine("Difference between default values if the datatypes are made nullable.");
            int? nullableInt = null;
            float? nullableFloat = null;
            double? nullableDouble = null;
            decimal? nullableDecimal = null;
            //string? nullableString = null;
            bool? nullableBool = null;

            Console.WriteLine("Task 3: Nullable Default Values");
            Console.WriteLine($"Nullable Int: {nullableInt}");
            Console.WriteLine($"Nullable Float: {nullableFloat}");
            Console.WriteLine($"Nullable Double: {nullableDouble}");
            Console.WriteLine($"Nullable Decimal: {nullableDecimal}");
            //Console.WriteLine($"Nullable String: {nullableString}");
            Console.WriteLine($"Nullable Bool: {nullableBool}\n");

            // Task 4
            Console.WriteLine("--------------------- TASK 4 -----------------------");
            Console.WriteLine("Write a program using enum to print the day of week in text, if input is provided as a number.");
            if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine($"{(DaysOfWeek)dayNumber}!");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }
        }
    }
}
