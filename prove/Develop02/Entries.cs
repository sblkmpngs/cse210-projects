
public class Entries
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompts: {_promptText}");
        Console.WriteLine($"Entries: {_entryText}");

        


    }
    
}