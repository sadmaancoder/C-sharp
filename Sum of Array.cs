using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 20, 30, 40, 50};

        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }
}