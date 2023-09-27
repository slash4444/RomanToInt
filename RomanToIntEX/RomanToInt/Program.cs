using System;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
            {
                result -= romanValues[s[i]];
            }
            else
            {
                result += romanValues[s[i]];
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.WriteLine("Enter a Roman numeral (e.g., III, LVIII, MCMXCIV):");
        string input = Console.ReadLine();

        try
        {
            int intValue = solution.RomanToInt(input);
            Console.WriteLine($"Integer value: {intValue}");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a valid Roman numeral.");
        }
    }
}
