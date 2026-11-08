using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int userInput = -99;
        while (userInput != 0)
        {
            Console.WriteLine("Enter the numbers, when you are done type 0 to finished");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        float sum = 0;
        float average = 0;
        foreach (float number in numbers)
        {
            sum = number + sum;
        }
        Console.WriteLine($"The sum is {sum}");
        float numbercount = numbers.Count;
        if (numbercount <= 0)
        {
            Console.WriteLine("Error, the list is empty");
        }
        else
        {
            Console.WriteLine(average = sum / numbercount);
        }
        Console.WriteLine($"The average is {average}");
        
        if (numbers.Count > 0)
        {
            int greatest = numbers[0] ;
            foreach (int number in numbers)
            {
                if (number > greatest){
                    greatest=number;
                }
            }
            Console.WriteLine($"The greateast number is {greatest}");

        }
            

    }
}