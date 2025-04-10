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


//2. C# Program to overload unary “-” Operator

using System;
namespace Calculator
{
    internal class Calculator
    {
        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Calculator operator -(Calculator c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine("number1= " + number1);
            Console.WriteLine("number2= " + number2);

        }
        class program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator(-10, -25);
                calc = -calc;
                calc.print();
            }
        }
    }
}

//3. C# Program to Overload Binary Plus ʺ+ʺ Operator

using System;
namespace overload
{
    class BinaryOverloading
    {
        public int number1 = 0;
        public BinaryOverloading() { }
        public BinaryOverloading(int num1)
        {
            number1 = num1;

        }
        public static BinaryOverloading operator +(BinaryOverloading c1, BinaryOverloading c2)
        {
            BinaryOverloading c3 = new BinaryOverloading(0);
            c3.number1 = c1.number1 + c2.number1;
            return c3;
        }
        public void print()
        {
            Console.WriteLine(number1);
        }
        class program
        {
            static void Main(string[] args)
            {
                BinaryOverloading c1 = new BinaryOverloading(250);
                BinaryOverloading c2 = new BinaryOverloading(50);
                BinaryOverloading c3 = new BinaryOverloading();
                c3 = c1 + c2;
                c1.print();
                c2.print();
                c3.print();
            }
        }
    }
}

