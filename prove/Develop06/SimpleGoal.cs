public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    
    public SimpleGoal(string name, string description, int points, bool optionalIsComplete = false) : base(name, description, points)
    {
        if (optionalIsComplete == false)
        {
            _isComplete = false;
        }
        else if (optionalIsComplete == true)
        {
            _isComplete = true;
        }
    }

    
    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;

            Console.WriteLine($"Congratulations! You have earned {_points} points!");
           
            
            return _points;

        }
        else
        {
            Console.WriteLine("You have already completed this goal. Returning to main menu.");
            return 0;
        }
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string outputString = $"SimpleGoal:{_name},{_shortDescription},{_points},{_isComplete}";
        return outputString;
    }


}