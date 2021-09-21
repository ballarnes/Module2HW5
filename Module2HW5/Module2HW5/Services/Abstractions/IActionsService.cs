using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW5.Exceptions;

namespace Module2HW5.Services.Abstractions
{
    public interface IActionsService
    {
        public bool InformationCheck();
        public bool WarningCheck();
        public bool ErrorCheck();
    }
}
