using System;
using System.Data;
using System.Diagnostics;

public class BreathingActivity : Activity

{
    private string _message;
    public BreathingActivity(string name, string description, int duration, string message) : base(name, description, duration)
    {
        _message = message;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine(base.DisplayStartingMessage());
        Console.WriteLine("How much time(seconds) would you like to spend in this activity?");
        int duration = Convert.ToInt32(Console.ReadLine());
        DateTime startIntTime = DateTime.Now;
        DateTime endIntTime = startIntTime.AddSeconds(duration);

        while (DateTime.Now < endIntTime)
        {
            base.ShowSpinner(3);
            Thread.Sleep(1000);
            Console.Clear();
            List<string> breathing = new List<string>();
            breathing.Add("breathe in...");
            breathing.Add("breathe out...");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string b = breathing[i];
                Console.Write(b);
                Thread.Sleep(1000);
                base.ShowCountDown(5);
                Console.WriteLine("");
                i++;

                if (i >= breathing.Count)
                {
                    i = 0;
                }

            }
        }
        Thread.Sleep(2000);
        Console.WriteLine($"{"\n"}{DisplayEndingMessage()}{"\n"}");
        Thread.Sleep(1000);
        Console.Clear();

    }


}