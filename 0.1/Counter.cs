class Counter
{
    static System.Int32 x;
    const System.String Version = "0.1";
    static void Main(string[] args)
    {
        System.Console.Title = "Counter" + " v" + Version;
        while (x != System.Int32.MaxValue)
        {
            x++;
            System.Console.WriteLine(x);
        }
    }
}