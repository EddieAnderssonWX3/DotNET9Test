using DotNET9Test.ViewModels.RecordedCalls;

namespace DotNET9Test.Views.RecordedCalls;

public partial class RecordedCallsPage : ContentPage
{
	public RecordedCallsPage(RecordedCallsPageViewModel recordedCallsPageViewModel)
	{
		InitializeComponent();
        BindingContext = recordedCallsPageViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Recorded Calls", true);
        }
    }
}