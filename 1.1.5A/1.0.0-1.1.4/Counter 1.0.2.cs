using System;
public class Counter_1_0_2
{
    public static int x;
    public static int y;
    public const string InternalVersion = "1.0.2";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != int.MaxValue || y != int.MinValue)
        {
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        if (x == int.MaxValue)
        {
            Console.WriteLine("Maximum limit reached");
            x = 0;
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Main();
        }
        if (y == int.MinValue)
        {
            Console.WriteLine("Minimum limit reached");
            y = 0;
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Main();
        }
    }
}