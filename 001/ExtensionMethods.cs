using System;

namespace Essential01
{
    public static class ExtensionMethods
    {
        public static int Wordcount(this string str)
        {
            var WordCount = str.Split(new char[] {' ', '.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
            return WordCount;
        }
    }
}