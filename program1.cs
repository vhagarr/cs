//1.	Program to find the sum of digits of a number
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
//2. C# Program to Print Binary Equivalent of an Integer using Recursion 

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Binary equivalent: ");
        PrintBinary(number);
    }
    static void PrintBinary(int num)
    {
        if (num == 0)
            return;
        PrintBinary(num / 2);         // Recursive call with num divided by 2
        Console.Write(num % 2);       // Print remainder (0 or 1)
    }
}

//3.Program to swap two numbers with and without a third number 
//With:
using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Name: Srushti Rajaram Shetake, Roll no: 252, Div: B");

            // Input from the user
            Console.Write("Enter number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: number1 = " + num1 + " and number2 = " + num2);

            // Swapping logic
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping: number1 = " + num1 + " and number2 = " + num2);

            Console.ReadKey();
        }
    }
}


//Without:
using System;
namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Name: Srushti Rajaram Shetake, Roll no: 252, Div: B");
            // Get input from the user
            Console.Write("Enter number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping: number1 = " + num1 + " and number2 = " + num2);
            // Swapping without using a third variable
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping: number1 = " + num1 + " and number2 = " + num2);
            Console.ReadKey();
        }
    }
}

