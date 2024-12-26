namespace Core.Task4;

public class Clock
{
    public Clock(double hours, double minutes)
    {
        if (hours is < 0 or > 23)
            throw new Exception("Task 4 : Hours is invalid.");
        if (minutes is < 0 or > 59)
            throw new Exception("Task 4 : Minutes is invalid.");

        if (hours > 12)
            hours -= 12;
        
        var hoursInDegrees = hours * 30;
        var minutesInDegrees = minutes * 6;

        AngleInDegreesBetweenArrows = Math.Abs(minutesInDegrees - hoursInDegrees);
    }

    public double AngleInDegreesBetweenArrows { get; }
}
