using System;
using System.Text;

namespace Essential01
{
    class Program
    {
        static void Main(string[] args)
        {
            School First = new School();
            Console.Write("Enter School Name: ");
            First.Name = Console.ReadLine() + " University";
            Console.Write("Enter School City: ");
            First.City = Console.ReadLine();
            Console.Write("Enter School Mascot: ");
            First.Mascot = Console.ReadLine();
            Console.Write("Enter School Color: ");
            First.Color = Console.ReadLine();
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
            Console.WriteLine(First.ToString());

            var Teacher = new Teacher();
            var Student = new Student();
            Console.WriteLine(Teacher.ComputeGrade());
            Console.WriteLine(Teacher.SendMessage("Yo"));
            Console.WriteLine(Student.ComputeGrade());
        }
    }
}
