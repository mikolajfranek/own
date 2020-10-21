using System;
using System.Text;
using Own.Backend.Components;

namespace Own.Backend.Loggers
{
    public class FileLogger : ILogger
    {
        public FileLogger() { }

        private const string filePath = "/home/debian/Dokumenty/Logowania/OwnLog.txt";

        public void Log(Action<LogBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(new LogBuilder(stringBuilder));
            lock (BackendConfiguration.IDENT_CRITICAL_SECTION_LOGGER_FILE)
            {
                FileComponent.SaveContent(filePath, stringBuilder.ToString());
            }
        }
    }
}
