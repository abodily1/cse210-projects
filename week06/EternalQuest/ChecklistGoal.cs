using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus; 
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target; 
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
            return false; 
    } 
    public void SetAmountCompleted(int value)
    {
       _amountCompleted = value; 
    }
    public override string GetDetailsString()
    {
         return $"{_description} -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_point},{_target},{_bonus},{_amountCompleted}";
    }
}
