using System;

class Program
{
    static void Main(string[] args)
    {
         
        int Number = 7;

        int guess = -1;
        while (guess != Number)
        {
            Console.Write("Pick a number: ");
            guess = int.Parse(Console.ReadLine());

            if (Number == guess)
            {
                Console.WriteLine("You Got It");
            }
            else if (Number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}