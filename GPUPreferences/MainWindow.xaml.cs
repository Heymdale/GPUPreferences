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

namespace GPUPreferences
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var data = RegistryTools.ReadRegistry();
            PreferencesDataGrid.ItemsSource = data;
        }

        private void LoadCurrentPreferences_Click(object sender, RoutedEventArgs e)
        {
            var data = RegistryTools.ReadRegistry();
            PreferencesDataGrid.ItemsSource = data;
        }
    }
}
