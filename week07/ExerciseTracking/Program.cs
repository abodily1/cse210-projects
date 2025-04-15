using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        DateTime currentTime = DateTime.Now;
        int length = 30;
        double distance = 3.0;
        Running run = new Running(currentTime, length, distance);
        activity.Add(run);

        length = 60;
        distance = 18.5;
        Cycling cycling = new Cycling(currentTime, length, distance);
        activity.Add(cycling);

        int laps = 35; 
        length = 55;
        distance = 1.2;
        Swimming swim = new Swimming(currentTime, length, distance, laps);
        activity.Add(swim);

        foreach (Activity item in activity)
        {
            item.GetSummary();
        } 
    }
}