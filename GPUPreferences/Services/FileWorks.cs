using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUPreferences.Services
{
    public class FileWorks
    {
        public static bool IsFileExist(string address)
        {
            bool result = File.Exists(address);
            return result;
        }
    }
}
