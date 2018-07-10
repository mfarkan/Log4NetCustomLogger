using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLog4netLibrary
{
    public interface ILogger
    {
        void Log(string Message);
        void Log(string Message, LogType LogType);
        void Log(string Message, LogType LogType, Exception exception);
    }
    public enum LogType
    {
        Information = 1,
        Warning = 2,
        Error = 3,
        Debug = 4
    }

}
