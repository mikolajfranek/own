using System;
using System.Text;

namespace Own.Backend.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger() { }

        public void Log(Action<LogBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(new LogBuilder(stringBuilder));
            Console.WriteLine(stringBuilder);
        }
    }
}
