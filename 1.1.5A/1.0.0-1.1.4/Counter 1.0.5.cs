using System;
public class Counter_1_0_5
{
    public static int x;
    public static int y;
    public const string InternalVersion = "1.0.5";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(">0)");
        Console.WriteLine("(_>");
        while (x != int.MaxValue || y != int.MinValue)
        {
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
            if (x == 0 + -y)
            {
                Console.WriteLine(">0)");
                Console.WriteLine("(_>");
            }
        }
        if (x == int.MaxValue)
        {
            Console.WriteLine("Max limit reached! YAY!");
            x = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
        if (y == int.MinValue)
        {
            Console.WriteLine("Min limit reached! YAY!");
            y = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}