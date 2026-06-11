using System;

class Program
{
    static char GetGrade(int marks)
    {
        if (marks >= 80)
            return 'A';
        else if (marks >= 70)
            return 'B';
        else if (marks >= 60)
            return 'C';
        else if (marks >= 40)
            return 'D';
        else
            return 'F';
    }

    static void Main()
    {
        Console.WriteLine("Grade: " + GetGrade(85));
        Console.WriteLine("Grade: " + GetGrade(72));
        Console.WriteLine("Grade: " + GetGrade(55));
        Console.WriteLine("Grade: " + GetGrade(30));
    }
}