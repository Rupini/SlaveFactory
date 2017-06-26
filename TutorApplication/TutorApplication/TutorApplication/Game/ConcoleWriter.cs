using System;

namespace TutorApplication
{
    public static class ConcoleWriter
    {
        public static void WriteLine(string message, ConsoleColor color)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;
        }
    }
}