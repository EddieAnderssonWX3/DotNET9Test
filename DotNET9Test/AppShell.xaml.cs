using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Models.Tabs;
using DotNET9Test.Popups.MoreTabs;
using DotNET9Test.Services;
using DotNET9Test.ViewModels;
using DotNET9Test.Views;
using DotNET9Test.Views.ActiveCalls;
using DotNET9Test.Views.Callbacks;
using DotNET9Test.Views.CallLogs;
using DotNET9Test.Views.CallProfiles;
using DotNET9Test.Views.Contacts;
using DotNET9Test.Views.Messages;
using DotNET9Test.Views.RecordedCalls;
using DotNET9Test.Views.Settings;
using DotNET9Test.Views.Tabs;
using DotNET9Test.Views.Voicemails;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using SimpleToolkit.SimpleShell;
using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace DotNET9Test
{
    public partial class AppShell : SimpleToolkit.SimpleShell.SimpleShell
    {
        public AppShellViewModel AppShellViewModel;
        public string MyTitle = "";
        public ObservableCollection<BaseShellItem> VisibleTabs { get; } = new();
        public AppShell()
        {
            InitializeComponent();
            AppShellViewModel = new AppShellViewModel(this);
            AppShellService.AppShellViewModel = AppShellViewModel;
            BindingContext = AppShellViewModel;
            Routing.RegisterRoute(nameof(ActiveCallsDetailsPage), typeof(ActiveCallsDetailsPage));
            Routing.RegisterRoute(nameof(ContactDetailsPage), typeof(ContactDetailsPage));

            List<ShellContent> tabs = TabService.GenerateTabs();
            TabService.GenerateMoreTabs();
            
            VisibleTabs.Add(ContactsSpecialTab);
            for (int i = 0; i < tabs.Count; i++)
            {
                VisibleTabs.Add(tabs[i]);

                if(tabs[i].Route == "MoreTabsPage")
                {
                    break;
                }
            }

            foreach (ShellContent tab in tabs)
            {
                AddShellContent(tab);
            }
        }

        private void AddShellContent(ShellContent tab)
        {
            thisShell.Items.Add(tab);  // Add to the Shell
        }

        public void DisplayMoreTabs()
        {
            // MAUI TOOLKIT POPUP ( HARD TO PLACE ANCHOR )
            MoreTabsPopup moreTabsPopup = new(tabBar);
            if (moreTabsPopup != null)
            {
                this.ShowPopup(moreTabsPopup);
            }

            // BOTTOM SHEET 49 ( NOT WORKING IN DOT NET 9 )
            /*var bottomMoreTabs = new BottomMoreTabs();

            // Show the sheet
            bottomMoreTabs.ShowAsync();*/
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);
            if (thisShell != null)
            {
                var tabbItem = thisShell.CurrentItem?.CurrentItem?.CurrentItem;
                if (tabbItem != null)
                {
                    var route = tabbItem.Route;
                    if (route == nameof(ContactsPage) || route == nameof(SettingsPage) || route == nameof(LoadingPage))
                    {
                        tabbItem.IsEnabled = false;
                        var specialRouteItem = thisShell.CurrentItem?.CurrentItem;
                        if (specialRouteItem != null)
                        {
                            var specialRoute = specialRouteItem.Route;
                            if (TabService.TabbarIconsMap.TryGetValue(specialRoute, out var specialRouteIcons))
                            {
                                specialRouteItem.Icon = specialRouteIcons.UnselectedIcon;
                            }
                        }
                    }
                    else
                    {
                        if (TabService.TabbarIconsMap.TryGetValue(route, out var icons))
                        {
                            tabbItem.Icon = icons.UnselectedIcon;
                        }
                    }
                }
            }
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);
            if (thisShell != null)
            {
                var tabbItem = thisShell.CurrentItem?.CurrentItem?.CurrentItem;
                if (tabbItem != null)
                {
                    var route = tabbItem.Route;

                    if (route == nameof(ContactsPage) || route == nameof(SettingsPage) || route == nameof(LoadingPage))
                    {
                        tabbItem.IsEnabled = true;
                        var specialRouteItem = thisShell.CurrentItem?.CurrentItem;
                        if(specialRouteItem != null)
                        {
                            var specialRoute = specialRouteItem.Route;
                            if (TabService.TabbarIconsMap.TryGetValue(specialRoute, out var specialRouteIcons))
                            {
                                specialRouteItem.Icon = specialRouteIcons.SelectedIcon;
                            }
                        }
                    }
                    else
                    {
                        if (TabService.TabbarIconsMap.TryGetValue(route, out var icons))
                        {
                            tabbItem.Icon = icons.SelectedIcon;
                        }
                    }
                }
            }
        }

        public async Task ReOrderTabBar()
        {
            List<BaseShellItem> yasd = VisibleTabs.ToList();
            List<BaseShellItem> reversedPart = yasd.GetRange(0, yasd.Count - 1);
            reversedPart.Reverse();
            for (int i = 0; i < reversedPart.Count; i++)
            {
                VisibleTabs[i] = reversedPart[i];
            }
        }
    }
}
