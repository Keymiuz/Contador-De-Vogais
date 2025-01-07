using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
    }

    static int CountVowels(string str)
    {
        if (string.IsNullOrEmpty(str))
            return 0;

        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in str)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}
