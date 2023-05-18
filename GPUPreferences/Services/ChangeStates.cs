using GPUPreferences.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GPUPreferences.Services
{
    internal class ChangeStates
    {
        public static void ChangePreferencesStates(PrefStateForCB neededPrefState, ObservableCollection<Pref> data)
        {
            foreach (Pref el in data)
            {
                if (el.Check)
                {
                    el.State = neededPrefState.PreferencesState;
                }
            }
        }
    }
}
