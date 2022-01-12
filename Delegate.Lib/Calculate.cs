using System;

namespace Delegate.Lib
{
    public static class Calculate
    {
        public static Message Log;
        
        public static int Add(int x, int y)
        {
            if (Log is not null)
            {
                Log($"x = {x}, y = {y}");
            }
            // Log?.Invoke($"x = {x}, y = {y}");
            var result = x + y;
            Log?.Invoke($"{x} + {y} = {result}");
            return result;
        }
        
        public static int Sub(int x, int y)
        {
            Log?.Invoke($"x = {x}, y = {y}");
            var result = x - y;
            Log?.Invoke($"{x} - {y} = {result}");
            return result;
        }
        
        public static int Mul(int x, int y)
        {
            Log?.Invoke($"x = {x}, y = {y}");
            var result = x * y;
            Log?.Invoke($"{x} * {y} = {result}");
            return result;
        }
        
        public static int Div(int x, int y)
        {
            Log?.Invoke($"x = {x}, y = {y}");
            try
            {
                var result = x / y;
                Log?.Invoke($"{x} / {y} = {result}");
                return result;
            }
            catch (DivideByZeroException)
            {
                Log?.Invoke("ERROR Деление на ноль");
                throw new Exception("Деление на ноль");
            }
        }
    }
}