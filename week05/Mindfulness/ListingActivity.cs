using System;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        AddPrompts();
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        DisplayReady();
        DisplayPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0, _prompts.Count());
        return _prompts[num];
    }
    private void AddPrompts()
    {
        _prompts.Add("--- Who are people that you appreciate?");
        _prompts.Add("--- What are personal strengths of yours?");
        _prompts.Add("--- Who are people that you have helped this week?");
        _prompts.Add("--- When have you felt the Holy Ghost this month?");
        _prompts.Add("--- Who are some of your personal heroes?");
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
    }
    private void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Convert.ToDouble(_duration));
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _count += 1; 
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
}