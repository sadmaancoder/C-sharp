using System;

class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "1234";

        Console.Write("Username: ");
        string user = Console.ReadLine();

        Console.Write("Password: ");
        string pass = Console.ReadLine();

        if (user == username && pass == password)
        {
            Console.WriteLine("Login Successful");
        }
        else
        {
            Console.WriteLine("Login Failed");
        }
    }
}