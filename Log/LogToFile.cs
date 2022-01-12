using System.IO;

namespace Log
{
    public static class LogToFile
    {
        public static void Log(string message)
        {
            using var file = new StreamWriter("delegate.log", append:true);
            file.WriteLine($"[INFO] {message}");
        }
    }
}