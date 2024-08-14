using System;
using System.Diagnostics;
class Starter
{
    public const string InternalVersion = "1.0.0.0";
    static void Main(string[] args)
    {
        args = null;
        Console.Title = "Starter" + " v" + InternalVersion;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Black;
        Process.Start("Counter 0.0.exe");
        Process.Start("Counter 0.1.exe");
        Process.Start("Counter 0.2.exe");
        Process.Start("Counter 0.3.exe");
        Process.Start("Counter 0.4.exe");
        Process.Start("Counter 0.5.exe");
        Process.Start("Counter 0.6.exe");
        Process.Start("Counter 0.7.exe");
        Process.Start("Counter 0.8.exe");
        Process.Start("Counter 0.9.exe");
        Process.Start("Counter 1.0.0.exe");
        Process.Start("Counter 1.0.1.exe");
        Process.Start("Counter 1.0.2.exe");
        Process.Start("Counter 1.0.3.exe");
        Process.Start("Counter 1.0.4.exe");
        Process.Start("Counter 1.0.5.exe");
        Process.Start("Counter 1.0.6.exe");
        Process.Start("Counter 1.0.7.exe");
        Process.Start("Counter 1.0.8.exe");
        Process.Start("Counter 1.0.9.exe");
        Process.Start("Counter 1.1.0.exe");
        Process.Start("Counter 1.1.1.exe");
        Process.Start("Counter 1.1.2.exe");
        Process.Start("Counter 1.1.3.exe");
        Process.Start("Counter 1.1.4.exe");
        Process.Start("Counter 1.1.5A.exe");
    }
}
