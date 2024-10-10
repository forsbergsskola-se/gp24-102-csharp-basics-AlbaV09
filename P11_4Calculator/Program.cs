/*
Develop a simple calculator program that allows operations such as addition, subtraction, multiplication, and division. Allow the user to choose which operation to perform.

    Input: 3, +, 7
    Output: 10
 */
Console.WriteLine("Give me two numbers!");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Tell me what you want: addition, subtraction, multiplication or division");
string operation = Console.ReadLine();
if (operation == "addition")
{
    Console.WriteLine(firstNumber + secondNumber);
}
if (operation == "subtraction")
{
    Console.WriteLine(firstNumber - secondNumber);
}

if (operation == "multiplication")
{
    Console.WriteLine(firstNumber * secondNumber);
}

if (operation == "division")
{
    Console.WriteLine(firstNumber / secondNumber);
}