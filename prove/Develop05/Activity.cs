using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string DisplayStartingMessage()
    {

        return $"Welcome to {_name}!{"\n"}{_description}{"\n"}";
    }

    public string DisplayEndingMessage()
    {
        return "ALL Done!";
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("<");
        animationStrings.Add("^");
        animationStrings.Add(">");
        animationStrings.Add("-");
        animationStrings.Add("^");
        animationStrings.Add("<");
        animationStrings.Add(">");
        animationStrings.Add("-");
        animationStrings.Add(">");
        animationStrings.Add("^");
        animationStrings.Add(">");
        animationStrings.Add("<");
        animationStrings.Add("-");
        animationStrings.Add("*");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            //Console.Write("\b \b \b \b \b \b");
            if ((i + 1) % 7 == 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        //Stretch activity to add animation emoji spinner.
    }

    public void ShowCountDown(int seconds)
    {
        int i = 0;

        for (i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }


}