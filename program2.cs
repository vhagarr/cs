//1.Calculate the factorial of a given number

using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        int i, fact = 1, number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
    }
}

//2.Print odd numbers in a given range

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter starting number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter ending number: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Odd numbers between {0} and {1} are:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (i % 2 != 0)  // Check if number is odd
            {
                Console.Write(i + " ");
            }
        }
    }
}

//3.Print all multiples of 17 which are less than 200

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Multiples of 17 less than 200:");

        for (int i = 17; i < 200; i += 17)
        {
            Console.Write(i + " ");
        }
    }
}


