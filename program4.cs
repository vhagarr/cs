//1. C# Program to Overload Binary Plus ʺ+ʺ Operator

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
