using System;
public class Counter_0_2
{
    public static int x;
    public const string Version = "0.2";
    public static void Main()
    {
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