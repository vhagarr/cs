//1. C# Program to overload unary “-” Operator

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
