Random random = new Random();
int myNumber = random.Next(1, 100);
int cont = 0;
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it! You have just 10 attempts");
Guess:
int guess = int.Parse(Console.ReadLine());

if (cont < 9)
{  cont++;
    if (guess < myNumber)
    {
    Console.WriteLine("Nope! My number is Greater!");
    goto Guess;
    }
    if (guess > myNumber){ 
        Console.WriteLine("Nope! My number is Smaller!");
        goto Guess;   
    }
Console.WriteLine($"That's the number! Well played! You have just needed {cont} attempts.");
}
else
{
    Console.WriteLine("You lose!");
}

