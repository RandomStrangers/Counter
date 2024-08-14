class Counter
{
    static System.Byte x;
    const System.String Version = "0.0.0.0";
    static void Main(System.String[] args)
    {
        System.Console.Title = "Test" + " v" + Counter.Version;
        while (Counter.x != System.Byte.MaxValue)
        {
            Counter.x++;
            System.Console.WriteLine("System.Byte:" + Counter.x);
        }
    }
}