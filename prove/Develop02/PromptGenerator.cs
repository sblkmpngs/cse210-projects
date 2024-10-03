

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

   
        string Prompts = Console.ReadLine();


        public string RandomPrompt()
            {
                List<string> prompts = new List<string>();
                prompts.Add("What is the best thing about today?");
                prompts.Add("Did you learn something new?");
                prompts.Add("Let's mention your blessings:");
                prompts.Add("What was the strongest emotion I felt today?");
                prompts.Add("Did you meet someone interesting?");

                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, prompts.Count());

                string promptText = prompts[number];

                return promptText;
            }
    
    

}
