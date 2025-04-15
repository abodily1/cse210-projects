using System;

public class Cycling : Activity 
{
    public Cycling(DateTime date, int minutes, double distance): base (date, minutes, distance)
    {}
    public override double ComputeSpeed()
    {
        double speed = (GetDistance() / GetMinutes()) * 60;
        return speed; 
    }
    public override double ComputePace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }
    public override void GetSummary()
    {
       double distance = GetDistance();
       double speed = ComputeSpeed();
       double pace = ComputePace();
       Console.WriteLine($"{GetDate().ToString("dd MMMM yyyy")} Cycling ({GetMinutes()} min)- Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} min per mile");
    }
}