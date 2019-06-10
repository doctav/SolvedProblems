using System;
using System.Globalization;

namespace DateTimeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems solved for: https://github.com/irinascurtu/siit-net/blob/master/DateTime.md");
            //1. Write a program to display the:
            //a) Current date and time
            //b) Current year
            //c) Month of year
            //d) Week number of the year
            //e) Weekday of the week
            //f) Day of year
            //g) Day of the month
            //h) Day of week
            //j) if the current year is a leap year or not
            DateInfo();

            //2. Write a program to add N year(s) to the current date and display the new date.
            AddNYears(10);

            //3. Write a program to display the date and time in a human-friendly string.
            HumanFriendlyDate();

            //4. Write a program to add 5 seconds to the current time and print it to the console.
            Add5Seconds();

            //5. Write a program to get current time in milliseconds.
            GetCurrentTimeInMilliseconds();

            //6. Write a program that calculates the date six months from the current date.
            SixMonthsFromCurrentDate();

            ////7. Write a program to get the first and last second of a day.
            DateTime today = DateTime.Now;
            FirstAndLastSecondOfDay(today);

            //8. Write a program to calculate two date difference in seconds.
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2019, 12, 30);
            DifferenceInSeconds(date1, date2);

            //9. Given a date of birth, calculate the age of a person.
            //Input: 10, 09, 1989 
            //Output: 29
            CalculateAge();
        }

        //1. Write a program to display the:
        //a) Current date and time
        //b) Current year
        //c) Month of year
        //d) Week number of the year
        //e) Weekday of the week
        //f) Day of year
        //g) Day of the month
        //h) Day of week
        //j) if the current year is a leap year or not
        public static void DateInfo()
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine($"Current date and time: {currentDate.ToString()}");
            Console.WriteLine($"Current year: {currentDate.Year}");
            Console.WriteLine($"Month of the year: {currentDate.Month}");
            Console.WriteLine("Week number of the year: " + CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
            Console.WriteLine($"Weekday of the week: {currentDate.DayOfWeek}");
            Console.WriteLine($"Day of year: {currentDate.DayOfYear}");
            Console.WriteLine($"Day of month: {currentDate.Day}");
            Console.WriteLine($"Day of week: {currentDate.DayOfWeek}");

            if (currentDate.Year % 4 == 0)
            {
                Console.WriteLine($"The year is a leap year.");
            }
            else
            {
                Console.WriteLine($"The year is NOT a leap year.");
            }
        }

        //2. Write a program to add N year(s) to the current date and display the new date.
        public static void AddNYears(int N)
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            DateTime nextDate;
            nextDate = currentDate.AddYears(N);
            Console.WriteLine($"The {currentDate} after {N} years will be {nextDate}");
        }

        //3. Write a program to display the date and time in a human-friendly string.
        public static void HumanFriendlyDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.Day}/{currentDate.Month}/{currentDate.Year} and the time is {currentDate.Hour}:{currentDate.Minute}");
        }

        //4. Write a program to add 5 seconds to the current time and print it to the console.
        public static void Add5Seconds()
        {
            DateTime currentDate = DateTime.Now;
            DateTime nextTime = currentDate.AddSeconds(5);
            Console.WriteLine($"Current time is {currentDate.TimeOfDay} and after 5 seconds it will be {nextTime.TimeOfDay}");
        }

        //5. Write a program to get current time in milliseconds.
        public static void GetCurrentTimeInMilliseconds()
        {
            DateTime currentDate = DateTime.Now;
            decimal totalMilliseconds = currentDate.TimeOfDay.Milliseconds + 1000 * currentDate.TimeOfDay.Seconds + 1000 * 60 * currentDate.TimeOfDay.Minutes + 1000 * 60 * 60 * currentDate.TimeOfDay.Hours;
            Console.WriteLine($"Current date in milliseconds: {totalMilliseconds}");
        }

        //6. Write a program that calculates the date six months from the current date.
        public static void SixMonthsFromCurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            DateTime nexttDate = currentDate.AddMonths(6);
            Console.WriteLine($"{currentDate} after six months: {nexttDate}");
        }

        //7. Write a program to get the first and last second of a day.
        public static void FirstAndLastSecondOfDay(DateTime day)
        {
            DateTime beginingOfTheDay = new DateTime(day.Year, day.Month, day.Day);
            DateTime endOfTheDay = beginingOfTheDay.AddHours(24);
            TimeSpan intervalOneMillisecond = TimeSpan.FromMilliseconds(1);
            endOfTheDay = endOfTheDay - intervalOneMillisecond;
            Console.WriteLine($"Beginning of the day: {beginingOfTheDay}. End of the day: {endOfTheDay}");
        }

        //8. Write a program to calculate two date difference in seconds.
        public static void DifferenceInSeconds(DateTime date1, DateTime date2)
        {
            TimeSpan diferenta = date2 - date1;
            Console.WriteLine($"The difference (seconds) between {date2} and {date1} is: {diferenta.TotalSeconds}");
        }

        //9. Given a date of birth, calculate the age of a person.
        //Input: 10, 09, 1989 
        //Output: 29
        public static void CalculateAge()
        {
            string birth = "10, 09, 1989";
            int day = int.Parse(birth.Substring(0, birth.IndexOf(',')));
            birth = birth.Substring(birth.IndexOf(',') + 1);
            int month = int.Parse(birth.Substring(0,birth.IndexOf(',')));
            birth = birth.Substring(birth.IndexOf(',') + 1);
            int year = int.Parse(birth);
            //build the date in C# format
            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Today;
            //calculate the age
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;
            Console.WriteLine($"Age = {age} years.");
        }
    }
}
