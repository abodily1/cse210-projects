using System;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {}
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName());
        } 
    }
    private void ResetGoals()
    {
        _goals.Clear();
        _score = 0;
    }
    public void ListGoalDetails()
    {
        string isDone = " ";
        int counter = 0;
        
        if (_goals.Count() > 0)
        {        
            Console.WriteLine("The goals are: ");
        
            foreach (Goal goal in _goals)
            {
                isDone = " ";
                if (goal.IsComplete()) 
                {
                    isDone = "X";
                }
                Console.WriteLine($"{counter += 1}. [{isDone}] {goal.GetDetailsString()}");
            }
            Console.WriteLine($"You now have {_score} points. ");
            Console.WriteLine();
        } 
        else
        {
            Console.WriteLine("There are no goals.");
        }
    }
    public void CreateGoal(string goalChoice, string goalName, string goalDescription, int goalPoints, int bonus, int target, bool completed, int amtCompleted)
    {
        if (goalChoice == "SimpleGoal")
        {
            SimpleGoal sg = new SimpleGoal(goalName, goalDescription, goalPoints);
            sg.SetComplete(completed);
            _goals.Add(sg);
        }
        else if (goalChoice == "EternalGoal")
        {
            EternalGoal sg = new EternalGoal(goalName, goalDescription, goalPoints); 
            _goals.Add(sg);
        }
        else if (goalChoice == "ChecklistGoal")
        {
            ChecklistGoal sg = new ChecklistGoal(goalName, goalDescription, goalPoints, bonus, target); 
            sg.SetAmountCompleted(amtCompleted);
            _goals.Add(sg);
        }
    }
    public void RecordEvent()
    {
         int counter = 0;
        
        if (_goals.Count() > 0)
        {        
            Console.WriteLine("The goals are: ");
        
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{counter += 1}. {goal.GetGoalName()}");
            }
            
            Console.Write("Which goal did you accomplish? ");
            int finishedGoal = Convert.ToInt32(Console.ReadLine());
            _goals[finishedGoal - 1].RecordEvent();
            int currentPoints = _goals[finishedGoal -1].GetPoints();
            _score += currentPoints;
            Console.WriteLine($"Congradulations! You have earned {currentPoints} points.");
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
        } 
        else
        {
            Console.WriteLine("There are no goals.");
        }      
    }
    public void SaveGoals()
    {
        if (_goals.Count() > 0)
        {                
            Console.Write("What is the filename for the goal? ");
            string goalFilename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(goalFilename))
            {
                outputFile.WriteLine($"{_score}");
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        } 
        else
        {
            Console.WriteLine("There are no goals.");
        }      
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        ResetGoals();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts.Count() == 1)
            {
                _score = Convert.ToInt32(parts[0]);
            }
            else if (parts.Count() == 4)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDesc = parts[2];
                int goalPoints = Convert.ToInt32(parts[3]);
                bool completed = false;
                int target = 0;
                int bonus = 0; 
                int amtCompleted = 0;

                CreateGoal(goalType, goalName, goalDesc, goalPoints, target, bonus, completed, amtCompleted);
            }
            else if (parts.Count() == 5)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDesc = parts[2];
                int goalPoints = Convert.ToInt32(parts[3]);
                bool completed = Convert.ToBoolean(parts[4]);
                int target = 0;
                int bonus = 0; 
                int amtCompleted = 0;

                CreateGoal(goalType, goalName, goalDesc, goalPoints, target, bonus, completed, amtCompleted);
            }
            else if (parts.Count() == 7)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDesc = parts[2];
                int goalPoints = Convert.ToInt32(parts[3]);
                int target = Convert.ToInt32(parts[4]);
                int bonus = Convert.ToInt32(parts[5]);
                int amtCompleted = Convert.ToInt32(parts[6]);
                bool completed = false;

                CreateGoal(goalType, goalName, goalDesc, goalPoints, target, bonus, completed, amtCompleted);
            } 
        }
    }
}
