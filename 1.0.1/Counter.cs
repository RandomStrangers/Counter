using System;
class Counter
{
    public static ulong x;
    public const string InternalVersion = "1.0.1";
    [STAThread]
    static void Main(string[] args)
    {
        args = null;
        Console.Title = "Counter" + " v" + InternalVersion;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.BackgroundColor = ConsoleColor.Black;
        while (x != ulong.MaxValue)
        {
            x++;
            Console.WriteLine(x);
        }
        if (x == ulong.MaxValue)
        {
            Console.WriteLine("Maximum limit reached");
            x = 0;
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Main(null);
        }
    }
}