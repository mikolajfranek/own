using System;
using System.Text;
using Own.Backend.Components;

namespace Own.Backend.Logger
{
    public class FileLogger : ILogger
    {
        public FileLogger() { }

        private const string filePath = "/home/debian/Dokumenty/Logowania/OwnLog.txt";

        public void Log(Action<LogBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(new LogBuilder(stringBuilder));
            FileComponent.SaveContent(filePath, stringBuilder.ToString());
        }
    }
}
