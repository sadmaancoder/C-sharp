using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 50, 20, 80, 30};

        int min = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Minimum = " + min);
    }
}