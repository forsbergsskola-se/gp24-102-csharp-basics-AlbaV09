Console.WriteLine("Give me your weight in kg");
string? weight = Console.ReadLine();
Console.WriteLine("Give me your height in meters");
string? height = Console.ReadLine();
float weightKg = float.Parse(weight);
float heightM = float.Parse(height);
float bmi = weightKg / ( heightM*heightM);
Console.WriteLine($"Your BMI value is {bmi}");