﻿using System;
using System.Text;

namespace Essential01
{
    class Program
    {
    public static string title = "My programs";
    public static int aNumber;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Line appended");
            sb.Append("Note to self append is not spelled apppend.");
            StringBuilder sb2 = new StringBuilder("With text!");
            sb2.AppendLine("Added new line."); // results in same line
            sb2 = new StringBuilder();
            sb2.AppendLine("Time for a break.");
            sb2.AppendLine("Added new line.");
            Console.WriteLine(sb2.ToString());
        }
    }
}
