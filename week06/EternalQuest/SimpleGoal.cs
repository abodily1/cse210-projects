using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public void SetComplete(bool completed)
    {
        _isComplete = completed;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_point},{_isComplete}";
    }
}