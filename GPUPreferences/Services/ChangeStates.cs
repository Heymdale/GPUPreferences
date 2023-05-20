using GPUPreferences.Model;
using System.Collections.ObjectModel;

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
