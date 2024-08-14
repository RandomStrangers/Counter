using System;
public class Counter_1_1_3
{

    public static int a = int.MinValue;
    public static int b = int.MaxValue;
    public static uint c = uint.MinValue;
    public static uint d = uint.MaxValue;
    public static long e = long.MinValue;
    public static long f = long.MaxValue;
    public static ulong g = ulong.MinValue;
    public static ulong h = ulong.MaxValue;
    public static short i = short.MinValue;
    public static short j = short.MaxValue;
    public static ushort k = ushort.MinValue;
    public static ushort l = ushort.MaxValue;
    public const string InternalVersion = "1.1.3";
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.BackgroundColor = ConsoleColor.Black;
        while (a != int.MaxValue || b != int.MinValue || c != uint.MaxValue || d != uint.MinValue || e != long.MaxValue || f != long.MinValue || g != ulong.MaxValue || h != ulong.MinValue || i != short.MaxValue || j != short.MinValue || k != ushort.MaxValue || l != ushort.MinValue)
        {
          if (a != int.MaxValue) 
          {
            a++;
            Console.WriteLine(a);
          }
          if (a == int.MaxValue) {
            Console.WriteLine("A is " + int.MaxValue);
          }
          if (b != int.MinValue) 
          {
            b--;
            Console.WriteLine(b);
          }
          if (b == int.MinValue) {
            Console.WriteLine("B is " + int.MinValue);
          }
          if (c != uint.MaxValue) 
          {
            c++;
            Console.WriteLine(c);
          }
          if (c == uint.MaxValue) {
            Console.WriteLine("C is " + uint.MaxValue);
          }
          if (d != uint.MinValue) 
          {
            d--;
            Console.WriteLine(d);
          }
          if (d == uint.MinValue) {
            Console.WriteLine("D is " + uint.MinValue);
          }
          if (e != long.MaxValue) 
          {
            e++;
            Console.WriteLine(e);
          }
          if (e == long.MaxValue) {
            Console.WriteLine("E is " + long.MaxValue);
          }
          if (f != long.MinValue) 
          {
            f--;
            Console.WriteLine(f);
          }
          if (f == long.MinValue) {
            Console.WriteLine("F is " + long.MinValue);
          }
          if (g != ulong.MaxValue) 
          {
            g++;
            Console.WriteLine(g);
          }
          if (g == ulong.MaxValue) {
            Console.WriteLine("G is " + ulong.MaxValue);
          }
          if (h != ulong.MinValue) 
          {
            h--;
            Console.WriteLine(h);
          }
          if (h == ulong.MinValue) {
            Console.WriteLine("H is " + ulong.MinValue);
          }
          if (i != short.MaxValue) 
          {
            i++;
            Console.WriteLine(i);
          }
          if (i == short.MaxValue) {
            Console.WriteLine("I is " + short.MaxValue);
          }
          if (j != short.MinValue) 
          {
            j--;
            Console.WriteLine(j);
          }
          if (j == short.MinValue) {
            Console.WriteLine("J is " + short.MinValue);
          }
          if (k != ushort.MaxValue) 
          {
            k++;
            Console.WriteLine(k);
          }
          if (k == ushort.MaxValue) {
            Console.WriteLine("K is " + ushort.MaxValue);
          }
          if (l != ushort.MinValue) 
          {
            l--;
            Console.WriteLine(l);
          }
          if (l == ushort.MinValue) {
            Console.WriteLine("L is " + ushort.MinValue);
          }
        }
        if (a == int.MaxValue && c == uint.MaxValue && e == long.MaxValue && g == ulong.MaxValue && i == short.MaxValue && k == ushort.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            a = int.MinValue;
            c = uint.MinValue;
            e = long.MinValue;
            g = ulong.MinValue;
            i = short.MinValue;
            k = ushort.MinValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
        if (b == int.MinValue && d == uint.MinValue && f == long.MinValue && h == ulong.MinValue && j == short.MinValue && l == ushort.MinValue)
        {
            Console.WriteLine("Min limit reached!");
            b = int.MaxValue;
            d = uint.MaxValue;
            f = long.MaxValue;
            h = ulong.MaxValue;
            j = short.MaxValue;
            l = ushort.MaxValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}