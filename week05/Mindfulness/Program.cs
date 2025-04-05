using System;
// Showing Creativity: In class ReflectingActivity I added logic so the question in GetRandomQuestion is not repeated until all the questions are used.  

class Program
{
    static void Main(string[] args)
    {
        string action = "0";
        Console.WriteLine("Menu Options:");
        while (action != "4")
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            action = Console.ReadLine();
            if (action == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
            }
            else if (action == "2")
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }
            else if (action == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
               
            }
            else if (action == "4")
            {
                Console.WriteLine("Thank you. Goodbye.");
            }
        }
    }
}