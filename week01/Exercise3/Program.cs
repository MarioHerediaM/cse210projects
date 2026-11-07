using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomNumber = new Random();
        int num = randomNumber.Next(1,100);
        int guess = 0;
        while (num != guess)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congrats you guessed right!");
            }

        }
    }
}