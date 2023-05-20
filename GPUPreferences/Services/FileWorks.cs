using System.IO;

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
