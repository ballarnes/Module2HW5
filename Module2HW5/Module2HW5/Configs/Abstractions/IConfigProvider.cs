﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Configs.Abstractions
{
    public interface IConfigProvider
    {
        public Config Init();
    }
}
