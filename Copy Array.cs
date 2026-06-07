using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 10, 20, 30, 40, 50 };
        int[] arr2 = new int[5];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i];
        }

        foreach (int num in arr2)
        {
            Console.Write(num + " ");
        }
    }
}