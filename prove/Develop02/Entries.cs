
public class Entries
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntries()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompts: {_promptText}");
        Console.WriteLine($"Entries: {_entryText}");
    }

    public string GetDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }

        


    
    
}