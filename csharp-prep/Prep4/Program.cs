using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            Number = int.Parse(userResponse);
            
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }

        int add = 0;
        foreach (int number in numbers)
        {
            add += number;
        }

        Console.WriteLine($"The sum is: {add}");
        float average = ((float)add) / numbers.Count;
        Console.WriteLine($"The average is: {average}");   
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The maximum is: {max}");
    }
}