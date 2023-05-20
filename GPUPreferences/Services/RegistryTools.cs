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
        private static readonly RegistryKey HKCU = Registry.CurrentUser;
        private static readonly RegistryKey writableDirectory = HKCU.OpenSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences", true);
        private static readonly RegistryKey readonlyDirectory = HKCU.OpenSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences");

        public static void ReadRegistry(ObservableCollection<Pref> data)
        {
            data.Clear();
            foreach (var address in readonlyDirectory.GetValueNames())
            {
                string state_text = readonlyDirectory.GetValue(address).ToString();
                int state = Convert.ToInt32(state_text.Substring(state_text.Length - 2, 1));

                data.Add(new Pref() { Address = address, State = (PrefState)state, Check = false });
            }
            return;
        }

        public static void DeleteRegKey(string key)
        {
            writableDirectory.DeleteValue(key, true);
        }

        public static void ChangeRegKey(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                ChangeRegValue(el.State, el.Address);
            }
        }

        public static void ChangeRegValue(PrefState state, string address)
        {
            string regPrefState = $"GpuPreference={(int)state};";
            writableDirectory.SetValue(address, regPrefState);
        }
    }
}
