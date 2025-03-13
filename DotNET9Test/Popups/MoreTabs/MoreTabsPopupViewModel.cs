using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Services;
using DotNET9Test.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.Popups.MoreTabs
{
    public partial class MoreTabsPopupViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<MoreTab> moreTabs = new();

       /* [ObservableProperty]
        public ObservableCollection<string> testTabs = new() { "EDDIE", "ADAM" };*/

        public MoreTabsPopupViewModel()
        {
            foreach (MoreTab moreTab in TabService.MoreTabs)
            {
                MoreTabs.Add(new("EDDIE", "", "", typeof(LoadingPage)));
            }
        }
    }
}
