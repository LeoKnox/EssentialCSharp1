using System;
using System.Text;

namespace Essential01
{
    class Program
    {
        static void Main(string[] args)
        {
            string tex = "Word One";
            float somNum = 101.33f;
            DateTime current = DateTime.Now;
            Console.WriteLine(string.Format(" This is {0} with {1} and is {2}", tex,somNum,current));
        }
    }
}
