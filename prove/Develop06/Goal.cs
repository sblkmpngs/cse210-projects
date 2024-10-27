using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{

    
    protected string _name;
    protected string _shortDescription;
    protected int _points;

    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _shortDescription = description;
        _points = points;
    }

    

    public abstract int RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString(string type)
    
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

            detailsString = $"{checkbox} {_name} ({_shortDescription})";
            }
        
        return detailsString;
    }



    public abstract string GetStringRepresentation();
    
}