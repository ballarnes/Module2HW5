using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Enums;

namespace Module2HW5.Services.Abstractions
{
    public interface ILoggerService
    {
        public void Write(LogType logType, string message);
        public void Write(LogType logType, string message, Exception exception);
    }
}
