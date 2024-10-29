public abstract class Activity
{
   
    private string _date; 
    private int _duration; 

  
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
       
    }

 
    public string Date()
    {
        return _date;
    }
    public int Duration()
    {
        return _duration;
    }
    public abstract string GetSummary();
   
}