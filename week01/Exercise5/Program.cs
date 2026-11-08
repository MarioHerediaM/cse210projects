using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        Console.WriteLine("What is your name?");
        string userName = PromptUserName(Console.ReadLine());

        Console.WriteLine("Enter a number:");
        int userNumber = PromptUserNumber(int.Parse(Console.ReadLine()));

        int squaredNumber = SquareNumber(userNumber);

        string result = DisplayResult(squaredNumber, userName);

        Console.WriteLine(result);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName(string name)
    {
        return name;
    }

    static int PromptUserNumber(int number)
    {
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static string DisplayResult(int number, string name)
    {
        return $"Brother {name}, the square of your number is {number}";
    }
}