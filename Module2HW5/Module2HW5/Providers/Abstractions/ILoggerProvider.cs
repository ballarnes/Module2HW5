using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Enums;

namespace Module2HW5.Providers.Abstractions
{
    public interface ILoggerProvider
    {
        public StringBuilder Log { get; set; }
    }
}
