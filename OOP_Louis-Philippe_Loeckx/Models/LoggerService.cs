using System;
using System.Linq;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;


        static LoggerService()
        {
            logs = new LogMessage[0];
            
        }

        public static void AddLogMessage(LogMessage message)
        {
            int length = logs.Length;
            logs.Append(message);
            Array.Resize(ref logs, length + 1 );

        }
    }
}
