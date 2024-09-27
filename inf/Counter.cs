using System;
namespace Counter
{
    public static class Inf
    {
        public static float a, b;
        public static double c, d;
        public const string InternalVersion = "0.0.0.4";
        public static string Version {  get { return InternalVersion + "inf"; } }
        public static string Title = "Counter v" + Version;
        public static void Main(string[] args)
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black; 
            while (a != float.PositiveInfinity || b != float.NegativeInfinity || c != double.PositiveInfinity || d != double.NegativeInfinity)
            {
                a++;
                b--;
                c++;
                d--;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
            }
        }
    }
}