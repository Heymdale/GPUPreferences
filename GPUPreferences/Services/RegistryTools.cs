using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using GPUPreferences.Model;

namespace GPUPreferences.Services
{
    public class RegistryTools
    {
        public static ObservableCollection<Pref> ReadRegistry()
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey neededDirectory = HKCU.OpenSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences");
            ObservableCollection<Pref> data = new ObservableCollection<Pref>();
            foreach (var address in neededDirectory.GetValueNames())
            {
                string state_text = neededDirectory.GetValue(address).ToString();
                int state = Convert.ToInt32(state_text.Substring(state_text.Length - 2, 1));

                data.Add(new Pref() { Address = address, State = (PrefState)state, Check = false });
            }
            return data;
        }

        public static void DeleteRegKey(string key)
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey neededDirectory = HKCU.OpenSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences", true);
            neededDirectory.DeleteValue(key, true);
        }
    }
}
