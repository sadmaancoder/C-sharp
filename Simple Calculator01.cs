using System;

class Program
{
    static void Main()
    {
        Console.Write("First Number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Second Number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Operator (+,-,*,/): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result = " + (a + b));
                break;

            case '-':
                Console.WriteLine("Result = " + (a - b));
                break;

            case '*':
                Console.WriteLine("Result = " + (a * b));
                break;

            case '/':
                Console.WriteLine("Result = " + (a / b));
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}