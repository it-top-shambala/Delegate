using System;

namespace Delegate.App
{
    public static class CLI
    {
        public static void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static string Input(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{message}: ");
            var input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }
    }
}