using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 50, 20, 80, 30};

        int max = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Maximum = " + max);
    }
}