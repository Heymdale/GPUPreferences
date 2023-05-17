using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GPUPreferences.Model;
using Microsoft.Xaml.Behaviors.Core;

namespace GPUPreferences.Services
{
    internal class DeleteChecked
    {
        public static void DeleteCheckedFromRegister(ObservableCollection<Pref> data)
        {
            for (var i=0 ; i < data.Count; i++)
            {
                if (data[i].Check)
                {
                    RegistryTools.DeleteRegKey(data[i].Address);
                    data.RemoveAt(i);
                    i--;
                }
            }
            return;
        }
    }
}
