/*
    Create a Console Project named P8Conversion How To? ok
    Ask the user for a Number and assign the result to a variable.
    Convert the variable to Type float.
    Print the float to the Console.
    Convert the double number to type int.
    Print the int to the console.
    Convert the original string to type int.
    What happens? (Hint: You will see an Invalid Format Exception
 */

using System.Globalization;

Console.WriteLine("Give me a number");
string? number = Console.ReadLine();
float numberFloat = float.Parse(number);
Console.WriteLine(numberFloat);
int numberWhole = (int) numberFloat;
Console.WriteLine(numberWhole);
int numberIntWhole = int.Parse(number, CultureInfo.InvariantCulture);
Console.WriteLine(numberIntWhole);