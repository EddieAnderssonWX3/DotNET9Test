using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Models.Contacts;
using DotNET9Test.Popups.MoreTabs;
using DotNET9Test.Views;
using DotNET9Test.Views.Contacts;
using DotNET9Test.Views.Settings;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using SimpleToolkit.SimpleShell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels
{
    public partial class AppShellViewModel : ObservableObject
    {
        [ObservableProperty]
        public string topNavBarTitle = "";

        [ObservableProperty]
        public bool showLoadingBar = true;
        
        [ObservableProperty]
        public bool showCallWindow = true;

        [ObservableProperty]
        public string loadingBarText = "Loading...";

        [ObservableProperty]
        public bool showUser = false;

        [ObservableProperty]
        public bool showNavBack = false;

        [ObservableProperty]
        public bool showExtraButtonOne = false;

        [ObservableProperty]
        public string extraButtonOneIcon = "";

        [ObservableProperty]
        public Command extraButtonOneCommand = new Command(() => { });

        [ObservableProperty]
        public object? extraButtonOneCommandParam = null;

        [ObservableProperty]
        public bool showExtraButtonTwo = false;

        [ObservableProperty]
        public string extraButtonTwoIcon = "";

        [ObservableProperty]
        public Command extraButtonTwoCommand = new Command(() => { });

        [ObservableProperty]
        public object? extraButtonTwoCommandParam = null;

        [ObservableProperty]
        public MyUser myUser = new("Eddie", "dotnet_bot.png");

        private AppShell MyAppShell;

        public List<ShellContent> MainTabs = new();
        public List<ShellContent> MoreTabs = new();

        public AppShellViewModel(AppShell myAppShell)
        {
            MyAppShell = myAppShell;
        }
        public void UpdateShellTopNavBar(string title, bool mainPage, string? extraButtonOneIcon = null, Command? extraButtonOneCommand = null, string? extraButtonTwoIcon = null, Command? extraButtonTwoCommand = null)
        {
            TopNavBarTitle = title;
            ShowUser = mainPage;
            ShowNavBack = !mainPage;

            if (!string.IsNullOrEmpty(extraButtonOneIcon) && extraButtonOneCommand != null)
            {
                ExtraButtonOneIcon = extraButtonOneIcon;
                ExtraButtonOneCommand = extraButtonOneCommand;
                ShowExtraButtonOne = true;
            } else
            {
                ExtraButtonOneIcon = "";
                ExtraButtonOneCommand = new Command(() => { });
                ShowExtraButtonOne = false;
            }

            if (!string.IsNullOrEmpty(extraButtonTwoIcon) && extraButtonTwoCommand != null)
            {
                ExtraButtonTwoIcon = extraButtonTwoIcon;
                ExtraButtonTwoCommand = extraButtonTwoCommand;
                ShowExtraButtonTwo = true;
            }
            else
            {
                ExtraButtonTwoIcon = "";
                ExtraButtonTwoCommand = new Command(() => { });
                ShowExtraButtonTwo = false;
            }
        }

        [RelayCommand]
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task GoToRoute(string route)
        {
            if (Shell.Current.CurrentItem.CurrentItem.CurrentItem.Route != route && Shell.Current.CurrentItem.CurrentItem.Route != route)
            {
                await Shell.Current.GoToAsync($"///{route}");
            }
        }

        [RelayCommand]
        public async Task GoToMyUser()
        {
            await Shell.Current.GoToAsync($"{nameof(ContactDetailsPage)}", true);
        }
        
        [RelayCommand]
        public async Task DisplayMoreTabs()
        {
            await Shell.Current.GoToAsync($"{nameof(ContactDetailsPage)}", true);
        }

        public void ToggleLoadingBar(bool state)
        {
            ShowLoadingBar = state;
        }

        public void SetLoadingBarText(string text)
        {
            LoadingBarText = text;
        }
        
        public void ToggleCallWindow(bool state)
        {
            ShowCallWindow = state;
        }
    }
}
