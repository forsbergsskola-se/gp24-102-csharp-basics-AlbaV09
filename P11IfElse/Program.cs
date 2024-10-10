Console.WriteLine("What's your age");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);
if (ageInt >= 18)
{
    Console.WriteLine("Your are an adult");
} else if (ageInt < 18 && ageInt > 12)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are a child");
}
Console.WriteLine("Now give me a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > ageInt)
{
    Console.WriteLine($"The maximum is: {number}");
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even");
    } else {Console.WriteLine("The number is odd");}
}
else
{
    Console.WriteLine($"The maximum is: {ageInt}");
    if (ageInt % 2 == 0)
    {
        Console.WriteLine("The number is even");
    } else {Console.WriteLine("The number is odd");}
}
