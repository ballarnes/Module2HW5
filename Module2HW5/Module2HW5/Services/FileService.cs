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
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.WriteAllText($"{path}{name}", text);
            }
            else
            {
                File.WriteAllText($"{path}{name}", text);
                string[] files = Directory.GetFiles(path);
                if (files.Length > 3)
                {
                    Array.Sort(files);
                    for (var i = 0; i < files.Length - 3; i++)
                    {
                        File.Delete(files[i]);
                    }
                }
            }
        }
    }
}
