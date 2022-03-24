using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1Library
{
    public static class DateExtension
    {
        public static void FutureDate(this DateTime dateTime)
        {
            Console.WriteLine($"День {dateTime.Day} месяца {dateTime.Month} года {dateTime.Year+5501} от сотворения мира.");
        }
    }
}
