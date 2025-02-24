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
            // Step 1: Create a placeholder item
            var placeholderTab = CreateTab("LoadingPage", "dotnet_bot.png", typeof(LoadingPage));

            // Step 2: Add the placeholder at index 0
            UserTabBar.Items.Insert(0, placeholderTab);

            // Step 3: Capture existing tabs in reverse order (excluding the placeholder)
            var TabBarItems = UserTabBar.Items.Skip(1).Reverse().ToList();

            // Step 4: Remove all items except the placeholder
            while (UserTabBar.Items.Count > 1)
            {
                UserTabBar.Items.RemoveAt(1); // Always remove the second item (index 1)
            }

            await Task.Delay(100);

            // Step 5: Re-add all tabs in reverse order
            foreach (var i in TabBarItems)
            {
                UserTabBar.Items.Add(i);
            }

            // Step 6: Remove the placeholder tab
            UserTabBar.Items.Remove(placeholderTab);
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
