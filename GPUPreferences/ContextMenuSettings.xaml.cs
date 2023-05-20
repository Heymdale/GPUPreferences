using GPUPreferences.Model.ContextMenuSettings;
using GPUPreferences.Services.ContextMenuServices;
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
using System.Windows.Shapes;

namespace GPUPreferences
{
    /// <summary>
    /// Interaction logic for ContextMenuSettings.xaml
    /// </summary>
    public partial class ContextMenuSettings : Window
    {
        private AllSettings AllSettings = new AllSettings();

        public ContextMenuSettings()
        {
            InitializeComponent();
            DataContext = AllSettings;
        }

        private void ApplySettingsToRegistry_Click(object sender, RoutedEventArgs e)
        {
            ContextMenuRegistryService registryHandler = new ContextMenuRegistryService();
            registryHandler.AddAppToContextMenu(AllSettings);
        }

        private void DeleteAppFromRegistry_Click(object sender, RoutedEventArgs e)
        {
            ContextMenuRegistryService registryService = new ContextMenuRegistryService();
            registryService.DeleteAppFromRegistry();
        }
    }
}
