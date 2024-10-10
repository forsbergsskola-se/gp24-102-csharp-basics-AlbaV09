/*
Develop a program that asks the user to enter a single character and then determines whether it's a digit, a vowel or a consonant.
 Display an appropriate message.

    Input: 'a'
    Output: "That's a vowel."
 */
Console.WriteLine("Give me a character");
string character = Console.ReadLine();
//int characterNumber = int.Parse(character);
if (character == "A" || character == "a" || character == "E" || character == "e" || character == "I" || character == "i" || character == "O" || character == "o" || character == "U" || character == "o"){
Console.WriteLine("That's a vowel");
} 
else {
Console.WriteLine("That's a consonant");
}

