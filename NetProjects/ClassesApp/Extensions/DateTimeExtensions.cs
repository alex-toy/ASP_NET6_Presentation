namespace ClassesApp.Extensions;

public static class DateTimeExtensions
{
    public static DateTime LastDayOfWeek(this DateTime today, DayOfWeek dayOfWeek)
    {
        DateTime lastDayOfWeek = today;

        while (lastDayOfWeek.DayOfWeek != dayOfWeek) lastDayOfWeek = lastDayOfWeek.AddDays(-1);

        return lastDayOfWeek;
    }

    public static DateTime NextDayOfWeek(this DateTime today, DayOfWeek dayOfWeek)
    {
        DateTime lastDayOfWeek = today;

        while (lastDayOfWeek.DayOfWeek != dayOfWeek) lastDayOfWeek = lastDayOfWeek.AddDays(1);

        return lastDayOfWeek;
    }

    public static int GetWorkingDaysCount(this DateTime day1, DateTime day2)
    {
        int result = 0;
        DateTime start = day1 > day2 ? day2 : day1;
        DateTime end = day1 < day2 ? day2 : day1;

        do
        {
            if (start.IsWorkingDay()) result += 1;
            start = start.AddDays(1);
        } while (start != end);

        return result;
    }

    public static bool IsWorkingDay(this DateTime day)
    {
        return day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday;
    }
}
