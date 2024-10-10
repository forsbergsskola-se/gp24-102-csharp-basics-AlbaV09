Console.WriteLine("Give me a time in minutes");
string? minutes = Console.ReadLine();
int minutesNumber = int.Parse(minutes);
int seconds = minutesNumber * 60;
Console.WriteLine($"Your are talking about {seconds} seconds");