namespace Core.Task3;

internal static class TemperatureHelper
{
    public static void EnsureIsCelsius(double value)
    {
        if (value < MeltingPointInCelsius)
            throw new Exception("Task 3 : Temperature in celsius is invalid.");
    }
    
    private const double MeltingPointInCelsius = -273.15d;
}