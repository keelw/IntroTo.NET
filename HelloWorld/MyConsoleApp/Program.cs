// See https://aka.ms/new-console-template for more information

DateTime today = DateTime.Today;
DateTime christmas = new DateTime(today.Year, 12, 25);

TimeSpan difference = christmas - today;
int daysToChristmas = difference.Days;

Console.WriteLine($"Hello, World! \nThe current time is {DateTime.Now}");
Console.WriteLine($"There are {daysToChristmas} days until next Christmas.");