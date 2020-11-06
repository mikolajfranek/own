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
                Console.WriteLine("Start program");


                /*
                Parallel.For(0, 10, i =>
                {
                    ILogger logger = new FileLogger();
                    logger.Log(logBuilder => logBuilder
                       .AddDefaultContent()
                   );
                });
                */

                Console.WriteLine("End program");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
