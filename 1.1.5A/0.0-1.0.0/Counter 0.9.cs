﻿using System;
public class Counter_0_9
{
    public static long x;
    public const string Version = "0.9";
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != long.MaxValue)
        {
            x++;
            Console.Write(x);
        }
        if (x == long.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            x = 0;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}