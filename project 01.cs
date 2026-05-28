using System;

class Program
{
    static void Main()
    {
        double num1, num2, result = 0;
        char op;

        // First Number Input
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Operator Input
        Console.Write("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        // Second Number Input
        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Calculation
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
                break;

            default:
                Console.WriteLine("Invalid Operator!");
                return;
        }

        // Final Output
        Console.WriteLine("Result = " + result);
    }
}