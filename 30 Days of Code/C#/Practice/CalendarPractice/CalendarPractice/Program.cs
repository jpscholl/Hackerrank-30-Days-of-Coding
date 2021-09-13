/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Hackerrank 30 days of coding Day 14 tutorial video
//  Description: Day 14 tutorial video
*/
using System;
using System.Data;
using System.Globalization;

namespace CalendarPractice
{
    class Program
    {
        public static void DisplayValues(Calendar myCal, DateTime myDT)
        {
            Console.WriteLine("   Era:          {0}", myCal.GetEra(myDT));
            Console.WriteLine("   Year:         {0}", myCal.GetYear(myDT));
            Console.WriteLine("   Month:        {0}", myCal.GetMonth(myDT));
            Console.WriteLine("   DayOfYear:    {0}", myCal.GetDayOfYear(myDT));
            Console.WriteLine("   DayOfMonth:   {0}", myCal.GetDayOfMonth(myDT));
            Console.WriteLine("   DayOfWeek:    {0}", myCal.GetDayOfWeek(myDT));
            Console.WriteLine("   Hour:         {0}", myCal.GetHour(myDT));
            Console.WriteLine("   Minute:       {0}", myCal.GetMinute(myDT));
            Console.WriteLine("   Second:       {0}", myCal.GetSecond(myDT));
            Console.WriteLine("   Milliseconds: {0}", myCal.GetMilliseconds(myDT));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DateTime myDT = new DateTime(1988, 5, 2, new GregorianCalendar());

            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            DisplayValues(myCal, myDT);

            myDT = myCal.AddYears(myDT, 5);
            myDT = myCal.AddMonths(myDT, 5);
            myDT = myCal.AddWeeks(myDT, 5);
            myDT = myCal.AddDays(myDT, 5);
            myDT = myCal.AddHours(myDT, 5);
            myDT = myCal.AddMinutes(myDT, 5);
            myDT = myCal.AddSeconds(myDT, 5);
            myDT = myCal.AddMilliseconds(myDT, 5);

            // Displays the values of the DateTime.
            Console.WriteLine("After adding 5 to each component of the DateTime:");
            DisplayValues(myCal, myDT);

            DateTime thisDate1 = DateTime.Now;
            Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
                                                          TimeSpan.Zero);
            Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
                               thisDate2);
        }
    }
}
