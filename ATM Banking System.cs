using System;

class Program
{
    static void Main()
    {
        double balance = 1000;

        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");

        Console.Write("Choose Option: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Balance = " + balance);
                break;

            case 2:
                Console.Write("Deposit Amount: ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                balance += deposit;
                Console.WriteLine("New Balance = " + balance);
                break;

            case 3:
                Console.Write("Withdraw Amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());

                if (withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine("New Balance = " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}