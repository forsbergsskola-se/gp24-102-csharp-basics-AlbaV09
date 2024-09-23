/*
Develop a program that generates random X and Y coordinates for an enemy in a 2D game world with 100x100 coordinates.
Display these coordinates to the user.
 */
Random random = new Random();
int numberX = random.Next(0, 101);
int numberY = random.Next(0, 101);
Console.WriteLine($"The enemy is at {numberX} X {numberY}");