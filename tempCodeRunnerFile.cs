using System;

class Program
{
    static void Main()
    {
      console.Write("Enter a number: ");
      int num =  Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
}