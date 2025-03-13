using DotNET9Test.ViewModels.Tabs;

namespace DotNET9Test.Views.Tabs;

public partial class MoreTabsPage : ContentPage
{
	public MoreTabsPage(MoreTabsViewModel moreTabsViewModel)
	{
		InitializeComponent();
		BindingContext = moreTabsViewModel;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("More", true);
        }
    }
}