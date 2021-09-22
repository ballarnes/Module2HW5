using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module2HW5.Helpers
{
    public class FileComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo f1, FileInfo f2)
        {
            if (f1.CreationTime < f2.CreationTime)
            {
                return 1;
            }
            else if (f1.CreationTime > f2.CreationTime)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
