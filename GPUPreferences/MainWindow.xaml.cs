using System.Windows;
using System.Collections.ObjectModel;
using GPUPreferences.Model;
using GPUPreferences.Services;

namespace GPUPreferences
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Pref> data = new ObservableCollection<Pref> { };
        PrefStateForCB preferencesState = new PrefStateForCB();
        public MainWindow()
        {
            InitializeComponent();
            PreferencesComboBox.DataContext = preferencesState;
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

        private void InvertChoosen_Click(object sender, RoutedEventArgs e)
        {
            Checker.InvertAllChecks(data);
        }

        private void DeleteChoosen_Click(object sender, RoutedEventArgs e)
        {
            DeleteChecked.DeleteCheckedFromRegister(data);
        }

        private void SetPreferencesToChecked_Click(object sender, RoutedEventArgs e)
        {
            ChangeStates.ChangePreferencesStates(preferencesState, data);
        }

        private void ApplyToRegistry_Click(object sender, RoutedEventArgs e)
        {
            RegistryTools.ChangeRegKey(data);
        }

        private void AddAppToContextMenu_Click(object sender, RoutedEventArgs e)
        {
            ContextMenuSettings settingsWindow =  new ContextMenuSettings();
            settingsWindow.Show();
        }
    }
}
