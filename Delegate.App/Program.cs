using System;
using Delegate.Lib;

namespace Delegate.App
{
    internal static class Program
    {
        private static void Main()
        {
            CLI.Show("*** Калькулятор v0.1 ***");
            Console.WriteLine();

            var exit = false;
            var select = string.Empty;
            Calculate.Log = Log.LogToFile.Log;
            Calculate.Log += Log.LogToConsole.Log;
            var x = 0;
            var y = 0;
            var result = 0;
            
            do
            {
                CLI.Show("Режимы работы:");
                CLI.Show("1. Сложение");
                CLI.Show("2. Вычитание");
                CLI.Show("3. Умножение");
                CLI.Show("4. Деление");
                CLI.Show("0. Выход");
                select = CLI.Input("Выберите режим: ");

                switch (select)
                {
                    case "1":
                        x = Int32.Parse(CLI.Input("Введите первое число"));
                        y = Int32.Parse(CLI.Input("Введите второе число"));
                        result = Calculate.Add(x, y);
                        break;
                    case "2":
                        x = Int32.Parse(CLI.Input("Введите первое число"));
                        y = Int32.Parse(CLI.Input("Введите второе число"));
                        result = Calculate.Sub(x, y);
                        break;
                    case "3":
                        x = Int32.Parse(CLI.Input("Введите первое число"));
                        y = Int32.Parse(CLI.Input("Введите второе число"));
                        result = Calculate.Mul(x, y);
                        break;
                    case "4":
                        x = Int32.Parse(CLI.Input("Введите первое число"));
                        y = Int32.Parse(CLI.Input("Введите второе число"));
                        result = Calculate.Div(x, y);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        CLI.Show("Ввели не тот режим. Повторите ввод.");
                        break;
                }

            } while (!exit);
            
            CLI.Show("До свидания ...");
        }
    }
}