Console.WriteLine("Give me an integer number");
string? first = Console.ReadLine();
Console.WriteLine("Give me another integer number");
string? second = Console.ReadLine();
int firstNumber = int.Parse(first);
int secondNumber = int.Parse(second);
int product = firstNumber * secondNumber;
Console.WriteLine($"The result of multiply {firstNumber} and {secondNumber} is {product}");