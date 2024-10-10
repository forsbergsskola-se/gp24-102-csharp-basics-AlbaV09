Console.WriteLine("Give me a number of seconds");
string? seconds = Console.ReadLine();
int secondsNumber = int.Parse(seconds);
int minutes = secondsNumber / 60;
int remainSec = secondsNumber % 60;
Console.WriteLine($"{minutes} minute(s) and {remainSec} second(s)");