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
            string xx = "15,329";
            int result;
            int.TryParse(xx, out result); // returns false, if no comma would return true and set reult = to number always returns bool
            int zz = int.Parse(xx.Replace(",", ""));
            Console.WriteLine(zz);
            Console.WriteLine(string.Format(" This is {0} at {1:0,0.000} and is {2:t}", tex,somNum,current));
            Console.WriteLine(22/7);
            Console.WriteLine(Math.Round(5.3));
        }
    }
}
