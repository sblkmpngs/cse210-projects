using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine(base.DisplayStartingMessage());
        Console.WriteLine("How much time(seconds) would you like to spend in this activity?");
        int duration = Convert.ToInt32(Console.ReadLine());
        DateTime startIntTime = DateTime.Now;
        DateTime endTime = startIntTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            base.ShowSpinner(3);
            Console.Clear();
            GetRandomPrompt();
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
            Console.Write("You should begin your list...");
            Thread.Sleep(1000);
            base.ShowCountDown(3);
            Console.WriteLine("");
            base.ShowSpinner(3);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Clear();
            List<string> lista = GetListFromUser(endTime); 
            _count = lista.Count;
            Thread.Sleep(1000);
            Console.WriteLine($"You've entered {_count} entries");
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
    public List<string> GetListFromUser(DateTime endTime)
    {
        List<string> lista = new List<string>();
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            lista.Add(input);
        }
        return lista;
    }
}