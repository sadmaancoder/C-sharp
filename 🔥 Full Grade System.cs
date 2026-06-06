using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 80)
            Console.WriteLine("A+");
        else if (marks >= 70)
            Console.WriteLine("A");
        else if (marks >= 60)
            Console.WriteLine("B+");
        else if (marks >= 50)
            Console.WriteLine("B");
        else if (marks >= 40)
            Console.WriteLine("D");
        else
            Console.WriteLine("Fail");
    }
}