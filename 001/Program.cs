﻿using System;

namespace Essential01
{
    class Program
    {
    public static string title = "My programs";
    public static int aNumber;
        static void Main(string[] args)
        {
            aNumber = 5;
            int bigInt = int.MaxValue; // MaxVlue can be used to show max value of int type
            int smInt = int.MinValue;
            uint posInt = uint.MaxValue;
            float pie = 3.14f; // f required to make it float over double.
            bool amI = false; // bool is boolean and true/false lowercase
            var message = string.Format($"This is {title} and a number {aNumber}");
            message = "'long' and 'short' are also int values";
            message = ($"this is big int {bigInt}, smInt {smInt} and posInt {posInt}");
            Console.WriteLine(message);
        }
    }
}
