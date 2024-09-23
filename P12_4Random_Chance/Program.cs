// Write a program that has a 10% chance of showing a secret message.
// Otherwise it just displays a message saying to try again.

double chance = 0.1d;
if(Random.Shared.NextDouble() < chance){
    Console.WriteLine("Congratulations! You can read the secret message, you can find it behind the door!");
} else {
    Console.WriteLine("Try again!");
}
