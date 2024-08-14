using System;
public class Counter_1_0_9
{
    public static long x;
    public static long y;
    public const string InternalVersion = "1.0.9";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != long.MaxValue || y != long.MinValue)
        {
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        if (x == long.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            x = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
        if (y == long.MinValue)
        {
            Console.WriteLine("Min limit reached!");
            y = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}
