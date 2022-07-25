using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GPUPreferences
{
    public class RegistryTools
    {
        public static List<Pref> ReadRegistry()
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey neededDirectory = HKCU.OpenSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences");
            List<Pref> data = new List<Pref>();
            foreach (var address in neededDirectory.GetValueNames())
            {
                string state_text = neededDirectory.GetValue(address).ToString();
                int state = Convert.ToInt32(state_text.Substring(state_text.Length - 2,1));

                data.Add(new Pref() { Address = address, State = (PrefState)state, Check = false});
            }
            return data;
        }

        public static void DeleteRegKey(string key)
        {

        }
    }
}
