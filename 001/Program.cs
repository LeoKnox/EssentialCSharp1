using System;
using System.Text;

namespace Essential01
{
    class Program
    {
        static void Main(string[] args)
        {
            School First = new School();
            Console.WriteLine(First.Name);
            Console.Write("Enter School Name: ");
            string name = Console.ReadLine();
            First.Name = name + " University";
            Console.WriteLine(First.Name);
            Console.Write("Enter School City: ");
            string City = Console.ReadLine();
            Console.Write("Enter School Mascot: ");
            string mascot = Console.ReadLine();
            Console.Write("Enter School Color: ");
            string color = Console.ReadLine();
            while (First.Socialmedia == null)
            {
                Console.Write("Enter School Media: ");
                try
                {
                    First.Socialmedia = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
