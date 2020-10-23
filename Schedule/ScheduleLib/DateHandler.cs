using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleLib
{
    public static class DateHandler
    {
        public static string GetTodayDate()
        {
            return GetDateInFormat(DateTime.Now);
        }

        public static string GetDateInFormatFromToday(int daysFromToday)
        {
            DateTime d = DateTime.Now;
            return GetDateInFormat(d.AddDays(daysFromToday));
        }

        public static DateTime GetDateFromToday(int daysFromToday)
        {
            DateTime d = DateTime.Now;
            return d.AddDays(daysFromToday);
        }


        public static string GetDateInFormat(DateTime date)
        {
            return date.ToString("MMM dd");
        }
    }
}
