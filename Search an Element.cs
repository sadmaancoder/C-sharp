using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        int search = 30;

        bool found = false;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == search)
            {
                found = true;
                break;
            }
        }

        if(found)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");
    }
}