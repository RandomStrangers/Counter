using System;
class Counter
{
    public static int x;
    public const string Version = "0.2";
    static void Main(string[] args)
    {
        Console.Title = "Counter" + " v" + Version;
        while (x != int.MaxValue)
        {
            x++;
            Console.WriteLine(x);
        }
        if (x == int.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
        }
    }
}