using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7,8};

        int count = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % 2 != 0)
            {
                count++;
            }
        }

        Console.WriteLine("Odd Count = " + count);
    }
}
