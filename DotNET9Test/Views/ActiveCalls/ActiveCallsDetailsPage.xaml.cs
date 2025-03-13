namespace DotNET9Test.Views.ActiveCalls;

public partial class ActiveCallsDetailsPage : ContentPage
{
	public ActiveCallsDetailsPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Active Calls Details Page", false);
        }
    }
}