//1. C# Program to overload ++ operator.

using System;

class Counter
{
    public int Value;

    public Counter(int value)
    {
        Value = value;
    }

    // Overloading the ++ operator
    public static Counter operator ++(Counter c)
    {
        c.Value += 1;
        return c;
    }

    public void Display()
    {
        Console.WriteLine("Value: " + Value);
    }
}
class Program
{
    static void Main()
    {
        Counter c1 = new Counter(5);

        Console.WriteLine("Before increment:");
        c1.Display();

        c1++;  // Calls overloaded ++ operator

        Console.WriteLine("After increment:");
        c1.Display();
    }
}
