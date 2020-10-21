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
            lock (BackendConfiguration.IDENT_CRITICAL_SECTION_LOGGER_CONSOLE)
            {
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
