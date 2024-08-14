using System;
class Counter
{
    public static int x;
    public const string Version = "0.6";
    [STAThread]
    static void Main(string[] args)
    {
        args = null;
        Console.Title = "Counter" + " v" + Version;
        Console.ForegroundColor = ConsoleColor.Red;
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
            Main(null);
        }
    }
}