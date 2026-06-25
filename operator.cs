using System;
class Program
{
    static  void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter CGPA: ");
        double cgpa = Convert.ToDouble(Console.ReadLine());
        
        
        Console.WriteLine("\n----- student Information -----");
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Age: "+ age);
        Console.WriteLine("CGPA: "+ cgpa);
       
    }
}