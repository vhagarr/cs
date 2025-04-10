//1.
9.	C# Program to demonstrate interface inheritance (The shape and colour program practiced in the practicale sesison)

using System;
// Define the first interface IShape
interface IShape
{
    void Draw();
}
// Define the second interface IColor
interface IColor
{
    void FillColor();
}
// Interface inheritance: IColoredShape inherits from both IShape and IColor
interface IColoredShape : IShape, IColor
{
    void Display();
}
// A class that implements the IColoredShape interface
class Circle : IColoredShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }

    public void FillColor()
    {
        Console.WriteLine("Filling the Circle with Red color.");
    }

    public void Display()
    {
        Console.WriteLine("Displaying the Colored Circle.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.Draw();         // From IShape
        myCircle.FillColor();    // From IColor
        myCircle.Display();      // From IColoredShape
    }
}
