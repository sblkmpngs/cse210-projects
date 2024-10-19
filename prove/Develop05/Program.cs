using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int response=-1;
        while (response!=4)
        {
            
            Console.WriteLine("Please select one of the following menu options: ");
            Console.WriteLine("1. Breathing Activity: ");
            Console.WriteLine("2. Listing Activity: ");
            Console.WriteLine("3. Reflection Activity: ");
            Console.WriteLine("4. Quit: ");

            Console.Write("Please Choose [1~4]: ");
            string selection = Console.ReadLine();
            response = int.Parse(selection);
        
        

            if (response ==1)
            {      
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax and Clear your mind.", 0, "Get Ready...");
                breathingActivity.Run();
            
            }

            else if(response==2)
            {
                    List<string> promptListing = ["What are some things that bring me joy and happiness?",
                                                "How can I practice more gratitude in my daily life?",
                                                "How can I practice more self-care and self-love?",
                                                "How can I cultivate a sense of inner peace and calm?"];
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you list the good things in your life.", 0, 0, promptListing);
                    listingActivity.Run();
                    
            }

            else if(response==3)
            {
                    List<string> promptList = ["Think of a turning point in your life.", "Think of a great expirience.",
                    "Think of a bad expirience."];

                    List<string> promptQuestion = ["How can you grow from this?", "What can you change about this?", "What did you learn from this?",
                    "Do you regret this?", "What was special about this?"];

                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on the good things in your life.", 0, promptList, promptQuestion);
                    reflectingActivity.Run();

                  
            }

            else if(response==4)
            {
                    Console.WriteLine("Thanks for participating! goodbye");
                   
            }
            else
            {
            Console.WriteLine("Please Input the Correct answer. options 1-4");
            
            }
        }
        
    }
}