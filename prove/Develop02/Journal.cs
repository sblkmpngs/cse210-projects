
public class Journal
{
    public List<Entries> _entries = new List<Entries>();

    

    public void SaveToFile(string file)
    {
       string fileName = "Journal.txt";
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
    
                            outputFile.WriteLine($"{_entries}");
    

                        }
                }

    }









}