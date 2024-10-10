Console.WriteLine("What's your age");
string? age = Console.ReadLine();
int ageNumber = int.Parse(age);
bool isChild = ageNumber <= 12;
bool isTeenager = ageNumber >12 && ageNumber < 19;
bool isAdult = ageNumber >= 19;
Console.WriteLine($"You are a child: {isChild}");
Console.WriteLine($"You are a teenager: {isTeenager}");
Console.WriteLine($"You are an adult: {isAdult}");


