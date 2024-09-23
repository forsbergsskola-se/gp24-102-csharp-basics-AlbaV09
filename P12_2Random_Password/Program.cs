// Design a program that generates a random password with 6 characters, digits or symbols.

Random random = new Random();
int password = random.Next(0, 10);
int password2 = random.Next(0, 10);
int password3 = random.Next(0, 10);
int password4 = random.Next(0, 10);
int password5 = random.Next(0, 10);
int password6 = random.Next(0, 10);

Console.WriteLine($"Your new password is {password}{password2}{password3}{password4}{password5}{password6}");
