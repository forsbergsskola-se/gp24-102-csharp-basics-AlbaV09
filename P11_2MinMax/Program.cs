/* Create a program that asks the user to input three numbers and then displays the minimum and maximum of those numbers.
 \Do not use Math.Min or Math.Max (also not MathF.Min or MathF.Max). 
 You can solve this problem using if...else expressions.

    Input: 12, -7, 100
    Output: -7, 100
 */
Console.WriteLine("Give me a number");
string? first = Console.ReadLine();
Console.WriteLine("Give me a number");
string? second = Console.ReadLine();
Console.WriteLine("Give me a number");
string? third = Console.ReadLine();
int firstNumber = Convert.ToInt32(first);
int secondNumber = Convert.ToInt32(second);
int thirdNumber = Convert.ToInt32(third);
if (firstNumber < secondNumber && firstNumber < thirdNumber)
{
    Console.WriteLine(firstNumber);
    
} if (secondNumber < firstNumber && secondNumber < thirdNumber)
{
    Console.WriteLine(secondNumber);
    
} if (thirdNumber < firstNumber && thirdNumber < secondNumber)
{
    Console.WriteLine(thirdNumber);
    
} if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine(firstNumber);
    
} if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine(secondNumber);
    
} if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine(thirdNumber);
}


