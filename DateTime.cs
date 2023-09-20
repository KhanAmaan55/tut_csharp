using System;
namespace Hello
{
	public class DateTimeCon
	{
        public static void DateTimeConversion()
        {
            // DateTime convertsion
            string dateStr = "2023-09-14 14:30:00";
            DateTime dateTimeValue = Convert.ToDateTime(dateStr);

            string dateStr2 = "2023-09-14";
            DateTime dateValue = Convert.ToDateTime(dateStr2);

            long ticks = 1631623800000000; // Example number of ticks
            /*The DateTime constructor interprets this value as the number of 100-nanosecond intervals (ticks) that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar.*/
            DateTime dateTimeValue2 = Convert.ToDateTime(new DateTime(ticks));

            DateTime date = new DateTime(2000, 10, 12);
            long totalTicks = date.Ticks;
            Console.WriteLine($"yyyy-mm-dd hh:mm:ss format string converted in datetime  - {dateTimeValue}");
            Console.WriteLine($"yyyy-mm-dd format string converted in datetime  - {dateValue}");
            Console.WriteLine($"Number of ticks converted in datetime  - {dateTimeValue2}");
            Console.WriteLine($"date {date} converted to ticks  - {totalTicks}");
        }
    }
}

