using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GPUPreferences.Model.ContextMenuSettings
{
    internal class AllSettings : DependencyObject
    {
        public PositionOptions Position
        {
            get { return (PositionOptions)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PositionProperty  =
            DependencyProperty.Register(nameof(Position), typeof(PositionOptions), typeof(AllSettings), new PropertyMetadata((PositionOptions)0));


        public bool Extended
        {
            get { return (bool)GetValue(ExtendedProperty); }
            set { SetValue(ExtendedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExtendedProperty =
            DependencyProperty.Register(nameof(Extended), typeof(bool), typeof(AllSettings), new PropertyMetadata(false));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(AllSettings), new PropertyMetadata("Set app mode to"));


        public bool AutoMode
        {
            get { return (bool)GetValue(AutoModeProperty); }
            set { SetValue(AutoModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AutoMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoModeProperty =
            DependencyProperty.Register(nameof(AutoMode), typeof(bool), typeof(AllSettings), new PropertyMetadata(false));


        public bool PowerSavingMode
        {
            get { return (bool)GetValue(PowerSavingModeProperty); }
            set { SetValue(PowerSavingModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PowerSavingMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PowerSavingModeProperty =
            DependencyProperty.Register(nameof(PowerSavingMode), typeof(bool), typeof(AllSettings), new PropertyMetadata(true));


        public bool HighPerformanceMode
        {
            get { return (bool)GetValue(HighPerformanceModeProperty); }
            set { SetValue(HighPerformanceModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HighPerformanceMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HighPerformanceModeProperty =
            DependencyProperty.Register(nameof(HighPerformanceMode), typeof(bool), typeof(AllSettings), new PropertyMetadata(true));
    }
}
