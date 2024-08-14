using System;
public class Counter_1_1_0
{
    public static ulong x = ulong.MinValue;
    public static ulong y = ulong.MaxValue;
    public const string InternalVersion = "1.1.0";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != ulong.MaxValue || y != ulong.MinValue)
        {
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        if (x == ulong.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            x = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
        if (y == ulong.MinValue)
        {
            Console.WriteLine("Min limit reached!");
            y = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}
