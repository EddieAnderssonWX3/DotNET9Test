using CommunityToolkit.Maui;
using DotNET9Test.ViewModels;
using DotNET9Test.ViewModels.ActiveCalls;
using DotNET9Test.ViewModels.Callbacks;
using DotNET9Test.ViewModels.CallLogs;
using DotNET9Test.ViewModels.CallProfiles;
using DotNET9Test.ViewModels.Contacts;
using DotNET9Test.ViewModels.Messages;
using DotNET9Test.ViewModels.RecordedCalls;
using DotNET9Test.ViewModels.Settings;
using DotNET9Test.ViewModels.Voicemails;
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
using Microsoft.Extensions.Logging;

namespace DotNET9Test
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingletonWithShellRoute<ActiveCallsPage, ActiveCallsPageViewModel>("ActiveCallsPage");
            builder.Services.AddSingletonWithShellRoute<CallbacksPage, CallbacksPageViewModel>("CallbacksPage");
            builder.Services.AddSingletonWithShellRoute<CallLogsPage, CallLogsPageViewModel>("CallLogsPage");
            builder.Services.AddSingletonWithShellRoute<CallProfilesPage, CallProfilesPageViewModel>("CallProfilesPage");
            builder.Services.AddSingletonWithShellRoute<ContactsPage, ContactsPageViewModel>("ContactsPage");
            builder.Services.AddSingletonWithShellRoute<MessagesPage, MessagesPageViewModel>("MessagesPage");
            builder.Services.AddSingletonWithShellRoute<RecordedCallsPage, RecordedCallsPageViewModel>("RecordedCallsPage");
            builder.Services.AddSingletonWithShellRoute<SettingsPage, SettingsPageViewModel>("SettingsPage");
            builder.Services.AddSingletonWithShellRoute<VoicemailsPage, VoicemailsPageViewModel>("VoicemailsPage");
            builder.Services.AddSingletonWithShellRoute<LoadingPage, LoadingPageViewModel>("LoadingPage");



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
