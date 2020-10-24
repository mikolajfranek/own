using System;
using System.Text;
using Own.Backend.NullObjects;

namespace Own.Backend.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger() { }

        private static Null<object> IDENT_CRITICAL_SECTION = new Null<object>();

        public void Log(Action<LogBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(new LogBuilder(stringBuilder));
            lock (IDENT_CRITICAL_SECTION)
            {
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
