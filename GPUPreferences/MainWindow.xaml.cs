using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using GPUPreferences.Model;
using GPUPreferences.Services;

namespace GPUPreferences
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Pref> data = new ObservableCollection<Pref> { };
        public MainWindow()
        {
            InitializeComponent();
            // Must be moved in Services
            RegistryTools.ReadRegistry(data);
            PreferencesDataGrid.ItemsSource = data;

        }

        private void LoadCurrentPreferences_Click(object sender, RoutedEventArgs e)
        {
            RegistryTools.ReadRegistry(data);
        }

        private void CheckNonExists_Click(object sender, RoutedEventArgs e)
        {
            Checker.CheckNonExist(data);
        }

        private void ChooseAll_Click(object sender, RoutedEventArgs e)
        {
            Checker.CheckAllOrNone(data);
        }

        private void DeleteChoosen_Click(object sender, RoutedEventArgs e)
        {
            DeleteChecked.DeleteCheckedFromRegister(data);
        }
    }
}
