using System;

public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        DisplayReady();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Convert.ToDouble(_duration));
        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
        {
            Console.Write("Breathe in...");
            // Breathe in loop
            for(int i = 5; i > 0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breathe out...");

            // Breathe out loop
            for(int i = 5; i > 0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}