public class UniqueIntegerExtractor
{
    public static List<int> GetUniqueIntegers(string input)
    {
        // Split the input string by spaces to get individual integer strings
        string[] integerStrings = input.Split(' ');

        // Use a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // Convert strings to integers and add them to the HashSet
        foreach (string integerString in integerStrings)
        {
            if (int.TryParse(integerString, out int number))
            {
                uniqueIntegers.Add(number);
            }
        }

        // Convert the HashSet to a List (or any other collection) to return
        return new List<int>(uniqueIntegers);
    }

    public static void Main(string[] args)
    {
        string input = "2 2 2 8 8 3 0 0 10 3 8 8";
        List<int> uniqueIntegers = GetUniqueIntegers(input);

        // Output the result
        Console.WriteLine(string.Join(" ", uniqueIntegers));
    }
}