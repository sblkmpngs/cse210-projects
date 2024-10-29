using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       

        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling
        (
            "06 May 2024",  25, 16 
        );

        Running running = new Running
        (
            "11 June 2024", 36, 27
        );

        Swimming swimming = new Swimming
        (
            "20 July 2024", 42, 58 
        );

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity i in activities)
        {
            Console.WriteLine(i.GetSummary());

        }

    }
}