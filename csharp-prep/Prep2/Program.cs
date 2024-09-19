using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int result = int.Parse(answer);

        string letter = "";

        if (result >= 90)
        {
            letter = "A";
        }
        else if (result >= 80)
        {
            letter = "B";
        }
        else if (result >= 70)
        {
            letter = "C";
        }
        else if (result >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (result >= 70)
        {
            Console.WriteLine("Well Done, you did it");
        }
        else
        {
            Console.WriteLine("You have to try harder next time");
        }
    }
}