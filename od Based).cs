using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static int Mul(int a, int b)
    {
        return a * b;
    }

    static int Div(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("Add = " + Add(10, 5));
        Console.WriteLine("Sub = " + Sub(10, 5));
        Console.WriteLine("Mul = " + Mul(10, 5));
        Console.WriteLine("Div = " + Div(10, 5));
    }
}