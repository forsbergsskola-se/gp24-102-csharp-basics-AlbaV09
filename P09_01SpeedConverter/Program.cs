Console.WriteLine("Give me your velocity in km/h");
string? kmh = Console.ReadLine();
float kmhNumber = float.Parse(kmh);
float msconverter = 5f / 18f;
float ms = kmhNumber * msconverter;
int msfinal = Convert.ToInt32(ms);
Console.WriteLine($"Your velocity is {kmhNumber} km/h what is the same as {msfinal} m/s");