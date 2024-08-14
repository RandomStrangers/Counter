using System;
    public class Counter
    {
        public static ulong x = ulong.MinValue;
        public static ulong y = ulong.MaxValue;
        public const string InternalVersion = "1.1.1";
        public static void Main(string[] args)
        {
            Console.Title = "Counter" + " v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            while (x != ulong.MaxValue || y != ulong.MinValue)
            {
                x++;
                y--;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            if (x == ulong.MaxValue)
            {
                Console.WriteLine("Max limit reached!");
                x = 0;
                Console.WriteLine("Press any key to restart!");
                Console.ReadKey(true);
                Main(null);
            }
            if (y == ulong.MinValue)
            {
                Console.WriteLine("Min limit reached!");
                y = 0;
                Console.WriteLine("Press any key to restart!");
                Console.ReadKey(true);
                Main(null);
            }
        }
    }