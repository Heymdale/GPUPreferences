using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GPUPreferences.Model;


namespace GPUPreferences.Services
{
    internal class DeleteChecked
    {
        public static ObservableCollection<Pref> DeleteCheckedFromRegister(ObservableCollection<Pref> data)
        {
            ObservableCollection<Pref> newData = new ObservableCollection<Pref>();
            foreach (var el in data)
            {
                if (el.Check)
                {
                    RegistryTools.DeleteRegKey(el.Address);
                }
                else
                {
                    newData.Add(el);
                }
            }
            data = newData;
            return data;
        }
    }
}
