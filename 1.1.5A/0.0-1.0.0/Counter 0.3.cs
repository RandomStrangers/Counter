using System;
public class Counter_0_3
{
    public static int x;
    public const string Version = "0.3";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != int.MaxValue)
        {
            x++;
            Console.WriteLine(x);
        }
        if (x == int.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            Console.ReadKey(true);
        }
    }
}