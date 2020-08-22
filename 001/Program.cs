using System;

namespace Essential01
{
    class Program
    {
    public static string title = "My programs";
    public static int aNumber;
        static void Main(string[] args)
        {
            aNumber = 5;
            var message = string.Format($"This is {title} and a number {aNumber}");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
