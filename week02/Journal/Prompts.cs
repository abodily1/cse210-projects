using System; 
public class Prompts
{

    public List<string> _prompts;
    public Prompts()
    {
        _prompts = new List<string>();
    }
    public string GetRandomPrompt()
    {
        //get random number 
        Random random = new Random();
        int num = random.Next(0, _prompts.Count());
    
        //get random prompt
        return _prompts[num];
    }
    public void Create()
    {
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What is the best memory I had this week?");
        _prompts.Add("What was the best part of the day?");
        _prompts.Add("What was the best food I ate today?");
        _prompts.Add("What was is the best scripture I read today?");
    }
}