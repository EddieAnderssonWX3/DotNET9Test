using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Settings
{
    public partial class SettingsPageViewModel : ObservableObject
    {
        public SettingsPageViewModel() { }

        [RelayCommand]
        public async Task ReOrderAppShellTabBar()
        {
            if (Shell.Current is AppShell shell)
            {
                await shell.ReOrderTabBar();
            }
        }
    }
}
