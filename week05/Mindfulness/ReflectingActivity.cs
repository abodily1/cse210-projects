using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>(); 
    private List<int> _usedQuestions = new List<int>(); 

    public ReflectingActivity()
    { 
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        AddPrompts();
        AddQuestions();
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetDurationFromUser(); 
        DisplayReady();
        DisplayPrompt();       
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Convert.ToDouble(_duration));
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            DisplayQuestions();
            currentTime = DateTime.Now;
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0, _prompts.Count());
        return _prompts[num];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int num = random.Next(0, _questions.Count());
        if (_usedQuestions.Count() == _prompts.Count())
        {
            _usedQuestions.Clear();
        }
        while (_usedQuestions.Contains(num)) 
        {
            num = random.Next(0, _prompts.Count());
        }
        _usedQuestions.Add(num); 
       
        return _questions[num];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue");
        // Press enter to continue 
        Console.ReadLine(); 
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }
    private void AddPrompts()
    {
        _prompts.Add("--- Think of a time when you stood up for someone else.");
        _prompts.Add("--- Think of a time when you did something really difficult.");
        _prompts.Add("--- Think of a time when you helped someone in need");
        _prompts.Add("--- Think of a time when you did something truly selfless.");
        _prompts.Add("--- What was is the best scripture I read today?");
    }
    private void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(8);
    }
    private void AddQuestions()
    {
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than the other times when you were not as sucessful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situation? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the furture? ");
    }
}