using System;
using System.Threading.Tasks;
using Own.Backend.Loggers;

namespace Own.Front
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Parallel.For(0, 10, i =>
                {
                    ILogger logger = new FileLogger();
                    logger.Log(logBuilder => logBuilder
                       .AddDefaultContent()
                   );
                });

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
