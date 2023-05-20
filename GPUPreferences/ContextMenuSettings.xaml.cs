using GPUPreferences.Model.ContextMenuSettings;
using GPUPreferences.Services.ContextMenuServices;
using System.Windows;

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
