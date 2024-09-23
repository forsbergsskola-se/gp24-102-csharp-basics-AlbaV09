/*
 * Write a program that checks if a given integer is even or odd and displays an appropriate message.

    Input: 12
    Output: "That's even."
 */

Console.WriteLine("give me a number");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}