using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Views;
using DotNET9Test.Views.ActiveCalls;
using DotNET9Test.Views.Callbacks;
using DotNET9Test.Views.CallLogs;
using DotNET9Test.Views.Contacts;
using DotNET9Test.Views.Messages;
using DotNET9Test.Views.RecordedCalls;
using DotNET9Test.Views.Settings;
using DotNET9Test.Views.Tabs;
using DotNET9Test.Views.Voicemails;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using SimpleToolkit.SimpleShell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DotNET9Test.Services
{
    public class TabService
    {
        public static List<MoreTab> MoreTabs = new();

        public static Dictionary<string, (ImageSource SelectedIcon, ImageSource UnselectedIcon)> TabbarIconsMap = new()
        {
            [nameof(ActiveCallsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(CallLogsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(MessagesPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(RecordedCallsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(SettingsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(VoicemailsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(CallbacksPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(ContactsPage)] = ("message_sent.png", "message_failed.png"),
            [nameof(MoreTabsPage)] = ("message_sent.png", "dotsblue.png"),
            ["ContactsTabPage"] = ("message_sent.png", "message_failed.png"),
        };

        public static List<ShellContent> GenerateTabs()
        {
            return new List<ShellContent>
            {
                GenerateShellContent("Active Calls", "ActiveCallsPage", "message_failed.png", typeof(ActiveCallsPage)),
                GenerateShellContent("Recorded Calls", "RecordedCallsPage", "message_failed.png", typeof(RecordedCallsPage)),
                GenerateShellContent("Callbacks", "CallbacksPage", "message_failed.png", typeof(CallbacksPage)),
                GenerateShellContent("More", "MoreTabsPage", "dotsblue.png", typeof(MoreTabsPage)),
                GenerateShellContent("CallLogs", "CallLogsPage", "message_sent.png", typeof(CallLogsPage)),
                GenerateShellContent("Messages", "MessagesPage", "message_sent.png", typeof(MessagesPage)),
                GenerateShellContent("Voicemails", "VoicemailsPage", "message_sent.png", typeof(VoicemailsPage)),
            };

        }

        public static void GenerateMoreTabs()
        {
            MoreTabs = new List<MoreTab>
            {
                new MoreTab("CallLogs", "CallLogsPage", "message_sent.png", typeof(CallLogsPage)),
                new MoreTab("Messages", "MessagesPage", "message_sent.png", typeof(MessagesPage)),
                new MoreTab("Voicemails", "VoicemailsPage", "message_sent.png", typeof(VoicemailsPage)),
            };
        }

        private static ShellContent GenerateShellContent(string title, string route, string icon, Type pageType)
        {
            ImageSource tempicon = icon;

            if (TabbarIconsMap.TryGetValue(route, out var icons))
            {
                tempicon = icons.UnselectedIcon;
            }

            return new ShellContent
            {
                Title = title,
                Route = route,
                Icon = tempicon,

                ContentTemplate = new DataTemplate(pageType)
            };
        }
    }

    public partial class MoreTab : ObservableObject
    {
        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public ImageSource icon;

        [ObservableProperty]
        public string route;

        [ObservableProperty]
        public Type pageType;

        [ObservableProperty]
        public bool notification = false;

        public MoreTab(string title, string route, string icon, Type pageType)
        {
            Title = title;
            Route = route;
            Icon = icon;
            PageType = pageType;
        }
    }
}
