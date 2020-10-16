using System;

namespace Own.Backend.Loggers
{
    public interface ILogger
    {
        void Log(Action<LogBuilder> action);
    }
}
