using System;
public static class Counter
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
    public static sbyte m = sbyte.MinValue;
    public static sbyte n = sbyte.MaxValue;
    public static byte o = byte.MinValue;
    public static byte p = byte.MaxValue;
    public static float q = float.MinValue;
    public static float r = float.MaxValue;
    public static double s = double.MinValue;
    public static double t = double.MaxValue;
    public const string InternalVersion = "1.1.5";
    public static void Main(string[] args)
    {
        Console.Title = "Counter v" + InternalVersion;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Black;
        while (a != int.MaxValue || b != int.MinValue
            || c != uint.MaxValue || d != uint.MinValue
            || e != long.MaxValue || f != long.MinValue
            || g != ulong.MaxValue || h != ulong.MinValue
            || i != short.MaxValue || j != short.MinValue
            || k != ushort.MaxValue || l != ushort.MinValue
            || m != sbyte.MaxValue || n != sbyte.MinValue
            || o != byte.MaxValue || p != byte.MinValue
            || q != float.MaxValue || r != float.MinValue
            || s != double.MaxValue || t != double.MinValue)
        {
            if (a != int.MaxValue)
            {
                a++;
                Console.WriteLine(a);
            }
            if (a == int.MaxValue)
            {
                Console.WriteLine("A is " + int.MaxValue);
            }
            if (b != int.MinValue)
            {
                b--;
                Console.WriteLine(b);
            }
            if (b == int.MinValue)
            {
                Console.WriteLine("B is " + int.MinValue);
            }
            if (c != uint.MaxValue)
            {
                c++;
                Console.WriteLine(c);
            }
            if (c == uint.MaxValue)
            {
                Console.WriteLine("C is " + uint.MaxValue);
            }
            if (d != uint.MinValue)
            {
                d--;
                Console.WriteLine(d);
            }
            if (d == uint.MinValue)
            {
                Console.WriteLine("D is " + uint.MinValue);
            }
            if (e != long.MaxValue)
            {
                e++;
                Console.WriteLine(e);
            }
            if (e == long.MaxValue)
            {
                Console.WriteLine("E is " + long.MaxValue);
            }
            if (f != long.MinValue)
            {
                f--;
                Console.WriteLine(f);
            }
            if (f == long.MinValue)
            {
                Console.WriteLine("F is " + long.MinValue);
            }
            if (g != ulong.MaxValue)
            {
                g++;
                Console.WriteLine(g);
            }
            if (g == ulong.MaxValue)
            {
                Console.WriteLine("G is " + ulong.MaxValue);
            }
            if (h != ulong.MinValue)
            {
                h--;
                Console.WriteLine(h);
            }
            if (h == ulong.MinValue)
            {
                Console.WriteLine("H is " + ulong.MinValue);
            }
            if (i != short.MaxValue)
            {
                i++;
                Console.WriteLine(i);
            }
            if (i == short.MaxValue)
            {
                Console.WriteLine("I is " + short.MaxValue);
            }
            if (j != short.MinValue)
            {
                j--;
                Console.WriteLine(j);
            }
            if (j == short.MinValue)
            {
                Console.WriteLine("J is " + short.MinValue);
            }
            if (k != ushort.MaxValue)
            {
                k++;
                Console.WriteLine(k);
            }
            if (k == ushort.MaxValue)
            {
                Console.WriteLine("K is " + ushort.MaxValue);
            }
            if (l != ushort.MinValue)
            {
                l--;
                Console.WriteLine(l);
            }
            if (l == ushort.MinValue)
            {
                Console.WriteLine("L is " + ushort.MinValue);
            }
            if (m != sbyte.MaxValue)
            {
                m++;
                Console.WriteLine(m);
            }
            if (m == sbyte.MaxValue)
            {
                Console.WriteLine("M is " + sbyte.MaxValue);
            }
            if (n != sbyte.MinValue)
            {
                n--;
                Console.WriteLine(n);
            }
            if (n == sbyte.MinValue)
            {
                Console.WriteLine("N is " + sbyte.MinValue);
            }
            if (o != byte.MaxValue)
            {
                o++;
                Console.WriteLine(o);
            }
            if (o == byte.MaxValue)
            {
                Console.WriteLine("O is " + byte.MaxValue);
            }
            if (p != byte.MinValue)
            {
                p--;
                Console.WriteLine(p);
            }
            if (p == byte.MinValue)
            {
                Console.WriteLine("P is " + byte.MinValue);
            }
            if (q != float.MaxValue)
            {
                q++;
                Console.WriteLine(q);
            }
            if (q == float.MaxValue)
            {
                Console.WriteLine("Q is " + float.MaxValue);
            }
            if (r != float.MinValue)
            {
                r--;
                Console.WriteLine(r);
            }
            if (r == float.MinValue)
            {
                Console.WriteLine("R is " + float.MinValue);
            }
            if (s != double.MaxValue)
            {
                s++;
                Console.WriteLine(s);
            }
            if (s == double.MaxValue)
            {
                Console.WriteLine("S is " + double.MaxValue);
            }
            if (t != double.MinValue)
            {
                t--;
                Console.WriteLine(t);
            }
            if (t == double.MinValue)
            {
                Console.WriteLine("T is " + double.MinValue);
            }
        }
        if (a == int.MaxValue && c == uint.MaxValue
            && e == long.MaxValue && g == ulong.MaxValue
            && i == short.MaxValue && k == ushort.MaxValue
            && m == sbyte.MaxValue && o == byte.MaxValue
            && q == float.MaxValue && s == double.MaxValue)
        {
            Console.WriteLine("Max limit reached!");
            a = int.MinValue;
            c = uint.MinValue;
            e = long.MinValue;
            g = ulong.MinValue;
            i = short.MinValue;
            k = ushort.MinValue;
            m = sbyte.MinValue;
            o = byte.MinValue;
            q = float.MinValue;
            s = double.MinValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main(null);
        }
        if (b == int.MinValue && d == uint.MinValue
            && f == long.MinValue && h == ulong.MinValue
            && j == short.MinValue && l == ushort.MinValue
            && n == sbyte.MinValue && p == byte.MinValue
            && r == float.MinValue && t == double.MinValue)
        {
            Console.WriteLine("Min limit reached!");
            b = int.MaxValue;
            d = uint.MaxValue;
            f = long.MaxValue;
            h = ulong.MaxValue;
            j = short.MaxValue;
            l = ushort.MaxValue;
            n = sbyte.MaxValue;
            p = byte.MaxValue;
            r = float.MaxValue;
            t = double.MaxValue;
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey(true);
            Main(null);
        }
    }
}