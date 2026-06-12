using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int sum = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }
}