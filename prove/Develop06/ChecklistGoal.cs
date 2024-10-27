using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    
    public override int RecordEvent()
    {
        _amountCompleted ++;
        int totalPoints;

        if (_amountCompleted < _target)
        {
            totalPoints = _points;
            Console.WriteLine($"Well Done! You have earned {_points} points!");
            
            return _points;
        }

        else if (_amountCompleted == _target)
        {
            totalPoints = _points + _bonus;
            Console.WriteLine($"Well Done! You have earned {_points} points and {_bonus} bonus points!");

            return totalPoints;
        }
        else
        {
            Console.WriteLine("You have already completed this goal. Returning to menu.");

            return 0;
        }
        
        
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString(string type)
    {


        string detailsString = "";

        if (type == "name")
            {
                detailsString = _name;
            }

        else if (type == "details")
            {
            string checkbox;

            bool complete = IsComplete();
            if (complete == false)
            {
                checkbox = "( )";
            }
            else
            {
                checkbox = "( * )";
            }

            detailsString = $"{checkbox} {_name} ({_shortDescription}) -- Currently Completed: {_amountCompleted}/{_target}";
        
            }
        
        return detailsString;
    }

    public override string GetStringRepresentation()
    {
        string outputString = $"ChecklistGoal:{_name},{_shortDescription},{_points},{_bonus},{_target},{_amountCompleted}";
        return outputString;
    }

}