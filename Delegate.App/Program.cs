using System;
using Delegate.Lib;

namespace Delegate.App
{
    public delegate int Exec(int x, int y);
    
    internal static class Program
    {
        private static void Main()
        {
            CLI.Show("*** Калькулятор v0.1 ***");
            Console.WriteLine();

            var exit = false;

            Calculate.Log = Log.LogToFile.Log;
            Calculate.Log += Log.LogToConsole.Log;

            do
            {
                CLI.Show("Режимы работы:");
                CLI.Show("1. Сложение");
                CLI.Show("2. Вычитание");
                CLI.Show("3. Умножение");
                CLI.Show("4. Деление");
                CLI.Show("0. Выход");
                var select = CLI.Input("Выберите режим: ");
                switch (select)
                {
                    case "1":
                        Calc(Calculate.Add);
                        break;
                    case "2":
                        Calc(Calculate.Sub);
                        break;
                    case "3":
                        Calc(Calculate.Mul);
                        break;
                    case "4":
                        Calc(Calculate.Div);
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

        private static void Calc(Exec exec)
        {
            var x = int.Parse(CLI.Input("Введите первое число"));
            var y = int.Parse(CLI.Input("Введите второе число"));
            exec(x, y);
        }
    }
}