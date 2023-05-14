using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace GPUPreferences.Model
{
    public class PrefCollection : INotifyPropertyChanged
    {
        private ObservableCollection<Pref> preferences;

        public ObservableCollection<Pref> Preferences 
        { 
            get { return preferences; }
            set 
            { 
                preferences = value;
                OnPropertyChanged("Preferences");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
