using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeGym
{
    public class CodeGymExer_DateShow
    {
        public static void Main(string[] args)
        {

            DateTime timeShowNow = DateTime.Now;

            Console.WriteLine("Now: {0} ", DateTime.Now);
            Console.WriteLine("Today: {0} ", DateTime.Today);
            Console.WriteLine("UtcNow: {0} ", DateTime.UtcNow);
            DateTime timeShow;
            timeShow = new DateTime(1987, 06, 19, 12, 1, 10);
            Console.WriteLine("TimeShow My Birthday: {0} ", timeShow);

            Console.WriteLine("---------------");

            Console.WriteLine("Date: {0} - {1} ", timeShowNow.Date, timeShow.Date);
            Console.WriteLine("Day: {0} - {1} ", timeShowNow.Day, timeShow.Day);
            Console.WriteLine("DayOfWeek: {0} - {1} ", timeShowNow.DayOfWeek, timeShow.DayOfWeek);
            Console.WriteLine("DayOfYear: {0} - {1} ", timeShowNow.DayOfYear, timeShow.DayOfYear);
            Console.WriteLine("Hour: {0} - {1} ", timeShowNow.Hour, timeShow.Hour);
            Console.WriteLine("Kind: {0} - {1} ", timeShowNow.Kind, timeShow.Kind);
            Console.WriteLine("Millisecond: {0} - {1} ", timeShowNow.Millisecond, timeShow.Millisecond);
            Console.WriteLine("Minute: {0} - {1} ", timeShowNow.Minute, timeShow.Minute);
            Console.WriteLine("Month: {0} - {1} ", timeShowNow.Month, timeShow.Month);
            Console.WriteLine("Second: {0} - {1} ", timeShowNow.Second, timeShow.Second);
            Console.WriteLine("Ticks: {0} - {1} ", timeShowNow.Ticks, timeShow.Ticks);
            Console.WriteLine("TimeOfDay: {0} - {1} ", timeShowNow.TimeOfDay, timeShow.TimeOfDay);
            Console.WriteLine("Year: {0} - {1} ", timeShowNow.Year, timeShow.Year);
            Console.WriteLine("ToLongDateString: {0} - {1} ", timeShowNow.ToLongDateString(), timeShow.ToLongDateString());
            Console.WriteLine("ToLongTimeString: {0} - {1} ", timeShowNow.ToLongTimeString(), timeShow.ToLongTimeString());
            Console.WriteLine("ToShortDateString: {0} - {1} ", timeShowNow.ToShortDateString(), timeShow.ToShortDateString());
            Console.WriteLine("ToShortTimeString: {0} - {1} ", timeShowNow.ToShortTimeString(), timeShow.ToShortTimeString());
            Console.WriteLine("ToUniversalTime: {0} - {1} ", timeShowNow.ToUniversalTime(), timeShow.ToUniversalTime());


        }
    }
}

