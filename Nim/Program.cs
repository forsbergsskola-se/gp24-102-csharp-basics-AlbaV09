Console.WriteLine("Welcome to Nim!\nLet's play: we take turns drawing matches, and the one who draws the last one is the loser.");
int matches = 24;
string draw = "||||||||||||||||||||||||";
Console.WriteLine($"{draw} ({matches})");
Console.WriteLine("How many matches do you want to draw?");

Play:
// User turn
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput == 1 || userInput == 2 || userInput == 3){
 matches = matches - userInput;
 Console.WriteLine($"The number of matches is: {new string('|', matches)} ({matches})");
 if (matches <= 0 )
 {
    Console.WriteLine("You lose!");
    goto Over;
 }

// AI turn
 int aiChoice = Random.Shared.Next(1,4);
 if (aiChoice > matches) aiChoice = matches;
 Console.WriteLine($"The AI draws {aiChoice} matches");
 matches = matches - aiChoice;
 Console.WriteLine($"The number of matches is: {new string('|', matches)} ({matches})");
 if (matches <= 0 ){
    Console.WriteLine("The AI loses!");
    goto Over;
 }
 // Switch turn
 Console.WriteLine("Your turn");
 goto Play; 
}
else // Rules
{
    Console.WriteLine("Error, just 1, 2 or 3, try again.");
    goto Play;
}
Over:
Console.WriteLine("Game Over!");



