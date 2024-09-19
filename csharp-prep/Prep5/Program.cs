using System;

class Program
{
    static void Main(string[] args)
    {
          DisplayWelcomeMessage();

        string Name = PromptName();
        int Number = PromptNumber();

        int squaredNumber = SquareNumber(Number);

        DisplayResult(Name, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptNumber()
    {
        Console.Write("choose a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, Your number squared is {square}");
    }
    
}