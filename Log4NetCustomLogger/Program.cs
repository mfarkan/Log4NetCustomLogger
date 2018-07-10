
using CustomLog4netLibrary;
using System;
using System.IO;

namespace Log4NetCustomLogger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var logfile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
            Log4NetLogger.Init(logfile);
            Log4NetLogger k = new Log4NetLogger();
            k.Log("this is a debug log...", LogType.Debug);
            Console.ReadLine();

        }
    }
}
