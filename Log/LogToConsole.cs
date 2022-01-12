using System;

namespace Log
{
    public static class LogToConsole
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[INFO] {message}");
            Console.ResetColor();
        }
    }
}