using System.Collections.ObjectModel;
using GPUPreferences.Model;

namespace GPUPreferences.Services
{
    public class Checker
    {
        public static void CheckNonExist(ObservableCollection<Pref> data)
        {
            foreach (Pref el in data)
            {
                if (FileWorks.IsFileExist(el.Address))
                {
                    el.Check = false;
                }
                else
                {
                    el.Check = true;
                }
            }
            return;
        }

        private static void CheckAll(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = true;
            }
            return;
        }

        private static void CheckNone(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = false;
            }
            return;
        }

        public static void CheckAllOrNone(ObservableCollection<Pref> data)
        {
            foreach (Pref el in data)
            {
                if (!el.Check)
                {
                    CheckAll(data);
                    return;
                }
            }
            CheckNone(data);
            return;
        }

        public static void InvertAllChecks(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = !el.Check;
            }
            return;
        }
    }
}
