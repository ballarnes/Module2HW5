using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Exceptions
{
    public class WarningInLogException : Exception
    {
        public WarningInLogException(string message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
