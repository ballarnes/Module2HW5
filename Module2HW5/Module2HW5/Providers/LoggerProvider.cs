using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Providers.Abstractions;
using Module2HW5.Enums;

namespace Module2HW5.Providers
{
    public class LoggerProvider : ILoggerProvider
    {
        public LoggerProvider()
        {
            Log = new StringBuilder();
        }

        public StringBuilder Log { get; set; }
    }
}
