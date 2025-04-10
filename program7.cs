//1.	C# Program to find all substrings in a string

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("All substrings are:");

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 1; j <= input.Length - i; j++)
            {
                string substring = input.Substring(i, j);
                Console.WriteLine(substring);
            }
        }
    }
}


// 2.C# Program to convert characters of a string to the opposite case

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = "";
        foreach (char c in input)
        {
            if (char.IsUpper(c))
                result += char.ToLower(c);
            else if (char.IsLower(c))
                result += char.ToUpper(c);
            else
                result += c; // Keep non-letter characters as they are
        }

        Console.WriteLine("Converted string: " + result);
    }
}


