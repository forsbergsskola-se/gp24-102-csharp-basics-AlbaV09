Console.WriteLine("Give me an integer number");
string? first = Console.ReadLine();
Console.WriteLine("Give me another integer number");
string? second = Console.ReadLine();
float firstNumber = float.Parse(first);
float secondNumber = float.Parse(second);
float division = firstNumber / secondNumber;
Console.WriteLine($"The result of {firstNumber} divided with {secondNumber} is {division}");