using System;
using System.Text;

namespace Essential01
{
    class Program
    {
        static void Main(string[] args)
        {
            string tex = "Word One";
            float somNum = 10100.33f;
            var current = DateTime.Now;
            Console.WriteLine(string.Format(" This is {0} at {1:0,0.000} and is {2:t}", tex,somNum,current));
        }
    }
}
