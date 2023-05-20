using GPUPreferences.Model;
using GPUPreferences.Model.ContextMenuSettings;
using Microsoft.Win32;

namespace GPUPreferences.Services.ContextMenuServices
{
    // TODO: OpenSubkey and CreateSubkey must be close() after work
    internal class ContextMenuRegistryService
    {
        const string SubKeyBaseName = "GPUPreferences";
        private readonly string PathOfThisExefile = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private readonly RegistryKey BaseWorkDir = Registry.ClassesRoot.OpenSubKey($"exefile\\shell\\", true);

        public void AddAppToContextMenu(AllSettings settings)
        {
            if (settings.AutoMode)
            {
                AddModeToContextMenu(settings, PrefState.Auto);
            }
            else
            {
                DeleteModeFromRegistry(PrefState.Auto);
            }

            if (settings.PowerSavingMode)
            {
                AddModeToContextMenu(settings, PrefState.PowerSaving);
            }
            else
            {
                DeleteModeFromRegistry(PrefState.PowerSaving);
            }

            if (settings.HighPerformanceMode)
            {
                AddModeToContextMenu(settings, PrefState.HighPerformance);
            }
            else
            {
                DeleteModeFromRegistry(PrefState.HighPerformance);
            }
        }

        private string GetSubKeyModeName(PrefState mode)
        {
            return $"{SubKeyBaseName}{mode}";
        }

        private void AddModeToContextMenu(AllSettings settings, PrefState mode)
        {
            RegistryKey workDir = BaseWorkDir.CreateSubKey(GetSubKeyModeName(mode), true);
            workDir.SetValue("MUIverb", $"{settings.Title} {mode}");

            if (settings.Position is PositionOptions.None)
            {
                workDir.DeleteValue("Position", false);
            }
            else
            {
                workDir.SetValue("Position", settings.Position.ToString());
            }

            if (settings.Extended)
            {
                workDir.SetValue("Extended", "");
            }
            else
            {
                workDir.DeleteValue("Extended", false);
            }

            workDir = workDir.CreateSubKey("command", true);
            workDir.SetValue("", $"{PathOfThisExefile} {(int)mode} \"%1\"");
        }

        public void DeleteModeFromRegistry(PrefState mode)
        {
            BaseWorkDir.DeleteSubKeyTree(GetSubKeyModeName(mode), false);
        }

        public void DeleteAppFromRegistry()
        {
            for (int i = 0; i < 3;  i++)
            {
                DeleteModeFromRegistry((PrefState)i);
            }
        }
    }
}
