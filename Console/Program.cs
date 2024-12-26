using System.Globalization;
using Core.Task1;
using Core.Task2;
using Core.Task3;
using Microsoft.Extensions.Configuration;

namespace Console;

internal static class Program
{
    private static int Main()
    {
        try
        {
            var config = new ConfigurationBuilder().AddJsonFile("D:\\Development\\Projects\\.NET\\IFellowTestTask\\Console\\appsettings.json").Build();
            
            ExecuteTask1(config);
            ExecuteTask2(config);
            ExecuteTask3(config);

            return 0;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);

            return 1;
        }
    }

    private static void ExecuteTask1(IConfigurationRoot config)
    {
        var task1Config = config.GetRequiredSection("Task1");
        var randomNumbersCount = int.Parse(task1Config["RandomNumbersCount"] ?? throw new Exception("Format of configuration file content is invalid."));

        var randomNumbers = new RandomNumbers(randomNumbersCount);

        System.Console.WriteLine("Task1:");
        System.Console.WriteLine($"\tContent of random numbers: {string.Join(", ", randomNumbers.Value)}");
        System.Console.WriteLine($"\tMinimum of random numbers: {randomNumbers.Minimum}");
        System.Console.WriteLine($"\tAverage of random numbers: {randomNumbers.Average}");
        System.Console.WriteLine($"\tMaximum of random numbers: {randomNumbers.Maximum}");
    }
    
    private static void ExecuteTask2(IConfigurationRoot config)
    {
        var task2Config = config.GetRequiredSection("Task2");
        var sourceText = task2Config["SourceText"] ?? throw new Exception("Format of configuration file content is invalid.");

        var repeatingCharacters = new RepeatingCharacters(sourceText);

        System.Console.WriteLine("Task2:");
        System.Console.WriteLine($"\tSource text: {sourceText}");
        System.Console.WriteLine($"\tRepeating characters in source text: {repeatingCharacters.Value}");
    }
    
    private static void ExecuteTask3(IConfigurationRoot config)
    {
        var task3Config = config.GetRequiredSection("Task3");
        var temperatureInCelsius = double.Parse(task3Config["TemperatureInCelsius"] ?? throw new Exception("Format of configuration file content is invalid."), CultureInfo.InvariantCulture);
        var convertTo = task3Config["ConvertTo"] ??
                        throw new Exception("Format of configuration file content is invalid.");

        IConverter converter = convertTo switch
        {
            "Kelvin" => new CelsiusToKelvinConverter(),
            "Fahrenheit" => new CelsiusToFahrenheitConverter(),
            _ => throw new Exception("Program.ExecuteTask2 : \"ConvertTo\" must be \"Kelvin\" or \"Fahrenheit\".")
        };

        var conversionResult = converter.Convert(temperatureInCelsius);

        System.Console.WriteLine("Task3:");
        System.Console.WriteLine($"\tTemperature in celsius: {temperatureInCelsius}");
        System.Console.WriteLine($"\tConvert to: {convertTo}");
        System.Console.WriteLine($"\tConversion result: {conversionResult}");
    }
}