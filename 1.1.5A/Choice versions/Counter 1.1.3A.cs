using System;
using System.Threading;
    public class Counter_1_1_3A
    {
        public const string InternalVersion = "1.1.3a";
        public const string Text = "Counter v" + InternalVersion;
        public static string arg;
    public static void Main(string[] args)
        {
        Console.Title = Text;
        Console.WriteLine(Text);
          if (args.Length > 0)
          {
          arg = args[0]; 
          VersionChoice();
          }
          else 
          {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("No argument found, running Counter v" + Counter_1_1_2.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_2.Main();
          return;
          }
        }
    public static void VersionChoice() {
      if (arg.CaselessContains("1.1.2"))
      {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.BackgroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("Running: Counter v" + Counter_1_1_2.InternalVersion);
          Thread.Sleep(1000);
          Counter_1_1_2.Main();
      }
      else if (arg.CaselessContains("1.1.1"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_1_1.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_1.Main();
        }
        else if (arg.CaselessContains("1.1.0"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_1_0.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_0.Main();
        }
        else if (arg.CaselessContains("1.0.9"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_9.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_9.Main();
        }
        else if (arg.CaselessContains("1.0.8"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_8.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_8.Main();
        }
        else if (arg.CaselessContains("1.0.7"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_7.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_7.Main();
        }
        else if (arg.CaselessContains("1.0.6"))
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_6.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_6.Main();
        }
        else if (arg.CaselessContains("1.0.5"))
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_5.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_5.Main();
        }
        else if (arg.CaselessContains("1.0.4"))
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_4.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_4.Main();
        }
        else if (arg.CaselessContains("1.0.3"))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_3.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_3.Main();
        }
        else if (arg.CaselessContains("1.0.2"))
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_2.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_2.Main();
        }
        else if (arg.CaselessContains("1.0.1"))
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_1.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_1.Main();
        }
        else if (arg.CaselessContains("1.0") && !arg.IsOtherVer())
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_0_0.Version);
            Thread.Sleep(1000);
            Counter_1_0_0.Main();
        }
        else if (arg.CaselessContains("9") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_9.Version);
            Thread.Sleep(1000);
            Counter_0_9.Main();
        }
        else if (arg.CaselessContains("8") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_8.Version);
            Thread.Sleep(1000);
            Counter_0_8.Main();
        }
        else if (arg.CaselessContains("7") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_7.Version);
            Thread.Sleep(1000);
            Counter_0_7.Main();
        }
        else if (arg.CaselessContains("6") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_6.Version);
            Thread.Sleep(1000);
            Counter_0_6.Main();
        }
        else if (arg.CaselessContains("5") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_5.Version);
            Thread.Sleep(1000);
            Counter_0_5.Main();
        }
        else if (arg.CaselessContains("4") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_4.Version);
            Thread.Sleep(1000);
            Counter_0_4.Main();
        }
        else if (arg.CaselessContains("3") && !arg.CaselessContains("1"))
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_0_3.Version);
            Thread.Sleep(1000);
            Counter_0_3.Main();
        }
        else if (arg.CaselessContains("2") && !arg.CaselessContains("1"))
        {
            Console.WriteLine("Running: Counter v" + Counter_0_2.Version);
            Thread.Sleep(1000);
            Counter_0_2.Main();
        }
        else if (arg.CaselessContains("0.1") || arg.CaselessEq("0.1."))
        {
            Console.WriteLine("Running: Counter v" + Counter_0_1.Version);
            Thread.Sleep(1000);
            Counter_0_1.Main();
        }
        else if (arg.CaselessEq("0.0") || arg.CaselessEq("0.0."))
        {
            Console.WriteLine("Running: Test v" + Counter_0_0.Version);
            Thread.Sleep(1000);
            Counter_0_0.Main();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Running: Counter v" + Counter_1_1_1.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_1.Main();
        }
    }
}