using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLINQExample
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------------- Employee Salary Processing --------------------");
            var employees = new List<(string Name, string Department, int Salary)>
        {
            ("Amit", "HR", 60000), ("Ravi", "IT", 50000), ("Priya", "Finance", 70000)
        };
            var highEarners = employees.Where(e => e.Salary > 50000).OrderByDescending(e => e.Salary);
            foreach (var e in highEarners)
                Console.WriteLine($"{e.Name}: {e.Salary}");

            Console.WriteLine("-------------------- Finding Most Ordered Products --------------------");
            var orders = new List<(string ProductName, int QuantityOrdered)>
        {
            ("Laptop", 10), ("Phone", 25), ("Tablet", 5), ("Monitor", 15)
        };
            var topProducts = orders.OrderByDescending(o => o.QuantityOrdered).Take(3);
            foreach (var p in topProducts)
                Console.WriteLine($"{p.ProductName}: {p.QuantityOrdered}");

            Console.WriteLine("-------------------- Filtering Students with High Marks --------------------");
            var students = new List<(string Name, int Marks)>
        {
            ("Ananya", 80), ("Raj", 90), ("Tarun", 70), ("Sita", 85)
        };
            var topStudents = students.Where(s => s.Marks > 75).OrderByDescending(s => s.Marks).Take(5);
            foreach (var s in topStudents)
                Console.WriteLine($"{s.Name}: {s.Marks}");

            Console.WriteLine("-------------------- Grouping Customers by City --------------------");
            var customers = new List<(string CustomerName, string City)>
        {
            ("Deepak", "Mumbai"), ("Meera", "Delhi"), ("Rahul", "Mumbai"), ("Sonia", "Delhi")
        };
            var groupedCustomers = customers.GroupBy(c => c.City).Select(g => new { City = g.Key, Count = g.Count() });
            foreach (var g in groupedCustomers)
                Console.WriteLine($"{g.City}: {g.Count}");

            Console.WriteLine("-------------------- Removing Duplicate Entries in a List --------------------");
            var activities = new List<string> { "Login", "Upload", "Login", "Download" };
            var uniqueActivities = activities.Distinct();
            foreach (var a in uniqueActivities)
                Console.WriteLine(a);

            Console.WriteLine("-------------------- Counting Word Frequency in a Text --------------------");
            var text = "Hello world, hello everyone.".Split(' ');
            var wordCounts = text.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
            foreach (var kv in wordCounts.OrderByDescending(k => k.Value))
                Console.WriteLine($"{kv.Key}: {kv.Value}");

            Console.WriteLine("-------------------- Finding Employees by Department --------------------");
            var employeeDept = new Dictionary<string, string>
        {
            {"Amit", "HR"}, {"Ravi", "IT"}, {"Abdul","IT" },{"Priya", "Finance"}
        };
            string targetDept = "IT";
            var deptEmployees = employeeDept.Where(e => e.Value == targetDept).OrderBy(e => e.Key);
            foreach (var e in deptEmployees)
                Console.WriteLine(e.Key);

            Console.WriteLine("-------------------- Finding the Most Expensive Product --------------------");
            var products = new Dictionary<string, int> { { "Laptop", 1000 }, { "Phone", 500 } };
            var expensiveProduct = products.OrderByDescending(p => p.Value).First();
            Console.WriteLine($"{expensiveProduct.Key}: ${expensiveProduct.Value}");

            Console.WriteLine("-------------------- Grouping Students by Grades --------------------");
            var studentGrades = new Dictionary<string, char> { { "Ananya", 'A' }, { "Raj", 'B' } };
            var groupedGrades = studentGrades.GroupBy(s => s.Value);
            foreach (var g in groupedGrades)
            {
                Console.WriteLine($"Grade {g.Key}: {string.Join(", ", g.Select(s => s.Key))}");
            }

            Console.WriteLine("-------------------- Removing Duplicates from Hashtable --------------------");
            var ipLog = new Hashtable
        {
            { "192.168.1.1", "10:00" },
            { "192.168.1.2", "10:05" },
            { "192.168.1.3", "10:10" }
        };
            var uniqueIPs = ipLog.Keys.Cast<string>().Distinct();
            foreach (var ip in uniqueIPs)
                Console.WriteLine(ip);
        }
    }


}
