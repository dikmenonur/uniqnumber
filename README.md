# Unique Integer Extractor

This project contains a method to extract unique integer values from a given string. The method takes a string of integers separated by spaces and returns a list of unique integers.

## Requirements

- The input string consists of integers from 0 to 100, separated by spaces.
- The method should return unique integers from the input string.
- The order of the integers in the output does not matter.

## Example

If you pass the string `"2 2 2 8 8 3 0 0 10 3 8 8"` to the method, it will return `2 8 3 0 10`. The order does not matter, so it could also return `0 2 3 8 10`.

## Method Implementation

The method `GetUniqueIntegers` is implemented as follows:

1. Split the input string by spaces to get individual integer strings.
2. Convert these strings to integers.
3. Use a `HashSet<int>` to store unique integers, as `HashSet` does not allow duplicate values.
4. Convert the `HashSet<int>` back to a list and return it.

Here is the complete implementation in C#:

```csharp
using System;
using System.Collections.Generic;

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
