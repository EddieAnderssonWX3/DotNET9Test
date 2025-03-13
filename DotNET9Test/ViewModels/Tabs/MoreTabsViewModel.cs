using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Tabs
{
    public partial class MoreTabsViewModel : ObservableObject
    {
        public ObservableCollection<MoreTab> MoreTabs { get; set; }

        public MoreTabsViewModel()
        {
            MoreTabs = new(TabService.MoreTabs);
        }

        [RelayCommand]
        public async Task GoToRoute(string route)
        {
            if (Shell.Current.CurrentItem.CurrentItem.CurrentItem.Route != route && Shell.Current.CurrentItem.CurrentItem.Route != route)
            {
                await Shell.Current.GoToAsync($"///{route}");
            }
        }
    }
}
