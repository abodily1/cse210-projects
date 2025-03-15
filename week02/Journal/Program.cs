// Showing Creativity and Exceeding Requirements:
//  Save other information in the journal entry - Location (city only)  
using System;
class Program
{
    static void Main(string[] args)
    {
        string action = "0";
        Journal myJournal = new Journal();

        Prompts p = new Prompts();
        p.Create();

        string filename = "journal.csv"; 

        Console.WriteLine("Welcome to the Journal Project.\nPlease select one of the following:");
        while (action != "5")
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            action = Console.ReadLine();
           
            if (action == "1")
            {
                // get date/time
                DateTime now = DateTime.Now;
                string date = now.ToString("MM/dd/yyyy HH:mm:ss");

                // get the random prompt
                string res = p.GetRandomPrompt();
                Console.WriteLine($"{res}");
                string response = Console.ReadLine();
                
                // get location
                Console.WriteLine("Enter your location (city only): ");
                string loc = Console.ReadLine();
                
                Entry entry = new Entry();
                entry._dateTime = date;
                entry._prompt = res;
                entry._response = response;
                entry._location = loc;

                myJournal.AddEntry(entry);
            }
            else if (action == "2")
            {
                myJournal.DisplayAll();
            }
            else if (action == "3")
            {
                myJournal.LoadFromFile(filename);
            }
            else if (action == "4")
            {
                myJournal.SaveToFile(filename);
            }
            else if (action == "5")
            {
                Console.WriteLine("Thank you. Goodbye.");
            }
        }
    }
}