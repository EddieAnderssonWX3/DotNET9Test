using DotNET9Test.ViewModels.CallProfiles;

namespace DotNET9Test.Views.CallProfiles;

public partial class CallProfilesPage : ContentPage
{
	public CallProfilesPage(CallProfilesPageViewModel callProfilesPageViewModel)
	{
		InitializeComponent();
        BindingContext = callProfilesPageViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Call Profiles", true);
        }
    }
}