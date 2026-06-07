using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}