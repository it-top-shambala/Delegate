using System;

namespace Delegate.Lib
{
    public static class Calculate
    {
        public static Message Log;
        
        public static int Add(int x, int y)
        {
            Log($"x = {x}, y = {y}");
            var result = x + y;
            Log($"{x} + {y} = {result}");
            return result;
        }
        
        public static int Sub(int x, int y)
        {
            Log($"x = {x}, y = {y}");
            var result = x - y;
            Log($"{x} - {y} = {result}");
            return result;
        }
        
        public static int Mul(int x, int y)
        {
            Log($"x = {x}, y = {y}");
            var result = x * y;
            Log($"{x} * {y} = {result}");
            return result;
        }
        
        public static int Div(int x, int y)
        {
            Log($"x = {x}, y = {y}");
            try
            {
                var result = x / y;
                Log($"{x} / {y} = {result}");
                return result;
            }
            catch (DivideByZeroException)
            {
                Log("ERROR Деление на ноль");
                throw new Exception("Деление на ноль");
            }
        }
    }
}