namespace Core.Task2;

public class RepeatingCharacters
{
    public RepeatingCharacters(string sourceText)
    {
        if (string.IsNullOrWhiteSpace(sourceText))
            throw new Exception("Task 2 : Source text is invalid.");
        
        var uniqueCharacters = new HashSet<char>(sourceText.Length);
        var repeatingCharacters = new HashSet<char>(sourceText.Where(character => !uniqueCharacters.Add(character)));

        Value = new string(repeatingCharacters.ToArray());
    }

    public string Value { get; }
}