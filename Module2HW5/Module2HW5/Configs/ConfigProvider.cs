using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Module2HW5.Configs.Abstractions;
using Newtonsoft.Json;

namespace Module2HW5.Configs
{
    public class ConfigProvider : IConfigProvider
    {
        public Config Init()
        {
            var configFile = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
            return config;
        }
    }
}
