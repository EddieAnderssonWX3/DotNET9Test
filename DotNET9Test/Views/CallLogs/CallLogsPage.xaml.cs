using DotNET9Test.ViewModels.CallLogs;

namespace DotNET9Test.Views.CallLogs;

public partial class CallLogsPage : ContentPage
{
	public CallLogsPage(CallLogsPageViewModel callLogsPageViewModel)
	{
		InitializeComponent();
        BindingContext = callLogsPageViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Call Logs", true);
        }
    }
}