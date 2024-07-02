public class UniqueIntegerExtractor
{
    /// <summary>
    /// Extracts unique integer values from a space-separated string.
    /// </summary>
    /// <param name="input">The string containing space-separated integers.</param>
    /// <returns>A list of unique integer values found in the input string.</returns>
    public static List<int> GetUniqueIntegers(string input)
    {
        // 1. Split the input string into an array of string representations of integers.
        string[] integerStrings = input.Split(' ');

        // 2. Create a HashSet to efficiently store and track unique integers.
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // 3. Iterate through each string representation of an integer.
        foreach (string integerString in integerStrings)
        {
            // 4. Attempt to parse the string into an integer.
            if (int.TryParse(integerString, out int number))
            {
                // 5. If parsing is successful, add the integer to the HashSet to ensure uniqueness.
                uniqueIntegers.Add(number);
            } // If parsing fails, the non-integer string is ignored.
        }
        // 6. Convert the HashSet (containing unique integers) into a List for easier manipulation and return it.
        return new List<int>(uniqueIntegers);
    }

    public static void Main(string[] args)
    {
        // Example usage of the GetUniqueIntegers method.
        string input = "2 2 2 8 8 3 0 0 10 3 8 8";
        List<int> uniqueIntegers = GetUniqueIntegers(input);

        // Display the unique integers in a space-separated format.
        Console.WriteLine(string.Join(" ", uniqueIntegers));  // Output: 2 8 3 0 10
    }
}
