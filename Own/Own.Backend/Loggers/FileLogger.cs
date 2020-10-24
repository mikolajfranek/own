using System;
using System.Text;
using Own.Backend.Components;
using Own.Backend.NullObjects;

namespace Own.Backend.Loggers
{
    public class FileLogger : ILogger
    {
        public FileLogger() { }

        private static Null<object> IDENT_CRITICAL_SECTION = new Null<object>();
        private const string FILE_PATH = "/home/debian/Dokumenty/Logowania/OwnLog.txt";

        public void Log(Action<LogBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(new LogBuilder(stringBuilder));
            lock (IDENT_CRITICAL_SECTION)
            {
                FileComponent.SaveContent(FILE_PATH, stringBuilder.ToString());
            }
        }
    }
}
