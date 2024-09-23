Console.WriteLine("Welcome to Nim!");
int matches = 24;
string draw = "||||||||||||||||||||||||";
Console.WriteLine($"{draw} ({matches})");
Console.WriteLine("How many matches do you want to draw?");

Play:
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput == 1 || userInput == 2 || userInput == 3){
matches = matches - userInput;
Console.WriteLine($"The number of matches is {matches}");
int aiChoice = Random.Shared.Next(1,4);
Console.WriteLine($"The AI draws {aiChoice} matches");
matches = matches - aiChoice;
Console.WriteLine($"The number of matches is {matches}");
if (matches > 0)
{
    Console.WriteLine("Your turn");
    goto Play; 
}
}
else
{
    Console.WriteLine("Error, just 1, 2 or 3, try again.");
    goto Play;
}

