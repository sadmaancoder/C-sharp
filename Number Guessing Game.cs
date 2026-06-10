using System;

class Program
{
    static void Main()
    {
        int secretNumber = 7;
        int guess;

        Console.Write("Guess a number (1-10): ");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed correctly.");
        }
        else
        {
            Console.WriteLine("Wrong Guess!");
        }
    }
}