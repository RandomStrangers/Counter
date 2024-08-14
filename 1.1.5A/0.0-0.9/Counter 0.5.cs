using System;
public class Counter_0_5
{
    public static int x;
    public const string Version = "0.5";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != int.MaxValue)
        {
            x++;
            Console.WriteLine(x);
        }
        if (x == int.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            x = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}