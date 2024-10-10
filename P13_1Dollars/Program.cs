/*
Write a Program that asks how many Dollars the user wants. 
Then, the program proceeds to printing that many Dollar Symbols.
    Input: 7
    Output: "Here's your Dollars: $$$$$$$"
*/
Console.WriteLine("How many dollars do you want?");
int dollars = Convert.ToInt32(Console.ReadLine());
int cont = 0;

PrintDollar:
Console.Write("$");
cont ++;
if (cont < dollars)
{
    goto PrintDollar;
}

