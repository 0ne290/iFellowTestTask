namespace Core.Task1;

public class RandomNumbers
{
    public RandomNumbers(int count)
    {
        if (count < 1)
            throw new Exception("Task 1 : Count is invalid.");

        var numbers = new double[count];
        for (var i = 0; i < numbers.Length; i++)
            numbers[i] = Random.Shared.NextDouble();

        Value = numbers;
        Minimum = numbers.Min();
        Maximum = numbers.Max();
        Average = numbers.Average();
    }
    
    public IEnumerable<double> Value { get; }
    
    public double Minimum { get; }
    
    public double Average { get; }
    
    public double Maximum { get; }
}