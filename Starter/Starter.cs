using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Counter
{
    public static class Starter
    {
        public const string InternalVersion = "1.0.0.3";
        public const string Name = "Starter";
        public const string Title = Name + " v " + InternalVersion;
        public static List<string> Programs = new List<string>()
        {
            "Counter 0.0.exe", "Counter 0.1.exe", "Counter 0.2.exe", "Counter 0.4.exe",
            "Counter 0.5.exe", "Counter 0.6.exe", "Counter 0.7.exe", "Counter 0.8.exe",
            "Counter 0.9.exe", "Counter 1.0.0.exe", "Counter 1.0.1.exe", "Counter 1.0.2.exe",
            "Counter 1.0.3.exe", "Counter 1.0.4.exe", "Counter 1.0.5.exe", "Counter 1.0.6.exe",
            "Counter 1.0.7.exe", "Counter 1.0.8.exe", "Counter 1.0.9.exe", "Counter 1.1.0.exe",
            "Counter 1.1.1.exe", "Counter 1.1.2.exe", "Counter 1.1.3.exe", "Counter 1.1.4.exe",
            "Counter 1.1.5.exe", "Counter 1.1.6A.exe"
        };
        public static string Program;
        public static void Main(string[] args)
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (string program in Programs)
            {
                try
                {
                    Program = program;
                    Process.Start(program);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error starting program {0}: \n{1}", program, ex.ToString());
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}