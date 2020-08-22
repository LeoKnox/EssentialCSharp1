using System;

namespace Essential01
{
    class Program
    {
    public static string title = "My programs";
    public static int aNumber;
        static void Main(string[] args)
        {
            // methods
            string testString = " abcDEF    ";
            Console.WriteLine(testString.Trim());
            Console.WriteLine(testString.ToUpper().TrimEnd());
            string longString = "This is a really long string, and more to come.";
            Console.WriteLine(longString.Substring(5, 3));
            // properties
            Console.WriteLine(longString.Length);
            string challenge = "   Text processing in C# is really great!    ";
            Console.WriteLine(challenge.Trim().Substring(8, challenge.Length-17).ToUpper());
        }
    }
}
