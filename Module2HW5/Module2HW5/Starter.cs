using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Configs.Abstractions;
using Module2HW5.Services.Abstractions;
using Module2HW5.Providers.Abstractions;
using Module2HW5.Exceptions;
using Module2HW5.Enums;

namespace Module2HW5
{
    public class Starter
    {
        private readonly IConfigProvider _configProvider;
        private readonly IActionsService _actionsService;
        private readonly ILoggerProvider _loggerProvider;
        private readonly ILoggerService _loggerService;
        private readonly IFileService _fileService;
        public Starter(IConfigProvider configProvider, IActionsService actionsService, ILoggerProvider loggerProvider, ILoggerService loggerService, IFileService fileService)
        {
            _configProvider = configProvider;
            _actionsService = actionsService;
            _loggerProvider = loggerProvider;
            _loggerService = loggerService;
            _fileService = fileService;
        }

        public void Run()
        {
            for (var i = 0; i < 100; i++)
            {
                byte method = (byte)new Random().Next(1, 4);
                try
                {
                    switch (method)
                    {
                        case 1:
                            _actionsService.InformationCheck();
                            break;
                        case 2:
                            _actionsService.WarningCheck();
                            break;
                        case 3:
                            _actionsService.ErrorCheck();
                            break;
                    }
                }
                catch (WarningInLogException exception)
                {
                    _loggerService.Write(LogType.Warning, $"Action got this custom Exception: {exception.Message}");
                }
                catch (Exception exception)
                {
                    _loggerService.Write(LogType.Error, $"Action failed by reason:", exception);
                }
            }

            _fileService.SaveInFile(_configProvider.Init().Logger.DirectoryPath, $"{DateTime.Now.ToString(_configProvider.Init().Logger.TimeFormat)}{_configProvider.Init().Logger.FileExtension}", _loggerProvider.Log.ToString());
        }
    }
}
