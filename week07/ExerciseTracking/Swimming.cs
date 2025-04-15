using System;

public class Swimming : Activity 
{
    private int _laps = 0; 
    public Swimming(DateTime date, int minutes, double distance, int laps): base (date, minutes, distance)
    {
        _laps = laps;
    }
    public override double ComputeSpeed()
    {
        double distance = (double)_laps * 50 / 1000 * 0.62;
        double speed = distance / GetMinutes() * 60;
        return speed; 
    }
    public override double ComputePace()
    {
        double pace = (double)GetMinutes() / GetDistance();
        return pace;
    }
    public override void GetSummary()
    {
       double distance = GetDistance();
       double speed = ComputeSpeed();
       double pace = ComputePace();
       Console.WriteLine($"{GetDate().ToString("dd MMMM yyyy")} Swimming ({GetMinutes()} min)- Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} min per mile");
    }
}