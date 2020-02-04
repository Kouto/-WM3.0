using NLog;
using NLog.Common;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    public static class Logger
    {
        public readonly static NLog.Logger logCalculator = null;

        static Logger()
        {
            InternalLogger.LogToConsole = false;
            //InternalLogger.LogFile = Directory.GetCurrentDirectory() + "/logs/nlog_sql.log";
            InternalLogger.LogFile = Directory.GetCurrentDirectory() + "\\logs\\nlog.log";
            InternalLogger.LogWriter = new StringWriter();
            InternalLogger.LogLevel = LogLevel.Info;
            InternalLogger.IncludeTimestamp = true;

            FileTarget file = new FileTarget()
            {
                FileName = "${basedir}/logs/${shortdate}.log",
                Layout = "${longdate} | ${pad:padding=-12:inner=${logger}} | ${pad:padding=-5:inner=${uppercase:${level}}} | ${message} => ${callsite} ${onexception: ${newline} ${exception:format=toString,Data}}",
                MaxArchiveFiles = 31,
                // this speeds up things when no other processes are writing to the file
                ConcurrentWrites = false, // true
                Encoding = Encoding.GetEncoding(1251),
            };

            /*LoggerTarget tar1 = new LoggerTarget()
            {
                Layout = "${longdate} | ${pad:padding=-20:inner=${logger}} | ${pad:padding=-5:inner=${uppercase:${level}}} | ${message} => ${callsite} ${onexception: ${newline} ${exception:format=toString,Data}}",
                Name = "tar1",
            };*/

            //NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(tar1, LogLevel.Debug);
            NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(file, LogLevel.Debug);

            logCalculator = LogManager.GetLogger("Calculator");
        }

    }
}
