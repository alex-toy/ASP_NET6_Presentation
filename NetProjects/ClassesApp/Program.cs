using ClassesApp.Extensions;

//Demo.DemoEleve();

DateTime today = DateTime.Today;

DateTime lastDayOfWeek = today.LastDayOfWeek(DayOfWeek.Tuesday);
DateTime nextDayOfWeek = today.NextDayOfWeek(DayOfWeek.Monday);

int daysCount = today.GetWorkingDaysCount(today.AddDays(10));


Console.WriteLine(lastDayOfWeek);
Console.WriteLine(nextDayOfWeek);
Console.WriteLine(daysCount);






