using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Module2HW5.Services.Abstractions;
using Module2HW5.Configs.Abstractions;
using Module2HW5.Providers.Abstractions;

namespace Module2HW5.Services
{
    public class FileService : IFileService
    {
        public void SaveInFile(string path, string name, string text)
        {
            File.WriteAllText($"{path}{name}", text);
        }
    }
}
