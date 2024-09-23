/*
Ask the user for a Critical Hit Chance between 0.0 (0%) and 1.0 (100%).
Then simulate 5 Attacks where you roll for the Critical Hit Chance and print, whether it’s a Critical Hit. Or No Critical Hit.
 */
Console.WriteLine("Please give me a seed (integer)");
int seed = Convert.ToInt32(Console.ReadLine());
Random random = new Random(seed);

Console.WriteLine("Three integers between 0 and 5");
int number1 = random.Next(0, 5);
int number2 = random.Next(0, 5);
int number3 = random.Next(0, 5);
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

Console.WriteLine("Three numbers between 0.0 and 0.5");
double numd1 = random.NextDouble()*0.5;
double numd2 = random.NextDouble()*0.5;
double numd3 = random.NextDouble()*0.5;
Console.WriteLine(numd1);
Console.WriteLine(numd2);
Console.WriteLine(numd3);

Console.WriteLine("Three numbers between 0.2 and 0.7");
double numdouble1 = random.NextDouble()*(0.7-0.2)+0.2;
double numdouble2 = random.NextDouble()*(0.7-0.2)+0.2;
double numdouble3 = random.NextDouble()*(0.7-0.2)+0.2;
Console.WriteLine(numdouble1);
Console.WriteLine(numdouble2);
Console.WriteLine(numdouble3);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = double.Parse(Console.ReadLine());

if(random.NextDouble() < critChance){
 Console.WriteLine("Crit");
} else {
 Console.WriteLine("No Crit");
}
if(random.NextDouble() < critChance){
 Console.WriteLine("Crit");
} else {
 Console.WriteLine("No Crit");
}
if(random.NextDouble() < critChance){
 Console.WriteLine("Crit");
} else {
 Console.WriteLine("No Crit");
}
if(random.NextDouble() < critChance){
 Console.WriteLine("Crit");
} else {
 Console.WriteLine("No Crit");
}
if(random.NextDouble() < critChance){
 Console.WriteLine("Crit");
} else {
 Console.WriteLine("No Crit");
}
