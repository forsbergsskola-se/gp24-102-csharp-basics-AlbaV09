// Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.
Random random = new Random();
string[] items = ["stone", "crystal", "seed", "water", "feather"];
int randomItemIndex = random.Next(0, items.Length);
Console.WriteLine(items[randomItemIndex]);