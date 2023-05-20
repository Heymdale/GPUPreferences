using GPUPreferences.Model;
using GPUPreferences.Services;
using System;
using System.Windows;

namespace GPUPreferences
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                PrefState prefState = (PrefState)Convert.ToInt32(e.Args[0]);
                string path = e.Args[1];
                RegistryTools.ChangeRegValue(prefState, path);
                Current.Shutdown();
            }
            else 
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
