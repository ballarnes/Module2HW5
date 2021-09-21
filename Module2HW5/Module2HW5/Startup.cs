using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Module2HW5.Configs.Abstractions;
using Module2HW5.Configs;
using Module2HW5.Services.Abstractions;
using Module2HW5.Services;
using Module2HW5.Providers.Abstractions;
using Module2HW5.Providers;

namespace Module2HW5
{
    public class Startup
    {
        public void Start()
        {
            var serviceProvider = new ServiceCollection()
                            .AddSingleton<IConfigProvider, ConfigProvider>()
                            .AddSingleton<ILoggerService, LoggerService>()
                            .AddSingleton<ILoggerProvider, LoggerProvider>()
                            .AddTransient<IActionsService, ActionsService>()
                            .AddTransient<IFileService, FileService>()
                            .AddTransient<Starter>()
                            .BuildServiceProvider();

            var appStart = serviceProvider.GetService<Starter>();
            appStart.Run();
        }
    }
}
