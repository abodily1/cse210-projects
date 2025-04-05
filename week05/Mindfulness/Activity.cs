using System;

 public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity()
    {}
    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        ShowSpinner(3);
        Console.WriteLine();
    }
    public void GetDurationFromUser()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayReady()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();      
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        
        List <string>animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        while (currentTime < futureTime)
        {
            foreach (string a in animation)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}