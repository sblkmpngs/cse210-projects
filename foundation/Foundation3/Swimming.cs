public class Swimming : Activity
{
    
    private int _laps;

  
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
        
    }


    public override string GetSummary()
    {
        int duration = Duration();
        string date = Date();

        double distance = _laps * 50 / 1000 * 0.62;
        double speed = distance / duration * 60;
        double pace = duration / distance;


        string activitySummary = $"{date} Swimming ({duration} min.) - Distance: {distance:N2} miles, Speed: {speed:N2} mph, Pace: {pace:N2} minutes per mile";
        return activitySummary;
    }
}