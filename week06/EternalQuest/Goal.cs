using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description; 
    protected int _point;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _point = points;
    }
    public abstract void RecordEvent(); 
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
         return _description;
    }
    public string GetGoalName()
    {
         return ($"Name: {_shortName}");
    }

    public string GetGoalDescription()
    {
         return _description;
    }

    public int GetPoints()
    {
         return _point;
    }
    public abstract string GetStringRepresentation();
    
}
