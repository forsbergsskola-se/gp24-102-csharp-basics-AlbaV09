Console.WriteLine("Give me your grade number from 0 to 100");
string? grade = Console.ReadLine();
int gradeNumber = int.Parse(grade);
if (gradeNumber < 60)
{
    Console.WriteLine("F");
} else if (gradeNumber >= 60 && gradeNumber <= 69){
    Console.WriteLine("D");
} else if (gradeNumber >= 70 && gradeNumber <= 79){
    Console.WriteLine("C");
} else if (gradeNumber >= 80 && gradeNumber <= 89){
    Console.WriteLine("B");
} else if (gradeNumber >= 90 && gradeNumber <= 100){
    Console.WriteLine("A");
}
/*
A: 90-100

B: 80-89

C: 70-79

D: 60-69

F: <60
*/