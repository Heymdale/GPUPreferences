using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUPreferences
{
    public class FileWorks
    {
        public static bool IsFileExist(string address)
        {
            bool result = File.Exists(address);
            return result;
        }

        public static void SaveRegFile(string filename)
        {

        }

        public static List<string> ReadRegFile(string filename)
        {
            return null;
        }
    }
}
