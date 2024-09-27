public class Counter_0_0
{
    public static System.Byte x;
    public const System.String Version = "0.0.0.0";
    public static void Main()
    {
        while (Counter_0_0.x != System.Byte.MaxValue)
        {
            Counter_0_0.x++;
            System.Console.WriteLine("System.Byte:" + Counter_0_0.x);
        }
    }
}