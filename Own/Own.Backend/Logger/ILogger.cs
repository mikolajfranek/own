using System;

namespace Own.Backend.Logger
{
    public interface ILogger
    {
        void Log(Action<LogBuilder> action);
    }
}
