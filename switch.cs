using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }
}