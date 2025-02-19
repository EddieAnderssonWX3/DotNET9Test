using DotNET9Test.Views;
using DotNET9Test.Views.ActiveCalls;
using DotNET9Test.Views.Callbacks;
using DotNET9Test.Views.CallLogs;
using DotNET9Test.Views.CallProfiles;
using DotNET9Test.Views.Contacts;
using DotNET9Test.Views.Messages;
using DotNET9Test.Views.RecordedCalls;
using DotNET9Test.Views.Settings;
using DotNET9Test.Views.Voicemails;

namespace DotNET9Test
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            UserTabBar.Items.Clear();
            CreateTabs();
        }

        public async Task ReOrderTabBar()
        {
            var TabBarItems = UserTabBar.Items.Reverse().ToList();
            UserTabBar.Items.Clear();
            UserTabBar.Items.Add(TabBarItems[0]);
            await Task.Delay(10);
            UserTabBar.Items.Clear();

            foreach (var i in TabBarItems)
            {
                UserTabBar.Items.Add(i);
            }
        }

        private void CreateTabs()
        {
            // Add tabs dynamically
            UserTabBar.Items.Add(CreateTab("ActiveCalls", "dotnet_bot.png", typeof(ActiveCallsPage)));
            UserTabBar.Items.Add(CreateTab("Callbacks", "dotnet_bot.png", typeof(CallbacksPage)));
            UserTabBar.Items.Add(CreateTab("CallLogs", "dotnet_bot.png", typeof(CallLogsPage)));
            UserTabBar.Items.Add(CreateTab("CallProfiles", "dotnet_bot.png", typeof(CallProfilesPage)));
            UserTabBar.Items.Add(CreateTab("Contacts", "dotnet_bot.png", typeof(ContactsPage)));
            UserTabBar.Items.Add(CreateTab("Messages", "dotnet_bot.png", typeof(MessagesPage)));
            UserTabBar.Items.Add(CreateTab("RecordedCalls", "dotnet_bot.png", typeof(RecordedCallsPage)));
            UserTabBar.Items.Add(CreateTab("Settings", "dotnet_bot.png", typeof(SettingsPage)));
            UserTabBar.Items.Add(CreateTab("Voicemails", "dotnet_bot.png", typeof(VoicemailsPage)));
        }

        private Tab CreateTab(string title, string icon, Type pageType)
        {
            return new Tab
            {
                Title = title,
                Icon = icon,
                Items =
            {
                new ShellContent
                {
                    ContentTemplate = new DataTemplate(pageType)
                }
            }
            };
        }
    }
}
