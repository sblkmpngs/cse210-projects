
public class Journal
{
    public List<Entries> _entries = new List<Entries>();

    
    public string _fileName = "Journal.txt";

    
    public void AddEntry(Entries newEntry)
    {
        _entries.Add(newEntry);
    
    }
    public void DisplayAllEntries()
    {

    
        foreach (Entries i in _entries)
        {
            i.DisplayEntries();
        }
    }
    public void SaveToFile(string file)
    {
       string fileName = "Journal.txt";
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
    
                            foreach (Entries i in _entries)
                            {
                            string entryDate = $"{i._date}";
                            string entryPrompt = $"{i._promptText}";
                            string entryText = $"{i._entryText}";

                            outputFile.WriteLine($"{entryDate},{entryPrompt},{entryText}");
                            }
                        }
    

                        
                }

    }
    public void LoadToFile(string filename)
    {
        string filenameLoad = "Journal.txt";
        
        {       
            _entries.Clear();


            string[] lines = System.IO.File.ReadAllLines(filenameLoad);
            foreach (string line in lines)
            {
                Entries newEntry = new Entries();

                string[] parts = line.Split(",");

                string entryDate = parts[0];
                string entryPrompt = parts[1];
                string textEntry = parts[2];

                newEntry._date = entryDate;
                newEntry._promptText = entryPrompt;
                newEntry._entryText = textEntry;

                Console.WriteLine("This is the inserted journal:");
                Console.WriteLine(newEntry._date);
                Console.WriteLine(newEntry._promptText);
                Console.WriteLine(newEntry._entryText);

                _entries.Add(newEntry);

            }


        }
    }
}