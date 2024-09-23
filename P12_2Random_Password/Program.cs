// Design a program that generates a random password with 6 characters, digits or symbols.

string chars = "!@#£¤$%&/{([)=?0123456789absdefghijklmnopqrstuvwxyz";
Random random = new Random();

string password = String.Empty;

for (int i = 0; i < 6; i++)
{
    password += chars[random.Next(chars.Length)];
}

Console.WriteLine($"Your new password is {password}");
