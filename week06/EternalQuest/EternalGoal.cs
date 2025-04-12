using System;

class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, int points): base (name, description, points)
    {
    }
    public override void RecordEvent()
    {
        // Eternal goes are not marked complete so there is nothing to do.
    }
    public override bool IsComplete()
    {
        // Eternal Goals are never complete
        return false; 
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_point}";
    }
}