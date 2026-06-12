using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 1 };

        Console.WriteLine("Duplicate Elements:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}