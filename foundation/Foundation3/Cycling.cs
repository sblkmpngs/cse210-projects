public class Cycling : Activity
{
 
    private double _speed; 

    
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
        
    }

   
    public override string GetSummary()
    {
        int duration = Duration();
        string date = Date();
        
        double distance = _speed / 60 * duration; 
        double pace = 60 / _speed;
        
  

        string activitySummary = $"{date} Cycling ({duration} min.) - Distance: {distance:N2} miles, Speed: {_speed:N2} mph, Pace: {pace:N2} minutes per mile";
        return activitySummary;
    }
}