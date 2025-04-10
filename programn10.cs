//1. C# Program to implement Minimum 5 StringBuilder methods
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        // 1. Append
        sb.Append(" World");
        Console.WriteLine("After Append: " + sb);

        // 2. Insert
        sb.Insert(5, ",");
        Console.WriteLine("After Insert: " + sb);

        // 3. Replace
        sb.Replace("World", "C#");
        Console.WriteLine("After Replace: " + sb);

        // 4. Remove
        sb.Remove(5, 1); // Removes the comma
        Console.WriteLine("After Remove: " + sb);

        // 5. Clear
        sb.Clear();
        Console.WriteLine("After Clear: \"" + sb + "\" (empty string)");
    }
}
