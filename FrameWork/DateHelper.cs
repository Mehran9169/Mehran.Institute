using System;
using System.Globalization;


namespace FrameWork
{
    public static class DateHelper
    {
        public static string GetPersianDate(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}/{pc.GetMonth(t).ToString()}/{pc.GetDayOfMonth(t).ToString()}";
        }
        public static string GetPersianDateTimeForFileName(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}_{pc.GetMonth(t).ToString()}_{pc.GetDayOfMonth(t).ToString()}_{pc.GetHour(t).ToString()}_{pc.GetMinute(t).ToString()}_{pc.GetSecond(t).ToString()}_{pc.GetMilliseconds(t).ToString()} ";
        }

        public static DateTime ToGeorgianDateTime(this string persianDate)
        {

                int year = Convert.ToInt32(persianDate.Substring(0, 4));
                int month = Convert.ToInt32(persianDate.Substring(5, 2));
                int day = Convert.ToInt32(persianDate.Substring(8, 2));
                var georgianDateTime = new DateTime(year, month, day, new PersianCalendar());
                return georgianDateTime;
        }
        public static DateTime? ToGeorgianDateTimeNullable(this string persianDate)
        {
            if (persianDate is null || persianDate == string.Empty)
            {
                return null;
            }
            else
            {
                int year = Convert.ToInt32(persianDate.Substring(0, 4));
                int month = Convert.ToInt32(persianDate.Substring(5, 2));
                int day = Convert.ToInt32(persianDate.Substring(8, 2));
                var georgianDateTime = new DateTime(year, month, day, new PersianCalendar());
                return georgianDateTime;
            }

        }
    }
}
