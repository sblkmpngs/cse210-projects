using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml.Serialization;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using System.Formats.Asn1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Your Journal");
        

        Journal myJournal = new Journal();
        
        List<int> menu = new List<int>();
        int response=-1;
        while (response!=5)
        {
            Console.WriteLine("These Are Your Choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("Please Choose [1~5]: ");
            string answer = Console.ReadLine();
            response = int.Parse(answer);

            if (response==1)
            {
                Entries newEntry = new Entries();
            
                PromptGenerator newPrompt = new PromptGenerator();
                newEntry._promptText = newPrompt.RandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._date = newEntry.GetDateTime();
            
                newEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(newEntry);

            }
            else if (response==2)
            {
                myJournal.DisplayAllEntries();
                
            }
            else if (response==3)
            {
                Console.Write("Input File Name: ");
                Console.ReadLine();
                Console.WriteLine("Loading File...");
                string filename = Console.ReadLine();
                myJournal.LoadToFile(filename);
                myJournal.DisplayAllEntries();

            }
            else if (response==4)
            {
                Console.Write("Input File Name: ");
                Console.ReadLine();
                Console.WriteLine("Saving  File...");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if(response==5)
            {
                Console.WriteLine("All Done! See You Next Time.");
            }
            else
            {
                Console.WriteLine("Please Input the Correct answer.");
            }

        }
        

    }

}
