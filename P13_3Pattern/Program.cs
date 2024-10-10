Console.WriteLine("Give me a number for a repetition of a pattern");

int number = Convert.ToInt32(Console.ReadLine());

Pattern:
if (number > 0)
{
    if (number % 2 == 0)
    { 
        Console.WriteLine("#-#-#-#-#-");
    }
    else
    {
        Console.WriteLine("-#-#-#-#-#");
    }
    number--;
    goto Pattern;
}