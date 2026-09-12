Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime christmas = new DateTime(day: 25, month: 12, year: DateTime.Now.Year);
if (DateTime.Now < christmas)
{
  Console.WriteLine($"There are {(christmas - DateTime.Today).TotalDays} days until the next christmas");
}