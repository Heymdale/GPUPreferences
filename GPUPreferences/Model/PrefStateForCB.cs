using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GPUPreferences.Model
{
    public class PrefStateForCB : DependencyObject
    {
        public PrefState PreferencesState
        {
            get { return (PrefState)GetValue(PreferencesStateProperty); }
            set { SetValue(PreferencesStateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PreferencesState.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PreferencesStateProperty =
            DependencyProperty.Register(nameof(PreferencesState), typeof(PrefState), typeof(PrefStateForCB), new PropertyMetadata((PrefState)0));
    }
}
