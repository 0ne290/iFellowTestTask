namespace Core.Task3;

public class CelsiusToFahrenheitConverter : IConverter
{
    public double Convert(double temperatureInCelsius)
    {
        TemperatureHelper.EnsureIsCelsius(temperatureInCelsius);
        
        return MagicCoefficient * temperatureInCelsius + MeltingPointInFahrenheit;
    }

    private const double MagicCoefficient = 9d / 5d;
    
    private const double MeltingPointInFahrenheit = 32d;
}