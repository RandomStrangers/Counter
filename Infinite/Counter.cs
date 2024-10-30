using System;
namespace Infinite_Counter
{
    public static class Infinite
    {
        public static float A, B;
        public static double C, D;
        public const string InternalVersion = "0.0.0.5";
        public static string Title = "Counter (Infinite) v" + InternalVersion;
        public static void Main(string[] args)
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("This counter runs indefinitely, press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();
            while (A != float.PositiveInfinity  && B != float.NegativeInfinity
                && C != double.PositiveInfinity && D != double.NegativeInfinity)
            {
                A++;
                B--;
                C++;
                D--;
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
                Console.WriteLine(D);
            }
        }
    }
}