using DotNET9Test.ViewModels.Voicemails;

namespace DotNET9Test.Views.Voicemails;

public partial class VoicemailsPage : ContentPage
{
	public VoicemailsPage(VoicemailsPageViewModel voicemailsPageViewModel)
	{
		InitializeComponent();
        BindingContext = voicemailsPageViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Voicemails", true);
        }
    }
}