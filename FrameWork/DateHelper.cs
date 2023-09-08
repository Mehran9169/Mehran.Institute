using System;
using System.Globalization;

namespace FrameWork
{
    public class DateHelper
    {
        public string GetPersianDate(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}/{pc.GetMonth(t).ToString()}/{pc.GetDayOfMonth(t).ToString()}";
        }
        public static string GetPersianDateTimeForFileName(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}_{pc.GetMonth(t).ToString()}_{pc.GetDayOfMonth(t).ToString()}_{pc.GetHour(t).ToString()}_{pc.GetMinute(t).ToString()}_{pc.GetSecond(t).ToString()}_{pc.GetMilliseconds(t).ToString()} ";
        }
    }
}
