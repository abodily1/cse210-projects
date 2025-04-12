using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.DisplayPlayerInfo();
        string action = "0";
        Console.WriteLine("Menu Options:");
        while (action != "6")
        {
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            action = Console.ReadLine();
            if (action == "1")
            {
                int goalAmount = 0; 
                int bonusAmount = 0;
                Console.WriteLine("The Types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal"); 
                Console.WriteLine("3. CheckList Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();

                if (goalChoice == "1")
                {
                    goalChoice = "SimpleGoal";
                }
                else if (goalChoice == "2")
                {
                    goalChoice = "EternalGoal";
                }
                else
                {
                    goalChoice = "ChecklistGoal";
                }

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = Convert.ToInt32(Console.ReadLine()); 
                if (goalChoice == "ChecklistGoal")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    goalAmount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonusAmount = Convert.ToInt32(Console.ReadLine());
                }
                bool completed = false;
                int amtCompleted = 0;
                gm.CreateGoal(goalChoice, goalName, goalDescription, goalPoints, goalAmount, bonusAmount, completed, amtCompleted);
            }
            else if (action == "2")
            {
                gm.ListGoalDetails();
            }
            else if (action == "3")
            {
                gm.SaveGoals();                
            }
            else if (action == "4")
            {
                gm.LoadGoals();
            }
            else if (action == "5")
            {
                gm.RecordEvent();
            }
        }
    }
}