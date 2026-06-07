using System;

class Program
{
    static void Main()
    {
        int[] arr = {50,20,80,10,30};

        Array.Sort(arr);

        foreach(int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}