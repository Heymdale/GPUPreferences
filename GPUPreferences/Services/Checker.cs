using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using GPUPreferences.Model;

namespace GPUPreferences.Services
{
    public class Checker
    {
        public static ObservableCollection<Pref> CheckNonExist(ObservableCollection<Pref> data)
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
            return data;
        }

        private static ObservableCollection<Pref> CheckAll(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = true;
            }
            return data;
        }

        private static ObservableCollection<Pref> CheckNone(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = false;
            }
            return data;
        }

        public static ObservableCollection<Pref> CheckAllOrNone(ObservableCollection<Pref> data)
        {
            foreach (Pref el in data)
            {
                if (!el.Check)
                {
                    return CheckAll(data);
                }
            }
            return CheckNone(data);
        }

        public static ObservableCollection<Pref> InvertAllChecks(ObservableCollection<Pref> data)
        {
            foreach (var el in data)
            {
                el.Check = !el.Check;
            }
            return data;
        }
    }
}
