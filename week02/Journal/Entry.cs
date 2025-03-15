using System;

public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _dateTime= "";
    public string _location = "";

    public void DisplayEntry()
    {
         Console.WriteLine($"Date: {_dateTime}");
         Console.WriteLine($"Prompt: {_prompt}");
         Console.WriteLine($"Response: {_response}");
         Console.WriteLine($"Location: {_location}");
    }
}