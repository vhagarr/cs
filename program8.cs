//1.C# Program for searching a number in a given array.

using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 75, 90 };
        Console.Write("Enter number to search: ");
        int search = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == search)
            {
                Console.WriteLine("Number found at index " + i);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Number not found in the array.");
        }
    }
}

//2.	C# Program to find all substrings in a string

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
