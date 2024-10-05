using System;

class Program
{
    static void Main(string[] args)
    {
        string verse = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Reference reference = new Reference("Mosiah", 2, 1);
        //Console.Write(reference.GetDisplayText());


        Scripture scripture = new Scripture(reference, verse);
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("");
        string answer="";

        while(answer!="quit")
        {
            Console.WriteLine("Press Enter to Continue or type quit to exit.");
            answer = Console.ReadLine();
            
            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.GetDisplayText());
            
        }

        
        if (answer == "quit")
            {
                Console.WriteLine("Good Job!");
            } 
        else
        {
            Console.WriteLine("Good Job!");
        }
    }
}