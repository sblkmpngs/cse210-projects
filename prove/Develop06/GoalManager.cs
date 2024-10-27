using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class GoalManager
{
    
    private List<Goal> _goals;
    public int _score;

    
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


   

    public void Start() 
    {
        string userInput = "0";

        Console.WriteLine("Welcome to EternalGoal");
        
        while (userInput != "6")
        {

            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu [1~6]: ");
            userInput = Console.ReadLine();

        if (userInput == "1")
            {
                CreateGoal();
            }

        else if (userInput == "2")
            {
                ListGoalDetails();
            }

        else if (userInput == "3")
            {
                SaveGoals();
            }

        else if (userInput == "4")
            {
                LoadGoals();
            }

        else if (userInput == "5")
            {
                RecordEvent();
            }

        else if (userInput == "6")
            {
                Console.WriteLine(" Thank you and Goodbye");
            }

        else
            {
                Console.WriteLine("Please insert correct input[1~6]");
            }


        }
        

    }
    public void DisplayPlayerInfo() 
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        int goalCount = 0;
        foreach (Goal goal in _goals)
        {
            goalCount ++;

            string goalString = goal.GetDetailsString("name");
            string baseString = $"{goalCount}. {goalString}";

            Console.WriteLine(baseString);
        }
    }
    public void ListGoalDetails()
    {
        int goalCount = 0;
        foreach (Goal goal in _goals)
        {
            goalCount ++;

            string goalString = goal.GetDetailsString("details");
            string baseString = $"{goalCount}. {goalString}";

            Console.WriteLine(baseString);
        }
    }
    public void CreateGoal() 
    {
        Console.WriteLine("Which type of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string userInput = Console.ReadLine();


        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of this goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points are associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        
        if (userInput == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (userInput == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (userInput == "3")
        {
            Console.Write("How many times does this goal need accomplished to earn a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points are earned for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
}
    public void RecordEvent() 
    {
        Console.WriteLine("Your goals are:");
        ListGoalNames();
        Console.Write("Which goal have you completed? (Enter the number of the goal from the list.) ");
        int goalUpdate = int.Parse(Console.ReadLine());
        goalUpdate --;
        
        
        _score += _goals[goalUpdate].RecordEvent();

        

        Console.WriteLine($"Your total points are now {_score} points!");
    }
    public void SaveGoals() 
    {




        
        Console.Write("Enter File Name:");
        string fileName = Console.ReadLine();




        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }







    }
    public void LoadGoals() 
    {
 
        
        Console.Write("Enter File Name:");
        string fileName = Console.ReadLine();

        

        _goals = new List<Goal>();
        
    

        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        
        
        _score = int.Parse(lines[0]);
        
        foreach (string line in lines)
        {
            if (line == lines[0])
            {

            _score = int.Parse(line);
          
            }
        
            else
            {
    
                string[] parts = line.Split(":");
   
                string type = parts[0];
      
                string details = parts[1];

                string[] detailsParts = details.Split(",");
                string name = detailsParts[0];
                string description = detailsParts[1];
                int points = int.Parse(detailsParts[2]);
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(detailsParts[3]);
            

                    
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(detailsParts[3]);
                    int bonus = int.Parse(detailsParts[4]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                }
            }    

        }



    }

    public void IncreaseScore(int points)
    {
        _score += points;
    }

}