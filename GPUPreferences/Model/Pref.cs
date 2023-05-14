using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GPUPreferences.Model
{
    public class Pref
    {
        public string Address { get; set; }
        public PrefState State { get; set; }
        public bool Check { get; set; }
    }
    //public class Pref : INotifyPropertyChanged
    //{
    //    private string address;
    //    private PrefState state;
    //    private bool check;

    //    public string Address
    //    {
    //        get { return address; }
    //        set
    //        {
    //            address = value;
    //            OnPropertyChanged("Address");
    //        }
    //    }

    //    public PrefState State
    //    {
    //        get { return state; }
    //        set
    //        {
    //            state = value;
    //            OnPropertyChanged("State");
    //        }
    //    }

    //    public bool Check
    //    {
    //        get { return check; }
    //        set
    //        {
    //            check = value;
    //            OnPropertyChanged("Check");
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName] string prop = "")
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
}
