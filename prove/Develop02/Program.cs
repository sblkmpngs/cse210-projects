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
                Entries Entries1 = new Entries();
                Entries1._promptText = "Did you meet someone interesting?";
                Entries1._entryText = "";
                Entries1._date = "";

                Entries Entries2 = new Entries();
                Entries2._promptText = "What did you do today?";
                Entries2._entryText = "";
                Entries2._date = "";

                Entries Entries3 = new Entries();
                Entries3._promptText = "Let's mention your blessings:";
                Entries3._entryText = "";
                Entries3._date = "";

                Entries Entries4 = new Entries();
                Entries4._promptText = "What did you do today?";
                Entries4._entryText = "";
                Entries4._date = "";

                Entries Entries5 = new Entries();
                Entries5._promptText = "Did you learn something new?";
                Entries5._entryText = "";
                Entries5._date = "";

                 List<Entries> answers = new List<Entries>();
                 answers.Add(Entries1);
                 answers.Add(Entries2);
                 answers.Add(Entries3);
                 answers.Add(Entries4);
                 answers.Add(Entries5);

                Random randomGenerator = new Random();
                int question = randomGenerator.Next();
                
                Console.WriteLine("What is the best thing about today?");
                Console.Write("> ");
                string Prompts = Console.ReadLine();



            }
            else if (response==2)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{dateText}{answer}");
                
            }
            else if (response==3)
            {
                string fileName = "Journal.txt";
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
    
                            outputFile.WriteLine($"{answer}");
    

                        }
                }
                string filename = "journal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                            string dateText = parts[0];
                        Console.Write("Input File Name: ");
                        Console.ReadLine();    
                        Console.WriteLine("Loading File...");
                    }

            }
            else if (response==4)
            {
                string filename = "journal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                Console.Write("Input File Name: ");
                Console.ReadLine();
                Console.WriteLine("Saving File...");
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
