using System;
public class Counter_1_1_2
{

    public static int a = int.MinValue;
    public static int b = int.MaxValue;
    public static uint c = uint.MinValue;
    public static uint d = uint.MaxValue;
    public static long e = long.MinValue;
    public static long f = long.MaxValue;
    public static ulong g = ulong.MinValue;
    public static ulong h = ulong.MaxValue;

    public const string InternalVersion = "1.1.2";
    public static void Main()
    {            
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.BackgroundColor = ConsoleColor.Black;
        while (a != int.MaxValue || b != int.MinValue || c != uint.MaxValue || d != uint.MinValue || e != long.MaxValue || f != long.MinValue || g != ulong.MaxValue || h != ulong.MinValue)
        {
          if (a != int.MaxValue) 
          {
            a++;
            Console.WriteLine(a);
          }
          if (b != int.MinValue) 
          {
            b--;
            Console.WriteLine(b);
          }
          if (c != uint.MaxValue) 
          {
            c++;
            Console.WriteLine(c);
          }
          if (d != uint.MinValue) 
          {
            d--;
            Console.WriteLine(d);
          }
          if (e != long.MaxValue) 
          {
            e++;
            Console.WriteLine(e);
          }
          if (f != long.MinValue) 
          {
            f--;
            Console.WriteLine(f);
          }
          if (g != ulong.MaxValue) 
          {
            g++;
            Console.WriteLine(g);
          }
          if (h != ulong.MinValue) 
          {
            h--;
            Console.WriteLine(h);
          }
        }
        if (a == int.MaxValue && c == uint.MaxValue && e == long.MaxValue && g == ulong.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            a = int.MinValue;
            c = uint.MinValue;
            e = long.MinValue;
            g = ulong.MinValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
        if (b == int.MinValue && d == uint.MinValue && f == long.MinValue && h == ulong.MinValue)
        {
            Console.WriteLine("Min limit reached!");
            b = int.MinValue;
            d = uint.MinValue;
            f = long.MinValue;
            h = ulong.MinValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}