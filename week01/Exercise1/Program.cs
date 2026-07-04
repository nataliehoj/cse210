using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Student!");

        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is you last name? ");
        string lname = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}