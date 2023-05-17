using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace GPUPreferences.Model
{
    public class Pref : DependencyObject
    {
        public string Address {
            get { return (string)GetValue(AddressProperty); } 
            set { SetValue(AddressProperty, value); } 
        }
        public static readonly DependencyProperty AddressProperty =
        DependencyProperty.Register(nameof(Address), typeof(string), typeof(Pref), new PropertyMetadata(""));

        public PrefState State
        {
            get { return (PrefState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }
        public static readonly DependencyProperty StateProperty =
        DependencyProperty.Register(nameof(State), typeof(PrefState), typeof(Pref), new PropertyMetadata(null));

        public bool Check
        {
            get { return (bool)GetValue(CheckProperty); }
            set { SetValue(CheckProperty, value); }
        }
        public static readonly DependencyProperty CheckProperty =
        DependencyProperty.Register(nameof(Check), typeof(bool), typeof(Pref), new PropertyMetadata(false));
    }
}
