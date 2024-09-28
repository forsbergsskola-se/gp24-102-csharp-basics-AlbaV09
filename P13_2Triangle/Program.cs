/* Write a program that prints an ASCII Triangle as big as the user desires.
 Use goto efficiently to write as little code as necessary.
    Input: 5
#####
####
###
##
#
*/

Console.WriteLine("Give me a number");
int number = Convert.ToInt32(Console.ReadLine());


Triangle:
Console.WriteLine(new string ('#', number--));
if (number > 0)
{
    goto Triangle;
}
