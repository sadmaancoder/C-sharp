using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter day (1-7): ");
        
        int day;
        bool isValid = int.TryParse(Console.ReadLine(), out day);

        if (!isValid)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
            return;
        }

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }
}