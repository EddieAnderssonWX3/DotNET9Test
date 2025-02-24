using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.ViewModels.Contacts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Settings
{
    public partial class SettingsPageViewModel : ObservableObject
    {
        readonly IServiceProvider ServiceProvider;
        public SettingsPageViewModel(IServiceProvider serviceProvider) 
        {
            ServiceProvider = serviceProvider;
        }

        [RelayCommand]
        public async Task ReOrderAppShellTabBar()
        {
            if (Shell.Current is AppShell shell)
            {

                await shell.ReOrderTabBar();

                for (var i = 0; i < 100; i++)
                {
                    ServiceProvider.GetService<ContactsPageViewModel>()?.ContactModels.Add(new(i + 3, i + 3, i + 3, "caller " + i + 3, "reciver " + i + 3));
                }
            }
        }
    }
}
