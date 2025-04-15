using System;

public abstract class Activity
{
    private DateTime _date;
    private int _mins;
    private double _distance; 

    public Activity(DateTime date, int minutes, double distance)
    {
        _date = date;
        _mins = minutes;
        _distance = distance;
    }

    public DateTime GetDate()
    { 
        return _date; 
    }
    public int GetMinutes()
    {
        return _mins;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public abstract double ComputeSpeed();
    public abstract double ComputePace();
    public abstract void GetSummary();
}
