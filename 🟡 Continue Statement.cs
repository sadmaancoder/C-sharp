using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i == 4)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}