using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Services.Abstractions;
using Module2HW5.Providers.Abstractions;
using Module2HW5.Enums;
using Module2HW5.Exceptions;

namespace Module2HW5.Services
{
    public class ActionsService : IActionsService
    {
        private readonly ILoggerService _loggerService;
        public ActionsService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public bool InformationCheck()
        {
            _loggerService.Write(LogType.Info, $"Start method: {nameof(InformationCheck)}.");
            return true;
        }

        public bool WarningCheck()
        {
            throw new WarningInLogException("Skipped logic in method.");
        }

        public bool ErrorCheck()
        {
            throw new Exception("I broke a logic.");
        }
    }
}
