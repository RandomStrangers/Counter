public class Counter_0_1
{
    public static System.Int32 x;
    public const System.String Version = "0.1";
    public static void Main()
    {
        while (x != System.Int32.MaxValue)
        {
            x++;
            System.Console.WriteLine(x);
        }
    }
}