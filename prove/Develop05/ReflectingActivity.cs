using System;

public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine(base.DisplayStartingMessage());
        Console.WriteLine("How much time(seconds) would you like to spend in this activity?");
        int duration = Convert.ToInt32(Console.ReadLine());
        DateTime startIntTime = DateTime.Now;
        DateTime endTime = startIntTime.AddSeconds(duration);

        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            base.ShowSpinner(3);
            Thread.Sleep(1000);
            Console.Clear();
            GetRandomPrompt();
            Console.WriteLine("If ready, press ENTER to begin...");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience \n");
            Console.Write("You should begin in...");
            Thread.Sleep(1000);
            base.ShowCountDown(3);
            Console.SetCursorPosition(0, Console.CursorTop);
            GetRandomQuestion();
            Thread.Sleep(3000);
            base.ShowSpinner(3);
            Console.Clear();
            Console.SetCursorPosition(0, Console.CursorTop);
            GetRandomQuestion();
            Thread.Sleep(3000);
            Console.WriteLine("");
            base.ShowSpinner(3);
            Console.Clear();
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
            Console.WriteLine($"{"\n"}{base.DisplayEndingMessage()}{"\n"}");
            Thread.Sleep(1000);
            Console.Clear();
        }

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count); 

        Console.WriteLine(_prompts[randomPrompt]);


    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestion = random.Next(_questions.Count); //RANDOM QUESTION
        Console.WriteLine(_questions[randomQuestion]);
    }
    public string DisplayPrompt()
    {
        return "";
    }

    public string DisplayQuestion()
    {
        return "";
    }

}