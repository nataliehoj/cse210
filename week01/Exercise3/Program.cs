using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int leNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != leNumber)
        {
            Console.Write("What is le number? ");
            guess = int.Parse(Console.ReadLine());

            if (leNumber > guess)
            {
                Console.WriteLine("Le number is higher");
            }
            else if (leNumber < guess)
            {
                Console.WriteLine("Le number is lower");
            }
            else
            {
                Console.WriteLine("You have guessed Le number!");
            }
        }
    }
}