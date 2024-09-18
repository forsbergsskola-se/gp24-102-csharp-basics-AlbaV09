Console.WriteLine("Give me an integer number");
string? first = Console.ReadLine();
Console.WriteLine("Give me an integer number");
string? second = Console.ReadLine();
int firstNumber = int.Parse(first);
int secondNumber = int.Parse(second);
int remainder = firstNumber % secondNumber;
Console.WriteLine($"The remainder of dividing {first} and {second} is {remainder}");
