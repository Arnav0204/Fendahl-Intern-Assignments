using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main()
        {
            
            
            Console.WriteLine("------------------------- TASK 1 -------------------------");
            Console.WriteLine("Convert an Integer to a Double");
            int intValue = 42;
            double doubleValue = intValue; 
            Console.WriteLine($"Integer: {intValue}, Double: {doubleValue}");

            
            Console.WriteLine("------------------------- TASK 2 -------------------------");
            Console.WriteLine("Convert a Character to an Integer (ASCII Value)");
            char charValue = 'A';
            int asciiValue = charValue;
            Console.WriteLine($"Character: {charValue}, ASCII Value: {asciiValue}");

            
            Console.WriteLine("------------------------- TASK 3 -------------------------");
            Console.WriteLine("Convert a Double to an Integer");
            double doubleNum = 9.99;
            int intNum = (int)doubleNum; 
            Console.WriteLine($"Double: {doubleNum}, Integer (truncated): {intNum}");

            
            Console.WriteLine("------------------------- TASK 4 -------------------------");
            Console.WriteLine("Truncate a Float Value");
            float floatNum = 8.75f;
            int truncatedInt = (int)floatNum;
            Console.WriteLine($"Float: {floatNum}, Truncated Integer: {truncatedInt}");

            
            Console.WriteLine("------------------------- TASK 5 -------------------------");
            Console.WriteLine("Convert a String to an Integer");
            string strNum = "100";
            int parsedInt = Convert.ToInt32(strNum);
            Console.WriteLine($"String: {strNum}, Converted Integer: {parsedInt}");

      
            Console.WriteLine("------------------------- TASK 6 -------------------------");
            Console.WriteLine("Convert a Boolean to an Integer");
            bool boolValue = true;
            int boolToInt = Convert.ToInt32(boolValue);
            Console.WriteLine($"Boolean: {boolValue}, Integer: {boolToInt}");

       
            Console.WriteLine("------------------------- TASK 7 -------------------------");
            Console.WriteLine(" Convert a String to an Integer using Parse()");
            string strNum2 = "200";
            int parsedInt2 = int.Parse(strNum2);
            Console.WriteLine($"String: {strNum2}, Parsed Integer: {parsedInt2}");

     
            Console.WriteLine("------------------------- TASK 8 -------------------------");
            Console.WriteLine("Handle Non-Numeric String using TryParse()");
            string invalidStr = "ABC";
            bool isSuccess = int.TryParse(invalidStr, out int result);
            Console.WriteLine($"String: {invalidStr}, Conversion Successful: {isSuccess}, Result: {result}");

          
            Console.WriteLine("------------------------- TASK 9 -------------------------");
            Console.WriteLine("User Input Conversion From String To Double");
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            double userDouble = Convert.ToDouble(userInput);
            Console.WriteLine($"Your number * 10: {userDouble * 10}");

            
            Console.WriteLine("------------------------- TASK 10 -------------------------");
            Console.WriteLine("Temperature Converter (Celsius to Fahrenheit)");
            Console.Write("Enter temperature in Celsius: ");
            string tempInput = Console.ReadLine();
            double celsius = Convert.ToDouble(tempInput);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        }
    }
}
