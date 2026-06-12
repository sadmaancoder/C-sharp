using System;

class Program
{
    static void Main()
    {
        int[] arr = { 15, 5, 20, 8, 50 };

        int max = arr[0];
        int min = arr[0];

        foreach (int item in arr)
        {
            if (item > max)
                max = item;

            if (item < min)
                min = item;
        }

        Console.WriteLine("Maximum = " + max);
        Console.WriteLine("Minimum = " + min);
    }
}