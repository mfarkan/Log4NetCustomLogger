using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomLog4netLibrary
{
    public class Log4NetLogger : ILogger
    {
        public static void Init(string logfile)
        {
            if (string.IsNullOrEmpty(logfile))
            {
                logfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
            }
            XmlConfigurator.Configure(new FileInfo(logfile));
        }
        public void Log(string Message)
        {
            this.Log(string.Empty, Message, LogType.Information, null);
        }

        public void Log(string Message, LogType LogType)
        {
            this.Log(string.Empty, Message, LogType, null);
        }

        public void Log(string Message, LogType LogType, Exception exception)
        {
            this.Log(string.Empty, Message, LogType, exception);
        }
        public void Log(string LogName, string Message, LogType LogType, Exception exception)
        {
            ILog log = string.IsNullOrWhiteSpace(LogName) ? LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType) : LogManager.GetLogger(LogName);
            switch (LogType)
            {
                case LogType.Information:
                    log.Info(Message, exception);
                    break;
                case LogType.Warning:
                    log.Warn(Message, exception);
                    break;
                case LogType.Error:
                    log.Error(Message, exception);
                    break;
                case LogType.Debug:
                    log.Debug(Message, exception);
                    break;
                default:
                    log.Debug(Message, exception);
                    break;
            }

        }
    }
}
