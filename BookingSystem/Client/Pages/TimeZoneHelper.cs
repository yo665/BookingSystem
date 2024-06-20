using System;

namespace BookingSystem.Client.Pages
{
    public static class TimeZoneHelper
    {
        public static DateTime ConvertToIST(DateTime utcDateTime)
        {
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime istDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, istZone);
            return istDateTime;
        }
    }
}
