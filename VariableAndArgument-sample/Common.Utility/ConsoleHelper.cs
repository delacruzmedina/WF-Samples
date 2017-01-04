using System;

namespace Common.Utility
{
    public class ConsoleHelper
    {
        public static void WriteLineInColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
    }
}
