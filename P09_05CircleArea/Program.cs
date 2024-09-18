Console.WriteLine("Give me the radius of a circle");
string? radius = Console.ReadLine();
float radiusFloat = float.Parse(radius);
double area = Math.PI * (radiusFloat*radiusFloat);
Console.WriteLine($"The area of your circle is {area}");