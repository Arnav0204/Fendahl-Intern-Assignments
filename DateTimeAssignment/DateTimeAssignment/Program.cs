using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        // ------- Task 1: Formatting DateTime -------
        static void FormatDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(now.ToString("MM/dd/yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
        }

        // ------- Task 2: Adding and Subtracting Time -------
        static void AddSubtractTime()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today's Date: {today:yyyy-MM-dd}");

            DateTime futureDate = today.AddDays(10);
            Console.WriteLine($"Date After 10 Days: {futureDate:yyyy-MM-dd}");

            DateTime pastTime = today.AddHours(-5);
            Console.WriteLine($"Time 5 Hours Ago: {pastTime:HH:mm:ss}");
        }

        // ------- Task 3: Parsing Dates -------
        static void ParseDate()
        {
            string dateString = "14-Feb-2025";
            DateTime parsedDate;

            if (DateTime.TryParse(dateString, out parsedDate))
            {
                Console.WriteLine($"Parsed Date: {parsedDate:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Invalid Date Format!");
            }
        }

        // ------- Task 4: Comparing Dates -------
        static void CompareDates()
        {
            DateTime date1 = new DateTime(2025, 2, 14);
            DateTime date2 = new DateTime(2025, 2, 20);

            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                Console.WriteLine("date1 is earlier than date2");
            else if (result > 0)
                Console.WriteLine("date1 is later than date2");
            else
                Console.WriteLine("date1 and date2 are the same");
        }

        // ------- Task 5: Calculating the Difference Between Two Dates -------
        static void DateDifference()
        {
            DateTime startDate = new DateTime(2025, 1, 1);
            DateTime endDate = new DateTime(2025, 2, 14);

            TimeSpan difference = endDate - startDate;
            Console.WriteLine($"Difference in Days: {difference.Days}");
        }

        // ------- Task 6: Extracting Date and Time Components -------
        static void ExtractDateTimeComponents()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Year: {now.Year}");
            Console.WriteLine($"Month: {now.Month}");
            Console.WriteLine($"Day: {now.Day}");
            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");
            Console.WriteLine($"Second: {now.Second}");
        }

        // ------- Task 7: Time Zones and UTC Conversion -------
        static void TimeZonesAndUTC()
        {
            DateTime localTime = DateTime.Now;
            DateTime utcTime = localTime.ToUniversalTime();

            Console.WriteLine($"Local Time: {localTime}");
            Console.WriteLine($"UTC Time: {utcTime}");
        }

        // ------- Task 8: Checking Leap Year -------
        static void CheckLeapYear(int year)
        {
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year: {isLeap}");
        }

        // ------- Task 9: Display the First and Last Day of the Month -------
        static void FirstAndLastDayOfMonth(DateTime inputDate)
        {
            DateTime firstDay = new DateTime(inputDate.Year, inputDate.Month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            Console.WriteLine($"First Day: {firstDay:yyyy-MM-dd}");
            Console.WriteLine($"Last Day: {lastDay:yyyy-MM-dd}");
        }

        // ------- Task 10: Add a Specific Time Duration -------
        static void AddTimeSpan()
        {
            DateTime now = DateTime.Now;
            TimeSpan duration = new TimeSpan(2, 30, 0);
            DateTime newTime = now.Add(duration);

            Console.WriteLine($"Current Time: {now:HH:mm:ss}");
            Console.WriteLine($"Time After 2 Hours 30 Minutes: {newTime:HH:mm:ss}");
        }

        // ------- Task 11: Countdown Timer -------
        static void CountdownToFutureDate(DateTime futureDate)
        {
            DateTime now = DateTime.Now;
            TimeSpan remaining = futureDate - now;

            Console.WriteLine($"Time Remaining: {remaining.Days} days, {remaining.Hours} hours, {remaining.Minutes} minutes");
        }

        // ------- Main Method to Execute Tasks -------
        static void Main()
        {
            Console.WriteLine("------- Task 1: Formatting DateTime -------");
            FormatDateTime();

            Console.WriteLine("\n------- Task 2: Adding and Subtracting Time -------");
            AddSubtractTime();

            Console.WriteLine("\n------- Task 3: Parsing Dates -------");
            ParseDate();

            Console.WriteLine("\n------- Task 4: Comparing Dates -------");
            CompareDates();

            Console.WriteLine("\n------- Task 5: Date Difference -------");
            DateDifference();

            Console.WriteLine("\n------- Task 6: Extracting Date and Time Components -------");
            ExtractDateTimeComponents();

            Console.WriteLine("\n------- Task 7: Time Zones and UTC Conversion -------");
            TimeZonesAndUTC();

            Console.WriteLine("\n------- Task 8: Checking Leap Year (2024) -------");
            CheckLeapYear(2024);

            Console.WriteLine("\n------- Task 9: First and Last Day of February 2025 -------");
            FirstAndLastDayOfMonth(new DateTime(2025, 2, 1));

            Console.WriteLine("\n------- Task 10: Adding TimeSpan -------");
            AddTimeSpan();

            Console.WriteLine("\n------- Task 11: Countdown Timer to 31-Dec-2025 -------");
            CountdownToFutureDate(new DateTime(2025, 12, 31));
        }
    }
}
