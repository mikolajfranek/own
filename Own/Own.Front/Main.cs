using System;
using Own.Backend.Loggers;

namespace Own.Front
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

            try
            {
                logger.Log(logBuilder  => logBuilder
                    .AddContent("hello")
                    .AddNewLine()
                    .AddContent("hello2")
                    .AddNewLine()
                    .AddOSVersion()
                );
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }




        }
    }
}
