//1. Print the Fibonacci series up to the first 6 numbers
using System;

class Program
{
    static void Main()
    {
        int n1 = 0, n2 = 1, n3;

        Console.WriteLine("First 6 numbers of the Fibonacci series:");
        Console.Write(n1 + " " + n2 + " ");

        for (int i = 2; i < 6; i++)  // Already printed first two numbers
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}

//2.	Program to find the sum of digits of a number
using System;
class Program
{
    static void Main()
    {
        int num, sum = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum of digits = " + sum);
    }
}

//3.Calculate the factorial of a given number

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
