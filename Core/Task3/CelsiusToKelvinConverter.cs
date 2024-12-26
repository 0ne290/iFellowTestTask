namespace Core.Task3;

public class CelsiusToKelvinConverter : IConverter
{
    public double Convert(double temperatureInCelsius)
    {
        TemperatureHelper.EnsureIsCelsius(temperatureInCelsius);
        
        return temperatureInCelsius + MeltingPointInKelvin;
    }
    
    private const double MeltingPointInKelvin = -273.15d;
}