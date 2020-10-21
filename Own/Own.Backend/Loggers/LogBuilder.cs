using System;
using System.Text;

namespace Own.Backend.Loggers
{
    public class LogBuilder
    {
        private StringBuilder stringBuilder;

        public LogBuilder(StringBuilder stringBuilder)
        {
            this.stringBuilder = stringBuilder;
        }

        public LogBuilder AddCurrentDateAndTime()
        {
            stringBuilder.Append(DateTime.Now);
            return this;
        }

        public LogBuilder AddNewLine()
        {
            stringBuilder.Append(Environment.NewLine);
            return this;
        }

        public LogBuilder AddOSVersion()
        {
            stringBuilder.Append(Environment.OSVersion);
            return this;
        }

        public LogBuilder AddContent(string content)
        {
            stringBuilder.Append(content);
            return this;
        }

        public LogBuilder AddException(Exception exception)
        {
            stringBuilder.Append(exception);
            if (exception.InnerException != null)
            {
                stringBuilder.Append(exception.InnerException);
            }
            return this;
        }

        public LogBuilder AddDefaultContent()
        {
            this.AddCurrentDateAndTime()
                .AddNewLine()
                .AddOSVersion()
                .AddNewLine();
            return this;
        }
    }
}