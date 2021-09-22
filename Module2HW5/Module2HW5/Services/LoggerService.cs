using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Services.Abstractions;
using Module2HW5.Providers.Abstractions;
using Module2HW5.Configs.Abstractions;
using Module2HW5.Enums;
using Module2HW5.Providers;
using Module2HW5.Configs;

namespace Module2HW5.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILoggerProvider _loggerProvider;
        private readonly IConfigProvider _configProvider;

        public LoggerService(ILoggerProvider loggerProvider, IConfigProvider configProvider)
        {
            _loggerProvider = loggerProvider;
            _configProvider = configProvider;
        }

        public void Write(LogType logType, string message)
        {
            var log = $"{DateTime.Now.ToString(_configProvider.Init().Logger.TimeFormat)}: {logType}: {message}";
            Console.WriteLine(log);
            _loggerProvider.Log.AppendLine(log);
        }

        public void Write(LogType logType, string message, Exception exception)
        {
            var log = $"{DateTime.Now.ToString(_configProvider.Init().Logger.TimeFormat)}: {logType}: {message} {exception}";
            Console.WriteLine(log);
            _loggerProvider.Log.AppendLine(log);
        }
    }
}
