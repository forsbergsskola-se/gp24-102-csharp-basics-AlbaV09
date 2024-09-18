Console.WriteLine("I will calculate for you the hypotenuse of a right triangle. Give me the length of one side");
string? first = Console.ReadLine();
Console.WriteLine("Give me the other");
string? second = Console.ReadLine();
float firstNumber = float.Parse(first);
float secondNumber = float.Parse(second);
float hypo = (firstNumber * firstNumber) + (secondNumber * secondNumber);
Console.WriteLine($"Your hypotenuse is {Math.Round(Math.Sqrt(hypo))}");

