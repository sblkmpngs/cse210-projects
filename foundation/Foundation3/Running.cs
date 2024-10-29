public class Running : Activity
{
    
    private double _distance;

  
    public Running(string date, int duration, int distance) : base(date, duration)
    {
        _distance = distance;

      
    }

  
    public override string GetSummary()
    {
        int duration = Duration();
        string date = Date();
        
        double speed = _distance / duration * 60;
        double pace = duration / _distance;

       

        string activitySummary = $"{date} Running ({duration} min.) - Distance: {_distance:N2} miles, Speed: {speed:N2} mph, Pace: {pace:N2} minutes per mile";
        return activitySummary;
    }
}